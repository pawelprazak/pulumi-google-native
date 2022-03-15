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
    'GetOsPolicyAssignmentResult',
    'AwaitableGetOsPolicyAssignmentResult',
    'get_os_policy_assignment',
    'get_os_policy_assignment_output',
]

@pulumi.output_type
class GetOsPolicyAssignmentResult:
    def __init__(__self__, baseline=None, deleted=None, description=None, etag=None, instance_filter=None, name=None, os_policies=None, reconciling=None, revision_create_time=None, revision_id=None, rollout=None, rollout_state=None, uid=None):
        if baseline and not isinstance(baseline, bool):
            raise TypeError("Expected argument 'baseline' to be a bool")
        pulumi.set(__self__, "baseline", baseline)
        if deleted and not isinstance(deleted, bool):
            raise TypeError("Expected argument 'deleted' to be a bool")
        pulumi.set(__self__, "deleted", deleted)
        if description and not isinstance(description, str):
            raise TypeError("Expected argument 'description' to be a str")
        pulumi.set(__self__, "description", description)
        if etag and not isinstance(etag, str):
            raise TypeError("Expected argument 'etag' to be a str")
        pulumi.set(__self__, "etag", etag)
        if instance_filter and not isinstance(instance_filter, dict):
            raise TypeError("Expected argument 'instance_filter' to be a dict")
        pulumi.set(__self__, "instance_filter", instance_filter)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if os_policies and not isinstance(os_policies, list):
            raise TypeError("Expected argument 'os_policies' to be a list")
        pulumi.set(__self__, "os_policies", os_policies)
        if reconciling and not isinstance(reconciling, bool):
            raise TypeError("Expected argument 'reconciling' to be a bool")
        pulumi.set(__self__, "reconciling", reconciling)
        if revision_create_time and not isinstance(revision_create_time, str):
            raise TypeError("Expected argument 'revision_create_time' to be a str")
        pulumi.set(__self__, "revision_create_time", revision_create_time)
        if revision_id and not isinstance(revision_id, str):
            raise TypeError("Expected argument 'revision_id' to be a str")
        pulumi.set(__self__, "revision_id", revision_id)
        if rollout and not isinstance(rollout, dict):
            raise TypeError("Expected argument 'rollout' to be a dict")
        pulumi.set(__self__, "rollout", rollout)
        if rollout_state and not isinstance(rollout_state, str):
            raise TypeError("Expected argument 'rollout_state' to be a str")
        pulumi.set(__self__, "rollout_state", rollout_state)
        if uid and not isinstance(uid, str):
            raise TypeError("Expected argument 'uid' to be a str")
        pulumi.set(__self__, "uid", uid)

    @property
    @pulumi.getter
    def baseline(self) -> bool:
        """
        Indicates that this revision has been successfully rolled out in this zone and new VMs will be assigned OS policies from this revision. For a given OS policy assignment, there is only one revision with a value of `true` for this field.
        """
        return pulumi.get(self, "baseline")

    @property
    @pulumi.getter
    def deleted(self) -> bool:
        """
        Indicates that this revision deletes the OS policy assignment.
        """
        return pulumi.get(self, "deleted")

    @property
    @pulumi.getter
    def description(self) -> str:
        """
        OS policy assignment description. Length of the description is limited to 1024 characters.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def etag(self) -> str:
        """
        The etag for this OS policy assignment. If this is provided on update, it must match the server's etag.
        """
        return pulumi.get(self, "etag")

    @property
    @pulumi.getter(name="instanceFilter")
    def instance_filter(self) -> 'outputs.OSPolicyAssignmentInstanceFilterResponse':
        """
        Filter to select VMs.
        """
        return pulumi.get(self, "instance_filter")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Resource name. Format: `projects/{project_number}/locations/{location}/osPolicyAssignments/{os_policy_assignment_id}` This field is ignored when you create an OS policy assignment.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="osPolicies")
    def os_policies(self) -> Sequence['outputs.OSPolicyResponse']:
        """
        List of OS policies to be applied to the VMs.
        """
        return pulumi.get(self, "os_policies")

    @property
    @pulumi.getter
    def reconciling(self) -> bool:
        """
        Indicates that reconciliation is in progress for the revision. This value is `true` when the `rollout_state` is one of: * IN_PROGRESS * CANCELLING
        """
        return pulumi.get(self, "reconciling")

    @property
    @pulumi.getter(name="revisionCreateTime")
    def revision_create_time(self) -> str:
        """
        The timestamp that the revision was created.
        """
        return pulumi.get(self, "revision_create_time")

    @property
    @pulumi.getter(name="revisionId")
    def revision_id(self) -> str:
        """
        The assignment revision ID A new revision is committed whenever a rollout is triggered for a OS policy assignment
        """
        return pulumi.get(self, "revision_id")

    @property
    @pulumi.getter
    def rollout(self) -> 'outputs.OSPolicyAssignmentRolloutResponse':
        """
        Rollout to deploy the OS policy assignment. A rollout is triggered in the following situations: 1) OSPolicyAssignment is created. 2) OSPolicyAssignment is updated and the update contains changes to one of the following fields: - instance_filter - os_policies 3) OSPolicyAssignment is deleted.
        """
        return pulumi.get(self, "rollout")

    @property
    @pulumi.getter(name="rolloutState")
    def rollout_state(self) -> str:
        """
        OS policy assignment rollout state
        """
        return pulumi.get(self, "rollout_state")

    @property
    @pulumi.getter
    def uid(self) -> str:
        """
        Server generated unique id for the OS policy assignment resource.
        """
        return pulumi.get(self, "uid")


class AwaitableGetOsPolicyAssignmentResult(GetOsPolicyAssignmentResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetOsPolicyAssignmentResult(
            baseline=self.baseline,
            deleted=self.deleted,
            description=self.description,
            etag=self.etag,
            instance_filter=self.instance_filter,
            name=self.name,
            os_policies=self.os_policies,
            reconciling=self.reconciling,
            revision_create_time=self.revision_create_time,
            revision_id=self.revision_id,
            rollout=self.rollout,
            rollout_state=self.rollout_state,
            uid=self.uid)


def get_os_policy_assignment(location: Optional[str] = None,
                             os_policy_assignment_id: Optional[str] = None,
                             project: Optional[str] = None,
                             opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetOsPolicyAssignmentResult:
    """
    Retrieve an existing OS policy assignment. This method always returns the latest revision. In order to retrieve a previous revision of the assignment, also provide the revision ID in the `name` parameter.
    """
    __args__ = dict()
    __args__['location'] = location
    __args__['osPolicyAssignmentId'] = os_policy_assignment_id
    __args__['project'] = project
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('google-native:osconfig/v1alpha:getOsPolicyAssignment', __args__, opts=opts, typ=GetOsPolicyAssignmentResult).value

    return AwaitableGetOsPolicyAssignmentResult(
        baseline=__ret__.baseline,
        deleted=__ret__.deleted,
        description=__ret__.description,
        etag=__ret__.etag,
        instance_filter=__ret__.instance_filter,
        name=__ret__.name,
        os_policies=__ret__.os_policies,
        reconciling=__ret__.reconciling,
        revision_create_time=__ret__.revision_create_time,
        revision_id=__ret__.revision_id,
        rollout=__ret__.rollout,
        rollout_state=__ret__.rollout_state,
        uid=__ret__.uid)


@_utilities.lift_output_func(get_os_policy_assignment)
def get_os_policy_assignment_output(location: Optional[pulumi.Input[str]] = None,
                                    os_policy_assignment_id: Optional[pulumi.Input[str]] = None,
                                    project: Optional[pulumi.Input[Optional[str]]] = None,
                                    opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetOsPolicyAssignmentResult]:
    """
    Retrieve an existing OS policy assignment. This method always returns the latest revision. In order to retrieve a previous revision of the assignment, also provide the revision ID in the `name` parameter.
    """
    ...