// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v2beta

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Create a new case and associate it with the given Cloud resource.
// Note - this resource's API doesn't support deletion. When deleted, the resource will persist
// on Google Cloud even though it will be deleted from Pulumi state.
type Case struct {
	pulumi.CustomResourceState

	// The issue classification applicable to this case.
	Classification CaseClassificationResponseOutput `pulumi:"classification"`
	// The time this case was created.
	CreateTime pulumi.StringOutput `pulumi:"createTime"`
	// The user who created the case. Note: The name and email will be obfuscated if the case was created by Google Support.
	Creator ActorResponseOutput `pulumi:"creator"`
	// A broad description of the issue.
	Description pulumi.StringOutput `pulumi:"description"`
	// The short summary of the issue reported in this case.
	DisplayName pulumi.StringOutput `pulumi:"displayName"`
	// Whether the case is currently escalated.
	Escalated pulumi.BoolOutput `pulumi:"escalated"`
	// The resource name for the case.
	Name pulumi.StringOutput `pulumi:"name"`
	// The priority of this case. If this is set, do not set severity.
	Priority pulumi.StringOutput `pulumi:"priority"`
	// The severity of this case. Deprecated. Use priority instead.
	//
	// Deprecated: The severity of this case. Deprecated. Use priority instead.
	Severity pulumi.StringOutput `pulumi:"severity"`
	// The current status of the support case.
	State pulumi.StringOutput `pulumi:"state"`
	// The email addresses to receive updates on this case.
	SubscriberEmailAddresses pulumi.StringArrayOutput `pulumi:"subscriberEmailAddresses"`
	// Whether this case was created for internal API testing and should not be acted on by the support team.
	TestCase pulumi.BoolOutput `pulumi:"testCase"`
	// The timezone of the user who created the support case. It should be in a format IANA recognizes: https://www.iana.org/time-zones. There is no additional validation done by the API.
	TimeZone pulumi.StringOutput `pulumi:"timeZone"`
	// The time this case was last updated.
	UpdateTime pulumi.StringOutput `pulumi:"updateTime"`
	V2betaId1  pulumi.StringOutput `pulumi:"v2betaId1"`
	V2betumId  pulumi.StringOutput `pulumi:"v2betumId"`
}

// NewCase registers a new resource with the given unique name, arguments, and options.
func NewCase(ctx *pulumi.Context,
	name string, args *CaseArgs, opts ...pulumi.ResourceOption) (*Case, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.V2betaId1 == nil {
		return nil, errors.New("invalid value for required argument 'V2betaId1'")
	}
	if args.V2betumId == nil {
		return nil, errors.New("invalid value for required argument 'V2betumId'")
	}
	var resource Case
	err := ctx.RegisterResource("google-native:cloudsupport/v2beta:Case", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetCase gets an existing Case resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetCase(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *CaseState, opts ...pulumi.ResourceOption) (*Case, error) {
	var resource Case
	err := ctx.ReadResource("google-native:cloudsupport/v2beta:Case", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Case resources.
type caseState struct {
}

type CaseState struct {
}

func (CaseState) ElementType() reflect.Type {
	return reflect.TypeOf((*caseState)(nil)).Elem()
}

type caseArgs struct {
	// The issue classification applicable to this case.
	Classification *CaseClassification `pulumi:"classification"`
	// The user who created the case. Note: The name and email will be obfuscated if the case was created by Google Support.
	Creator *Actor `pulumi:"creator"`
	// A broad description of the issue.
	Description *string `pulumi:"description"`
	// The short summary of the issue reported in this case.
	DisplayName *string `pulumi:"displayName"`
	// Whether the case is currently escalated.
	Escalated *bool `pulumi:"escalated"`
	// The resource name for the case.
	Name *string `pulumi:"name"`
	// The priority of this case. If this is set, do not set severity.
	Priority *CasePriority `pulumi:"priority"`
	// The severity of this case. Deprecated. Use priority instead.
	//
	// Deprecated: The severity of this case. Deprecated. Use priority instead.
	Severity *CaseSeverity `pulumi:"severity"`
	// The email addresses to receive updates on this case.
	SubscriberEmailAddresses []string `pulumi:"subscriberEmailAddresses"`
	// Whether this case was created for internal API testing and should not be acted on by the support team.
	TestCase *bool `pulumi:"testCase"`
	// The timezone of the user who created the support case. It should be in a format IANA recognizes: https://www.iana.org/time-zones. There is no additional validation done by the API.
	TimeZone  *string `pulumi:"timeZone"`
	V2betaId1 string  `pulumi:"v2betaId1"`
	V2betumId string  `pulumi:"v2betumId"`
}

// The set of arguments for constructing a Case resource.
type CaseArgs struct {
	// The issue classification applicable to this case.
	Classification CaseClassificationPtrInput
	// The user who created the case. Note: The name and email will be obfuscated if the case was created by Google Support.
	Creator ActorPtrInput
	// A broad description of the issue.
	Description pulumi.StringPtrInput
	// The short summary of the issue reported in this case.
	DisplayName pulumi.StringPtrInput
	// Whether the case is currently escalated.
	Escalated pulumi.BoolPtrInput
	// The resource name for the case.
	Name pulumi.StringPtrInput
	// The priority of this case. If this is set, do not set severity.
	Priority CasePriorityPtrInput
	// The severity of this case. Deprecated. Use priority instead.
	//
	// Deprecated: The severity of this case. Deprecated. Use priority instead.
	Severity CaseSeverityPtrInput
	// The email addresses to receive updates on this case.
	SubscriberEmailAddresses pulumi.StringArrayInput
	// Whether this case was created for internal API testing and should not be acted on by the support team.
	TestCase pulumi.BoolPtrInput
	// The timezone of the user who created the support case. It should be in a format IANA recognizes: https://www.iana.org/time-zones. There is no additional validation done by the API.
	TimeZone  pulumi.StringPtrInput
	V2betaId1 pulumi.StringInput
	V2betumId pulumi.StringInput
}

func (CaseArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*caseArgs)(nil)).Elem()
}

type CaseInput interface {
	pulumi.Input

	ToCaseOutput() CaseOutput
	ToCaseOutputWithContext(ctx context.Context) CaseOutput
}

func (*Case) ElementType() reflect.Type {
	return reflect.TypeOf((**Case)(nil)).Elem()
}

func (i *Case) ToCaseOutput() CaseOutput {
	return i.ToCaseOutputWithContext(context.Background())
}

func (i *Case) ToCaseOutputWithContext(ctx context.Context) CaseOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CaseOutput)
}

