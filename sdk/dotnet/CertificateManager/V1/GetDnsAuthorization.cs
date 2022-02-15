// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.CertificateManager.V1
{
    public static class GetDnsAuthorization
    {
        /// <summary>
        /// Gets details of a single DnsAuthorization.
        /// </summary>
        public static Task<GetDnsAuthorizationResult> InvokeAsync(GetDnsAuthorizationArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetDnsAuthorizationResult>("google-native:certificatemanager/v1:getDnsAuthorization", args ?? new GetDnsAuthorizationArgs(), options.WithDefaults());

        /// <summary>
        /// Gets details of a single DnsAuthorization.
        /// </summary>
        public static Output<GetDnsAuthorizationResult> Invoke(GetDnsAuthorizationInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetDnsAuthorizationResult>("google-native:certificatemanager/v1:getDnsAuthorization", args ?? new GetDnsAuthorizationInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetDnsAuthorizationArgs : Pulumi.InvokeArgs
    {
        [Input("dnsAuthorizationId", required: true)]
        public string DnsAuthorizationId { get; set; } = null!;

        [Input("location", required: true)]
        public string Location { get; set; } = null!;

        [Input("project")]
        public string? Project { get; set; }

        public GetDnsAuthorizationArgs()
        {
        }
    }

    public sealed class GetDnsAuthorizationInvokeArgs : Pulumi.InvokeArgs
    {
        [Input("dnsAuthorizationId", required: true)]
        public Input<string> DnsAuthorizationId { get; set; } = null!;

        [Input("location", required: true)]
        public Input<string> Location { get; set; } = null!;

        [Input("project")]
        public Input<string>? Project { get; set; }

        public GetDnsAuthorizationInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetDnsAuthorizationResult
    {
        /// <summary>
        /// The creation timestamp of a DnsAuthorization.
        /// </summary>
        public readonly string CreateTime;
        /// <summary>
        /// One or more paragraphs of text description of a DnsAuthorization.
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// DNS Resource Record that needs to be added to DNS configuration.
        /// </summary>
        public readonly Outputs.DnsResourceRecordResponse DnsResourceRecord;
        /// <summary>
        /// Immutable. A domain which is being authorized. A DnsAuthorization resource covers a single domain and its wildcard, e.g. authorization for "example.com" can be used to issue certificates for "example.com" and "*.example.com".
        /// </summary>
        public readonly string Domain;
        /// <summary>
        /// Set of labels associated with a DnsAuthorization.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Labels;
        /// <summary>
        /// A user-defined name of the dns authorization. DnsAuthorization names must be unique globally and match pattern `projects/*/locations/*/dnsAuthorizations/*`.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The last update timestamp of a DnsAuthorization.
        /// </summary>
        public readonly string UpdateTime;

        [OutputConstructor]
        private GetDnsAuthorizationResult(
            string createTime,

            string description,

            Outputs.DnsResourceRecordResponse dnsResourceRecord,

            string domain,

            ImmutableDictionary<string, string> labels,

            string name,

            string updateTime)
        {
            CreateTime = createTime;
            Description = description;
            DnsResourceRecord = dnsResourceRecord;
            Domain = domain;
            Labels = labels;
            Name = name;
            UpdateTime = updateTime;
        }
    }
}