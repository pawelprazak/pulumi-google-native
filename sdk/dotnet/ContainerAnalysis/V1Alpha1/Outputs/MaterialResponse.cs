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
    /// Material is a material used in the generation of the provenance
    /// </summary>
    [OutputType]
    public sealed class MaterialResponse
    {
        /// <summary>
        /// digest is a map from a hash algorithm (e.g. sha256) to the value in the material
        /// </summary>
        public readonly ImmutableDictionary<string, string> Digest;
        /// <summary>
        /// uri is the uri of the material
        /// </summary>
        public readonly string Uri;

        [OutputConstructor]
        private MaterialResponse(
            ImmutableDictionary<string, string> digest,

            string uri)
        {
            Digest = digest;
            Uri = uri;
        }
    }
}
