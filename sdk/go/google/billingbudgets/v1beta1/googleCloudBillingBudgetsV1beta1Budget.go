// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1beta1

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Creates a new budget. See Quotas and limits for more information on the limits of the number of budgets you can create.
type GoogleCloudBillingBudgetsV1beta1Budget struct {
	pulumi.CustomResourceState
}

// NewGoogleCloudBillingBudgetsV1beta1Budget registers a new resource with the given unique name, arguments, and options.
func NewGoogleCloudBillingBudgetsV1beta1Budget(ctx *pulumi.Context,
	name string, args *GoogleCloudBillingBudgetsV1beta1BudgetArgs, opts ...pulumi.ResourceOption) (*GoogleCloudBillingBudgetsV1beta1Budget, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Parent == nil {
		return nil, errors.New("invalid value for required argument 'Parent'")
	}
	var resource GoogleCloudBillingBudgetsV1beta1Budget
	err := ctx.RegisterResource("google-cloud:billingbudgets/v1beta1:GoogleCloudBillingBudgetsV1beta1Budget", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetGoogleCloudBillingBudgetsV1beta1Budget gets an existing GoogleCloudBillingBudgetsV1beta1Budget resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetGoogleCloudBillingBudgetsV1beta1Budget(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *GoogleCloudBillingBudgetsV1beta1BudgetState, opts ...pulumi.ResourceOption) (*GoogleCloudBillingBudgetsV1beta1Budget, error) {
	var resource GoogleCloudBillingBudgetsV1beta1Budget
	err := ctx.ReadResource("google-cloud:billingbudgets/v1beta1:GoogleCloudBillingBudgetsV1beta1Budget", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering GoogleCloudBillingBudgetsV1beta1Budget resources.
type googleCloudBillingBudgetsV1beta1BudgetState struct {
}

type GoogleCloudBillingBudgetsV1beta1BudgetState struct {
}

func (GoogleCloudBillingBudgetsV1beta1BudgetState) ElementType() reflect.Type {
	return reflect.TypeOf((*googleCloudBillingBudgetsV1beta1BudgetState)(nil)).Elem()
}

type googleCloudBillingBudgetsV1beta1BudgetArgs struct {
	// Required. Budget to create.
	Budget *GoogleCloudBillingBudgetsV1beta1BudgetType `pulumi:"budget"`
	// Required. The name of the billing account to create the budget in. Values are of the form `billingAccounts/{billingAccountId}`.
	Parent string `pulumi:"parent"`
}

// The set of arguments for constructing a GoogleCloudBillingBudgetsV1beta1Budget resource.
type GoogleCloudBillingBudgetsV1beta1BudgetArgs struct {
	// Required. Budget to create.
	Budget GoogleCloudBillingBudgetsV1beta1BudgetTypePtrInput
	// Required. The name of the billing account to create the budget in. Values are of the form `billingAccounts/{billingAccountId}`.
	Parent pulumi.StringInput
}

func (GoogleCloudBillingBudgetsV1beta1BudgetArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*googleCloudBillingBudgetsV1beta1BudgetArgs)(nil)).Elem()
}

type GoogleCloudBillingBudgetsV1beta1BudgetInput interface {
	pulumi.Input

	ToGoogleCloudBillingBudgetsV1beta1BudgetOutput() GoogleCloudBillingBudgetsV1beta1BudgetOutput
	ToGoogleCloudBillingBudgetsV1beta1BudgetOutputWithContext(ctx context.Context) GoogleCloudBillingBudgetsV1beta1BudgetOutput
}

func (*GoogleCloudBillingBudgetsV1beta1Budget) ElementType() reflect.Type {
	return reflect.TypeOf((*GoogleCloudBillingBudgetsV1beta1Budget)(nil))
}

func (i *GoogleCloudBillingBudgetsV1beta1Budget) ToGoogleCloudBillingBudgetsV1beta1BudgetOutput() GoogleCloudBillingBudgetsV1beta1BudgetOutput {
	return i.ToGoogleCloudBillingBudgetsV1beta1BudgetOutputWithContext(context.Background())
}

func (i *GoogleCloudBillingBudgetsV1beta1Budget) ToGoogleCloudBillingBudgetsV1beta1BudgetOutputWithContext(ctx context.Context) GoogleCloudBillingBudgetsV1beta1BudgetOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GoogleCloudBillingBudgetsV1beta1BudgetOutput)
}

type GoogleCloudBillingBudgetsV1beta1BudgetOutput struct {
	*pulumi.OutputState
}

func (GoogleCloudBillingBudgetsV1beta1BudgetOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GoogleCloudBillingBudgetsV1beta1Budget)(nil))
}

func (o GoogleCloudBillingBudgetsV1beta1BudgetOutput) ToGoogleCloudBillingBudgetsV1beta1BudgetOutput() GoogleCloudBillingBudgetsV1beta1BudgetOutput {
	return o
}

func (o GoogleCloudBillingBudgetsV1beta1BudgetOutput) ToGoogleCloudBillingBudgetsV1beta1BudgetOutputWithContext(ctx context.Context) GoogleCloudBillingBudgetsV1beta1BudgetOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(GoogleCloudBillingBudgetsV1beta1BudgetOutput{})
}