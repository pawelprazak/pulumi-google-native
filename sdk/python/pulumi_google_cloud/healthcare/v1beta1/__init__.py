# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

# Export this package's modules as members:
from .annotation import *
from .annotation_store import *
from .attribute_definition import *
from .consent import *
from .consent_artifact import *
from .consent_store import *
from .dataset import *
from .dicom_store import *
from .fhir_store import *
from .hl7_v2_store import *
from .http_body import *
from .message import *
from .policy import *
from .user_data_mapping import *
from ._inputs import *

def _register_module():
    import pulumi
    from ... import _utilities


    class Module(pulumi.runtime.ResourceModule):
        _version = _utilities.get_semver_version()

        def version(self):
            return Module._version

        def construct(self, name: str, typ: str, urn: str) -> pulumi.Resource:
            if typ == "google-cloud:healthcare/v1beta1:Annotation":
                return Annotation(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "google-cloud:healthcare/v1beta1:AnnotationStore":
                return AnnotationStore(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "google-cloud:healthcare/v1beta1:AttributeDefinition":
                return AttributeDefinition(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "google-cloud:healthcare/v1beta1:Consent":
                return Consent(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "google-cloud:healthcare/v1beta1:ConsentArtifact":
                return ConsentArtifact(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "google-cloud:healthcare/v1beta1:ConsentStore":
                return ConsentStore(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "google-cloud:healthcare/v1beta1:Dataset":
                return Dataset(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "google-cloud:healthcare/v1beta1:DicomStore":
                return DicomStore(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "google-cloud:healthcare/v1beta1:FhirStore":
                return FhirStore(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "google-cloud:healthcare/v1beta1:Hl7V2Store":
                return Hl7V2Store(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "google-cloud:healthcare/v1beta1:HttpBody":
                return HttpBody(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "google-cloud:healthcare/v1beta1:Message":
                return Message(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "google-cloud:healthcare/v1beta1:Policy":
                return Policy(name, pulumi.ResourceOptions(urn=urn))
            elif typ == "google-cloud:healthcare/v1beta1:UserDataMapping":
                return UserDataMapping(name, pulumi.ResourceOptions(urn=urn))
            else:
                raise Exception(f"unknown resource type {typ}")


    _module_instance = Module()
    pulumi.runtime.register_resource_module("google-cloud", "healthcare/v1beta1", _module_instance)

_register_module()