// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.Privateca.V1Beta1.Outputs
{

    [OutputType]
    public sealed class AllowedConfigListResponse
    {
        /// <summary>
        /// Required. All Certificates issued by the CertificateAuthority must match at least one listed ReusableConfigWrapper. If a ReusableConfigWrapper has an empty field, any value will be allowed for that field.
        /// </summary>
        public readonly ImmutableArray<Outputs.ReusableConfigWrapperResponse> AllowedConfigValues;

        [OutputConstructor]
        private AllowedConfigListResponse(ImmutableArray<Outputs.ReusableConfigWrapperResponse> allowedConfigValues)
        {
            AllowedConfigValues = allowedConfigValues;
        }
    }
}