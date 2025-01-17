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
    /// Denoise preprocessing configuration. **Note:** This configuration is not supported.
    /// </summary>
    public sealed class DenoiseArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Set strength of the denoise. Enter a value between 0 and 1. The higher the value, the smoother the image. 0 is no denoising. The default is 0.
        /// </summary>
        [Input("strength")]
        public Input<double>? Strength { get; set; }

        /// <summary>
        /// Set the denoiser mode. The default is `standard`. Supported denoiser modes: - `standard` - `grain`
        /// </summary>
        [Input("tune")]
        public Input<string>? Tune { get; set; }

        public DenoiseArgs()
        {
        }
    }
}
