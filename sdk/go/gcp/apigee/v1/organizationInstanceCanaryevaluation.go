// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Creates a new canary evaluation for an organization.
type OrganizationInstanceCanaryevaluation struct {
	pulumi.CustomResourceState

	// Required. The stable version that is serving requests.
	Control pulumi.StringOutput `pulumi:"control"`
	// Create time of the canary evaluation.
	CreateTime pulumi.StringOutput `pulumi:"createTime"`
	// Required. End time for the evaluation's analysis.
	EndTime pulumi.StringOutput `pulumi:"endTime"`
	// Required. Labels used to filter the metrics used for a canary evaluation.
	MetricLabels GoogleCloudApigeeV1CanaryEvaluationMetricLabelsResponseOutput `pulumi:"metricLabels"`
	// Name of the canary evalution.
	Name pulumi.StringOutput `pulumi:"name"`
	// Required. Start time for the canary evaluation's analysis.
	StartTime pulumi.StringOutput `pulumi:"startTime"`
	// The current state of the canary evaluation.
	State pulumi.StringOutput `pulumi:"state"`
	// Required. The newer version that is serving requests.
	Treatment pulumi.StringOutput `pulumi:"treatment"`
	// The resulting verdict of the canary evaluations: NONE, PASS, or FAIL.
	Verdict pulumi.StringOutput `pulumi:"verdict"`
}

