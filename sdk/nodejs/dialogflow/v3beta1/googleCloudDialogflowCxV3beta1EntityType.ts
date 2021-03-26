// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

/**
 * Creates an entity type in the specified agent.
 */
export class GoogleCloudDialogflowCxV3beta1EntityType extends pulumi.CustomResource {
    /**
     * Get an existing GoogleCloudDialogflowCxV3beta1EntityType resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): GoogleCloudDialogflowCxV3beta1EntityType {
        return new GoogleCloudDialogflowCxV3beta1EntityType(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'google-cloud:dialogflow/v3beta1:GoogleCloudDialogflowCxV3beta1EntityType';

    /**
     * Returns true if the given object is an instance of GoogleCloudDialogflowCxV3beta1EntityType.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is GoogleCloudDialogflowCxV3beta1EntityType {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === GoogleCloudDialogflowCxV3beta1EntityType.__pulumiType;
    }


    /**
     * Create a GoogleCloudDialogflowCxV3beta1EntityType resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: GoogleCloudDialogflowCxV3beta1EntityTypeArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.parent === undefined) && !opts.urn) {
                throw new Error("Missing required property 'parent'");
            }
            inputs["autoExpansionMode"] = args ? args.autoExpansionMode : undefined;
            inputs["displayName"] = args ? args.displayName : undefined;
            inputs["enableFuzzyExtraction"] = args ? args.enableFuzzyExtraction : undefined;
            inputs["entities"] = args ? args.entities : undefined;
            inputs["excludedPhrases"] = args ? args.excludedPhrases : undefined;
            inputs["kind"] = args ? args.kind : undefined;
            inputs["languageCode"] = args ? args.languageCode : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["parent"] = args ? args.parent : undefined;
            inputs["redact"] = args ? args.redact : undefined;
        } else {
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(GoogleCloudDialogflowCxV3beta1EntityType.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a GoogleCloudDialogflowCxV3beta1EntityType resource.
 */
export interface GoogleCloudDialogflowCxV3beta1EntityTypeArgs {
    /**
     * Indicates whether the entity type can be automatically expanded.
     */
    readonly autoExpansionMode?: pulumi.Input<string>;
    /**
     * Required. The human-readable name of the entity type, unique within the agent.
     */
    readonly displayName?: pulumi.Input<string>;
    /**
     * Enables fuzzy entity extraction during classification.
     */
    readonly enableFuzzyExtraction?: pulumi.Input<boolean>;
    /**
     * The collection of entity entries associated with the entity type.
     */
    readonly entities?: pulumi.Input<pulumi.Input<inputs.dialogflow.v3beta1.GoogleCloudDialogflowCxV3beta1EntityTypeEntity>[]>;
    /**
     * Collection of exceptional words and phrases that shouldn't be matched. For example, if you have a size entity type with entry `giant`(an adjective), you might consider adding `giants`(a noun) as an exclusion. If the kind of entity type is `KIND_MAP`, then the phrases specified by entities and excluded phrases should be mutually exclusive.
     */
    readonly excludedPhrases?: pulumi.Input<pulumi.Input<inputs.dialogflow.v3beta1.GoogleCloudDialogflowCxV3beta1EntityTypeExcludedPhrase>[]>;
    /**
     * Required. Indicates the kind of entity type.
     */
    readonly kind?: pulumi.Input<string>;
    /**
     * The language of the following fields in `entity_type`: * `EntityType.entities.value` * `EntityType.entities.synonyms` * `EntityType.excluded_phrases.value` If not specified, the agent's default language is used. [Many languages](https://cloud.google.com/dialogflow/cx/docs/reference/language) are supported. Note: languages must be enabled in the agent before they can be used.
     */
    readonly languageCode?: pulumi.Input<string>;
    /**
     * The unique identifier of the entity type. Required for EntityTypes.UpdateEntityType. Format: `projects//locations//agents//entityTypes/`.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * Required. The agent to create a entity type for. Format: `projects//locations//agents/`.
     */
    readonly parent: pulumi.Input<string>;
    /**
     * Indicates whether parameters of the entity type should be redacted in log. If redaction is enabled, page parameters and intent parameters referring to the entity type will be replaced by parameter name during logging.
     */
    readonly redact?: pulumi.Input<boolean>;
}