// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

/**
 * Gets details of a single Backup.
 */
export function getBackup(args: GetBackupArgs, opts?: pulumi.InvokeOptions): Promise<GetBackupResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("google-native:managedidentities/v1:getBackup", {
        "backupId": args.backupId,
        "domainId": args.domainId,
        "project": args.project,
    }, opts);
}

export interface GetBackupArgs {
    backupId: string;
    domainId: string;
    project?: string;
}

export interface GetBackupResult {
    /**
     * The time the backups was created.
     */
    readonly createTime: string;
    /**
     * Optional. Resource labels to represent user provided metadata.
     */
    readonly labels: {[key: string]: string};
    /**
     * The unique name of the Backup in the form of `projects/{project_id}/locations/global/domains/{domain_name}/backups/{name}`
     */
    readonly name: string;
    /**
     * The current state of the backup.
     */
    readonly state: string;
    /**
     * Additional information about the current status of this backup, if available.
     */
    readonly statusMessage: string;
    /**
     * Indicates whether it’s an on-demand backup or scheduled.
     */
    readonly type: string;
    /**
     * Last update time.
     */
    readonly updateTime: string;
}

export function getBackupOutput(args: GetBackupOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetBackupResult> {
    return pulumi.output(args).apply(a => getBackup(a, opts))
}

export interface GetBackupOutputArgs {
    backupId: pulumi.Input<string>;
    domainId: pulumi.Input<string>;
    project?: pulumi.Input<string>;
}
