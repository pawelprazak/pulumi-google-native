// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.DNS.V2
{
    public static class GetResponsePolicy
    {
        /// <summary>
        /// Fetches the representation of an existing Response Policy.
        /// </summary>
        public static Task<GetResponsePolicyResult> InvokeAsync(GetResponsePolicyArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetResponsePolicyResult>("google-native:dns/v2:getResponsePolicy", args ?? new GetResponsePolicyArgs(), options.WithDefaults());

        /// <summary>
        /// Fetches the representation of an existing Response Policy.
        /// </summary>
        public static Output<GetResponsePolicyResult> Invoke(GetResponsePolicyInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetResponsePolicyResult>("google-native:dns/v2:getResponsePolicy", args ?? new GetResponsePolicyInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetResponsePolicyArgs : Pulumi.InvokeArgs
    {
        [Input("clientOperationId")]
        public string? ClientOperationId { get; set; }

        [Input("location", required: true)]
        public string Location { get; set; } = null!;

        [Input("project")]
        public string? Project { get; set; }

        [Input("responsePolicy", required: true)]
        public string ResponsePolicy { get; set; } = null!;

        public GetResponsePolicyArgs()
        {
        }
    }

    public sealed class GetResponsePolicyInvokeArgs : Pulumi.InvokeArgs
    {
        [Input("clientOperationId")]
        public Input<string>? ClientOperationId { get; set; }

        [Input("location", required: true)]
        public Input<string> Location { get; set; } = null!;

        [Input("project")]
        public Input<string>? Project { get; set; }

        [Input("responsePolicy", required: true)]
        public Input<string> ResponsePolicy { get; set; } = null!;

        public GetResponsePolicyInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetResponsePolicyResult
    {
        /// <summary>
        /// User-provided description for this Response Policy.
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// The list of Google Kubernetes Engine clusters to which this response policy is applied.
        /// </summary>
        public readonly ImmutableArray<Outputs.ResponsePolicyGKEClusterResponse> GkeClusters;
        public readonly string Kind;
        /// <summary>
        /// List of network names specifying networks to which this policy is applied.
        /// </summary>
        public readonly ImmutableArray<Outputs.ResponsePolicyNetworkResponse> Networks;
        /// <summary>
        /// User assigned name for this Response Policy.
        /// </summary>
        public readonly string ResponsePolicyName;

        [OutputConstructor]
        private GetResponsePolicyResult(
            string description,

            ImmutableArray<Outputs.ResponsePolicyGKEClusterResponse> gkeClusters,

            string kind,

            ImmutableArray<Outputs.ResponsePolicyNetworkResponse> networks,

            string responsePolicyName)
        {
            Description = description;
            GkeClusters = gkeClusters;
            Kind = kind;
            Networks = networks;
            ResponsePolicyName = responsePolicyName;
        }
    }
}