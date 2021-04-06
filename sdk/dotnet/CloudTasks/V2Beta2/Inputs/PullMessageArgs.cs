// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.CloudTasks.V2Beta2.Inputs
{

    /// <summary>
    /// The pull message contains data that can be used by the caller of LeaseTasks to process the task. This proto can only be used for tasks in a queue which has pull_target set.
    /// </summary>
    public sealed class PullMessageArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A data payload consumed by the worker to execute the task.
        /// </summary>
        [Input("payload")]
        public Input<string>? Payload { get; set; }

        /// <summary>
        /// The task's tag. Tags allow similar tasks to be processed in a batch. If you label tasks with a tag, your worker can lease tasks with the same tag using filter. For example, if you want to aggregate the events associated with a specific user once a day, you could tag tasks with the user ID. The task's tag can only be set when the task is created. The tag must be less than 500 characters. SDK compatibility: Although the SDK allows tags to be either string or [bytes](https://cloud.google.com/appengine/docs/standard/java/javadoc/com/google/appengine/api/taskqueue/TaskOptions.html#tag-byte:A-), only UTF-8 encoded tags can be used in Cloud Tasks. If a tag isn't UTF-8 encoded, the tag will be empty when the task is returned by Cloud Tasks.
        /// </summary>
        [Input("tag")]
        public Input<string>? Tag { get; set; }

        public PullMessageArgs()
        {
        }
    }
}