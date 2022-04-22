// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.Dataproc.V1.Outputs
{

    /// <summary>
    /// Dataproc cluster config for a cluster that does not directly control the underlying compute resources, such as a Dataproc-on-GKE cluster (https://cloud.google.com/dataproc/docs/concepts/jobs/dataproc-gke#create-a-dataproc-on-gke-cluster).
    /// </summary>
    [OutputType]
    public sealed class VirtualClusterConfigResponse
    {
        /// <summary>
        /// Optional. Configuration of auxiliary services used by this cluster.
        /// </summary>
        public readonly Outputs.AuxiliaryServicesConfigResponse AuxiliaryServicesConfig;
        /// <summary>
        /// The configuration for running the Dataproc cluster on Kubernetes.
        /// </summary>
        public readonly Outputs.KubernetesClusterConfigResponse KubernetesClusterConfig;
        /// <summary>
        /// Optional. A Storage bucket used to stage job dependencies, config files, and job driver console output. If you do not specify a staging bucket, Cloud Dataproc will determine a Cloud Storage location (US, ASIA, or EU) for your cluster's staging bucket according to the Compute Engine zone where your cluster is deployed, and then create and manage this project-level, per-location bucket (see Dataproc staging and temp buckets (https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/staging-bucket)). This field requires a Cloud Storage bucket name, not a gs://... URI to a Cloud Storage bucket.
        /// </summary>
        public readonly string StagingBucket;

        [OutputConstructor]
        private VirtualClusterConfigResponse(
            Outputs.AuxiliaryServicesConfigResponse auxiliaryServicesConfig,

            Outputs.KubernetesClusterConfigResponse kubernetesClusterConfig,

            string stagingBucket)
        {
            AuxiliaryServicesConfig = auxiliaryServicesConfig;
            KubernetesClusterConfig = kubernetesClusterConfig;
            StagingBucket = stagingBucket;
        }
    }
}