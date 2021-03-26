// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1beta1

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Creates a tag template. The user should enable the Data Catalog API in the project identified by the `parent` parameter (see [Data Catalog Resource Project](https://cloud.google.com/data-catalog/docs/concepts/resource-project) for more information).
type GoogleCloudDatacatalogV1beta1TagTemplate struct {
	pulumi.CustomResourceState
}

// NewGoogleCloudDatacatalogV1beta1TagTemplate registers a new resource with the given unique name, arguments, and options.
func NewGoogleCloudDatacatalogV1beta1TagTemplate(ctx *pulumi.Context,
	name string, args *GoogleCloudDatacatalogV1beta1TagTemplateArgs, opts ...pulumi.ResourceOption) (*GoogleCloudDatacatalogV1beta1TagTemplate, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Parent == nil {
		return nil, errors.New("invalid value for required argument 'Parent'")
	}
	var resource GoogleCloudDatacatalogV1beta1TagTemplate
	err := ctx.RegisterResource("google-cloud:datacatalog/v1beta1:GoogleCloudDatacatalogV1beta1TagTemplate", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetGoogleCloudDatacatalogV1beta1TagTemplate gets an existing GoogleCloudDatacatalogV1beta1TagTemplate resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetGoogleCloudDatacatalogV1beta1TagTemplate(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *GoogleCloudDatacatalogV1beta1TagTemplateState, opts ...pulumi.ResourceOption) (*GoogleCloudDatacatalogV1beta1TagTemplate, error) {
	var resource GoogleCloudDatacatalogV1beta1TagTemplate
	err := ctx.ReadResource("google-cloud:datacatalog/v1beta1:GoogleCloudDatacatalogV1beta1TagTemplate", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering GoogleCloudDatacatalogV1beta1TagTemplate resources.
type googleCloudDatacatalogV1beta1TagTemplateState struct {
}

type GoogleCloudDatacatalogV1beta1TagTemplateState struct {
}

func (GoogleCloudDatacatalogV1beta1TagTemplateState) ElementType() reflect.Type {
	return reflect.TypeOf((*googleCloudDatacatalogV1beta1TagTemplateState)(nil)).Elem()
}

type googleCloudDatacatalogV1beta1TagTemplateArgs struct {
	// The display name for this template. Defaults to an empty string.
	DisplayName *string `pulumi:"displayName"`
	// Required. Map of tag template field IDs to the settings for the field. This map is an exhaustive list of the allowed fields. This map must contain at least one field and at most 500 fields. The keys to this map are tag template field IDs. Field IDs can contain letters (both uppercase and lowercase), numbers (0-9) and underscores (_). Field IDs must be at least 1 character long and at most 64 characters long. Field IDs must start with a letter or underscore.
	Fields map[string]string `pulumi:"fields"`
	// The resource name of the tag template in URL format. Example: * projects/{project_id}/locations/{location}/tagTemplates/{tag_template_id} Note that this TagTemplate and its child resources may not actually be stored in the location in this name.
	Name *string `pulumi:"name"`
	// Required. The name of the project and the template location [region](https://cloud.google.com/data-catalog/docs/concepts/regions. Example: * projects/{project_id}/locations/us-central1
	Parent string `pulumi:"parent"`
	// Required. The id of the tag template to create.
	TagTemplateId *string `pulumi:"tagTemplateId"`
}

// The set of arguments for constructing a GoogleCloudDatacatalogV1beta1TagTemplate resource.
type GoogleCloudDatacatalogV1beta1TagTemplateArgs struct {
	// The display name for this template. Defaults to an empty string.
	DisplayName pulumi.StringPtrInput
	// Required. Map of tag template field IDs to the settings for the field. This map is an exhaustive list of the allowed fields. This map must contain at least one field and at most 500 fields. The keys to this map are tag template field IDs. Field IDs can contain letters (both uppercase and lowercase), numbers (0-9) and underscores (_). Field IDs must be at least 1 character long and at most 64 characters long. Field IDs must start with a letter or underscore.
	Fields pulumi.StringMapInput
	// The resource name of the tag template in URL format. Example: * projects/{project_id}/locations/{location}/tagTemplates/{tag_template_id} Note that this TagTemplate and its child resources may not actually be stored in the location in this name.
	Name pulumi.StringPtrInput
	// Required. The name of the project and the template location [region](https://cloud.google.com/data-catalog/docs/concepts/regions. Example: * projects/{project_id}/locations/us-central1
	Parent pulumi.StringInput
	// Required. The id of the tag template to create.
	TagTemplateId pulumi.StringPtrInput
}

func (GoogleCloudDatacatalogV1beta1TagTemplateArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*googleCloudDatacatalogV1beta1TagTemplateArgs)(nil)).Elem()
}

type GoogleCloudDatacatalogV1beta1TagTemplateInput interface {
	pulumi.Input

	ToGoogleCloudDatacatalogV1beta1TagTemplateOutput() GoogleCloudDatacatalogV1beta1TagTemplateOutput
	ToGoogleCloudDatacatalogV1beta1TagTemplateOutputWithContext(ctx context.Context) GoogleCloudDatacatalogV1beta1TagTemplateOutput
}

func (*GoogleCloudDatacatalogV1beta1TagTemplate) ElementType() reflect.Type {
	return reflect.TypeOf((*GoogleCloudDatacatalogV1beta1TagTemplate)(nil))
}

func (i *GoogleCloudDatacatalogV1beta1TagTemplate) ToGoogleCloudDatacatalogV1beta1TagTemplateOutput() GoogleCloudDatacatalogV1beta1TagTemplateOutput {
	return i.ToGoogleCloudDatacatalogV1beta1TagTemplateOutputWithContext(context.Background())
}

func (i *GoogleCloudDatacatalogV1beta1TagTemplate) ToGoogleCloudDatacatalogV1beta1TagTemplateOutputWithContext(ctx context.Context) GoogleCloudDatacatalogV1beta1TagTemplateOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GoogleCloudDatacatalogV1beta1TagTemplateOutput)
}

type GoogleCloudDatacatalogV1beta1TagTemplateOutput struct {
	*pulumi.OutputState
}

func (GoogleCloudDatacatalogV1beta1TagTemplateOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GoogleCloudDatacatalogV1beta1TagTemplate)(nil))
}

func (o GoogleCloudDatacatalogV1beta1TagTemplateOutput) ToGoogleCloudDatacatalogV1beta1TagTemplateOutput() GoogleCloudDatacatalogV1beta1TagTemplateOutput {
	return o
}

func (o GoogleCloudDatacatalogV1beta1TagTemplateOutput) ToGoogleCloudDatacatalogV1beta1TagTemplateOutputWithContext(ctx context.Context) GoogleCloudDatacatalogV1beta1TagTemplateOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(GoogleCloudDatacatalogV1beta1TagTemplateOutput{})
}