// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Creates a new conversation. Conversations are auto-completed after 24 hours. Conversation Lifecycle: There are two stages during a conversation: Automated Agent Stage and Assist Stage. For Automated Agent Stage, there will be a dialogflow agent responding to user queries. For Assist Stage, there's no dialogflow agent responding to user queries. But we will provide suggestions which are generated from conversation. If Conversation.conversation_profile is configured for a dialogflow agent, conversation will start from `Automated Agent Stage`, otherwise, it will start from `Assist Stage`. And during `Automated Agent Stage`, once an Intent with Intent.live_agent_handoff is triggered, conversation will transfer to Assist Stage.
 * Auto-naming is currently not supported for this resource.
 * Note - this resource's API doesn't support deletion. When deleted, the resource will persist
 * on Google Cloud even though it will be deleted from Pulumi state.
 */
export class Conversation extends pulumi.CustomResource {
    /**
     * Get an existing Conversation resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Conversation {
        return new Conversation(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'google-native:dialogflow/v2beta1:Conversation';

    /**
     * Returns true if the given object is an instance of Conversation.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Conversation {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Conversation.__pulumiType;
    }

    /**
     * Optional. Identifier of the conversation. Generally it's auto generated by Google. Only set it if you cannot wait for the response to return a auto-generated one to you. The conversation ID must be compliant with the regression fomula "a-zA-Z*" with the characters length in range of [3,64]. If the field is provided, the caller is resposible for 1. the uniqueness of the ID, otherwise the request will be rejected. 2. the consistency for whether to use custom ID or not under a project to better ensure uniqueness.
     */
    public readonly conversationId!: pulumi.Output<string | undefined>;
    /**
     * The Conversation Profile to be used to configure this Conversation. This field cannot be updated. Format: `projects//locations//conversationProfiles/`.
     */
    public readonly conversationProfile!: pulumi.Output<string>;
    /**
     * The stage of a conversation. It indicates whether the virtual agent or a human agent is handling the conversation. If the conversation is created with the conversation profile that has Dialogflow config set, defaults to ConversationStage.VIRTUAL_AGENT_STAGE; Otherwise, defaults to ConversationStage.HUMAN_ASSIST_STAGE. If the conversation is created with the conversation profile that has Dialogflow config set but explicitly sets conversation_stage to ConversationStage.HUMAN_ASSIST_STAGE, it skips ConversationStage.VIRTUAL_AGENT_STAGE stage and directly goes to ConversationStage.HUMAN_ASSIST_STAGE.
     */
    public readonly conversationStage!: pulumi.Output<string>;
    /**
     * The time the conversation was finished.
     */
    public /*out*/ readonly endTime!: pulumi.Output<string>;
    /**
     * The current state of the Conversation.
     */
    public /*out*/ readonly lifecycleState!: pulumi.Output<string>;
    public readonly location!: pulumi.Output<string>;
    /**
     * The unique identifier of this conversation. Format: `projects//locations//conversations/`.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * Required if the conversation is to be connected over telephony.
     */
    public /*out*/ readonly phoneNumber!: pulumi.Output<outputs.dialogflow.v2beta1.GoogleCloudDialogflowV2beta1ConversationPhoneNumberResponse>;
    public readonly project!: pulumi.Output<string>;
    /**
     * The time the conversation was started.
     */
    public /*out*/ readonly startTime!: pulumi.Output<string>;

    /**
     * Create a Conversation resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ConversationArgs, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.conversationProfile === undefined) && !opts.urn) {
                throw new Error("Missing required property 'conversationProfile'");
            }
            resourceInputs["conversationId"] = args ? args.conversationId : undefined;
            resourceInputs["conversationProfile"] = args ? args.conversationProfile : undefined;
            resourceInputs["conversationStage"] = args ? args.conversationStage : undefined;
            resourceInputs["location"] = args ? args.location : undefined;
            resourceInputs["project"] = args ? args.project : undefined;
            resourceInputs["endTime"] = undefined /*out*/;
            resourceInputs["lifecycleState"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["phoneNumber"] = undefined /*out*/;
            resourceInputs["startTime"] = undefined /*out*/;
        } else {
            resourceInputs["conversationId"] = undefined /*out*/;
            resourceInputs["conversationProfile"] = undefined /*out*/;
            resourceInputs["conversationStage"] = undefined /*out*/;
            resourceInputs["endTime"] = undefined /*out*/;
            resourceInputs["lifecycleState"] = undefined /*out*/;
            resourceInputs["location"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["phoneNumber"] = undefined /*out*/;
            resourceInputs["project"] = undefined /*out*/;
            resourceInputs["startTime"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(Conversation.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * The set of arguments for constructing a Conversation resource.
 */
export interface ConversationArgs {
    /**
     * Optional. Identifier of the conversation. Generally it's auto generated by Google. Only set it if you cannot wait for the response to return a auto-generated one to you. The conversation ID must be compliant with the regression fomula "a-zA-Z*" with the characters length in range of [3,64]. If the field is provided, the caller is resposible for 1. the uniqueness of the ID, otherwise the request will be rejected. 2. the consistency for whether to use custom ID or not under a project to better ensure uniqueness.
     */
    conversationId?: pulumi.Input<string>;
    /**
     * The Conversation Profile to be used to configure this Conversation. This field cannot be updated. Format: `projects//locations//conversationProfiles/`.
     */
    conversationProfile: pulumi.Input<string>;
    /**
     * The stage of a conversation. It indicates whether the virtual agent or a human agent is handling the conversation. If the conversation is created with the conversation profile that has Dialogflow config set, defaults to ConversationStage.VIRTUAL_AGENT_STAGE; Otherwise, defaults to ConversationStage.HUMAN_ASSIST_STAGE. If the conversation is created with the conversation profile that has Dialogflow config set but explicitly sets conversation_stage to ConversationStage.HUMAN_ASSIST_STAGE, it skips ConversationStage.VIRTUAL_AGENT_STAGE stage and directly goes to ConversationStage.HUMAN_ASSIST_STAGE.
     */
    conversationStage?: pulumi.Input<enums.dialogflow.v2beta1.ConversationConversationStage>;
    location?: pulumi.Input<string>;
    project?: pulumi.Input<string>;
}
