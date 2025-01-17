// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.DataLabeling.V1Beta1
{
    /// <summary>
    /// Creates an evaluation job.
    /// Auto-naming is currently not supported for this resource.
    /// </summary>
    [GoogleNativeResourceType("google-native:datalabeling/v1beta1:EvaluationJob")]
    public partial class EvaluationJob : Pulumi.CustomResource
    {
        /// <summary>
        /// Name of the AnnotationSpecSet describing all the labels that your machine learning model outputs. You must create this resource before you create an evaluation job and provide its name in the following format: "projects/{project_id}/annotationSpecSets/{annotation_spec_set_id}"
        /// </summary>
        [Output("annotationSpecSet")]
        public Output<string> AnnotationSpecSet { get; private set; } = null!;

        /// <summary>
        /// Every time the evaluation job runs and an error occurs, the failed attempt is appended to this array.
        /// </summary>
        [Output("attempts")]
        public Output<ImmutableArray<Outputs.GoogleCloudDatalabelingV1beta1AttemptResponse>> Attempts { get; private set; } = null!;

        /// <summary>
        /// Timestamp of when this evaluation job was created.
        /// </summary>
        [Output("createTime")]
        public Output<string> CreateTime { get; private set; } = null!;

        /// <summary>
        /// Description of the job. The description can be up to 25,000 characters long.
        /// </summary>
        [Output("description")]
        public Output<string> Description { get; private set; } = null!;

        /// <summary>
        /// Configuration details for the evaluation job.
        /// </summary>
        [Output("evaluationJobConfig")]
        public Output<Outputs.GoogleCloudDatalabelingV1beta1EvaluationJobConfigResponse> EvaluationJobConfig { get; private set; } = null!;

        /// <summary>
        /// Whether you want Data Labeling Service to provide ground truth labels for prediction input. If you want the service to assign human labelers to annotate your data, set this to `true`. If you want to provide your own ground truth labels in the evaluation job's BigQuery table, set this to `false`.
        /// </summary>
        [Output("labelMissingGroundTruth")]
        public Output<bool> LabelMissingGroundTruth { get; private set; } = null!;

        /// <summary>
        /// The [AI Platform Prediction model version](/ml-engine/docs/prediction-overview) to be evaluated. Prediction input and output is sampled from this model version. When creating an evaluation job, specify the model version in the following format: "projects/{project_id}/models/{model_name}/versions/{version_name}" There can only be one evaluation job per model version.
        /// </summary>
        [Output("modelVersion")]
        public Output<string> ModelVersion { get; private set; } = null!;

        /// <summary>
        /// After you create a job, Data Labeling Service assigns a name to the job with the following format: "projects/{project_id}/evaluationJobs/ {evaluation_job_id}"
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        [Output("project")]
        public Output<string> Project { get; private set; } = null!;

        /// <summary>
        /// Describes the interval at which the job runs. This interval must be at least 1 day, and it is rounded to the nearest day. For example, if you specify a 50-hour interval, the job runs every 2 days. You can provide the schedule in [crontab format](/scheduler/docs/configuring/cron-job-schedules) or in an [English-like format](/appengine/docs/standard/python/config/cronref#schedule_format). Regardless of what you specify, the job will run at 10:00 AM UTC. Only the interval from this schedule is used, not the specific time of day.
        /// </summary>
        [Output("schedule")]
        public Output<string> Schedule { get; private set; } = null!;

        /// <summary>
        /// Describes the current state of the job.
        /// </summary>
        [Output("state")]
        public Output<string> State { get; private set; } = null!;


        /// <summary>
        /// Create a EvaluationJob resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public EvaluationJob(string name, EvaluationJobArgs args, CustomResourceOptions? options = null)
            : base("google-native:datalabeling/v1beta1:EvaluationJob", name, args ?? new EvaluationJobArgs(), MakeResourceOptions(options, ""))
        {
        }

        private EvaluationJob(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("google-native:datalabeling/v1beta1:EvaluationJob", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing EvaluationJob resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static EvaluationJob Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new EvaluationJob(name, id, options);
        }
    }

    public sealed class EvaluationJobArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Name of the AnnotationSpecSet describing all the labels that your machine learning model outputs. You must create this resource before you create an evaluation job and provide its name in the following format: "projects/{project_id}/annotationSpecSets/{annotation_spec_set_id}"
        /// </summary>
        [Input("annotationSpecSet", required: true)]
        public Input<string> AnnotationSpecSet { get; set; } = null!;

        /// <summary>
        /// Description of the job. The description can be up to 25,000 characters long.
        /// </summary>
        [Input("description", required: true)]
        public Input<string> Description { get; set; } = null!;

        /// <summary>
        /// Configuration details for the evaluation job.
        /// </summary>
        [Input("evaluationJobConfig", required: true)]
        public Input<Inputs.GoogleCloudDatalabelingV1beta1EvaluationJobConfigArgs> EvaluationJobConfig { get; set; } = null!;

        /// <summary>
        /// Whether you want Data Labeling Service to provide ground truth labels for prediction input. If you want the service to assign human labelers to annotate your data, set this to `true`. If you want to provide your own ground truth labels in the evaluation job's BigQuery table, set this to `false`.
        /// </summary>
        [Input("labelMissingGroundTruth", required: true)]
        public Input<bool> LabelMissingGroundTruth { get; set; } = null!;

        /// <summary>
        /// The [AI Platform Prediction model version](/ml-engine/docs/prediction-overview) to be evaluated. Prediction input and output is sampled from this model version. When creating an evaluation job, specify the model version in the following format: "projects/{project_id}/models/{model_name}/versions/{version_name}" There can only be one evaluation job per model version.
        /// </summary>
        [Input("modelVersion", required: true)]
        public Input<string> ModelVersion { get; set; } = null!;

        [Input("project")]
        public Input<string>? Project { get; set; }

        /// <summary>
        /// Describes the interval at which the job runs. This interval must be at least 1 day, and it is rounded to the nearest day. For example, if you specify a 50-hour interval, the job runs every 2 days. You can provide the schedule in [crontab format](/scheduler/docs/configuring/cron-job-schedules) or in an [English-like format](/appengine/docs/standard/python/config/cronref#schedule_format). Regardless of what you specify, the job will run at 10:00 AM UTC. Only the interval from this schedule is used, not the specific time of day.
        /// </summary>
        [Input("schedule", required: true)]
        public Input<string> Schedule { get; set; } = null!;

        public EvaluationJobArgs()
        {
        }
    }
}
