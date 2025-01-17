// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.Dataplex.V1
{
    /// <summary>
    /// Creates a task resource within a lake.
    /// Auto-naming is currently not supported for this resource.
    /// </summary>
    [GoogleNativeResourceType("google-native:dataplex/v1:Task")]
    public partial class Task : Pulumi.CustomResource
    {
        /// <summary>
        /// The time when the task was created.
        /// </summary>
        [Output("createTime")]
        public Output<string> CreateTime { get; private set; } = null!;

        /// <summary>
        /// Optional. Description of the task.
        /// </summary>
        [Output("description")]
        public Output<string> Description { get; private set; } = null!;

        /// <summary>
        /// Optional. User friendly display name.
        /// </summary>
        [Output("displayName")]
        public Output<string> DisplayName { get; private set; } = null!;

        /// <summary>
        /// Spec related to how a task is executed.
        /// </summary>
        [Output("executionSpec")]
        public Output<Outputs.GoogleCloudDataplexV1TaskExecutionSpecResponse> ExecutionSpec { get; private set; } = null!;

        /// <summary>
        /// Status of the latest task executions.
        /// </summary>
        [Output("executionStatus")]
        public Output<Outputs.GoogleCloudDataplexV1TaskExecutionStatusResponse> ExecutionStatus { get; private set; } = null!;

        /// <summary>
        /// Optional. User-defined labels for the task.
        /// </summary>
        [Output("labels")]
        public Output<ImmutableDictionary<string, string>> Labels { get; private set; } = null!;

        [Output("lakeId")]
        public Output<string> LakeId { get; private set; } = null!;

        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// The relative resource name of the task, of the form: projects/{project_number}/locations/{location_id}/lakes/{lake_id}/ tasks/{task_id}.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        [Output("project")]
        public Output<string> Project { get; private set; } = null!;

        /// <summary>
        /// Config related to running custom Spark tasks.
        /// </summary>
        [Output("spark")]
        public Output<Outputs.GoogleCloudDataplexV1TaskSparkTaskConfigResponse> Spark { get; private set; } = null!;

        /// <summary>
        /// Current state of the task.
        /// </summary>
        [Output("state")]
        public Output<string> State { get; private set; } = null!;

        /// <summary>
        /// Required. Task identifier.
        /// </summary>
        [Output("taskId")]
        public Output<string> TaskId { get; private set; } = null!;

        /// <summary>
        /// Spec related to how often and when a task should be triggered.
        /// </summary>
        [Output("triggerSpec")]
        public Output<Outputs.GoogleCloudDataplexV1TaskTriggerSpecResponse> TriggerSpec { get; private set; } = null!;

        /// <summary>
        /// System generated globally unique ID for the task. This ID will be different if the task is deleted and re-created with the same name.
        /// </summary>
        [Output("uid")]
        public Output<string> Uid { get; private set; } = null!;

        /// <summary>
        /// The time when the task was last updated.
        /// </summary>
        [Output("updateTime")]
        public Output<string> UpdateTime { get; private set; } = null!;

        /// <summary>
        /// Optional. Only validate the request, but do not perform mutations. The default is false.
        /// </summary>
        [Output("validateOnly")]
        public Output<string?> ValidateOnly { get; private set; } = null!;


        /// <summary>
        /// Create a Task resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Task(string name, TaskArgs args, CustomResourceOptions? options = null)
            : base("google-native:dataplex/v1:Task", name, args ?? new TaskArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Task(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("google-native:dataplex/v1:Task", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing Task resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Task Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Task(name, id, options);
        }
    }

    public sealed class TaskArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Optional. Description of the task.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Optional. User friendly display name.
        /// </summary>
        [Input("displayName")]
        public Input<string>? DisplayName { get; set; }

        /// <summary>
        /// Spec related to how a task is executed.
        /// </summary>
        [Input("executionSpec", required: true)]
        public Input<Inputs.GoogleCloudDataplexV1TaskExecutionSpecArgs> ExecutionSpec { get; set; } = null!;

        [Input("labels")]
        private InputMap<string>? _labels;

        /// <summary>
        /// Optional. User-defined labels for the task.
        /// </summary>
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        [Input("lakeId", required: true)]
        public Input<string> LakeId { get; set; } = null!;

        [Input("location")]
        public Input<string>? Location { get; set; }

        [Input("project")]
        public Input<string>? Project { get; set; }

        /// <summary>
        /// Config related to running custom Spark tasks.
        /// </summary>
        [Input("spark")]
        public Input<Inputs.GoogleCloudDataplexV1TaskSparkTaskConfigArgs>? Spark { get; set; }

        /// <summary>
        /// Required. Task identifier.
        /// </summary>
        [Input("taskId", required: true)]
        public Input<string> TaskId { get; set; } = null!;

        /// <summary>
        /// Spec related to how often and when a task should be triggered.
        /// </summary>
        [Input("triggerSpec", required: true)]
        public Input<Inputs.GoogleCloudDataplexV1TaskTriggerSpecArgs> TriggerSpec { get; set; } = null!;

        /// <summary>
        /// Optional. Only validate the request, but do not perform mutations. The default is false.
        /// </summary>
        [Input("validateOnly")]
        public Input<string>? ValidateOnly { get; set; }

        public TaskArgs()
        {
        }
    }
}
