// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.APIKeys.V2.Inputs
{

    /// <summary>
    /// The IP addresses of callers that are allowed to use the key.
    /// </summary>
    public sealed class V2ServerKeyRestrictionsArgs : Pulumi.ResourceArgs
    {
        [Input("allowedIps")]
        private InputList<string>? _allowedIps;

        /// <summary>
        /// A list of the caller IP addresses that are allowed to make API calls with this key.
        /// </summary>
        public InputList<string> AllowedIps
        {
            get => _allowedIps ?? (_allowedIps = new InputList<string>());
            set => _allowedIps = value;
        }

        public V2ServerKeyRestrictionsArgs()
        {
        }
    }
}