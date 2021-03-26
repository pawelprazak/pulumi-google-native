// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

/**
 * Creates an entry. Only entries of 'FILESET' type or user-specified type can be created. Users should enable the Data Catalog API in the project identified by the `parent` parameter (see [Data Catalog Resource Project] (https://cloud.google.com/data-catalog/docs/concepts/resource-project) for more information). A maximum of 100,000 entries may be created per entry group.
 */
export class GoogleCloudDatacatalogV1beta1Entry extends pulumi.CustomResource {
    /**
     * Get an existing GoogleCloudDatacatalogV1beta1Entry resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): GoogleCloudDatacatalogV1beta1Entry {
        return new GoogleCloudDatacatalogV1beta1Entry(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'google-cloud:datacatalog/v1beta1:GoogleCloudDatacatalogV1beta1Entry';

    /**
     * Returns true if the given object is an instance of GoogleCloudDatacatalogV1beta1Entry.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is GoogleCloudDatacatalogV1beta1Entry {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === GoogleCloudDatacatalogV1beta1Entry.__pulumiType;
    }


    /**
     * Create a GoogleCloudDatacatalogV1beta1Entry resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: GoogleCloudDatacatalogV1beta1EntryArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.parent === undefined) && !opts.urn) {
                throw new Error("Missing required property 'parent'");
            }
            inputs["bigqueryDateShardedSpec"] = args ? args.bigqueryDateShardedSpec : undefined;
            inputs["bigqueryTableSpec"] = args ? args.bigqueryTableSpec : undefined;
            inputs["description"] = args ? args.description : undefined;
            inputs["displayName"] = args ? args.displayName : undefined;
            inputs["entryId"] = args ? args.entryId : undefined;
            inputs["gcsFilesetSpec"] = args ? args.gcsFilesetSpec : undefined;
            inputs["integratedSystem"] = args ? args.integratedSystem : undefined;
            inputs["linkedResource"] = args ? args.linkedResource : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["parent"] = args ? args.parent : undefined;
            inputs["schema"] = args ? args.schema : undefined;
            inputs["sourceSystemTimestamps"] = args ? args.sourceSystemTimestamps : undefined;
            inputs["type"] = args ? args.type : undefined;
            inputs["userSpecifiedSystem"] = args ? args.userSpecifiedSystem : undefined;
            inputs["userSpecifiedType"] = args ? args.userSpecifiedType : undefined;
        } else {
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(GoogleCloudDatacatalogV1beta1Entry.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a GoogleCloudDatacatalogV1beta1Entry resource.
 */
export interface GoogleCloudDatacatalogV1beta1EntryArgs {
    /**
     * Specification for a group of BigQuery tables with name pattern `[prefix]YYYYMMDD`. Context: https://cloud.google.com/bigquery/docs/partitioned-tables#partitioning_versus_sharding.
     */
    readonly bigqueryDateShardedSpec?: pulumi.Input<inputs.datacatalog.v1beta1.GoogleCloudDatacatalogV1beta1BigQueryDateShardedSpec>;
    /**
     * Specification that applies to a BigQuery table. This is only valid on entries of type `TABLE`.
     */
    readonly bigqueryTableSpec?: pulumi.Input<inputs.datacatalog.v1beta1.GoogleCloudDatacatalogV1beta1BigQueryTableSpec>;
    /**
     * Entry description, which can consist of several sentences or paragraphs that describe entry contents. Default value is an empty string.
     */
    readonly description?: pulumi.Input<string>;
    /**
     * Display information such as title and description. A short name to identify the entry, for example, "Analytics Data - Jan 2011". Default value is an empty string.
     */
    readonly displayName?: pulumi.Input<string>;
    /**
     * Required. The id of the entry to create.
     */
    readonly entryId?: pulumi.Input<string>;
    /**
     * Specification that applies to a Cloud Storage fileset. This is only valid on entries of type FILESET.
     */
    readonly gcsFilesetSpec?: pulumi.Input<inputs.datacatalog.v1beta1.GoogleCloudDatacatalogV1beta1GcsFilesetSpec>;
    /**
     * Output only. This field indicates the entry's source system that Data Catalog integrates with, such as BigQuery or Pub/Sub.
     */
    readonly integratedSystem?: pulumi.Input<string>;
    /**
     * The resource this metadata entry refers to. For Google Cloud Platform resources, `linked_resource` is the [full name of the resource](https://cloud.google.com/apis/design/resource_names#full_resource_name). For example, the `linked_resource` for a table resource from BigQuery is: * //bigquery.googleapis.com/projects/projectId/datasets/datasetId/tables/tableId Output only when Entry is of type in the EntryType enum. For entries with user_specified_type, this field is optional and defaults to an empty string.
     */
    readonly linkedResource?: pulumi.Input<string>;
    /**
     * Output only. The Data Catalog resource name of the entry in URL format. Example: * projects/{project_id}/locations/{location}/entryGroups/{entry_group_id}/entries/{entry_id} Note that this Entry and its child resources may not actually be stored in the location in this name.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * Required. The name of the entry group this entry is in. Example: * projects/{project_id}/locations/{location}/entryGroups/{entry_group_id} Note that this Entry and its child resources may not actually be stored in the location in this name.
     */
    readonly parent: pulumi.Input<string>;
    /**
     * Schema of the entry. An entry might not have any schema attached to it.
     */
    readonly schema?: pulumi.Input<inputs.datacatalog.v1beta1.GoogleCloudDatacatalogV1beta1Schema>;
    /**
     * Output only. Timestamps about the underlying resource, not about this Data Catalog entry. Output only when Entry is of type in the EntryType enum. For entries with user_specified_type, this field is optional and defaults to an empty timestamp.
     */
    readonly sourceSystemTimestamps?: pulumi.Input<inputs.datacatalog.v1beta1.GoogleCloudDatacatalogV1beta1SystemTimestamps>;
    /**
     * The type of the entry. Only used for Entries with types in the EntryType enum.
     */
    readonly type?: pulumi.Input<string>;
    /**
     * This field indicates the entry's source system that Data Catalog does not integrate with. `user_specified_system` strings must begin with a letter or underscore and can only contain letters, numbers, and underscores; are case insensitive; must be at least 1 character and at most 64 characters long.
     */
    readonly userSpecifiedSystem?: pulumi.Input<string>;
    /**
     * Entry type if it does not fit any of the input-allowed values listed in `EntryType` enum above. When creating an entry, users should check the enum values first, if nothing matches the entry to be created, then provide a custom value, for example "my_special_type". `user_specified_type` strings must begin with a letter or underscore and can only contain letters, numbers, and underscores; are case insensitive; must be at least 1 character and at most 64 characters long. Currently, only FILESET enum value is allowed. All other entries created through Data Catalog must use `user_specified_type`.
     */
    readonly userSpecifiedType?: pulumi.Input<string>;
}