// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.Dialogflow.V2.Outputs
{

    /// <summary>
    /// Row of TableCard.
    /// </summary>
    [OutputType]
    public sealed class GoogleCloudDialogflowV2IntentMessageTableCardRowResponse
    {
        /// <summary>
        /// Optional. List of cells that make up this row.
        /// </summary>
        public readonly ImmutableArray<Outputs.GoogleCloudDialogflowV2IntentMessageTableCardCellResponse> Cells;
        /// <summary>
        /// Optional. Whether to add a visual divider after this row.
        /// </summary>
        public readonly bool DividerAfter;

        [OutputConstructor]
        private GoogleCloudDialogflowV2IntentMessageTableCardRowResponse(
            ImmutableArray<Outputs.GoogleCloudDialogflowV2IntentMessageTableCardCellResponse> cells,

            bool dividerAfter)
        {
            Cells = cells;
            DividerAfter = dividerAfter;
        }
    }
}
