// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.Datacatalog.V1beta1
{
    /// <summary>
    /// A maximum of 10,000 entry groups may be created per organization across all locations. Users should enable the Data Catalog API in the project identified by the `parent` parameter (see [Data Catalog Resource Project] (https://cloud.google.com/data-catalog/docs/concepts/resource-project) for more information).
    /// </summary>
    [GoogleCloudResourceType("google-cloud:datacatalog/v1beta1:GoogleCloudDatacatalogV1beta1EntryGroup")]
    public partial class GoogleCloudDatacatalogV1beta1EntryGroup : Pulumi.CustomResource
    {
        /// <summary>
        /// Create a GoogleCloudDatacatalogV1beta1EntryGroup resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public GoogleCloudDatacatalogV1beta1EntryGroup(string name, GoogleCloudDatacatalogV1beta1EntryGroupArgs args, CustomResourceOptions? options = null)
            : base("google-cloud:datacatalog/v1beta1:GoogleCloudDatacatalogV1beta1EntryGroup", name, args ?? new GoogleCloudDatacatalogV1beta1EntryGroupArgs(), MakeResourceOptions(options, ""))
        {
        }

        private GoogleCloudDatacatalogV1beta1EntryGroup(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("google-cloud:datacatalog/v1beta1:GoogleCloudDatacatalogV1beta1EntryGroup", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing GoogleCloudDatacatalogV1beta1EntryGroup resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static GoogleCloudDatacatalogV1beta1EntryGroup Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new GoogleCloudDatacatalogV1beta1EntryGroup(name, id, options);
        }
    }

    public sealed class GoogleCloudDatacatalogV1beta1EntryGroupArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Output only. Timestamps about this EntryGroup. Default value is empty timestamps.
        /// </summary>
        [Input("dataCatalogTimestamps")]
        public Input<Inputs.GoogleCloudDatacatalogV1beta1SystemTimestampsArgs>? DataCatalogTimestamps { get; set; }

        /// <summary>
        /// Entry group description, which can consist of several sentences or paragraphs that describe entry group contents. Default value is an empty string.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// A short name to identify the entry group, for example, "analytics data - jan 2011". Default value is an empty string.
        /// </summary>
        [Input("displayName")]
        public Input<string>? DisplayName { get; set; }

        /// <summary>
        /// Required. The id of the entry group to create. The id must begin with a letter or underscore, contain only English letters, numbers and underscores, and be at most 64 characters.
        /// </summary>
        [Input("entryGroupId")]
        public Input<string>? EntryGroupId { get; set; }

        /// <summary>
        /// The resource name of the entry group in URL format. Example: * projects/{project_id}/locations/{location}/entryGroups/{entry_group_id} Note that this EntryGroup and its child resources may not actually be stored in the location in this name.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Required. The name of the project this entry group is in. Example: * projects/{project_id}/locations/{location} Note that this EntryGroup and its child resources may not actually be stored in the location in this name.
        /// </summary>
        [Input("parent", required: true)]
        public Input<string> Parent { get; set; } = null!;

        public GoogleCloudDatacatalogV1beta1EntryGroupArgs()
        {
        }
    }
}