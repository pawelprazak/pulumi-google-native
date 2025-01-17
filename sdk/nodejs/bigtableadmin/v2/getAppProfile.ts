// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Gets information about an app profile.
 */
export function getAppProfile(args: GetAppProfileArgs, opts?: pulumi.InvokeOptions): Promise<GetAppProfileResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("google-native:bigtableadmin/v2:getAppProfile", {
        "appProfileId": args.appProfileId,
        "instanceId": args.instanceId,
        "project": args.project,
    }, opts);
}

export interface GetAppProfileArgs {
    appProfileId: string;
    instanceId: string;
    project?: string;
}

export interface GetAppProfileResult {
    /**
     * Long form description of the use case for this AppProfile.
     */
    readonly description: string;
    /**
     * Strongly validated etag for optimistic concurrency control. Preserve the value returned from `GetAppProfile` when calling `UpdateAppProfile` to fail the request if there has been a modification in the mean time. The `update_mask` of the request need not include `etag` for this protection to apply. See [Wikipedia](https://en.wikipedia.org/wiki/HTTP_ETag) and [RFC 7232](https://tools.ietf.org/html/rfc7232#section-2.3) for more details.
     */
    readonly etag: string;
    /**
     * Use a multi-cluster routing policy.
     */
    readonly multiClusterRoutingUseAny: outputs.bigtableadmin.v2.MultiClusterRoutingUseAnyResponse;
    /**
     * The unique name of the app profile. Values are of the form `projects/{project}/instances/{instance}/appProfiles/_a-zA-Z0-9*`.
     */
    readonly name: string;
    /**
     * Use a single-cluster routing policy.
     */
    readonly singleClusterRouting: outputs.bigtableadmin.v2.SingleClusterRoutingResponse;
}

export function getAppProfileOutput(args: GetAppProfileOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetAppProfileResult> {
    return pulumi.output(args).apply(a => getAppProfile(a, opts))
}

export interface GetAppProfileOutputArgs {
    appProfileId: pulumi.Input<string>;
    instanceId: pulumi.Input<string>;
    project?: pulumi.Input<string>;
}
