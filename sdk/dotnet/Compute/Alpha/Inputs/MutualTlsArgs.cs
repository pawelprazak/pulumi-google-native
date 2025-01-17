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
    /// [Deprecated] Configuration for the mutual Tls mode for peer authentication. Configuration for the mutual Tls mode for peer authentication.
    /// </summary>
    public sealed class MutualTlsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies if the server TLS is configured to be strict or permissive. This field can be set to one of the following: STRICT: Client certificate must be presented, connection is in TLS. PERMISSIVE: Client certificate can be omitted, connection can be either plaintext or TLS.
        /// </summary>
        [Input("mode")]
        public Input<Pulumi.GoogleNative.Compute.Alpha.MutualTlsMode>? Mode { get; set; }

        public MutualTlsArgs()
        {
        }
    }
}
