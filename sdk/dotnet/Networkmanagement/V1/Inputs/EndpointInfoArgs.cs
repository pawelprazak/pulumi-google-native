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
    /// For display only. The specification of the endpoints for the test. EndpointInfo is derived from source and destination Endpoint and validated by the backend data plane model.
    /// </summary>
    public sealed class EndpointInfoArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Destination IP address.
        /// </summary>
        [Input("destinationIp")]
        public Input<string>? DestinationIp { get; set; }

        /// <summary>
        /// URI of the network where this packet is sent to.
        /// </summary>
        [Input("destinationNetworkUri")]
        public Input<string>? DestinationNetworkUri { get; set; }

        /// <summary>
        /// Destination port. Only valid when protocol is TCP or UDP.
        /// </summary>
        [Input("destinationPort")]
        public Input<int>? DestinationPort { get; set; }

        /// <summary>
        /// IP protocol in string format, for example: "TCP", "UDP", "ICMP".
        /// </summary>
        [Input("protocol")]
        public Input<string>? Protocol { get; set; }

        /// <summary>
        /// Source IP address.
        /// </summary>
        [Input("sourceIp")]
        public Input<string>? SourceIp { get; set; }

        /// <summary>
        /// URI of the network where this packet originates from.
        /// </summary>
        [Input("sourceNetworkUri")]
        public Input<string>? SourceNetworkUri { get; set; }

        /// <summary>
        /// Source port. Only valid when protocol is TCP or UDP.
        /// </summary>
        [Input("sourcePort")]
        public Input<int>? SourcePort { get; set; }

        public EndpointInfoArgs()
        {
        }
    }
}