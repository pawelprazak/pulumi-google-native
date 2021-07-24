// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Adds a new Feature.
// Auto-naming is currently not supported for this resource.
type Feature struct {
	pulumi.CustomResourceState

	// When the Feature resource was created.
	CreateTime pulumi.StringOutput `pulumi:"createTime"`
	// When the Feature resource was deleted.
	DeleteTime pulumi.StringOutput `pulumi:"deleteTime"`
	// GCP labels for this Feature.
	Labels pulumi.StringMapOutput `pulumi:"labels"`
	// Optional. Membership-specific configuration for this Feature. If this Feature does not support any per-Membership configuration, this field may be unused. The keys indicate which Membership the configuration is for, in the form: `projects/{p}/locations/{l}/memberships/{m}` Where {p} is the project, {l} is a valid location and {m} is a valid Membership in this project at that location. {p} WILL match the Feature's project. {p} will always be returned as the project number, but the project ID is also accepted during input. If the same Membership is specified in the map twice (using the project ID form, and the project number form), exactly ONE of the entries will be saved, with no guarantees as to which. For this reason, it is recommended the same format be used for all entries when mutating a Feature.
	MembershipSpecs pulumi.StringMapOutput `pulumi:"membershipSpecs"`
	// Membership-specific Feature status. If this Feature does report any per-Membership status, this field may be unused. The keys indicate which Membership the state is for, in the form: `projects/{p}/locations/{l}/memberships/{m}` Where {p} is the project number, {l} is a valid location and {m} is a valid Membership in this project at that location. {p} MUST match the Feature's project number.
	MembershipStates pulumi.StringMapOutput `pulumi:"membershipStates"`
	// The full, unique name of this Feature resource in the format `projects/*/locations/*/features/*`.
	Name pulumi.StringOutput `pulumi:"name"`
	// State of the Feature resource itself.
	ResourceState FeatureResourceStateResponseOutput `pulumi:"resourceState"`
	// Optional. Hub-wide Feature configuration. If this Feature does not support any Hub-wide configuration, this field may be unused.
	Spec CommonFeatureSpecResponseOutput `pulumi:"spec"`
	// The Hub-wide Feature state.
	State CommonFeatureStateResponseOutput `pulumi:"state"`
	// When the Feature resource was last updated.
	UpdateTime pulumi.StringOutput `pulumi:"updateTime"`
}

// NewFeature registers a new resource with the given unique name, arguments, and options.
func NewFeature(ctx *pulumi.Context,
	name string, args *FeatureArgs, opts ...pulumi.ResourceOption) (*Feature, error) {
	if args == nil {
		args = &FeatureArgs{}
	}

	var resource Feature
	err := ctx.RegisterResource("google-native:gkehub/v1:Feature", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetFeature gets an existing Feature resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetFeature(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *FeatureState, opts ...pulumi.ResourceOption) (*Feature, error) {
	var resource Feature
	err := ctx.ReadResource("google-native:gkehub/v1:Feature", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Feature resources.
type featureState struct {
}

type FeatureState struct {
}

func (FeatureState) ElementType() reflect.Type {
	return reflect.TypeOf((*featureState)(nil)).Elem()
}

type featureArgs struct {
	FeatureId *string `pulumi:"featureId"`
	// GCP labels for this Feature.
	Labels   map[string]string `pulumi:"labels"`
	Location *string           `pulumi:"location"`
	// Optional. Membership-specific configuration for this Feature. If this Feature does not support any per-Membership configuration, this field may be unused. The keys indicate which Membership the configuration is for, in the form: `projects/{p}/locations/{l}/memberships/{m}` Where {p} is the project, {l} is a valid location and {m} is a valid Membership in this project at that location. {p} WILL match the Feature's project. {p} will always be returned as the project number, but the project ID is also accepted during input. If the same Membership is specified in the map twice (using the project ID form, and the project number form), exactly ONE of the entries will be saved, with no guarantees as to which. For this reason, it is recommended the same format be used for all entries when mutating a Feature.
	MembershipSpecs map[string]string `pulumi:"membershipSpecs"`
	Project         *string           `pulumi:"project"`
	RequestId       *string           `pulumi:"requestId"`
	// Optional. Hub-wide Feature configuration. If this Feature does not support any Hub-wide configuration, this field may be unused.
	Spec *CommonFeatureSpec `pulumi:"spec"`
}

// The set of arguments for constructing a Feature resource.
type FeatureArgs struct {
	FeatureId pulumi.StringPtrInput
	// GCP labels for this Feature.
	Labels   pulumi.StringMapInput
	Location pulumi.StringPtrInput
	// Optional. Membership-specific configuration for this Feature. If this Feature does not support any per-Membership configuration, this field may be unused. The keys indicate which Membership the configuration is for, in the form: `projects/{p}/locations/{l}/memberships/{m}` Where {p} is the project, {l} is a valid location and {m} is a valid Membership in this project at that location. {p} WILL match the Feature's project. {p} will always be returned as the project number, but the project ID is also accepted during input. If the same Membership is specified in the map twice (using the project ID form, and the project number form), exactly ONE of the entries will be saved, with no guarantees as to which. For this reason, it is recommended the same format be used for all entries when mutating a Feature.
	MembershipSpecs pulumi.StringMapInput
	Project         pulumi.StringPtrInput
	RequestId       pulumi.StringPtrInput
	// Optional. Hub-wide Feature configuration. If this Feature does not support any Hub-wide configuration, this field may be unused.
	Spec CommonFeatureSpecPtrInput
}

func (FeatureArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*featureArgs)(nil)).Elem()
}

type FeatureInput interface {
	pulumi.Input

	ToFeatureOutput() FeatureOutput
	ToFeatureOutputWithContext(ctx context.Context) FeatureOutput
}

func (*Feature) ElementType() reflect.Type {
	return reflect.TypeOf((*Feature)(nil))
}

func (i *Feature) ToFeatureOutput() FeatureOutput {
	return i.ToFeatureOutputWithContext(context.Background())
}

func (i *Feature) ToFeatureOutputWithContext(ctx context.Context) FeatureOutput {
	return pulumi.ToOutputWithContext(ctx, i).(FeatureOutput)
}

type FeatureOutput struct {
	*pulumi.OutputState
}

func (FeatureOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Feature)(nil))
}

func (o FeatureOutput) ToFeatureOutput() FeatureOutput {
	return o
}

func (o FeatureOutput) ToFeatureOutputWithContext(ctx context.Context) FeatureOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(FeatureOutput{})
}