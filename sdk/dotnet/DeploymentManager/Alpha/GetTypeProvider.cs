// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.DeploymentManager.Alpha
{
    public static class GetTypeProvider
    {
        /// <summary>
        /// Gets information about a specific type provider.
        /// </summary>
        public static Task<GetTypeProviderResult> InvokeAsync(GetTypeProviderArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetTypeProviderResult>("google-native:deploymentmanager/alpha:getTypeProvider", args ?? new GetTypeProviderArgs(), options.WithDefaults());

        /// <summary>
        /// Gets information about a specific type provider.
        /// </summary>
        public static Output<GetTypeProviderResult> Invoke(GetTypeProviderInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetTypeProviderResult>("google-native:deploymentmanager/alpha:getTypeProvider", args ?? new GetTypeProviderInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetTypeProviderArgs : Pulumi.InvokeArgs
    {
        [Input("project")]
        public string? Project { get; set; }

        [Input("typeProvider", required: true)]
        public string TypeProvider { get; set; } = null!;

        public GetTypeProviderArgs()
        {
        }
    }

    public sealed class GetTypeProviderInvokeArgs : Pulumi.InvokeArgs
    {
        [Input("project")]
        public Input<string>? Project { get; set; }

        [Input("typeProvider", required: true)]
        public Input<string> TypeProvider { get; set; } = null!;

        public GetTypeProviderInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetTypeProviderResult
    {
        /// <summary>
        /// Allows resource handling overrides for specific collections
        /// </summary>
        public readonly ImmutableArray<Outputs.CollectionOverrideResponse> CollectionOverrides;
        /// <summary>
        /// Credential used when interacting with this type.
        /// </summary>
        public readonly Outputs.CredentialResponse Credential;
        /// <summary>
        /// List of up to 2 custom certificate authority roots to use for TLS authentication when making calls on behalf of this type provider. If set, TLS authentication will exclusively use these roots instead of relying on publicly trusted certificate authorities when validating TLS certificate authenticity. The certificates must be in base64-encoded PEM format. The maximum size of each certificate must not exceed 10KB.
        /// </summary>
        public readonly ImmutableArray<string> CustomCertificateAuthorityRoots;
        /// <summary>
        /// An optional textual description of the resource; provided by the client when the resource is created.
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// Descriptor Url for the this type provider.
        /// </summary>
        public readonly string DescriptorUrl;
        /// <summary>
        /// Creation timestamp in RFC3339 text format.
        /// </summary>
        public readonly string InsertTime;
        /// <summary>
        /// Map of One Platform labels; provided by the client when the resource is created or updated. Specifically: Label keys must be between 1 and 63 characters long and must conform to the following regular expression: `[a-z]([-a-z0-9]*[a-z0-9])?` Label values must be between 0 and 63 characters long and must conform to the regular expression `([a-z]([-a-z0-9]*[a-z0-9])?)?`
        /// </summary>
        public readonly ImmutableArray<Outputs.TypeProviderLabelEntryResponse> Labels;
        /// <summary>
        /// Name of the resource; provided by the client when the resource is created. The name must be 1-63 characters long, and comply with RFC1035. Specifically, the name must be 1-63 characters long and match the regular expression `[a-z]([-a-z0-9]*[a-z0-9])?` which means the first character must be a lowercase letter, and all following characters must be a dash, lowercase letter, or digit, except the last character, which cannot be a dash.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The Operation that most recently ran, or is currently running, on this type provider.
        /// </summary>
        public readonly Outputs.OperationResponse Operation;
        /// <summary>
        /// Options to apply when handling any resources in this service.
        /// </summary>
        public readonly Outputs.OptionsResponse Options;
        /// <summary>
        /// Self link for the type provider.
        /// </summary>
        public readonly string SelfLink;

        [OutputConstructor]
        private GetTypeProviderResult(
            ImmutableArray<Outputs.CollectionOverrideResponse> collectionOverrides,

            Outputs.CredentialResponse credential,

            ImmutableArray<string> customCertificateAuthorityRoots,

            string description,

            string descriptorUrl,

            string insertTime,

            ImmutableArray<Outputs.TypeProviderLabelEntryResponse> labels,

            string name,

            Outputs.OperationResponse operation,

            Outputs.OptionsResponse options,

            string selfLink)
        {
            CollectionOverrides = collectionOverrides;
            Credential = credential;
            CustomCertificateAuthorityRoots = customCertificateAuthorityRoots;
            Description = description;
            DescriptorUrl = descriptorUrl;
            InsertTime = insertTime;
            Labels = labels;
            Name = name;
            Operation = operation;
            Options = options;
            SelfLink = selfLink;
        }
    }
}
