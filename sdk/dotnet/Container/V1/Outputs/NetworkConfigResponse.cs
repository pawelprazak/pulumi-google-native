// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.Container.V1.Outputs
{

    [OutputType]
    public sealed class NetworkConfigResponse
    {
        /// <summary>
        /// Whether the cluster disables default in-node sNAT rules. In-node sNAT rules will be disabled when default_snat_status is disabled. When disabled is set to false, default IP masquerade rules will be applied to the nodes to prevent sNAT on cluster internal traffic.
        /// </summary>
        public readonly Outputs.DefaultSnatStatusResponse DefaultSnatStatus;
        /// <summary>
        /// Whether Intra-node visibility is enabled for this cluster. This makes same node pod to pod traffic visible for VPC network.
        /// </summary>
        public readonly bool EnableIntraNodeVisibility;
        /// <summary>
        /// The relative name of the Google Compute Engine network(https://cloud.google.com/compute/docs/networks-and-firewalls#networks) to which the cluster is connected. Example: projects/my-project/global/networks/my-network
        /// </summary>
        public readonly string Network;
        /// <summary>
        /// The desired state of IPv6 connectivity to Google Services. By default, no private IPv6 access to or from Google Services (all access will be via IPv4)
        /// </summary>
        public readonly string PrivateIpv6GoogleAccess;
        /// <summary>
        /// The relative name of the Google Compute Engine [subnetwork](https://cloud.google.com/compute/docs/vpc) to which the cluster is connected. Example: projects/my-project/regions/us-central1/subnetworks/my-subnet
        /// </summary>
        public readonly string Subnetwork;

        [OutputConstructor]
        private NetworkConfigResponse(
            Outputs.DefaultSnatStatusResponse defaultSnatStatus,

            bool enableIntraNodeVisibility,

            string network,

            string privateIpv6GoogleAccess,

            string subnetwork)
        {
            DefaultSnatStatus = defaultSnatStatus;
            EnableIntraNodeVisibility = enableIntraNodeVisibility;
            Network = network;
            PrivateIpv6GoogleAccess = privateIpv6GoogleAccess;
            Subnetwork = subnetwork;
        }
    }
}