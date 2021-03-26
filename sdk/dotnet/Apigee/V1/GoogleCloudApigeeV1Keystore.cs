// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.Apigee.V1
{
    /// <summary>
    /// Creates a keystore or truststore. - Keystore: Contains certificates and their associated keys. - Truststore: Contains trusted certificates used to validate a server's certificate. These certificates are typically self-signed certificates or certificates that are not signed by a trusted CA.
    /// </summary>
    [GoogleCloudResourceType("google-cloud:apigee/v1:GoogleCloudApigeeV1Keystore")]
    public partial class GoogleCloudApigeeV1Keystore : Pulumi.CustomResource
    {
        /// <summary>
        /// Create a GoogleCloudApigeeV1Keystore resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public GoogleCloudApigeeV1Keystore(string name, GoogleCloudApigeeV1KeystoreArgs args, CustomResourceOptions? options = null)
            : base("google-cloud:apigee/v1:GoogleCloudApigeeV1Keystore", name, args ?? new GoogleCloudApigeeV1KeystoreArgs(), MakeResourceOptions(options, ""))
        {
        }

        private GoogleCloudApigeeV1Keystore(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("google-cloud:apigee/v1:GoogleCloudApigeeV1Keystore", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing GoogleCloudApigeeV1Keystore resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static GoogleCloudApigeeV1Keystore Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new GoogleCloudApigeeV1Keystore(name, id, options);
        }
    }

    public sealed class GoogleCloudApigeeV1KeystoreArgs : Pulumi.ResourceArgs
    {
        [Input("aliases")]
        private InputList<string>? _aliases;

        /// <summary>
        /// Output only. Aliases in this keystore.
        /// </summary>
        public InputList<string> Aliases
        {
            get => _aliases ?? (_aliases = new InputList<string>());
            set => _aliases = value;
        }

        /// <summary>
        /// Required. Resource ID for this keystore. Values must match the regular expression `[\w[:space:]-.]{1,255}`.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Required. Name of the environment in which to create the keystore. Use the following format in your request: `organizations/{org}/environments/{env}`
        /// </summary>
        [Input("parent", required: true)]
        public Input<string> Parent { get; set; } = null!;

        public GoogleCloudApigeeV1KeystoreArgs()
        {
        }
    }
}