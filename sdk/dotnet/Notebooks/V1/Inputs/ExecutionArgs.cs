// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.Notebooks.V1.Inputs
{

    /// <summary>
    /// The definition of a single executed notebook.
    /// </summary>
    public sealed class ExecutionArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Output only. Time the Execution was instantiated.
        /// </summary>
        [Input("createTime")]
        public Input<string>? CreateTime { get; set; }

        /// <summary>
        /// A brief description of this execution.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Output only. Name used for UI purposes. Name can only contain alphanumeric characters and underscores '_'.
        /// </summary>
        [Input("displayName")]
        public Input<string>? DisplayName { get; set; }

        /// <summary>
        /// execute metadata including name, hardware spec, region, labels, etc.
        /// </summary>
        [Input("executionTemplate")]
        public Input<Inputs.ExecutionTemplateArgs>? ExecutionTemplate { get; set; }

        /// <summary>
        /// Output only. The resource name of the execute. Format: `projects/{project_id}/locations/{location}/execution/{execution_id}
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Output notebook file generated by this execution
        /// </summary>
        [Input("outputNotebookFile")]
        public Input<string>? OutputNotebookFile { get; set; }

        /// <summary>
        /// Output only. State of the underlying AI Platform job.
        /// </summary>
        [Input("state")]
        public Input<string>? State { get; set; }

        /// <summary>
        /// Output only. Time the Execution was last updated.
        /// </summary>
        [Input("updateTime")]
        public Input<string>? UpdateTime { get; set; }

        public ExecutionArgs()
        {
        }
    }
}