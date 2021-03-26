// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.Dialogflow.V3beta1.Inputs
{

    /// <summary>
    /// The text response message.
    /// </summary>
    public sealed class GoogleCloudDialogflowCxV3beta1ResponseMessageTextArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Output only. Whether the playback of this message can be interrupted by the end user's speech and the client can then starts the next Dialogflow request.
        /// </summary>
        [Input("allowPlaybackInterruption")]
        public Input<bool>? AllowPlaybackInterruption { get; set; }

        [Input("text")]
        private InputList<string>? _text;

        /// <summary>
        /// Required. A collection of text responses.
        /// </summary>
        public InputList<string> Text
        {
            get => _text ?? (_text = new InputList<string>());
            set => _text = value;
        }

        public GoogleCloudDialogflowCxV3beta1ResponseMessageTextArgs()
        {
        }
    }
}