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
    'GetDeploymentResult',
    'AwaitableGetDeploymentResult',
    'get_deployment',
    'get_deployment_output',
]

@pulumi.output_type
class GetDeploymentResult:
    def __init__(__self__, access_guidance=None, annotations=None, api_spec_revision=None, create_time=None, description=None, display_name=None, endpoint_uri=None, external_channel_uri=None, intended_audience=None, labels=None, name=None, revision_create_time=None, revision_id=None, revision_update_time=None):
        if access_guidance and not isinstance(access_guidance, str):
            raise TypeError("Expected argument 'access_guidance' to be a str")
        pulumi.set(__self__, "access_guidance", access_guidance)
        if annotations and not isinstance(annotations, dict):
            raise TypeError("Expected argument 'annotations' to be a dict")
        pulumi.set(__self__, "annotations", annotations)
        if api_spec_revision and not isinstance(api_spec_revision, str):
            raise TypeError("Expected argument 'api_spec_revision' to be a str")
        pulumi.set(__self__, "api_spec_revision", api_spec_revision)
        if create_time and not isinstance(create_time, str):
            raise TypeError("Expected argument 'create_time' to be a str")
        pulumi.set(__self__, "create_time", create_time)
        if description and not isinstance(description, str):
            raise TypeError("Expected argument 'description' to be a str")
        pulumi.set(__self__, "description", description)
        if display_name and not isinstance(display_name, str):
            raise TypeError("Expected argument 'display_name' to be a str")
        pulumi.set(__self__, "display_name", display_name)
        if endpoint_uri and not isinstance(endpoint_uri, str):
            raise TypeError("Expected argument 'endpoint_uri' to be a str")
        pulumi.set(__self__, "endpoint_uri", endpoint_uri)
        if external_channel_uri and not isinstance(external_channel_uri, str):
            raise TypeError("Expected argument 'external_channel_uri' to be a str")
        pulumi.set(__self__, "external_channel_uri", external_channel_uri)
        if intended_audience and not isinstance(intended_audience, str):
            raise TypeError("Expected argument 'intended_audience' to be a str")
        pulumi.set(__self__, "intended_audience", intended_audience)
        if labels and not isinstance(labels, dict):
            raise TypeError("Expected argument 'labels' to be a dict")
        pulumi.set(__self__, "labels", labels)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if revision_create_time and not isinstance(revision_create_time, str):
            raise TypeError("Expected argument 'revision_create_time' to be a str")
        pulumi.set(__self__, "revision_create_time", revision_create_time)
        if revision_id and not isinstance(revision_id, str):
            raise TypeError("Expected argument 'revision_id' to be a str")
        pulumi.set(__self__, "revision_id", revision_id)
        if revision_update_time and not isinstance(revision_update_time, str):
            raise TypeError("Expected argument 'revision_update_time' to be a str")
        pulumi.set(__self__, "revision_update_time", revision_update_time)

    @property
    @pulumi.getter(name="accessGuidance")
    def access_guidance(self) -> str:
        """
        Text briefly describing how to access the endpoint. Changes to this value will not affect the revision.
        """
        return pulumi.get(self, "access_guidance")

    @property
    @pulumi.getter
    def annotations(self) -> Mapping[str, str]:
        """
        Annotations attach non-identifying metadata to resources. Annotation keys and values are less restricted than those of labels, but should be generally used for small values of broad interest. Larger, topic- specific metadata should be stored in Artifacts.
        """
        return pulumi.get(self, "annotations")

    @property
    @pulumi.getter(name="apiSpecRevision")
    def api_spec_revision(self) -> str:
        """
        The full resource name (including revision id) of the spec of the API being served by the deployment. Changes to this value will update the revision. Format: apis/{api}/deployments/{deployment}
        """
        return pulumi.get(self, "api_spec_revision")

    @property
    @pulumi.getter(name="createTime")
    def create_time(self) -> str:
        """
        Creation timestamp; when the deployment resource was created.
        """
        return pulumi.get(self, "create_time")

    @property
    @pulumi.getter
    def description(self) -> str:
        """
        A detailed description.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="displayName")
    def display_name(self) -> str:
        """
        Human-meaningful name.
        """
        return pulumi.get(self, "display_name")

    @property
    @pulumi.getter(name="endpointUri")
    def endpoint_uri(self) -> str:
        """
        The address where the deployment is serving. Changes to this value will update the revision.
        """
        return pulumi.get(self, "endpoint_uri")

    @property
    @pulumi.getter(name="externalChannelUri")
    def external_channel_uri(self) -> str:
        """
        The address of the external channel of the API (e.g. the Developer Portal). Changes to this value will not affect the revision.
        """
        return pulumi.get(self, "external_channel_uri")

    @property
    @pulumi.getter(name="intendedAudience")
    def intended_audience(self) -> str:
        """
        Text briefly identifying the intended audience of the API. Changes to this value will not affect the revision.
        """
        return pulumi.get(self, "intended_audience")

    @property
    @pulumi.getter
    def labels(self) -> Mapping[str, str]:
        """
        Labels attach identifying metadata to resources. Identifying metadata can be used to filter list operations. Label keys and values can be no longer than 64 characters (Unicode codepoints), can only contain lowercase letters, numeric characters, underscores and dashes. International characters are allowed. No more than 64 user labels can be associated with one resource (System labels are excluded). See https://goo.gl/xmQnxf for more information and examples of labels. System reserved label keys are prefixed with "apigeeregistry.googleapis.com/" and cannot be changed.
        """
        return pulumi.get(self, "labels")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Resource name.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="revisionCreateTime")
    def revision_create_time(self) -> str:
        """
        Revision creation timestamp; when the represented revision was created.
        """
        return pulumi.get(self, "revision_create_time")

    @property
    @pulumi.getter(name="revisionId")
    def revision_id(self) -> str:
        """
        Immutable. The revision ID of the deployment. A new revision is committed whenever the deployment contents are changed. The format is an 8-character hexadecimal string.
        """
        return pulumi.get(self, "revision_id")

    @property
    @pulumi.getter(name="revisionUpdateTime")
    def revision_update_time(self) -> str:
        """
        Last update timestamp: when the represented revision was last modified.
        """
        return pulumi.get(self, "revision_update_time")


class AwaitableGetDeploymentResult(GetDeploymentResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetDeploymentResult(
            access_guidance=self.access_guidance,
            annotations=self.annotations,
            api_spec_revision=self.api_spec_revision,
            create_time=self.create_time,
            description=self.description,
            display_name=self.display_name,
            endpoint_uri=self.endpoint_uri,
            external_channel_uri=self.external_channel_uri,
            intended_audience=self.intended_audience,
            labels=self.labels,
            name=self.name,
            revision_create_time=self.revision_create_time,
            revision_id=self.revision_id,
            revision_update_time=self.revision_update_time)


def get_deployment(api_id: Optional[str] = None,
                   deployment_id: Optional[str] = None,
                   location: Optional[str] = None,
                   project: Optional[str] = None,
                   opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetDeploymentResult:
    """
    GetApiDeployment returns a specified deployment.
    """
    __args__ = dict()
    __args__['apiId'] = api_id
    __args__['deploymentId'] = deployment_id
    __args__['location'] = location
    __args__['project'] = project
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('google-native:apigeeregistry/v1:getDeployment', __args__, opts=opts, typ=GetDeploymentResult).value

    return AwaitableGetDeploymentResult(
        access_guidance=__ret__.access_guidance,
        annotations=__ret__.annotations,
        api_spec_revision=__ret__.api_spec_revision,
        create_time=__ret__.create_time,
        description=__ret__.description,
        display_name=__ret__.display_name,
        endpoint_uri=__ret__.endpoint_uri,
        external_channel_uri=__ret__.external_channel_uri,
        intended_audience=__ret__.intended_audience,
        labels=__ret__.labels,
        name=__ret__.name,
        revision_create_time=__ret__.revision_create_time,
        revision_id=__ret__.revision_id,
        revision_update_time=__ret__.revision_update_time)


@_utilities.lift_output_func(get_deployment)
def get_deployment_output(api_id: Optional[pulumi.Input[str]] = None,
                          deployment_id: Optional[pulumi.Input[str]] = None,
                          location: Optional[pulumi.Input[str]] = None,
                          project: Optional[pulumi.Input[Optional[str]]] = None,
                          opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetDeploymentResult]:
    """
    GetApiDeployment returns a specified deployment.
    """
    ...
