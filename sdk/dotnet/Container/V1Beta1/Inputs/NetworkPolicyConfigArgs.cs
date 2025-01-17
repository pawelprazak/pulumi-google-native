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
    /// Configuration for NetworkPolicy. This only tracks whether the addon is enabled or not on the Master, it does not track whether network policy is enabled for the nodes.
    /// </summary>
    public sealed class NetworkPolicyConfigArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Whether NetworkPolicy is enabled for this cluster.
        /// </summary>
        [Input("disabled")]
        public Input<bool>? Disabled { get; set; }

        public NetworkPolicyConfigArgs()
        {
        }
    }
}
