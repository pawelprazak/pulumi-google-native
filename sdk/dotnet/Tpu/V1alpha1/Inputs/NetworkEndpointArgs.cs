// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.Tpu.V1alpha1.Inputs
{

    /// <summary>
    /// A network endpoint over which a TPU worker can be reached.
    /// </summary>
    public sealed class NetworkEndpointArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The IP address of this network endpoint.
        /// </summary>
        [Input("ipAddress")]
        public Input<string>? IpAddress { get; set; }

        /// <summary>
        /// The port of this network endpoint.
        /// </summary>
        [Input("port")]
        public Input<int>? Port { get; set; }

        public NetworkEndpointArgs()
        {
        }
    }
}