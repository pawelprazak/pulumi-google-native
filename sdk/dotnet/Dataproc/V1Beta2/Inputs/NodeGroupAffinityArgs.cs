// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.Dataproc.V1Beta2.Inputs
{

    /// <summary>
    /// Node Group Affinity for clusters using sole-tenant node groups.
    /// </summary>
    public sealed class NodeGroupAffinityArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The URI of a sole-tenant node group resource (https://cloud.google.com/compute/docs/reference/rest/v1/nodeGroups) that the cluster will be created on.A full URL, partial URI, or node group name are valid. Examples: https://www.googleapis.com/compute/v1/projects/[project_id]/zones/us-central1-a/nodeGroups/node-group-1 projects/[project_id]/zones/us-central1-a/nodeGroups/node-group-1 node-group-1
        /// </summary>
        [Input("nodeGroupUri", required: true)]
        public Input<string> NodeGroupUri { get; set; } = null!;

        public NodeGroupAffinityArgs()
        {
        }
    }
}
