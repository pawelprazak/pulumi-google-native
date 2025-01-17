// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.SecretManager.V1Beta1
{
    public static class GetSecret
    {
        /// <summary>
        /// Gets metadata for a given Secret.
        /// </summary>
        public static Task<GetSecretResult> InvokeAsync(GetSecretArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetSecretResult>("google-native:secretmanager/v1beta1:getSecret", args ?? new GetSecretArgs(), options.WithDefaults());

        /// <summary>
        /// Gets metadata for a given Secret.
        /// </summary>
        public static Output<GetSecretResult> Invoke(GetSecretInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetSecretResult>("google-native:secretmanager/v1beta1:getSecret", args ?? new GetSecretInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetSecretArgs : Pulumi.InvokeArgs
    {
        [Input("project")]
        public string? Project { get; set; }

        [Input("secretId", required: true)]
        public string SecretId { get; set; } = null!;

        public GetSecretArgs()
        {
        }
    }

    public sealed class GetSecretInvokeArgs : Pulumi.InvokeArgs
    {
        [Input("project")]
        public Input<string>? Project { get; set; }

        [Input("secretId", required: true)]
        public Input<string> SecretId { get; set; } = null!;

        public GetSecretInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetSecretResult
    {
        /// <summary>
        /// The time at which the Secret was created.
        /// </summary>
        public readonly string CreateTime;
        /// <summary>
        /// The labels assigned to this Secret. Label keys must be between 1 and 63 characters long, have a UTF-8 encoding of maximum 128 bytes, and must conform to the following PCRE regular expression: `\p{Ll}\p{Lo}{0,62}` Label values must be between 0 and 63 characters long, have a UTF-8 encoding of maximum 128 bytes, and must conform to the following PCRE regular expression: `[\p{Ll}\p{Lo}\p{N}_-]{0,63}` No more than 64 labels can be assigned to a given resource.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Labels;
        /// <summary>
        /// The resource name of the Secret in the format `projects/*/secrets/*`.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Immutable. The replication policy of the secret data attached to the Secret. The replication policy cannot be changed after the Secret has been created.
        /// </summary>
        public readonly Outputs.ReplicationResponse Replication;

        [OutputConstructor]
        private GetSecretResult(
            string createTime,

            ImmutableDictionary<string, string> labels,

            string name,

            Outputs.ReplicationResponse replication)
        {
            CreateTime = createTime;
            Labels = labels;
            Name = name;
            Replication = replication;
        }
    }
}
