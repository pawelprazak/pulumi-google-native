# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

# Export this package's modules as members:
from .client_event import *
from .company import *
from .job import *
from .tenant import *
from ._inputs import *

def _register_module():
    import pulumi
    from ... import _utilities


    class Module(pulumi.runtime.ResourceModule):
        _version = _utilities.get_semver_version()

        def version(self):
            return Module._version

        def construct(self, name: str, typ: str, urn: str) -> pulumi.Resource:
            if typ == "google-cloud:jobs/v4:ClientEvent":
                return ClientEvent(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "google-cloud:jobs/v4:Company":
                return Company(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "google-cloud:jobs/v4:Job":
                return Job(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "google-cloud:jobs/v4:Tenant":
                return Tenant(name, pulumi.ResourceOptions(urn=urn))
            else:
                raise Exception(f"unknown resource type {typ}")


    _module_instance = Module()
    pulumi.runtime.register_resource_module("google-cloud", "jobs/v4", _module_instance)

_register_module()