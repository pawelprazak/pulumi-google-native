# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

from enum import Enum

__all__ = [
    'BasicLevelCombiningFunction',
    'DevicePolicyAllowedDeviceManagementLevelsItem',
    'DevicePolicyAllowedEncryptionStatusesItem',
    'OsConstraintOsType',
    'ServicePerimeterPerimeterType',
]


class BasicLevelCombiningFunction(str, Enum):
    """
    How the `conditions` list should be combined to determine if a request is granted this `AccessLevel`. If AND is used, each `Condition` in `conditions` must be satisfied for the `AccessLevel` to be applied. If OR is used, at least one `Condition` in `conditions` must be satisfied for the `AccessLevel` to be applied. Default behavior is AND.
    """
    AND_ = "AND"
    """
    All `Conditions` must be true for the `BasicLevel` to be true.
    """
    OR_ = "OR"
    """
    If at least one `Condition` is true, then the `BasicLevel` is true.
    """


class DevicePolicyAllowedDeviceManagementLevelsItem(str, Enum):
    MANAGEMENT_UNSPECIFIED = "MANAGEMENT_UNSPECIFIED"
    """
    The device's management level is not specified or not known.
    """
    NONE = "NONE"
    """
    The device is not managed.
    """
    BASIC = "BASIC"
    """
    Basic management is enabled, which is generally limited to monitoring and wiping the corporate account.
    """
    COMPLETE = "COMPLETE"
    """
    Complete device management. This includes more thorough monitoring and the ability to directly manage the device (such as remote wiping). This can be enabled through the Android Enterprise Platform.
    """


class DevicePolicyAllowedEncryptionStatusesItem(str, Enum):
    ENCRYPTION_UNSPECIFIED = "ENCRYPTION_UNSPECIFIED"
    """
    The encryption status of the device is not specified or not known.
    """
    ENCRYPTION_UNSUPPORTED = "ENCRYPTION_UNSUPPORTED"
    """
    The device does not support encryption.
    """
    UNENCRYPTED = "UNENCRYPTED"
    """
    The device supports encryption, but is currently unencrypted.
    """
    ENCRYPTED = "ENCRYPTED"
    """
    The device is encrypted.
    """


class OsConstraintOsType(str, Enum):
    """
    Required. The allowed OS type.
    """
    OS_UNSPECIFIED = "OS_UNSPECIFIED"
    """
    The operating system of the device is not specified or not known.
    """
    DESKTOP_MAC = "DESKTOP_MAC"
    """
    A desktop Mac operating system.
    """
    DESKTOP_WINDOWS = "DESKTOP_WINDOWS"
    """
    A desktop Windows operating system.
    """
    DESKTOP_LINUX = "DESKTOP_LINUX"
    """
    A desktop Linux operating system.
    """
    DESKTOP_CHROME_OS = "DESKTOP_CHROME_OS"
    """
    A desktop ChromeOS operating system.
    """
    ANDROID = "ANDROID"
    """
    An Android operating system.
    """
    IOS = "IOS"
    """
    An iOS operating system.
    """


class ServicePerimeterPerimeterType(str, Enum):
    """
    Perimeter type indicator. A single project is allowed to be a member of single regular perimeter, but multiple service perimeter bridges. A project cannot be a included in a perimeter bridge without being included in regular perimeter. For perimeter bridges, restricted/unrestricted service lists as well as access lists must be empty.
    """
    PERIMETER_TYPE_REGULAR = "PERIMETER_TYPE_REGULAR"
    """
    Regular Perimeter.
    """
    PERIMETER_TYPE_BRIDGE = "PERIMETER_TYPE_BRIDGE"
    """
    Perimeter Bridge.
    """
