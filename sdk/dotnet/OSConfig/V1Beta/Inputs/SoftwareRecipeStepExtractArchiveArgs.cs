// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.OSConfig.V1Beta.Inputs
{

    /// <summary>
    /// Extracts an archive of the type specified in the specified directory.
    /// </summary>
    public sealed class SoftwareRecipeStepExtractArchiveArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Required. The id of the relevant artifact in the recipe.
        /// </summary>
        [Input("artifactId")]
        public Input<string>? ArtifactId { get; set; }

        /// <summary>
        /// Directory to extract archive to. Defaults to `/` on Linux or `C:\` on Windows.
        /// </summary>
        [Input("destination")]
        public Input<string>? Destination { get; set; }

        /// <summary>
        /// Required. The type of the archive to extract.
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        public SoftwareRecipeStepExtractArchiveArgs()
        {
        }
    }
}