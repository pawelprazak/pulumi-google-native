# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables
from . import outputs
from ._inputs import *

__all__ = ['Job']


class Job(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 create_time: Optional[pulumi.Input[str]] = None,
                 end_time: Optional[pulumi.Input[str]] = None,
                 error_message: Optional[pulumi.Input[str]] = None,
                 etag: Optional[pulumi.Input[str]] = None,
                 job_id: Optional[pulumi.Input[str]] = None,
                 jobs_id: Optional[pulumi.Input[str]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 prediction_input: Optional[pulumi.Input[pulumi.InputType['GoogleCloudMlV1__PredictionInputArgs']]] = None,
                 prediction_output: Optional[pulumi.Input[pulumi.InputType['GoogleCloudMlV1__PredictionOutputArgs']]] = None,
                 projects_id: Optional[pulumi.Input[str]] = None,
                 start_time: Optional[pulumi.Input[str]] = None,
                 state: Optional[pulumi.Input[str]] = None,
                 training_input: Optional[pulumi.Input[pulumi.InputType['GoogleCloudMlV1__TrainingInputArgs']]] = None,
                 training_output: Optional[pulumi.Input[pulumi.InputType['GoogleCloudMlV1__TrainingOutputArgs']]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Creates a training or a batch prediction job.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] create_time: When the job was created.
        :param pulumi.Input[str] end_time: When the job processing was completed.
        :param pulumi.Input[str] error_message: The details of a failure or a cancellation.
        :param pulumi.Input[str] etag: `etag` is used for optimistic concurrency control as a way to help prevent simultaneous updates of a job from overwriting each other. It is strongly suggested that systems make use of the `etag` in the read-modify-write cycle to perform job updates in order to avoid race conditions: An `etag` is returned in the response to `GetJob`, and systems are expected to put that etag in the request to `UpdateJob` to ensure that their change will be applied to the same version of the job.
        :param pulumi.Input[str] job_id: Required. The user-specified id of the job.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] labels: Optional. One or more labels that you can add, to organize your jobs. Each label is a key-value pair, where both the key and the value are arbitrary strings that you supply. For more information, see the documentation on using labels.
        :param pulumi.Input[pulumi.InputType['GoogleCloudMlV1__PredictionInputArgs']] prediction_input: Input parameters to create a prediction job.
        :param pulumi.Input[pulumi.InputType['GoogleCloudMlV1__PredictionOutputArgs']] prediction_output: The current prediction job result.
        :param pulumi.Input[str] start_time: When the job processing was started.
        :param pulumi.Input[str] state: The detailed state of a job.
        :param pulumi.Input[pulumi.InputType['GoogleCloudMlV1__TrainingInputArgs']] training_input: Input parameters to create a training job.
        :param pulumi.Input[pulumi.InputType['GoogleCloudMlV1__TrainingOutputArgs']] training_output: The current training job result.
        """
        if __name__ is not None:
            warnings.warn("explicit use of __name__ is deprecated", DeprecationWarning)
            resource_name = __name__
        if __opts__ is not None:
            warnings.warn("explicit use of __opts__ is deprecated, use 'opts' instead", DeprecationWarning)
            opts = __opts__
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = dict()

            __props__['create_time'] = create_time
            __props__['end_time'] = end_time
            __props__['error_message'] = error_message
            __props__['etag'] = etag
            __props__['job_id'] = job_id
            if jobs_id is None and not opts.urn:
                raise TypeError("Missing required property 'jobs_id'")
            __props__['jobs_id'] = jobs_id
            __props__['labels'] = labels
            __props__['prediction_input'] = prediction_input
            __props__['prediction_output'] = prediction_output
            if projects_id is None and not opts.urn:
                raise TypeError("Missing required property 'projects_id'")
            __props__['projects_id'] = projects_id
            __props__['start_time'] = start_time
            __props__['state'] = state
            __props__['training_input'] = training_input
            __props__['training_output'] = training_output
        super(Job, __self__).__init__(
            'google-cloud:ml/v1:Job',
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

        __props__ = dict()

        __props__["create_time"] = None
        __props__["end_time"] = None
        __props__["error_message"] = None
        __props__["etag"] = None
        __props__["job_id"] = None
        __props__["labels"] = None
        __props__["prediction_input"] = None
        __props__["prediction_output"] = None
        __props__["start_time"] = None
        __props__["state"] = None
        __props__["training_input"] = None
        __props__["training_output"] = None
        return Job(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="createTime")
    def create_time(self) -> pulumi.Output[str]:
        """
        When the job was created.
        """
        return pulumi.get(self, "create_time")

    @property
    @pulumi.getter(name="endTime")
    def end_time(self) -> pulumi.Output[str]:
        """
        When the job processing was completed.
        """
        return pulumi.get(self, "end_time")

    @property
    @pulumi.getter(name="errorMessage")
    def error_message(self) -> pulumi.Output[str]:
        """
        The details of a failure or a cancellation.
        """
        return pulumi.get(self, "error_message")

    @property
    @pulumi.getter
    def etag(self) -> pulumi.Output[str]:
        """
        `etag` is used for optimistic concurrency control as a way to help prevent simultaneous updates of a job from overwriting each other. It is strongly suggested that systems make use of the `etag` in the read-modify-write cycle to perform job updates in order to avoid race conditions: An `etag` is returned in the response to `GetJob`, and systems are expected to put that etag in the request to `UpdateJob` to ensure that their change will be applied to the same version of the job.
        """
        return pulumi.get(self, "etag")

    @property
    @pulumi.getter(name="jobId")
    def job_id(self) -> pulumi.Output[str]:
        """
        Required. The user-specified id of the job.
        """
        return pulumi.get(self, "job_id")

    @property
    @pulumi.getter
    def labels(self) -> pulumi.Output[Mapping[str, str]]:
        """
        Optional. One or more labels that you can add, to organize your jobs. Each label is a key-value pair, where both the key and the value are arbitrary strings that you supply. For more information, see the documentation on using labels.
        """
        return pulumi.get(self, "labels")

    @property
    @pulumi.getter(name="predictionInput")
    def prediction_input(self) -> pulumi.Output['outputs.GoogleCloudMlV1__PredictionInputResponse']:
        """
        Input parameters to create a prediction job.
        """
        return pulumi.get(self, "prediction_input")

    @property
    @pulumi.getter(name="predictionOutput")
    def prediction_output(self) -> pulumi.Output['outputs.GoogleCloudMlV1__PredictionOutputResponse']:
        """
        The current prediction job result.
        """
        return pulumi.get(self, "prediction_output")

    @property
    @pulumi.getter(name="startTime")
    def start_time(self) -> pulumi.Output[str]:
        """
        When the job processing was started.
        """
        return pulumi.get(self, "start_time")

    @property
    @pulumi.getter
    def state(self) -> pulumi.Output[str]:
        """
        The detailed state of a job.
        """
        return pulumi.get(self, "state")

    @property
    @pulumi.getter(name="trainingInput")
    def training_input(self) -> pulumi.Output['outputs.GoogleCloudMlV1__TrainingInputResponse']:
        """
        Input parameters to create a training job.
        """
        return pulumi.get(self, "training_input")

    @property
    @pulumi.getter(name="trainingOutput")
    def training_output(self) -> pulumi.Output['outputs.GoogleCloudMlV1__TrainingOutputResponse']:
        """
        The current training job result.
        """
        return pulumi.get(self, "training_output")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop
