// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.DLP.V2.Outputs
{

    /// <summary>
    /// Statistics for a StoredInfoType.
    /// </summary>
    [OutputType]
    public sealed class GooglePrivacyDlpV2StoredInfoTypeStatsResponse
    {
        /// <summary>
        /// StoredInfoType where findings are defined by a dictionary of phrases.
        /// </summary>
        public readonly Outputs.GooglePrivacyDlpV2LargeCustomDictionaryStatsResponse LargeCustomDictionary;

        [OutputConstructor]
        private GooglePrivacyDlpV2StoredInfoTypeStatsResponse(Outputs.GooglePrivacyDlpV2LargeCustomDictionaryStatsResponse largeCustomDictionary)
        {
            LargeCustomDictionary = largeCustomDictionary;
        }
    }
}
