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
    'GetGameServerDeploymentResult',
    'AwaitableGetGameServerDeploymentResult',
    'get_game_server_deployment',
    'get_game_server_deployment_output',
]

@pulumi.output_type
class GetGameServerDeploymentResult:
    def __init__(__self__, create_time=None, description=None, etag=None, labels=None, name=None, update_time=None):
        if create_time and not isinstance(create_time, str):
            raise TypeError("Expected argument 'create_time' to be a str")
        pulumi.set(__self__, "create_time", create_time)
        if description and not isinstance(description, str):
            raise TypeError("Expected argument 'description' to be a str")
        pulumi.set(__self__, "description", description)
        if etag and not isinstance(etag, str):
            raise TypeError("Expected argument 'etag' to be a str")
        pulumi.set(__self__, "etag", etag)
        if labels and not isinstance(labels, dict):
            raise TypeError("Expected argument 'labels' to be a dict")
        pulumi.set(__self__, "labels", labels)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if update_time and not isinstance(update_time, str):
            raise TypeError("Expected argument 'update_time' to be a str")
        pulumi.set(__self__, "update_time", update_time)

    @property
    @pulumi.getter(name="createTime")
    def create_time(self) -> str:
        """
        The creation time.
        """
        return pulumi.get(self, "create_time")

    @property
    @pulumi.getter
    def description(self) -> str:
        """
        Human readable description of the game server deployment.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def etag(self) -> str:
        """
        Used to perform consistent read-modify-write updates. If not set, a blind "overwrite" update happens.
        """
        return pulumi.get(self, "etag")

    @property
    @pulumi.getter
    def labels(self) -> Mapping[str, str]:
        """
        The labels associated with this game server deployment. Each label is a key-value pair.
        """
        return pulumi.get(self, "labels")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        The resource name of the game server deployment, in the following form: `projects/{project}/locations/{locationId}/gameServerDeployments/{deploymentId}`. For example, `projects/my-project/locations/global/gameServerDeployments/my-deployment`.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="updateTime")
    def update_time(self) -> str:
        """
        The last-modified time.
        """
        return pulumi.get(self, "update_time")


class AwaitableGetGameServerDeploymentResult(GetGameServerDeploymentResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetGameServerDeploymentResult(
            create_time=self.create_time,
            description=self.description,
            etag=self.etag,
            labels=self.labels,
            name=self.name,
            update_time=self.update_time)


def get_game_server_deployment(game_server_deployment_id: Optional[str] = None,
                               location: Optional[str] = None,
                               project: Optional[str] = None,
                               opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetGameServerDeploymentResult:
    """
    Gets details of a single game server deployment.
    """
    __args__ = dict()
    __args__['gameServerDeploymentId'] = game_server_deployment_id
    __args__['location'] = location
    __args__['project'] = project
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('google-native:gameservices/v1:getGameServerDeployment', __args__, opts=opts, typ=GetGameServerDeploymentResult).value

    return AwaitableGetGameServerDeploymentResult(
        create_time=__ret__.create_time,
        description=__ret__.description,
        etag=__ret__.etag,
        labels=__ret__.labels,
        name=__ret__.name,
        update_time=__ret__.update_time)


@_utilities.lift_output_func(get_game_server_deployment)
def get_game_server_deployment_output(game_server_deployment_id: Optional[pulumi.Input[str]] = None,
                                      location: Optional[pulumi.Input[str]] = None,
                                      project: Optional[pulumi.Input[Optional[str]]] = None,
                                      opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetGameServerDeploymentResult]:
    """
    Gets details of a single game server deployment.
    """
    ...
