// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

/**
 * Creates a catalog item.
 */
export class GoogleCloudRecommendationengineV1beta1CatalogItem extends pulumi.CustomResource {
    /**
     * Get an existing GoogleCloudRecommendationengineV1beta1CatalogItem resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): GoogleCloudRecommendationengineV1beta1CatalogItem {
        return new GoogleCloudRecommendationengineV1beta1CatalogItem(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'google-cloud:recommendationengine/v1beta1:GoogleCloudRecommendationengineV1beta1CatalogItem';

    /**
     * Returns true if the given object is an instance of GoogleCloudRecommendationengineV1beta1CatalogItem.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is GoogleCloudRecommendationengineV1beta1CatalogItem {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === GoogleCloudRecommendationengineV1beta1CatalogItem.__pulumiType;
    }


    /**
     * Create a GoogleCloudRecommendationengineV1beta1CatalogItem resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: GoogleCloudRecommendationengineV1beta1CatalogItemArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.parent === undefined) && !opts.urn) {
                throw new Error("Missing required property 'parent'");
            }
            inputs["categoryHierarchies"] = args ? args.categoryHierarchies : undefined;
            inputs["description"] = args ? args.description : undefined;
            inputs["id"] = args ? args.id : undefined;
            inputs["itemAttributes"] = args ? args.itemAttributes : undefined;
            inputs["itemGroupId"] = args ? args.itemGroupId : undefined;
            inputs["languageCode"] = args ? args.languageCode : undefined;
            inputs["parent"] = args ? args.parent : undefined;
            inputs["productMetadata"] = args ? args.productMetadata : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["title"] = args ? args.title : undefined;
        } else {
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(GoogleCloudRecommendationengineV1beta1CatalogItem.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a GoogleCloudRecommendationengineV1beta1CatalogItem resource.
 */
export interface GoogleCloudRecommendationengineV1beta1CatalogItemArgs {
    /**
     * Required. Catalog item categories. This field is repeated for supporting one catalog item belonging to several parallel category hierarchies. For example, if a shoes product belongs to both ["Shoes & Accessories" -> "Shoes"] and ["Sports & Fitness" -> "Athletic Clothing" -> "Shoes"], it could be represented as: "categoryHierarchies": [ { "categories": ["Shoes & Accessories", "Shoes"]}, { "categories": ["Sports & Fitness", "Athletic Clothing", "Shoes"] } ]
     */
    readonly categoryHierarchies?: pulumi.Input<pulumi.Input<inputs.recommendationengine.v1beta1.GoogleCloudRecommendationengineV1beta1CatalogItemCategoryHierarchy>[]>;
    /**
     * Optional. Catalog item description. UTF-8 encoded string with a length limit of 5 KiB.
     */
    readonly description?: pulumi.Input<string>;
    /**
     * Required. Catalog item identifier. UTF-8 encoded string with a length limit of 128 bytes. This id must be unique among all catalog items within the same catalog. It should also be used when logging user events in order for the user events to be joined with the Catalog.
     */
    readonly id?: pulumi.Input<string>;
    /**
     * Optional. Highly encouraged. Extra catalog item attributes to be included in the recommendation model. For example, for retail products, this could include the store name, vendor, style, color, etc. These are very strong signals for recommendation model, thus we highly recommend providing the item attributes here.
     */
    readonly itemAttributes?: pulumi.Input<inputs.recommendationengine.v1beta1.GoogleCloudRecommendationengineV1beta1FeatureMap>;
    /**
     * Optional. Variant group identifier for prediction results. UTF-8 encoded string with a length limit of 128 bytes. This field must be enabled before it can be used. [Learn more](/recommendations-ai/docs/catalog#item-group-id).
     */
    readonly itemGroupId?: pulumi.Input<string>;
    /**
     * Optional. Deprecated. The model automatically detects the text language. Your catalog can include text in different languages, but duplicating catalog items to provide text in multiple languages can result in degraded model performance.
     */
    readonly languageCode?: pulumi.Input<string>;
    /**
     * Required. The parent catalog resource name, such as "projects/*&#47;locations/global/catalogs/default_catalog".
     */
    readonly parent: pulumi.Input<string>;
    /**
     * Optional. Metadata specific to retail products.
     */
    readonly productMetadata?: pulumi.Input<inputs.recommendationengine.v1beta1.GoogleCloudRecommendationengineV1beta1ProductCatalogItem>;
    /**
     * Optional. Filtering tags associated with the catalog item. Each tag should be a UTF-8 encoded string with a length limit of 1 KiB. This tag can be used for filtering recommendation results by passing the tag as part of the predict request filter.
     */
    readonly tags?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Required. Catalog item title. UTF-8 encoded string with a length limit of 1 KiB.
     */
    readonly title?: pulumi.Input<string>;
}