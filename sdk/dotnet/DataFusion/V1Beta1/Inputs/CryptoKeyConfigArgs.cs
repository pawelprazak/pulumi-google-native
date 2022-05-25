// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.DataFusion.V1Beta1.Inputs
{

    /// <summary>
    /// The crypto key configuration. This field is used by the Customer-managed encryption keys (CMEK) feature.
    /// </summary>
    public sealed class CryptoKeyConfigArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the key which is used to encrypt/decrypt customer data. For key in Cloud KMS, the key should be in the format of `projects/*/locations/*/keyRings/*/cryptoKeys/*`.
        /// </summary>
        [Input("keyReference")]
        public Input<string>? KeyReference { get; set; }

        public CryptoKeyConfigArgs()
        {
        }
    }
}