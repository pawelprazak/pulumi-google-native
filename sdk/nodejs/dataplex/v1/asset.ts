// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Creates an asset resource.
 * Auto-naming is currently not supported for this resource.
 */
export class Asset extends pulumi.CustomResource {
    /**
     * Get an existing Asset resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Asset {
        return new Asset(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'google-native:dataplex/v1:Asset';

    /**
     * Returns true if the given object is an instance of Asset.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Asset {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Asset.__pulumiType;
    }

    /**
     * Required. Asset identifier. This ID will be used to generate names such as table names when publishing metadata to Hive Metastore and BigQuery. * Must contain only lowercase letters, numbers and hyphens. * Must start with a letter. * Must end with a number or a letter. * Must be between 1-63 characters. * Must be unique within the zone.
     */
    public readonly assetId!: pulumi.Output<string>;
    /**
     * The time when the asset was created.
     */
    public /*out*/ readonly createTime!: pulumi.Output<string>;
    /**
     * Optional. Description of the asset.
     */
    public readonly description!: pulumi.Output<string>;
    /**
     * Optional. Specification of the discovery feature applied to data referenced by this asset. When this spec is left unset, the asset will use the spec set on the parent zone.
     */
    public readonly discoverySpec!: pulumi.Output<outputs.dataplex.v1.GoogleCloudDataplexV1AssetDiscoverySpecResponse>;
    /**
     * Status of the discovery feature applied to data referenced by this asset.
     */
    public /*out*/ readonly discoveryStatus!: pulumi.Output<outputs.dataplex.v1.GoogleCloudDataplexV1AssetDiscoveryStatusResponse>;
    /**
     * Optional. User friendly display name.
     */
    public readonly displayName!: pulumi.Output<string>;
    /**
     * Optional. User defined labels for the asset.
     */
    public readonly labels!: pulumi.Output<{[key: string]: string}>;
    public readonly lakeId!: pulumi.Output<string>;
    public readonly location!: pulumi.Output<string>;
    /**
     * The relative resource name of the asset, of the form: projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/assets/{asset_id}.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    public readonly project!: pulumi.Output<string>;
    /**
     * Specification of the resource that is referenced by this asset.
     */
    public readonly resourceSpec!: pulumi.Output<outputs.dataplex.v1.GoogleCloudDataplexV1AssetResourceSpecResponse>;
    /**
     * Status of the resource referenced by this asset.
     */
    public /*out*/ readonly resourceStatus!: pulumi.Output<outputs.dataplex.v1.GoogleCloudDataplexV1AssetResourceStatusResponse>;
    /**
     * Status of the security policy applied to resource referenced by this asset.
     */
    public /*out*/ readonly securityStatus!: pulumi.Output<outputs.dataplex.v1.GoogleCloudDataplexV1AssetSecurityStatusResponse>;
    /**
     * Current state of the asset.
     */
    public /*out*/ readonly state!: pulumi.Output<string>;
    /**
     * System generated globally unique ID for the asset. This ID will be different if the asset is deleted and re-created with the same name.
     */
    public /*out*/ readonly uid!: pulumi.Output<string>;
    /**
     * The time when the asset was last updated.
     */
    public /*out*/ readonly updateTime!: pulumi.Output<string>;
    /**
     * Optional. Only validate the request, but do not perform mutations. The default is false.
     */
    public readonly validateOnly!: pulumi.Output<string | undefined>;
    public readonly zone!: pulumi.Output<string>;

    /**
     * Create a Asset resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: AssetArgs, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.assetId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'assetId'");
            }
            if ((!args || args.lakeId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'lakeId'");
            }
            if ((!args || args.resourceSpec === undefined) && !opts.urn) {
                throw new Error("Missing required property 'resourceSpec'");
            }
            resourceInputs["assetId"] = args ? args.assetId : undefined;
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["discoverySpec"] = args ? args.discoverySpec : undefined;
            resourceInputs["displayName"] = args ? args.displayName : undefined;
            resourceInputs["labels"] = args ? args.labels : undefined;
            resourceInputs["lakeId"] = args ? args.lakeId : undefined;
            resourceInputs["location"] = args ? args.location : undefined;
            resourceInputs["project"] = args ? args.project : undefined;
            resourceInputs["resourceSpec"] = args ? args.resourceSpec : undefined;
            resourceInputs["validateOnly"] = args ? args.validateOnly : undefined;
            resourceInputs["zone"] = args ? args.zone : undefined;
            resourceInputs["createTime"] = undefined /*out*/;
            resourceInputs["discoveryStatus"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["resourceStatus"] = undefined /*out*/;
            resourceInputs["securityStatus"] = undefined /*out*/;
            resourceInputs["state"] = undefined /*out*/;
            resourceInputs["uid"] = undefined /*out*/;
            resourceInputs["updateTime"] = undefined /*out*/;
        } else {
            resourceInputs["assetId"] = undefined /*out*/;
            resourceInputs["createTime"] = undefined /*out*/;
            resourceInputs["description"] = undefined /*out*/;
            resourceInputs["discoverySpec"] = undefined /*out*/;
            resourceInputs["discoveryStatus"] = undefined /*out*/;
            resourceInputs["displayName"] = undefined /*out*/;
            resourceInputs["labels"] = undefined /*out*/;
            resourceInputs["lakeId"] = undefined /*out*/;
            resourceInputs["location"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["project"] = undefined /*out*/;
            resourceInputs["resourceSpec"] = undefined /*out*/;
            resourceInputs["resourceStatus"] = undefined /*out*/;
            resourceInputs["securityStatus"] = undefined /*out*/;
            resourceInputs["state"] = undefined /*out*/;
            resourceInputs["uid"] = undefined /*out*/;
            resourceInputs["updateTime"] = undefined /*out*/;
            resourceInputs["validateOnly"] = undefined /*out*/;
            resourceInputs["zone"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(Asset.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * The set of arguments for constructing a Asset resource.
 */
export interface AssetArgs {
    /**
     * Required. Asset identifier. This ID will be used to generate names such as table names when publishing metadata to Hive Metastore and BigQuery. * Must contain only lowercase letters, numbers and hyphens. * Must start with a letter. * Must end with a number or a letter. * Must be between 1-63 characters. * Must be unique within the zone.
     */
    assetId: pulumi.Input<string>;
    /**
     * Optional. Description of the asset.
     */
    description?: pulumi.Input<string>;
    /**
     * Optional. Specification of the discovery feature applied to data referenced by this asset. When this spec is left unset, the asset will use the spec set on the parent zone.
     */
    discoverySpec?: pulumi.Input<inputs.dataplex.v1.GoogleCloudDataplexV1AssetDiscoverySpecArgs>;
    /**
     * Optional. User friendly display name.
     */
    displayName?: pulumi.Input<string>;
    /**
     * Optional. User defined labels for the asset.
     */
    labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    lakeId: pulumi.Input<string>;
    location?: pulumi.Input<string>;
    project?: pulumi.Input<string>;
    /**
     * Specification of the resource that is referenced by this asset.
     */
    resourceSpec: pulumi.Input<inputs.dataplex.v1.GoogleCloudDataplexV1AssetResourceSpecArgs>;
    /**
     * Optional. Only validate the request, but do not perform mutations. The default is false.
     */
    validateOnly?: pulumi.Input<string>;
    zone?: pulumi.Input<string>;
}
