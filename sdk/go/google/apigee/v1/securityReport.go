// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v1

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Submit a report request to be processed in the background. If the submission succeeds, the API returns a 200 status and an ID that refer to the report request. In addition to the HTTP status 200, the `state` of "enqueued" means that the request succeeded.
// Auto-naming is currently not supported for this resource.
// Note - this resource's API doesn't support deletion. When deleted, the resource will persist
// on Google Cloud even though it will be deleted from Pulumi state.
type SecurityReport struct {
	pulumi.CustomResourceState

	// Creation time of the query.
	Created pulumi.StringOutput `pulumi:"created"`
	// Display Name specified by the user.
	DisplayName pulumi.StringOutput `pulumi:"displayName"`
	// Hostname is available only when query is executed at host level.
	EnvgroupHostname pulumi.StringOutput `pulumi:"envgroupHostname"`
	EnvironmentId    pulumi.StringOutput `pulumi:"environmentId"`
	// Error is set when query fails.
	Error pulumi.StringOutput `pulumi:"error"`
	// ExecutionTime is available only after the query is completed.
	ExecutionTime  pulumi.StringOutput `pulumi:"executionTime"`
	OrganizationId pulumi.StringOutput `pulumi:"organizationId"`
	// Contains information like metrics, dimenstions etc of the Security Report.
	QueryParams GoogleCloudApigeeV1SecurityReportMetadataResponseOutput `pulumi:"queryParams"`
	// Report Definition ID.
	ReportDefinitionId pulumi.StringOutput `pulumi:"reportDefinitionId"`
	// Result is available only after the query is completed.
	Result GoogleCloudApigeeV1SecurityReportResultMetadataResponseOutput `pulumi:"result"`
	// ResultFileSize is available only after the query is completed.
	ResultFileSize pulumi.StringOutput `pulumi:"resultFileSize"`
	// ResultRows is available only after the query is completed.
	ResultRows pulumi.StringOutput `pulumi:"resultRows"`
	// Self link of the query. Example: `/organizations/myorg/environments/myenv/securityReports/9cfc0d85-0f30-46d6-ae6f-318d0cb961bd` or following format if query is running at host level: `/organizations/myorg/hostSecurityReports/9cfc0d85-0f30-46d6-ae6f-318d0cb961bd`
	Self pulumi.StringOutput `pulumi:"self"`
	// Query state could be "enqueued", "running", "completed", "failed".
	State pulumi.StringOutput `pulumi:"state"`
	// Last updated timestamp for the query.
	Updated pulumi.StringOutput `pulumi:"updated"`
}

