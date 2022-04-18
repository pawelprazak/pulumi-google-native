// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.Transcoder.V1.Inputs
{

    /// <summary>
    /// Audio stream resource.
    /// </summary>
    public sealed class AudioStreamArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Audio bitrate in bits per second. Must be between 1 and 10,000,000.
        /// </summary>
        [Input("bitrateBps", required: true)]
        public Input<int> BitrateBps { get; set; } = null!;

        /// <summary>
        /// Number of audio channels. Must be between 1 and 6. The default is 2.
        /// </summary>
        [Input("channelCount")]
        public Input<int>? ChannelCount { get; set; }

        [Input("channelLayout")]
        private InputList<string>? _channelLayout;

        /// <summary>
        /// A list of channel names specifying layout of the audio channels. This only affects the metadata embedded in the container headers, if supported by the specified format. The default is `["fl", "fr"]`. Supported channel names: - `fl` - Front left channel - `fr` - Front right channel - `sl` - Side left channel - `sr` - Side right channel - `fc` - Front center channel - `lfe` - Low frequency
        /// </summary>
        public InputList<string> ChannelLayout
        {
            get => _channelLayout ?? (_channelLayout = new InputList<string>());
            set => _channelLayout = value;
        }

        /// <summary>
        /// The codec for this audio stream. The default is `aac`. Supported audio codecs: - `aac` - `aac-he` - `aac-he-v2` - `mp3` - `ac3` - `eac3`
        /// </summary>
        [Input("codec")]
        public Input<string>? Codec { get; set; }

        [Input("mapping")]
        private InputList<Inputs.AudioMappingArgs>? _mapping;

        /// <summary>
        /// The mapping for the `Job.edit_list` atoms with audio `EditAtom.inputs`.
        /// </summary>
        public InputList<Inputs.AudioMappingArgs> Mapping
        {
            get => _mapping ?? (_mapping = new InputList<Inputs.AudioMappingArgs>());
            set => _mapping = value;
        }

        /// <summary>
        /// The audio sample rate in Hertz. The default is 48000 Hertz.
        /// </summary>
        [Input("sampleRateHertz")]
        public Input<int>? SampleRateHertz { get; set; }

        public AudioStreamArgs()
        {
        }
    }
}