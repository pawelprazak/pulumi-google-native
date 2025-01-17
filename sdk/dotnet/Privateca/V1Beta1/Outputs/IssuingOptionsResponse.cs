// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.Privateca.V1Beta1.Outputs
{

    /// <summary>
    /// Options that affect all certificates issued by a CertificateAuthority.
    /// </summary>
    [OutputType]
    public sealed class IssuingOptionsResponse
    {
        /// <summary>
        /// When true, includes a URL to the issuing CA certificate in the "authority information access" X.509 extension.
        /// </summary>
        public readonly bool IncludeCaCertUrl;
        /// <summary>
        /// When true, includes a URL to the CRL corresponding to certificates issued from a CertificateAuthority. CRLs will expire 7 days from their creation. However, we will rebuild daily. CRLs are also rebuilt shortly after a certificate is revoked.
        /// </summary>
        public readonly bool IncludeCrlAccessUrl;

        [OutputConstructor]
        private IssuingOptionsResponse(
            bool includeCaCertUrl,

            bool includeCrlAccessUrl)
        {
            IncludeCaCertUrl = includeCaCertUrl;
            IncludeCrlAccessUrl = includeCrlAccessUrl;
        }
    }
}
