// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.Dialogflow.V2Beta1.Outputs
{

    /// <summary>
    /// Settings of suggestion trigger.
    /// </summary>
    [OutputType]
    public sealed class GoogleCloudDialogflowV2beta1HumanAgentAssistantConfigSuggestionTriggerSettingsResponse
    {
        /// <summary>
        /// Do not trigger if last utterance is small talk.
        /// </summary>
        public readonly bool NoSmallTalk;
        /// <summary>
        /// Only trigger suggestion if participant role of last utterance is END_USER.
        /// </summary>
        public readonly bool OnlyEndUser;

        [OutputConstructor]
        private GoogleCloudDialogflowV2beta1HumanAgentAssistantConfigSuggestionTriggerSettingsResponse(
            bool noSmallTalk,

            bool onlyEndUser)
        {
            NoSmallTalk = noSmallTalk;
            OnlyEndUser = onlyEndUser;
        }
    }
}
