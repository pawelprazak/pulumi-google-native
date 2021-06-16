// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.ServiceDirectory.V1
{
    public static class GetNamespace
    {
        /// <summary>
        /// Gets a namespace.
        /// </summary>
        public static Task<GetNamespaceResult> InvokeAsync(GetNamespaceArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetNamespaceResult>("google-native:servicedirectory/v1:getNamespace", args ?? new GetNamespaceArgs(), options.WithVersion());
    }


    public sealed class GetNamespaceArgs : Pulumi.InvokeArgs
    {
        [Input("location", required: true)]
        public string Location { get; set; } = null!;

        [Input("namespaceId", required: true)]
        public string NamespaceId { get; set; } = null!;

        [Input("project", required: true)]
        public string Project { get; set; } = null!;

        public GetNamespaceArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetNamespaceResult
    {
        /// <summary>
        /// Optional. Resource labels associated with this namespace. No more than 64 user labels can be associated with a given resource. Label keys and values can be no longer than 63 characters.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Labels;
        /// <summary>
        /// Immutable. The resource name for the namespace in the format `projects/*/locations/*/namespaces/*`.
        /// </summary>
        public readonly string Name;

        [OutputConstructor]
        private GetNamespaceResult(
            ImmutableDictionary<string, string> labels,

            string name)
        {
            Labels = labels;
            Name = name;
        }
    }
}