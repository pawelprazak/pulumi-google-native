# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from ... import _utilities
from . import outputs
from ._inputs import *

__all__ = ['CustomClassArgs', 'CustomClass']

@pulumi.input_type
class CustomClassArgs:
    def __init__(__self__, *,
                 custom_class_id: pulumi.Input[str],
                 items: Optional[pulumi.Input[Sequence[pulumi.Input['ClassItemArgs']]]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 project: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a CustomClass resource.
        :param pulumi.Input[str] custom_class_id: The ID to use for the custom class, which will become the final component of the custom class' resource name. This value should restrict to letters, numbers, and hyphens, with the first character a letter, the last a letter or a number, and be 4-63 characters.
        :param pulumi.Input[Sequence[pulumi.Input['ClassItemArgs']]] items: A collection of class items.
        :param pulumi.Input[str] name: The resource name of the custom class.
        """
        pulumi.set(__self__, "custom_class_id", custom_class_id)
        if items is not None:
            pulumi.set(__self__, "items", items)
        if location is not None:
            pulumi.set(__self__, "location", location)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if project is not None:
            pulumi.set(__self__, "project", project)

    @property
    @pulumi.getter(name="customClassId")
    def custom_class_id(self) -> pulumi.Input[str]:
        """
        The ID to use for the custom class, which will become the final component of the custom class' resource name. This value should restrict to letters, numbers, and hyphens, with the first character a letter, the last a letter or a number, and be 4-63 characters.
        """
        return pulumi.get(self, "custom_class_id")

    @custom_class_id.setter
    def custom_class_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "custom_class_id", value)

    @property
    @pulumi.getter
    def items(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['ClassItemArgs']]]]:
        """
        A collection of class items.
        """
        return pulumi.get(self, "items")

    @items.setter
    def items(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['ClassItemArgs']]]]):
        pulumi.set(self, "items", value)

    @property
    @pulumi.getter
    def location(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "location")

    @location.setter
    def location(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "location", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        The resource name of the custom class.
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


class CustomClass(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 custom_class_id: Optional[pulumi.Input[str]] = None,
                 items: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ClassItemArgs']]]]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 project: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Create a custom class.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] custom_class_id: The ID to use for the custom class, which will become the final component of the custom class' resource name. This value should restrict to letters, numbers, and hyphens, with the first character a letter, the last a letter or a number, and be 4-63 characters.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ClassItemArgs']]]] items: A collection of class items.
        :param pulumi.Input[str] name: The resource name of the custom class.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: CustomClassArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a custom class.

        :param str resource_name: The name of the resource.
        :param CustomClassArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(CustomClassArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 custom_class_id: Optional[pulumi.Input[str]] = None,
                 items: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ClassItemArgs']]]]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 project: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = CustomClassArgs.__new__(CustomClassArgs)

            if custom_class_id is None and not opts.urn:
                raise TypeError("Missing required property 'custom_class_id'")
            __props__.__dict__["custom_class_id"] = custom_class_id
            __props__.__dict__["items"] = items
            __props__.__dict__["location"] = location
            __props__.__dict__["name"] = name
            __props__.__dict__["project"] = project
        super(CustomClass, __self__).__init__(
            'google-native:speech/v1:CustomClass',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'CustomClass':
        """
        Get an existing CustomClass resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = CustomClassArgs.__new__(CustomClassArgs)

        __props__.__dict__["custom_class_id"] = None
        __props__.__dict__["items"] = None
        __props__.__dict__["name"] = None
        return CustomClass(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="customClassId")
    def custom_class_id(self) -> pulumi.Output[str]:
        """
        If this custom class is a resource, the custom_class_id is the resource id of the CustomClass. Case sensitive.
        """
        return pulumi.get(self, "custom_class_id")

    @property
    @pulumi.getter
    def items(self) -> pulumi.Output[Sequence['outputs.ClassItemResponse']]:
        """
        A collection of class items.
        """
        return pulumi.get(self, "items")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        The resource name of the custom class.
        """
        return pulumi.get(self, "name")
