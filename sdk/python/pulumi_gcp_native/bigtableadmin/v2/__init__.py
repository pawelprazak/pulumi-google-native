# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

# Export this package's modules as members:
from .instance import *
from .instance_app_profile import *
from .instance_cluster import *
from .instance_cluster_backup import *
from .instance_cluster_backup_iam_policy import *
from .instance_iam_policy import *
from .instance_table import *
from .instance_table_iam_policy import *
from ._inputs import *
from . import outputs

def _register_module():
    import pulumi
    from ... import _utilities


    class Module(pulumi.runtime.ResourceModule):
        _version = _utilities.get_semver_version()

        def version(self):
            return Module._version

        def construct(self, name: str, typ: str, urn: str) -> pulumi.Resource:
            if typ == "gcp-native:bigtableadmin/v2:Instance":
                return Instance(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "gcp-native:bigtableadmin/v2:InstanceAppProfile":
                return InstanceAppProfile(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "gcp-native:bigtableadmin/v2:InstanceCluster":
                return InstanceCluster(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "gcp-native:bigtableadmin/v2:InstanceClusterBackup":
                return InstanceClusterBackup(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "gcp-native:bigtableadmin/v2:InstanceClusterBackupIamPolicy":
                return InstanceClusterBackupIamPolicy(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "gcp-native:bigtableadmin/v2:InstanceIamPolicy":
                return InstanceIamPolicy(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "gcp-native:bigtableadmin/v2:InstanceTable":
                return InstanceTable(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "gcp-native:bigtableadmin/v2:InstanceTableIamPolicy":
                return InstanceTableIamPolicy(name, pulumi.ResourceOptions(urn=urn))
            else:
                raise Exception(f"unknown resource type {typ}")


    _module_instance = Module()
    pulumi.runtime.register_resource_module("gcp-native", "bigtableadmin/v2", _module_instance)

_register_module()