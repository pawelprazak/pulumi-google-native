// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.ContainerAnalysis.V1Beta1.Inputs
{

    /// <summary>
    /// Details of a discovery occurrence.
    /// </summary>
    public sealed class GrafeasV1beta1DiscoveryDetailsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Required. Analysis status for the discovered resource.
        /// </summary>
        [Input("discovered")]
        public Input<Inputs.DiscoveredArgs>? Discovered { get; set; }

        public GrafeasV1beta1DiscoveryDetailsArgs()
        {
        }
    }
}