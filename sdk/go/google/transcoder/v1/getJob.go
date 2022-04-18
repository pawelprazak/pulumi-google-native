// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Returns the job data.
func LookupJob(ctx *pulumi.Context, args *LookupJobArgs, opts ...pulumi.InvokeOption) (*LookupJobResult, error) {
	var rv LookupJobResult
	err := ctx.Invoke("google-native:transcoder/v1:getJob", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupJobArgs struct {
	JobId    string  `pulumi:"jobId"`
	Location string  `pulumi:"location"`
	Project  *string `pulumi:"project"`
}

type LookupJobResult struct {
	// The configuration for this job.
	Config JobConfigResponse `pulumi:"config"`
	// The time the job was created.
	CreateTime string `pulumi:"createTime"`
	// The time the transcoding finished.
	EndTime string `pulumi:"endTime"`
	// An error object that describes the reason for the failure. This property is always present when `state` is `FAILED`.
	Error StatusResponse `pulumi:"error"`
	// Input only. Specify the `input_uri` to populate empty `uri` fields in each element of `Job.config.inputs` or `JobTemplate.config.inputs` when using template. URI of the media. Input files must be at least 5 seconds in duration and stored in Cloud Storage (for example, `gs://bucket/inputs/file.mp4`). See [Supported input and output formats](https://cloud.google.com/transcoder/docs/concepts/supported-input-and-output-formats).
	InputUri string `pulumi:"inputUri"`
	// The resource name of the job. Format: `projects/{project_number}/locations/{location}/jobs/{job}`
	Name string `pulumi:"name"`
	// Input only. Specify the `output_uri` to populate an empty `Job.config.output.uri` or `JobTemplate.config.output.uri` when using template. URI for the output file(s). For example, `gs://my-bucket/outputs/`. See [Supported input and output formats](https://cloud.google.com/transcoder/docs/concepts/supported-input-and-output-formats).
	OutputUri string `pulumi:"outputUri"`
	// The time the transcoding started.
	StartTime string `pulumi:"startTime"`
	// The current state of the job.
	State string `pulumi:"state"`
	// Input only. Specify the `template_id` to use for populating `Job.config`. The default is `preset/web-hd`. Preset Transcoder templates: - `preset/{preset_id}` - User defined JobTemplate: `{job_template_id}`
	TemplateId string `pulumi:"templateId"`
	// Job time to live value in days, which will be effective after job completion. Job should be deleted automatically after the given TTL. Enter a value between 1 and 90. The default is 30.
	TtlAfterCompletionDays int `pulumi:"ttlAfterCompletionDays"`
}

func LookupJobOutput(ctx *pulumi.Context, args LookupJobOutputArgs, opts ...pulumi.InvokeOption) LookupJobResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupJobResult, error) {
			args := v.(LookupJobArgs)
			r, err := LookupJob(ctx, &args, opts...)
			var s LookupJobResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupJobResultOutput)
}

type LookupJobOutputArgs struct {
	JobId    pulumi.StringInput    `pulumi:"jobId"`
	Location pulumi.StringInput    `pulumi:"location"`
	Project  pulumi.StringPtrInput `pulumi:"project"`
}

func (LookupJobOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupJobArgs)(nil)).Elem()
}

type LookupJobResultOutput struct{ *pulumi.OutputState }

func (LookupJobResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupJobResult)(nil)).Elem()
}

func (o LookupJobResultOutput) ToLookupJobResultOutput() LookupJobResultOutput {
	return o
}

func (o LookupJobResultOutput) ToLookupJobResultOutputWithContext(ctx context.Context) LookupJobResultOutput {
	return o
}

// The configuration for this job.
func (o LookupJobResultOutput) Config() JobConfigResponseOutput {
	return o.ApplyT(func(v LookupJobResult) JobConfigResponse { return v.Config }).(JobConfigResponseOutput)
}

// The time the job was created.
func (o LookupJobResultOutput) CreateTime() pulumi.StringOutput {
	return o.ApplyT(func(v LookupJobResult) string { return v.CreateTime }).(pulumi.StringOutput)
}

// The time the transcoding finished.
func (o LookupJobResultOutput) EndTime() pulumi.StringOutput {
	return o.ApplyT(func(v LookupJobResult) string { return v.EndTime }).(pulumi.StringOutput)
}

// An error object that describes the reason for the failure. This property is always present when `state` is `FAILED`.
func (o LookupJobResultOutput) Error() StatusResponseOutput {
	return o.ApplyT(func(v LookupJobResult) StatusResponse { return v.Error }).(StatusResponseOutput)
}

// Input only. Specify the `input_uri` to populate empty `uri` fields in each element of `Job.config.inputs` or `JobTemplate.config.inputs` when using template. URI of the media. Input files must be at least 5 seconds in duration and stored in Cloud Storage (for example, `gs://bucket/inputs/file.mp4`). See [Supported input and output formats](https://cloud.google.com/transcoder/docs/concepts/supported-input-and-output-formats).
func (o LookupJobResultOutput) InputUri() pulumi.StringOutput {
	return o.ApplyT(func(v LookupJobResult) string { return v.InputUri }).(pulumi.StringOutput)
}

// The resource name of the job. Format: `projects/{project_number}/locations/{location}/jobs/{job}`
func (o LookupJobResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupJobResult) string { return v.Name }).(pulumi.StringOutput)
}

// Input only. Specify the `output_uri` to populate an empty `Job.config.output.uri` or `JobTemplate.config.output.uri` when using template. URI for the output file(s). For example, `gs://my-bucket/outputs/`. See [Supported input and output formats](https://cloud.google.com/transcoder/docs/concepts/supported-input-and-output-formats).
func (o LookupJobResultOutput) OutputUri() pulumi.StringOutput {
	return o.ApplyT(func(v LookupJobResult) string { return v.OutputUri }).(pulumi.StringOutput)
}

// The time the transcoding started.
func (o LookupJobResultOutput) StartTime() pulumi.StringOutput {
	return o.ApplyT(func(v LookupJobResult) string { return v.StartTime }).(pulumi.StringOutput)
}

// The current state of the job.
func (o LookupJobResultOutput) State() pulumi.StringOutput {
	return o.ApplyT(func(v LookupJobResult) string { return v.State }).(pulumi.StringOutput)
}

// Input only. Specify the `template_id` to use for populating `Job.config`. The default is `preset/web-hd`. Preset Transcoder templates: - `preset/{preset_id}` - User defined JobTemplate: `{job_template_id}`
func (o LookupJobResultOutput) TemplateId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupJobResult) string { return v.TemplateId }).(pulumi.StringOutput)
}

// Job time to live value in days, which will be effective after job completion. Job should be deleted automatically after the given TTL. Enter a value between 1 and 90. The default is 30.
func (o LookupJobResultOutput) TtlAfterCompletionDays() pulumi.IntOutput {
	return o.ApplyT(func(v LookupJobResult) int { return v.TtlAfterCompletionDays }).(pulumi.IntOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupJobResultOutput{})
}