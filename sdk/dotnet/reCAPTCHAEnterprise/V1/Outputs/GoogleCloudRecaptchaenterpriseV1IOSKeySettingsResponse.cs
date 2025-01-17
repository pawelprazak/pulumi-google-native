// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.reCAPTCHAEnterprise.V1.Outputs
{

    /// <summary>
    /// Settings specific to keys that can be used by iOS apps.
    /// </summary>
    [OutputType]
    public sealed class GoogleCloudRecaptchaenterpriseV1IOSKeySettingsResponse
    {
        /// <summary>
        /// If set to true, allowed_bundle_ids are not enforced.
        /// </summary>
        public readonly bool AllowAllBundleIds;
        /// <summary>
        /// iOS bundle ids of apps allowed to use the key. Example: 'com.companyname.productname.appname'
        /// </summary>
        public readonly ImmutableArray<string> AllowedBundleIds;

        [OutputConstructor]
        private GoogleCloudRecaptchaenterpriseV1IOSKeySettingsResponse(
            bool allowAllBundleIds,

            ImmutableArray<string> allowedBundleIds)
        {
            AllowAllBundleIds = allowAllBundleIds;
            AllowedBundleIds = allowedBundleIds;
        }
    }
}
