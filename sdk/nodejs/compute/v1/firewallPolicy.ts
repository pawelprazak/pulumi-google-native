// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

/**
 * Creates a new policy in the specified project using the data included in the request.
 */
export class FirewallPolicy extends pulumi.CustomResource {
    /**
     * Get an existing FirewallPolicy resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): FirewallPolicy {
        return new FirewallPolicy(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'google-cloud:compute/v1:FirewallPolicy';

    /**
     * Returns true if the given object is an instance of FirewallPolicy.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is FirewallPolicy {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === FirewallPolicy.__pulumiType;
    }


    /**
     * Create a FirewallPolicy resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: FirewallPolicyArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            inputs["associations"] = args ? args.associations : undefined;
            inputs["creationTimestamp"] = args ? args.creationTimestamp : undefined;
            inputs["description"] = args ? args.description : undefined;
            inputs["displayName"] = args ? args.displayName : undefined;
            inputs["fingerprint"] = args ? args.fingerprint : undefined;
            inputs["id"] = args ? args.id : undefined;
            inputs["kind"] = args ? args.kind : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["parent"] = args ? args.parent : undefined;
            inputs["parentId"] = args ? args.parentId : undefined;
            inputs["requestId"] = args ? args.requestId : undefined;
            inputs["ruleTupleCount"] = args ? args.ruleTupleCount : undefined;
            inputs["rules"] = args ? args.rules : undefined;
            inputs["selfLink"] = args ? args.selfLink : undefined;
            inputs["selfLinkWithId"] = args ? args.selfLinkWithId : undefined;
            inputs["shortName"] = args ? args.shortName : undefined;
        } else {
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(FirewallPolicy.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a FirewallPolicy resource.
 */
export interface FirewallPolicyArgs {
    /**
     * A list of associations that belong to this firewall policy.
     */
    readonly associations?: pulumi.Input<pulumi.Input<inputs.compute.v1.FirewallPolicyAssociation>[]>;
    /**
     * [Output Only] Creation timestamp in RFC3339 text format.
     */
    readonly creationTimestamp?: pulumi.Input<string>;
    /**
     * An optional description of this resource. Provide this property when you create the resource.
     */
    readonly description?: pulumi.Input<string>;
    /**
     * Depreacted, please use short name instead. User-provided name of the Organization firewall plicy. The name should be unique in the organization in which the firewall policy is created. The name must be 1-63 characters long, and comply with RFC1035. Specifically, the name must be 1-63 characters long and match the regular expression `[a-z]([-a-z0-9]*[a-z0-9])?` which means the first character must be a lowercase letter, and all following characters must be a dash, lowercase letter, or digit, except the last character, which cannot be a dash.
     */
    readonly displayName?: pulumi.Input<string>;
    /**
     * Specifies a fingerprint for this resource, which is essentially a hash of the metadata's contents and used for optimistic locking. The fingerprint is initially generated by Compute Engine and changes after every request to modify or update metadata. You must always provide an up-to-date fingerprint hash in order to update or change metadata, otherwise the request will fail with error 412 conditionNotMet.
     *
     * To see the latest fingerprint, make get() request to the firewall policy.
     */
    readonly fingerprint?: pulumi.Input<string>;
    /**
     * [Output Only] The unique identifier for the resource. This identifier is defined by the server.
     */
    readonly id?: pulumi.Input<string>;
    /**
     * [Output only] Type of the resource. Always compute#firewallPolicyfor firewall policies
     */
    readonly kind?: pulumi.Input<string>;
    /**
     * [Output Only] Name of the resource. It is a numeric ID allocated by GCP which uniquely identifies the Firewall Policy.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * [Output Only] The parent of the firewall policy.
     */
    readonly parent?: pulumi.Input<string>;
    /**
     * Parent ID for this request. The ID can be either be "folders/[FOLDER_ID]" if the parent is a folder or "organizations/[ORGANIZATION_ID]" if the parent is an organization.
     */
    readonly parentId?: pulumi.Input<string>;
    /**
     * An optional request ID to identify requests. Specify a unique request ID so that if you must retry your request, the server will know to ignore the request if it has already been completed.
     *
     * For example, consider a situation where you make an initial request and the request times out. If you make the request again with the same request ID, the server can check if original operation with the same request ID was received, and if so, will ignore the second request. This prevents clients from accidentally creating duplicate commitments.
     *
     * The request ID must be a valid UUID with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
     */
    readonly requestId?: pulumi.Input<string>;
    /**
     * [Output Only] Total count of all firewall policy rule tuples. A firewall policy can not exceed a set number of tuples.
     */
    readonly ruleTupleCount?: pulumi.Input<number>;
    /**
     * A list of rules that belong to this policy. There must always be a default rule (rule with priority 2147483647 and match "*"). If no rules are provided when creating a firewall policy, a default rule with action "allow" will be added.
     */
    readonly rules?: pulumi.Input<pulumi.Input<inputs.compute.v1.FirewallPolicyRule>[]>;
    /**
     * [Output Only] Server-defined URL for the resource.
     */
    readonly selfLink?: pulumi.Input<string>;
    /**
     * [Output Only] Server-defined URL for this resource with the resource id.
     */
    readonly selfLinkWithId?: pulumi.Input<string>;
    /**
     * User-provided name of the Organization firewall plicy. The name should be unique in the organization in which the firewall policy is created. The name must be 1-63 characters long, and comply with RFC1035. Specifically, the name must be 1-63 characters long and match the regular expression `[a-z]([-a-z0-9]*[a-z0-9])?` which means the first character must be a lowercase letter, and all following characters must be a dash, lowercase letter, or digit, except the last character, which cannot be a dash.
     */
    readonly shortName?: pulumi.Input<string>;
}