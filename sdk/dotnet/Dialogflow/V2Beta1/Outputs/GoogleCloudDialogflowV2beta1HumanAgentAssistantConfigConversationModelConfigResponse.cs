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
    /// Custom conversation models used in agent assist feature. Supported feature: ARTICLE_SUGGESTION, SMART_COMPOSE, SMART_REPLY, CONVERSATION_SUMMARIZATION.
    /// </summary>
    [OutputType]
    public sealed class GoogleCloudDialogflowV2beta1HumanAgentAssistantConfigConversationModelConfigResponse
    {
        /// <summary>
        /// Conversation model resource name. Format: `projects//conversationModels/`.
        /// </summary>
        public readonly string Model;

        [OutputConstructor]
        private GoogleCloudDialogflowV2beta1HumanAgentAssistantConfigConversationModelConfigResponse(string model)
        {
            Model = model;
        }
    }
}
