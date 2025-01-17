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
    'GetCustomerResult',
    'AwaitableGetCustomerResult',
    'get_customer',
    'get_customer_output',
]

@pulumi.output_type
class GetCustomerResult:
    def __init__(__self__, alternate_email=None, channel_partner_id=None, cloud_identity_id=None, cloud_identity_info=None, create_time=None, domain=None, language_code=None, name=None, org_display_name=None, org_postal_address=None, primary_contact_info=None, update_time=None):
        if alternate_email and not isinstance(alternate_email, str):
            raise TypeError("Expected argument 'alternate_email' to be a str")
        pulumi.set(__self__, "alternate_email", alternate_email)
        if channel_partner_id and not isinstance(channel_partner_id, str):
            raise TypeError("Expected argument 'channel_partner_id' to be a str")
        pulumi.set(__self__, "channel_partner_id", channel_partner_id)
        if cloud_identity_id and not isinstance(cloud_identity_id, str):
            raise TypeError("Expected argument 'cloud_identity_id' to be a str")
        pulumi.set(__self__, "cloud_identity_id", cloud_identity_id)
        if cloud_identity_info and not isinstance(cloud_identity_info, dict):
            raise TypeError("Expected argument 'cloud_identity_info' to be a dict")
        pulumi.set(__self__, "cloud_identity_info", cloud_identity_info)
        if create_time and not isinstance(create_time, str):
            raise TypeError("Expected argument 'create_time' to be a str")
        pulumi.set(__self__, "create_time", create_time)
        if domain and not isinstance(domain, str):
            raise TypeError("Expected argument 'domain' to be a str")
        pulumi.set(__self__, "domain", domain)
        if language_code and not isinstance(language_code, str):
            raise TypeError("Expected argument 'language_code' to be a str")
        pulumi.set(__self__, "language_code", language_code)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if org_display_name and not isinstance(org_display_name, str):
            raise TypeError("Expected argument 'org_display_name' to be a str")
        pulumi.set(__self__, "org_display_name", org_display_name)
        if org_postal_address and not isinstance(org_postal_address, dict):
            raise TypeError("Expected argument 'org_postal_address' to be a dict")
        pulumi.set(__self__, "org_postal_address", org_postal_address)
        if primary_contact_info and not isinstance(primary_contact_info, dict):
            raise TypeError("Expected argument 'primary_contact_info' to be a dict")
        pulumi.set(__self__, "primary_contact_info", primary_contact_info)
        if update_time and not isinstance(update_time, str):
            raise TypeError("Expected argument 'update_time' to be a str")
        pulumi.set(__self__, "update_time", update_time)

    @property
    @pulumi.getter(name="alternateEmail")
    def alternate_email(self) -> str:
        """
        Secondary contact email. You need to provide an alternate email to create different domains if a primary contact email already exists. Users will receive a notification with credentials when you create an admin.google.com account. Secondary emails are also recovery email addresses. Alternate emails are optional when you create Team customers.
        """
        return pulumi.get(self, "alternate_email")

    @property
    @pulumi.getter(name="channelPartnerId")
    def channel_partner_id(self) -> str:
        """
        Cloud Identity ID of the customer's channel partner. Populated only if a channel partner exists for this customer.
        """
        return pulumi.get(self, "channel_partner_id")

    @property
    @pulumi.getter(name="cloudIdentityId")
    def cloud_identity_id(self) -> str:
        """
        The customer's Cloud Identity ID if the customer has a Cloud Identity resource.
        """
        return pulumi.get(self, "cloud_identity_id")

    @property
    @pulumi.getter(name="cloudIdentityInfo")
    def cloud_identity_info(self) -> 'outputs.GoogleCloudChannelV1CloudIdentityInfoResponse':
        """
        Cloud Identity information for the customer. Populated only if a Cloud Identity account exists for this customer.
        """
        return pulumi.get(self, "cloud_identity_info")

    @property
    @pulumi.getter(name="createTime")
    def create_time(self) -> str:
        """
        Time when the customer was created.
        """
        return pulumi.get(self, "create_time")

    @property
    @pulumi.getter
    def domain(self) -> str:
        """
        The customer's primary domain. Must match the primary contact email's domain.
        """
        return pulumi.get(self, "domain")

    @property
    @pulumi.getter(name="languageCode")
    def language_code(self) -> str:
        """
        Optional. The BCP-47 language code, such as "en-US" or "sr-Latn". For more information, see https://www.unicode.org/reports/tr35/#Unicode_locale_identifier.
        """
        return pulumi.get(self, "language_code")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Resource name of the customer. Format: accounts/{account_id}/customers/{customer_id}
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="orgDisplayName")
    def org_display_name(self) -> str:
        """
        Name of the organization that the customer entity represents.
        """
        return pulumi.get(self, "org_display_name")

    @property
    @pulumi.getter(name="orgPostalAddress")
    def org_postal_address(self) -> 'outputs.GoogleTypePostalAddressResponse':
        """
        The organization address for the customer. To enforce US laws and embargoes, we require a region and zip code. You must provide valid addresses for every customer. To set the customer's language, use the Customer-level language code.
        """
        return pulumi.get(self, "org_postal_address")

    @property
    @pulumi.getter(name="primaryContactInfo")
    def primary_contact_info(self) -> 'outputs.GoogleCloudChannelV1ContactInfoResponse':
        """
        Primary contact info.
        """
        return pulumi.get(self, "primary_contact_info")

    @property
    @pulumi.getter(name="updateTime")
    def update_time(self) -> str:
        """
        Time when the customer was updated.
        """
        return pulumi.get(self, "update_time")


