// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.Run.V2.Outputs
{

    /// <summary>
    /// ExecutionTemplate describes the data an execution should have when created from a template.
    /// </summary>
    [OutputType]
    public sealed class GoogleCloudRunV2ExecutionTemplateResponse
    {
        /// <summary>
        /// KRM-style annotations for the resource.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Annotations;
        /// <summary>
        /// KRM-style labels for the resource.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Labels;
        /// <summary>
        /// Specifies the maximum desired number of tasks the execution should run at given time. Must be &lt;= task_count. When the job is run, if this field is 0 or unset, the maximum possible value will be used for that execution. The actual number of tasks running in steady state will be less than this number when there are fewer tasks waiting to be completed remaining, i.e. when the work left to do is less than max parallelism.
        /// </summary>
        public readonly int Parallelism;
        /// <summary>
        /// Specifies the desired number of tasks the execution should run. Setting to 1 means that parallelism is limited to 1 and the success of that task signals the success of the execution. More info: https://kubernetes.io/docs/concepts/workloads/controllers/jobs-run-to-completion/
        /// </summary>
        public readonly int TaskCount;
        /// <summary>
        /// Describes the task(s) that will be created when executing an execution.
        /// </summary>
        public readonly Outputs.GoogleCloudRunV2TaskTemplateResponse Template;

        [OutputConstructor]
        private GoogleCloudRunV2ExecutionTemplateResponse(
            ImmutableDictionary<string, string> annotations,

            ImmutableDictionary<string, string> labels,

            int parallelism,

            int taskCount,

            Outputs.GoogleCloudRunV2TaskTemplateResponse template)
        {
            Annotations = annotations;
            Labels = labels;
            Parallelism = parallelism;
            TaskCount = taskCount;
            Template = template;
        }
    }
}
