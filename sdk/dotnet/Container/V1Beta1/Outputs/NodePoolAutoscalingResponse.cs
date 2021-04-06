// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.Container.V1Beta1.Outputs
{

    [OutputType]
    public sealed class NodePoolAutoscalingResponse
    {
        /// <summary>
        /// Can this node pool be deleted automatically.
        /// </summary>
        public readonly bool Autoprovisioned;
        /// <summary>
        /// Is autoscaling enabled for this node pool.
        /// </summary>
        public readonly bool Enabled;
        /// <summary>
        /// Maximum number of nodes in the NodePool. Must be &gt;= min_node_count. There has to enough quota to scale up the cluster.
        /// </summary>
        public readonly int MaxNodeCount;
        /// <summary>
        /// Minimum number of nodes in the NodePool. Must be &gt;= 1 and &lt;= max_node_count.
        /// </summary>
        public readonly int MinNodeCount;

        [OutputConstructor]
        private NodePoolAutoscalingResponse(
            bool autoprovisioned,

            bool enabled,

            int maxNodeCount,

            int minNodeCount)
        {
            Autoprovisioned = autoprovisioned;
            Enabled = enabled;
            MaxNodeCount = maxNodeCount;
            MinNodeCount = minNodeCount;
        }
    }
}