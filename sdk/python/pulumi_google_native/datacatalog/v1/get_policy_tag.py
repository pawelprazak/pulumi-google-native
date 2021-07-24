# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from ... import _utilities

__all__ = [
    'GetPolicyTagResult',
    'AwaitableGetPolicyTagResult',
    'get_policy_tag',
]

@pulumi.output_type
class GetPolicyTagResult:
    def __init__(__self__, child_policy_tags=None, description=None, display_name=None, name=None, parent_policy_tag=None):
        if child_policy_tags and not isinstance(child_policy_tags, list):
            raise TypeError("Expected argument 'child_policy_tags' to be a list")
        pulumi.set(__self__, "child_policy_tags", child_policy_tags)
        if description and not isinstance(description, str):
            raise TypeError("Expected argument 'description' to be a str")
        pulumi.set(__self__, "description", description)
        if display_name and not isinstance(display_name, str):
            raise TypeError("Expected argument 'display_name' to be a str")
        pulumi.set(__self__, "display_name", display_name)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if parent_policy_tag and not isinstance(parent_policy_tag, str):
            raise TypeError("Expected argument 'parent_policy_tag' to be a str")
        pulumi.set(__self__, "parent_policy_tag", parent_policy_tag)

    @property
    @pulumi.getter(name="childPolicyTags")
    def child_policy_tags(self) -> Sequence[str]:
        """
        Resource names of child policy tags of this policy tag.
        """
        return pulumi.get(self, "child_policy_tags")

    @property
    @pulumi.getter
    def description(self) -> str:
        """
        Description of this policy tag. If not set, defaults to empty. The description must contain only Unicode characters, tabs, newlines, carriage returns and page breaks, and be at most 2000 bytes long when encoded in UTF-8.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="displayName")
    def display_name(self) -> str:
        """
        User-defined name of this policy tag. The name can't start or end with spaces and must be unique within the parent taxonomy, contain only Unicode letters, numbers, underscores, dashes and spaces, and be at most 200 bytes long when encoded in UTF-8.
        """
        return pulumi.get(self, "display_name")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Resource name of this policy tag in the URL format. The policy tag manager generates unique taxonomy IDs and policy tag IDs. 
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="parentPolicyTag")
    def parent_policy_tag(self) -> str:
        """
        Resource name of this policy tag's parent policy tag. If empty, this is a top level tag. If not set, defaults to an empty string. For example, for the "LatLong" policy tag in the example above, this field contains the resource name of the "Geolocation" policy tag, and, for "Geolocation", this field is empty.
        """
        return pulumi.get(self, "parent_policy_tag")


class AwaitableGetPolicyTagResult(GetPolicyTagResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetPolicyTagResult(
            child_policy_tags=self.child_policy_tags,
            description=self.description,
            display_name=self.display_name,
            name=self.name,
            parent_policy_tag=self.parent_policy_tag)


def get_policy_tag(location: Optional[str] = None,
                   policy_tag_id: Optional[str] = None,
                   project: Optional[str] = None,
                   taxonomy_id: Optional[str] = None,
                   opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetPolicyTagResult:
    """
    Gets a policy tag.
    """
    __args__ = dict()
    __args__['location'] = location
    __args__['policyTagId'] = policy_tag_id
    __args__['project'] = project
    __args__['taxonomyId'] = taxonomy_id
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('google-native:datacatalog/v1:getPolicyTag', __args__, opts=opts, typ=GetPolicyTagResult).value

    return AwaitableGetPolicyTagResult(
        child_policy_tags=__ret__.child_policy_tags,
        description=__ret__.description,
        display_name=__ret__.display_name,
        name=__ret__.name,
        parent_policy_tag=__ret__.parent_policy_tag)