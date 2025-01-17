// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.Run.V1.Outputs
{

    /// <summary>
    /// JobStatus represents the current state of a Job.
    /// </summary>
    [OutputType]
    public sealed class JobStatusResponse
    {
        /// <summary>
        /// The latest available observations of a job's current state. More info: https://kubernetes.io/docs/concepts/workloads/controllers/jobs-run-to-completion/
        /// </summary>
        public readonly ImmutableArray<Outputs.GoogleCloudRunV1ConditionResponse> Conditions;
        /// <summary>
        /// Number of executions created for this job.
        /// </summary>
        public readonly int ExecutionCount;
        /// <summary>
        /// A pointer to the most recently created execution for this job. This is set regardless of the eventual state of the execution.
        /// </summary>
        public readonly Outputs.ExecutionReferenceResponse LatestCreatedExecution;
        /// <summary>
        /// The 'generation' of the job that was last processed by the controller.
        /// </summary>
        public readonly int ObservedGeneration;

        [OutputConstructor]
        private JobStatusResponse(
            ImmutableArray<Outputs.GoogleCloudRunV1ConditionResponse> conditions,

            int executionCount,

            Outputs.ExecutionReferenceResponse latestCreatedExecution,

            int observedGeneration)
        {
            Conditions = conditions;
            ExecutionCount = executionCount;
            LatestCreatedExecution = latestCreatedExecution;
            ObservedGeneration = observedGeneration;
        }
    }
}
