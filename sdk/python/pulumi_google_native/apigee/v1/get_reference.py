# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from ... import _utilities

__all__ = [
    'GetReferenceResult',
    'AwaitableGetReferenceResult',
    'get_reference',
]

@pulumi.output_type
class GetReferenceResult:
    def __init__(__self__, description=None, name=None, refers=None, resource_type=None):
        if description and not isinstance(description, str):
            raise TypeError("Expected argument 'description' to be a str")
        pulumi.set(__self__, "description", description)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if refers and not isinstance(refers, str):
            raise TypeError("Expected argument 'refers' to be a str")
        pulumi.set(__self__, "refers", refers)
        if resource_type and not isinstance(resource_type, str):
            raise TypeError("Expected argument 'resource_type' to be a str")
        pulumi.set(__self__, "resource_type", resource_type)

    @property
    @pulumi.getter
    def description(self) -> str:
        """
        Optional. A human-readable description of this reference.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Required. The resource id of this reference. Values must match the regular expression [\w\s\-.]+.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def refers(self) -> str:
        """
        Required. The id of the resource to which this reference refers. Must be the id of a resource that exists in the parent environment and is of the given resource_type.
        """
        return pulumi.get(self, "refers")

    @property
    @pulumi.getter(name="resourceType")
    def resource_type(self) -> str:
        """
        The type of resource referred to by this reference. Valid values are 'KeyStore' or 'TrustStore'.
        """
        return pulumi.get(self, "resource_type")


class AwaitableGetReferenceResult(GetReferenceResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetReferenceResult(
            description=self.description,
            name=self.name,
            refers=self.refers,
            resource_type=self.resource_type)


def get_reference(environment_id: Optional[str] = None,
                  organization_id: Optional[str] = None,
                  reference_id: Optional[str] = None,
                  opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetReferenceResult:
    """
    Gets a Reference resource.
    """
    __args__ = dict()
    __args__['environmentId'] = environment_id
    __args__['organizationId'] = organization_id
    __args__['referenceId'] = reference_id
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('google-native:apigee/v1:getReference', __args__, opts=opts, typ=GetReferenceResult).value

    return AwaitableGetReferenceResult(
        description=__ret__.description,
        name=__ret__.name,
        refers=__ret__.refers,
        resource_type=__ret__.resource_type)