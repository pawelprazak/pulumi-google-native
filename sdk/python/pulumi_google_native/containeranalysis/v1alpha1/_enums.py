# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

from enum import Enum

__all__ = [
    'BuildSignatureKeyType',
    'DeploymentPlatform',
    'DiscoveredAnalysisStatus',
    'DiscoveredContinuousAnalysis',
    'DiscoveryAnalysisKind',
    'DistributionArchitecture',
    'GoogleDevtoolsContaineranalysisV1alpha1AliasContextKind',
    'HashType',
    'LayerDirective',
    'NoteKind',
    'OccurrenceKind',
    'PgpSignedAttestationContentType',
    'VersionKind',
    'VulnerabilityDetailsEffectiveSeverity',
    'VulnerabilityDetailsSeverity',
    'VulnerabilityTypeSeverity',
]


class BuildSignatureKeyType(str, Enum):
    """
    The type of the key, either stored in `public_key` or referenced in `key_id`
    """
    KEY_TYPE_UNSPECIFIED = "KEY_TYPE_UNSPECIFIED"
    PGP_ASCII_ARMORED = "PGP_ASCII_ARMORED"
    PKIX_PEM = "PKIX_PEM"


class DeploymentPlatform(str, Enum):
    """
    Platform hosting this deployment.
    """
    PLATFORM_UNSPECIFIED = "PLATFORM_UNSPECIFIED"
    GKE = "GKE"
    FLEX = "FLEX"
    CUSTOM = "CUSTOM"


class DiscoveredAnalysisStatus(str, Enum):
    """
    The status of discovery for the resource.
    """
    ANALYSIS_STATUS_UNSPECIFIED = "ANALYSIS_STATUS_UNSPECIFIED"
    PENDING = "PENDING"
    SCANNING = "SCANNING"
    FINISHED_SUCCESS = "FINISHED_SUCCESS"
    FINISHED_FAILED = "FINISHED_FAILED"
    FINISHED_UNSUPPORTED = "FINISHED_UNSUPPORTED"


class DiscoveredContinuousAnalysis(str, Enum):
    """
    Whether the resource is continuously analyzed.
    """
    CONTINUOUS_ANALYSIS_UNSPECIFIED = "CONTINUOUS_ANALYSIS_UNSPECIFIED"
    ACTIVE = "ACTIVE"
    INACTIVE = "INACTIVE"


class DiscoveryAnalysisKind(str, Enum):
    """
    The kind of analysis that is handled by this discovery.
    """
    KIND_UNSPECIFIED = "KIND_UNSPECIFIED"
    PACKAGE_VULNERABILITY = "PACKAGE_VULNERABILITY"
    BUILD_DETAILS = "BUILD_DETAILS"
    IMAGE_BASIS = "IMAGE_BASIS"
    PACKAGE_MANAGER = "PACKAGE_MANAGER"
    DEPLOYABLE = "DEPLOYABLE"
    DISCOVERY = "DISCOVERY"
    ATTESTATION_AUTHORITY = "ATTESTATION_AUTHORITY"
    UPGRADE = "UPGRADE"


class DistributionArchitecture(str, Enum):
    """
    The CPU architecture for which packages in this distribution channel were built
    """
    ARCHITECTURE_UNSPECIFIED = "ARCHITECTURE_UNSPECIFIED"
    X86 = "X86"
    X64 = "X64"


class GoogleDevtoolsContaineranalysisV1alpha1AliasContextKind(str, Enum):
    """
    The alias kind.
    """
    KIND_UNSPECIFIED = "KIND_UNSPECIFIED"
    FIXED = "FIXED"
    MOVABLE = "MOVABLE"
    OTHER = "OTHER"


class HashType(str, Enum):
    """
    The type of hash that was performed.
    """
    NONE = "NONE"
    SHA256 = "SHA256"


