// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.Container.V1Beta1.Inputs
{

    /// <summary>
    /// Contains information about amount of some resource in the cluster. For memory, value should be in GB.
    /// </summary>
    public sealed class ResourceLimitArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Maximum amount of the resource in the cluster.
        /// </summary>
        [Input("maximum")]
        public Input<string>? Maximum { get; set; }

        /// <summary>
        /// Minimum amount of the resource in the cluster.
        /// </summary>
        [Input("minimum")]
        public Input<string>? Minimum { get; set; }

        /// <summary>
        /// Resource name "cpu", "memory" or gpu-specific string.
        /// </summary>
        [Input("resourceType")]
        public Input<string>? ResourceType { get; set; }

        public ResourceLimitArgs()
        {
        }
    }
}
