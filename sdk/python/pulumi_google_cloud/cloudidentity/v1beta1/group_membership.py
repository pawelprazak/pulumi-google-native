# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables
from . import outputs
from ._inputs import *

__all__ = ['GroupMembership']


class GroupMembership(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 groups_id: Optional[pulumi.Input[str]] = None,
                 member_key: Optional[pulumi.Input[pulumi.InputType['EntityKeyArgs']]] = None,
                 memberships_id: Optional[pulumi.Input[str]] = None,
                 preferred_member_key: Optional[pulumi.Input[pulumi.InputType['EntityKeyArgs']]] = None,
                 roles: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['MembershipRoleArgs']]]]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Creates a `Membership`.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[pulumi.InputType['EntityKeyArgs']] member_key: Immutable. The `EntityKey` of the member. Either `member_key` or `preferred_member_key` must be set when calling MembershipsService.CreateMembership but not both; both shall be set when returned.
        :param pulumi.Input[pulumi.InputType['EntityKeyArgs']] preferred_member_key: Required. Immutable. The `EntityKey` of the member. Either `member_key` or `preferred_member_key` must be set when calling MembershipsService.CreateMembership but not both; both shall be set when returned.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['MembershipRoleArgs']]]] roles: The `MembershipRole`s that apply to the `Membership`. If unspecified, defaults to a single `MembershipRole` with `name` `MEMBER`. Must not contain duplicate `MembershipRole`s with the same `name`.
        """
        if __name__ is not None:
            warnings.warn("explicit use of __name__ is deprecated", DeprecationWarning)
            resource_name = __name__
        if __opts__ is not None:
            warnings.warn("explicit use of __opts__ is deprecated, use 'opts' instead", DeprecationWarning)
            opts = __opts__
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = dict()

            if groups_id is None and not opts.urn:
                raise TypeError("Missing required property 'groups_id'")
            __props__['groups_id'] = groups_id
            __props__['member_key'] = member_key
            if memberships_id is None and not opts.urn:
                raise TypeError("Missing required property 'memberships_id'")
            __props__['memberships_id'] = memberships_id
            __props__['preferred_member_key'] = preferred_member_key
            __props__['roles'] = roles
            __props__['create_time'] = None
            __props__['name'] = None
            __props__['type'] = None
            __props__['update_time'] = None
        super(GroupMembership, __self__).__init__(
            'google-cloud:cloudidentity/v1beta1:GroupMembership',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'GroupMembership':
        """
        Get an existing GroupMembership resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["create_time"] = None
        __props__["member_key"] = None
        __props__["name"] = None
        __props__["preferred_member_key"] = None
        __props__["roles"] = None
        __props__["type"] = None
        __props__["update_time"] = None
        return GroupMembership(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="createTime")
    def create_time(self) -> pulumi.Output[str]:
        """
        The time when the `Membership` was created.
        """
        return pulumi.get(self, "create_time")

    @property
    @pulumi.getter(name="memberKey")
    def member_key(self) -> pulumi.Output['outputs.EntityKeyResponse']:
        """
        Immutable. The `EntityKey` of the member. Either `member_key` or `preferred_member_key` must be set when calling MembershipsService.CreateMembership but not both; both shall be set when returned.
        """
        return pulumi.get(self, "member_key")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        The [resource name](https://cloud.google.com/apis/design/resource_names) of the `Membership`. Shall be of the form `groups/{group_id}/memberships/{membership_id}`.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="preferredMemberKey")
    def preferred_member_key(self) -> pulumi.Output['outputs.EntityKeyResponse']:
        """
        Required. Immutable. The `EntityKey` of the member. Either `member_key` or `preferred_member_key` must be set when calling MembershipsService.CreateMembership but not both; both shall be set when returned.
        """
        return pulumi.get(self, "preferred_member_key")

    @property
    @pulumi.getter
    def roles(self) -> pulumi.Output[Sequence['outputs.MembershipRoleResponse']]:
        """
        The `MembershipRole`s that apply to the `Membership`. If unspecified, defaults to a single `MembershipRole` with `name` `MEMBER`. Must not contain duplicate `MembershipRole`s with the same `name`.
        """
        return pulumi.get(self, "roles")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[str]:
        """
        The type of the membership.
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="updateTime")
    def update_time(self) -> pulumi.Output[str]:
        """
        The time when the `Membership` was last updated.
        """
        return pulumi.get(self, "update_time")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop
