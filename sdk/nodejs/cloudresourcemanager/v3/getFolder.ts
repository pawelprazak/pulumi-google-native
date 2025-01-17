// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

/**
 * Retrieves a folder identified by the supplied resource name. Valid folder resource names have the format `folders/{folder_id}` (for example, `folders/1234`). The caller must have `resourcemanager.folders.get` permission on the identified folder.
 */
export function getFolder(args: GetFolderArgs, opts?: pulumi.InvokeOptions): Promise<GetFolderResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("google-native:cloudresourcemanager/v3:getFolder", {
        "folderId": args.folderId,
    }, opts);
}

export interface GetFolderArgs {
    folderId: string;
}

export interface GetFolderResult {
    /**
     * Timestamp when the folder was created.
     */
    readonly createTime: string;
    /**
     * Timestamp when the folder was requested to be deleted.
     */
    readonly deleteTime: string;
    /**
     * The folder's display name. A folder's display name must be unique amongst its siblings. For example, no two folders with the same parent can share the same display name. The display name must start and end with a letter or digit, may contain letters, digits, spaces, hyphens and underscores and can be no longer than 30 characters. This is captured by the regular expression: `[\p{L}\p{N}]([\p{L}\p{N}_- ]{0,28}[\p{L}\p{N}])?`.
     */
    readonly displayName: string;
    /**
     * A checksum computed by the server based on the current value of the folder resource. This may be sent on update and delete requests to ensure the client has an up-to-date value before proceeding.
     */
    readonly etag: string;
    /**
     * The resource name of the folder. Its format is `folders/{folder_id}`, for example: "folders/1234".
     */
    readonly name: string;
    /**
     * The folder's parent's resource name. Updates to the folder's parent must be performed using MoveFolder.
     */
    readonly parent: string;
    /**
     * The lifecycle state of the folder. Updates to the state must be performed using DeleteFolder and UndeleteFolder.
     */
    readonly state: string;
    /**
     * Timestamp when the folder was last modified.
     */
    readonly updateTime: string;
}

export function getFolderOutput(args: GetFolderOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetFolderResult> {
    return pulumi.output(args).apply(a => getFolder(a, opts))
}

export interface GetFolderOutputArgs {
    folderId: pulumi.Input<string>;
}