// NewSecurityReport registers a new resource with the given unique name, arguments, and options.
func NewSecurityReport(ctx *pulumi.Context,
	name string, args *SecurityReportArgs, opts ...pulumi.ResourceOption) (*SecurityReport, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.EnvironmentId == nil {
		return nil, errors.New("invalid value for required argument 'EnvironmentId'")
	}
	if args.OrganizationId == nil {
		return nil, errors.New("invalid value for required argument 'OrganizationId'")
	}
	if args.TimeRange == nil {
		return nil, errors.New("invalid value for required argument 'TimeRange'")
	}
	var resource SecurityReport
	err := ctx.RegisterResource("google-native:apigee/v1:SecurityReport", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetSecurityReport gets an existing SecurityReport resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSecurityReport(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *SecurityReportState, opts ...pulumi.ResourceOption) (*SecurityReport, error) {
	var resource SecurityReport
	err := ctx.ReadResource("google-native:apigee/v1:SecurityReport", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering SecurityReport resources.
type securityReportState struct {
}

type SecurityReportState struct {
}

func (SecurityReportState) ElementType() reflect.Type {
	return reflect.TypeOf((*securityReportState)(nil)).Elem()
}

type securityReportArgs struct {
	// Delimiter used in the CSV file, if `outputFormat` is set to `csv`. Defaults to the `,` (comma) character. Supported delimiter characters include comma (`,`), pipe (`|`), and tab (`\t`).
	CsvDelimiter *string `pulumi:"csvDelimiter"`
	// A list of dimensions. https://docs.apigee.com/api-platform/analytics/analytics-reference#dimensions
	Dimensions []string `pulumi:"dimensions"`
	// Security Report display name which users can specify.
	DisplayName *string `pulumi:"displayName"`
	// Hostname needs to be specified if query intends to run at host level. This field is only allowed when query is submitted by CreateHostSecurityReport where analytics data will be grouped by organization and hostname.
	EnvgroupHostname *string `pulumi:"envgroupHostname"`
	EnvironmentId    string  `pulumi:"environmentId"`
	// Boolean expression that can be used to filter data. Filter expressions can be combined using AND/OR terms and should be fully parenthesized to avoid ambiguity. See Analytics metrics, dimensions, and filters reference https://docs.apigee.com/api-platform/analytics/analytics-reference for more information on the fields available to filter on. For more information on the tokens that you use to build filter expressions, see Filter expression syntax. https://docs.apigee.com/api-platform/analytics/asynch-reports-api#filter-expression-syntax
	Filter *string `pulumi:"filter"`
	// Time unit used to group the result set. Valid values include: second, minute, hour, day, week, or month. If a query includes groupByTimeUnit, then the result is an aggregation based on the specified time unit and the resultant timestamp does not include milliseconds precision. If a query omits groupByTimeUnit, then the resultant timestamp includes milliseconds precision.
	GroupByTimeUnit *string `pulumi:"groupByTimeUnit"`
	// Maximum number of rows that can be returned in the result.
	Limit *int `pulumi:"limit"`
	// A list of Metrics.
	Metrics []GoogleCloudApigeeV1SecurityReportQueryMetric `pulumi:"metrics"`
	// Valid values include: `csv` or `json`. Defaults to `json`. Note: Configure the delimiter for CSV output using the csvDelimiter property.
	MimeType       *string `pulumi:"mimeType"`
	OrganizationId string  `pulumi:"organizationId"`
	// Report Definition ID.
	ReportDefinitionId *string `pulumi:"reportDefinitionId"`
	// Time range for the query. Can use the following predefined strings to specify the time range: `last60minutes` `last24hours` `last7days` Or, specify the timeRange as a structure describing start and end timestamps in the ISO format: yyyy-mm-ddThh:mm:ssZ. Example: "timeRange": { "start": "2018-07-29T00:13:00Z", "end": "2018-08-01T00:18:00Z" }
	TimeRange interface{} `pulumi:"timeRange"`
}

// The set of arguments for constructing a SecurityReport resource.
type SecurityReportArgs struct {
	// Delimiter used in the CSV file, if `outputFormat` is set to `csv`. Defaults to the `,` (comma) character. Supported delimiter characters include comma (`,`), pipe (`|`), and tab (`\t`).
	CsvDelimiter pulumi.StringPtrInput
	// A list of dimensions. https://docs.apigee.com/api-platform/analytics/analytics-reference#dimensions
	Dimensions pulumi.StringArrayInput
	// Security Report display name which users can specify.
	DisplayName pulumi.StringPtrInput
	// Hostname needs to be specified if query intends to run at host level. This field is only allowed when query is submitted by CreateHostSecurityReport where analytics data will be grouped by organization and hostname.
	EnvgroupHostname pulumi.StringPtrInput
	EnvironmentId    pulumi.StringInput
	// Boolean expression that can be used to filter data. Filter expressions can be combined using AND/OR terms and should be fully parenthesized to avoid ambiguity. See Analytics metrics, dimensions, and filters reference https://docs.apigee.com/api-platform/analytics/analytics-reference for more information on the fields available to filter on. For more information on the tokens that you use to build filter expressions, see Filter expression syntax. https://docs.apigee.com/api-platform/analytics/asynch-reports-api#filter-expression-syntax
	Filter pulumi.StringPtrInput
	// Time unit used to group the result set. Valid values include: second, minute, hour, day, week, or month. If a query includes groupByTimeUnit, then the result is an aggregation based on the specified time unit and the resultant timestamp does not include milliseconds precision. If a query omits groupByTimeUnit, then the resultant timestamp includes milliseconds precision.
	GroupByTimeUnit pulumi.StringPtrInput
	// Maximum number of rows that can be returned in the result.
	Limit pulumi.IntPtrInput
	// A list of Metrics.
	Metrics GoogleCloudApigeeV1SecurityReportQueryMetricArrayInput
	// Valid values include: `csv` or `json`. Defaults to `json`. Note: Configure the delimiter for CSV output using the csvDelimiter property.
	MimeType       pulumi.StringPtrInput
	OrganizationId pulumi.StringInput
	// Report Definition ID.
	ReportDefinitionId pulumi.StringPtrInput
	// Time range for the query. Can use the following predefined strings to specify the time range: `last60minutes` `last24hours` `last7days` Or, specify the timeRange as a structure describing start and end timestamps in the ISO format: yyyy-mm-ddThh:mm:ssZ. Example: "timeRange": { "start": "2018-07-29T00:13:00Z", "end": "2018-08-01T00:18:00Z" }
	TimeRange pulumi.Input
}

func (SecurityReportArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*securityReportArgs)(nil)).Elem()
}

type SecurityReportInput interface {
	pulumi.Input

	ToSecurityReportOutput() SecurityReportOutput
	ToSecurityReportOutputWithContext(ctx context.Context) SecurityReportOutput
}

func (*SecurityReport) ElementType() reflect.Type {
	return reflect.TypeOf((**SecurityReport)(nil)).Elem()
}

func (i *SecurityReport) ToSecurityReportOutput() SecurityReportOutput {
	return i.ToSecurityReportOutputWithContext(context.Background())
}

func (i *SecurityReport) ToSecurityReportOutputWithContext(ctx context.Context) SecurityReportOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SecurityReportOutput)
}

