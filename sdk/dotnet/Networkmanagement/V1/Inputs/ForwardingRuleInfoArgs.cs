// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.Networkmanagement.V1.Inputs
{

    /// <summary>
    /// For display only. Metadata associated with a Compute Engine forwarding rule.
    /// </summary>
    public sealed class ForwardingRuleInfoArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Name of a Compute Engine forwarding rule.
        /// </summary>
        [Input("displayName")]
        public Input<string>? DisplayName { get; set; }

        /// <summary>
        /// Port range defined in the forwarding rule that matches the test.
        /// </summary>
        [Input("matchedPortRange")]
        public Input<string>? MatchedPortRange { get; set; }

        /// <summary>
        /// Protocol defined in the forwarding rule that matches the test.
        /// </summary>
        [Input("matchedProtocol")]
        public Input<string>? MatchedProtocol { get; set; }

        /// <summary>
        /// Network URI. Only valid for Internal Load Balancer.
        /// </summary>
        [Input("networkUri")]
        public Input<string>? NetworkUri { get; set; }

        /// <summary>
        /// Target type of the forwarding rule.
        /// </summary>
        [Input("target")]
        public Input<string>? Target { get; set; }

        /// <summary>
        /// URI of a Compute Engine forwarding rule.
        /// </summary>
        [Input("uri")]
        public Input<string>? Uri { get; set; }

        /// <summary>
        /// VIP of the forwarding rule.
        /// </summary>
        [Input("vip")]
        public Input<string>? Vip { get; set; }

        public ForwardingRuleInfoArgs()
        {
        }
    }
}