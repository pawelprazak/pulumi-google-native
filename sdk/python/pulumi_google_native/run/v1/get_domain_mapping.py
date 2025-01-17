# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from ... import _utilities
from . import outputs

__all__ = [
    'GetDomainMappingResult',
    'AwaitableGetDomainMappingResult',
    'get_domain_mapping',
    'get_domain_mapping_output',
]

@pulumi.output_type
class GetDomainMappingResult:
    def __init__(__self__, api_version=None, kind=None, metadata=None, spec=None, status=None):
        if api_version and not isinstance(api_version, str):
            raise TypeError("Expected argument 'api_version' to be a str")
        pulumi.set(__self__, "api_version", api_version)
        if kind and not isinstance(kind, str):
            raise TypeError("Expected argument 'kind' to be a str")
        pulumi.set(__self__, "kind", kind)
        if metadata and not isinstance(metadata, dict):
            raise TypeError("Expected argument 'metadata' to be a dict")
        pulumi.set(__self__, "metadata", metadata)
        if spec and not isinstance(spec, dict):
            raise TypeError("Expected argument 'spec' to be a dict")
        pulumi.set(__self__, "spec", spec)
        if status and not isinstance(status, dict):
            raise TypeError("Expected argument 'status' to be a dict")
        pulumi.set(__self__, "status", status)

    @property
    @pulumi.getter(name="apiVersion")
    def api_version(self) -> str:
        """
        The API version for this call such as "domains.cloudrun.com/v1".
        """
        return pulumi.get(self, "api_version")

    @property
    @pulumi.getter
    def kind(self) -> str:
        """
        The kind of resource, in this case "DomainMapping".
        """
        return pulumi.get(self, "kind")

    @property
    @pulumi.getter
    def metadata(self) -> 'outputs.ObjectMetaResponse':
        """
        Metadata associated with this BuildTemplate.
        """
        return pulumi.get(self, "metadata")

    @property
    @pulumi.getter
    def spec(self) -> 'outputs.DomainMappingSpecResponse':
        """
        The spec for this DomainMapping.
        """
        return pulumi.get(self, "spec")

    @property
    @pulumi.getter
    def status(self) -> 'outputs.DomainMappingStatusResponse':
        """
        The current status of the DomainMapping.
        """
        return pulumi.get(self, "status")


class AwaitableGetDomainMappingResult(GetDomainMappingResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetDomainMappingResult(
            api_version=self.api_version,
            kind=self.kind,
            metadata=self.metadata,
            spec=self.spec,
            status=self.status)


def get_domain_mapping(domainmapping_id: Optional[str] = None,
                       location: Optional[str] = None,
                       project: Optional[str] = None,
                       opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetDomainMappingResult:
    """
    Get information about a domain mapping.
    """
    __args__ = dict()
    __args__['domainmappingId'] = domainmapping_id
    __args__['location'] = location
    __args__['project'] = project
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('google-native:run/v1:getDomainMapping', __args__, opts=opts, typ=GetDomainMappingResult).value

    return AwaitableGetDomainMappingResult(
        api_version=__ret__.api_version,
        kind=__ret__.kind,
        metadata=__ret__.metadata,
        spec=__ret__.spec,
        status=__ret__.status)


@_utilities.lift_output_func(get_domain_mapping)
def get_domain_mapping_output(domainmapping_id: Optional[pulumi.Input[str]] = None,
                              location: Optional[pulumi.Input[str]] = None,
                              project: Optional[pulumi.Input[Optional[str]]] = None,
                              opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetDomainMappingResult]:
    """
    Get information about a domain mapping.
    """
    ...