// NewOrganizationInstanceCanaryevaluation registers a new resource with the given unique name, arguments, and options.
func NewOrganizationInstanceCanaryevaluation(ctx *pulumi.Context,
	name string, args *OrganizationInstanceCanaryevaluationArgs, opts ...pulumi.ResourceOption) (*OrganizationInstanceCanaryevaluation, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.CanaryevaluationsId == nil {
		return nil, errors.New("invalid value for required argument 'CanaryevaluationsId'")
	}
	if args.InstancesId == nil {
		return nil, errors.New("invalid value for required argument 'InstancesId'")
	}
	if args.OrganizationsId == nil {
		return nil, errors.New("invalid value for required argument 'OrganizationsId'")
	}
	var resource OrganizationInstanceCanaryevaluation
	err := ctx.RegisterResource("gcp-native:apigee/v1:OrganizationInstanceCanaryevaluation", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetOrganizationInstanceCanaryevaluation gets an existing OrganizationInstanceCanaryevaluation resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetOrganizationInstanceCanaryevaluation(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *OrganizationInstanceCanaryevaluationState, opts ...pulumi.ResourceOption) (*OrganizationInstanceCanaryevaluation, error) {
	var resource OrganizationInstanceCanaryevaluation
	err := ctx.ReadResource("gcp-native:apigee/v1:OrganizationInstanceCanaryevaluation", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering OrganizationInstanceCanaryevaluation resources.
type organizationInstanceCanaryevaluationState struct {
	// Required. The stable version that is serving requests.
	Control *string `pulumi:"control"`
	// Create time of the canary evaluation.
	CreateTime *string `pulumi:"createTime"`
	// Required. End time for the evaluation's analysis.
	EndTime *string `pulumi:"endTime"`
	// Required. Labels used to filter the metrics used for a canary evaluation.
	MetricLabels *GoogleCloudApigeeV1CanaryEvaluationMetricLabelsResponse `pulumi:"metricLabels"`
	// Name of the canary evalution.
	Name *string `pulumi:"name"`
	// Required. Start time for the canary evaluation's analysis.
	StartTime *string `pulumi:"startTime"`
	// The current state of the canary evaluation.
	State *string `pulumi:"state"`
	// Required. The newer version that is serving requests.
	Treatment *string `pulumi:"treatment"`
	// The resulting verdict of the canary evaluations: NONE, PASS, or FAIL.
	Verdict *string `pulumi:"verdict"`
}

type OrganizationInstanceCanaryevaluationState struct {
	// Required. The stable version that is serving requests.
	Control pulumi.StringPtrInput
	// Create time of the canary evaluation.
	CreateTime pulumi.StringPtrInput
	// Required. End time for the evaluation's analysis.
	EndTime pulumi.StringPtrInput
	// Required. Labels used to filter the metrics used for a canary evaluation.
	MetricLabels GoogleCloudApigeeV1CanaryEvaluationMetricLabelsResponsePtrInput
	// Name of the canary evalution.
	Name pulumi.StringPtrInput
	// Required. Start time for the canary evaluation's analysis.
	StartTime pulumi.StringPtrInput
	// The current state of the canary evaluation.
	State pulumi.StringPtrInput
	// Required. The newer version that is serving requests.
	Treatment pulumi.StringPtrInput
	// The resulting verdict of the canary evaluations: NONE, PASS, or FAIL.
	Verdict pulumi.StringPtrInput
}

func (OrganizationInstanceCanaryevaluationState) ElementType() reflect.Type {
	return reflect.TypeOf((*organizationInstanceCanaryevaluationState)(nil)).Elem()
}

type organizationInstanceCanaryevaluationArgs struct {
	CanaryevaluationsId string `pulumi:"canaryevaluationsId"`
	// Required. The stable version that is serving requests.
	Control *string `pulumi:"control"`
	// Required. End time for the evaluation's analysis.
	EndTime     *string `pulumi:"endTime"`
	InstancesId string  `pulumi:"instancesId"`
	// Required. Labels used to filter the metrics used for a canary evaluation.
	MetricLabels    *GoogleCloudApigeeV1CanaryEvaluationMetricLabels `pulumi:"metricLabels"`
	OrganizationsId string                                           `pulumi:"organizationsId"`
	// Required. Start time for the canary evaluation's analysis.
	StartTime *string `pulumi:"startTime"`
	// Required. The newer version that is serving requests.
	Treatment *string `pulumi:"treatment"`
}

// The set of arguments for constructing a OrganizationInstanceCanaryevaluation resource.
type OrganizationInstanceCanaryevaluationArgs struct {
	CanaryevaluationsId pulumi.StringInput
	// Required. The stable version that is serving requests.
	Control pulumi.StringPtrInput
	// Required. End time for the evaluation's analysis.
	EndTime     pulumi.StringPtrInput
	InstancesId pulumi.StringInput
	// Required. Labels used to filter the metrics used for a canary evaluation.
	MetricLabels    GoogleCloudApigeeV1CanaryEvaluationMetricLabelsPtrInput
	OrganizationsId pulumi.StringInput
	// Required. Start time for the canary evaluation's analysis.
	StartTime pulumi.StringPtrInput
	// Required. The newer version that is serving requests.
	Treatment pulumi.StringPtrInput
}

func (OrganizationInstanceCanaryevaluationArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*organizationInstanceCanaryevaluationArgs)(nil)).Elem()
}

type OrganizationInstanceCanaryevaluationInput interface {
	pulumi.Input

	ToOrganizationInstanceCanaryevaluationOutput() OrganizationInstanceCanaryevaluationOutput
	ToOrganizationInstanceCanaryevaluationOutputWithContext(ctx context.Context) OrganizationInstanceCanaryevaluationOutput
}

func (*OrganizationInstanceCanaryevaluation) ElementType() reflect.Type {
	return reflect.TypeOf((*OrganizationInstanceCanaryevaluation)(nil))
}

func (i *OrganizationInstanceCanaryevaluation) ToOrganizationInstanceCanaryevaluationOutput() OrganizationInstanceCanaryevaluationOutput {
	return i.ToOrganizationInstanceCanaryevaluationOutputWithContext(context.Background())
}

func (i *OrganizationInstanceCanaryevaluation) ToOrganizationInstanceCanaryevaluationOutputWithContext(ctx context.Context) OrganizationInstanceCanaryevaluationOutput {
	return pulumi.ToOutputWithContext(ctx, i).(OrganizationInstanceCanaryevaluationOutput)
}

type OrganizationInstanceCanaryevaluationOutput struct {
	*pulumi.OutputState
}

func (OrganizationInstanceCanaryevaluationOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*OrganizationInstanceCanaryevaluation)(nil))
}

func (o OrganizationInstanceCanaryevaluationOutput) ToOrganizationInstanceCanaryevaluationOutput() OrganizationInstanceCanaryevaluationOutput {
	return o
}

func (o OrganizationInstanceCanaryevaluationOutput) ToOrganizationInstanceCanaryevaluationOutputWithContext(ctx context.Context) OrganizationInstanceCanaryevaluationOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(OrganizationInstanceCanaryevaluationOutput{})
}