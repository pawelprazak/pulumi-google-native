// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v3

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Creates a session entity type.
type GoogleCloudDialogflowCxV3SessionEntityType struct {
	pulumi.CustomResourceState
}

// NewGoogleCloudDialogflowCxV3SessionEntityType registers a new resource with the given unique name, arguments, and options.
func NewGoogleCloudDialogflowCxV3SessionEntityType(ctx *pulumi.Context,
	name string, args *GoogleCloudDialogflowCxV3SessionEntityTypeArgs, opts ...pulumi.ResourceOption) (*GoogleCloudDialogflowCxV3SessionEntityType, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Parent == nil {
		return nil, errors.New("invalid value for required argument 'Parent'")
	}
	var resource GoogleCloudDialogflowCxV3SessionEntityType
	err := ctx.RegisterResource("google-cloud:dialogflow/v3:GoogleCloudDialogflowCxV3SessionEntityType", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetGoogleCloudDialogflowCxV3SessionEntityType gets an existing GoogleCloudDialogflowCxV3SessionEntityType resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetGoogleCloudDialogflowCxV3SessionEntityType(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *GoogleCloudDialogflowCxV3SessionEntityTypeState, opts ...pulumi.ResourceOption) (*GoogleCloudDialogflowCxV3SessionEntityType, error) {
	var resource GoogleCloudDialogflowCxV3SessionEntityType
	err := ctx.ReadResource("google-cloud:dialogflow/v3:GoogleCloudDialogflowCxV3SessionEntityType", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering GoogleCloudDialogflowCxV3SessionEntityType resources.
type googleCloudDialogflowCxV3SessionEntityTypeState struct {
}

type GoogleCloudDialogflowCxV3SessionEntityTypeState struct {
}

func (GoogleCloudDialogflowCxV3SessionEntityTypeState) ElementType() reflect.Type {
	return reflect.TypeOf((*googleCloudDialogflowCxV3SessionEntityTypeState)(nil)).Elem()
}

type googleCloudDialogflowCxV3SessionEntityTypeArgs struct {
	// Required. The collection of entities to override or supplement the custom entity type.
	Entities []GoogleCloudDialogflowCxV3EntityTypeEntity `pulumi:"entities"`
	// Required. Indicates whether the additional data should override or supplement the custom entity type definition.
	EntityOverrideMode *string `pulumi:"entityOverrideMode"`
	// Required. The unique identifier of the session entity type. Format: `projects//locations//agents//sessions//entityTypes/` or `projects//locations//agents//environments//sessions//entityTypes/`. If `Environment ID` is not specified, we assume default 'draft' environment.
	Name *string `pulumi:"name"`
	// Required. The session to create a session entity type for. Format: `projects//locations//agents//sessions/` or `projects//locations//agents//environments//sessions/`. If `Environment ID` is not specified, we assume default 'draft' environment.
	Parent string `pulumi:"parent"`
}

// The set of arguments for constructing a GoogleCloudDialogflowCxV3SessionEntityType resource.
type GoogleCloudDialogflowCxV3SessionEntityTypeArgs struct {
	// Required. The collection of entities to override or supplement the custom entity type.
	Entities GoogleCloudDialogflowCxV3EntityTypeEntityArrayInput
	// Required. Indicates whether the additional data should override or supplement the custom entity type definition.
	EntityOverrideMode pulumi.StringPtrInput
	// Required. The unique identifier of the session entity type. Format: `projects//locations//agents//sessions//entityTypes/` or `projects//locations//agents//environments//sessions//entityTypes/`. If `Environment ID` is not specified, we assume default 'draft' environment.
	Name pulumi.StringPtrInput
	// Required. The session to create a session entity type for. Format: `projects//locations//agents//sessions/` or `projects//locations//agents//environments//sessions/`. If `Environment ID` is not specified, we assume default 'draft' environment.
	Parent pulumi.StringInput
}

func (GoogleCloudDialogflowCxV3SessionEntityTypeArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*googleCloudDialogflowCxV3SessionEntityTypeArgs)(nil)).Elem()
}

type GoogleCloudDialogflowCxV3SessionEntityTypeInput interface {
	pulumi.Input

	ToGoogleCloudDialogflowCxV3SessionEntityTypeOutput() GoogleCloudDialogflowCxV3SessionEntityTypeOutput
	ToGoogleCloudDialogflowCxV3SessionEntityTypeOutputWithContext(ctx context.Context) GoogleCloudDialogflowCxV3SessionEntityTypeOutput
}

func (*GoogleCloudDialogflowCxV3SessionEntityType) ElementType() reflect.Type {
	return reflect.TypeOf((*GoogleCloudDialogflowCxV3SessionEntityType)(nil))
}

func (i *GoogleCloudDialogflowCxV3SessionEntityType) ToGoogleCloudDialogflowCxV3SessionEntityTypeOutput() GoogleCloudDialogflowCxV3SessionEntityTypeOutput {
	return i.ToGoogleCloudDialogflowCxV3SessionEntityTypeOutputWithContext(context.Background())
}

func (i *GoogleCloudDialogflowCxV3SessionEntityType) ToGoogleCloudDialogflowCxV3SessionEntityTypeOutputWithContext(ctx context.Context) GoogleCloudDialogflowCxV3SessionEntityTypeOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GoogleCloudDialogflowCxV3SessionEntityTypeOutput)
}

type GoogleCloudDialogflowCxV3SessionEntityTypeOutput struct {
	*pulumi.OutputState
}

func (GoogleCloudDialogflowCxV3SessionEntityTypeOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GoogleCloudDialogflowCxV3SessionEntityType)(nil))
}

func (o GoogleCloudDialogflowCxV3SessionEntityTypeOutput) ToGoogleCloudDialogflowCxV3SessionEntityTypeOutput() GoogleCloudDialogflowCxV3SessionEntityTypeOutput {
	return o
}

func (o GoogleCloudDialogflowCxV3SessionEntityTypeOutput) ToGoogleCloudDialogflowCxV3SessionEntityTypeOutputWithContext(ctx context.Context) GoogleCloudDialogflowCxV3SessionEntityTypeOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(GoogleCloudDialogflowCxV3SessionEntityTypeOutput{})
}