class AwaitableGetCustomerResult(GetCustomerResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetCustomerResult(
            alternate_email=self.alternate_email,
            channel_partner_id=self.channel_partner_id,
            cloud_identity_id=self.cloud_identity_id,
            cloud_identity_info=self.cloud_identity_info,
            create_time=self.create_time,
            domain=self.domain,
            language_code=self.language_code,
            name=self.name,
            org_display_name=self.org_display_name,
            org_postal_address=self.org_postal_address,
            primary_contact_info=self.primary_contact_info,
            update_time=self.update_time)


def get_customer(account_id: Optional[str] = None,
                 channel_partner_link_id: Optional[str] = None,
                 customer_id: Optional[str] = None,
                 opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetCustomerResult:
    """
    Returns the requested Customer resource. Possible error codes: * PERMISSION_DENIED: The reseller account making the request is different from the reseller account in the API request. * INVALID_ARGUMENT: Required request parameters are missing or invalid. * NOT_FOUND: The customer resource doesn't exist. Usually the result of an invalid name parameter. Return value: The Customer resource.
    """
    __args__ = dict()
    __args__['accountId'] = account_id
    __args__['channelPartnerLinkId'] = channel_partner_link_id
    __args__['customerId'] = customer_id
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('google-native:cloudchannel/v1:getCustomer', __args__, opts=opts, typ=GetCustomerResult).value

    return AwaitableGetCustomerResult(
        alternate_email=__ret__.alternate_email,
        channel_partner_id=__ret__.channel_partner_id,
        cloud_identity_id=__ret__.cloud_identity_id,
        cloud_identity_info=__ret__.cloud_identity_info,
        create_time=__ret__.create_time,
        domain=__ret__.domain,
        language_code=__ret__.language_code,
        name=__ret__.name,
        org_display_name=__ret__.org_display_name,
        org_postal_address=__ret__.org_postal_address,
        primary_contact_info=__ret__.primary_contact_info,
        update_time=__ret__.update_time)


@_utilities.lift_output_func(get_customer)
def get_customer_output(account_id: Optional[pulumi.Input[str]] = None,
                        channel_partner_link_id: Optional[pulumi.Input[str]] = None,
                        customer_id: Optional[pulumi.Input[str]] = None,
                        opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetCustomerResult]:
    """
    Returns the requested Customer resource. Possible error codes: * PERMISSION_DENIED: The reseller account making the request is different from the reseller account in the API request. * INVALID_ARGUMENT: Required request parameters are missing or invalid. * NOT_FOUND: The customer resource doesn't exist. Usually the result of an invalid name parameter. Return value: The Customer resource.
    """
    ...
