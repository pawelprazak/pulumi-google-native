// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.Monitoring.V3.Inputs
{

    /// <summary>
    /// A GKE Workload (Deployment, StatefulSet, etc). The field names correspond to the metadata labels on monitored resources that fall under a workload (for example, k8s_container or k8s_pod).
    /// </summary>
    public sealed class GkeWorkloadArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the parent cluster.
        /// </summary>
        [Input("clusterName")]
        public Input<string>? ClusterName { get; set; }

        /// <summary>
        /// The location of the parent cluster. This may be a zone or region.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// The name of the parent namespace.
        /// </summary>
        [Input("namespaceName")]
        public Input<string>? NamespaceName { get; set; }

        /// <summary>
        /// The name of this workload.
        /// </summary>
        [Input("topLevelControllerName")]
        public Input<string>? TopLevelControllerName { get; set; }

        /// <summary>
        /// The type of this workload (for example, "Deployment" or "DaemonSet")
        /// </summary>
        [Input("topLevelControllerType")]
        public Input<string>? TopLevelControllerType { get; set; }

        public GkeWorkloadArgs()
        {
        }
    }
}
