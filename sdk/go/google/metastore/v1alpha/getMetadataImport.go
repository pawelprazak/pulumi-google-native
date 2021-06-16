// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha

import (
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Gets details of a single import.
func LookupMetadataImport(ctx *pulumi.Context, args *LookupMetadataImportArgs, opts ...pulumi.InvokeOption) (*LookupMetadataImportResult, error) {
	var rv LookupMetadataImportResult
	err := ctx.Invoke("google-native:metastore/v1alpha:getMetadataImport", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupMetadataImportArgs struct {
	Location         string `pulumi:"location"`
	MetadataImportId string `pulumi:"metadataImportId"`
	Project          string `pulumi:"project"`
	ServiceId        string `pulumi:"serviceId"`
}

type LookupMetadataImportResult struct {
	// The time when the metadata import was created.
	CreateTime string `pulumi:"createTime"`
	// Immutable. A database dump from a pre-existing metastore's database.
	DatabaseDump DatabaseDumpResponse `pulumi:"databaseDump"`
	// The description of the metadata import.
	Description string `pulumi:"description"`
	// Immutable. The relative resource name of the metadata import, of the form:projects/{project_number}/locations/{location_id}/services/{service_id}/metadataImports/{metadata_import_id}.
	Name string `pulumi:"name"`
	// The current state of the metadata import.
	State string `pulumi:"state"`
	// The time when the metadata import was last updated.
	UpdateTime string `pulumi:"updateTime"`
}