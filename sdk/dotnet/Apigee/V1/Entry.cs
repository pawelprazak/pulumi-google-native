// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.Apigee.V1
{
    /// <summary>
    /// Creates key value entries in a key value map scoped to an organization, environment, or API proxy.
    /// </summary>
    [GoogleNativeResourceType("google-native:apigee/v1:Entry")]
    public partial class Entry : Pulumi.CustomResource
    {
        [Output("apiId")]
        public Output<string> ApiId { get; private set; } = null!;

        [Output("keyvaluemapId")]
        public Output<string> KeyvaluemapId { get; private set; } = null!;

        /// <summary>
        /// Resource URI that can be used to identify the scope of the key value map entries.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        [Output("organizationId")]
        public Output<string> OrganizationId { get; private set; } = null!;

        /// <summary>
        /// Data or payload that is being retrieved and associated with the unique key.
        /// </summary>
        [Output("value")]
        public Output<string> Value { get; private set; } = null!;


        /// <summary>
        /// Create a Entry resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Entry(string name, EntryArgs args, CustomResourceOptions? options = null)
            : base("google-native:apigee/v1:Entry", name, args ?? new EntryArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Entry(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("google-native:apigee/v1:Entry", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Entry resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Entry Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Entry(name, id, options);
        }
    }

    public sealed class EntryArgs : Pulumi.ResourceArgs
    {
        [Input("apiId", required: true)]
        public Input<string> ApiId { get; set; } = null!;

        [Input("keyvaluemapId", required: true)]
        public Input<string> KeyvaluemapId { get; set; } = null!;

        /// <summary>
        /// Resource URI that can be used to identify the scope of the key value map entries.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("organizationId", required: true)]
        public Input<string> OrganizationId { get; set; } = null!;

        /// <summary>
        /// Data or payload that is being retrieved and associated with the unique key.
        /// </summary>
        [Input("value", required: true)]
        public Input<string> Value { get; set; } = null!;

        public EntryArgs()
        {
        }
    }
}
