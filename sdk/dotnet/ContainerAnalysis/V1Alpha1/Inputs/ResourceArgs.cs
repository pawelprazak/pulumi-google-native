// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.ContainerAnalysis.V1Alpha1.Inputs
{

    /// <summary>
    ///  Resource is an entity that can have metadata. E.g., a Docker image.
    /// </summary>
    public sealed class ResourceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The hash of the resource content. E.g., the Docker digest.
        /// </summary>
        [Input("contentHash")]
        public Input<Inputs.HashArgs>? ContentHash { get; set; }

        /// <summary>
        /// The name of the resource. E.g., the name of a Docker image - "Debian".
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The unique URI of the resource. E.g., "https://gcr.io/project/image@sha256:foo" for a Docker image.
        /// </summary>
        [Input("uri")]
        public Input<string>? Uri { get; set; }

        public ResourceArgs()
        {
        }
    }
}