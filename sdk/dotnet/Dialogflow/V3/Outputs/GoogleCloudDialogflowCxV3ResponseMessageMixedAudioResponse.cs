// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.Dialogflow.V3.Outputs
{

    [OutputType]
    public sealed class GoogleCloudDialogflowCxV3ResponseMessageMixedAudioResponse
    {
        /// <summary>
        /// Segments this audio response is composed of.
        /// </summary>
        public readonly ImmutableArray<Outputs.GoogleCloudDialogflowCxV3ResponseMessageMixedAudioSegmentResponse> Segments;

        [OutputConstructor]
        private GoogleCloudDialogflowCxV3ResponseMessageMixedAudioResponse(ImmutableArray<Outputs.GoogleCloudDialogflowCxV3ResponseMessageMixedAudioSegmentResponse> segments)
        {
            Segments = segments;
        }
    }
}