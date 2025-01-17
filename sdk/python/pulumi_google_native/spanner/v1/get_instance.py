# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from ... import _utilities

__all__ = [
    'GetInstanceResult',
    'AwaitableGetInstanceResult',
    'get_instance',
    'get_instance_output',
]

@pulumi.output_type
class GetInstanceResult:
    def __init__(__self__, config=None, create_time=None, display_name=None, endpoint_uris=None, labels=None, name=None, node_count=None, processing_units=None, state=None, update_time=None):
        if config and not isinstance(config, str):
            raise TypeError("Expected argument 'config' to be a str")
        pulumi.set(__self__, "config", config)
        if create_time and not isinstance(create_time, str):
            raise TypeError("Expected argument 'create_time' to be a str")
        pulumi.set(__self__, "create_time", create_time)
        if display_name and not isinstance(display_name, str):
            raise TypeError("Expected argument 'display_name' to be a str")
        pulumi.set(__self__, "display_name", display_name)
        if endpoint_uris and not isinstance(endpoint_uris, list):
            raise TypeError("Expected argument 'endpoint_uris' to be a list")
        if endpoint_uris is not None:
            warnings.warn("""Deprecated. This field is not populated.""", DeprecationWarning)
            pulumi.log.warn("""endpoint_uris is deprecated: Deprecated. This field is not populated.""")

        pulumi.set(__self__, "endpoint_uris", endpoint_uris)
        if labels and not isinstance(labels, dict):
            raise TypeError("Expected argument 'labels' to be a dict")
        pulumi.set(__self__, "labels", labels)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if node_count and not isinstance(node_count, int):
            raise TypeError("Expected argument 'node_count' to be a int")
        pulumi.set(__self__, "node_count", node_count)
        if processing_units and not isinstance(processing_units, int):
            raise TypeError("Expected argument 'processing_units' to be a int")
        pulumi.set(__self__, "processing_units", processing_units)
        if state and not isinstance(state, str):
            raise TypeError("Expected argument 'state' to be a str")
        pulumi.set(__self__, "state", state)
        if update_time and not isinstance(update_time, str):
            raise TypeError("Expected argument 'update_time' to be a str")
        pulumi.set(__self__, "update_time", update_time)

    @property
    @pulumi.getter
    def config(self) -> str:
        """
        The name of the instance's configuration. Values are of the form `projects//instanceConfigs/`. See also InstanceConfig and ListInstanceConfigs.
        """
        return pulumi.get(self, "config")

    @property
    @pulumi.getter(name="createTime")
    def create_time(self) -> str:
        """
        The time at which the instance was created.
        """
        return pulumi.get(self, "create_time")

    @property
    @pulumi.getter(name="displayName")
    def display_name(self) -> str:
        """
        The descriptive name for this instance as it appears in UIs. Must be unique per project and between 4 and 30 characters in length.
        """
        return pulumi.get(self, "display_name")

    @property
    @pulumi.getter(name="endpointUris")
    def endpoint_uris(self) -> Sequence[str]:
        """
        Deprecated. This field is not populated.
        """
        return pulumi.get(self, "endpoint_uris")

    @property
    @pulumi.getter
    def labels(self) -> Mapping[str, str]:
        """
        Cloud Labels are a flexible and lightweight mechanism for organizing cloud resources into groups that reflect a customer's organizational needs and deployment strategies. Cloud Labels can be used to filter collections of resources. They can be used to control how resource metrics are aggregated. And they can be used as arguments to policy management rules (e.g. route, firewall, load balancing, etc.). * Label keys must be between 1 and 63 characters long and must conform to the following regular expression: `a-z{0,62}`. * Label values must be between 0 and 63 characters long and must conform to the regular expression `[a-z0-9_-]{0,63}`. * No more than 64 labels can be associated with a given resource. See https://goo.gl/xmQnxf for more information on and examples of labels. If you plan to use labels in your own code, please note that additional characters may be allowed in the future. And so you are advised to use an internal label representation, such as JSON, which doesn't rely upon specific characters being disallowed. For example, representing labels as the string: name + "_" + value would prove problematic if we were to allow "_" in a future release.
        """
        return pulumi.get(self, "labels")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        A unique identifier for the instance, which cannot be changed after the instance is created. Values are of the form `projects//instances/a-z*[a-z0-9]`. The final segment of the name must be between 2 and 64 characters in length.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="nodeCount")
    def node_count(self) -> int:
        """
        The number of nodes allocated to this instance. At most one of either node_count or processing_units should be present in the message. This may be zero in API responses for instances that are not yet in state `READY`. See [the documentation](https://cloud.google.com/spanner/docs/compute-capacity) for more information about nodes and processing units.
        """
        return pulumi.get(self, "node_count")

    @property
    @pulumi.getter(name="processingUnits")
    def processing_units(self) -> int:
        """
        The number of processing units allocated to this instance. At most one of processing_units or node_count should be present in the message. This may be zero in API responses for instances that are not yet in state `READY`. See [the documentation](https://cloud.google.com/spanner/docs/compute-capacity) for more information about nodes and processing units.
        """
        return pulumi.get(self, "processing_units")

    @property
    @pulumi.getter
    def state(self) -> str:
        """
        The current instance state. For CreateInstance, the state must be either omitted or set to `CREATING`. For UpdateInstance, the state must be either omitted or set to `READY`.
        """
        return pulumi.get(self, "state")

    @property
    @pulumi.getter(name="updateTime")
    def update_time(self) -> str:
        """
        The time at which the instance was most recently updated.
        """
        return pulumi.get(self, "update_time")


class AwaitableGetInstanceResult(GetInstanceResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetInstanceResult(
            config=self.config,
            create_time=self.create_time,
            display_name=self.display_name,
            endpoint_uris=self.endpoint_uris,
            labels=self.labels,
            name=self.name,
            node_count=self.node_count,
            processing_units=self.processing_units,
            state=self.state,
            update_time=self.update_time)


def get_instance(field_mask: Optional[str] = None,
                 instance_id: Optional[str] = None,
                 project: Optional[str] = None,
                 opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetInstanceResult:
    """
    Gets information about a particular instance.
    """
    __args__ = dict()
    __args__['fieldMask'] = field_mask
    __args__['instanceId'] = instance_id
    __args__['project'] = project
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('google-native:spanner/v1:getInstance', __args__, opts=opts, typ=GetInstanceResult).value

    return AwaitableGetInstanceResult(
        config=__ret__.config,
        create_time=__ret__.create_time,
        display_name=__ret__.display_name,
        endpoint_uris=__ret__.endpoint_uris,
        labels=__ret__.labels,
        name=__ret__.name,
        node_count=__ret__.node_count,
        processing_units=__ret__.processing_units,
        state=__ret__.state,
        update_time=__ret__.update_time)


@_utilities.lift_output_func(get_instance)
def get_instance_output(field_mask: Optional[pulumi.Input[Optional[str]]] = None,
                        instance_id: Optional[pulumi.Input[str]] = None,
                        project: Optional[pulumi.Input[Optional[str]]] = None,
                        opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetInstanceResult]:
    """
    Gets information about a particular instance.
    """
    ...
