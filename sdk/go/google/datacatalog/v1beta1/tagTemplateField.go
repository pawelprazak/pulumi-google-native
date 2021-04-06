// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1beta1

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Creates a field in a tag template. The user should enable the Data Catalog API in the project identified by the `parent` parameter (see [Data Catalog Resource Project](https://cloud.google.com/data-catalog/docs/concepts/resource-project) for more information).
type TagTemplateField struct {
	pulumi.CustomResourceState
}

// NewTagTemplateField registers a new resource with the given unique name, arguments, and options.
func NewTagTemplateField(ctx *pulumi.Context,
	name string, args *TagTemplateFieldArgs, opts ...pulumi.ResourceOption) (*TagTemplateField, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.FieldsId == nil {
		return nil, errors.New("invalid value for required argument 'FieldsId'")
	}
	if args.LocationsId == nil {
		return nil, errors.New("invalid value for required argument 'LocationsId'")
	}
	if args.ProjectsId == nil {
		return nil, errors.New("invalid value for required argument 'ProjectsId'")
	}
	if args.TagTemplatesId == nil {
		return nil, errors.New("invalid value for required argument 'TagTemplatesId'")
	}
	var resource TagTemplateField
	err := ctx.RegisterResource("google-cloud:datacatalog/v1beta1:TagTemplateField", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetTagTemplateField gets an existing TagTemplateField resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetTagTemplateField(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *TagTemplateFieldState, opts ...pulumi.ResourceOption) (*TagTemplateField, error) {
	var resource TagTemplateField
	err := ctx.ReadResource("google-cloud:datacatalog/v1beta1:TagTemplateField", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering TagTemplateField resources.
type tagTemplateFieldState struct {
}

type TagTemplateFieldState struct {
}

func (TagTemplateFieldState) ElementType() reflect.Type {
	return reflect.TypeOf((*tagTemplateFieldState)(nil)).Elem()
}

type tagTemplateFieldArgs struct {
	// The description for this field. Defaults to an empty string.
	Description *string `pulumi:"description"`
	// The display name for this field. Defaults to an empty string.
	DisplayName *string `pulumi:"displayName"`
	FieldsId    string  `pulumi:"fieldsId"`
	// Whether this is a required field. Defaults to false.
	IsRequired  *bool  `pulumi:"isRequired"`
	LocationsId string `pulumi:"locationsId"`
	// The order of this field with respect to other fields in this tag template. A higher value indicates a more important field. The value can be negative. Multiple fields can have the same order, and field orders within a tag do not have to be sequential.
	Order          *int   `pulumi:"order"`
	ProjectsId     string `pulumi:"projectsId"`
	TagTemplatesId string `pulumi:"tagTemplatesId"`
	// Required. The type of value this tag field can contain.
	Type *GoogleCloudDatacatalogV1beta1FieldType `pulumi:"type"`
}

// The set of arguments for constructing a TagTemplateField resource.
type TagTemplateFieldArgs struct {
	// The description for this field. Defaults to an empty string.
	Description pulumi.StringPtrInput
	// The display name for this field. Defaults to an empty string.
	DisplayName pulumi.StringPtrInput
	FieldsId    pulumi.StringInput
	// Whether this is a required field. Defaults to false.
	IsRequired  pulumi.BoolPtrInput
	LocationsId pulumi.StringInput
	// The order of this field with respect to other fields in this tag template. A higher value indicates a more important field. The value can be negative. Multiple fields can have the same order, and field orders within a tag do not have to be sequential.
	Order          pulumi.IntPtrInput
	ProjectsId     pulumi.StringInput
	TagTemplatesId pulumi.StringInput
	// Required. The type of value this tag field can contain.
	Type GoogleCloudDatacatalogV1beta1FieldTypePtrInput
}

func (TagTemplateFieldArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*tagTemplateFieldArgs)(nil)).Elem()
}

type TagTemplateFieldInput interface {
	pulumi.Input

	ToTagTemplateFieldOutput() TagTemplateFieldOutput
	ToTagTemplateFieldOutputWithContext(ctx context.Context) TagTemplateFieldOutput
}

func (*TagTemplateField) ElementType() reflect.Type {
	return reflect.TypeOf((*TagTemplateField)(nil))
}

func (i *TagTemplateField) ToTagTemplateFieldOutput() TagTemplateFieldOutput {
	return i.ToTagTemplateFieldOutputWithContext(context.Background())
}

func (i *TagTemplateField) ToTagTemplateFieldOutputWithContext(ctx context.Context) TagTemplateFieldOutput {
	return pulumi.ToOutputWithContext(ctx, i).(TagTemplateFieldOutput)
}

type TagTemplateFieldOutput struct {
	*pulumi.OutputState
}

func (TagTemplateFieldOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*TagTemplateField)(nil))
}

func (o TagTemplateFieldOutput) ToTagTemplateFieldOutput() TagTemplateFieldOutput {
	return o
}

func (o TagTemplateFieldOutput) ToTagTemplateFieldOutputWithContext(ctx context.Context) TagTemplateFieldOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(TagTemplateFieldOutput{})
}