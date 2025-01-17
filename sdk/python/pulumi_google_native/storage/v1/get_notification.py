# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from ... import _utilities

__all__ = [
    'GetNotificationResult',
    'AwaitableGetNotificationResult',
    'get_notification',
    'get_notification_output',
]

@pulumi.output_type
class GetNotificationResult:
    def __init__(__self__, custom_attributes=None, etag=None, event_types=None, kind=None, object_name_prefix=None, payload_format=None, self_link=None, topic=None):
        if custom_attributes and not isinstance(custom_attributes, dict):
            raise TypeError("Expected argument 'custom_attributes' to be a dict")
        pulumi.set(__self__, "custom_attributes", custom_attributes)
        if etag and not isinstance(etag, str):
            raise TypeError("Expected argument 'etag' to be a str")
        pulumi.set(__self__, "etag", etag)
        if event_types and not isinstance(event_types, list):
            raise TypeError("Expected argument 'event_types' to be a list")
        pulumi.set(__self__, "event_types", event_types)
        if kind and not isinstance(kind, str):
            raise TypeError("Expected argument 'kind' to be a str")
        pulumi.set(__self__, "kind", kind)
        if object_name_prefix and not isinstance(object_name_prefix, str):
            raise TypeError("Expected argument 'object_name_prefix' to be a str")
        pulumi.set(__self__, "object_name_prefix", object_name_prefix)
        if payload_format and not isinstance(payload_format, str):
            raise TypeError("Expected argument 'payload_format' to be a str")
        pulumi.set(__self__, "payload_format", payload_format)
        if self_link and not isinstance(self_link, str):
            raise TypeError("Expected argument 'self_link' to be a str")
        pulumi.set(__self__, "self_link", self_link)
        if topic and not isinstance(topic, str):
            raise TypeError("Expected argument 'topic' to be a str")
        pulumi.set(__self__, "topic", topic)

    @property
    @pulumi.getter(name="customAttributes")
    def custom_attributes(self) -> Mapping[str, str]:
        """
        An optional list of additional attributes to attach to each Cloud PubSub message published for this notification subscription.
        """
        return pulumi.get(self, "custom_attributes")

    @property
    @pulumi.getter
    def etag(self) -> str:
        """
        HTTP 1.1 Entity tag for this subscription notification.
        """
        return pulumi.get(self, "etag")

    @property
    @pulumi.getter(name="eventTypes")
    def event_types(self) -> Sequence[str]:
        """
        If present, only send notifications about listed event types. If empty, sent notifications for all event types.
        """
        return pulumi.get(self, "event_types")

    @property
    @pulumi.getter
    def kind(self) -> str:
        """
        The kind of item this is. For notifications, this is always storage#notification.
        """
        return pulumi.get(self, "kind")

    @property
    @pulumi.getter(name="objectNamePrefix")
    def object_name_prefix(self) -> str:
        """
        If present, only apply this notification configuration to object names that begin with this prefix.
        """
        return pulumi.get(self, "object_name_prefix")

    @property
    @pulumi.getter(name="payloadFormat")
    def payload_format(self) -> str:
        """
        The desired content of the Payload.
        """
        return pulumi.get(self, "payload_format")

    @property
    @pulumi.getter(name="selfLink")
    def self_link(self) -> str:
        """
        The canonical URL of this notification.
        """
        return pulumi.get(self, "self_link")

    @property
    @pulumi.getter
    def topic(self) -> str:
        """
        The Cloud PubSub topic to which this subscription publishes. Formatted as: '//pubsub.googleapis.com/projects/{project-identifier}/topics/{my-topic}'
        """
        return pulumi.get(self, "topic")


class AwaitableGetNotificationResult(GetNotificationResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetNotificationResult(
            custom_attributes=self.custom_attributes,
            etag=self.etag,
            event_types=self.event_types,
            kind=self.kind,
            object_name_prefix=self.object_name_prefix,
            payload_format=self.payload_format,
            self_link=self.self_link,
            topic=self.topic)


def get_notification(bucket: Optional[str] = None,
                     notification: Optional[str] = None,
                     user_project: Optional[str] = None,
                     opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetNotificationResult:
    """
    View a notification configuration.
    """
    __args__ = dict()
    __args__['bucket'] = bucket
    __args__['notification'] = notification
    __args__['userProject'] = user_project
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('google-native:storage/v1:getNotification', __args__, opts=opts, typ=GetNotificationResult).value

    return AwaitableGetNotificationResult(
        custom_attributes=__ret__.custom_attributes,
        etag=__ret__.etag,
        event_types=__ret__.event_types,
        kind=__ret__.kind,
        object_name_prefix=__ret__.object_name_prefix,
        payload_format=__ret__.payload_format,
        self_link=__ret__.self_link,
        topic=__ret__.topic)


@_utilities.lift_output_func(get_notification)
def get_notification_output(bucket: Optional[pulumi.Input[str]] = None,
                            notification: Optional[pulumi.Input[str]] = None,
                            user_project: Optional[pulumi.Input[Optional[str]]] = None,
                            opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetNotificationResult]:
    """
    View a notification configuration.
    """
    ...
