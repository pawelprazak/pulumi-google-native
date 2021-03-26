# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables
from ._inputs import *

__all__ = ['Build']


class Build(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 artifacts: Optional[pulumi.Input[pulumi.InputType['ArtifactsArgs']]] = None,
                 available_secrets: Optional[pulumi.Input[pulumi.InputType['SecretsArgs']]] = None,
                 build_trigger_id: Optional[pulumi.Input[str]] = None,
                 create_time: Optional[pulumi.Input[str]] = None,
                 finish_time: Optional[pulumi.Input[str]] = None,
                 id: Optional[pulumi.Input[str]] = None,
                 images: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 log_url: Optional[pulumi.Input[str]] = None,
                 logs_bucket: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 options: Optional[pulumi.Input[pulumi.InputType['BuildOptionsArgs']]] = None,
                 parent: Optional[pulumi.Input[str]] = None,
                 project_id: Optional[pulumi.Input[str]] = None,
                 queue_ttl: Optional[pulumi.Input[str]] = None,
                 results: Optional[pulumi.Input[pulumi.InputType['ResultsArgs']]] = None,
                 secrets: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['SecretArgs']]]]] = None,
                 service_account: Optional[pulumi.Input[str]] = None,
                 source: Optional[pulumi.Input[pulumi.InputType['SourceArgs']]] = None,
                 source_provenance: Optional[pulumi.Input[pulumi.InputType['SourceProvenanceArgs']]] = None,
                 start_time: Optional[pulumi.Input[str]] = None,
                 status: Optional[pulumi.Input[str]] = None,
                 status_detail: Optional[pulumi.Input[str]] = None,
                 steps: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['BuildStepArgs']]]]] = None,
                 substitutions: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 timeout: Optional[pulumi.Input[str]] = None,
                 timing: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Starts a build with the specified configuration. This method returns a long-running `Operation`, which includes the build ID. Pass the build ID to `GetBuild` to determine the build status (such as `SUCCESS` or `FAILURE`).

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[pulumi.InputType['ArtifactsArgs']] artifacts: Artifacts produced by the build that should be uploaded upon successful completion of all build steps.
        :param pulumi.Input[pulumi.InputType['SecretsArgs']] available_secrets: Secrets and secret environment variables.
        :param pulumi.Input[str] build_trigger_id: Output only. The ID of the `BuildTrigger` that triggered this build, if it was triggered automatically.
        :param pulumi.Input[str] create_time: Output only. Time at which the request to create the build was received.
        :param pulumi.Input[str] finish_time: Output only. Time at which execution of the build was finished. The difference between finish_time and start_time is the duration of the build's execution.
        :param pulumi.Input[str] id: Output only. Unique identifier of the build.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] images: A list of images to be pushed upon the successful completion of all build steps. The images are pushed using the builder service account's credentials. The digests of the pushed images will be stored in the `Build` resource's results field. If any of the images fail to be pushed, the build status is marked `FAILURE`.
        :param pulumi.Input[str] log_url: Output only. URL to logs for this build in Google Cloud Console.
        :param pulumi.Input[str] logs_bucket: Google Cloud Storage bucket where logs should be written (see [Bucket Name Requirements](https://cloud.google.com/storage/docs/bucket-naming#requirements)). Logs file names will be of the format `${logs_bucket}/log-${build_id}.txt`.
        :param pulumi.Input[str] name: Output only. The 'Build' name with format: `projects/{project}/locations/{location}/builds/{build}`, where {build} is a unique identifier generated by the service.
        :param pulumi.Input[pulumi.InputType['BuildOptionsArgs']] options: Special options for this build.
        :param pulumi.Input[str] parent: The parent resource where this build will be created. Format: `projects/{project}/locations/{location}`
        :param pulumi.Input[str] project_id: Output only. ID of the project.
        :param pulumi.Input[str] queue_ttl: TTL in queue for this build. If provided and the build is enqueued longer than this value, the build will expire and the build status will be `EXPIRED`. The TTL starts ticking from create_time.
        :param pulumi.Input[pulumi.InputType['ResultsArgs']] results: Output only. Results of the build.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['SecretArgs']]]] secrets: Secrets to decrypt using Cloud Key Management Service. Note: Secret Manager is the recommended technique for managing sensitive data with Cloud Build. Use `available_secrets` to configure builds to access secrets from Secret Manager. For instructions, see: https://cloud.google.com/cloud-build/docs/securing-builds/use-secrets
        :param pulumi.Input[str] service_account: IAM service account whose credentials will be used at build runtime. Must be of the format `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`. ACCOUNT can be email address or uniqueId of the service account. This field is in beta.
        :param pulumi.Input[pulumi.InputType['SourceArgs']] source: The location of the source files to build.
        :param pulumi.Input[pulumi.InputType['SourceProvenanceArgs']] source_provenance: Output only. A permanent fixed identifier for source.
        :param pulumi.Input[str] start_time: Output only. Time at which execution of the build was started.
        :param pulumi.Input[str] status: Output only. Status of the build.
        :param pulumi.Input[str] status_detail: Output only. Customer-readable message about the current status.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['BuildStepArgs']]]] steps: Required. The operations to be performed on the workspace.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] substitutions: Substitutions data for `Build` resource.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] tags: Tags for annotation of a `Build`. These are not docker tags.
        :param pulumi.Input[str] timeout: Amount of time that this build should be allowed to run, to second granularity. If this amount of time elapses, work on the build will cease and the build status will be `TIMEOUT`. `timeout` starts ticking from `startTime`. Default time is ten minutes.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] timing: Output only. Stores timing information for phases of the build. Valid keys are: * BUILD: time to execute all build steps * PUSH: time to push all specified images. * FETCHSOURCE: time to fetch source. If the build does not specify source or images, these keys will not be included.
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

            __props__['artifacts'] = artifacts
            __props__['available_secrets'] = available_secrets
            __props__['build_trigger_id'] = build_trigger_id
            __props__['create_time'] = create_time
            __props__['finish_time'] = finish_time
            __props__['id'] = id
            __props__['images'] = images
            __props__['log_url'] = log_url
            __props__['logs_bucket'] = logs_bucket
            __props__['name'] = name
            __props__['options'] = options
            __props__['parent'] = parent
            if project_id is None and not opts.urn:
                raise TypeError("Missing required property 'project_id'")
            __props__['project_id'] = project_id
            __props__['queue_ttl'] = queue_ttl
            __props__['results'] = results
            __props__['secrets'] = secrets
            __props__['service_account'] = service_account
            __props__['source'] = source
            __props__['source_provenance'] = source_provenance
            __props__['start_time'] = start_time
            __props__['status'] = status
            __props__['status_detail'] = status_detail
            __props__['steps'] = steps
            __props__['substitutions'] = substitutions
            __props__['tags'] = tags
            __props__['timeout'] = timeout
            __props__['timing'] = timing
        super(Build, __self__).__init__(
            'google-cloud:cloudbuild/v1:Build',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'Build':
        """
        Get an existing Build resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return Build(resource_name, opts=opts, __props__=__props__)

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop
