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

__all__ = ['FeatureConfigArgs', 'FeatureConfig']

@pulumi.input_type
class FeatureConfigArgs:
    def __init__(__self__, *,
                 feature_config_id: Optional[pulumi.Input[str]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 project: Optional[pulumi.Input[str]] = None,
                 request_id: Optional[pulumi.Input[str]] = None,
                 spec: Optional[pulumi.Input['FeatureSpecArgs']] = None,
                 state: Optional[pulumi.Input['FeatureConfigStateArgs']] = None):
        """
        The set of arguments for constructing a FeatureConfig resource.
        :param pulumi.Input[str] feature_config_id: The ID of the feature config to create.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] labels: GCP labels for this FeatureConfig.
        :param pulumi.Input[str] request_id: Idempotent request UUID.
        :param pulumi.Input['FeatureSpecArgs'] spec: Input only. Immutable. User input of feature spec. Note that this field is immutable. Must create a new FeatureConfig if a new feature spec is needed.
        :param pulumi.Input['FeatureConfigStateArgs'] state: Lifecycle information of the FeatureConfig.
        """
        if feature_config_id is not None:
            pulumi.set(__self__, "feature_config_id", feature_config_id)
        if labels is not None:
            pulumi.set(__self__, "labels", labels)
        if location is not None:
            pulumi.set(__self__, "location", location)
        if project is not None:
            pulumi.set(__self__, "project", project)
        if request_id is not None:
            pulumi.set(__self__, "request_id", request_id)
        if spec is not None:
            pulumi.set(__self__, "spec", spec)
        if state is not None:
            pulumi.set(__self__, "state", state)

    @property
    @pulumi.getter(name="featureConfigId")
    def feature_config_id(self) -> Optional[pulumi.Input[str]]:
        """
        The ID of the feature config to create.
        """
        return pulumi.get(self, "feature_config_id")

    @feature_config_id.setter
    def feature_config_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "feature_config_id", value)

    @property
    @pulumi.getter
    def labels(self) -> Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]:
        """
        GCP labels for this FeatureConfig.
        """
        return pulumi.get(self, "labels")

    @labels.setter
    def labels(self, value: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]):
        pulumi.set(self, "labels", value)

    @property
    @pulumi.getter
    def location(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "location")

    @location.setter
    def location(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "location", value)

    @property
    @pulumi.getter
    def project(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "project")

    @project.setter
    def project(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "project", value)

    @property
    @pulumi.getter(name="requestId")
    def request_id(self) -> Optional[pulumi.Input[str]]:
        """
        Idempotent request UUID.
        """
        return pulumi.get(self, "request_id")

    @request_id.setter
    def request_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "request_id", value)

    @property
    @pulumi.getter
    def spec(self) -> Optional[pulumi.Input['FeatureSpecArgs']]:
        """
        Input only. Immutable. User input of feature spec. Note that this field is immutable. Must create a new FeatureConfig if a new feature spec is needed.
        """
        return pulumi.get(self, "spec")

    @spec.setter
    def spec(self, value: Optional[pulumi.Input['FeatureSpecArgs']]):
        pulumi.set(self, "spec", value)

    @property
    @pulumi.getter
    def state(self) -> Optional[pulumi.Input['FeatureConfigStateArgs']]:
        """
        Lifecycle information of the FeatureConfig.
        """
        return pulumi.get(self, "state")

    @state.setter
    def state(self, value: Optional[pulumi.Input['FeatureConfigStateArgs']]):
        pulumi.set(self, "state", value)


