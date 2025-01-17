// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.BinaryAuthorization.V1.Inputs
{

    /// <summary>
    /// A public key in the PkixPublicKey format (see https://tools.ietf.org/html/rfc5280#section-4.1.2.7 for details). Public keys of this type are typically textually encoded using the PEM format.
    /// </summary>
    public sealed class PkixPublicKeyArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A PEM-encoded public key, as described in https://tools.ietf.org/html/rfc7468#section-13
        /// </summary>
        [Input("publicKeyPem")]
        public Input<string>? PublicKeyPem { get; set; }

        /// <summary>
        /// The signature algorithm used to verify a message against a signature using this key. These signature algorithm must match the structure and any object identifiers encoded in `public_key_pem` (i.e. this algorithm must match that of the public key).
        /// </summary>
        [Input("signatureAlgorithm")]
        public Input<Pulumi.GoogleNative.BinaryAuthorization.V1.PkixPublicKeySignatureAlgorithm>? SignatureAlgorithm { get; set; }

        public PkixPublicKeyArgs()
        {
        }
    }
}
