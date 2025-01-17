// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Creates evaluation of a conversation model.
 * Note - this resource's API doesn't support deletion. When deleted, the resource will persist
 * on Google Cloud even though it will be deleted from Pulumi state.
 */
export class Evaluation extends pulumi.CustomResource {
    /**
     * Get an existing Evaluation resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Evaluation {
        return new Evaluation(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'google-native:dialogflow/v2:Evaluation';

    /**
     * Returns true if the given object is an instance of Evaluation.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Evaluation {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Evaluation.__pulumiType;
    }

    public readonly conversationModelId!: pulumi.Output<string>;
    /**
     * Creation time of this model.
     */
    public /*out*/ readonly createTime!: pulumi.Output<string>;
    /**
     * Optional. The display name of the model evaluation. At most 64 bytes long.
     */
    public readonly displayName!: pulumi.Output<string>;
    /**
     * Optional. The configuration of the evaluation task.
     */
    public readonly evaluationConfig!: pulumi.Output<outputs.dialogflow.v2.GoogleCloudDialogflowV2EvaluationConfigResponse>;
    public readonly location!: pulumi.Output<string>;
    /**
     * The resource name of the evaluation. Format: `projects//conversationModels//evaluations/`
     */
    public readonly name!: pulumi.Output<string>;
    public readonly project!: pulumi.Output<string>;
    /**
     * Only available when model is for smart reply.
     */
    public /*out*/ readonly smartReplyMetrics!: pulumi.Output<outputs.dialogflow.v2.GoogleCloudDialogflowV2SmartReplyMetricsResponse>;

    /**
     * Create a Evaluation resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: EvaluationArgs, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.conversationModelId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'conversationModelId'");
            }
            resourceInputs["conversationModelId"] = args ? args.conversationModelId : undefined;
            resourceInputs["displayName"] = args ? args.displayName : undefined;
            resourceInputs["evaluationConfig"] = args ? args.evaluationConfig : undefined;
            resourceInputs["location"] = args ? args.location : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["project"] = args ? args.project : undefined;
            resourceInputs["createTime"] = undefined /*out*/;
            resourceInputs["smartReplyMetrics"] = undefined /*out*/;
        } else {
            resourceInputs["conversationModelId"] = undefined /*out*/;
            resourceInputs["createTime"] = undefined /*out*/;
            resourceInputs["displayName"] = undefined /*out*/;
            resourceInputs["evaluationConfig"] = undefined /*out*/;
            resourceInputs["location"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["project"] = undefined /*out*/;
            resourceInputs["smartReplyMetrics"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(Evaluation.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * The set of arguments for constructing a Evaluation resource.
 */
export interface EvaluationArgs {
    conversationModelId: pulumi.Input<string>;
    /**
     * Optional. The display name of the model evaluation. At most 64 bytes long.
     */
    displayName?: pulumi.Input<string>;
    /**
     * Optional. The configuration of the evaluation task.
     */
    evaluationConfig?: pulumi.Input<inputs.dialogflow.v2.GoogleCloudDialogflowV2EvaluationConfigArgs>;
    location?: pulumi.Input<string>;
    /**
     * The resource name of the evaluation. Format: `projects//conversationModels//evaluations/`
     */
    name?: pulumi.Input<string>;
    project?: pulumi.Input<string>;
}
