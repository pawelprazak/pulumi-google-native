// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Returns the ACL entry for the specified entity on the specified object.
 */
export function getObjectAccessControl(args: GetObjectAccessControlArgs, opts?: pulumi.InvokeOptions): Promise<GetObjectAccessControlResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("google-native:storage/v1:getObjectAccessControl", {
        "bucket": args.bucket,
        "entity": args.entity,
        "generation": args.generation,
        "object": args.object,
        "userProject": args.userProject,
    }, opts);
}

export interface GetObjectAccessControlArgs {
    bucket: string;
    entity: string;
    generation?: string;
    object: string;
    userProject?: string;
}

export interface GetObjectAccessControlResult {
    /**
     * The name of the bucket.
     */
    readonly bucket: string;
    /**
     * The domain associated with the entity, if any.
     */
    readonly domain: string;
    /**
     * The email address associated with the entity, if any.
     */
    readonly email: string;
    /**
     * The entity holding the permission, in one of the following forms: 
     * - user-userId 
     * - user-email 
     * - group-groupId 
     * - group-email 
     * - domain-domain 
     * - project-team-projectId 
     * - allUsers 
     * - allAuthenticatedUsers Examples: 
     * - The user liz@example.com would be user-liz@example.com. 
     * - The group example@googlegroups.com would be group-example@googlegroups.com. 
     * - To refer to all members of the Google Apps for Business domain example.com, the entity would be domain-example.com.
     */
    readonly entity: string;
    /**
     * The ID for the entity, if any.
     */
    readonly entityId: string;
    /**
     * HTTP 1.1 Entity tag for the access-control entry.
     */
    readonly etag: string;
    /**
     * The content generation of the object, if applied to an object.
     */
    readonly generation: string;
    /**
     * The kind of item this is. For object access control entries, this is always storage#objectAccessControl.
     */
    readonly kind: string;
    /**
     * The name of the object, if applied to an object.
     */
    readonly object: string;
    /**
     * The project team associated with the entity, if any.
     */
    readonly projectTeam: outputs.storage.v1.ObjectAccessControlProjectTeamResponse;
    /**
     * The access permission for the entity.
     */
    readonly role: string;
    /**
     * The link to this access-control entry.
     */
    readonly selfLink: string;
}

export function getObjectAccessControlOutput(args: GetObjectAccessControlOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetObjectAccessControlResult> {
    return pulumi.output(args).apply(a => getObjectAccessControl(a, opts))
}

export interface GetObjectAccessControlOutputArgs {
    bucket: pulumi.Input<string>;
    entity: pulumi.Input<string>;
    generation?: pulumi.Input<string>;
    object: pulumi.Input<string>;
    userProject?: pulumi.Input<string>;
}
