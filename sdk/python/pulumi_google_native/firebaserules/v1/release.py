# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from ... import _utilities

__all__ = ['ReleaseArgs', 'Release']

@pulumi.input_type
class ReleaseArgs:
    def __init__(__self__, *,
                 ruleset_name: pulumi.Input[str],
                 name: Optional[pulumi.Input[str]] = None,
                 project: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a Release resource.
        :param pulumi.Input[str] ruleset_name: Name of the `Ruleset` referred to by this `Release`. The `Ruleset` must exist the `Release` to be created.
        :param pulumi.Input[str] name: Format: `projects/{project_id}/releases/{release_id}`
        """
        pulumi.set(__self__, "ruleset_name", ruleset_name)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if project is not None:
            pulumi.set(__self__, "project", project)

    @property
    @pulumi.getter(name="rulesetName")
    def ruleset_name(self) -> pulumi.Input[str]:
        """
        Name of the `Ruleset` referred to by this `Release`. The `Ruleset` must exist the `Release` to be created.
        """
        return pulumi.get(self, "ruleset_name")

    @ruleset_name.setter
    def ruleset_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "ruleset_name", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Format: `projects/{project_id}/releases/{release_id}`
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def project(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "project")

    @project.setter
    def project(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "project", value)


class Release(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 project: Optional[pulumi.Input[str]] = None,
                 ruleset_name: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Create a `Release`. Release names should reflect the developer's deployment practices. For example, the release name may include the environment name, application name, application version, or any other name meaningful to the developer. Once a `Release` refers to a `Ruleset`, the rules can be enforced by Firebase Rules-enabled services. More than one `Release` may be 'live' concurrently. Consider the following three `Release` names for `projects/foo` and the `Ruleset` to which they refer. Release Name -> Ruleset Name * projects/foo/releases/prod -> projects/foo/rulesets/uuid123 * projects/foo/releases/prod/beta -> projects/foo/rulesets/uuid123 * projects/foo/releases/prod/v23 -> projects/foo/rulesets/uuid456 The relationships reflect a `Ruleset` rollout in progress. The `prod` and `prod/beta` releases refer to the same `Ruleset`. However, `prod/v23` refers to a new `Ruleset`. The `Ruleset` reference for a `Release` may be updated using the UpdateRelease method.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] name: Format: `projects/{project_id}/releases/{release_id}`
        :param pulumi.Input[str] ruleset_name: Name of the `Ruleset` referred to by this `Release`. The `Ruleset` must exist the `Release` to be created.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: ReleaseArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a `Release`. Release names should reflect the developer's deployment practices. For example, the release name may include the environment name, application name, application version, or any other name meaningful to the developer. Once a `Release` refers to a `Ruleset`, the rules can be enforced by Firebase Rules-enabled services. More than one `Release` may be 'live' concurrently. Consider the following three `Release` names for `projects/foo` and the `Ruleset` to which they refer. Release Name -> Ruleset Name * projects/foo/releases/prod -> projects/foo/rulesets/uuid123 * projects/foo/releases/prod/beta -> projects/foo/rulesets/uuid123 * projects/foo/releases/prod/v23 -> projects/foo/rulesets/uuid456 The relationships reflect a `Ruleset` rollout in progress. The `prod` and `prod/beta` releases refer to the same `Ruleset`. However, `prod/v23` refers to a new `Ruleset`. The `Ruleset` reference for a `Release` may be updated using the UpdateRelease method.

        :param str resource_name: The name of the resource.
        :param ReleaseArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(ReleaseArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 project: Optional[pulumi.Input[str]] = None,
                 ruleset_name: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        if opts is None:
            opts = pulumi.ResourceOptions()
        else:
            opts = copy.copy(opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = ReleaseArgs.__new__(ReleaseArgs)

            __props__.__dict__["name"] = name
            __props__.__dict__["project"] = project
            if ruleset_name is None and not opts.urn:
                raise TypeError("Missing required property 'ruleset_name'")
            __props__.__dict__["ruleset_name"] = ruleset_name
            __props__.__dict__["create_time"] = None
            __props__.__dict__["update_time"] = None
        super(Release, __self__).__init__(
            'google-native:firebaserules/v1:Release',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'Release':
        """
        Get an existing Release resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = ReleaseArgs.__new__(ReleaseArgs)

        __props__.__dict__["create_time"] = None
        __props__.__dict__["name"] = None
        __props__.__dict__["project"] = None
        __props__.__dict__["ruleset_name"] = None
        __props__.__dict__["update_time"] = None
        return Release(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="createTime")
    def create_time(self) -> pulumi.Output[str]:
        """
        Time the release was created.
        """
        return pulumi.get(self, "create_time")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Format: `projects/{project_id}/releases/{release_id}`
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def project(self) -> pulumi.Output[str]:
        return pulumi.get(self, "project")

    @property
    @pulumi.getter(name="rulesetName")
    def ruleset_name(self) -> pulumi.Output[str]:
        """
        Name of the `Ruleset` referred to by this `Release`. The `Ruleset` must exist the `Release` to be created.
        """
        return pulumi.get(self, "ruleset_name")

    @property
    @pulumi.getter(name="updateTime")
    def update_time(self) -> pulumi.Output[str]:
        """
        Time the release was updated.
        """
        return pulumi.get(self, "update_time")

