// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

/**
 * Gets details of a single game server deployment.
 */
export function getGameServerDeployment(args: GetGameServerDeploymentArgs, opts?: pulumi.InvokeOptions): Promise<GetGameServerDeploymentResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("google-native:gameservices/v1beta:getGameServerDeployment", {
        "gameServerDeploymentId": args.gameServerDeploymentId,
        "location": args.location,
        "project": args.project,
    }, opts);
}

export interface GetGameServerDeploymentArgs {
    gameServerDeploymentId: string;
    location: string;
    project?: string;
}

export interface GetGameServerDeploymentResult {
    /**
     * The creation time.
     */
    readonly createTime: string;
    /**
     * Human readable description of the game server deployment.
     */
    readonly description: string;
    /**
     * Used to perform consistent read-modify-write updates. If not set, a blind "overwrite" update happens.
     */
    readonly etag: string;
    /**
     * The labels associated with this game server deployment. Each label is a key-value pair.
     */
    readonly labels: {[key: string]: string};
    /**
     * The resource name of the game server deployment, in the following form: `projects/{project}/locations/{locationId}/gameServerDeployments/{deploymentId}`. For example, `projects/my-project/locations/global/gameServerDeployments/my-deployment`.
     */
    readonly name: string;
    /**
     * The last-modified time.
     */
    readonly updateTime: string;
}

export function getGameServerDeploymentOutput(args: GetGameServerDeploymentOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetGameServerDeploymentResult> {
    return pulumi.output(args).apply(a => getGameServerDeployment(a, opts))
}

export interface GetGameServerDeploymentOutputArgs {
    gameServerDeploymentId: pulumi.Input<string>;
    location: pulumi.Input<string>;
    project?: pulumi.Input<string>;
}
