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

__all__ = [
    'GoogleCloudRecaptchaenterpriseV1AndroidKeySettingsResponse',
    'GoogleCloudRecaptchaenterpriseV1IOSKeySettingsResponse',
    'GoogleCloudRecaptchaenterpriseV1TestingOptionsResponse',
    'GoogleCloudRecaptchaenterpriseV1WafSettingsResponse',
    'GoogleCloudRecaptchaenterpriseV1WebKeySettingsResponse',
]

@pulumi.output_type
class GoogleCloudRecaptchaenterpriseV1AndroidKeySettingsResponse(dict):
    """
    Settings specific to keys that can be used by Android apps.
    """
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "allowAllPackageNames":
            suggest = "allow_all_package_names"
        elif key == "allowedPackageNames":
            suggest = "allowed_package_names"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in GoogleCloudRecaptchaenterpriseV1AndroidKeySettingsResponse. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        GoogleCloudRecaptchaenterpriseV1AndroidKeySettingsResponse.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        GoogleCloudRecaptchaenterpriseV1AndroidKeySettingsResponse.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 allow_all_package_names: bool,
                 allowed_package_names: Sequence[str]):
        """
        Settings specific to keys that can be used by Android apps.
        :param bool allow_all_package_names: If set to true, allowed_package_names are not enforced.
        :param Sequence[str] allowed_package_names: Android package names of apps allowed to use the key. Example: 'com.companyname.appname'
        """
        pulumi.set(__self__, "allow_all_package_names", allow_all_package_names)
        pulumi.set(__self__, "allowed_package_names", allowed_package_names)

    @property
    @pulumi.getter(name="allowAllPackageNames")
    def allow_all_package_names(self) -> bool:
        """
        If set to true, allowed_package_names are not enforced.
        """
        return pulumi.get(self, "allow_all_package_names")

    @property
    @pulumi.getter(name="allowedPackageNames")
    def allowed_package_names(self) -> Sequence[str]:
        """
        Android package names of apps allowed to use the key. Example: 'com.companyname.appname'
        """
        return pulumi.get(self, "allowed_package_names")


@pulumi.output_type
class GoogleCloudRecaptchaenterpriseV1IOSKeySettingsResponse(dict):
    """
    Settings specific to keys that can be used by iOS apps.
    """
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "allowAllBundleIds":
            suggest = "allow_all_bundle_ids"
        elif key == "allowedBundleIds":
            suggest = "allowed_bundle_ids"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in GoogleCloudRecaptchaenterpriseV1IOSKeySettingsResponse. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        GoogleCloudRecaptchaenterpriseV1IOSKeySettingsResponse.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        GoogleCloudRecaptchaenterpriseV1IOSKeySettingsResponse.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 allow_all_bundle_ids: bool,
                 allowed_bundle_ids: Sequence[str]):
        """
        Settings specific to keys that can be used by iOS apps.
        :param bool allow_all_bundle_ids: If set to true, allowed_bundle_ids are not enforced.
        :param Sequence[str] allowed_bundle_ids: iOS bundle ids of apps allowed to use the key. Example: 'com.companyname.productname.appname'
        """
        pulumi.set(__self__, "allow_all_bundle_ids", allow_all_bundle_ids)
        pulumi.set(__self__, "allowed_bundle_ids", allowed_bundle_ids)

    @property
    @pulumi.getter(name="allowAllBundleIds")
    def allow_all_bundle_ids(self) -> bool:
        """
        If set to true, allowed_bundle_ids are not enforced.
        """
        return pulumi.get(self, "allow_all_bundle_ids")

    @property
    @pulumi.getter(name="allowedBundleIds")
    def allowed_bundle_ids(self) -> Sequence[str]:
        """
        iOS bundle ids of apps allowed to use the key. Example: 'com.companyname.productname.appname'
        """
        return pulumi.get(self, "allowed_bundle_ids")


@pulumi.output_type
class GoogleCloudRecaptchaenterpriseV1TestingOptionsResponse(dict):
    """
    Options for user acceptance testing.
    """
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "testingChallenge":
            suggest = "testing_challenge"
        elif key == "testingScore":
            suggest = "testing_score"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in GoogleCloudRecaptchaenterpriseV1TestingOptionsResponse. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        GoogleCloudRecaptchaenterpriseV1TestingOptionsResponse.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        GoogleCloudRecaptchaenterpriseV1TestingOptionsResponse.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 testing_challenge: str,
                 testing_score: float):
        """
        Options for user acceptance testing.
        :param str testing_challenge: For challenge-based keys only (CHECKBOX, INVISIBLE), all challenge requests for this site will return nocaptcha if NOCAPTCHA, or an unsolvable challenge if CHALLENGE.
        :param float testing_score: All assessments for this Key will return this score. Must be between 0 (likely not legitimate) and 1 (likely legitimate) inclusive.
        """
        pulumi.set(__self__, "testing_challenge", testing_challenge)
        pulumi.set(__self__, "testing_score", testing_score)

    @property
    @pulumi.getter(name="testingChallenge")
    def testing_challenge(self) -> str:
        """
        For challenge-based keys only (CHECKBOX, INVISIBLE), all challenge requests for this site will return nocaptcha if NOCAPTCHA, or an unsolvable challenge if CHALLENGE.
        """
        return pulumi.get(self, "testing_challenge")

    @property
    @pulumi.getter(name="testingScore")
    def testing_score(self) -> float:
        """
        All assessments for this Key will return this score. Must be between 0 (likely not legitimate) and 1 (likely legitimate) inclusive.
        """
        return pulumi.get(self, "testing_score")


