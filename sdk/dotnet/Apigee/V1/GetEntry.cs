// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.Apigee.V1
{
    public static class GetEntry
    {
        /// <summary>
        /// Get the Key value entry value for org, env or apis scoped Key value map.
        /// </summary>
        public static Task<GetEntryResult> InvokeAsync(GetEntryArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetEntryResult>("google-native:apigee/v1:getEntry", args ?? new GetEntryArgs(), options.WithDefaults());

        /// <summary>
        /// Get the Key value entry value for org, env or apis scoped Key value map.
        /// </summary>
        public static Output<GetEntryResult> Invoke(GetEntryInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetEntryResult>("google-native:apigee/v1:getEntry", args ?? new GetEntryInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetEntryArgs : Pulumi.InvokeArgs
    {
        [Input("apiId", required: true)]
        public string ApiId { get; set; } = null!;

        [Input("entryId", required: true)]
        public string EntryId { get; set; } = null!;

        [Input("keyvaluemapId", required: true)]
        public string KeyvaluemapId { get; set; } = null!;

        [Input("organizationId", required: true)]
        public string OrganizationId { get; set; } = null!;

        public GetEntryArgs()
        {
        }
    }

    public sealed class GetEntryInvokeArgs : Pulumi.InvokeArgs
    {
        [Input("apiId", required: true)]
        public Input<string> ApiId { get; set; } = null!;

        [Input("entryId", required: true)]
        public Input<string> EntryId { get; set; } = null!;

        [Input("keyvaluemapId", required: true)]
        public Input<string> KeyvaluemapId { get; set; } = null!;

        [Input("organizationId", required: true)]
        public Input<string> OrganizationId { get; set; } = null!;

        public GetEntryInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetEntryResult
    {
        /// <summary>
        /// Resource URI that can be used to identify the scope of the key value map entries.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Data or payload that is being retrieved and associated with the unique key.
        /// </summary>
        public readonly string Value;

        [OutputConstructor]
        private GetEntryResult(
            string name,

            string value)
        {
            Name = name;
            Value = value;
        }
    }
}
