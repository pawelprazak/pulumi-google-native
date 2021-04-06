// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.Compute.Alpha.Outputs
{

    [OutputType]
    public sealed class SecurityPolicyAdaptiveProtectionConfigLayer7DdosDefenseConfigResponse
    {
        /// <summary>
        /// If set to true, enables CAAP for L7 DDoS detection.
        /// </summary>
        public readonly bool Enable;
        /// <summary>
        /// Rule visibility can be one of the following: STANDARD - opaque rules. (default) PREMIUM - transparent rules.
        /// </summary>
        public readonly string RuleVisibility;

        [OutputConstructor]
        private SecurityPolicyAdaptiveProtectionConfigLayer7DdosDefenseConfigResponse(
            bool enable,

            string ruleVisibility)
        {
            Enable = enable;
            RuleVisibility = ruleVisibility;
        }
    }
}