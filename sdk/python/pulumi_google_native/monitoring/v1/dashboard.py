# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from ... import _utilities
from . import outputs
from ._inputs import *

__all__ = ['DashboardArgs', 'Dashboard']

@pulumi.input_type
class DashboardArgs:
    def __init__(__self__, *,
                 dashboards_id: pulumi.Input[str],
                 projects_id: pulumi.Input[str],
                 column_layout: Optional[pulumi.Input['ColumnLayoutArgs']] = None,
                 display_name: Optional[pulumi.Input[str]] = None,
                 etag: Optional[pulumi.Input[str]] = None,
                 grid_layout: Optional[pulumi.Input['GridLayoutArgs']] = None,
                 mosaic_layout: Optional[pulumi.Input['MosaicLayoutArgs']] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 row_layout: Optional[pulumi.Input['RowLayoutArgs']] = None):
        """
        The set of arguments for constructing a Dashboard resource.
        :param pulumi.Input['ColumnLayoutArgs'] column_layout: The content is divided into equally spaced columns and the widgets are arranged vertically.
        :param pulumi.Input[str] display_name: Required. The mutable, human-readable name.
        :param pulumi.Input[str] etag: etag is used for optimistic concurrency control as a way to help prevent simultaneous updates of a policy from overwriting each other. An etag is returned in the response to GetDashboard, and users are expected to put that etag in the request to UpdateDashboard to ensure that their change will be applied to the same version of the Dashboard configuration. The field should not be passed during dashboard creation.
        :param pulumi.Input['GridLayoutArgs'] grid_layout: Content is arranged with a basic layout that re-flows a simple list of informational elements like widgets or tiles.
        :param pulumi.Input['MosaicLayoutArgs'] mosaic_layout: The content is arranged as a grid of tiles, with each content widget occupying one or more grid blocks.
        :param pulumi.Input[str] name: Immutable. The resource name of the dashboard.
        :param pulumi.Input['RowLayoutArgs'] row_layout: The content is divided into equally spaced rows and the widgets are arranged horizontally.
        """
        pulumi.set(__self__, "dashboards_id", dashboards_id)
        pulumi.set(__self__, "projects_id", projects_id)
        if column_layout is not None:
            pulumi.set(__self__, "column_layout", column_layout)
        if display_name is not None:
            pulumi.set(__self__, "display_name", display_name)
        if etag is not None:
            pulumi.set(__self__, "etag", etag)
        if grid_layout is not None:
            pulumi.set(__self__, "grid_layout", grid_layout)
        if mosaic_layout is not None:
            pulumi.set(__self__, "mosaic_layout", mosaic_layout)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if row_layout is not None:
            pulumi.set(__self__, "row_layout", row_layout)

    @property
    @pulumi.getter(name="dashboardsId")
    def dashboards_id(self) -> pulumi.Input[str]:
        return pulumi.get(self, "dashboards_id")

    @dashboards_id.setter
    def dashboards_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "dashboards_id", value)

    @property
    @pulumi.getter(name="projectsId")
    def projects_id(self) -> pulumi.Input[str]:
        return pulumi.get(self, "projects_id")

    @projects_id.setter
    def projects_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "projects_id", value)

    @property
    @pulumi.getter(name="columnLayout")
    def column_layout(self) -> Optional[pulumi.Input['ColumnLayoutArgs']]:
        """
        The content is divided into equally spaced columns and the widgets are arranged vertically.
        """
        return pulumi.get(self, "column_layout")

    @column_layout.setter
    def column_layout(self, value: Optional[pulumi.Input['ColumnLayoutArgs']]):
        pulumi.set(self, "column_layout", value)

    @property
    @pulumi.getter(name="displayName")
    def display_name(self) -> Optional[pulumi.Input[str]]:
        """
        Required. The mutable, human-readable name.
        """
        return pulumi.get(self, "display_name")

    @display_name.setter
    def display_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "display_name", value)

    @property
    @pulumi.getter
    def etag(self) -> Optional[pulumi.Input[str]]:
        """
        etag is used for optimistic concurrency control as a way to help prevent simultaneous updates of a policy from overwriting each other. An etag is returned in the response to GetDashboard, and users are expected to put that etag in the request to UpdateDashboard to ensure that their change will be applied to the same version of the Dashboard configuration. The field should not be passed during dashboard creation.
        """
        return pulumi.get(self, "etag")

    @etag.setter
    def etag(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "etag", value)

    @property
    @pulumi.getter(name="gridLayout")
    def grid_layout(self) -> Optional[pulumi.Input['GridLayoutArgs']]:
        """
        Content is arranged with a basic layout that re-flows a simple list of informational elements like widgets or tiles.
        """
        return pulumi.get(self, "grid_layout")

    @grid_layout.setter
    def grid_layout(self, value: Optional[pulumi.Input['GridLayoutArgs']]):
        pulumi.set(self, "grid_layout", value)

    @property
    @pulumi.getter(name="mosaicLayout")
    def mosaic_layout(self) -> Optional[pulumi.Input['MosaicLayoutArgs']]:
        """
        The content is arranged as a grid of tiles, with each content widget occupying one or more grid blocks.
        """
        return pulumi.get(self, "mosaic_layout")

    @mosaic_layout.setter
    def mosaic_layout(self, value: Optional[pulumi.Input['MosaicLayoutArgs']]):
        pulumi.set(self, "mosaic_layout", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Immutable. The resource name of the dashboard.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="rowLayout")
    def row_layout(self) -> Optional[pulumi.Input['RowLayoutArgs']]:
        """
        The content is divided into equally spaced rows and the widgets are arranged horizontally.
        """
        return pulumi.get(self, "row_layout")

    @row_layout.setter
    def row_layout(self, value: Optional[pulumi.Input['RowLayoutArgs']]):
        pulumi.set(self, "row_layout", value)