type SecurityReportOutput struct{ *pulumi.OutputState }

func (SecurityReportOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**SecurityReport)(nil)).Elem()
}

func (o SecurityReportOutput) ToSecurityReportOutput() SecurityReportOutput {
	return o
}

func (o SecurityReportOutput) ToSecurityReportOutputWithContext(ctx context.Context) SecurityReportOutput {
	return o
}

// Creation time of the query.
func (o SecurityReportOutput) Created() pulumi.StringOutput {
	return o.ApplyT(func(v *SecurityReport) pulumi.StringOutput { return v.Created }).(pulumi.StringOutput)
}

// Display Name specified by the user.
func (o SecurityReportOutput) DisplayName() pulumi.StringOutput {
	return o.ApplyT(func(v *SecurityReport) pulumi.StringOutput { return v.DisplayName }).(pulumi.StringOutput)
}

// Hostname is available only when query is executed at host level.
func (o SecurityReportOutput) EnvgroupHostname() pulumi.StringOutput {
	return o.ApplyT(func(v *SecurityReport) pulumi.StringOutput { return v.EnvgroupHostname }).(pulumi.StringOutput)
}

func (o SecurityReportOutput) EnvironmentId() pulumi.StringOutput {
	return o.ApplyT(func(v *SecurityReport) pulumi.StringOutput { return v.EnvironmentId }).(pulumi.StringOutput)
}

// Error is set when query fails.
func (o SecurityReportOutput) Error() pulumi.StringOutput {
	return o.ApplyT(func(v *SecurityReport) pulumi.StringOutput { return v.Error }).(pulumi.StringOutput)
}

// ExecutionTime is available only after the query is completed.
func (o SecurityReportOutput) ExecutionTime() pulumi.StringOutput {
	return o.ApplyT(func(v *SecurityReport) pulumi.StringOutput { return v.ExecutionTime }).(pulumi.StringOutput)
}

func (o SecurityReportOutput) OrganizationId() pulumi.StringOutput {
	return o.ApplyT(func(v *SecurityReport) pulumi.StringOutput { return v.OrganizationId }).(pulumi.StringOutput)
}

// Contains information like metrics, dimenstions etc of the Security Report.
func (o SecurityReportOutput) QueryParams() GoogleCloudApigeeV1SecurityReportMetadataResponseOutput {
	return o.ApplyT(func(v *SecurityReport) GoogleCloudApigeeV1SecurityReportMetadataResponseOutput { return v.QueryParams }).(GoogleCloudApigeeV1SecurityReportMetadataResponseOutput)
}

// Report Definition ID.
func (o SecurityReportOutput) ReportDefinitionId() pulumi.StringOutput {
	return o.ApplyT(func(v *SecurityReport) pulumi.StringOutput { return v.ReportDefinitionId }).(pulumi.StringOutput)
}

// Result is available only after the query is completed.
func (o SecurityReportOutput) Result() GoogleCloudApigeeV1SecurityReportResultMetadataResponseOutput {
	return o.ApplyT(func(v *SecurityReport) GoogleCloudApigeeV1SecurityReportResultMetadataResponseOutput { return v.Result }).(GoogleCloudApigeeV1SecurityReportResultMetadataResponseOutput)
}

// ResultFileSize is available only after the query is completed.
func (o SecurityReportOutput) ResultFileSize() pulumi.StringOutput {
	return o.ApplyT(func(v *SecurityReport) pulumi.StringOutput { return v.ResultFileSize }).(pulumi.StringOutput)
}

// ResultRows is available only after the query is completed.
func (o SecurityReportOutput) ResultRows() pulumi.StringOutput {
	return o.ApplyT(func(v *SecurityReport) pulumi.StringOutput { return v.ResultRows }).(pulumi.StringOutput)
}

// Self link of the query. Example: `/organizations/myorg/environments/myenv/securityReports/9cfc0d85-0f30-46d6-ae6f-318d0cb961bd` or following format if query is running at host level: `/organizations/myorg/hostSecurityReports/9cfc0d85-0f30-46d6-ae6f-318d0cb961bd`
func (o SecurityReportOutput) Self() pulumi.StringOutput {
	return o.ApplyT(func(v *SecurityReport) pulumi.StringOutput { return v.Self }).(pulumi.StringOutput)
}

// Query state could be "enqueued", "running", "completed", "failed".
func (o SecurityReportOutput) State() pulumi.StringOutput {
	return o.ApplyT(func(v *SecurityReport) pulumi.StringOutput { return v.State }).(pulumi.StringOutput)
}

// Last updated timestamp for the query.
func (o SecurityReportOutput) Updated() pulumi.StringOutput {
	return o.ApplyT(func(v *SecurityReport) pulumi.StringOutput { return v.Updated }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*SecurityReportInput)(nil)).Elem(), &SecurityReport{})
	pulumi.RegisterOutputType(SecurityReportOutput{})
}
