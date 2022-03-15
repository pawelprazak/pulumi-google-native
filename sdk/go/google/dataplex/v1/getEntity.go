// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Get a metadata entity.
func LookupEntity(ctx *pulumi.Context, args *LookupEntityArgs, opts ...pulumi.InvokeOption) (*LookupEntityResult, error) {
	var rv LookupEntityResult
	err := ctx.Invoke("google-native:dataplex/v1:getEntity", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupEntityArgs struct {
	EntityId string  `pulumi:"entityId"`
	LakeId   string  `pulumi:"lakeId"`
	Location string  `pulumi:"location"`
	Project  *string `pulumi:"project"`
	View     *string `pulumi:"view"`
	Zone     string  `pulumi:"zone"`
}

type LookupEntityResult struct {
	// Immutable. The ID of the asset associated with the storage location containing the entity data. The entity must be with in the same zone with the asset.
	Asset string `pulumi:"asset"`
	// The name of the associated Data Catalog entry.
	CatalogEntry string `pulumi:"catalogEntry"`
	// Metadata stores that the entity is compatible with.
	Compatibility GoogleCloudDataplexV1EntityCompatibilityStatusResponse `pulumi:"compatibility"`
	// The time when the entity was created.
	CreateTime string `pulumi:"createTime"`
	// Immutable. The storage path of the entity data. For Cloud Storage data, this is the fully-qualified path to the entity, such as gs://bucket/path/to/data. For BigQuery data, this is the name of the table resource, such as projects/project_id/datasets/dataset_id/tables/table_id.
	DataPath string `pulumi:"dataPath"`
	// Optional. The set of items within the data path constituting the data in the entity, represented as a glob path. Example: gs://bucket/path/to/data/**/*.csv.
	DataPathPattern string `pulumi:"dataPathPattern"`
	// Optional. User friendly longer description text. Must be shorter than or equal to 1024 characters.
	Description string `pulumi:"description"`
	// Optional. Display name must be shorter than or equal to 256 characters.
	DisplayName string `pulumi:"displayName"`
	// Optional. The etag associated with the entity, which can be retrieved with a GetEntity request. Required for update and delete requests.
	Etag string `pulumi:"etag"`
	// Identifies the storage format of the entity data. It does not apply to entities with data stored in BigQuery.
	Format GoogleCloudDataplexV1StorageFormatResponse `pulumi:"format"`
	// The resource name of the entity, of the form: projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{id}.
	Name string `pulumi:"name"`
	// The description of the data structure and layout. The schema is not included in list responses. It is only included in SCHEMA and FULL entity views of a GetEntity response.
	Schema GoogleCloudDataplexV1SchemaResponse `pulumi:"schema"`
	// Immutable. Identifies the storage system of the entity data.
	System string `pulumi:"system"`
	// Immutable. The type of entity.
	Type string `pulumi:"type"`
	// The time when the entity was last updated.
	UpdateTime string `pulumi:"updateTime"`
}

func LookupEntityOutput(ctx *pulumi.Context, args LookupEntityOutputArgs, opts ...pulumi.InvokeOption) LookupEntityResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupEntityResult, error) {
			args := v.(LookupEntityArgs)
			r, err := LookupEntity(ctx, &args, opts...)
			return *r, err
		}).(LookupEntityResultOutput)
}

type LookupEntityOutputArgs struct {
	EntityId pulumi.StringInput    `pulumi:"entityId"`
	LakeId   pulumi.StringInput    `pulumi:"lakeId"`
	Location pulumi.StringInput    `pulumi:"location"`
	Project  pulumi.StringPtrInput `pulumi:"project"`
	View     pulumi.StringPtrInput `pulumi:"view"`
	Zone     pulumi.StringInput    `pulumi:"zone"`
}

func (LookupEntityOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupEntityArgs)(nil)).Elem()
}

type LookupEntityResultOutput struct{ *pulumi.OutputState }

func (LookupEntityResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupEntityResult)(nil)).Elem()
}

func (o LookupEntityResultOutput) ToLookupEntityResultOutput() LookupEntityResultOutput {
	return o
}

func (o LookupEntityResultOutput) ToLookupEntityResultOutputWithContext(ctx context.Context) LookupEntityResultOutput {
	return o
}

