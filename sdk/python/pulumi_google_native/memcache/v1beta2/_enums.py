# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

from enum import Enum

__all__ = [
    'InstanceMemcacheVersion',
    'InstanceMessageCode',
    'WeeklyMaintenanceWindowDay',
]


class InstanceMemcacheVersion(str, Enum):
    """
    The major version of Memcached software. If not provided, latest supported version will be used. Currently the latest supported major version is `MEMCACHE_1_5`. The minor version will be automatically determined by our system based on the latest supported minor version.
    """
    MEMCACHE_VERSION_UNSPECIFIED = "MEMCACHE_VERSION_UNSPECIFIED"
    MEMCACHE15 = "MEMCACHE_1_5"
    """
    Memcached 1.5 version.
    """


class InstanceMessageCode(str, Enum):
    """
    A code that correspond to one type of user-facing message.
    """
    CODE_UNSPECIFIED = "CODE_UNSPECIFIED"
    """
    Message Code not set.
    """
    ZONE_DISTRIBUTION_UNBALANCED = "ZONE_DISTRIBUTION_UNBALANCED"
    """
    Memcached nodes are distributed unevenly.
    """


class WeeklyMaintenanceWindowDay(str, Enum):
    """
    Required. Allows to define schedule that runs specified day of the week.
    """
    DAY_OF_WEEK_UNSPECIFIED = "DAY_OF_WEEK_UNSPECIFIED"
    """
    The day of the week is unspecified.
    """
    MONDAY = "MONDAY"
    """
    Monday
    """
    TUESDAY = "TUESDAY"
    """
    Tuesday
    """
    WEDNESDAY = "WEDNESDAY"
    """
    Wednesday
    """
    THURSDAY = "THURSDAY"
    """
    Thursday
    """
    FRIDAY = "FRIDAY"
    """
    Friday
    """
    SATURDAY = "SATURDAY"
    """
    Saturday
    """
    SUNDAY = "SUNDAY"
    """
    Sunday
    """
