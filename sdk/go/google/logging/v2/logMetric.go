// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v2

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Creates a logs-based metric.
type LogMetric struct {
	pulumi.CustomResourceState
}

// NewLogMetric registers a new resource with the given unique name, arguments, and options.
func NewLogMetric(ctx *pulumi.Context,
	name string, args *LogMetricArgs, opts ...pulumi.ResourceOption) (*LogMetric, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Parent == nil {
		return nil, errors.New("invalid value for required argument 'Parent'")
	}
	var resource LogMetric
	err := ctx.RegisterResource("google-cloud:logging/v2:LogMetric", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetLogMetric gets an existing LogMetric resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetLogMetric(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *LogMetricState, opts ...pulumi.ResourceOption) (*LogMetric, error) {
	var resource LogMetric
	err := ctx.ReadResource("google-cloud:logging/v2:LogMetric", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering LogMetric resources.
type logMetricState struct {
}

type LogMetricState struct {
}

func (LogMetricState) ElementType() reflect.Type {
	return reflect.TypeOf((*logMetricState)(nil)).Elem()
}

type logMetricArgs struct {
	// Optional. The bucket_options are required when the logs-based metric is using a DISTRIBUTION value type and it describes the bucket boundaries used to create a histogram of the extracted values.
	BucketOptions *BucketOptions `pulumi:"bucketOptions"`
	// Output only. The creation timestamp of the metric.This field may not be present for older metrics.
	CreateTime *string `pulumi:"createTime"`
	// Optional. A description of this metric, which is used in documentation. The maximum length of the description is 8000 characters.
	Description *string `pulumi:"description"`
	// Required. An advanced logs filter (https://cloud.google.com/logging/docs/view/advanced_filters) which is used to match log entries. Example: "resource.type=gae_app AND severity>=ERROR" The maximum length of the filter is 20000 characters.
	Filter *string `pulumi:"filter"`
	// Optional. A map from a label key string to an extractor expression which is used to extract data from a log entry field and assign as the label value. Each label key specified in the LabelDescriptor must have an associated extractor expression in this map. The syntax of the extractor expression is the same as for the value_extractor field.The extracted value is converted to the type defined in the label descriptor. If the either the extraction or the type conversion fails, the label will have a default value. The default value for a string label is an empty string, for an integer label its 0, and for a boolean label its false.Note that there are upper bounds on the maximum number of labels and the number of active time series that are allowed in a project.
	LabelExtractors map[string]string `pulumi:"labelExtractors"`
	// Optional. The metric descriptor associated with the logs-based metric. If unspecified, it uses a default metric descriptor with a DELTA metric kind, INT64 value type, with no labels and a unit of "1". Such a metric counts the number of log entries matching the filter expression.The name, type, and description fields in the metric_descriptor are output only, and is constructed using the name and description field in the LogMetric.To create a logs-based metric that records a distribution of log values, a DELTA metric kind with a DISTRIBUTION value type must be used along with a value_extractor expression in the LogMetric.Each label in the metric descriptor must have a matching label name as the key and an extractor expression as the value in the label_extractors map.The metric_kind and value_type fields in the metric_descriptor cannot be updated once initially configured. New labels can be added in the metric_descriptor, but existing labels cannot be modified except for their description.
	MetricDescriptor *MetricDescriptor `pulumi:"metricDescriptor"`
	// Required. The client-assigned metric identifier. Examples: "error_count", "nginx/requests".Metric identifiers are limited to 100 characters and can include only the following characters: A-Z, a-z, 0-9, and the special characters _-.,+!*',()%/. The forward-slash character (/) denotes a hierarchy of name pieces, and it cannot be the first character of the name.The metric identifier in this field must not be URL-encoded (https://en.wikipedia.org/wiki/Percent-encoding). However, when the metric identifier appears as the [METRIC_ID] part of a metric_name API parameter, then the metric identifier must be URL-encoded. Example: "projects/my-project/metrics/nginx%2Frequests".
	Name *string `pulumi:"name"`
	// Required. The resource name of the project in which to create the metric: "projects/[PROJECT_ID]" The new metric must be provided in the request.
	Parent string `pulumi:"parent"`
	// Output only. The last update timestamp of the metric.This field may not be present for older metrics.
	UpdateTime *string `pulumi:"updateTime"`
	// Optional. A value_extractor is required when using a distribution logs-based metric to extract the values to record from a log entry. Two functions are supported for value extraction: EXTRACT(field) or REGEXP_EXTRACT(field, regex). The argument are: 1. field: The name of the log entry field from which the value is to be extracted. 2. regex: A regular expression using the Google RE2 syntax (https://github.com/google/re2/wiki/Syntax) with a single capture group to extract data from the specified log entry field. The value of the field is converted to a string before applying the regex. It is an error to specify a regex that does not include exactly one capture group.The result of the extraction must be convertible to a double type, as the distribution always records double values. If either the extraction or the conversion to double fails, then those values are not recorded in the distribution.Example: REGEXP_EXTRACT(jsonPayload.request, ".*quantity=(\d+).*")
	ValueExtractor *string `pulumi:"valueExtractor"`
	// Deprecated. The API version that created or updated this metric. The v2 format is used by default and cannot be changed.
	Version *string `pulumi:"version"`
}

// The set of arguments for constructing a LogMetric resource.
type LogMetricArgs struct {
	// Optional. The bucket_options are required when the logs-based metric is using a DISTRIBUTION value type and it describes the bucket boundaries used to create a histogram of the extracted values.
	BucketOptions BucketOptionsPtrInput
	// Output only. The creation timestamp of the metric.This field may not be present for older metrics.
	CreateTime pulumi.StringPtrInput
	// Optional. A description of this metric, which is used in documentation. The maximum length of the description is 8000 characters.
	Description pulumi.StringPtrInput
	// Required. An advanced logs filter (https://cloud.google.com/logging/docs/view/advanced_filters) which is used to match log entries. Example: "resource.type=gae_app AND severity>=ERROR" The maximum length of the filter is 20000 characters.
	Filter pulumi.StringPtrInput
	// Optional. A map from a label key string to an extractor expression which is used to extract data from a log entry field and assign as the label value. Each label key specified in the LabelDescriptor must have an associated extractor expression in this map. The syntax of the extractor expression is the same as for the value_extractor field.The extracted value is converted to the type defined in the label descriptor. If the either the extraction or the type conversion fails, the label will have a default value. The default value for a string label is an empty string, for an integer label its 0, and for a boolean label its false.Note that there are upper bounds on the maximum number of labels and the number of active time series that are allowed in a project.
	LabelExtractors pulumi.StringMapInput
	// Optional. The metric descriptor associated with the logs-based metric. If unspecified, it uses a default metric descriptor with a DELTA metric kind, INT64 value type, with no labels and a unit of "1". Such a metric counts the number of log entries matching the filter expression.The name, type, and description fields in the metric_descriptor are output only, and is constructed using the name and description field in the LogMetric.To create a logs-based metric that records a distribution of log values, a DELTA metric kind with a DISTRIBUTION value type must be used along with a value_extractor expression in the LogMetric.Each label in the metric descriptor must have a matching label name as the key and an extractor expression as the value in the label_extractors map.The metric_kind and value_type fields in the metric_descriptor cannot be updated once initially configured. New labels can be added in the metric_descriptor, but existing labels cannot be modified except for their description.
	MetricDescriptor MetricDescriptorPtrInput
	// Required. The client-assigned metric identifier. Examples: "error_count", "nginx/requests".Metric identifiers are limited to 100 characters and can include only the following characters: A-Z, a-z, 0-9, and the special characters _-.,+!*',()%/. The forward-slash character (/) denotes a hierarchy of name pieces, and it cannot be the first character of the name.The metric identifier in this field must not be URL-encoded (https://en.wikipedia.org/wiki/Percent-encoding). However, when the metric identifier appears as the [METRIC_ID] part of a metric_name API parameter, then the metric identifier must be URL-encoded. Example: "projects/my-project/metrics/nginx%2Frequests".
	Name pulumi.StringPtrInput
	// Required. The resource name of the project in which to create the metric: "projects/[PROJECT_ID]" The new metric must be provided in the request.
	Parent pulumi.StringInput
	// Output only. The last update timestamp of the metric.This field may not be present for older metrics.
	UpdateTime pulumi.StringPtrInput
	// Optional. A value_extractor is required when using a distribution logs-based metric to extract the values to record from a log entry. Two functions are supported for value extraction: EXTRACT(field) or REGEXP_EXTRACT(field, regex). The argument are: 1. field: The name of the log entry field from which the value is to be extracted. 2. regex: A regular expression using the Google RE2 syntax (https://github.com/google/re2/wiki/Syntax) with a single capture group to extract data from the specified log entry field. The value of the field is converted to a string before applying the regex. It is an error to specify a regex that does not include exactly one capture group.The result of the extraction must be convertible to a double type, as the distribution always records double values. If either the extraction or the conversion to double fails, then those values are not recorded in the distribution.Example: REGEXP_EXTRACT(jsonPayload.request, ".*quantity=(\d+).*")
	ValueExtractor pulumi.StringPtrInput
	// Deprecated. The API version that created or updated this metric. The v2 format is used by default and cannot be changed.
	Version pulumi.StringPtrInput
}

func (LogMetricArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*logMetricArgs)(nil)).Elem()
}

type LogMetricInput interface {
	pulumi.Input

	ToLogMetricOutput() LogMetricOutput
	ToLogMetricOutputWithContext(ctx context.Context) LogMetricOutput
}

func (*LogMetric) ElementType() reflect.Type {
	return reflect.TypeOf((*LogMetric)(nil))
}

func (i *LogMetric) ToLogMetricOutput() LogMetricOutput {
	return i.ToLogMetricOutputWithContext(context.Background())
}

func (i *LogMetric) ToLogMetricOutputWithContext(ctx context.Context) LogMetricOutput {
	return pulumi.ToOutputWithContext(ctx, i).(LogMetricOutput)
}

type LogMetricOutput struct {
	*pulumi.OutputState
}

func (LogMetricOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LogMetric)(nil))
}

func (o LogMetricOutput) ToLogMetricOutput() LogMetricOutput {
	return o
}

func (o LogMetricOutput) ToLogMetricOutputWithContext(ctx context.Context) LogMetricOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(LogMetricOutput{})
}