type CaseOutput struct{ *pulumi.OutputState }

func (CaseOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**Case)(nil)).Elem()
}

func (o CaseOutput) ToCaseOutput() CaseOutput {
	return o
}

func (o CaseOutput) ToCaseOutputWithContext(ctx context.Context) CaseOutput {
	return o
}

// The issue classification applicable to this case.
func (o CaseOutput) Classification() CaseClassificationResponseOutput {
	return o.ApplyT(func(v *Case) CaseClassificationResponseOutput { return v.Classification }).(CaseClassificationResponseOutput)
}

// The time this case was created.
func (o CaseOutput) CreateTime() pulumi.StringOutput {
	return o.ApplyT(func(v *Case) pulumi.StringOutput { return v.CreateTime }).(pulumi.StringOutput)
}

// The user who created the case. Note: The name and email will be obfuscated if the case was created by Google Support.
func (o CaseOutput) Creator() ActorResponseOutput {
	return o.ApplyT(func(v *Case) ActorResponseOutput { return v.Creator }).(ActorResponseOutput)
}

// A broad description of the issue.
func (o CaseOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v *Case) pulumi.StringOutput { return v.Description }).(pulumi.StringOutput)
}

// The short summary of the issue reported in this case.
func (o CaseOutput) DisplayName() pulumi.StringOutput {
	return o.ApplyT(func(v *Case) pulumi.StringOutput { return v.DisplayName }).(pulumi.StringOutput)
}

// Whether the case is currently escalated.
func (o CaseOutput) Escalated() pulumi.BoolOutput {
	return o.ApplyT(func(v *Case) pulumi.BoolOutput { return v.Escalated }).(pulumi.BoolOutput)
}

// The resource name for the case.
func (o CaseOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *Case) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// The priority of this case. If this is set, do not set severity.
func (o CaseOutput) Priority() pulumi.StringOutput {
	return o.ApplyT(func(v *Case) pulumi.StringOutput { return v.Priority }).(pulumi.StringOutput)
}

// The severity of this case. Deprecated. Use priority instead.
//
// Deprecated: The severity of this case. Deprecated. Use priority instead.
func (o CaseOutput) Severity() pulumi.StringOutput {
	return o.ApplyT(func(v *Case) pulumi.StringOutput { return v.Severity }).(pulumi.StringOutput)
}

// The current status of the support case.
func (o CaseOutput) State() pulumi.StringOutput {
	return o.ApplyT(func(v *Case) pulumi.StringOutput { return v.State }).(pulumi.StringOutput)
}

// The email addresses to receive updates on this case.
func (o CaseOutput) SubscriberEmailAddresses() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *Case) pulumi.StringArrayOutput { return v.SubscriberEmailAddresses }).(pulumi.StringArrayOutput)
}

// Whether this case was created for internal API testing and should not be acted on by the support team.
func (o CaseOutput) TestCase() pulumi.BoolOutput {
	return o.ApplyT(func(v *Case) pulumi.BoolOutput { return v.TestCase }).(pulumi.BoolOutput)
}

// The timezone of the user who created the support case. It should be in a format IANA recognizes: https://www.iana.org/time-zones. There is no additional validation done by the API.
func (o CaseOutput) TimeZone() pulumi.StringOutput {
	return o.ApplyT(func(v *Case) pulumi.StringOutput { return v.TimeZone }).(pulumi.StringOutput)
}

// The time this case was last updated.
func (o CaseOutput) UpdateTime() pulumi.StringOutput {
	return o.ApplyT(func(v *Case) pulumi.StringOutput { return v.UpdateTime }).(pulumi.StringOutput)
}

func (o CaseOutput) V2betaId1() pulumi.StringOutput {
	return o.ApplyT(func(v *Case) pulumi.StringOutput { return v.V2betaId1 }).(pulumi.StringOutput)
}

func (o CaseOutput) V2betumId() pulumi.StringOutput {
	return o.ApplyT(func(v *Case) pulumi.StringOutput { return v.V2betumId }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*CaseInput)(nil)).Elem(), &Case{})
	pulumi.RegisterOutputType(CaseOutput{})
}
