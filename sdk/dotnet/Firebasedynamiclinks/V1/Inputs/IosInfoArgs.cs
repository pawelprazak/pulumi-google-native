// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.Firebasedynamiclinks.V1.Inputs
{

    /// <summary>
    /// iOS related attributes to the Dynamic Link..
    /// </summary>
    public sealed class IosInfoArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// iOS App Store ID.
        /// </summary>
        [Input("iosAppStoreId")]
        public Input<string>? IosAppStoreId { get; set; }

        /// <summary>
        /// iOS bundle ID of the app.
        /// </summary>
        [Input("iosBundleId")]
        public Input<string>? IosBundleId { get; set; }

        /// <summary>
        /// Custom (destination) scheme to use for iOS. By default, we’ll use the bundle ID as the custom scheme. Developer can override this behavior using this param.
        /// </summary>
        [Input("iosCustomScheme")]
        public Input<string>? IosCustomScheme { get; set; }

        /// <summary>
        /// Link to open on iOS if the app is not installed.
        /// </summary>
        [Input("iosFallbackLink")]
        public Input<string>? IosFallbackLink { get; set; }

        /// <summary>
        /// iPad bundle ID of the app.
        /// </summary>
        [Input("iosIpadBundleId")]
        public Input<string>? IosIpadBundleId { get; set; }

        /// <summary>
        /// If specified, this overrides the ios_fallback_link value on iPads.
        /// </summary>
        [Input("iosIpadFallbackLink")]
        public Input<string>? IosIpadFallbackLink { get; set; }

        /// <summary>
        /// iOS minimum version.
        /// </summary>
        [Input("iosMinimumVersion")]
        public Input<string>? IosMinimumVersion { get; set; }

        public IosInfoArgs()
        {
        }
    }
}