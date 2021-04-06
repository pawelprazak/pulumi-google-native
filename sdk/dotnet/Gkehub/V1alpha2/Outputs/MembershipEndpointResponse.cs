// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.Gkehub.V1alpha2.Outputs
{

    [OutputType]
    public sealed class MembershipEndpointResponse
    {
        /// <summary>
        /// Optional. GKE-specific information. Only present if this Membership is a GKE cluster.
        /// </summary>
        public readonly Outputs.GkeClusterResponse GkeCluster;
        /// <summary>
        /// Useful Kubernetes-specific metadata.
        /// </summary>
        public readonly Outputs.KubernetesMetadataResponse KubernetesMetadata;
        /// <summary>
        /// Optional. The in-cluster Kubernetes Resources that should be applied for a correctly registered cluster, in the steady state. These resources: * Ensure that the cluster is exclusively registered to one and only one Hub Membership. * Propagate Workload Pool Information available in the Membership Authority field. * Ensure proper initial configuration of default Hub Features.
        /// </summary>
        public readonly Outputs.KubernetesResourceResponse KubernetesResource;

        [OutputConstructor]
        private MembershipEndpointResponse(
            Outputs.GkeClusterResponse gkeCluster,

            Outputs.KubernetesMetadataResponse kubernetesMetadata,

            Outputs.KubernetesResourceResponse kubernetesResource)
        {
            GkeCluster = gkeCluster;
            KubernetesMetadata = kubernetesMetadata;
            KubernetesResource = kubernetesResource;
        }
    }
}