// Immutable. The ID of the asset associated with the storage location containing the entity data. The entity must be with in the same zone with the asset.
func (o LookupEntityResultOutput) Asset() pulumi.StringOutput {
	return o.ApplyT(func(v LookupEntityResult) string { return v.Asset }).(pulumi.StringOutput)
}

// The name of the associated Data Catalog entry.
func (o LookupEntityResultOutput) CatalogEntry() pulumi.StringOutput {
	return o.ApplyT(func(v LookupEntityResult) string { return v.CatalogEntry }).(pulumi.StringOutput)
}

// Metadata stores that the entity is compatible with.
func (o LookupEntityResultOutput) Compatibility() GoogleCloudDataplexV1EntityCompatibilityStatusResponseOutput {
	return o.ApplyT(func(v LookupEntityResult) GoogleCloudDataplexV1EntityCompatibilityStatusResponse {
		return v.Compatibility
	}).(GoogleCloudDataplexV1EntityCompatibilityStatusResponseOutput)
}

// The time when the entity was created.
func (o LookupEntityResultOutput) CreateTime() pulumi.StringOutput {
	return o.ApplyT(func(v LookupEntityResult) string { return v.CreateTime }).(pulumi.StringOutput)
}

// Immutable. The storage path of the entity data. For Cloud Storage data, this is the fully-qualified path to the entity, such as gs://bucket/path/to/data. For BigQuery data, this is the name of the table resource, such as projects/project_id/datasets/dataset_id/tables/table_id.
func (o LookupEntityResultOutput) DataPath() pulumi.StringOutput {
	return o.ApplyT(func(v LookupEntityResult) string { return v.DataPath }).(pulumi.StringOutput)
}

// Optional. The set of items within the data path constituting the data in the entity, represented as a glob path. Example: gs://bucket/path/to/data/**/*.csv.
func (o LookupEntityResultOutput) DataPathPattern() pulumi.StringOutput {
	return o.ApplyT(func(v LookupEntityResult) string { return v.DataPathPattern }).(pulumi.StringOutput)
}

// Optional. User friendly longer description text. Must be shorter than or equal to 1024 characters.
func (o LookupEntityResultOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v LookupEntityResult) string { return v.Description }).(pulumi.StringOutput)
}

// Optional. Display name must be shorter than or equal to 256 characters.
func (o LookupEntityResultOutput) DisplayName() pulumi.StringOutput {
	return o.ApplyT(func(v LookupEntityResult) string { return v.DisplayName }).(pulumi.StringOutput)
}

// Optional. The etag associated with the entity, which can be retrieved with a GetEntity request. Required for update and delete requests.
func (o LookupEntityResultOutput) Etag() pulumi.StringOutput {
	return o.ApplyT(func(v LookupEntityResult) string { return v.Etag }).(pulumi.StringOutput)
}

// Identifies the storage format of the entity data. It does not apply to entities with data stored in BigQuery.
func (o LookupEntityResultOutput) Format() GoogleCloudDataplexV1StorageFormatResponseOutput {
	return o.ApplyT(func(v LookupEntityResult) GoogleCloudDataplexV1StorageFormatResponse { return v.Format }).(GoogleCloudDataplexV1StorageFormatResponseOutput)
}

// The resource name of the entity, of the form: projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{id}.
func (o LookupEntityResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupEntityResult) string { return v.Name }).(pulumi.StringOutput)
}

// The description of the data structure and layout. The schema is not included in list responses. It is only included in SCHEMA and FULL entity views of a GetEntity response.
func (o LookupEntityResultOutput) Schema() GoogleCloudDataplexV1SchemaResponseOutput {
	return o.ApplyT(func(v LookupEntityResult) GoogleCloudDataplexV1SchemaResponse { return v.Schema }).(GoogleCloudDataplexV1SchemaResponseOutput)
}

// Immutable. Identifies the storage system of the entity data.
func (o LookupEntityResultOutput) System() pulumi.StringOutput {
	return o.ApplyT(func(v LookupEntityResult) string { return v.System }).(pulumi.StringOutput)
}

// Immutable. The type of entity.
func (o LookupEntityResultOutput) Type() pulumi.StringOutput {
	return o.ApplyT(func(v LookupEntityResult) string { return v.Type }).(pulumi.StringOutput)
}

// The time when the entity was last updated.
func (o LookupEntityResultOutput) UpdateTime() pulumi.StringOutput {
	return o.ApplyT(func(v LookupEntityResult) string { return v.UpdateTime }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupEntityResultOutput{})
}