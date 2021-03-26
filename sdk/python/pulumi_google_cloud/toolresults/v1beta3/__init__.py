# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

# Export this package's modules as members:
from .execution import *
from .history import *
from .perf_metrics_summary import *
from .perf_sample_series import *
from .step import *
from ._inputs import *

def _register_module():
    import pulumi
    from ... import _utilities


    class Module(pulumi.runtime.ResourceModule):
        _version = _utilities.get_semver_version()

        def version(self):
            return Module._version

        def construct(self, name: str, typ: str, urn: str) -> pulumi.Resource:
            if typ == "google-cloud:toolresults/v1beta3:Execution":
                return Execution(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "google-cloud:toolresults/v1beta3:History":
                return History(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "google-cloud:toolresults/v1beta3:PerfMetricsSummary":
                return PerfMetricsSummary(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "google-cloud:toolresults/v1beta3:PerfSampleSeries":
                return PerfSampleSeries(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "google-cloud:toolresults/v1beta3:Step":
                return Step(name, pulumi.ResourceOptions(urn=urn))
            else:
                raise Exception(f"unknown resource type {typ}")


    _module_instance = Module()
    pulumi.runtime.register_resource_module("google-cloud", "toolresults/v1beta3", _module_instance)

_register_module()