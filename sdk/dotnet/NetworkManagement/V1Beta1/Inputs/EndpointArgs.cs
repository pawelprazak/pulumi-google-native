// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.NetworkManagement.V1Beta1.Inputs
{

    /// <summary>
    /// Source or destination of the Connectivity Test.
    /// </summary>
    public sealed class EndpointArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A [Cloud function](https://cloud.google.com/functions).
        /// </summary>
        [Input("cloudFunction")]
        public Input<Inputs.CloudFunctionEndpointArgs>? CloudFunction { get; set; }

        /// <summary>
        /// A [Cloud SQL](https://cloud.google.com/sql) instance URI.
        /// </summary>
        [Input("cloudSqlInstance")]
        public Input<string>? CloudSqlInstance { get; set; }

        /// <summary>
        /// A cluster URI for [Google Kubernetes Engine master](https://cloud.google.com/kubernetes-engine/docs/concepts/cluster-architecture).
        /// </summary>
        [Input("gkeMasterCluster")]
        public Input<string>? GkeMasterCluster { get; set; }

        /// <summary>
        /// A Compute Engine instance URI.
        /// </summary>
        [Input("instance")]
        public Input<string>? Instance { get; set; }

        /// <summary>
        /// The IP address of the endpoint, which can be an external or internal IP. An IPv6 address is only allowed when the test's destination is a [global load balancer VIP](https://cloud.google.com/load-balancing/docs/load-balancing-overview).
        /// </summary>
        [Input("ipAddress")]
        public Input<string>? IpAddress { get; set; }

        /// <summary>
        /// A Compute Engine network URI.
        /// </summary>
        [Input("network")]
        public Input<string>? Network { get; set; }

        /// <summary>
        /// Type of the network where the endpoint is located. Applicable only to source endpoint, as destination network type can be inferred from the source.
        /// </summary>
        [Input("networkType")]
        public Input<Pulumi.GoogleNative.NetworkManagement.V1Beta1.EndpointNetworkType>? NetworkType { get; set; }

        /// <summary>
        /// The IP protocol port of the endpoint. Only applicable when protocol is TCP or UDP.
        /// </summary>
        [Input("port")]
        public Input<int>? Port { get; set; }

        /// <summary>
        /// Project ID where the endpoint is located. The Project ID can be derived from the URI if you provide a VM instance or network URI. The following are two cases where you must provide the project ID: 1. Only the IP address is specified, and the IP address is within a GCP project. 2. When you are using Shared VPC and the IP address that you provide is from the service project. In this case, the network that the IP address resides in is defined in the host project.
        /// </summary>
        [Input("project")]
        public Input<string>? Project { get; set; }

        public EndpointArgs()
        {
        }
    }
}
