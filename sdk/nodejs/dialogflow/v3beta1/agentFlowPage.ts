// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

/**
 * Creates a page in the specified flow.
 */
export class AgentFlowPage extends pulumi.CustomResource {
    /**
     * Get an existing AgentFlowPage resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): AgentFlowPage {
        return new AgentFlowPage(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'google-cloud:dialogflow/v3beta1:AgentFlowPage';

    /**
     * Returns true if the given object is an instance of AgentFlowPage.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is AgentFlowPage {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === AgentFlowPage.__pulumiType;
    }

    /**
     * Required. The human-readable name of the page, unique within the agent.
     */
    public readonly displayName!: pulumi.Output<string>;
    /**
     * The fulfillment to call when the session is entering the page.
     */
    public readonly entryFulfillment!: pulumi.Output<outputs.dialogflow.v3beta1.GoogleCloudDialogflowCxV3beta1FulfillmentResponse>;
    /**
     * Handlers associated with the page to handle events such as webhook errors, no match or no input.
     */
    public readonly eventHandlers!: pulumi.Output<outputs.dialogflow.v3beta1.GoogleCloudDialogflowCxV3beta1EventHandlerResponse[]>;
    /**
     * The form associated with the page, used for collecting parameters relevant to the page.
     */
    public readonly form!: pulumi.Output<outputs.dialogflow.v3beta1.GoogleCloudDialogflowCxV3beta1FormResponse>;
    /**
     * The unique identifier of the page. Required for the Pages.UpdatePage method. Pages.CreatePage populates the name automatically. Format: `projects//locations//agents//flows//pages/`.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * Ordered list of `TransitionRouteGroups` associated with the page. Transition route groups must be unique within a page. * If multiple transition routes within a page scope refer to the same intent, then the precedence order is: page's transition route -> page's transition route group -> flow's transition routes. * If multiple transition route groups within a page contain the same intent, then the first group in the ordered list takes precedence. Format:`projects//locations//agents//flows//transitionRouteGroups/`.
     */
    public readonly transitionRouteGroups!: pulumi.Output<string[]>;
    /**
     * A list of transitions for the transition rules of this page. They route the conversation to another page in the same flow, or another flow. When we are in a certain page, the TransitionRoutes are evalauted in the following order: * TransitionRoutes defined in the page with intent specified. * TransitionRoutes defined in the transition route groups with intent specified. * TransitionRoutes defined in flow with intent specified. * TransitionRoutes defined in the transition route groups with intent specified. * TransitionRoutes defined in the page with only condition specified. * TransitionRoutes defined in the transition route groups with only condition specified.
     */
    public readonly transitionRoutes!: pulumi.Output<outputs.dialogflow.v3beta1.GoogleCloudDialogflowCxV3beta1TransitionRouteResponse[]>;

    /**
     * Create a AgentFlowPage resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: AgentFlowPageArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.agentsId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'agentsId'");
            }
            if ((!args || args.flowsId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'flowsId'");
            }
            if ((!args || args.locationsId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'locationsId'");
            }
            if ((!args || args.pagesId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'pagesId'");
            }
            if ((!args || args.projectsId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'projectsId'");
            }
            inputs["agentsId"] = args ? args.agentsId : undefined;
            inputs["displayName"] = args ? args.displayName : undefined;
            inputs["entryFulfillment"] = args ? args.entryFulfillment : undefined;
            inputs["eventHandlers"] = args ? args.eventHandlers : undefined;
            inputs["flowsId"] = args ? args.flowsId : undefined;
            inputs["form"] = args ? args.form : undefined;
            inputs["locationsId"] = args ? args.locationsId : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["pagesId"] = args ? args.pagesId : undefined;
            inputs["projectsId"] = args ? args.projectsId : undefined;
            inputs["transitionRouteGroups"] = args ? args.transitionRouteGroups : undefined;
            inputs["transitionRoutes"] = args ? args.transitionRoutes : undefined;
        } else {
            inputs["displayName"] = undefined /*out*/;
            inputs["entryFulfillment"] = undefined /*out*/;
            inputs["eventHandlers"] = undefined /*out*/;
            inputs["form"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["transitionRouteGroups"] = undefined /*out*/;
            inputs["transitionRoutes"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(AgentFlowPage.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a AgentFlowPage resource.
 */
export interface AgentFlowPageArgs {
    readonly agentsId: pulumi.Input<string>;
    /**
     * Required. The human-readable name of the page, unique within the agent.
     */
    readonly displayName?: pulumi.Input<string>;
    /**
     * The fulfillment to call when the session is entering the page.
     */
    readonly entryFulfillment?: pulumi.Input<inputs.dialogflow.v3beta1.GoogleCloudDialogflowCxV3beta1Fulfillment>;
    /**
     * Handlers associated with the page to handle events such as webhook errors, no match or no input.
     */
    readonly eventHandlers?: pulumi.Input<pulumi.Input<inputs.dialogflow.v3beta1.GoogleCloudDialogflowCxV3beta1EventHandler>[]>;
    readonly flowsId: pulumi.Input<string>;
    /**
     * The form associated with the page, used for collecting parameters relevant to the page.
     */
    readonly form?: pulumi.Input<inputs.dialogflow.v3beta1.GoogleCloudDialogflowCxV3beta1Form>;
    readonly locationsId: pulumi.Input<string>;
    /**
     * The unique identifier of the page. Required for the Pages.UpdatePage method. Pages.CreatePage populates the name automatically. Format: `projects//locations//agents//flows//pages/`.
     */
    readonly name?: pulumi.Input<string>;
    readonly pagesId: pulumi.Input<string>;
    readonly projectsId: pulumi.Input<string>;
    /**
     * Ordered list of `TransitionRouteGroups` associated with the page. Transition route groups must be unique within a page. * If multiple transition routes within a page scope refer to the same intent, then the precedence order is: page's transition route -> page's transition route group -> flow's transition routes. * If multiple transition route groups within a page contain the same intent, then the first group in the ordered list takes precedence. Format:`projects//locations//agents//flows//transitionRouteGroups/`.
     */
    readonly transitionRouteGroups?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * A list of transitions for the transition rules of this page. They route the conversation to another page in the same flow, or another flow. When we are in a certain page, the TransitionRoutes are evalauted in the following order: * TransitionRoutes defined in the page with intent specified. * TransitionRoutes defined in the transition route groups with intent specified. * TransitionRoutes defined in flow with intent specified. * TransitionRoutes defined in the transition route groups with intent specified. * TransitionRoutes defined in the page with only condition specified. * TransitionRoutes defined in the transition route groups with only condition specified.
     */
    readonly transitionRoutes?: pulumi.Input<pulumi.Input<inputs.dialogflow.v3beta1.GoogleCloudDialogflowCxV3beta1TransitionRoute>[]>;
}