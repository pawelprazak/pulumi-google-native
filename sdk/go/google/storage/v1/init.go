// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v1

import (
	"fmt"

	"github.com/blang/semver"
	"github.com/pulumi/pulumi-google-native/sdk/go/google"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type module struct {
	version semver.Version
}

func (m *module) Version() semver.Version {
	return m.version
}

func (m *module) Construct(ctx *pulumi.Context, name, typ, urn string) (r pulumi.Resource, err error) {
	switch typ {
	case "google-native:storage/v1:Bucket":
		r = &Bucket{}
	case "google-native:storage/v1:BucketAccessControl":
		r = &BucketAccessControl{}
	case "google-native:storage/v1:BucketIamPolicy":
		r = &BucketIamPolicy{}
	case "google-native:storage/v1:BucketObject":
		r = &BucketObject{}
	case "google-native:storage/v1:DefaultObjectAccessControl":
		r = &DefaultObjectAccessControl{}
	case "google-native:storage/v1:HmacKey":
		r = &HmacKey{}
	case "google-native:storage/v1:Notification":
		r = &Notification{}
	case "google-native:storage/v1:ObjectAccessControl":
		r = &ObjectAccessControl{}
	case "google-native:storage/v1:ObjectIamPolicy":
		r = &ObjectIamPolicy{}
	default:
		return nil, fmt.Errorf("unknown resource type: %s", typ)
	}

	err = ctx.RegisterResource(typ, name, nil, r, pulumi.URN_(urn))
	return
}

func init() {
	version, err := google.PkgVersion()
	if err != nil {
		version = semver.Version{Major: 1}
	}
	pulumi.RegisterResourceModule(
		"google-native",
		"storage/v1",
		&module{version},
	)
}
