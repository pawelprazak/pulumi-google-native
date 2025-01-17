// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.Transcoder.V1.Outputs
{

    /// <summary>
    /// Job configuration
    /// </summary>
    [OutputType]
    public sealed class JobConfigResponse
    {
        /// <summary>
        /// List of ad breaks. Specifies where to insert ad break tags in the output manifests.
        /// </summary>
        public readonly ImmutableArray<Outputs.AdBreakResponse> AdBreaks;
        /// <summary>
        /// List of `Edit atom`s. Defines the ultimate timeline of the resulting file or manifest.
        /// </summary>
        public readonly ImmutableArray<Outputs.EditAtomResponse> EditList;
        /// <summary>
        /// List of elementary streams.
        /// </summary>
        public readonly ImmutableArray<Outputs.ElementaryStreamResponse> ElementaryStreams;
        /// <summary>
        /// List of input assets stored in Cloud Storage.
        /// </summary>
        public readonly ImmutableArray<Outputs.InputResponse> Inputs;
        /// <summary>
        /// List of output manifests.
        /// </summary>
        public readonly ImmutableArray<Outputs.ManifestResponse> Manifests;
        /// <summary>
        /// List of multiplexing settings for output streams.
        /// </summary>
        public readonly ImmutableArray<Outputs.MuxStreamResponse> MuxStreams;
        /// <summary>
        /// Output configuration.
        /// </summary>
        public readonly Outputs.OutputResponse Output;
        /// <summary>
        /// List of overlays on the output video, in descending Z-order.
        /// </summary>
        public readonly ImmutableArray<Outputs.OverlayResponse> Overlays;
        /// <summary>
        /// Destination on Pub/Sub.
        /// </summary>
        public readonly Outputs.PubsubDestinationResponse PubsubDestination;
        /// <summary>
        /// List of output sprite sheets. Spritesheets require at least one VideoStream in the Jobconfig.
        /// </summary>
        public readonly ImmutableArray<Outputs.SpriteSheetResponse> SpriteSheets;

        [OutputConstructor]
        private JobConfigResponse(
            ImmutableArray<Outputs.AdBreakResponse> adBreaks,

            ImmutableArray<Outputs.EditAtomResponse> editList,

            ImmutableArray<Outputs.ElementaryStreamResponse> elementaryStreams,

            ImmutableArray<Outputs.InputResponse> inputs,

            ImmutableArray<Outputs.ManifestResponse> manifests,

            ImmutableArray<Outputs.MuxStreamResponse> muxStreams,

            Outputs.OutputResponse output,

            ImmutableArray<Outputs.OverlayResponse> overlays,

            Outputs.PubsubDestinationResponse pubsubDestination,

            ImmutableArray<Outputs.SpriteSheetResponse> spriteSheets)
        {
            AdBreaks = adBreaks;
            EditList = editList;
            ElementaryStreams = elementaryStreams;
            Inputs = inputs;
            Manifests = manifests;
            MuxStreams = muxStreams;
            Output = output;
            Overlays = overlays;
            PubsubDestination = pubsubDestination;
            SpriteSheets = spriteSheets;
        }
    }
}
