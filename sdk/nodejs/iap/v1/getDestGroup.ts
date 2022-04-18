// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

/**
 * Retrieves an existing TunnelDestGroup.
 */
export function getDestGroup(args: GetDestGroupArgs, opts?: pulumi.InvokeOptions): Promise<GetDestGroupResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("google-native:iap/v1:getDestGroup", {
        "destGroupId": args.destGroupId,
        "location": args.location,
        "project": args.project,
    }, opts);
}

export interface GetDestGroupArgs {
    destGroupId: string;
    location: string;
    project?: string;
}

export interface GetDestGroupResult {
    /**
     * null List of CIDRs that this group applies to.
     */
    readonly cidrs: string[];
    /**
     * null List of FQDNs that this group applies to.
     */
    readonly fqdns: string[];
    /**
     * Immutable. Identifier for the TunnelDestGroup. Must be unique within the project.
     */
    readonly name: string;
}

export function getDestGroupOutput(args: GetDestGroupOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetDestGroupResult> {
    return pulumi.output(args).apply(a => getDestGroup(a, opts))
}

export interface GetDestGroupOutputArgs {
    destGroupId: pulumi.Input<string>;
    location: pulumi.Input<string>;
    project?: pulumi.Input<string>;
}