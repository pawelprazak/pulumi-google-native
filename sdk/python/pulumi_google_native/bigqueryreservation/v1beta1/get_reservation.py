# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from ... import _utilities

__all__ = [
    'GetReservationResult',
    'AwaitableGetReservationResult',
    'get_reservation',
]

@pulumi.output_type
class GetReservationResult:
    def __init__(__self__, creation_time=None, ignore_idle_slots=None, name=None, slot_capacity=None, update_time=None):
        if creation_time and not isinstance(creation_time, str):
            raise TypeError("Expected argument 'creation_time' to be a str")
        pulumi.set(__self__, "creation_time", creation_time)
        if ignore_idle_slots and not isinstance(ignore_idle_slots, bool):
            raise TypeError("Expected argument 'ignore_idle_slots' to be a bool")
        pulumi.set(__self__, "ignore_idle_slots", ignore_idle_slots)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if slot_capacity and not isinstance(slot_capacity, str):
            raise TypeError("Expected argument 'slot_capacity' to be a str")
        pulumi.set(__self__, "slot_capacity", slot_capacity)
        if update_time and not isinstance(update_time, str):
            raise TypeError("Expected argument 'update_time' to be a str")
        pulumi.set(__self__, "update_time", update_time)

    @property
    @pulumi.getter(name="creationTime")
    def creation_time(self) -> str:
        """
        Creation time of the reservation.
        """
        return pulumi.get(self, "creation_time")

    @property
    @pulumi.getter(name="ignoreIdleSlots")
    def ignore_idle_slots(self) -> bool:
        """
        If false, any query using this reservation will use idle slots from other reservations within the same admin project. If true, a query using this reservation will execute with the slot capacity specified above at most.
        """
        return pulumi.get(self, "ignore_idle_slots")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        The resource name of the reservation, e.g., `projects/*/locations/*/reservations/team1-prod`.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="slotCapacity")
    def slot_capacity(self) -> str:
        """
        Minimum slots available to this reservation. A slot is a unit of computational power in BigQuery, and serves as the unit of parallelism. Queries using this reservation might use more slots during runtime if ignore_idle_slots is set to false. If the new reservation's slot capacity exceed the parent's slot capacity or if total slot capacity of the new reservation and its siblings exceeds the parent's slot capacity, the request will fail with `google.rpc.Code.RESOURCE_EXHAUSTED`.
        """
        return pulumi.get(self, "slot_capacity")

    @property
    @pulumi.getter(name="updateTime")
    def update_time(self) -> str:
        """
        Last update time of the reservation.
        """
        return pulumi.get(self, "update_time")


class AwaitableGetReservationResult(GetReservationResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetReservationResult(
            creation_time=self.creation_time,
            ignore_idle_slots=self.ignore_idle_slots,
            name=self.name,
            slot_capacity=self.slot_capacity,
            update_time=self.update_time)


def get_reservation(location: Optional[str] = None,
                    project: Optional[str] = None,
                    reservation_id: Optional[str] = None,
                    opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetReservationResult:
    """
    Returns information about the reservation.
    """
    __args__ = dict()
    __args__['location'] = location
    __args__['project'] = project
    __args__['reservationId'] = reservation_id
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('google-native:bigqueryreservation/v1beta1:getReservation', __args__, opts=opts, typ=GetReservationResult).value

    return AwaitableGetReservationResult(
        creation_time=__ret__.creation_time,
        ignore_idle_slots=__ret__.ignore_idle_slots,
        name=__ret__.name,
        slot_capacity=__ret__.slot_capacity,
        update_time=__ret__.update_time)