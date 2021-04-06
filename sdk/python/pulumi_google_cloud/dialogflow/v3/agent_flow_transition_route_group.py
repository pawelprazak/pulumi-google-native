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

__all__ = ['AgentFlowTransitionRouteGroup']


class AgentFlowTransitionRouteGroup(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 agents_id: Optional[pulumi.Input[str]] = None,
                 display_name: Optional[pulumi.Input[str]] = None,
                 flows_id: Optional[pulumi.Input[str]] = None,
                 locations_id: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 projects_id: Optional[pulumi.Input[str]] = None,
                 transition_route_groups_id: Optional[pulumi.Input[str]] = None,
                 transition_routes: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['GoogleCloudDialogflowCxV3TransitionRouteArgs']]]]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Creates an TransitionRouteGroup in the specified flow.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] display_name: Required. The human-readable name of the transition route group, unique within the Agent. The display name can be no longer than 30 characters.
        :param pulumi.Input[str] name: The unique identifier of the transition route group. TransitionRouteGroups.CreateTransitionRouteGroup populates the name automatically. Format: `projects//locations//agents//flows//transitionRouteGroups/`.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['GoogleCloudDialogflowCxV3TransitionRouteArgs']]]] transition_routes: Transition routes associated with the TransitionRouteGroup.
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

            if agents_id is None and not opts.urn:
                raise TypeError("Missing required property 'agents_id'")
            __props__['agents_id'] = agents_id
            __props__['display_name'] = display_name
            if flows_id is None and not opts.urn:
                raise TypeError("Missing required property 'flows_id'")
            __props__['flows_id'] = flows_id
            if locations_id is None and not opts.urn:
                raise TypeError("Missing required property 'locations_id'")
            __props__['locations_id'] = locations_id
            __props__['name'] = name
            if projects_id is None and not opts.urn:
                raise TypeError("Missing required property 'projects_id'")
            __props__['projects_id'] = projects_id
            if transition_route_groups_id is None and not opts.urn:
                raise TypeError("Missing required property 'transition_route_groups_id'")
            __props__['transition_route_groups_id'] = transition_route_groups_id
            __props__['transition_routes'] = transition_routes
        super(AgentFlowTransitionRouteGroup, __self__).__init__(
            'google-cloud:dialogflow/v3:AgentFlowTransitionRouteGroup',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'AgentFlowTransitionRouteGroup':
        """
        Get an existing AgentFlowTransitionRouteGroup resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["display_name"] = None
        __props__["name"] = None
        __props__["transition_routes"] = None
        return AgentFlowTransitionRouteGroup(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="displayName")
    def display_name(self) -> pulumi.Output[str]:
        """
        Required. The human-readable name of the transition route group, unique within the Agent. The display name can be no longer than 30 characters.
        """
        return pulumi.get(self, "display_name")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        The unique identifier of the transition route group. TransitionRouteGroups.CreateTransitionRouteGroup populates the name automatically. Format: `projects//locations//agents//flows//transitionRouteGroups/`.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="transitionRoutes")
    def transition_routes(self) -> pulumi.Output[Sequence['outputs.GoogleCloudDialogflowCxV3TransitionRouteResponse']]:
        """
        Transition routes associated with the TransitionRouteGroup.
        """
        return pulumi.get(self, "transition_routes")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop
