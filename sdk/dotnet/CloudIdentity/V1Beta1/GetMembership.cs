// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.CloudIdentity.V1Beta1
{
    public static class GetMembership
    {
        /// <summary>
        /// Retrieves a `Membership`.
        /// </summary>
        public static Task<GetMembershipResult> InvokeAsync(GetMembershipArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetMembershipResult>("google-native:cloudidentity/v1beta1:getMembership", args ?? new GetMembershipArgs(), options.WithDefaults());

        /// <summary>
        /// Retrieves a `Membership`.
        /// </summary>
        public static Output<GetMembershipResult> Invoke(GetMembershipInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetMembershipResult>("google-native:cloudidentity/v1beta1:getMembership", args ?? new GetMembershipInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetMembershipArgs : Pulumi.InvokeArgs
    {
        [Input("groupId", required: true)]
        public string GroupId { get; set; } = null!;

        [Input("membershipId", required: true)]
        public string MembershipId { get; set; } = null!;

        public GetMembershipArgs()
        {
        }
    }

    public sealed class GetMembershipInvokeArgs : Pulumi.InvokeArgs
    {
        [Input("groupId", required: true)]
        public Input<string> GroupId { get; set; } = null!;

        [Input("membershipId", required: true)]
        public Input<string> MembershipId { get; set; } = null!;

        public GetMembershipInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetMembershipResult
    {
        /// <summary>
        /// The time when the `Membership` was created.
        /// </summary>
        public readonly string CreateTime;
        /// <summary>
        /// Immutable. The `EntityKey` of the member. Either `member_key` or `preferred_member_key` must be set when calling MembershipsService.CreateMembership but not both; both shall be set when returned.
        /// </summary>
        public readonly Outputs.EntityKeyResponse MemberKey;
        /// <summary>
        /// The [resource name](https://cloud.google.com/apis/design/resource_names) of the `Membership`. Shall be of the form `groups/{group_id}/memberships/{membership_id}`.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Immutable. The `EntityKey` of the member. Either `member_key` or `preferred_member_key` must be set when calling MembershipsService.CreateMembership but not both; both shall be set when returned.
        /// </summary>
        public readonly Outputs.EntityKeyResponse PreferredMemberKey;
        /// <summary>
        /// The `MembershipRole`s that apply to the `Membership`. If unspecified, defaults to a single `MembershipRole` with `name` `MEMBER`. Must not contain duplicate `MembershipRole`s with the same `name`.
        /// </summary>
        public readonly ImmutableArray<Outputs.MembershipRoleResponse> Roles;
        /// <summary>
        /// The type of the membership.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// The time when the `Membership` was last updated.
        /// </summary>
        public readonly string UpdateTime;

        [OutputConstructor]
        private GetMembershipResult(
            string createTime,

            Outputs.EntityKeyResponse memberKey,

            string name,

            Outputs.EntityKeyResponse preferredMemberKey,

            ImmutableArray<Outputs.MembershipRoleResponse> roles,

            string type,

            string updateTime)
        {
            CreateTime = createTime;
            MemberKey = memberKey;
            Name = name;
            PreferredMemberKey = preferredMemberKey;
            Roles = roles;
            Type = type;
            UpdateTime = updateTime;
        }
    }
}
