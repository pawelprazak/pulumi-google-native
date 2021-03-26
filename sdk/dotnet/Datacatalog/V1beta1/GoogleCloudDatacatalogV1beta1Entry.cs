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
    /// Creates an entry. Only entries of 'FILESET' type or user-specified type can be created. Users should enable the Data Catalog API in the project identified by the `parent` parameter (see [Data Catalog Resource Project] (https://cloud.google.com/data-catalog/docs/concepts/resource-project) for more information). A maximum of 100,000 entries may be created per entry group.
    /// </summary>
    [GoogleCloudResourceType("google-cloud:datacatalog/v1beta1:GoogleCloudDatacatalogV1beta1Entry")]
    public partial class GoogleCloudDatacatalogV1beta1Entry : Pulumi.CustomResource
    {
        /// <summary>
        /// Create a GoogleCloudDatacatalogV1beta1Entry resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public GoogleCloudDatacatalogV1beta1Entry(string name, GoogleCloudDatacatalogV1beta1EntryArgs args, CustomResourceOptions? options = null)
            : base("google-cloud:datacatalog/v1beta1:GoogleCloudDatacatalogV1beta1Entry", name, args ?? new GoogleCloudDatacatalogV1beta1EntryArgs(), MakeResourceOptions(options, ""))
        {
        }

        private GoogleCloudDatacatalogV1beta1Entry(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("google-cloud:datacatalog/v1beta1:GoogleCloudDatacatalogV1beta1Entry", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing GoogleCloudDatacatalogV1beta1Entry resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static GoogleCloudDatacatalogV1beta1Entry Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new GoogleCloudDatacatalogV1beta1Entry(name, id, options);
        }
    }

    public sealed class GoogleCloudDatacatalogV1beta1EntryArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specification for a group of BigQuery tables with name pattern `[prefix]YYYYMMDD`. Context: https://cloud.google.com/bigquery/docs/partitioned-tables#partitioning_versus_sharding.
        /// </summary>
        [Input("bigqueryDateShardedSpec")]
        public Input<Inputs.GoogleCloudDatacatalogV1beta1BigQueryDateShardedSpecArgs>? BigqueryDateShardedSpec { get; set; }

        /// <summary>
        /// Specification that applies to a BigQuery table. This is only valid on entries of type `TABLE`.
        /// </summary>
        [Input("bigqueryTableSpec")]
        public Input<Inputs.GoogleCloudDatacatalogV1beta1BigQueryTableSpecArgs>? BigqueryTableSpec { get; set; }

        /// <summary>
        /// Entry description, which can consist of several sentences or paragraphs that describe entry contents. Default value is an empty string.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Display information such as title and description. A short name to identify the entry, for example, "Analytics Data - Jan 2011". Default value is an empty string.
        /// </summary>
        [Input("displayName")]
        public Input<string>? DisplayName { get; set; }

        /// <summary>
        /// Required. The id of the entry to create.
        /// </summary>
        [Input("entryId")]
        public Input<string>? EntryId { get; set; }

        /// <summary>
        /// Specification that applies to a Cloud Storage fileset. This is only valid on entries of type FILESET.
        /// </summary>
        [Input("gcsFilesetSpec")]
        public Input<Inputs.GoogleCloudDatacatalogV1beta1GcsFilesetSpecArgs>? GcsFilesetSpec { get; set; }

        /// <summary>
        /// Output only. This field indicates the entry's source system that Data Catalog integrates with, such as BigQuery or Pub/Sub.
        /// </summary>
        [Input("integratedSystem")]
        public Input<string>? IntegratedSystem { get; set; }

        /// <summary>
        /// The resource this metadata entry refers to. For Google Cloud Platform resources, `linked_resource` is the [full name of the resource](https://cloud.google.com/apis/design/resource_names#full_resource_name). For example, the `linked_resource` for a table resource from BigQuery is: * //bigquery.googleapis.com/projects/projectId/datasets/datasetId/tables/tableId Output only when Entry is of type in the EntryType enum. For entries with user_specified_type, this field is optional and defaults to an empty string.
        /// </summary>
        [Input("linkedResource")]
        public Input<string>? LinkedResource { get; set; }

        /// <summary>
        /// Output only. The Data Catalog resource name of the entry in URL format. Example: * projects/{project_id}/locations/{location}/entryGroups/{entry_group_id}/entries/{entry_id} Note that this Entry and its child resources may not actually be stored in the location in this name.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Required. The name of the entry group this entry is in. Example: * projects/{project_id}/locations/{location}/entryGroups/{entry_group_id} Note that this Entry and its child resources may not actually be stored in the location in this name.
        /// </summary>
        [Input("parent", required: true)]
        public Input<string> Parent { get; set; } = null!;

        /// <summary>
        /// Schema of the entry. An entry might not have any schema attached to it.
        /// </summary>
        [Input("schema")]
        public Input<Inputs.GoogleCloudDatacatalogV1beta1SchemaArgs>? Schema { get; set; }

        /// <summary>
        /// Output only. Timestamps about the underlying resource, not about this Data Catalog entry. Output only when Entry is of type in the EntryType enum. For entries with user_specified_type, this field is optional and defaults to an empty timestamp.
        /// </summary>
        [Input("sourceSystemTimestamps")]
        public Input<Inputs.GoogleCloudDatacatalogV1beta1SystemTimestampsArgs>? SourceSystemTimestamps { get; set; }

        /// <summary>
        /// The type of the entry. Only used for Entries with types in the EntryType enum.
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        /// <summary>
        /// This field indicates the entry's source system that Data Catalog does not integrate with. `user_specified_system` strings must begin with a letter or underscore and can only contain letters, numbers, and underscores; are case insensitive; must be at least 1 character and at most 64 characters long.
        /// </summary>
        [Input("userSpecifiedSystem")]
        public Input<string>? UserSpecifiedSystem { get; set; }

        /// <summary>
        /// Entry type if it does not fit any of the input-allowed values listed in `EntryType` enum above. When creating an entry, users should check the enum values first, if nothing matches the entry to be created, then provide a custom value, for example "my_special_type". `user_specified_type` strings must begin with a letter or underscore and can only contain letters, numbers, and underscores; are case insensitive; must be at least 1 character and at most 64 characters long. Currently, only FILESET enum value is allowed. All other entries created through Data Catalog must use `user_specified_type`.
        /// </summary>
        [Input("userSpecifiedType")]
        public Input<string>? UserSpecifiedType { get; set; }

        public GoogleCloudDatacatalogV1beta1EntryArgs()
        {
        }
    }
}