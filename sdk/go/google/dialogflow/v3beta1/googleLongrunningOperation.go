// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v3beta1

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Creates an Environment in the specified Agent.
type GoogleLongrunningOperation struct {
	pulumi.CustomResourceState
}

// NewGoogleLongrunningOperation registers a new resource with the given unique name, arguments, and options.
func NewGoogleLongrunningOperation(ctx *pulumi.Context,
	name string, args *GoogleLongrunningOperationArgs, opts ...pulumi.ResourceOption) (*GoogleLongrunningOperation, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Parent == nil {
		return nil, errors.New("invalid value for required argument 'Parent'")
	}
	var resource GoogleLongrunningOperation
	err := ctx.RegisterResource("google-cloud:dialogflow/v3beta1:GoogleLongrunningOperation", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetGoogleLongrunningOperation gets an existing GoogleLongrunningOperation resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetGoogleLongrunningOperation(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *GoogleLongrunningOperationState, opts ...pulumi.ResourceOption) (*GoogleLongrunningOperation, error) {
	var resource GoogleLongrunningOperation
	err := ctx.ReadResource("google-cloud:dialogflow/v3beta1:GoogleLongrunningOperation", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering GoogleLongrunningOperation resources.
type googleLongrunningOperationState struct {
}

type GoogleLongrunningOperationState struct {
}

func (GoogleLongrunningOperationState) ElementType() reflect.Type {
	return reflect.TypeOf((*googleLongrunningOperationState)(nil)).Elem()
}

type googleLongrunningOperationArgs struct {
	// The human-readable description of the environment. The maximum length is 500 characters. If exceeded, the request is rejected.
	Description *string `pulumi:"description"`
	// Required. The human-readable name of the environment (unique in an agent). Limit of 64 characters.
	DisplayName *string `pulumi:"displayName"`
	// The name of the environment. Format: `projects//locations//agents//environments/`.
	Name *string `pulumi:"name"`
	// Required. The Agent to create an Environment for. Format: `projects//locations//agents/`.
	Parent string `pulumi:"parent"`
	// Output only. Update time of this environment.
	UpdateTime *string `pulumi:"updateTime"`
	// Required. A list of configurations for flow versions. You should include version configs for all flows that are reachable from `Start Flow` in the agent. Otherwise, an error will be returned.
	VersionConfigs []GoogleCloudDialogflowCxV3beta1EnvironmentVersionConfig `pulumi:"versionConfigs"`
}

// The set of arguments for constructing a GoogleLongrunningOperation resource.
type GoogleLongrunningOperationArgs struct {
	// The human-readable description of the environment. The maximum length is 500 characters. If exceeded, the request is rejected.
	Description pulumi.StringPtrInput
	// Required. The human-readable name of the environment (unique in an agent). Limit of 64 characters.
	DisplayName pulumi.StringPtrInput
	// The name of the environment. Format: `projects//locations//agents//environments/`.
	Name pulumi.StringPtrInput
	// Required. The Agent to create an Environment for. Format: `projects//locations//agents/`.
	Parent pulumi.StringInput
	// Output only. Update time of this environment.
	UpdateTime pulumi.StringPtrInput
	// Required. A list of configurations for flow versions. You should include version configs for all flows that are reachable from `Start Flow` in the agent. Otherwise, an error will be returned.
	VersionConfigs GoogleCloudDialogflowCxV3beta1EnvironmentVersionConfigArrayInput
}

func (GoogleLongrunningOperationArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*googleLongrunningOperationArgs)(nil)).Elem()
}

type GoogleLongrunningOperationInput interface {
	pulumi.Input

	ToGoogleLongrunningOperationOutput() GoogleLongrunningOperationOutput
	ToGoogleLongrunningOperationOutputWithContext(ctx context.Context) GoogleLongrunningOperationOutput
}

func (*GoogleLongrunningOperation) ElementType() reflect.Type {
	return reflect.TypeOf((*GoogleLongrunningOperation)(nil))
}

func (i *GoogleLongrunningOperation) ToGoogleLongrunningOperationOutput() GoogleLongrunningOperationOutput {
	return i.ToGoogleLongrunningOperationOutputWithContext(context.Background())
}

func (i *GoogleLongrunningOperation) ToGoogleLongrunningOperationOutputWithContext(ctx context.Context) GoogleLongrunningOperationOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GoogleLongrunningOperationOutput)
}

type GoogleLongrunningOperationOutput struct {
	*pulumi.OutputState
}

func (GoogleLongrunningOperationOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GoogleLongrunningOperation)(nil))
}

func (o GoogleLongrunningOperationOutput) ToGoogleLongrunningOperationOutput() GoogleLongrunningOperationOutput {
	return o
}

func (o GoogleLongrunningOperationOutput) ToGoogleLongrunningOperationOutputWithContext(ctx context.Context) GoogleLongrunningOperationOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(GoogleLongrunningOperationOutput{})
}