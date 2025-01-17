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
from ._enums import *
from ._inputs import *

__all__ = ['JobArgs', 'Job']

@pulumi.input_type
class JobArgs:
    def __init__(__self__, *,
                 app_engine_http_target: Optional[pulumi.Input['AppEngineHttpTargetArgs']] = None,
                 attempt_deadline: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 http_target: Optional[pulumi.Input['HttpTargetArgs']] = None,
                 legacy_app_engine_cron: Optional[pulumi.Input[bool]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 project: Optional[pulumi.Input[str]] = None,
                 pubsub_target: Optional[pulumi.Input['PubsubTargetArgs']] = None,
                 retry_config: Optional[pulumi.Input['RetryConfigArgs']] = None,
                 schedule: Optional[pulumi.Input[str]] = None,
                 time_zone: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a Job resource.
        :param pulumi.Input['AppEngineHttpTargetArgs'] app_engine_http_target: App Engine HTTP target.
        :param pulumi.Input[str] attempt_deadline: The deadline for job attempts. If the request handler does not respond by this deadline then the request is cancelled and the attempt is marked as a `DEADLINE_EXCEEDED` failure. The failed attempt can be viewed in execution logs. Cloud Scheduler will retry the job according to the RetryConfig. The allowed duration for this deadline is: * For HTTP targets, between 15 seconds and 30 minutes. * For App Engine HTTP targets, between 15 seconds and 24 hours 15 seconds. * For Pub/Sub targets, this field is ignored.
        :param pulumi.Input[str] description: Optionally caller-specified in CreateJob or UpdateJob. A human-readable description for the job. This string must not contain more than 500 characters.
        :param pulumi.Input['HttpTargetArgs'] http_target: HTTP target.
        :param pulumi.Input[bool] legacy_app_engine_cron: Immutable. This field is used to manage the legacy App Engine Cron jobs using the Cloud Scheduler API. If the field is set to true, the job will be considered a legacy job. Note that App Engine Cron jobs have fewer features than Cloud Scheduler jobs, e.g., are only limited to App Engine targets.
        :param pulumi.Input[str] name: Optionally caller-specified in CreateJob, after which it becomes output only. The job name. For example: `projects/PROJECT_ID/locations/LOCATION_ID/jobs/JOB_ID`. * `PROJECT_ID` can contain letters ([A-Za-z]), numbers ([0-9]), hyphens (-), colons (:), or periods (.). For more information, see [Identifying projects](https://cloud.google.com/resource-manager/docs/creating-managing-projects#identifying_projects) * `LOCATION_ID` is the canonical ID for the job's location. The list of available locations can be obtained by calling ListLocations. For more information, see https://cloud.google.com/about/locations/. * `JOB_ID` can contain only letters ([A-Za-z]), numbers ([0-9]), hyphens (-), or underscores (_). The maximum length is 500 characters.
        :param pulumi.Input['PubsubTargetArgs'] pubsub_target: Pub/Sub target.
        :param pulumi.Input['RetryConfigArgs'] retry_config: Settings that determine the retry behavior.
        :param pulumi.Input[str] schedule: Required, except when used with UpdateJob. Describes the schedule on which the job will be executed. The schedule can be either of the following types: * [Crontab](https://en.wikipedia.org/wiki/Cron#Overview) * English-like [schedule](https://cloud.google.com/scheduler/docs/configuring/cron-job-schedules) As a general rule, execution `n + 1` of a job will not begin until execution `n` has finished. Cloud Scheduler will never allow two simultaneously outstanding executions. For example, this implies that if the `n+1`th execution is scheduled to run at 16:00 but the `n`th execution takes until 16:15, the `n+1`th execution will not start until `16:15`. A scheduled start time will be delayed if the previous execution has not ended when its scheduled time occurs. If retry_count > 0 and a job attempt fails, the job will be tried a total of retry_count times, with exponential backoff, until the next scheduled start time.
        :param pulumi.Input[str] time_zone: Specifies the time zone to be used in interpreting schedule. The value of this field must be a time zone name from the [tz database](http://en.wikipedia.org/wiki/Tz_database). Note that some time zones include a provision for daylight savings time. The rules for daylight saving time are determined by the chosen tz. For UTC use the string "utc". If a time zone is not specified, the default will be in UTC (also known as GMT).
        """
        if app_engine_http_target is not None:
            pulumi.set(__self__, "app_engine_http_target", app_engine_http_target)
        if attempt_deadline is not None:
            pulumi.set(__self__, "attempt_deadline", attempt_deadline)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if http_target is not None:
            pulumi.set(__self__, "http_target", http_target)
        if legacy_app_engine_cron is not None:
            pulumi.set(__self__, "legacy_app_engine_cron", legacy_app_engine_cron)
        if location is not None:
            pulumi.set(__self__, "location", location)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if project is not None:
            pulumi.set(__self__, "project", project)
        if pubsub_target is not None:
            pulumi.set(__self__, "pubsub_target", pubsub_target)
        if retry_config is not None:
            pulumi.set(__self__, "retry_config", retry_config)
        if schedule is not None:
            pulumi.set(__self__, "schedule", schedule)
        if time_zone is not None:
            pulumi.set(__self__, "time_zone", time_zone)

    @property
    @pulumi.getter(name="appEngineHttpTarget")
    def app_engine_http_target(self) -> Optional[pulumi.Input['AppEngineHttpTargetArgs']]:
        """
        App Engine HTTP target.
        """
        return pulumi.get(self, "app_engine_http_target")

    @app_engine_http_target.setter
    def app_engine_http_target(self, value: Optional[pulumi.Input['AppEngineHttpTargetArgs']]):
        pulumi.set(self, "app_engine_http_target", value)

    @property
    @pulumi.getter(name="attemptDeadline")
    def attempt_deadline(self) -> Optional[pulumi.Input[str]]:
        """
        The deadline for job attempts. If the request handler does not respond by this deadline then the request is cancelled and the attempt is marked as a `DEADLINE_EXCEEDED` failure. The failed attempt can be viewed in execution logs. Cloud Scheduler will retry the job according to the RetryConfig. The allowed duration for this deadline is: * For HTTP targets, between 15 seconds and 30 minutes. * For App Engine HTTP targets, between 15 seconds and 24 hours 15 seconds. * For Pub/Sub targets, this field is ignored.
        """
        return pulumi.get(self, "attempt_deadline")

    @attempt_deadline.setter
    def attempt_deadline(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "attempt_deadline", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        Optionally caller-specified in CreateJob or UpdateJob. A human-readable description for the job. This string must not contain more than 500 characters.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter(name="httpTarget")
    def http_target(self) -> Optional[pulumi.Input['HttpTargetArgs']]:
        """
        HTTP target.
        """
        return pulumi.get(self, "http_target")

    @http_target.setter
    def http_target(self, value: Optional[pulumi.Input['HttpTargetArgs']]):
        pulumi.set(self, "http_target", value)

    @property
    @pulumi.getter(name="legacyAppEngineCron")
    def legacy_app_engine_cron(self) -> Optional[pulumi.Input[bool]]:
        """
        Immutable. This field is used to manage the legacy App Engine Cron jobs using the Cloud Scheduler API. If the field is set to true, the job will be considered a legacy job. Note that App Engine Cron jobs have fewer features than Cloud Scheduler jobs, e.g., are only limited to App Engine targets.
        """
        return pulumi.get(self, "legacy_app_engine_cron")

    @legacy_app_engine_cron.setter
    def legacy_app_engine_cron(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "legacy_app_engine_cron", value)

    @property
    @pulumi.getter
    def location(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "location")

    @location.setter
    def location(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "location", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Optionally caller-specified in CreateJob, after which it becomes output only. The job name. For example: `projects/PROJECT_ID/locations/LOCATION_ID/jobs/JOB_ID`. * `PROJECT_ID` can contain letters ([A-Za-z]), numbers ([0-9]), hyphens (-), colons (:), or periods (.). For more information, see [Identifying projects](https://cloud.google.com/resource-manager/docs/creating-managing-projects#identifying_projects) * `LOCATION_ID` is the canonical ID for the job's location. The list of available locations can be obtained by calling ListLocations. For more information, see https://cloud.google.com/about/locations/. * `JOB_ID` can contain only letters ([A-Za-z]), numbers ([0-9]), hyphens (-), or underscores (_). The maximum length is 500 characters.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def project(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "project")

    @project.setter
    def project(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "project", value)

    @property
    @pulumi.getter(name="pubsubTarget")
    def pubsub_target(self) -> Optional[pulumi.Input['PubsubTargetArgs']]:
        """
        Pub/Sub target.
        """
        return pulumi.get(self, "pubsub_target")

    @pubsub_target.setter
    def pubsub_target(self, value: Optional[pulumi.Input['PubsubTargetArgs']]):
        pulumi.set(self, "pubsub_target", value)

    @property
    @pulumi.getter(name="retryConfig")
    def retry_config(self) -> Optional[pulumi.Input['RetryConfigArgs']]:
        """
        Settings that determine the retry behavior.
        """
        return pulumi.get(self, "retry_config")

    @retry_config.setter
    def retry_config(self, value: Optional[pulumi.Input['RetryConfigArgs']]):
        pulumi.set(self, "retry_config", value)

    @property
    @pulumi.getter
    def schedule(self) -> Optional[pulumi.Input[str]]:
        """
        Required, except when used with UpdateJob. Describes the schedule on which the job will be executed. The schedule can be either of the following types: * [Crontab](https://en.wikipedia.org/wiki/Cron#Overview) * English-like [schedule](https://cloud.google.com/scheduler/docs/configuring/cron-job-schedules) As a general rule, execution `n + 1` of a job will not begin until execution `n` has finished. Cloud Scheduler will never allow two simultaneously outstanding executions. For example, this implies that if the `n+1`th execution is scheduled to run at 16:00 but the `n`th execution takes until 16:15, the `n+1`th execution will not start until `16:15`. A scheduled start time will be delayed if the previous execution has not ended when its scheduled time occurs. If retry_count > 0 and a job attempt fails, the job will be tried a total of retry_count times, with exponential backoff, until the next scheduled start time.
        """
        return pulumi.get(self, "schedule")

    @schedule.setter
    def schedule(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "schedule", value)

    @property
    @pulumi.getter(name="timeZone")
    def time_zone(self) -> Optional[pulumi.Input[str]]:
        """
        Specifies the time zone to be used in interpreting schedule. The value of this field must be a time zone name from the [tz database](http://en.wikipedia.org/wiki/Tz_database). Note that some time zones include a provision for daylight savings time. The rules for daylight saving time are determined by the chosen tz. For UTC use the string "utc". If a time zone is not specified, the default will be in UTC (also known as GMT).
        """
        return pulumi.get(self, "time_zone")

    @time_zone.setter
    def time_zone(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "time_zone", value)


class Job(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 app_engine_http_target: Optional[pulumi.Input[pulumi.InputType['AppEngineHttpTargetArgs']]] = None,
                 attempt_deadline: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 http_target: Optional[pulumi.Input[pulumi.InputType['HttpTargetArgs']]] = None,
                 legacy_app_engine_cron: Optional[pulumi.Input[bool]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 project: Optional[pulumi.Input[str]] = None,
                 pubsub_target: Optional[pulumi.Input[pulumi.InputType['PubsubTargetArgs']]] = None,
                 retry_config: Optional[pulumi.Input[pulumi.InputType['RetryConfigArgs']]] = None,
                 schedule: Optional[pulumi.Input[str]] = None,
                 time_zone: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Creates a job.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[pulumi.InputType['AppEngineHttpTargetArgs']] app_engine_http_target: App Engine HTTP target.
        :param pulumi.Input[str] attempt_deadline: The deadline for job attempts. If the request handler does not respond by this deadline then the request is cancelled and the attempt is marked as a `DEADLINE_EXCEEDED` failure. The failed attempt can be viewed in execution logs. Cloud Scheduler will retry the job according to the RetryConfig. The allowed duration for this deadline is: * For HTTP targets, between 15 seconds and 30 minutes. * For App Engine HTTP targets, between 15 seconds and 24 hours 15 seconds. * For Pub/Sub targets, this field is ignored.
        :param pulumi.Input[str] description: Optionally caller-specified in CreateJob or UpdateJob. A human-readable description for the job. This string must not contain more than 500 characters.
        :param pulumi.Input[pulumi.InputType['HttpTargetArgs']] http_target: HTTP target.
        :param pulumi.Input[bool] legacy_app_engine_cron: Immutable. This field is used to manage the legacy App Engine Cron jobs using the Cloud Scheduler API. If the field is set to true, the job will be considered a legacy job. Note that App Engine Cron jobs have fewer features than Cloud Scheduler jobs, e.g., are only limited to App Engine targets.
        :param pulumi.Input[str] name: Optionally caller-specified in CreateJob, after which it becomes output only. The job name. For example: `projects/PROJECT_ID/locations/LOCATION_ID/jobs/JOB_ID`. * `PROJECT_ID` can contain letters ([A-Za-z]), numbers ([0-9]), hyphens (-), colons (:), or periods (.). For more information, see [Identifying projects](https://cloud.google.com/resource-manager/docs/creating-managing-projects#identifying_projects) * `LOCATION_ID` is the canonical ID for the job's location. The list of available locations can be obtained by calling ListLocations. For more information, see https://cloud.google.com/about/locations/. * `JOB_ID` can contain only letters ([A-Za-z]), numbers ([0-9]), hyphens (-), or underscores (_). The maximum length is 500 characters.
        :param pulumi.Input[pulumi.InputType['PubsubTargetArgs']] pubsub_target: Pub/Sub target.
        :param pulumi.Input[pulumi.InputType['RetryConfigArgs']] retry_config: Settings that determine the retry behavior.
        :param pulumi.Input[str] schedule: Required, except when used with UpdateJob. Describes the schedule on which the job will be executed. The schedule can be either of the following types: * [Crontab](https://en.wikipedia.org/wiki/Cron#Overview) * English-like [schedule](https://cloud.google.com/scheduler/docs/configuring/cron-job-schedules) As a general rule, execution `n + 1` of a job will not begin until execution `n` has finished. Cloud Scheduler will never allow two simultaneously outstanding executions. For example, this implies that if the `n+1`th execution is scheduled to run at 16:00 but the `n`th execution takes until 16:15, the `n+1`th execution will not start until `16:15`. A scheduled start time will be delayed if the previous execution has not ended when its scheduled time occurs. If retry_count > 0 and a job attempt fails, the job will be tried a total of retry_count times, with exponential backoff, until the next scheduled start time.
        :param pulumi.Input[str] time_zone: Specifies the time zone to be used in interpreting schedule. The value of this field must be a time zone name from the [tz database](http://en.wikipedia.org/wiki/Tz_database). Note that some time zones include a provision for daylight savings time. The rules for daylight saving time are determined by the chosen tz. For UTC use the string "utc". If a time zone is not specified, the default will be in UTC (also known as GMT).
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: Optional[JobArgs] = None,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Creates a job.

        :param str resource_name: The name of the resource.
        :param JobArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(JobArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 app_engine_http_target: Optional[pulumi.Input[pulumi.InputType['AppEngineHttpTargetArgs']]] = None,
                 attempt_deadline: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 http_target: Optional[pulumi.Input[pulumi.InputType['HttpTargetArgs']]] = None,
                 legacy_app_engine_cron: Optional[pulumi.Input[bool]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 project: Optional[pulumi.Input[str]] = None,
                 pubsub_target: Optional[pulumi.Input[pulumi.InputType['PubsubTargetArgs']]] = None,
                 retry_config: Optional[pulumi.Input[pulumi.InputType['RetryConfigArgs']]] = None,
                 schedule: Optional[pulumi.Input[str]] = None,
                 time_zone: Optional[pulumi.Input[str]] = None,
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
            __props__ = JobArgs.__new__(JobArgs)

            __props__.__dict__["app_engine_http_target"] = app_engine_http_target
            __props__.__dict__["attempt_deadline"] = attempt_deadline
            __props__.__dict__["description"] = description
            __props__.__dict__["http_target"] = http_target
            __props__.__dict__["legacy_app_engine_cron"] = legacy_app_engine_cron
            __props__.__dict__["location"] = location
            __props__.__dict__["name"] = name
            __props__.__dict__["project"] = project
            __props__.__dict__["pubsub_target"] = pubsub_target
            __props__.__dict__["retry_config"] = retry_config
            __props__.__dict__["schedule"] = schedule
            __props__.__dict__["time_zone"] = time_zone
            __props__.__dict__["last_attempt_time"] = None
            __props__.__dict__["schedule_time"] = None
            __props__.__dict__["state"] = None
            __props__.__dict__["status"] = None
            __props__.__dict__["user_update_time"] = None
        super(Job, __self__).__init__(
            'google-native:cloudscheduler/v1beta1:Job',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'Job':
        """
        Get an existing Job resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = JobArgs.__new__(JobArgs)

        __props__.__dict__["app_engine_http_target"] = None
        __props__.__dict__["attempt_deadline"] = None
        __props__.__dict__["description"] = None
        __props__.__dict__["http_target"] = None
        __props__.__dict__["last_attempt_time"] = None
        __props__.__dict__["legacy_app_engine_cron"] = None
        __props__.__dict__["location"] = None
        __props__.__dict__["name"] = None
        __props__.__dict__["project"] = None
        __props__.__dict__["pubsub_target"] = None
        __props__.__dict__["retry_config"] = None
        __props__.__dict__["schedule"] = None
        __props__.__dict__["schedule_time"] = None
        __props__.__dict__["state"] = None
        __props__.__dict__["status"] = None
        __props__.__dict__["time_zone"] = None
        __props__.__dict__["user_update_time"] = None
        return Job(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="appEngineHttpTarget")
    def app_engine_http_target(self) -> pulumi.Output['outputs.AppEngineHttpTargetResponse']:
        """
        App Engine HTTP target.
        """
        return pulumi.get(self, "app_engine_http_target")

    @property
    @pulumi.getter(name="attemptDeadline")
    def attempt_deadline(self) -> pulumi.Output[str]:
        """
        The deadline for job attempts. If the request handler does not respond by this deadline then the request is cancelled and the attempt is marked as a `DEADLINE_EXCEEDED` failure. The failed attempt can be viewed in execution logs. Cloud Scheduler will retry the job according to the RetryConfig. The allowed duration for this deadline is: * For HTTP targets, between 15 seconds and 30 minutes. * For App Engine HTTP targets, between 15 seconds and 24 hours 15 seconds. * For Pub/Sub targets, this field is ignored.
        """
        return pulumi.get(self, "attempt_deadline")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[str]:
        """
        Optionally caller-specified in CreateJob or UpdateJob. A human-readable description for the job. This string must not contain more than 500 characters.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="httpTarget")
    def http_target(self) -> pulumi.Output['outputs.HttpTargetResponse']:
        """
        HTTP target.
        """
        return pulumi.get(self, "http_target")

    @property
    @pulumi.getter(name="lastAttemptTime")
    def last_attempt_time(self) -> pulumi.Output[str]:
        """
        The time the last job attempt started.
        """
        return pulumi.get(self, "last_attempt_time")

    @property
    @pulumi.getter(name="legacyAppEngineCron")
    def legacy_app_engine_cron(self) -> pulumi.Output[bool]:
        """
        Immutable. This field is used to manage the legacy App Engine Cron jobs using the Cloud Scheduler API. If the field is set to true, the job will be considered a legacy job. Note that App Engine Cron jobs have fewer features than Cloud Scheduler jobs, e.g., are only limited to App Engine targets.
        """
        return pulumi.get(self, "legacy_app_engine_cron")

    @property
    @pulumi.getter
    def location(self) -> pulumi.Output[str]:
        return pulumi.get(self, "location")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Optionally caller-specified in CreateJob, after which it becomes output only. The job name. For example: `projects/PROJECT_ID/locations/LOCATION_ID/jobs/JOB_ID`. * `PROJECT_ID` can contain letters ([A-Za-z]), numbers ([0-9]), hyphens (-), colons (:), or periods (.). For more information, see [Identifying projects](https://cloud.google.com/resource-manager/docs/creating-managing-projects#identifying_projects) * `LOCATION_ID` is the canonical ID for the job's location. The list of available locations can be obtained by calling ListLocations. For more information, see https://cloud.google.com/about/locations/. * `JOB_ID` can contain only letters ([A-Za-z]), numbers ([0-9]), hyphens (-), or underscores (_). The maximum length is 500 characters.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def project(self) -> pulumi.Output[str]:
        return pulumi.get(self, "project")

    @property
    @pulumi.getter(name="pubsubTarget")
    def pubsub_target(self) -> pulumi.Output['outputs.PubsubTargetResponse']:
        """
        Pub/Sub target.
        """
        return pulumi.get(self, "pubsub_target")

    @property
    @pulumi.getter(name="retryConfig")
    def retry_config(self) -> pulumi.Output['outputs.RetryConfigResponse']:
        """
        Settings that determine the retry behavior.
        """
        return pulumi.get(self, "retry_config")

    @property
    @pulumi.getter
    def schedule(self) -> pulumi.Output[str]:
        """
        Required, except when used with UpdateJob. Describes the schedule on which the job will be executed. The schedule can be either of the following types: * [Crontab](https://en.wikipedia.org/wiki/Cron#Overview) * English-like [schedule](https://cloud.google.com/scheduler/docs/configuring/cron-job-schedules) As a general rule, execution `n + 1` of a job will not begin until execution `n` has finished. Cloud Scheduler will never allow two simultaneously outstanding executions. For example, this implies that if the `n+1`th execution is scheduled to run at 16:00 but the `n`th execution takes until 16:15, the `n+1`th execution will not start until `16:15`. A scheduled start time will be delayed if the previous execution has not ended when its scheduled time occurs. If retry_count > 0 and a job attempt fails, the job will be tried a total of retry_count times, with exponential backoff, until the next scheduled start time.
        """
        return pulumi.get(self, "schedule")

    @property
    @pulumi.getter(name="scheduleTime")
    def schedule_time(self) -> pulumi.Output[str]:
        """
        The next time the job is scheduled. Note that this may be a retry of a previously failed attempt or the next execution time according to the schedule.
        """
        return pulumi.get(self, "schedule_time")

    @property
    @pulumi.getter
    def state(self) -> pulumi.Output[str]:
        """
        State of the job.
        """
        return pulumi.get(self, "state")

    @property
    @pulumi.getter
    def status(self) -> pulumi.Output['outputs.StatusResponse']:
        """
        The response from the target for the last attempted execution.
        """
        return pulumi.get(self, "status")

    @property
    @pulumi.getter(name="timeZone")
    def time_zone(self) -> pulumi.Output[str]:
        """
        Specifies the time zone to be used in interpreting schedule. The value of this field must be a time zone name from the [tz database](http://en.wikipedia.org/wiki/Tz_database). Note that some time zones include a provision for daylight savings time. The rules for daylight saving time are determined by the chosen tz. For UTC use the string "utc". If a time zone is not specified, the default will be in UTC (also known as GMT).
        """
        return pulumi.get(self, "time_zone")

    @property
    @pulumi.getter(name="userUpdateTime")
    def user_update_time(self) -> pulumi.Output[str]:
        """
        The creation time of the job.
        """
        return pulumi.get(self, "user_update_time")

