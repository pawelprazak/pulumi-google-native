// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.Dialogflow.V2.Inputs
{

    /// <summary>
    /// Row of TableCard.
    /// </summary>
    public sealed class GoogleCloudDialogflowV2IntentMessageTableCardRowArgs : Pulumi.ResourceArgs
    {
        [Input("cells")]
        private InputList<Inputs.GoogleCloudDialogflowV2IntentMessageTableCardCellArgs>? _cells;

        /// <summary>
        /// Optional. List of cells that make up this row.
        /// </summary>
        public InputList<Inputs.GoogleCloudDialogflowV2IntentMessageTableCardCellArgs> Cells
        {
            get => _cells ?? (_cells = new InputList<Inputs.GoogleCloudDialogflowV2IntentMessageTableCardCellArgs>());
            set => _cells = value;
        }

        /// <summary>
        /// Optional. Whether to add a visual divider after this row.
        /// </summary>
        [Input("dividerAfter")]
        public Input<bool>? DividerAfter { get; set; }

        public GoogleCloudDialogflowV2IntentMessageTableCardRowArgs()
        {
        }
    }
}