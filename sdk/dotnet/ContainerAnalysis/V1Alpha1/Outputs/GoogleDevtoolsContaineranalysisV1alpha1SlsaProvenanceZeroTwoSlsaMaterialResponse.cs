// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.ContainerAnalysis.V1Alpha1.Outputs
{

    /// <summary>
    /// The collection of artifacts that influenced the build including sources, dependencies, build tools, base images, and so on.
    /// </summary>
    [OutputType]
    public sealed class GoogleDevtoolsContaineranalysisV1alpha1SlsaProvenanceZeroTwoSlsaMaterialResponse
    {
        /// <summary>
        /// Collection of cryptographic digests for the contents of this artifact.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Digest;
        /// <summary>
        /// The method by which this artifact was referenced during the build.
        /// </summary>
        public readonly string Uri;

        [OutputConstructor]
        private GoogleDevtoolsContaineranalysisV1alpha1SlsaProvenanceZeroTwoSlsaMaterialResponse(
            ImmutableDictionary<string, string> digest,

            string uri)
        {
            Digest = digest;
            Uri = uri;
        }
    }
}