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
    /// Controls what and how to inspect for findings.
    /// </summary>
    public sealed class GooglePrivacyDlpV2InspectJobConfigArgs : Pulumi.ResourceArgs
    {
        [Input("actions")]
        private InputList<Inputs.GooglePrivacyDlpV2ActionArgs>? _actions;

        /// <summary>
        /// Actions to execute at the completion of the job.
        /// </summary>
        public InputList<Inputs.GooglePrivacyDlpV2ActionArgs> Actions
        {
            get => _actions ?? (_actions = new InputList<Inputs.GooglePrivacyDlpV2ActionArgs>());
            set => _actions = value;
        }

        /// <summary>
        /// How and what to scan for.
        /// </summary>
        [Input("inspectConfig")]
        public Input<Inputs.GooglePrivacyDlpV2InspectConfigArgs>? InspectConfig { get; set; }

        /// <summary>
        /// If provided, will be used as the default for all values in InspectConfig. `inspect_config` will be merged into the values persisted as part of the template.
        /// </summary>
        [Input("inspectTemplateName")]
        public Input<string>? InspectTemplateName { get; set; }

        /// <summary>
        /// The data to scan.
        /// </summary>
        [Input("storageConfig")]
        public Input<Inputs.GooglePrivacyDlpV2StorageConfigArgs>? StorageConfig { get; set; }

        public GooglePrivacyDlpV2InspectJobConfigArgs()
        {
        }
    }
}