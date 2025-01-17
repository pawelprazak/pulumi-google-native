// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.CloudResourceManager.V3
{
    /// <summary>
    /// Creates a new TagKey. If another request with the same parameters is sent while the original request is in process, the second request will receive an error. A maximum of 1000 TagKeys can exist under a parent at any given time.
    /// </summary>
    [GoogleNativeResourceType("google-native:cloudresourcemanager/v3:TagKey")]
    public partial class TagKey : Pulumi.CustomResource
    {
        /// <summary>
        /// Creation time.
        /// </summary>
        [Output("createTime")]
        public Output<string> CreateTime { get; private set; } = null!;

        /// <summary>
        /// Optional. User-assigned description of the TagKey. Must not exceed 256 characters. Read-write.
        /// </summary>
        [Output("description")]
        public Output<string> Description { get; private set; } = null!;

        /// <summary>
        /// Optional. Entity tag which users can pass to prevent race conditions. This field is always set in server responses. See UpdateTagKeyRequest for details.
        /// </summary>
        [Output("etag")]
        public Output<string> Etag { get; private set; } = null!;

        /// <summary>
        /// Immutable. The resource name for a TagKey. Must be in the format `tagKeys/{tag_key_id}`, where `tag_key_id` is the generated numeric id for the TagKey.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Immutable. Namespaced name of the TagKey.
        /// </summary>
        [Output("namespacedName")]
        public Output<string> NamespacedName { get; private set; } = null!;

        /// <summary>
        /// Immutable. The resource name of the new TagKey's parent. Must be of the form `organizations/{org_id}`.
        /// </summary>
        [Output("parent")]
        public Output<string> Parent { get; private set; } = null!;

        /// <summary>
        /// Optional. A purpose denotes that this Tag is intended for use in policies of a specific policy engine, and will involve that policy engine in management operations involving this Tag. A purpose does not grant a policy engine exclusive rights to the Tag, and it may be referenced by other policy engines. A purpose cannot be changed once set.
        /// </summary>
        [Output("purpose")]
        public Output<string> Purpose { get; private set; } = null!;

        /// <summary>
        /// Optional. Purpose data corresponds to the policy system that the tag is intended for. See documentation for `Purpose` for formatting of this field. Purpose data cannot be changed once set.
        /// </summary>
        [Output("purposeData")]
        public Output<ImmutableDictionary<string, string>> PurposeData { get; private set; } = null!;

        /// <summary>
        /// Immutable. The user friendly name for a TagKey. The short name should be unique for TagKeys within the same tag namespace. The short name must be 1-63 characters, beginning and ending with an alphanumeric character ([a-z0-9A-Z]) with dashes (-), underscores (_), dots (.), and alphanumerics between.
        /// </summary>
        [Output("shortName")]
        public Output<string> ShortName { get; private set; } = null!;

        /// <summary>
        /// Update time.
        /// </summary>
        [Output("updateTime")]
        public Output<string> UpdateTime { get; private set; } = null!;

        /// <summary>
        /// Optional. Set to true to perform validations necessary for creating the resource, but not actually perform the action.
        /// </summary>
        [Output("validateOnly")]
        public Output<string?> ValidateOnly { get; private set; } = null!;


        /// <summary>
        /// Create a TagKey resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public TagKey(string name, TagKeyArgs args, CustomResourceOptions? options = null)
            : base("google-native:cloudresourcemanager/v3:TagKey", name, args ?? new TagKeyArgs(), MakeResourceOptions(options, ""))
        {
        }

        private TagKey(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("google-native:cloudresourcemanager/v3:TagKey", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing TagKey resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static TagKey Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new TagKey(name, id, options);
        }
    }

    public sealed class TagKeyArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Optional. User-assigned description of the TagKey. Must not exceed 256 characters. Read-write.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Optional. Entity tag which users can pass to prevent race conditions. This field is always set in server responses. See UpdateTagKeyRequest for details.
        /// </summary>
        [Input("etag")]
        public Input<string>? Etag { get; set; }

        /// <summary>
        /// Immutable. The resource name for a TagKey. Must be in the format `tagKeys/{tag_key_id}`, where `tag_key_id` is the generated numeric id for the TagKey.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Immutable. The resource name of the new TagKey's parent. Must be of the form `organizations/{org_id}`.
        /// </summary>
        [Input("parent")]
        public Input<string>? Parent { get; set; }

        /// <summary>
        /// Optional. A purpose denotes that this Tag is intended for use in policies of a specific policy engine, and will involve that policy engine in management operations involving this Tag. A purpose does not grant a policy engine exclusive rights to the Tag, and it may be referenced by other policy engines. A purpose cannot be changed once set.
        /// </summary>
        [Input("purpose")]
        public Input<Pulumi.GoogleNative.CloudResourceManager.V3.TagKeyPurpose>? Purpose { get; set; }

        [Input("purposeData")]
        private InputMap<string>? _purposeData;

        /// <summary>
        /// Optional. Purpose data corresponds to the policy system that the tag is intended for. See documentation for `Purpose` for formatting of this field. Purpose data cannot be changed once set.
        /// </summary>
        public InputMap<string> PurposeData
        {
            get => _purposeData ?? (_purposeData = new InputMap<string>());
            set => _purposeData = value;
        }

        /// <summary>
        /// Immutable. The user friendly name for a TagKey. The short name should be unique for TagKeys within the same tag namespace. The short name must be 1-63 characters, beginning and ending with an alphanumeric character ([a-z0-9A-Z]) with dashes (-), underscores (_), dots (.), and alphanumerics between.
        /// </summary>
        [Input("shortName", required: true)]
        public Input<string> ShortName { get; set; } = null!;

        /// <summary>
        /// Optional. Set to true to perform validations necessary for creating the resource, but not actually perform the action.
        /// </summary>
        [Input("validateOnly")]
        public Input<string>? ValidateOnly { get; set; }

        public TagKeyArgs()
        {
        }
    }
}
