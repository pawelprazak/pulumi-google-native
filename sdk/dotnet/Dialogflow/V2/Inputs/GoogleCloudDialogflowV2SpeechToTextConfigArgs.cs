// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.Dialogflow.V2.Inputs
{

    /// <summary>
    /// Configures speech transcription for ConversationProfile.
    /// </summary>
    public sealed class GoogleCloudDialogflowV2SpeechToTextConfigArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The speech model used in speech to text. `SPEECH_MODEL_VARIANT_UNSPECIFIED`, `USE_BEST_AVAILABLE` will be treated as `USE_ENHANCED`. It can be overridden in AnalyzeContentRequest and StreamingAnalyzeContentRequest request. If enhanced model variant is specified and an enhanced version of the specified model for the language does not exist, then it would emit an error.
        /// </summary>
        [Input("speechModelVariant")]
        public Input<Pulumi.GoogleNative.Dialogflow.V2.GoogleCloudDialogflowV2SpeechToTextConfigSpeechModelVariant>? SpeechModelVariant { get; set; }

        public GoogleCloudDialogflowV2SpeechToTextConfigArgs()
        {
        }
    }
}