class LayerDirective(str, Enum):
    """
    The recovered Dockerfile directive used to construct this layer.
    """
    DIRECTIVE_UNSPECIFIED = "DIRECTIVE_UNSPECIFIED"
    MAINTAINER = "MAINTAINER"
    RUN = "RUN"
    CMD = "CMD"
    LABEL = "LABEL"
    EXPOSE = "EXPOSE"
    ENV = "ENV"
    ADD = "ADD"
    COPY = "COPY"
    ENTRYPOINT = "ENTRYPOINT"
    VOLUME = "VOLUME"
    USER = "USER"
    WORKDIR = "WORKDIR"
    ARG = "ARG"
    ONBUILD = "ONBUILD"
    STOPSIGNAL = "STOPSIGNAL"
    HEALTHCHECK = "HEALTHCHECK"
    SHELL = "SHELL"


class NoteKind(str, Enum):
    """
    Output only. This explicitly denotes which kind of note is specified. This field can be used as a filter in list requests.
    """
    KIND_UNSPECIFIED = "KIND_UNSPECIFIED"
    PACKAGE_VULNERABILITY = "PACKAGE_VULNERABILITY"
    BUILD_DETAILS = "BUILD_DETAILS"
    IMAGE_BASIS = "IMAGE_BASIS"
    PACKAGE_MANAGER = "PACKAGE_MANAGER"
    DEPLOYABLE = "DEPLOYABLE"
    DISCOVERY = "DISCOVERY"
    ATTESTATION_AUTHORITY = "ATTESTATION_AUTHORITY"
    UPGRADE = "UPGRADE"


class OccurrenceKind(str, Enum):
    """
    Output only. This explicitly denotes which of the `Occurrence` details are specified. This field can be used as a filter in list requests.
    """
    KIND_UNSPECIFIED = "KIND_UNSPECIFIED"
    PACKAGE_VULNERABILITY = "PACKAGE_VULNERABILITY"
    BUILD_DETAILS = "BUILD_DETAILS"
    IMAGE_BASIS = "IMAGE_BASIS"
    PACKAGE_MANAGER = "PACKAGE_MANAGER"
    DEPLOYABLE = "DEPLOYABLE"
    DISCOVERY = "DISCOVERY"
    ATTESTATION_AUTHORITY = "ATTESTATION_AUTHORITY"
    UPGRADE = "UPGRADE"


class PgpSignedAttestationContentType(str, Enum):
    """
    Type (for example schema) of the attestation payload that was signed. The verifier must ensure that the provided type is one that the verifier supports, and that the attestation payload is a valid instantiation of that type (for example by validating a JSON schema).
    """
    CONTENT_TYPE_UNSPECIFIED = "CONTENT_TYPE_UNSPECIFIED"
    SIMPLE_SIGNING_JSON = "SIMPLE_SIGNING_JSON"


class VersionKind(str, Enum):
    """
    Distinguish between sentinel MIN/MAX versions and normal versions. If kind is not NORMAL, then the other fields are ignored.
    """
    NORMAL = "NORMAL"
    MINIMUM = "MINIMUM"
    MAXIMUM = "MAXIMUM"


class VulnerabilityDetailsEffectiveSeverity(str, Enum):
    """
    The distro assigned severity for this vulnerability when that is available and note provider assigned severity when distro has not yet assigned a severity for this vulnerability.
    """
    SEVERITY_UNSPECIFIED = "SEVERITY_UNSPECIFIED"
    MINIMAL = "MINIMAL"
    LOW = "LOW"
    MEDIUM = "MEDIUM"
    HIGH = "HIGH"
    CRITICAL = "CRITICAL"


class VulnerabilityDetailsSeverity(str, Enum):
    """
    Output only. The note provider assigned Severity of the vulnerability.
    """
    SEVERITY_UNSPECIFIED = "SEVERITY_UNSPECIFIED"
    MINIMAL = "MINIMAL"
    LOW = "LOW"
    MEDIUM = "MEDIUM"
    HIGH = "HIGH"
    CRITICAL = "CRITICAL"


class VulnerabilityTypeSeverity(str, Enum):
    """
    Note provider assigned impact of the vulnerability
    """
    SEVERITY_UNSPECIFIED = "SEVERITY_UNSPECIFIED"
    MINIMAL = "MINIMAL"
    LOW = "LOW"
    MEDIUM = "MEDIUM"
    HIGH = "HIGH"
    CRITICAL = "CRITICAL"