class FeatureConfig(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 feature_config_id: Optional[pulumi.Input[str]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 project: Optional[pulumi.Input[str]] = None,
                 request_id: Optional[pulumi.Input[str]] = None,
                 spec: Optional[pulumi.Input[pulumi.InputType['FeatureSpecArgs']]] = None,
                 state: Optional[pulumi.Input[pulumi.InputType['FeatureConfigStateArgs']]] = None,
                 __props__=None):
        """
        Creates FeatureConfig under a given parent.
        Auto-naming is currently not supported for this resource.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] feature_config_id: The ID of the feature config to create.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] labels: GCP labels for this FeatureConfig.
        :param pulumi.Input[str] request_id: Idempotent request UUID.
        :param pulumi.Input[pulumi.InputType['FeatureSpecArgs']] spec: Input only. Immutable. User input of feature spec. Note that this field is immutable. Must create a new FeatureConfig if a new feature spec is needed.
        :param pulumi.Input[pulumi.InputType['FeatureConfigStateArgs']] state: Lifecycle information of the FeatureConfig.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: Optional[FeatureConfigArgs] = None,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Creates FeatureConfig under a given parent.
        Auto-naming is currently not supported for this resource.

        :param str resource_name: The name of the resource.
        :param FeatureConfigArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(FeatureConfigArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 feature_config_id: Optional[pulumi.Input[str]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 project: Optional[pulumi.Input[str]] = None,
                 request_id: Optional[pulumi.Input[str]] = None,
                 spec: Optional[pulumi.Input[pulumi.InputType['FeatureSpecArgs']]] = None,
                 state: Optional[pulumi.Input[pulumi.InputType['FeatureConfigStateArgs']]] = None,
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
            __props__ = FeatureConfigArgs.__new__(FeatureConfigArgs)

            __props__.__dict__["feature_config_id"] = feature_config_id
            __props__.__dict__["labels"] = labels
            __props__.__dict__["location"] = location
            __props__.__dict__["project"] = project
            __props__.__dict__["request_id"] = request_id
            __props__.__dict__["spec"] = spec
            __props__.__dict__["state"] = state
            __props__.__dict__["create_time"] = None
            __props__.__dict__["delete_time"] = None
            __props__.__dict__["name"] = None
            __props__.__dict__["unique_id"] = None
            __props__.__dict__["update_time"] = None
        super(FeatureConfig, __self__).__init__(
            'google-native:gkehub/v2alpha:FeatureConfig',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'FeatureConfig':
        """
        Get an existing FeatureConfig resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = FeatureConfigArgs.__new__(FeatureConfigArgs)

        __props__.__dict__["create_time"] = None
        __props__.__dict__["delete_time"] = None
        __props__.__dict__["labels"] = None
        __props__.__dict__["name"] = None
        __props__.__dict__["spec"] = None
        __props__.__dict__["state"] = None
        __props__.__dict__["unique_id"] = None
        __props__.__dict__["update_time"] = None
        return FeatureConfig(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="createTime")
    def create_time(self) -> pulumi.Output[str]:
        """
        When the FeatureConfig resource was created.
        """
        return pulumi.get(self, "create_time")

    @property
    @pulumi.getter(name="deleteTime")
    def delete_time(self) -> pulumi.Output[str]:
        """
        When the FeatureConfig resource was deleted.
        """
        return pulumi.get(self, "delete_time")

    @property
    @pulumi.getter
    def labels(self) -> pulumi.Output[Mapping[str, str]]:
        """
        GCP labels for this FeatureConfig.
        """
        return pulumi.get(self, "labels")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Resource name of this FeatureConfig, in the format: `projects/{project}/locations/global/FeatureConfigs/{feature_type}/{feature_config}`
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def spec(self) -> pulumi.Output['outputs.FeatureSpecResponse']:
        """
        Input only. Immutable. User input of feature spec. Note that this field is immutable. Must create a new FeatureConfig if a new feature spec is needed.
        """
        return pulumi.get(self, "spec")

    @property
    @pulumi.getter
    def state(self) -> pulumi.Output['outputs.FeatureConfigStateResponse']:
        """
        Lifecycle information of the FeatureConfig.
        """
        return pulumi.get(self, "state")

    @property
    @pulumi.getter(name="uniqueId")
    def unique_id(self) -> pulumi.Output[str]:
        """
        Google-generated UUID for this resource. This is unique across all FeatureConfig resources. If a Membership resource is deleted and another resource with the same name is created, it gets a different unique_id.
        """
        return pulumi.get(self, "unique_id")

    @property
    @pulumi.getter(name="updateTime")
    def update_time(self) -> pulumi.Output[str]:
        """
        When the FeatureConfig resource was last updated.
        """
        return pulumi.get(self, "update_time")
