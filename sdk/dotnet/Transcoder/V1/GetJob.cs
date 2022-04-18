// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.Transcoder.V1
{
    public static class GetJob
    {
        /// <summary>
        /// Returns the job data.
        /// </summary>
        public static Task<GetJobResult> InvokeAsync(GetJobArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetJobResult>("google-native:transcoder/v1:getJob", args ?? new GetJobArgs(), options.WithDefaults());

        /// <summary>
        /// Returns the job data.
        /// </summary>
        public static Output<GetJobResult> Invoke(GetJobInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetJobResult>("google-native:transcoder/v1:getJob", args ?? new GetJobInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetJobArgs : Pulumi.InvokeArgs
    {
        [Input("jobId", required: true)]
        public string JobId { get; set; } = null!;

        [Input("location", required: true)]
        public string Location { get; set; } = null!;

        [Input("project")]
        public string? Project { get; set; }

        public GetJobArgs()
        {
        }
    }

    public sealed class GetJobInvokeArgs : Pulumi.InvokeArgs
    {
        [Input("jobId", required: true)]
        public Input<string> JobId { get; set; } = null!;

        [Input("location", required: true)]
        public Input<string> Location { get; set; } = null!;

        [Input("project")]
        public Input<string>? Project { get; set; }

        public GetJobInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetJobResult
    {
        /// <summary>
        /// The configuration for this job.
        /// </summary>
        public readonly Outputs.JobConfigResponse Config;
        /// <summary>
        /// The time the job was created.
        /// </summary>
        public readonly string CreateTime;
        /// <summary>
        /// The time the transcoding finished.
        /// </summary>
        public readonly string EndTime;
        /// <summary>
        /// An error object that describes the reason for the failure. This property is always present when `state` is `FAILED`.
        /// </summary>
        public readonly Outputs.StatusResponse Error;
        /// <summary>
        /// Input only. Specify the `input_uri` to populate empty `uri` fields in each element of `Job.config.inputs` or `JobTemplate.config.inputs` when using template. URI of the media. Input files must be at least 5 seconds in duration and stored in Cloud Storage (for example, `gs://bucket/inputs/file.mp4`). See [Supported input and output formats](https://cloud.google.com/transcoder/docs/concepts/supported-input-and-output-formats).
        /// </summary>
        public readonly string InputUri;
        /// <summary>
        /// The resource name of the job. Format: `projects/{project_number}/locations/{location}/jobs/{job}`
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Input only. Specify the `output_uri` to populate an empty `Job.config.output.uri` or `JobTemplate.config.output.uri` when using template. URI for the output file(s). For example, `gs://my-bucket/outputs/`. See [Supported input and output formats](https://cloud.google.com/transcoder/docs/concepts/supported-input-and-output-formats).
        /// </summary>
        public readonly string OutputUri;
        /// <summary>
        /// The time the transcoding started.
        /// </summary>
        public readonly string StartTime;
        /// <summary>
        /// The current state of the job.
        /// </summary>
        public readonly string State;
        /// <summary>
        /// Input only. Specify the `template_id` to use for populating `Job.config`. The default is `preset/web-hd`. Preset Transcoder templates: - `preset/{preset_id}` - User defined JobTemplate: `{job_template_id}`
        /// </summary>
        public readonly string TemplateId;
        /// <summary>
        /// Job time to live value in days, which will be effective after job completion. Job should be deleted automatically after the given TTL. Enter a value between 1 and 90. The default is 30.
        /// </summary>
        public readonly int TtlAfterCompletionDays;

        [OutputConstructor]
        private GetJobResult(
            Outputs.JobConfigResponse config,

            string createTime,

            string endTime,

            Outputs.StatusResponse error,

            string inputUri,

            string name,

            string outputUri,

            string startTime,

            string state,

            string templateId,

            int ttlAfterCompletionDays)
        {
            Config = config;
            CreateTime = createTime;
            EndTime = endTime;
            Error = error;
            InputUri = inputUri;
            Name = name;
            OutputUri = outputUri;
            StartTime = startTime;
            State = state;
            TemplateId = templateId;
            TtlAfterCompletionDays = ttlAfterCompletionDays;
        }
    }
}