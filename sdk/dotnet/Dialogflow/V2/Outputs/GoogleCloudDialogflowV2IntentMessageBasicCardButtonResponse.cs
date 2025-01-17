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
    /// The button object that appears at the bottom of a card.
    /// </summary>
    [OutputType]
    public sealed class GoogleCloudDialogflowV2IntentMessageBasicCardButtonResponse
    {
        /// <summary>
        /// Action to take when a user taps on the button.
        /// </summary>
        public readonly Outputs.GoogleCloudDialogflowV2IntentMessageBasicCardButtonOpenUriActionResponse OpenUriAction;
        /// <summary>
        /// The title of the button.
        /// </summary>
        public readonly string Title;

        [OutputConstructor]
        private GoogleCloudDialogflowV2IntentMessageBasicCardButtonResponse(
            Outputs.GoogleCloudDialogflowV2IntentMessageBasicCardButtonOpenUriActionResponse openUriAction,

            string title)
        {
            OpenUriAction = openUriAction;
            Title = title;
        }
    }
}
