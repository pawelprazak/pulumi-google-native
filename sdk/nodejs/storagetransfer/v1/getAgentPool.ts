// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Gets an agent pool.
 */
export function getAgentPool(args: GetAgentPoolArgs, opts?: pulumi.InvokeOptions): Promise<GetAgentPoolResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("google-native:storagetransfer/v1:getAgentPool", {
        "agentPoolId": args.agentPoolId,
        "project": args.project,
    }, opts);
}

export interface GetAgentPoolArgs {
    agentPoolId: string;
    project?: string;
}

export interface GetAgentPoolResult {
    /**
     * Specifies the bandwidth limit details. If this field is unspecified, the default value is set as 'No Limit'.
     */
    readonly bandwidthLimit: outputs.storagetransfer.v1.BandwidthLimitResponse;
    /**
     * Specifies the client-specified AgentPool description.
     */
    readonly displayName: string;
    /**
     * Specifies a unique string that identifies the agent pool. Format: `projects/{project_id}/agentPools/{agent_pool_id}`
     */
    readonly name: string;
    /**
     * Specifies the state of the AgentPool.
     */
    readonly state: string;
}

export function getAgentPoolOutput(args: GetAgentPoolOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetAgentPoolResult> {
    return pulumi.output(args).apply(a => getAgentPool(a, opts))
}

export interface GetAgentPoolOutputArgs {
    agentPoolId: pulumi.Input<string>;
    project?: pulumi.Input<string>;
}
