# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

from enum import Enum

__all__ = [
    'FeedContentType',
]


class FeedContentType(str, Enum):
    """
    Asset content type. If not specified, no content but the asset name and type will be returned.
    """
    CONTENT_TYPE_UNSPECIFIED = "CONTENT_TYPE_UNSPECIFIED"
    """
    Unspecified content type.
    """
    RESOURCE = "RESOURCE"
    """
    Resource metadata.
    """
    IAM_POLICY = "IAM_POLICY"
    """
    The actual IAM policy set on a resource.
    """
    ORG_POLICY = "ORG_POLICY"
    """
    The Cloud Organization Policy set on an asset.
    """
    ACCESS_POLICY = "ACCESS_POLICY"
    """
    The Cloud Access context manager Policy set on an asset.
    """
    OS_INVENTORY = "OS_INVENTORY"
    """
    The runtime OS Inventory information.
    """
    RELATIONSHIP = "RELATIONSHIP"
    """
    The related resources.
    """
