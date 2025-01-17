// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Retrieves a `Membership`.
 */
export function getMembership(args: GetMembershipArgs, opts?: pulumi.InvokeOptions): Promise<GetMembershipResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("google-native:cloudidentity/v1beta1:getMembership", {
        "groupId": args.groupId,
        "membershipId": args.membershipId,
    }, opts);
}

export interface GetMembershipArgs {
    groupId: string;
    membershipId: string;
}

export interface GetMembershipResult {
    /**
     * The time when the `Membership` was created.
     */
    readonly createTime: string;
    /**
     * Immutable. The `EntityKey` of the member. Either `member_key` or `preferred_member_key` must be set when calling MembershipsService.CreateMembership but not both; both shall be set when returned.
     */
    readonly memberKey: outputs.cloudidentity.v1beta1.EntityKeyResponse;
    /**
     * The [resource name](https://cloud.google.com/apis/design/resource_names) of the `Membership`. Shall be of the form `groups/{group_id}/memberships/{membership_id}`.
     */
    readonly name: string;
    /**
     * Immutable. The `EntityKey` of the member. Either `member_key` or `preferred_member_key` must be set when calling MembershipsService.CreateMembership but not both; both shall be set when returned.
     */
    readonly preferredMemberKey: outputs.cloudidentity.v1beta1.EntityKeyResponse;
    /**
     * The `MembershipRole`s that apply to the `Membership`. If unspecified, defaults to a single `MembershipRole` with `name` `MEMBER`. Must not contain duplicate `MembershipRole`s with the same `name`.
     */
    readonly roles: outputs.cloudidentity.v1beta1.MembershipRoleResponse[];
    /**
     * The type of the membership.
     */
    readonly type: string;
    /**
     * The time when the `Membership` was last updated.
     */
    readonly updateTime: string;
}

export function getMembershipOutput(args: GetMembershipOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetMembershipResult> {
    return pulumi.output(args).apply(a => getMembership(a, opts))
}

export interface GetMembershipOutputArgs {
    groupId: pulumi.Input<string>;
    membershipId: pulumi.Input<string>;
}
