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
    /// Create a Datastore for an org
    /// </summary>
    [GoogleCloudResourceType("google-cloud:apigee/v1:GoogleCloudApigeeV1Datastore")]
    public partial class GoogleCloudApigeeV1Datastore : Pulumi.CustomResource
    {
        /// <summary>
        /// Create a GoogleCloudApigeeV1Datastore resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public GoogleCloudApigeeV1Datastore(string name, GoogleCloudApigeeV1DatastoreArgs args, CustomResourceOptions? options = null)
            : base("google-cloud:apigee/v1:GoogleCloudApigeeV1Datastore", name, args ?? new GoogleCloudApigeeV1DatastoreArgs(), MakeResourceOptions(options, ""))
        {
        }

        private GoogleCloudApigeeV1Datastore(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("google-cloud:apigee/v1:GoogleCloudApigeeV1Datastore", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing GoogleCloudApigeeV1Datastore resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static GoogleCloudApigeeV1Datastore Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new GoogleCloudApigeeV1Datastore(name, id, options);
        }
    }

    public sealed class GoogleCloudApigeeV1DatastoreArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Output only. Datastore create time, in milliseconds since the epoch of 1970-01-01T00:00:00Z
        /// </summary>
        [Input("createTime")]
        public Input<string>? CreateTime { get; set; }

        /// <summary>
        /// Datastore Configurations.
        /// </summary>
        [Input("datastoreConfig")]
        public Input<Inputs.GoogleCloudApigeeV1DatastoreConfigArgs>? DatastoreConfig { get; set; }

        /// <summary>
        /// Required. Display name in UI
        /// </summary>
        [Input("displayName")]
        public Input<string>? DisplayName { get; set; }

        /// <summary>
        /// Output only. Datastore last update time, in milliseconds since the epoch of 1970-01-01T00:00:00Z
        /// </summary>
        [Input("lastUpdateTime")]
        public Input<string>? LastUpdateTime { get; set; }

        /// <summary>
        /// Output only. Organization that the datastore belongs to
        /// </summary>
        [Input("org")]
        public Input<string>? Org { get; set; }

        /// <summary>
        /// Required. The parent organization name. Must be of the form `organizations/{org}`.
        /// </summary>
        [Input("parent", required: true)]
        public Input<string> Parent { get; set; } = null!;

        /// <summary>
        /// Output only. Resource link of Datastore. Example: `/organizations/{org}/analytics/datastores/{uuid}`
        /// </summary>
        [Input("self")]
        public Input<string>? Self { get; set; }

        /// <summary>
        /// Destination storage type. Supported types `gcs` or `bigquery`.
        /// </summary>
        [Input("targetType")]
        public Input<string>? TargetType { get; set; }

        public GoogleCloudApigeeV1DatastoreArgs()
        {
        }
    }
}