// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.DLP.V2.Outputs
{

    [OutputType]
    public sealed class GooglePrivacyDlpV2StoredInfoTypeConfigResponse
    {
        /// <summary>
        /// Description of the StoredInfoType (max 256 characters).
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// Store dictionary-based CustomInfoType.
        /// </summary>
        public readonly Outputs.GooglePrivacyDlpV2DictionaryResponse Dictionary;
        /// <summary>
        /// Display name of the StoredInfoType (max 256 characters).
        /// </summary>
        public readonly string DisplayName;
        /// <summary>
        /// StoredInfoType where findings are defined by a dictionary of phrases.
        /// </summary>
        public readonly Outputs.GooglePrivacyDlpV2LargeCustomDictionaryConfigResponse LargeCustomDictionary;
        /// <summary>
        /// Store regular expression-based StoredInfoType.
        /// </summary>
        public readonly Outputs.GooglePrivacyDlpV2RegexResponse Regex;

        [OutputConstructor]
        private GooglePrivacyDlpV2StoredInfoTypeConfigResponse(
            string description,

            Outputs.GooglePrivacyDlpV2DictionaryResponse dictionary,

            string displayName,

            Outputs.GooglePrivacyDlpV2LargeCustomDictionaryConfigResponse largeCustomDictionary,

            Outputs.GooglePrivacyDlpV2RegexResponse regex)
        {
            Description = description;
            Dictionary = dictionary;
            DisplayName = displayName;
            LargeCustomDictionary = largeCustomDictionary;
            Regex = regex;
        }
    }
}