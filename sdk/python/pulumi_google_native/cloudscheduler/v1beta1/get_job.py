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
    'GetJobResult',
    'AwaitableGetJobResult',
    'get_job',
    'get_job_output',
]

@pulumi.output_type
class GetJobResult:
    def __init__(__self__, app_engine_http_target=None, attempt_deadline=None, description=None, http_target=None, last_attempt_time=None, legacy_app_engine_cron=None, name=None, pubsub_target=None, retry_config=None, schedule=None, schedule_time=None, state=None, status=None, time_zone=None, user_update_time=None):
        if app_engine_http_target and not isinstance(app_engine_http_target, dict):
            raise TypeError("Expected argument 'app_engine_http_target' to be a dict")
        pulumi.set(__self__, "app_engine_http_target", app_engine_http_target)
        if attempt_deadline and not isinstance(attempt_deadline, str):
            raise TypeError("Expected argument 'attempt_deadline' to be a str")
        pulumi.set(__self__, "attempt_deadline", attempt_deadline)
        if description and not isinstance(description, str):
            raise TypeError("Expected argument 'description' to be a str")
        pulumi.set(__self__, "description", description)
        if http_target and not isinstance(http_target, dict):
            raise TypeError("Expected argument 'http_target' to be a dict")
        pulumi.set(__self__, "http_target", http_target)
        if last_attempt_time and not isinstance(last_attempt_time, str):
            raise TypeError("Expected argument 'last_attempt_time' to be a str")
        pulumi.set(__self__, "last_attempt_time", last_attempt_time)
        if legacy_app_engine_cron and not isinstance(legacy_app_engine_cron, bool):
            raise TypeError("Expected argument 'legacy_app_engine_cron' to be a bool")
        pulumi.set(__self__, "legacy_app_engine_cron", legacy_app_engine_cron)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if pubsub_target and not isinstance(pubsub_target, dict):
            raise TypeError("Expected argument 'pubsub_target' to be a dict")
        pulumi.set(__self__, "pubsub_target", pubsub_target)
        if retry_config and not isinstance(retry_config, dict):
            raise TypeError("Expected argument 'retry_config' to be a dict")
        pulumi.set(__self__, "retry_config", retry_config)
        if schedule and not isinstance(schedule, str):
            raise TypeError("Expected argument 'schedule' to be a str")
        pulumi.set(__self__, "schedule", schedule)
        if schedule_time and not isinstance(schedule_time, str):
            raise TypeError("Expected argument 'schedule_time' to be a str")
        pulumi.set(__self__, "schedule_time", schedule_time)
        if state and not isinstance(state, str):
            raise TypeError("Expected argument 'state' to be a str")
        pulumi.set(__self__, "state", state)
        if status and not isinstance(status, dict):
            raise TypeError("Expected argument 'status' to be a dict")
        pulumi.set(__self__, "status", status)
        if time_zone and not isinstance(time_zone, str):
            raise TypeError("Expected argument 'time_zone' to be a str")
        pulumi.set(__self__, "time_zone", time_zone)
        if user_update_time and not isinstance(user_update_time, str):
            raise TypeError("Expected argument 'user_update_time' to be a str")
        pulumi.set(__self__, "user_update_time", user_update_time)

    @property
    @pulumi.getter(name="appEngineHttpTarget")
    def app_engine_http_target(self) -> 'outputs.AppEngineHttpTargetResponse':
        """
        App Engine HTTP target.
        """
        return pulumi.get(self, "app_engine_http_target")

    @property
    @pulumi.getter(name="attemptDeadline")
    def attempt_deadline(self) -> str:
        """
        The deadline for job attempts. If the request handler does not respond by this deadline then the request is cancelled and the attempt is marked as a `DEADLINE_EXCEEDED` failure. The failed attempt can be viewed in execution logs. Cloud Scheduler will retry the job according to the RetryConfig. The allowed duration for this deadline is: * For HTTP targets, between 15 seconds and 30 minutes. * For App Engine HTTP targets, between 15 seconds and 24 hours 15 seconds. * For Pub/Sub targets, this field is ignored.
        """
        return pulumi.get(self, "attempt_deadline")

    @property
    @pulumi.getter
    def description(self) -> str:
        """
        Optionally caller-specified in CreateJob or UpdateJob. A human-readable description for the job. This string must not contain more than 500 characters.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="httpTarget")
    def http_target(self) -> 'outputs.HttpTargetResponse':
        """
        HTTP target.
        """
        return pulumi.get(self, "http_target")

    @property
    @pulumi.getter(name="lastAttemptTime")
    def last_attempt_time(self) -> str:
        """
        The time the last job attempt started.
        """
        return pulumi.get(self, "last_attempt_time")

    @property
    @pulumi.getter(name="legacyAppEngineCron")
    def legacy_app_engine_cron(self) -> bool:
        """
        Immutable. This field is used to manage the legacy App Engine Cron jobs using the Cloud Scheduler API. If the field is set to true, the job will be considered a legacy job. Note that App Engine Cron jobs have fewer features than Cloud Scheduler jobs, e.g., are only limited to App Engine targets.
        """
        return pulumi.get(self, "legacy_app_engine_cron")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Optionally caller-specified in CreateJob, after which it becomes output only. The job name. For example: `projects/PROJECT_ID/locations/LOCATION_ID/jobs/JOB_ID`. * `PROJECT_ID` can contain letters ([A-Za-z]), numbers ([0-9]), hyphens (-), colons (:), or periods (.). For more information, see [Identifying projects](https://cloud.google.com/resource-manager/docs/creating-managing-projects#identifying_projects) * `LOCATION_ID` is the canonical ID for the job's location. The list of available locations can be obtained by calling ListLocations. For more information, see https://cloud.google.com/about/locations/. * `JOB_ID` can contain only letters ([A-Za-z]), numbers ([0-9]), hyphens (-), or underscores (_). The maximum length is 500 characters.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="pubsubTarget")
    def pubsub_target(self) -> 'outputs.PubsubTargetResponse':
        """
        Pub/Sub target.
        """
        return pulumi.get(self, "pubsub_target")

    @property
    @pulumi.getter(name="retryConfig")
    def retry_config(self) -> 'outputs.RetryConfigResponse':
        """
        Settings that determine the retry behavior.
        """
        return pulumi.get(self, "retry_config")

    @property
    @pulumi.getter
    def schedule(self) -> str:
        """
        Required, except when used with UpdateJob. Describes the schedule on which the job will be executed. The schedule can be either of the following types: * [Crontab](https://en.wikipedia.org/wiki/Cron#Overview) * English-like [schedule](https://cloud.google.com/scheduler/docs/configuring/cron-job-schedules) As a general rule, execution `n + 1` of a job will not begin until execution `n` has finished. Cloud Scheduler will never allow two simultaneously outstanding executions. For example, this implies that if the `n+1`th execution is scheduled to run at 16:00 but the `n`th execution takes until 16:15, the `n+1`th execution will not start until `16:15`. A scheduled start time will be delayed if the previous execution has not ended when its scheduled time occurs. If retry_count > 0 and a job attempt fails, the job will be tried a total of retry_count times, with exponential backoff, until the next scheduled start time.
        """
        return pulumi.get(self, "schedule")

    @property
    @pulumi.getter(name="scheduleTime")
    def schedule_time(self) -> str:
        """
        The next time the job is scheduled. Note that this may be a retry of a previously failed attempt or the next execution time according to the schedule.
        """
        return pulumi.get(self, "schedule_time")

    @property
    @pulumi.getter
    def state(self) -> str:
        """
        State of the job.
        """
        return pulumi.get(self, "state")

    @property
    @pulumi.getter
    def status(self) -> 'outputs.StatusResponse':
        """
        The response from the target for the last attempted execution.
        """
        return pulumi.get(self, "status")

    @property
    @pulumi.getter(name="timeZone")
    def time_zone(self) -> str:
        """
        Specifies the time zone to be used in interpreting schedule. The value of this field must be a time zone name from the [tz database](http://en.wikipedia.org/wiki/Tz_database). Note that some time zones include a provision for daylight savings time. The rules for daylight saving time are determined by the chosen tz. For UTC use the string "utc". If a time zone is not specified, the default will be in UTC (also known as GMT).
        """
        return pulumi.get(self, "time_zone")

    @property
    @pulumi.getter(name="userUpdateTime")
    def user_update_time(self) -> str:
        """
        The creation time of the job.
        """
        return pulumi.get(self, "user_update_time")


class AwaitableGetJobResult(GetJobResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetJobResult(
            app_engine_http_target=self.app_engine_http_target,
            attempt_deadline=self.attempt_deadline,
            description=self.description,
            http_target=self.http_target,
            last_attempt_time=self.last_attempt_time,
            legacy_app_engine_cron=self.legacy_app_engine_cron,
            name=self.name,
            pubsub_target=self.pubsub_target,
            retry_config=self.retry_config,
            schedule=self.schedule,
            schedule_time=self.schedule_time,
            state=self.state,
            status=self.status,
            time_zone=self.time_zone,
            user_update_time=self.user_update_time)


def get_job(job_id: Optional[str] = None,
            location: Optional[str] = None,
            project: Optional[str] = None,
            opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetJobResult:
    """
    Gets a job.
    """
    __args__ = dict()
    __args__['jobId'] = job_id
    __args__['location'] = location
    __args__['project'] = project
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('google-native:cloudscheduler/v1beta1:getJob', __args__, opts=opts, typ=GetJobResult).value

    return AwaitableGetJobResult(
        app_engine_http_target=__ret__.app_engine_http_target,
        attempt_deadline=__ret__.attempt_deadline,
        description=__ret__.description,
        http_target=__ret__.http_target,
        last_attempt_time=__ret__.last_attempt_time,
        legacy_app_engine_cron=__ret__.legacy_app_engine_cron,
        name=__ret__.name,
        pubsub_target=__ret__.pubsub_target,
        retry_config=__ret__.retry_config,
        schedule=__ret__.schedule,
        schedule_time=__ret__.schedule_time,
        state=__ret__.state,
        status=__ret__.status,
        time_zone=__ret__.time_zone,
        user_update_time=__ret__.user_update_time)


@_utilities.lift_output_func(get_job)
def get_job_output(job_id: Optional[pulumi.Input[str]] = None,
                   location: Optional[pulumi.Input[str]] = None,
                   project: Optional[pulumi.Input[Optional[str]]] = None,
                   opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetJobResult]:
    """
    Gets a job.
    """
    ...
