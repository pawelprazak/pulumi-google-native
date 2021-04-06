// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.DLP.V2.Inputs
{

    /// <summary>
    /// The configuration that controls how the data will change.
    /// </summary>
    public sealed class GooglePrivacyDlpV2DeidentifyConfigArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Treat the dataset as free-form text and apply the same free text transformation everywhere.
        /// </summary>
        [Input("infoTypeTransformations")]
        public Input<Inputs.GooglePrivacyDlpV2InfoTypeTransformationsArgs>? InfoTypeTransformations { get; set; }

        /// <summary>
        /// Treat the dataset as structured. Transformations can be applied to specific locations within structured datasets, such as transforming a column within a table.
        /// </summary>
        [Input("recordTransformations")]
        public Input<Inputs.GooglePrivacyDlpV2RecordTransformationsArgs>? RecordTransformations { get; set; }

        /// <summary>
        /// Mode for handling transformation errors. If left unspecified, the default mode is `TransformationErrorHandling.ThrowError`.
        /// </summary>
        [Input("transformationErrorHandling")]
        public Input<Inputs.GooglePrivacyDlpV2TransformationErrorHandlingArgs>? TransformationErrorHandling { get; set; }

        public GooglePrivacyDlpV2DeidentifyConfigArgs()
        {
        }
    }
}