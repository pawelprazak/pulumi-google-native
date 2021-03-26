// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.Transcoder.V1beta1.Inputs
{

    /// <summary>
    /// Color preprocessing configuration.
    /// </summary>
    public sealed class ColorArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Control brightness of the video. Enter a value between -1 and 1, where -1 is minimum brightness and 1 is maximum brightness. 0 is no change. The default is 0.
        /// </summary>
        [Input("brightness")]
        public Input<double>? Brightness { get; set; }

        /// <summary>
        /// Control black and white contrast of the video. Enter a value between -1 and 1, where -1 is minimum contrast and 1 is maximum contrast. 0 is no change. The default is 0.
        /// </summary>
        [Input("contrast")]
        public Input<double>? Contrast { get; set; }

        /// <summary>
        /// Control color saturation of the video. Enter a value between -1 and 1, where -1 is fully desaturated and 1 is maximum saturation. 0 is no change. The default is 0.
        /// </summary>
        [Input("saturation")]
        public Input<double>? Saturation { get; set; }

        public ColorArgs()
        {
        }
    }
}