@pulumi.output_type
class GoogleCloudRecaptchaenterpriseV1WafSettingsResponse(dict):
    """
    Settings specific to keys that can be used for WAF (Web Application Firewall).
    """
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "wafFeature":
            suggest = "waf_feature"
        elif key == "wafService":
            suggest = "waf_service"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in GoogleCloudRecaptchaenterpriseV1WafSettingsResponse. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        GoogleCloudRecaptchaenterpriseV1WafSettingsResponse.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        GoogleCloudRecaptchaenterpriseV1WafSettingsResponse.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 waf_feature: str,
                 waf_service: str):
        """
        Settings specific to keys that can be used for WAF (Web Application Firewall).
        :param str waf_feature: The WAF feature for which this key is enabled.
        :param str waf_service: The WAF service that uses this key.
        """
        pulumi.set(__self__, "waf_feature", waf_feature)
        pulumi.set(__self__, "waf_service", waf_service)

    @property
    @pulumi.getter(name="wafFeature")
    def waf_feature(self) -> str:
        """
        The WAF feature for which this key is enabled.
        """
        return pulumi.get(self, "waf_feature")

    @property
    @pulumi.getter(name="wafService")
    def waf_service(self) -> str:
        """
        The WAF service that uses this key.
        """
        return pulumi.get(self, "waf_service")


@pulumi.output_type
class GoogleCloudRecaptchaenterpriseV1WebKeySettingsResponse(dict):
    """
    Settings specific to keys that can be used by websites.
    """
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "allowAllDomains":
            suggest = "allow_all_domains"
        elif key == "allowAmpTraffic":
            suggest = "allow_amp_traffic"
        elif key == "allowedDomains":
            suggest = "allowed_domains"
        elif key == "challengeSecurityPreference":
            suggest = "challenge_security_preference"
        elif key == "integrationType":
            suggest = "integration_type"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in GoogleCloudRecaptchaenterpriseV1WebKeySettingsResponse. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        GoogleCloudRecaptchaenterpriseV1WebKeySettingsResponse.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        GoogleCloudRecaptchaenterpriseV1WebKeySettingsResponse.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 allow_all_domains: bool,
                 allow_amp_traffic: bool,
                 allowed_domains: Sequence[str],
                 challenge_security_preference: str,
                 integration_type: str):
        """
        Settings specific to keys that can be used by websites.
        :param bool allow_all_domains: If set to true, it means allowed_domains will not be enforced.
        :param bool allow_amp_traffic: If set to true, the key can be used on AMP (Accelerated Mobile Pages) websites. This is supported only for the SCORE integration type.
        :param Sequence[str] allowed_domains: Domains or subdomains of websites allowed to use the key. All subdomains of an allowed domain are automatically allowed. A valid domain requires a host and must not include any path, port, query or fragment. Examples: 'example.com' or 'subdomain.example.com'
        :param str challenge_security_preference: Settings for the frequency and difficulty at which this key triggers captcha challenges. This should only be specified for IntegrationTypes CHECKBOX and INVISIBLE.
        :param str integration_type: Describes how this key is integrated with the website.
        """
        pulumi.set(__self__, "allow_all_domains", allow_all_domains)
        pulumi.set(__self__, "allow_amp_traffic", allow_amp_traffic)
        pulumi.set(__self__, "allowed_domains", allowed_domains)
        pulumi.set(__self__, "challenge_security_preference", challenge_security_preference)
        pulumi.set(__self__, "integration_type", integration_type)

    @property
    @pulumi.getter(name="allowAllDomains")
    def allow_all_domains(self) -> bool:
        """
        If set to true, it means allowed_domains will not be enforced.
        """
        return pulumi.get(self, "allow_all_domains")

    @property
    @pulumi.getter(name="allowAmpTraffic")
    def allow_amp_traffic(self) -> bool:
        """
        If set to true, the key can be used on AMP (Accelerated Mobile Pages) websites. This is supported only for the SCORE integration type.
        """
        return pulumi.get(self, "allow_amp_traffic")

    @property
    @pulumi.getter(name="allowedDomains")
    def allowed_domains(self) -> Sequence[str]:
        """
        Domains or subdomains of websites allowed to use the key. All subdomains of an allowed domain are automatically allowed. A valid domain requires a host and must not include any path, port, query or fragment. Examples: 'example.com' or 'subdomain.example.com'
        """
        return pulumi.get(self, "allowed_domains")

    @property
    @pulumi.getter(name="challengeSecurityPreference")
    def challenge_security_preference(self) -> str:
        """
        Settings for the frequency and difficulty at which this key triggers captcha challenges. This should only be specified for IntegrationTypes CHECKBOX and INVISIBLE.
        """
        return pulumi.get(self, "challenge_security_preference")

    @property
    @pulumi.getter(name="integrationType")
    def integration_type(self) -> str:
        """
        Describes how this key is integrated with the website.
        """
        return pulumi.get(self, "integration_type")


