// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.CloudTasks.V2
{
    public static class GetQueue
    {
        /// <summary>
        /// Gets a queue.
        /// </summary>
        public static Task<GetQueueResult> InvokeAsync(GetQueueArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetQueueResult>("google-native:cloudtasks/v2:getQueue", args ?? new GetQueueArgs(), options.WithDefaults());

        /// <summary>
        /// Gets a queue.
        /// </summary>
        public static Output<GetQueueResult> Invoke(GetQueueInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetQueueResult>("google-native:cloudtasks/v2:getQueue", args ?? new GetQueueInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetQueueArgs : Pulumi.InvokeArgs
    {
        [Input("location", required: true)]
        public string Location { get; set; } = null!;

        [Input("project")]
        public string? Project { get; set; }

        [Input("queueId", required: true)]
        public string QueueId { get; set; } = null!;

        public GetQueueArgs()
        {
        }
    }

    public sealed class GetQueueInvokeArgs : Pulumi.InvokeArgs
    {
        [Input("location", required: true)]
        public Input<string> Location { get; set; } = null!;

        [Input("project")]
        public Input<string>? Project { get; set; }

        [Input("queueId", required: true)]
        public Input<string> QueueId { get; set; } = null!;

        public GetQueueInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetQueueResult
    {
        /// <summary>
        /// Overrides for task-level app_engine_routing. These settings apply only to App Engine tasks in this queue. Http tasks are not affected. If set, `app_engine_routing_override` is used for all App Engine tasks in the queue, no matter what the setting is for the task-level app_engine_routing.
        /// </summary>
        public readonly Outputs.AppEngineRoutingResponse AppEngineRoutingOverride;
        /// <summary>
        /// Caller-specified and required in CreateQueue, after which it becomes output only. The queue name. The queue name must have the following format: `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID` * `PROJECT_ID` can contain letters ([A-Za-z]), numbers ([0-9]), hyphens (-), colons (:), or periods (.). For more information, see [Identifying projects](https://cloud.google.com/resource-manager/docs/creating-managing-projects#identifying_projects) * `LOCATION_ID` is the canonical ID for the queue's location. The list of available locations can be obtained by calling ListLocations. For more information, see https://cloud.google.com/about/locations/. * `QUEUE_ID` can contain letters ([A-Za-z]), numbers ([0-9]), or hyphens (-). The maximum length is 100 characters.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The last time this queue was purged. All tasks that were created before this time were purged. A queue can be purged using PurgeQueue, the [App Engine Task Queue SDK, or the Cloud Console](https://cloud.google.com/appengine/docs/standard/python/taskqueue/push/deleting-tasks-and-queues#purging_all_tasks_from_a_queue). Purge time will be truncated to the nearest microsecond. Purge time will be unset if the queue has never been purged.
        /// </summary>
        public readonly string PurgeTime;
        /// <summary>
        /// Rate limits for task dispatches. rate_limits and retry_config are related because they both control task attempts. However they control task attempts in different ways: * rate_limits controls the total rate of dispatches from a queue (i.e. all traffic dispatched from the queue, regardless of whether the dispatch is from a first attempt or a retry). * retry_config controls what happens to particular a task after its first attempt fails. That is, retry_config controls task retries (the second attempt, third attempt, etc). The queue's actual dispatch rate is the result of: * Number of tasks in the queue * User-specified throttling: rate_limits, retry_config, and the queue's state. * System throttling due to `429` (Too Many Requests) or `503` (Service Unavailable) responses from the worker, high error rates, or to smooth sudden large traffic spikes.
        /// </summary>
        public readonly Outputs.RateLimitsResponse RateLimits;
        /// <summary>
        /// Settings that determine the retry behavior. * For tasks created using Cloud Tasks: the queue-level retry settings apply to all tasks in the queue that were created using Cloud Tasks. Retry settings cannot be set on individual tasks. * For tasks created using the App Engine SDK: the queue-level retry settings apply to all tasks in the queue which do not have retry settings explicitly set on the task and were created by the App Engine SDK. See [App Engine documentation](https://cloud.google.com/appengine/docs/standard/python/taskqueue/push/retrying-tasks).
        /// </summary>
        public readonly Outputs.RetryConfigResponse RetryConfig;
        /// <summary>
        /// Configuration options for writing logs to [Stackdriver Logging](https://cloud.google.com/logging/docs/). If this field is unset, then no logs are written.
        /// </summary>
        public readonly Outputs.StackdriverLoggingConfigResponse StackdriverLoggingConfig;
        /// <summary>
        /// The state of the queue. `state` can only be changed by calling PauseQueue, ResumeQueue, or uploading [queue.yaml/xml](https://cloud.google.com/appengine/docs/python/config/queueref). UpdateQueue cannot be used to change `state`.
        /// </summary>
        public readonly string State;

        [OutputConstructor]
        private GetQueueResult(
            Outputs.AppEngineRoutingResponse appEngineRoutingOverride,

            string name,

            string purgeTime,

            Outputs.RateLimitsResponse rateLimits,

            Outputs.RetryConfigResponse retryConfig,

            Outputs.StackdriverLoggingConfigResponse stackdriverLoggingConfig,

            string state)
        {
            AppEngineRoutingOverride = appEngineRoutingOverride;
            Name = name;
            PurgeTime = purgeTime;
            RateLimits = rateLimits;
            RetryConfig = retryConfig;
            StackdriverLoggingConfig = stackdriverLoggingConfig;
            State = state;
        }
    }
}
