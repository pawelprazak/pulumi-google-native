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
    'GetPipelineResult',
    'AwaitableGetPipelineResult',
    'get_pipeline',
    'get_pipeline_output',
]

@pulumi.output_type
class GetPipelineResult:
    def __init__(__self__, description=None, docker=None, input_parameters=None, name=None, output_parameters=None, pipeline_id=None, project=None, resources=None):
        if description and not isinstance(description, str):
            raise TypeError("Expected argument 'description' to be a str")
        pulumi.set(__self__, "description", description)
        if docker and not isinstance(docker, dict):
            raise TypeError("Expected argument 'docker' to be a dict")
        pulumi.set(__self__, "docker", docker)
        if input_parameters and not isinstance(input_parameters, list):
            raise TypeError("Expected argument 'input_parameters' to be a list")
        pulumi.set(__self__, "input_parameters", input_parameters)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if output_parameters and not isinstance(output_parameters, list):
            raise TypeError("Expected argument 'output_parameters' to be a list")
        pulumi.set(__self__, "output_parameters", output_parameters)
        if pipeline_id and not isinstance(pipeline_id, str):
            raise TypeError("Expected argument 'pipeline_id' to be a str")
        pulumi.set(__self__, "pipeline_id", pipeline_id)
        if project and not isinstance(project, str):
            raise TypeError("Expected argument 'project' to be a str")
        pulumi.set(__self__, "project", project)
        if resources and not isinstance(resources, dict):
            raise TypeError("Expected argument 'resources' to be a dict")
        pulumi.set(__self__, "resources", resources)

    @property
    @pulumi.getter
    def description(self) -> str:
        """
        User-specified description.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def docker(self) -> 'outputs.DockerExecutorResponse':
        """
        Specifies the docker run information.
        """
        return pulumi.get(self, "docker")

    @property
    @pulumi.getter(name="inputParameters")
    def input_parameters(self) -> Sequence['outputs.PipelineParameterResponse']:
        """
        Input parameters of the pipeline.
        """
        return pulumi.get(self, "input_parameters")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        A user specified pipeline name that does not have to be unique. This name can be used for filtering Pipelines in ListPipelines.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="outputParameters")
    def output_parameters(self) -> Sequence['outputs.PipelineParameterResponse']:
        """
        Output parameters of the pipeline.
        """
        return pulumi.get(self, "output_parameters")

    @property
    @pulumi.getter(name="pipelineId")
    def pipeline_id(self) -> str:
        """
        Unique pipeline id that is generated by the service when CreatePipeline is called. Cannot be specified in the Pipeline used in the CreatePipelineRequest, and will be populated in the response to CreatePipeline and all subsequent Get and List calls. Indicates that the service has registered this pipeline.
        """
        return pulumi.get(self, "pipeline_id")

    @property
    @pulumi.getter
    def project(self) -> str:
        """
        The project in which to create the pipeline. The caller must have WRITE access.
        """
        return pulumi.get(self, "project")

    @property
    @pulumi.getter
    def resources(self) -> 'outputs.PipelineResourcesResponse':
        """
        Specifies resource requirements for the pipeline run. Required fields: * minimumCpuCores * minimumRamGb
        """
        return pulumi.get(self, "resources")


class AwaitableGetPipelineResult(GetPipelineResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetPipelineResult(
            description=self.description,
            docker=self.docker,
            input_parameters=self.input_parameters,
            name=self.name,
            output_parameters=self.output_parameters,
            pipeline_id=self.pipeline_id,
            project=self.project,
            resources=self.resources)


def get_pipeline(pipeline_id: Optional[str] = None,
                 opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetPipelineResult:
    """
    Retrieves a pipeline based on ID. Caller must have READ permission to the project.
    """
    __args__ = dict()
    __args__['pipelineId'] = pipeline_id
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('google-native:genomics/v1alpha2:getPipeline', __args__, opts=opts, typ=GetPipelineResult).value

    return AwaitableGetPipelineResult(
        description=__ret__.description,
        docker=__ret__.docker,
        input_parameters=__ret__.input_parameters,
        name=__ret__.name,
        output_parameters=__ret__.output_parameters,
        pipeline_id=__ret__.pipeline_id,
        project=__ret__.project,
        resources=__ret__.resources)


@_utilities.lift_output_func(get_pipeline)
def get_pipeline_output(pipeline_id: Optional[pulumi.Input[str]] = None,
                        opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetPipelineResult]:
    """
    Retrieves a pipeline based on ID. Caller must have READ permission to the project.
    """
    ...
