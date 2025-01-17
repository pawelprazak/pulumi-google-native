# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from ... import _utilities
from ._enums import *

__all__ = ['DatabaseArgs', 'Database']

@pulumi.input_type
class DatabaseArgs:
    def __init__(__self__, *,
                 database_id: pulumi.Input[str],
                 app_engine_integration_mode: Optional[pulumi.Input['DatabaseAppEngineIntegrationMode']] = None,
                 concurrency_mode: Optional[pulumi.Input['DatabaseConcurrencyMode']] = None,
                 etag: Optional[pulumi.Input[str]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 project: Optional[pulumi.Input[str]] = None,
                 type: Optional[pulumi.Input['DatabaseType']] = None,
                 validate_only: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a Database resource.
        :param pulumi.Input[str] database_id: Required. The ID to use for the database, which will become the final component of the database's resource name. This value should be 4-63 characters. Valid characters are /a-z-/ with first character a letter and the last a letter or a number. Must not be UUID-like /[0-9a-f]{8}(-[0-9a-f]{4}){3}-[0-9a-f]{12}/. "(default)" database id is also valid.
        :param pulumi.Input['DatabaseAppEngineIntegrationMode'] app_engine_integration_mode: The App Engine integration mode to use for this database.
        :param pulumi.Input['DatabaseConcurrencyMode'] concurrency_mode: The concurrency control mode to use for this database.
        :param pulumi.Input[str] etag: This checksum is computed by the server based on the value of other fields, and may be sent on update and delete requests to ensure the client has an up-to-date value before proceeding.
        :param pulumi.Input[str] location: The location of the database. Available databases are listed at https://cloud.google.com/firestore/docs/locations.
        :param pulumi.Input[str] name: The resource name of the Database. Format: `projects/{project}/databases/{database}`
        :param pulumi.Input['DatabaseType'] type: The type of the database. See https://cloud.google.com/datastore/docs/firestore-or-datastore for information about how to choose.
        :param pulumi.Input[str] validate_only: If set, validate the request and preview the response, but do not actually create the database.
        """
        pulumi.set(__self__, "database_id", database_id)
        if app_engine_integration_mode is not None:
            pulumi.set(__self__, "app_engine_integration_mode", app_engine_integration_mode)
        if concurrency_mode is not None:
            pulumi.set(__self__, "concurrency_mode", concurrency_mode)
        if etag is not None:
            pulumi.set(__self__, "etag", etag)
        if location is not None:
            pulumi.set(__self__, "location", location)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if project is not None:
            pulumi.set(__self__, "project", project)
        if type is not None:
            pulumi.set(__self__, "type", type)
        if validate_only is not None:
            pulumi.set(__self__, "validate_only", validate_only)

    @property
    @pulumi.getter(name="databaseId")
    def database_id(self) -> pulumi.Input[str]:
        """
        Required. The ID to use for the database, which will become the final component of the database's resource name. This value should be 4-63 characters. Valid characters are /a-z-/ with first character a letter and the last a letter or a number. Must not be UUID-like /[0-9a-f]{8}(-[0-9a-f]{4}){3}-[0-9a-f]{12}/. "(default)" database id is also valid.
        """
        return pulumi.get(self, "database_id")

    @database_id.setter
    def database_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "database_id", value)

    @property
    @pulumi.getter(name="appEngineIntegrationMode")
    def app_engine_integration_mode(self) -> Optional[pulumi.Input['DatabaseAppEngineIntegrationMode']]:
        """
        The App Engine integration mode to use for this database.
        """
        return pulumi.get(self, "app_engine_integration_mode")

    @app_engine_integration_mode.setter
    def app_engine_integration_mode(self, value: Optional[pulumi.Input['DatabaseAppEngineIntegrationMode']]):
        pulumi.set(self, "app_engine_integration_mode", value)

    @property
    @pulumi.getter(name="concurrencyMode")
    def concurrency_mode(self) -> Optional[pulumi.Input['DatabaseConcurrencyMode']]:
        """
        The concurrency control mode to use for this database.
        """
        return pulumi.get(self, "concurrency_mode")

    @concurrency_mode.setter
    def concurrency_mode(self, value: Optional[pulumi.Input['DatabaseConcurrencyMode']]):
        pulumi.set(self, "concurrency_mode", value)

    @property
    @pulumi.getter
    def etag(self) -> Optional[pulumi.Input[str]]:
        """
        This checksum is computed by the server based on the value of other fields, and may be sent on update and delete requests to ensure the client has an up-to-date value before proceeding.
        """
        return pulumi.get(self, "etag")

    @etag.setter
    def etag(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "etag", value)

    @property
    @pulumi.getter
    def location(self) -> Optional[pulumi.Input[str]]:
        """
        The location of the database. Available databases are listed at https://cloud.google.com/firestore/docs/locations.
        """
        return pulumi.get(self, "location")

    @location.setter
    def location(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "location", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        The resource name of the Database. Format: `projects/{project}/databases/{database}`
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
    @pulumi.getter
    def type(self) -> Optional[pulumi.Input['DatabaseType']]:
        """
        The type of the database. See https://cloud.google.com/datastore/docs/firestore-or-datastore for information about how to choose.
        """
        return pulumi.get(self, "type")

    @type.setter
    def type(self, value: Optional[pulumi.Input['DatabaseType']]):
        pulumi.set(self, "type", value)

    @property
    @pulumi.getter(name="validateOnly")
    def validate_only(self) -> Optional[pulumi.Input[str]]:
        """
        If set, validate the request and preview the response, but do not actually create the database.
        """
        return pulumi.get(self, "validate_only")

    @validate_only.setter
    def validate_only(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "validate_only", value)


class Database(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 app_engine_integration_mode: Optional[pulumi.Input['DatabaseAppEngineIntegrationMode']] = None,
                 concurrency_mode: Optional[pulumi.Input['DatabaseConcurrencyMode']] = None,
                 database_id: Optional[pulumi.Input[str]] = None,
                 etag: Optional[pulumi.Input[str]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 project: Optional[pulumi.Input[str]] = None,
                 type: Optional[pulumi.Input['DatabaseType']] = None,
                 validate_only: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Create a database.
        Note - this resource's API doesn't support deletion. When deleted, the resource will persist
        on Google Cloud even though it will be deleted from Pulumi state.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input['DatabaseAppEngineIntegrationMode'] app_engine_integration_mode: The App Engine integration mode to use for this database.
        :param pulumi.Input['DatabaseConcurrencyMode'] concurrency_mode: The concurrency control mode to use for this database.
        :param pulumi.Input[str] database_id: Required. The ID to use for the database, which will become the final component of the database's resource name. This value should be 4-63 characters. Valid characters are /a-z-/ with first character a letter and the last a letter or a number. Must not be UUID-like /[0-9a-f]{8}(-[0-9a-f]{4}){3}-[0-9a-f]{12}/. "(default)" database id is also valid.
        :param pulumi.Input[str] etag: This checksum is computed by the server based on the value of other fields, and may be sent on update and delete requests to ensure the client has an up-to-date value before proceeding.
        :param pulumi.Input[str] location: The location of the database. Available databases are listed at https://cloud.google.com/firestore/docs/locations.
        :param pulumi.Input[str] name: The resource name of the Database. Format: `projects/{project}/databases/{database}`
        :param pulumi.Input['DatabaseType'] type: The type of the database. See https://cloud.google.com/datastore/docs/firestore-or-datastore for information about how to choose.
        :param pulumi.Input[str] validate_only: If set, validate the request and preview the response, but do not actually create the database.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: DatabaseArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a database.
        Note - this resource's API doesn't support deletion. When deleted, the resource will persist
        on Google Cloud even though it will be deleted from Pulumi state.

        :param str resource_name: The name of the resource.
        :param DatabaseArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(DatabaseArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 app_engine_integration_mode: Optional[pulumi.Input['DatabaseAppEngineIntegrationMode']] = None,
                 concurrency_mode: Optional[pulumi.Input['DatabaseConcurrencyMode']] = None,
                 database_id: Optional[pulumi.Input[str]] = None,
                 etag: Optional[pulumi.Input[str]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 project: Optional[pulumi.Input[str]] = None,
                 type: Optional[pulumi.Input['DatabaseType']] = None,
                 validate_only: Optional[pulumi.Input[str]] = None,
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
            __props__ = DatabaseArgs.__new__(DatabaseArgs)

            __props__.__dict__["app_engine_integration_mode"] = app_engine_integration_mode
            __props__.__dict__["concurrency_mode"] = concurrency_mode
            if database_id is None and not opts.urn:
                raise TypeError("Missing required property 'database_id'")
            __props__.__dict__["database_id"] = database_id
            __props__.__dict__["etag"] = etag
            __props__.__dict__["location"] = location
            __props__.__dict__["name"] = name
            __props__.__dict__["project"] = project
            __props__.__dict__["type"] = type
            __props__.__dict__["validate_only"] = validate_only
            __props__.__dict__["key_prefix"] = None
        super(Database, __self__).__init__(
            'google-native:firestore/v1:Database',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'Database':
        """
        Get an existing Database resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = DatabaseArgs.__new__(DatabaseArgs)

        __props__.__dict__["app_engine_integration_mode"] = None
        __props__.__dict__["concurrency_mode"] = None
        __props__.__dict__["database_id"] = None
        __props__.__dict__["etag"] = None
        __props__.__dict__["key_prefix"] = None
        __props__.__dict__["location"] = None
        __props__.__dict__["name"] = None
        __props__.__dict__["project"] = None
        __props__.__dict__["type"] = None
        __props__.__dict__["validate_only"] = None
        return Database(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="appEngineIntegrationMode")
    def app_engine_integration_mode(self) -> pulumi.Output[str]:
        """
        The App Engine integration mode to use for this database.
        """
        return pulumi.get(self, "app_engine_integration_mode")

    @property
    @pulumi.getter(name="concurrencyMode")
    def concurrency_mode(self) -> pulumi.Output[str]:
        """
        The concurrency control mode to use for this database.
        """
        return pulumi.get(self, "concurrency_mode")

    @property
    @pulumi.getter(name="databaseId")
    def database_id(self) -> pulumi.Output[str]:
        """
        Required. The ID to use for the database, which will become the final component of the database's resource name. This value should be 4-63 characters. Valid characters are /a-z-/ with first character a letter and the last a letter or a number. Must not be UUID-like /[0-9a-f]{8}(-[0-9a-f]{4}){3}-[0-9a-f]{12}/. "(default)" database id is also valid.
        """
        return pulumi.get(self, "database_id")

    @property
    @pulumi.getter
    def etag(self) -> pulumi.Output[str]:
        """
        This checksum is computed by the server based on the value of other fields, and may be sent on update and delete requests to ensure the client has an up-to-date value before proceeding.
        """
        return pulumi.get(self, "etag")

    @property
    @pulumi.getter(name="keyPrefix")
    def key_prefix(self) -> pulumi.Output[str]:
        """
        The key_prefix for this database. This key_prefix is used, in combination with the project id ("~") to construct the application id that is returned from the Cloud Datastore APIs in Google App Engine first generation runtimes. This value may be empty in which case the appid to use for URL-encoded keys is the project_id (eg: foo instead of v~foo).
        """
        return pulumi.get(self, "key_prefix")

    @property
    @pulumi.getter
    def location(self) -> pulumi.Output[str]:
        """
        The location of the database. Available databases are listed at https://cloud.google.com/firestore/docs/locations.
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        The resource name of the Database. Format: `projects/{project}/databases/{database}`
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def project(self) -> pulumi.Output[str]:
        return pulumi.get(self, "project")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[str]:
        """
        The type of the database. See https://cloud.google.com/datastore/docs/firestore-or-datastore for information about how to choose.
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="validateOnly")
    def validate_only(self) -> pulumi.Output[Optional[str]]:
        """
        If set, validate the request and preview the response, but do not actually create the database.
        """
        return pulumi.get(self, "validate_only")

