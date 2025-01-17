// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.DataLabeling.V1Beta1.Inputs
{

    /// <summary>
    /// Metadata for classification annotations.
    /// </summary>
    public sealed class GoogleCloudDatalabelingV1beta1ClassificationMetadataArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Whether the classification task is multi-label or not.
        /// </summary>
        [Input("isMultiLabel")]
        public Input<bool>? IsMultiLabel { get; set; }

        public GoogleCloudDatalabelingV1beta1ClassificationMetadataArgs()
        {
        }
    }
}