class Dashboard(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 column_layout: Optional[pulumi.Input[pulumi.InputType['ColumnLayoutArgs']]] = None,
                 dashboards_id: Optional[pulumi.Input[str]] = None,
                 display_name: Optional[pulumi.Input[str]] = None,
                 etag: Optional[pulumi.Input[str]] = None,
                 grid_layout: Optional[pulumi.Input[pulumi.InputType['GridLayoutArgs']]] = None,
                 mosaic_layout: Optional[pulumi.Input[pulumi.InputType['MosaicLayoutArgs']]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 projects_id: Optional[pulumi.Input[str]] = None,
                 row_layout: Optional[pulumi.Input[pulumi.InputType['RowLayoutArgs']]] = None,
                 __props__=None):
        """
        Creates a new custom dashboard. For examples on how you can use this API to create dashboards, see Managing dashboards by API. This method requires the monitoring.dashboards.create permission on the specified project. For more information about permissions, see Cloud Identity and Access Management.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[pulumi.InputType['ColumnLayoutArgs']] column_layout: The content is divided into equally spaced columns and the widgets are arranged vertically.
        :param pulumi.Input[str] display_name: Required. The mutable, human-readable name.
        :param pulumi.Input[str] etag: etag is used for optimistic concurrency control as a way to help prevent simultaneous updates of a policy from overwriting each other. An etag is returned in the response to GetDashboard, and users are expected to put that etag in the request to UpdateDashboard to ensure that their change will be applied to the same version of the Dashboard configuration. The field should not be passed during dashboard creation.
        :param pulumi.Input[pulumi.InputType['GridLayoutArgs']] grid_layout: Content is arranged with a basic layout that re-flows a simple list of informational elements like widgets or tiles.
        :param pulumi.Input[pulumi.InputType['MosaicLayoutArgs']] mosaic_layout: The content is arranged as a grid of tiles, with each content widget occupying one or more grid blocks.
        :param pulumi.Input[str] name: Immutable. The resource name of the dashboard.
        :param pulumi.Input[pulumi.InputType['RowLayoutArgs']] row_layout: The content is divided into equally spaced rows and the widgets are arranged horizontally.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: DashboardArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Creates a new custom dashboard. For examples on how you can use this API to create dashboards, see Managing dashboards by API. This method requires the monitoring.dashboards.create permission on the specified project. For more information about permissions, see Cloud Identity and Access Management.

        :param str resource_name: The name of the resource.
        :param DashboardArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(DashboardArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 column_layout: Optional[pulumi.Input[pulumi.InputType['ColumnLayoutArgs']]] = None,
                 dashboards_id: Optional[pulumi.Input[str]] = None,
                 display_name: Optional[pulumi.Input[str]] = None,
                 etag: Optional[pulumi.Input[str]] = None,
                 grid_layout: Optional[pulumi.Input[pulumi.InputType['GridLayoutArgs']]] = None,
                 mosaic_layout: Optional[pulumi.Input[pulumi.InputType['MosaicLayoutArgs']]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 projects_id: Optional[pulumi.Input[str]] = None,
                 row_layout: Optional[pulumi.Input[pulumi.InputType['RowLayoutArgs']]] = None,
                 __props__=None):
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = DashboardArgs.__new__(DashboardArgs)

            __props__.__dict__["column_layout"] = column_layout
            if dashboards_id is None and not opts.urn:
                raise TypeError("Missing required property 'dashboards_id'")
            __props__.__dict__["dashboards_id"] = dashboards_id
            __props__.__dict__["display_name"] = display_name
            __props__.__dict__["etag"] = etag
            __props__.__dict__["grid_layout"] = grid_layout
            __props__.__dict__["mosaic_layout"] = mosaic_layout
            __props__.__dict__["name"] = name
            if projects_id is None and not opts.urn:
                raise TypeError("Missing required property 'projects_id'")
            __props__.__dict__["projects_id"] = projects_id
            __props__.__dict__["row_layout"] = row_layout
        super(Dashboard, __self__).__init__(
            'google-native:monitoring/v1:Dashboard',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'Dashboard':
        """
        Get an existing Dashboard resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = DashboardArgs.__new__(DashboardArgs)

        __props__.__dict__["column_layout"] = None
        __props__.__dict__["display_name"] = None
        __props__.__dict__["etag"] = None
        __props__.__dict__["grid_layout"] = None
        __props__.__dict__["mosaic_layout"] = None
        __props__.__dict__["name"] = None
        __props__.__dict__["row_layout"] = None
        return Dashboard(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="columnLayout")
    def column_layout(self) -> pulumi.Output['outputs.ColumnLayoutResponse']:
        """
        The content is divided into equally spaced columns and the widgets are arranged vertically.
        """
        return pulumi.get(self, "column_layout")

    @property
    @pulumi.getter(name="displayName")
    def display_name(self) -> pulumi.Output[str]:
        """
        Required. The mutable, human-readable name.
        """
        return pulumi.get(self, "display_name")

    @property
    @pulumi.getter
    def etag(self) -> pulumi.Output[str]:
        """
        etag is used for optimistic concurrency control as a way to help prevent simultaneous updates of a policy from overwriting each other. An etag is returned in the response to GetDashboard, and users are expected to put that etag in the request to UpdateDashboard to ensure that their change will be applied to the same version of the Dashboard configuration. The field should not be passed during dashboard creation.
        """
        return pulumi.get(self, "etag")

    @property
    @pulumi.getter(name="gridLayout")
    def grid_layout(self) -> pulumi.Output['outputs.GridLayoutResponse']:
        """
        Content is arranged with a basic layout that re-flows a simple list of informational elements like widgets or tiles.
        """
        return pulumi.get(self, "grid_layout")

    @property
    @pulumi.getter(name="mosaicLayout")
    def mosaic_layout(self) -> pulumi.Output['outputs.MosaicLayoutResponse']:
        """
        The content is arranged as a grid of tiles, with each content widget occupying one or more grid blocks.
        """
        return pulumi.get(self, "mosaic_layout")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Immutable. The resource name of the dashboard.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="rowLayout")
    def row_layout(self) -> pulumi.Output['outputs.RowLayoutResponse']:
        """
        The content is divided into equally spaced rows and the widgets are arranged horizontally.
        """
        return pulumi.get(self, "row_layout")
