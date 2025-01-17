// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.Privateca.V1
{
    public static class GetCaPool
    {
        /// <summary>
        /// Returns a CaPool.
        /// </summary>
        public static Task<GetCaPoolResult> InvokeAsync(GetCaPoolArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetCaPoolResult>("google-native:privateca/v1:getCaPool", args ?? new GetCaPoolArgs(), options.WithDefaults());

        /// <summary>
        /// Returns a CaPool.
        /// </summary>
        public static Output<GetCaPoolResult> Invoke(GetCaPoolInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetCaPoolResult>("google-native:privateca/v1:getCaPool", args ?? new GetCaPoolInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetCaPoolArgs : Pulumi.InvokeArgs
    {
        [Input("caPoolId", required: true)]
        public string CaPoolId { get; set; } = null!;

        [Input("location", required: true)]
        public string Location { get; set; } = null!;

        [Input("project")]
        public string? Project { get; set; }

        public GetCaPoolArgs()
        {
        }
    }

    public sealed class GetCaPoolInvokeArgs : Pulumi.InvokeArgs
    {
        [Input("caPoolId", required: true)]
        public Input<string> CaPoolId { get; set; } = null!;

        [Input("location", required: true)]
        public Input<string> Location { get; set; } = null!;

        [Input("project")]
        public Input<string>? Project { get; set; }

        public GetCaPoolInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetCaPoolResult
    {
        /// <summary>
        /// Optional. The IssuancePolicy to control how Certificates will be issued from this CaPool.
        /// </summary>
        public readonly Outputs.IssuancePolicyResponse IssuancePolicy;
        /// <summary>
        /// Optional. Labels with user-defined metadata.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Labels;
        /// <summary>
        /// The resource name for this CaPool in the format `projects/*/locations/*/caPools/*`.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Optional. The PublishingOptions to follow when issuing Certificates from any CertificateAuthority in this CaPool.
        /// </summary>
        public readonly Outputs.PublishingOptionsResponse PublishingOptions;
        /// <summary>
        /// Immutable. The Tier of this CaPool.
        /// </summary>
        public readonly string Tier;

        [OutputConstructor]
        private GetCaPoolResult(
            Outputs.IssuancePolicyResponse issuancePolicy,

            ImmutableDictionary<string, string> labels,

            string name,

            Outputs.PublishingOptionsResponse publishingOptions,

            string tier)
        {
            IssuancePolicy = issuancePolicy;
            Labels = labels;
            Name = name;
            PublishingOptions = publishingOptions;
            Tier = tier;
        }
    }
}
