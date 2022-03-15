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
    /// [Deprecated] The client side authentication settings for connection originating from the backend service. the backend service.
    /// </summary>
    public sealed class ClientTlsSettingsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Configures the mechanism to obtain client-side security certificates and identity information. This field is only applicable when mode is set to MUTUAL.
        /// </summary>
        [Input("clientTlsContext")]
        public Input<Inputs.TlsContextArgs>? ClientTlsContext { get; set; }

        /// <summary>
        /// Indicates whether connections to this port should be secured using TLS. The value of this field determines how TLS is enforced. This can be set to one of the following values: DISABLE: Do not setup a TLS connection to the backends. SIMPLE: Originate a TLS connection to the backends. MUTUAL: Secure connections to the backends using mutual TLS by presenting client certificates for authentication.
        /// </summary>
        [Input("mode")]
        public Input<Pulumi.GoogleNative.Compute.Alpha.ClientTlsSettingsMode>? Mode { get; set; }

        /// <summary>
        /// SNI string to present to the server during TLS handshake. This field is applicable only when mode is SIMPLE or MUTUAL.
        /// </summary>
        [Input("sni")]
        public Input<string>? Sni { get; set; }

        [Input("subjectAltNames")]
        private InputList<string>? _subjectAltNames;

        /// <summary>
        /// A list of alternate names to verify the subject identity in the certificate.If specified, the proxy will verify that the server certificate's subject alt name matches one of the specified values. This field is applicable only when mode is SIMPLE or MUTUAL.
        /// </summary>
        public InputList<string> SubjectAltNames
        {
            get => _subjectAltNames ?? (_subjectAltNames = new InputList<string>());
            set => _subjectAltNames = value;
        }

        public ClientTlsSettingsArgs()
        {
        }
    }
}