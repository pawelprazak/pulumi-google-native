// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Gets the details of a specific share.
 */
export function getShare(args: GetShareArgs, opts?: pulumi.InvokeOptions): Promise<GetShareResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("google-native:file/v1beta1:getShare", {
        "instanceId": args.instanceId,
        "location": args.location,
        "project": args.project,
        "shareId": args.shareId,
    }, opts);
}

export interface GetShareArgs {
    instanceId: string;
    location: string;
    project?: string;
    shareId: string;
}

export interface GetShareResult {
    /**
     * File share capacity in gigabytes (GB). Cloud Filestore defines 1 GB as 1024^3 bytes. Must be greater than 0.
     */
    readonly capacityGb: string;
    /**
     * The time when the share was created.
     */
    readonly createTime: string;
    /**
     * A description of the share with 2048 characters or less. Requests with longer descriptions will be rejected.
     */
    readonly description: string;
    /**
     * Resource labels to represent user provided metadata.
     */
    readonly labels: {[key: string]: string};
    /**
     * The mount name of the share. Must be 63 characters or less and consist of uppercase or lowercase letters, numbers, and underscores.
     */
    readonly mountName: string;
    /**
     * The resource name of the share, in the format `projects/{project_id}/locations/{location_id}/instances/{instance_id}/shares/{share_id}`.
     */
    readonly name: string;
    /**
     * Nfs Export Options. There is a limit of 10 export options per file share.
     */
    readonly nfsExportOptions: outputs.file.v1beta1.NfsExportOptionsResponse[];
    /**
     * The share state.
     */
    readonly state: string;
}

export function getShareOutput(args: GetShareOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetShareResult> {
    return pulumi.output(args).apply(a => getShare(a, opts))
}

export interface GetShareOutputArgs {
    instanceId: pulumi.Input<string>;
    location: pulumi.Input<string>;
    project?: pulumi.Input<string>;
    shareId: pulumi.Input<string>;
}
