// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

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
	case "google-native:healthcare/v1:AttributeDefinition":
		r = &AttributeDefinition{}
	case "google-native:healthcare/v1:Consent":
		r = &Consent{}
	case "google-native:healthcare/v1:ConsentArtifact":
		r = &ConsentArtifact{}
	case "google-native:healthcare/v1:ConsentStore":
		r = &ConsentStore{}
	case "google-native:healthcare/v1:Dataset":
		r = &Dataset{}
	case "google-native:healthcare/v1:DatasetConsentStoreIamPolicy":
		r = &DatasetConsentStoreIamPolicy{}
	case "google-native:healthcare/v1:DatasetDicomStoreIamPolicy":
		r = &DatasetDicomStoreIamPolicy{}
	case "google-native:healthcare/v1:DatasetFhirStoreIamPolicy":
		r = &DatasetFhirStoreIamPolicy{}
	case "google-native:healthcare/v1:DatasetHl7V2StoreIamPolicy":
		r = &DatasetHl7V2StoreIamPolicy{}
	case "google-native:healthcare/v1:DatasetIamPolicy":
		r = &DatasetIamPolicy{}
	case "google-native:healthcare/v1:DicomStore":
		r = &DicomStore{}
	case "google-native:healthcare/v1:FhirStore":
		r = &FhirStore{}
	case "google-native:healthcare/v1:Hl7V2Store":
		r = &Hl7V2Store{}
	case "google-native:healthcare/v1:Message":
		r = &Message{}
	case "google-native:healthcare/v1:UserDataMapping":
		r = &UserDataMapping{}
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
		"healthcare/v1",
		&module{version},
	)
}