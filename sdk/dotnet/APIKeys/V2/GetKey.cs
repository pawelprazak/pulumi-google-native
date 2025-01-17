// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.APIKeys.V2
{
    public static class GetKey
    {
        /// <summary>
        /// Gets the metadata for an API key. The key string of the API key isn't included in the response. NOTE: Key is a global resource; hence the only supported value for location is `global`.
        /// </summary>
        public static Task<GetKeyResult> InvokeAsync(GetKeyArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetKeyResult>("google-native:apikeys/v2:getKey", args ?? new GetKeyArgs(), options.WithDefaults());

        /// <summary>
        /// Gets the metadata for an API key. The key string of the API key isn't included in the response. NOTE: Key is a global resource; hence the only supported value for location is `global`.
        /// </summary>
        public static Output<GetKeyResult> Invoke(GetKeyInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetKeyResult>("google-native:apikeys/v2:getKey", args ?? new GetKeyInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetKeyArgs : Pulumi.InvokeArgs
    {
        [Input("keyId", required: true)]
        public string KeyId { get; set; } = null!;

        [Input("location", required: true)]
        public string Location { get; set; } = null!;

        [Input("project")]
        public string? Project { get; set; }

        public GetKeyArgs()
        {
        }
    }

    public sealed class GetKeyInvokeArgs : Pulumi.InvokeArgs
    {
        [Input("keyId", required: true)]
        public Input<string> KeyId { get; set; } = null!;

        [Input("location", required: true)]
        public Input<string> Location { get; set; } = null!;

        [Input("project")]
        public Input<string>? Project { get; set; }

        public GetKeyInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetKeyResult
    {
        /// <summary>
        /// Annotations is an unstructured key-value map stored with a policy that may be set by external tools to store and retrieve arbitrary metadata. They are not queryable and should be preserved when modifying objects.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Annotations;
        /// <summary>
        /// A timestamp identifying the time this key was originally created.
        /// </summary>
        public readonly string CreateTime;
        /// <summary>
        /// A timestamp when this key was deleted. If the resource is not deleted, this must be empty.
        /// </summary>
        public readonly string DeleteTime;
        /// <summary>
        /// Human-readable display name of this key that you can modify. The maximum length is 63 characters.
        /// </summary>
        public readonly string DisplayName;
        /// <summary>
        /// A checksum computed by the server based on the current value of the Key resource. This may be sent on update and delete requests to ensure the client has an up-to-date value before proceeding. See https://google.aip.dev/154.
        /// </summary>
        public readonly string Etag;
        /// <summary>
        /// An encrypted and signed value held by this key. This field can be accessed only through the `GetKeyString` method.
        /// </summary>
        public readonly string KeyString;
        /// <summary>
        /// The resource name of the key. The `name` has the form: `projects//locations/global/keys/`. For example: `projects/123456867718/locations/global/keys/b7ff1f9f-8275-410a-94dd-3855ee9b5dd2` NOTE: Key is a global resource; hence the only supported value for location is `global`.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Key restrictions.
        /// </summary>
        public readonly Outputs.V2RestrictionsResponse Restrictions;
        /// <summary>
        /// Unique id in UUID4 format.
        /// </summary>
        public readonly string Uid;
        /// <summary>
        /// A timestamp identifying the time this key was last updated.
        /// </summary>
        public readonly string UpdateTime;

        [OutputConstructor]
        private GetKeyResult(
            ImmutableDictionary<string, string> annotations,

            string createTime,

            string deleteTime,

            string displayName,

            string etag,

            string keyString,

            string name,

            Outputs.V2RestrictionsResponse restrictions,

            string uid,

            string updateTime)
        {
            Annotations = annotations;
            CreateTime = createTime;
            DeleteTime = deleteTime;
            DisplayName = displayName;
            Etag = etag;
            KeyString = keyString;
            Name = name;
            Restrictions = restrictions;
            Uid = uid;
            UpdateTime = updateTime;
        }
    }
}
