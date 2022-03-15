// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.Contactcenterinsights.V1.Inputs
{

    /// <summary>
    /// A Dialogflow source of conversation data.
    /// </summary>
    public sealed class GoogleCloudContactcenterinsightsV1DialogflowSourceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Cloud Storage URI that points to a file that contains the conversation audio.
        /// </summary>
        [Input("audioUri")]
        public Input<string>? AudioUri { get; set; }

        public GoogleCloudContactcenterinsightsV1DialogflowSourceArgs()
        {
        }
    }
}