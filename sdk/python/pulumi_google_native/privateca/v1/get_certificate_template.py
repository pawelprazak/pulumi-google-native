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
    'GetCertificateTemplateResult',
    'AwaitableGetCertificateTemplateResult',
    'get_certificate_template',
    'get_certificate_template_output',
]

@pulumi.output_type
class GetCertificateTemplateResult:
    def __init__(__self__, create_time=None, description=None, identity_constraints=None, labels=None, name=None, passthrough_extensions=None, predefined_values=None, update_time=None):
        if create_time and not isinstance(create_time, str):
            raise TypeError("Expected argument 'create_time' to be a str")
        pulumi.set(__self__, "create_time", create_time)
        if description and not isinstance(description, str):
            raise TypeError("Expected argument 'description' to be a str")
        pulumi.set(__self__, "description", description)
        if identity_constraints and not isinstance(identity_constraints, dict):
            raise TypeError("Expected argument 'identity_constraints' to be a dict")
        pulumi.set(__self__, "identity_constraints", identity_constraints)
        if labels and not isinstance(labels, dict):
            raise TypeError("Expected argument 'labels' to be a dict")
        pulumi.set(__self__, "labels", labels)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if passthrough_extensions and not isinstance(passthrough_extensions, dict):
            raise TypeError("Expected argument 'passthrough_extensions' to be a dict")
        pulumi.set(__self__, "passthrough_extensions", passthrough_extensions)
        if predefined_values and not isinstance(predefined_values, dict):
            raise TypeError("Expected argument 'predefined_values' to be a dict")
        pulumi.set(__self__, "predefined_values", predefined_values)
        if update_time and not isinstance(update_time, str):
            raise TypeError("Expected argument 'update_time' to be a str")
        pulumi.set(__self__, "update_time", update_time)

    @property
    @pulumi.getter(name="createTime")
    def create_time(self) -> str:
        """
        The time at which this CertificateTemplate was created.
        """
        return pulumi.get(self, "create_time")

    @property
    @pulumi.getter
    def description(self) -> str:
        """
        Optional. A human-readable description of scenarios this template is intended for.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="identityConstraints")
    def identity_constraints(self) -> 'outputs.CertificateIdentityConstraintsResponse':
        """
        Optional. Describes constraints on identities that may be appear in Certificates issued using this template. If this is omitted, then this template will not add restrictions on a certificate's identity.
        """
        return pulumi.get(self, "identity_constraints")

    @property
    @pulumi.getter
    def labels(self) -> Mapping[str, str]:
        """
        Optional. Labels with user-defined metadata.
        """
        return pulumi.get(self, "labels")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        The resource name for this CertificateTemplate in the format `projects/*/locations/*/certificateTemplates/*`.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="passthroughExtensions")
    def passthrough_extensions(self) -> 'outputs.CertificateExtensionConstraintsResponse':
        """
        Optional. Describes the set of X.509 extensions that may appear in a Certificate issued using this CertificateTemplate. If a certificate request sets extensions that don't appear in the passthrough_extensions, those extensions will be dropped. If the issuing CaPool's IssuancePolicy defines baseline_values that don't appear here, the certificate issuance request will fail. If this is omitted, then this template will not add restrictions on a certificate's X.509 extensions. These constraints do not apply to X.509 extensions set in this CertificateTemplate's predefined_values.
        """
        return pulumi.get(self, "passthrough_extensions")

    @property
    @pulumi.getter(name="predefinedValues")
    def predefined_values(self) -> 'outputs.X509ParametersResponse':
        """
        Optional. A set of X.509 values that will be applied to all issued certificates that use this template. If the certificate request includes conflicting values for the same properties, they will be overwritten by the values defined here. If the issuing CaPool's IssuancePolicy defines conflicting baseline_values for the same properties, the certificate issuance request will fail.
        """
        return pulumi.get(self, "predefined_values")

    @property
    @pulumi.getter(name="updateTime")
    def update_time(self) -> str:
        """
        The time at which this CertificateTemplate was updated.
        """
        return pulumi.get(self, "update_time")


class AwaitableGetCertificateTemplateResult(GetCertificateTemplateResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetCertificateTemplateResult(
            create_time=self.create_time,
            description=self.description,
            identity_constraints=self.identity_constraints,
            labels=self.labels,
            name=self.name,
            passthrough_extensions=self.passthrough_extensions,
            predefined_values=self.predefined_values,
            update_time=self.update_time)


def get_certificate_template(certificate_template_id: Optional[str] = None,
                             location: Optional[str] = None,
                             project: Optional[str] = None,
                             opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetCertificateTemplateResult:
    """
    Returns a CertificateTemplate.
    """
    __args__ = dict()
    __args__['certificateTemplateId'] = certificate_template_id
    __args__['location'] = location
    __args__['project'] = project
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('google-native:privateca/v1:getCertificateTemplate', __args__, opts=opts, typ=GetCertificateTemplateResult).value

    return AwaitableGetCertificateTemplateResult(
        create_time=__ret__.create_time,
        description=__ret__.description,
        identity_constraints=__ret__.identity_constraints,
        labels=__ret__.labels,
        name=__ret__.name,
        passthrough_extensions=__ret__.passthrough_extensions,
        predefined_values=__ret__.predefined_values,
        update_time=__ret__.update_time)


@_utilities.lift_output_func(get_certificate_template)
def get_certificate_template_output(certificate_template_id: Optional[pulumi.Input[str]] = None,
                                    location: Optional[pulumi.Input[str]] = None,
                                    project: Optional[pulumi.Input[Optional[str]]] = None,
                                    opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetCertificateTemplateResult]:
    """
    Returns a CertificateTemplate.
    """
    ...
