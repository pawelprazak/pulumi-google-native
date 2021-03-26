# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables
from ._inputs import *

__all__ = ['CapacityCommitment']


class CapacityCommitment(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 commitment_end_time: Optional[pulumi.Input[str]] = None,
                 commitment_start_time: Optional[pulumi.Input[str]] = None,
                 enforce_single_admin_project_per_org: Optional[pulumi.Input[bool]] = None,
                 failure_status: Optional[pulumi.Input[pulumi.InputType['StatusArgs']]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 parent: Optional[pulumi.Input[str]] = None,
                 plan: Optional[pulumi.Input[str]] = None,
                 renewal_plan: Optional[pulumi.Input[str]] = None,
                 slot_count: Optional[pulumi.Input[str]] = None,
                 state: Optional[pulumi.Input[str]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Creates a new capacity commitment resource.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] commitment_end_time: Output only. The end of the current commitment period. It is applicable only for ACTIVE capacity commitments.
        :param pulumi.Input[str] commitment_start_time: Output only. The start of the current commitment period. It is applicable only for ACTIVE capacity commitments.
        :param pulumi.Input[bool] enforce_single_admin_project_per_org: If true, fail the request if another project in the organization has a capacity commitment.
        :param pulumi.Input[pulumi.InputType['StatusArgs']] failure_status: Output only. For FAILED commitment plan, provides the reason of failure.
        :param pulumi.Input[str] name: Output only. The resource name of the capacity commitment, e.g., `projects/myproject/locations/US/capacityCommitments/123`
        :param pulumi.Input[str] parent: Required. Resource name of the parent reservation. E.g., `projects/myproject/locations/US`
        :param pulumi.Input[str] plan: Capacity commitment commitment plan.
        :param pulumi.Input[str] renewal_plan: The plan this capacity commitment is converted to after commitment_end_time passes. Once the plan is changed, committed period is extended according to commitment plan. Only applicable for ANNUAL and TRIAL commitments.
        :param pulumi.Input[str] slot_count: Number of slots in this commitment.
        :param pulumi.Input[str] state: Output only. State of the commitment.
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

            __props__['commitment_end_time'] = commitment_end_time
            __props__['commitment_start_time'] = commitment_start_time
            __props__['enforce_single_admin_project_per_org'] = enforce_single_admin_project_per_org
            __props__['failure_status'] = failure_status
            __props__['name'] = name
            if parent is None and not opts.urn:
                raise TypeError("Missing required property 'parent'")
            __props__['parent'] = parent
            __props__['plan'] = plan
            __props__['renewal_plan'] = renewal_plan
            __props__['slot_count'] = slot_count
            __props__['state'] = state
        super(CapacityCommitment, __self__).__init__(
            'google-cloud:bigqueryreservation/v1:CapacityCommitment',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'CapacityCommitment':
        """
        Get an existing CapacityCommitment resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return CapacityCommitment(resource_name, opts=opts, __props__=__props__)

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop
