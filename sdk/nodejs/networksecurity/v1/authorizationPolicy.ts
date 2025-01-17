// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Creates a new AuthorizationPolicy in a given project and location.
 */
export class AuthorizationPolicy extends pulumi.CustomResource {
    /**
     * Get an existing AuthorizationPolicy resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): AuthorizationPolicy {
        return new AuthorizationPolicy(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'google-native:networksecurity/v1:AuthorizationPolicy';

    /**
     * Returns true if the given object is an instance of AuthorizationPolicy.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is AuthorizationPolicy {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === AuthorizationPolicy.__pulumiType;
    }

    /**
     * The action to take when a rule match is found. Possible values are "ALLOW" or "DENY".
     */
    public readonly action!: pulumi.Output<string>;
    /**
     * Required. Short name of the AuthorizationPolicy resource to be created. This value should be 1-63 characters long, containing only letters, numbers, hyphens, and underscores, and should not start with a number. E.g. "authz_policy".
     */
    public readonly authorizationPolicyId!: pulumi.Output<string>;
    /**
     * The timestamp when the resource was created.
     */
    public /*out*/ readonly createTime!: pulumi.Output<string>;
    /**
     * Optional. Free-text description of the resource.
     */
    public readonly description!: pulumi.Output<string>;
    /**
     * Optional. Set of label tags associated with the AuthorizationPolicy resource.
     */
    public readonly labels!: pulumi.Output<{[key: string]: string}>;
    public readonly location!: pulumi.Output<string>;
    /**
     * Name of the AuthorizationPolicy resource. It matches pattern `projects/{project}/locations/{location}/authorizationPolicies/`.
     */
    public readonly name!: pulumi.Output<string>;
    public readonly project!: pulumi.Output<string>;
    /**
     * Optional. List of rules to match. Note that at least one of the rules must match in order for the action specified in the 'action' field to be taken. A rule is a match if there is a matching source and destination. If left blank, the action specified in the `action` field will be applied on every request.
     */
    public readonly rules!: pulumi.Output<outputs.networksecurity.v1.RuleResponse[]>;
    /**
     * The timestamp when the resource was updated.
     */
    public /*out*/ readonly updateTime!: pulumi.Output<string>;

    /**
     * Create a AuthorizationPolicy resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: AuthorizationPolicyArgs, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.action === undefined) && !opts.urn) {
                throw new Error("Missing required property 'action'");
            }
            if ((!args || args.authorizationPolicyId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'authorizationPolicyId'");
            }
            resourceInputs["action"] = args ? args.action : undefined;
            resourceInputs["authorizationPolicyId"] = args ? args.authorizationPolicyId : undefined;
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["labels"] = args ? args.labels : undefined;
            resourceInputs["location"] = args ? args.location : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["project"] = args ? args.project : undefined;
            resourceInputs["rules"] = args ? args.rules : undefined;
            resourceInputs["createTime"] = undefined /*out*/;
            resourceInputs["updateTime"] = undefined /*out*/;
        } else {
            resourceInputs["action"] = undefined /*out*/;
            resourceInputs["authorizationPolicyId"] = undefined /*out*/;
            resourceInputs["createTime"] = undefined /*out*/;
            resourceInputs["description"] = undefined /*out*/;
            resourceInputs["labels"] = undefined /*out*/;
            resourceInputs["location"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["project"] = undefined /*out*/;
            resourceInputs["rules"] = undefined /*out*/;
            resourceInputs["updateTime"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(AuthorizationPolicy.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * The set of arguments for constructing a AuthorizationPolicy resource.
 */
export interface AuthorizationPolicyArgs {
    /**
     * The action to take when a rule match is found. Possible values are "ALLOW" or "DENY".
     */
    action: pulumi.Input<enums.networksecurity.v1.AuthorizationPolicyAction>;
    /**
     * Required. Short name of the AuthorizationPolicy resource to be created. This value should be 1-63 characters long, containing only letters, numbers, hyphens, and underscores, and should not start with a number. E.g. "authz_policy".
     */
    authorizationPolicyId: pulumi.Input<string>;
    /**
     * Optional. Free-text description of the resource.
     */
    description?: pulumi.Input<string>;
    /**
     * Optional. Set of label tags associated with the AuthorizationPolicy resource.
     */
    labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    location?: pulumi.Input<string>;
    /**
     * Name of the AuthorizationPolicy resource. It matches pattern `projects/{project}/locations/{location}/authorizationPolicies/`.
     */
    name?: pulumi.Input<string>;
    project?: pulumi.Input<string>;
    /**
     * Optional. List of rules to match. Note that at least one of the rules must match in order for the action specified in the 'action' field to be taken. A rule is a match if there is a matching source and destination. If left blank, the action specified in the `action` field will be applied on every request.
     */
    rules?: pulumi.Input<pulumi.Input<inputs.networksecurity.v1.RuleArgs>[]>;
}
