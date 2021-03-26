// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.Dataproc.V1.Inputs
{

    /// <summary>
    /// The status of a cluster and its instances.
    /// </summary>
    public sealed class ClusterStatusArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Optional. Output only. Details of cluster's state.
        /// </summary>
        [Input("detail")]
        public Input<string>? Detail { get; set; }

        /// <summary>
        /// Output only. The cluster's state.
        /// </summary>
        [Input("state")]
        public Input<string>? State { get; set; }

        /// <summary>
        /// Output only. Time when this state was entered (see JSON representation of Timestamp (https://developers.google.com/protocol-buffers/docs/proto3#json)).
        /// </summary>
        [Input("stateStartTime")]
        public Input<string>? StateStartTime { get; set; }

        /// <summary>
        /// Output only. Additional state information that includes status reported by the agent.
        /// </summary>
        [Input("substate")]
        public Input<string>? Substate { get; set; }

        public ClusterStatusArgs()
        {
        }
    }
}