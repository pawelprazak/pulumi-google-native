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
    'GetDeploymentArtifactResult',
    'AwaitableGetDeploymentArtifactResult',
    'get_deployment_artifact',
    'get_deployment_artifact_output',
]

@pulumi.output_type
class GetDeploymentArtifactResult:
    def __init__(__self__, contents=None, create_time=None, hash=None, mime_type=None, name=None, size_bytes=None, update_time=None):
        if contents and not isinstance(contents, str):
            raise TypeError("Expected argument 'contents' to be a str")
        pulumi.set(__self__, "contents", contents)
        if create_time and not isinstance(create_time, str):
            raise TypeError("Expected argument 'create_time' to be a str")
        pulumi.set(__self__, "create_time", create_time)
        if hash and not isinstance(hash, str):
            raise TypeError("Expected argument 'hash' to be a str")
        pulumi.set(__self__, "hash", hash)
        if mime_type and not isinstance(mime_type, str):
            raise TypeError("Expected argument 'mime_type' to be a str")
        pulumi.set(__self__, "mime_type", mime_type)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if size_bytes and not isinstance(size_bytes, int):
            raise TypeError("Expected argument 'size_bytes' to be a int")
        pulumi.set(__self__, "size_bytes", size_bytes)
        if update_time and not isinstance(update_time, str):
            raise TypeError("Expected argument 'update_time' to be a str")
        pulumi.set(__self__, "update_time", update_time)

    @property
    @pulumi.getter
    def contents(self) -> str:
        """
        Input only. The contents of the artifact. Provided by API callers when artifacts are created or replaced. To access the contents of an artifact, use GetArtifactContents.
        """
        return pulumi.get(self, "contents")

    @property
    @pulumi.getter(name="createTime")
    def create_time(self) -> str:
        """
        Creation timestamp.
        """
        return pulumi.get(self, "create_time")

    @property
    @pulumi.getter
    def hash(self) -> str:
        """
        A SHA-256 hash of the artifact's contents. If the artifact is gzipped, this is the hash of the uncompressed artifact.
        """
        return pulumi.get(self, "hash")

    @property
    @pulumi.getter(name="mimeType")
    def mime_type(self) -> str:
        """
        A content type specifier for the artifact. Content type specifiers are Media Types (https://en.wikipedia.org/wiki/Media_type) with a possible "schema" parameter that specifies a schema for the stored information. Content types can specify compression. Currently only GZip compression is supported (indicated with "+gzip").
        """
        return pulumi.get(self, "mime_type")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Resource name.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="sizeBytes")
    def size_bytes(self) -> int:
        """
        The size of the artifact in bytes. If the artifact is gzipped, this is the size of the uncompressed artifact.
        """
        return pulumi.get(self, "size_bytes")

    @property
    @pulumi.getter(name="updateTime")
    def update_time(self) -> str:
        """
        Last update timestamp.
        """
        return pulumi.get(self, "update_time")


class AwaitableGetDeploymentArtifactResult(GetDeploymentArtifactResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetDeploymentArtifactResult(
            contents=self.contents,
            create_time=self.create_time,
            hash=self.hash,
            mime_type=self.mime_type,
            name=self.name,
            size_bytes=self.size_bytes,
            update_time=self.update_time)


def get_deployment_artifact(api_id: Optional[str] = None,
                            artifact_id: Optional[str] = None,
                            deployment_id: Optional[str] = None,
                            location: Optional[str] = None,
                            project: Optional[str] = None,
                            opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetDeploymentArtifactResult:
    """
    GetArtifact returns a specified artifact.
    """
    __args__ = dict()
    __args__['apiId'] = api_id
    __args__['artifactId'] = artifact_id
    __args__['deploymentId'] = deployment_id
    __args__['location'] = location
    __args__['project'] = project
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('google-native:apigeeregistry/v1:getDeploymentArtifact', __args__, opts=opts, typ=GetDeploymentArtifactResult).value

    return AwaitableGetDeploymentArtifactResult(
        contents=__ret__.contents,
        create_time=__ret__.create_time,
        hash=__ret__.hash,
        mime_type=__ret__.mime_type,
        name=__ret__.name,
        size_bytes=__ret__.size_bytes,
        update_time=__ret__.update_time)


@_utilities.lift_output_func(get_deployment_artifact)
def get_deployment_artifact_output(api_id: Optional[pulumi.Input[str]] = None,
                                   artifact_id: Optional[pulumi.Input[str]] = None,
                                   deployment_id: Optional[pulumi.Input[str]] = None,
                                   location: Optional[pulumi.Input[str]] = None,
                                   project: Optional[pulumi.Input[Optional[str]]] = None,
                                   opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetDeploymentArtifactResult]:
    """
    GetArtifact returns a specified artifact.
    """
    ...