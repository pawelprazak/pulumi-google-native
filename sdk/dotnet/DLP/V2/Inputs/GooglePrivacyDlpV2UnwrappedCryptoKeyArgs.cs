// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.DLP.V2.Inputs
{

    /// <summary>
    /// Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
    /// </summary>
    public sealed class GooglePrivacyDlpV2UnwrappedCryptoKeyArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Required. A 128/192/256 bit key.
        /// </summary>
        [Input("key")]
        public Input<string>? Key { get; set; }

        public GooglePrivacyDlpV2UnwrappedCryptoKeyArgs()
        {
        }
    }
}