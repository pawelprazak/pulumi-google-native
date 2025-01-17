// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.Compute.Alpha.Inputs
{

    /// <summary>
    /// [Deprecated] This message specifies a header location to extract JWT token. This message specifies a header location to extract JWT token.
    /// </summary>
    public sealed class JwtHeaderArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The HTTP header name.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The value prefix. The value format is "value_prefix" For example, for "Authorization: Bearer ", value_prefix="Bearer " with a space at the end.
        /// </summary>
        [Input("valuePrefix")]
        public Input<string>? ValuePrefix { get; set; }

        public JwtHeaderArgs()
        {
        }
    }
}
