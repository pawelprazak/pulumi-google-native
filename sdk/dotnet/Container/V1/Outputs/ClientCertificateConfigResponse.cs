// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.Container.V1.Outputs
{

    [OutputType]
    public sealed class ClientCertificateConfigResponse
    {
        /// <summary>
        /// Issue a client certificate.
        /// </summary>
        public readonly bool IssueClientCertificate;

        [OutputConstructor]
        private ClientCertificateConfigResponse(bool issueClientCertificate)
        {
            IssueClientCertificate = issueClientCertificate;
        }
    }
}