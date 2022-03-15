# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from ... import _utilities
from . import outputs

__all__ = [
    'GetIssueModelResult',
    'AwaitableGetIssueModelResult',
    'get_issue_model',
    'get_issue_model_output',
]

@pulumi.output_type
class GetIssueModelResult:
    def __init__(__self__, create_time=None, display_name=None, input_data_config=None, name=None, state=None, training_stats=None, update_time=None):
        if create_time and not isinstance(create_time, str):
            raise TypeError("Expected argument 'create_time' to be a str")
        pulumi.set(__self__, "create_time", create_time)
        if display_name and not isinstance(display_name, str):
            raise TypeError("Expected argument 'display_name' to be a str")
        pulumi.set(__self__, "display_name", display_name)
        if input_data_config and not isinstance(input_data_config, dict):
            raise TypeError("Expected argument 'input_data_config' to be a dict")
        pulumi.set(__self__, "input_data_config", input_data_config)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if state and not isinstance(state, str):
            raise TypeError("Expected argument 'state' to be a str")
        pulumi.set(__self__, "state", state)
        if training_stats and not isinstance(training_stats, dict):
            raise TypeError("Expected argument 'training_stats' to be a dict")
        pulumi.set(__self__, "training_stats", training_stats)
        if update_time and not isinstance(update_time, str):
            raise TypeError("Expected argument 'update_time' to be a str")
        pulumi.set(__self__, "update_time", update_time)

    @property
    @pulumi.getter(name="createTime")
    def create_time(self) -> str:
        """
        The time at which this issue model was created.
        """
        return pulumi.get(self, "create_time")

    @property
    @pulumi.getter(name="displayName")
    def display_name(self) -> str:
        """
        The representative name for the issue model.
        """
        return pulumi.get(self, "display_name")

    @property
    @pulumi.getter(name="inputDataConfig")
    def input_data_config(self) -> 'outputs.GoogleCloudContactcenterinsightsV1IssueModelInputDataConfigResponse':
        """
        Configs for the input data that used to create the issue model.
        """
        return pulumi.get(self, "input_data_config")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Immutable. The resource name of the issue model. Format: projects/{project}/locations/{location}/issueModels/{issue_model}
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def state(self) -> str:
        """
        State of the model.
        """
        return pulumi.get(self, "state")

    @property
    @pulumi.getter(name="trainingStats")
    def training_stats(self) -> 'outputs.GoogleCloudContactcenterinsightsV1IssueModelLabelStatsResponse':
        """
        Immutable. The issue model's label statistics on its training data.
        """
        return pulumi.get(self, "training_stats")

    @property
    @pulumi.getter(name="updateTime")
    def update_time(self) -> str:
        """
        The most recent time at which the issue model was updated.
        """
        return pulumi.get(self, "update_time")


class AwaitableGetIssueModelResult(GetIssueModelResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetIssueModelResult(
            create_time=self.create_time,
            display_name=self.display_name,
            input_data_config=self.input_data_config,
            name=self.name,
            state=self.state,
            training_stats=self.training_stats,
            update_time=self.update_time)


def get_issue_model(issue_model_id: Optional[str] = None,
                    location: Optional[str] = None,
                    project: Optional[str] = None,
                    opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetIssueModelResult:
    """
    Gets an issue model.
    """
    __args__ = dict()
    __args__['issueModelId'] = issue_model_id
    __args__['location'] = location
    __args__['project'] = project
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('google-native:contactcenterinsights/v1:getIssueModel', __args__, opts=opts, typ=GetIssueModelResult).value

    return AwaitableGetIssueModelResult(
        create_time=__ret__.create_time,
        display_name=__ret__.display_name,
        input_data_config=__ret__.input_data_config,
        name=__ret__.name,
        state=__ret__.state,
        training_stats=__ret__.training_stats,
        update_time=__ret__.update_time)


@_utilities.lift_output_func(get_issue_model)
def get_issue_model_output(issue_model_id: Optional[pulumi.Input[str]] = None,
                           location: Optional[pulumi.Input[str]] = None,
                           project: Optional[pulumi.Input[Optional[str]]] = None,
                           opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetIssueModelResult]:
    """
    Gets an issue model.
    """
    ...