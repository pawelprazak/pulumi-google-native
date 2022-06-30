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
from ._inputs import *

__all__ = ['BackupPlanArgs', 'BackupPlan']

@pulumi.input_type
class BackupPlanArgs:
    def __init__(__self__, *,
                 backup_plan_id: pulumi.Input[str],
                 cluster: pulumi.Input[str],
                 backup_config: Optional[pulumi.Input['BackupConfigArgs']] = None,
                 backup_schedule: Optional[pulumi.Input['ScheduleArgs']] = None,
                 deactivated: Optional[pulumi.Input[bool]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 project: Optional[pulumi.Input[str]] = None,
                 retention_policy: Optional[pulumi.Input['RetentionPolicyArgs']] = None):
        """
        The set of arguments for constructing a BackupPlan resource.
        :param pulumi.Input[str] backup_plan_id: Required. The client-provided short name for the BackupPlan resource. This name must: - be between 1 and 63 characters long (inclusive) - consist of only lower-case ASCII letters, numbers, and dashes - start with a lower-case letter - end with a lower-case letter or number - be unique within the set of BackupPlans in this location
        :param pulumi.Input[str] cluster: Immutable. The source cluster from which Backups will be created via this BackupPlan. Valid formats: - projects/*/locations/*/clusters/* - projects/*/zones/*/clusters/*
        :param pulumi.Input['BackupConfigArgs'] backup_config: Defines the configuration of Backups created via this BackupPlan.
        :param pulumi.Input['ScheduleArgs'] backup_schedule: Defines a schedule for automatic Backup creation via this BackupPlan.
        :param pulumi.Input[bool] deactivated: This flag indicates whether this BackupPlan has been deactivated. Setting this field to True locks the BackupPlan such that no further updates will be allowed (except deletes), including the deactivated field itself. It also prevents any new Backups from being created via this BackupPlan (including scheduled Backups). Default: False
        :param pulumi.Input[str] description: User specified descriptive string for this BackupPlan.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] labels: A set of custom labels supplied by user.
        :param pulumi.Input['RetentionPolicyArgs'] retention_policy: RetentionPolicy governs lifecycle of Backups created under this plan.
        """
        pulumi.set(__self__, "backup_plan_id", backup_plan_id)
        pulumi.set(__self__, "cluster", cluster)
        if backup_config is not None:
            pulumi.set(__self__, "backup_config", backup_config)
        if backup_schedule is not None:
            pulumi.set(__self__, "backup_schedule", backup_schedule)
        if deactivated is not None:
            pulumi.set(__self__, "deactivated", deactivated)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if labels is not None:
            pulumi.set(__self__, "labels", labels)
        if location is not None:
            pulumi.set(__self__, "location", location)
        if project is not None:
            pulumi.set(__self__, "project", project)
        if retention_policy is not None:
            pulumi.set(__self__, "retention_policy", retention_policy)

    @property
    @pulumi.getter(name="backupPlanId")
    def backup_plan_id(self) -> pulumi.Input[str]:
        """
        Required. The client-provided short name for the BackupPlan resource. This name must: - be between 1 and 63 characters long (inclusive) - consist of only lower-case ASCII letters, numbers, and dashes - start with a lower-case letter - end with a lower-case letter or number - be unique within the set of BackupPlans in this location
        """
        return pulumi.get(self, "backup_plan_id")

    @backup_plan_id.setter
    def backup_plan_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "backup_plan_id", value)

    @property
    @pulumi.getter
    def cluster(self) -> pulumi.Input[str]:
        """
        Immutable. The source cluster from which Backups will be created via this BackupPlan. Valid formats: - projects/*/locations/*/clusters/* - projects/*/zones/*/clusters/*
        """
        return pulumi.get(self, "cluster")

    @cluster.setter
    def cluster(self, value: pulumi.Input[str]):
        pulumi.set(self, "cluster", value)

    @property
    @pulumi.getter(name="backupConfig")
    def backup_config(self) -> Optional[pulumi.Input['BackupConfigArgs']]:
        """
        Defines the configuration of Backups created via this BackupPlan.
        """
        return pulumi.get(self, "backup_config")

    @backup_config.setter
    def backup_config(self, value: Optional[pulumi.Input['BackupConfigArgs']]):
        pulumi.set(self, "backup_config", value)

    @property
    @pulumi.getter(name="backupSchedule")
    def backup_schedule(self) -> Optional[pulumi.Input['ScheduleArgs']]:
        """
        Defines a schedule for automatic Backup creation via this BackupPlan.
        """
        return pulumi.get(self, "backup_schedule")

    @backup_schedule.setter
    def backup_schedule(self, value: Optional[pulumi.Input['ScheduleArgs']]):
        pulumi.set(self, "backup_schedule", value)

    @property
    @pulumi.getter
    def deactivated(self) -> Optional[pulumi.Input[bool]]:
        """
        This flag indicates whether this BackupPlan has been deactivated. Setting this field to True locks the BackupPlan such that no further updates will be allowed (except deletes), including the deactivated field itself. It also prevents any new Backups from being created via this BackupPlan (including scheduled Backups). Default: False
        """
        return pulumi.get(self, "deactivated")

    @deactivated.setter
    def deactivated(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "deactivated", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        User specified descriptive string for this BackupPlan.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter
    def labels(self) -> Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]:
        """
        A set of custom labels supplied by user.
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
    @pulumi.getter(name="retentionPolicy")
    def retention_policy(self) -> Optional[pulumi.Input['RetentionPolicyArgs']]:
        """
        RetentionPolicy governs lifecycle of Backups created under this plan.
        """
        return pulumi.get(self, "retention_policy")

    @retention_policy.setter
    def retention_policy(self, value: Optional[pulumi.Input['RetentionPolicyArgs']]):
        pulumi.set(self, "retention_policy", value)


class BackupPlan(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 backup_config: Optional[pulumi.Input[pulumi.InputType['BackupConfigArgs']]] = None,
                 backup_plan_id: Optional[pulumi.Input[str]] = None,
                 backup_schedule: Optional[pulumi.Input[pulumi.InputType['ScheduleArgs']]] = None,
                 cluster: Optional[pulumi.Input[str]] = None,
                 deactivated: Optional[pulumi.Input[bool]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 project: Optional[pulumi.Input[str]] = None,
                 retention_policy: Optional[pulumi.Input[pulumi.InputType['RetentionPolicyArgs']]] = None,
                 __props__=None):
        """
        Creates a new BackupPlan in a given location.
        Auto-naming is currently not supported for this resource.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[pulumi.InputType['BackupConfigArgs']] backup_config: Defines the configuration of Backups created via this BackupPlan.
        :param pulumi.Input[str] backup_plan_id: Required. The client-provided short name for the BackupPlan resource. This name must: - be between 1 and 63 characters long (inclusive) - consist of only lower-case ASCII letters, numbers, and dashes - start with a lower-case letter - end with a lower-case letter or number - be unique within the set of BackupPlans in this location
        :param pulumi.Input[pulumi.InputType['ScheduleArgs']] backup_schedule: Defines a schedule for automatic Backup creation via this BackupPlan.
        :param pulumi.Input[str] cluster: Immutable. The source cluster from which Backups will be created via this BackupPlan. Valid formats: - projects/*/locations/*/clusters/* - projects/*/zones/*/clusters/*
        :param pulumi.Input[bool] deactivated: This flag indicates whether this BackupPlan has been deactivated. Setting this field to True locks the BackupPlan such that no further updates will be allowed (except deletes), including the deactivated field itself. It also prevents any new Backups from being created via this BackupPlan (including scheduled Backups). Default: False
        :param pulumi.Input[str] description: User specified descriptive string for this BackupPlan.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] labels: A set of custom labels supplied by user.
        :param pulumi.Input[pulumi.InputType['RetentionPolicyArgs']] retention_policy: RetentionPolicy governs lifecycle of Backups created under this plan.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: BackupPlanArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Creates a new BackupPlan in a given location.
        Auto-naming is currently not supported for this resource.

        :param str resource_name: The name of the resource.
        :param BackupPlanArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(BackupPlanArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 backup_config: Optional[pulumi.Input[pulumi.InputType['BackupConfigArgs']]] = None,
                 backup_plan_id: Optional[pulumi.Input[str]] = None,
                 backup_schedule: Optional[pulumi.Input[pulumi.InputType['ScheduleArgs']]] = None,
                 cluster: Optional[pulumi.Input[str]] = None,
                 deactivated: Optional[pulumi.Input[bool]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 project: Optional[pulumi.Input[str]] = None,
                 retention_policy: Optional[pulumi.Input[pulumi.InputType['RetentionPolicyArgs']]] = None,
                 __props__=None):
        if opts is None:
            opts = pulumi.ResourceOptions()
        else:
            opts = copy.copy(opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = BackupPlanArgs.__new__(BackupPlanArgs)

            __props__.__dict__["backup_config"] = backup_config
            if backup_plan_id is None and not opts.urn:
                raise TypeError("Missing required property 'backup_plan_id'")
            __props__.__dict__["backup_plan_id"] = backup_plan_id
            __props__.__dict__["backup_schedule"] = backup_schedule
            if cluster is None and not opts.urn:
                raise TypeError("Missing required property 'cluster'")
            __props__.__dict__["cluster"] = cluster
            __props__.__dict__["deactivated"] = deactivated
            __props__.__dict__["description"] = description
            __props__.__dict__["labels"] = labels
            __props__.__dict__["location"] = location
            __props__.__dict__["project"] = project
            __props__.__dict__["retention_policy"] = retention_policy
            __props__.__dict__["create_time"] = None
            __props__.__dict__["etag"] = None
            __props__.__dict__["name"] = None
            __props__.__dict__["protected_pod_count"] = None
            __props__.__dict__["uid"] = None
            __props__.__dict__["update_time"] = None
        super(BackupPlan, __self__).__init__(
            'google-native:gkebackup/v1:BackupPlan',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'BackupPlan':
        """
        Get an existing BackupPlan resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = BackupPlanArgs.__new__(BackupPlanArgs)

        __props__.__dict__["backup_config"] = None
        __props__.__dict__["backup_plan_id"] = None
        __props__.__dict__["backup_schedule"] = None
        __props__.__dict__["cluster"] = None
        __props__.__dict__["create_time"] = None
        __props__.__dict__["deactivated"] = None
        __props__.__dict__["description"] = None
        __props__.__dict__["etag"] = None
        __props__.__dict__["labels"] = None
        __props__.__dict__["location"] = None
        __props__.__dict__["name"] = None
        __props__.__dict__["project"] = None
        __props__.__dict__["protected_pod_count"] = None
        __props__.__dict__["retention_policy"] = None
        __props__.__dict__["uid"] = None
        __props__.__dict__["update_time"] = None
        return BackupPlan(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="backupConfig")
    def backup_config(self) -> pulumi.Output['outputs.BackupConfigResponse']:
        """
        Defines the configuration of Backups created via this BackupPlan.
        """
        return pulumi.get(self, "backup_config")

    @property
    @pulumi.getter(name="backupPlanId")
    def backup_plan_id(self) -> pulumi.Output[str]:
        """
        Required. The client-provided short name for the BackupPlan resource. This name must: - be between 1 and 63 characters long (inclusive) - consist of only lower-case ASCII letters, numbers, and dashes - start with a lower-case letter - end with a lower-case letter or number - be unique within the set of BackupPlans in this location
        """
        return pulumi.get(self, "backup_plan_id")

    @property
    @pulumi.getter(name="backupSchedule")
    def backup_schedule(self) -> pulumi.Output['outputs.ScheduleResponse']:
        """
        Defines a schedule for automatic Backup creation via this BackupPlan.
        """
        return pulumi.get(self, "backup_schedule")

    @property
    @pulumi.getter
    def cluster(self) -> pulumi.Output[str]:
        """
        Immutable. The source cluster from which Backups will be created via this BackupPlan. Valid formats: - projects/*/locations/*/clusters/* - projects/*/zones/*/clusters/*
        """
        return pulumi.get(self, "cluster")

    @property
    @pulumi.getter(name="createTime")
    def create_time(self) -> pulumi.Output[str]:
        """
        The timestamp when this BackupPlan resource was created.
        """
        return pulumi.get(self, "create_time")

    @property
    @pulumi.getter
    def deactivated(self) -> pulumi.Output[bool]:
        """
        This flag indicates whether this BackupPlan has been deactivated. Setting this field to True locks the BackupPlan such that no further updates will be allowed (except deletes), including the deactivated field itself. It also prevents any new Backups from being created via this BackupPlan (including scheduled Backups). Default: False
        """
        return pulumi.get(self, "deactivated")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[str]:
        """
        User specified descriptive string for this BackupPlan.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def etag(self) -> pulumi.Output[str]:
        """
        `etag` is used for optimistic concurrency control as a way to help prevent simultaneous updates of a backup plan from overwriting each other. It is strongly suggested that systems make use of the 'etag' in the read-modify-write cycle to perform BackupPlan updates in order to avoid race conditions: An `etag` is returned in the response to `GetBackupPlan`, and systems are expected to put that etag in the request to `UpdateBackupPlan` or `DeleteBackupPlan` to ensure that their change will be applied to the same version of the resource.
        """
        return pulumi.get(self, "etag")

    @property
    @pulumi.getter
    def labels(self) -> pulumi.Output[Mapping[str, str]]:
        """
        A set of custom labels supplied by user.
        """
        return pulumi.get(self, "labels")

    @property
    @pulumi.getter
    def location(self) -> pulumi.Output[str]:
        return pulumi.get(self, "location")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        The full name of the BackupPlan resource. Format: projects/*/locations/*/backupPlans/*
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def project(self) -> pulumi.Output[str]:
        return pulumi.get(self, "project")

    @property
    @pulumi.getter(name="protectedPodCount")
    def protected_pod_count(self) -> pulumi.Output[int]:
        """
        The number of Kubernetes Pods backed up in the last successful Backup created via this BackupPlan.
        """
        return pulumi.get(self, "protected_pod_count")

    @property
    @pulumi.getter(name="retentionPolicy")
    def retention_policy(self) -> pulumi.Output['outputs.RetentionPolicyResponse']:
        """
        RetentionPolicy governs lifecycle of Backups created under this plan.
        """
        return pulumi.get(self, "retention_policy")

    @property
    @pulumi.getter
    def uid(self) -> pulumi.Output[str]:
        """
        Server generated global unique identifier of [UUID](https://en.wikipedia.org/wiki/Universally_unique_identifier) format.
        """
        return pulumi.get(self, "uid")

    @property
    @pulumi.getter(name="updateTime")
    def update_time(self) -> pulumi.Output[str]:
        """
        The timestamp when this BackupPlan resource was last updated.
        """
        return pulumi.get(self, "update_time")
