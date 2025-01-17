// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.CloudBuild.V1.Inputs
{

    /// <summary>
    /// Location of the source in a supported storage service.
    /// </summary>
    public sealed class SourceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// If provided, get the source from this location in a Cloud Source Repository.
        /// </summary>
        [Input("repoSource")]
        public Input<Inputs.RepoSourceArgs>? RepoSource { get; set; }

        /// <summary>
        /// If provided, get the source from this location in Google Cloud Storage.
        /// </summary>
        [Input("storageSource")]
        public Input<Inputs.StorageSourceArgs>? StorageSource { get; set; }

        /// <summary>
        /// If provided, get the source from this manifest in Google Cloud Storage. This feature is in Preview; see description [here](https://github.com/GoogleCloudPlatform/cloud-builders/tree/master/gcs-fetcher).
        /// </summary>
        [Input("storageSourceManifest")]
        public Input<Inputs.StorageSourceManifestArgs>? StorageSourceManifest { get; set; }

        public SourceArgs()
        {
        }
    }
}
