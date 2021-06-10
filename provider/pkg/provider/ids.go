// Copyright 2016-2021, Pulumi Corporation.
package provider

import (
	"fmt"
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi-google-native/provider/pkg/resources"
	"github.com/pulumi/pulumi/sdk/v3/go/common/resource"
	"net/url"
	"strings"
)

func calculateResourceId(res resources.CloudAPIResource, inputs map[string]interface{}, outputs map[string]interface{}) (string, error) {
	if res.IdProperty != "" {
		v, ok := outputs[res.IdProperty].(string)
		if !ok {
			return "", errors.Errorf("ID property %q not found", res.IdProperty)
		}
		return strings.TrimPrefix(v, res.BaseUrl), nil
	}

	id := res.IdPath
	idParams := res.IdParams
	for name, alias := range idParams {
		var propValue string
		if v, has := evalPropertyValue(inputs, alias); has {
			propValue = v
		} else if v, has := evalPropertyValue(outputs, alias); has {
			propValue = v
		}

		if propValue == "" {
			return "", errors.Errorf("property %q/%q not found", name, alias)
		}

		// The name property can sometimes contain multiple segments. We only care about the last one
		// because we flattened the path while building metadata.
		parts := strings.Split(propValue, "/")
		propValue = parts[len(parts)-1]

		id = strings.Replace(id, fmt.Sprintf("{%s}", name), propValue, 1)
	}
	return id, nil
}

func evalPropertyValue(values map[string]interface{}, path string) (string, bool) {
	current := values
	parts := strings.Split(path, ".")
	for idx, part := range parts {
		value := current[part]
		if idx == len(parts) - 1 {
			if str, ok := value.(string); ok {
				return str, true
			}
			return "", false
		}
		childMap, ok := value.(map[string]interface{})
		if !ok {
			return "", false
		}
		current = childMap
	}
	return "", false
}

// buildCreateUrl composes the URL to invoke to create a resource with given inputs.
func buildCreateUrl(res resources.CloudAPIResource, inputs resource.PropertyMap) (string, error) {
	path := res.CreatePath
	queryMap := map[string]string{}
	for _, param := range res.CreateParams {
		sdkName := param.Name
		if param.SdkName != "" {
			sdkName = param.SdkName
		}
		key := resource.PropertyKey(sdkName)
		if !inputs[key].HasValue() {
			continue
		}

		value := inputs[key].StringValue()
		switch param.Location {
		case "path":
			path = strings.Replace(path, fmt.Sprintf("{%s}", param.Name), url.PathEscape(value), 1)
		case "query":
			queryMap[param.Name] = value
		default:
			return "", errors.Errorf("unknown param location %q", param.Location)
		}
	}
	baseUriString := res.ResourceUrl(path)
	uri, err := url.Parse(baseUriString)
	if err != nil {
		return "", errors.Wrapf(err, "parsing resource URL %q", baseUriString)
	}
	query := uri.Query()
	for key, value := range queryMap {
		query.Add(key, value)
	}
	uri.RawQuery = query.Encode()
	return uri.String(), nil
}