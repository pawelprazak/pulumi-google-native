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
    /// The collection of suggestions.
    /// </summary>
    public sealed class GoogleCloudDialogflowV2IntentMessageSuggestionsArgs : Pulumi.ResourceArgs
    {
        [Input("suggestions")]
        private InputList<Inputs.GoogleCloudDialogflowV2IntentMessageSuggestionArgs>? _suggestions;

        /// <summary>
        /// Required. The list of suggested replies.
        /// </summary>
        public InputList<Inputs.GoogleCloudDialogflowV2IntentMessageSuggestionArgs> Suggestions
        {
            get => _suggestions ?? (_suggestions = new InputList<Inputs.GoogleCloudDialogflowV2IntentMessageSuggestionArgs>());
            set => _suggestions = value;
        }

        public GoogleCloudDialogflowV2IntentMessageSuggestionsArgs()
        {
        }
    }
}