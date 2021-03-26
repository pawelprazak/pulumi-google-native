// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

/**
 * A maximum of 10,000 entry groups may be created per organization across all locations. Users should enable the Data Catalog API in the project identified by the `parent` parameter (see [Data Catalog Resource Project] (https://cloud.google.com/data-catalog/docs/concepts/resource-project) for more information).
 */
export class GoogleCloudDatacatalogV1beta1EntryGroup extends pulumi.CustomResource {
    /**
     * Get an existing GoogleCloudDatacatalogV1beta1EntryGroup resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): GoogleCloudDatacatalogV1beta1EntryGroup {
        return new GoogleCloudDatacatalogV1beta1EntryGroup(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'google-cloud:datacatalog/v1beta1:GoogleCloudDatacatalogV1beta1EntryGroup';

    /**
     * Returns true if the given object is an instance of GoogleCloudDatacatalogV1beta1EntryGroup.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is GoogleCloudDatacatalogV1beta1EntryGroup {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === GoogleCloudDatacatalogV1beta1EntryGroup.__pulumiType;
    }


    /**
     * Create a GoogleCloudDatacatalogV1beta1EntryGroup resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: GoogleCloudDatacatalogV1beta1EntryGroupArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.parent === undefined) && !opts.urn) {
                throw new Error("Missing required property 'parent'");
            }
            inputs["dataCatalogTimestamps"] = args ? args.dataCatalogTimestamps : undefined;
            inputs["description"] = args ? args.description : undefined;
            inputs["displayName"] = args ? args.displayName : undefined;
            inputs["entryGroupId"] = args ? args.entryGroupId : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["parent"] = args ? args.parent : undefined;
        } else {
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(GoogleCloudDatacatalogV1beta1EntryGroup.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a GoogleCloudDatacatalogV1beta1EntryGroup resource.
 */
export interface GoogleCloudDatacatalogV1beta1EntryGroupArgs {
    /**
     * Output only. Timestamps about this EntryGroup. Default value is empty timestamps.
     */
    readonly dataCatalogTimestamps?: pulumi.Input<inputs.datacatalog.v1beta1.GoogleCloudDatacatalogV1beta1SystemTimestamps>;
    /**
     * Entry group description, which can consist of several sentences or paragraphs that describe entry group contents. Default value is an empty string.
     */
    readonly description?: pulumi.Input<string>;
    /**
     * A short name to identify the entry group, for example, "analytics data - jan 2011". Default value is an empty string.
     */
    readonly displayName?: pulumi.Input<string>;
    /**
     * Required. The id of the entry group to create. The id must begin with a letter or underscore, contain only English letters, numbers and underscores, and be at most 64 characters.
     */
    readonly entryGroupId?: pulumi.Input<string>;
    /**
     * The resource name of the entry group in URL format. Example: * projects/{project_id}/locations/{location}/entryGroups/{entry_group_id} Note that this EntryGroup and its child resources may not actually be stored in the location in this name.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * Required. The name of the project this entry group is in. Example: * projects/{project_id}/locations/{location} Note that this EntryGroup and its child resources may not actually be stored in the location in this name.
     */
    readonly parent: pulumi.Input<string>;
}