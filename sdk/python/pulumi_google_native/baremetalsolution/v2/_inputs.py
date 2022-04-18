# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from ... import _utilities
from ._enums import *

__all__ = [
    'InstanceConfigArgs',
    'IntakeVlanAttachmentArgs',
    'LunRangeArgs',
    'NetworkAddressArgs',
    'NetworkConfigArgs',
    'NfsExportArgs',
    'ScheduleArgs',
    'VolumeConfigArgs',
]

@pulumi.input_type
class InstanceConfigArgs:
    def __init__(__self__, *,
                 account_networks_enabled: Optional[pulumi.Input[bool]] = None,
                 client_network: Optional[pulumi.Input['NetworkAddressArgs']] = None,
                 hyperthreading: Optional[pulumi.Input[bool]] = None,
                 id: Optional[pulumi.Input[str]] = None,
                 instance_type: Optional[pulumi.Input[str]] = None,
                 os_image: Optional[pulumi.Input[str]] = None,
                 private_network: Optional[pulumi.Input['NetworkAddressArgs']] = None,
                 user_note: Optional[pulumi.Input[str]] = None):
        """
        Configuration parameters for a new instance.
        :param pulumi.Input[bool] account_networks_enabled: If true networks can be from different projects of the same vendor account.
        :param pulumi.Input['NetworkAddressArgs'] client_network: Client network address.
        :param pulumi.Input[bool] hyperthreading: Whether the instance should be provisioned with Hyperthreading enabled.
        :param pulumi.Input[str] id: A transient unique identifier to idenfity an instance within an ProvisioningConfig request.
        :param pulumi.Input[str] instance_type: Instance type. [Available types](https://cloud.google.com/bare-metal/docs/bms-planning#server_configurations)
        :param pulumi.Input[str] os_image: OS image to initialize the instance. [Available images](https://cloud.google.com/bare-metal/docs/bms-planning#server_configurations)
        :param pulumi.Input['NetworkAddressArgs'] private_network: Private network address, if any.
        :param pulumi.Input[str] user_note: User note field, it can be used by customers to add additional information for the BMS Ops team .
        """
        if account_networks_enabled is not None:
            pulumi.set(__self__, "account_networks_enabled", account_networks_enabled)
        if client_network is not None:
            pulumi.set(__self__, "client_network", client_network)
        if hyperthreading is not None:
            pulumi.set(__self__, "hyperthreading", hyperthreading)
        if id is not None:
            pulumi.set(__self__, "id", id)
        if instance_type is not None:
            pulumi.set(__self__, "instance_type", instance_type)
        if os_image is not None:
            pulumi.set(__self__, "os_image", os_image)
        if private_network is not None:
            pulumi.set(__self__, "private_network", private_network)
        if user_note is not None:
            pulumi.set(__self__, "user_note", user_note)

    @property
    @pulumi.getter(name="accountNetworksEnabled")
    def account_networks_enabled(self) -> Optional[pulumi.Input[bool]]:
        """
        If true networks can be from different projects of the same vendor account.
        """
        return pulumi.get(self, "account_networks_enabled")

    @account_networks_enabled.setter
    def account_networks_enabled(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "account_networks_enabled", value)

    @property
    @pulumi.getter(name="clientNetwork")
    def client_network(self) -> Optional[pulumi.Input['NetworkAddressArgs']]:
        """
        Client network address.
        """
        return pulumi.get(self, "client_network")

    @client_network.setter
    def client_network(self, value: Optional[pulumi.Input['NetworkAddressArgs']]):
        pulumi.set(self, "client_network", value)

    @property
    @pulumi.getter
    def hyperthreading(self) -> Optional[pulumi.Input[bool]]:
        """
        Whether the instance should be provisioned with Hyperthreading enabled.
        """
        return pulumi.get(self, "hyperthreading")

    @hyperthreading.setter
    def hyperthreading(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "hyperthreading", value)

    @property
    @pulumi.getter
    def id(self) -> Optional[pulumi.Input[str]]:
        """
        A transient unique identifier to idenfity an instance within an ProvisioningConfig request.
        """
        return pulumi.get(self, "id")

    @id.setter
    def id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "id", value)

    @property
    @pulumi.getter(name="instanceType")
    def instance_type(self) -> Optional[pulumi.Input[str]]:
        """
        Instance type. [Available types](https://cloud.google.com/bare-metal/docs/bms-planning#server_configurations)
        """
        return pulumi.get(self, "instance_type")

    @instance_type.setter
    def instance_type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "instance_type", value)

    @property
    @pulumi.getter(name="osImage")
    def os_image(self) -> Optional[pulumi.Input[str]]:
        """
        OS image to initialize the instance. [Available images](https://cloud.google.com/bare-metal/docs/bms-planning#server_configurations)
        """
        return pulumi.get(self, "os_image")

    @os_image.setter
    def os_image(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "os_image", value)

    @property
    @pulumi.getter(name="privateNetwork")
    def private_network(self) -> Optional[pulumi.Input['NetworkAddressArgs']]:
        """
        Private network address, if any.
        """
        return pulumi.get(self, "private_network")

    @private_network.setter
    def private_network(self, value: Optional[pulumi.Input['NetworkAddressArgs']]):
        pulumi.set(self, "private_network", value)

    @property
    @pulumi.getter(name="userNote")
    def user_note(self) -> Optional[pulumi.Input[str]]:
        """
        User note field, it can be used by customers to add additional information for the BMS Ops team .
        """
        return pulumi.get(self, "user_note")

    @user_note.setter
    def user_note(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "user_note", value)


@pulumi.input_type
class IntakeVlanAttachmentArgs:
    def __init__(__self__, *,
                 id: Optional[pulumi.Input[str]] = None,
                 pairing_key: Optional[pulumi.Input[str]] = None):
        """
        A GCP vlan attachment.
        :param pulumi.Input[str] id: Identifier of the VLAN attachment.
        :param pulumi.Input[str] pairing_key: Attachment pairing key.
        """
        if id is not None:
            pulumi.set(__self__, "id", id)
        if pairing_key is not None:
            pulumi.set(__self__, "pairing_key", pairing_key)

    @property
    @pulumi.getter
    def id(self) -> Optional[pulumi.Input[str]]:
        """
        Identifier of the VLAN attachment.
        """
        return pulumi.get(self, "id")

    @id.setter
    def id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "id", value)

    @property
    @pulumi.getter(name="pairingKey")
    def pairing_key(self) -> Optional[pulumi.Input[str]]:
        """
        Attachment pairing key.
        """
        return pulumi.get(self, "pairing_key")

    @pairing_key.setter
    def pairing_key(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "pairing_key", value)


@pulumi.input_type
class LunRangeArgs:
    def __init__(__self__, *,
                 quantity: Optional[pulumi.Input[int]] = None,
                 size_gb: Optional[pulumi.Input[int]] = None):
        """
        A LUN(Logical Unit Number) range.
        :param pulumi.Input[int] quantity: Number of LUNs to create.
        :param pulumi.Input[int] size_gb: The requested size of each LUN, in GB.
        """
        if quantity is not None:
            pulumi.set(__self__, "quantity", quantity)
        if size_gb is not None:
            pulumi.set(__self__, "size_gb", size_gb)

    @property
    @pulumi.getter
    def quantity(self) -> Optional[pulumi.Input[int]]:
        """
        Number of LUNs to create.
        """
        return pulumi.get(self, "quantity")

    @quantity.setter
    def quantity(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "quantity", value)

    @property
    @pulumi.getter(name="sizeGb")
    def size_gb(self) -> Optional[pulumi.Input[int]]:
        """
        The requested size of each LUN, in GB.
        """
        return pulumi.get(self, "size_gb")

    @size_gb.setter
    def size_gb(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "size_gb", value)


@pulumi.input_type
class NetworkAddressArgs:
    def __init__(__self__, *,
                 address: Optional[pulumi.Input[str]] = None,
                 existing_network_id: Optional[pulumi.Input[str]] = None,
                 network_id: Optional[pulumi.Input[str]] = None):
        """
        A network.
        :param pulumi.Input[str] address: IPv4 address to be assigned to the server.
        :param pulumi.Input[str] existing_network_id: Name of the existing network to use.
        :param pulumi.Input[str] network_id: Id of the network to use, within the same ProvisioningConfig request.
        """
        if address is not None:
            pulumi.set(__self__, "address", address)
        if existing_network_id is not None:
            pulumi.set(__self__, "existing_network_id", existing_network_id)
        if network_id is not None:
            pulumi.set(__self__, "network_id", network_id)

    @property
    @pulumi.getter
    def address(self) -> Optional[pulumi.Input[str]]:
        """
        IPv4 address to be assigned to the server.
        """
        return pulumi.get(self, "address")

    @address.setter
    def address(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "address", value)

    @property
    @pulumi.getter(name="existingNetworkId")
    def existing_network_id(self) -> Optional[pulumi.Input[str]]:
        """
        Name of the existing network to use.
        """
        return pulumi.get(self, "existing_network_id")

    @existing_network_id.setter
    def existing_network_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "existing_network_id", value)

    @property
    @pulumi.getter(name="networkId")
    def network_id(self) -> Optional[pulumi.Input[str]]:
        """
        Id of the network to use, within the same ProvisioningConfig request.
        """
        return pulumi.get(self, "network_id")

    @network_id.setter
    def network_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "network_id", value)


@pulumi.input_type
class NetworkConfigArgs:
    def __init__(__self__, *,
                 bandwidth: Optional[pulumi.Input['NetworkConfigBandwidth']] = None,
                 cidr: Optional[pulumi.Input[str]] = None,
                 gcp_service: Optional[pulumi.Input[str]] = None,
                 id: Optional[pulumi.Input[str]] = None,
                 service_cidr: Optional[pulumi.Input['NetworkConfigServiceCidr']] = None,
                 type: Optional[pulumi.Input['NetworkConfigType']] = None,
                 user_note: Optional[pulumi.Input[str]] = None,
                 vlan_attachments: Optional[pulumi.Input[Sequence[pulumi.Input['IntakeVlanAttachmentArgs']]]] = None,
                 vlan_same_project: Optional[pulumi.Input[bool]] = None):
        """
        Configuration parameters for a new network.
        :param pulumi.Input['NetworkConfigBandwidth'] bandwidth: Interconnect bandwidth. Set only when type is CLIENT.
        :param pulumi.Input[str] cidr: CIDR range of the network.
        :param pulumi.Input[str] gcp_service: The GCP service of the network. Available gcp_service are in https://cloud.google.com/bare-metal/docs/bms-planning.
        :param pulumi.Input[str] id: A transient unique identifier to identify a volume within an ProvisioningConfig request.
        :param pulumi.Input['NetworkConfigServiceCidr'] service_cidr: Service CIDR, if any.
        :param pulumi.Input['NetworkConfigType'] type: The type of this network, either Client or Private.
        :param pulumi.Input[str] user_note: User note field, it can be used by customers to add additional information for the BMS Ops team (b/194021617).
        :param pulumi.Input[Sequence[pulumi.Input['IntakeVlanAttachmentArgs']]] vlan_attachments: List of VLAN attachments. As of now there are always 2 attachments, but it is going to change in the future (multi vlan).
        :param pulumi.Input[bool] vlan_same_project: Whether the VLAN attachment pair is located in the same project.
        """
        if bandwidth is not None:
            pulumi.set(__self__, "bandwidth", bandwidth)
        if cidr is not None:
            pulumi.set(__self__, "cidr", cidr)
        if gcp_service is not None:
            pulumi.set(__self__, "gcp_service", gcp_service)
        if id is not None:
            pulumi.set(__self__, "id", id)
        if service_cidr is not None:
            pulumi.set(__self__, "service_cidr", service_cidr)
        if type is not None:
            pulumi.set(__self__, "type", type)
        if user_note is not None:
            pulumi.set(__self__, "user_note", user_note)
        if vlan_attachments is not None:
            pulumi.set(__self__, "vlan_attachments", vlan_attachments)
        if vlan_same_project is not None:
            pulumi.set(__self__, "vlan_same_project", vlan_same_project)

    @property
    @pulumi.getter
    def bandwidth(self) -> Optional[pulumi.Input['NetworkConfigBandwidth']]:
        """
        Interconnect bandwidth. Set only when type is CLIENT.
        """
        return pulumi.get(self, "bandwidth")

    @bandwidth.setter
    def bandwidth(self, value: Optional[pulumi.Input['NetworkConfigBandwidth']]):
        pulumi.set(self, "bandwidth", value)

    @property
    @pulumi.getter
    def cidr(self) -> Optional[pulumi.Input[str]]:
        """
        CIDR range of the network.
        """
        return pulumi.get(self, "cidr")

    @cidr.setter
    def cidr(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "cidr", value)

    @property
    @pulumi.getter(name="gcpService")
    def gcp_service(self) -> Optional[pulumi.Input[str]]:
        """
        The GCP service of the network. Available gcp_service are in https://cloud.google.com/bare-metal/docs/bms-planning.
        """
        return pulumi.get(self, "gcp_service")

    @gcp_service.setter
    def gcp_service(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "gcp_service", value)

    @property
    @pulumi.getter
    def id(self) -> Optional[pulumi.Input[str]]:
        """
        A transient unique identifier to identify a volume within an ProvisioningConfig request.
        """
        return pulumi.get(self, "id")

    @id.setter
    def id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "id", value)

    @property
    @pulumi.getter(name="serviceCidr")
    def service_cidr(self) -> Optional[pulumi.Input['NetworkConfigServiceCidr']]:
        """
        Service CIDR, if any.
        """
        return pulumi.get(self, "service_cidr")

    @service_cidr.setter
    def service_cidr(self, value: Optional[pulumi.Input['NetworkConfigServiceCidr']]):
        pulumi.set(self, "service_cidr", value)

    @property
    @pulumi.getter
    def type(self) -> Optional[pulumi.Input['NetworkConfigType']]:
        """
        The type of this network, either Client or Private.
        """
        return pulumi.get(self, "type")

    @type.setter
    def type(self, value: Optional[pulumi.Input['NetworkConfigType']]):
        pulumi.set(self, "type", value)

    @property
    @pulumi.getter(name="userNote")
    def user_note(self) -> Optional[pulumi.Input[str]]:
        """
        User note field, it can be used by customers to add additional information for the BMS Ops team (b/194021617).
        """
        return pulumi.get(self, "user_note")

    @user_note.setter
    def user_note(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "user_note", value)

    @property
    @pulumi.getter(name="vlanAttachments")
    def vlan_attachments(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['IntakeVlanAttachmentArgs']]]]:
        """
        List of VLAN attachments. As of now there are always 2 attachments, but it is going to change in the future (multi vlan).
        """
        return pulumi.get(self, "vlan_attachments")

    @vlan_attachments.setter
    def vlan_attachments(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['IntakeVlanAttachmentArgs']]]]):
        pulumi.set(self, "vlan_attachments", value)

    @property
    @pulumi.getter(name="vlanSameProject")
    def vlan_same_project(self) -> Optional[pulumi.Input[bool]]:
        """
        Whether the VLAN attachment pair is located in the same project.
        """
        return pulumi.get(self, "vlan_same_project")

    @vlan_same_project.setter
    def vlan_same_project(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "vlan_same_project", value)


@pulumi.input_type
class NfsExportArgs:
    def __init__(__self__, *,
                 allow_dev: Optional[pulumi.Input[bool]] = None,
                 allow_suid: Optional[pulumi.Input[bool]] = None,
                 cidr: Optional[pulumi.Input[str]] = None,
                 machine_id: Optional[pulumi.Input[str]] = None,
                 network_id: Optional[pulumi.Input[str]] = None,
                 no_root_squash: Optional[pulumi.Input[bool]] = None,
                 permissions: Optional[pulumi.Input['NfsExportPermissions']] = None):
        """
        A NFS export entry.
        :param pulumi.Input[bool] allow_dev: Allow dev flag in NfsShare AllowedClientsRequest.
        :param pulumi.Input[bool] allow_suid: Allow the setuid flag.
        :param pulumi.Input[str] cidr: A CIDR range.
        :param pulumi.Input[str] machine_id: Either a single machine, identified by an ID, or a comma-separated list of machine IDs.
        :param pulumi.Input[str] network_id: Network to use to publish the export.
        :param pulumi.Input[bool] no_root_squash: Disable root squashing, which is a feature of NFS. Root squash is a special mapping of the remote superuser (root) identity when using identity authentication.
        :param pulumi.Input['NfsExportPermissions'] permissions: Export permissions.
        """
        if allow_dev is not None:
            pulumi.set(__self__, "allow_dev", allow_dev)
        if allow_suid is not None:
            pulumi.set(__self__, "allow_suid", allow_suid)
        if cidr is not None:
            pulumi.set(__self__, "cidr", cidr)
        if machine_id is not None:
            pulumi.set(__self__, "machine_id", machine_id)
        if network_id is not None:
            pulumi.set(__self__, "network_id", network_id)
        if no_root_squash is not None:
            pulumi.set(__self__, "no_root_squash", no_root_squash)
        if permissions is not None:
            pulumi.set(__self__, "permissions", permissions)

    @property
    @pulumi.getter(name="allowDev")
    def allow_dev(self) -> Optional[pulumi.Input[bool]]:
        """
        Allow dev flag in NfsShare AllowedClientsRequest.
        """
        return pulumi.get(self, "allow_dev")

    @allow_dev.setter
    def allow_dev(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "allow_dev", value)

    @property
    @pulumi.getter(name="allowSuid")
    def allow_suid(self) -> Optional[pulumi.Input[bool]]:
        """
        Allow the setuid flag.
        """
        return pulumi.get(self, "allow_suid")

    @allow_suid.setter
    def allow_suid(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "allow_suid", value)

    @property
    @pulumi.getter
    def cidr(self) -> Optional[pulumi.Input[str]]:
        """
        A CIDR range.
        """
        return pulumi.get(self, "cidr")

    @cidr.setter
    def cidr(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "cidr", value)

    @property
    @pulumi.getter(name="machineId")
    def machine_id(self) -> Optional[pulumi.Input[str]]:
        """
        Either a single machine, identified by an ID, or a comma-separated list of machine IDs.
        """
        return pulumi.get(self, "machine_id")

    @machine_id.setter
    def machine_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "machine_id", value)

    @property
    @pulumi.getter(name="networkId")
    def network_id(self) -> Optional[pulumi.Input[str]]:
        """
        Network to use to publish the export.
        """
        return pulumi.get(self, "network_id")

    @network_id.setter
    def network_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "network_id", value)

    @property
    @pulumi.getter(name="noRootSquash")
    def no_root_squash(self) -> Optional[pulumi.Input[bool]]:
        """
        Disable root squashing, which is a feature of NFS. Root squash is a special mapping of the remote superuser (root) identity when using identity authentication.
        """
        return pulumi.get(self, "no_root_squash")

    @no_root_squash.setter
    def no_root_squash(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "no_root_squash", value)

    @property
    @pulumi.getter
    def permissions(self) -> Optional[pulumi.Input['NfsExportPermissions']]:
        """
        Export permissions.
        """
        return pulumi.get(self, "permissions")

    @permissions.setter
    def permissions(self, value: Optional[pulumi.Input['NfsExportPermissions']]):
        pulumi.set(self, "permissions", value)


@pulumi.input_type
class ScheduleArgs:
    def __init__(__self__, *,
                 crontab_spec: Optional[pulumi.Input[str]] = None,
                 prefix: Optional[pulumi.Input[str]] = None,
                 retention_count: Optional[pulumi.Input[int]] = None):
        """
        A snapshot schedule.
        :param pulumi.Input[str] crontab_spec: A crontab-like specification that the schedule uses to take snapshots.
        :param pulumi.Input[str] prefix: A list of snapshot names created in this schedule.
        :param pulumi.Input[int] retention_count: The maximum number of snapshots to retain in this schedule.
        """
        if crontab_spec is not None:
            pulumi.set(__self__, "crontab_spec", crontab_spec)
        if prefix is not None:
            pulumi.set(__self__, "prefix", prefix)
        if retention_count is not None:
            pulumi.set(__self__, "retention_count", retention_count)

    @property
    @pulumi.getter(name="crontabSpec")
    def crontab_spec(self) -> Optional[pulumi.Input[str]]:
        """
        A crontab-like specification that the schedule uses to take snapshots.
        """
        return pulumi.get(self, "crontab_spec")

    @crontab_spec.setter
    def crontab_spec(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "crontab_spec", value)

    @property
    @pulumi.getter
    def prefix(self) -> Optional[pulumi.Input[str]]:
        """
        A list of snapshot names created in this schedule.
        """
        return pulumi.get(self, "prefix")

    @prefix.setter
    def prefix(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "prefix", value)

    @property
    @pulumi.getter(name="retentionCount")
    def retention_count(self) -> Optional[pulumi.Input[int]]:
        """
        The maximum number of snapshots to retain in this schedule.
        """
        return pulumi.get(self, "retention_count")

    @retention_count.setter
    def retention_count(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "retention_count", value)


@pulumi.input_type
class VolumeConfigArgs:
    def __init__(__self__, *,
                 gcp_service: Optional[pulumi.Input[str]] = None,
                 id: Optional[pulumi.Input[str]] = None,
                 lun_ranges: Optional[pulumi.Input[Sequence[pulumi.Input['LunRangeArgs']]]] = None,
                 machine_ids: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 nfs_exports: Optional[pulumi.Input[Sequence[pulumi.Input['NfsExportArgs']]]] = None,
                 protocol: Optional[pulumi.Input['VolumeConfigProtocol']] = None,
                 size_gb: Optional[pulumi.Input[int]] = None,
                 snapshots_enabled: Optional[pulumi.Input[bool]] = None,
                 type: Optional[pulumi.Input['VolumeConfigType']] = None,
                 user_note: Optional[pulumi.Input[str]] = None):
        """
        Configuration parameters for a new volume.
        :param pulumi.Input[str] gcp_service: The GCP service of the storage volume. Available gcp_service are in https://cloud.google.com/bare-metal/docs/bms-planning.
        :param pulumi.Input[str] id: A transient unique identifier to identify a volume within an ProvisioningConfig request.
        :param pulumi.Input[Sequence[pulumi.Input['LunRangeArgs']]] lun_ranges: LUN ranges to be configured. Set only when protocol is PROTOCOL_FC.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] machine_ids: Machine ids connected to this volume. Set only when protocol is PROTOCOL_FC.
        :param pulumi.Input[Sequence[pulumi.Input['NfsExportArgs']]] nfs_exports: NFS exports. Set only when protocol is PROTOCOL_NFS.
        :param pulumi.Input['VolumeConfigProtocol'] protocol: Volume protocol.
        :param pulumi.Input[int] size_gb: The requested size of this volume, in GB.
        :param pulumi.Input[bool] snapshots_enabled: Whether snapshots should be enabled.
        :param pulumi.Input['VolumeConfigType'] type: The type of this Volume.
        :param pulumi.Input[str] user_note: User note field, it can be used by customers to add additional information for the BMS Ops team (b/194021617).
        """
        if gcp_service is not None:
            pulumi.set(__self__, "gcp_service", gcp_service)
        if id is not None:
            pulumi.set(__self__, "id", id)
        if lun_ranges is not None:
            pulumi.set(__self__, "lun_ranges", lun_ranges)
        if machine_ids is not None:
            pulumi.set(__self__, "machine_ids", machine_ids)
        if nfs_exports is not None:
            pulumi.set(__self__, "nfs_exports", nfs_exports)
        if protocol is not None:
            pulumi.set(__self__, "protocol", protocol)
        if size_gb is not None:
            pulumi.set(__self__, "size_gb", size_gb)
        if snapshots_enabled is not None:
            pulumi.set(__self__, "snapshots_enabled", snapshots_enabled)
        if type is not None:
            pulumi.set(__self__, "type", type)
        if user_note is not None:
            pulumi.set(__self__, "user_note", user_note)

    @property
    @pulumi.getter(name="gcpService")
    def gcp_service(self) -> Optional[pulumi.Input[str]]:
        """
        The GCP service of the storage volume. Available gcp_service are in https://cloud.google.com/bare-metal/docs/bms-planning.
        """
        return pulumi.get(self, "gcp_service")

    @gcp_service.setter
    def gcp_service(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "gcp_service", value)

    @property
    @pulumi.getter
    def id(self) -> Optional[pulumi.Input[str]]:
        """
        A transient unique identifier to identify a volume within an ProvisioningConfig request.
        """
        return pulumi.get(self, "id")

    @id.setter
    def id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "id", value)

    @property
    @pulumi.getter(name="lunRanges")
    def lun_ranges(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['LunRangeArgs']]]]:
        """
        LUN ranges to be configured. Set only when protocol is PROTOCOL_FC.
        """
        return pulumi.get(self, "lun_ranges")

    @lun_ranges.setter
    def lun_ranges(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['LunRangeArgs']]]]):
        pulumi.set(self, "lun_ranges", value)

    @property
    @pulumi.getter(name="machineIds")
    def machine_ids(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        Machine ids connected to this volume. Set only when protocol is PROTOCOL_FC.
        """
        return pulumi.get(self, "machine_ids")

    @machine_ids.setter
    def machine_ids(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "machine_ids", value)

    @property
    @pulumi.getter(name="nfsExports")
    def nfs_exports(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['NfsExportArgs']]]]:
        """
        NFS exports. Set only when protocol is PROTOCOL_NFS.
        """
        return pulumi.get(self, "nfs_exports")

    @nfs_exports.setter
    def nfs_exports(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['NfsExportArgs']]]]):
        pulumi.set(self, "nfs_exports", value)

    @property
    @pulumi.getter
    def protocol(self) -> Optional[pulumi.Input['VolumeConfigProtocol']]:
        """
        Volume protocol.
        """
        return pulumi.get(self, "protocol")

    @protocol.setter
    def protocol(self, value: Optional[pulumi.Input['VolumeConfigProtocol']]):
        pulumi.set(self, "protocol", value)

    @property
    @pulumi.getter(name="sizeGb")
    def size_gb(self) -> Optional[pulumi.Input[int]]:
        """
        The requested size of this volume, in GB.
        """
        return pulumi.get(self, "size_gb")

    @size_gb.setter
    def size_gb(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "size_gb", value)

    @property
    @pulumi.getter(name="snapshotsEnabled")
    def snapshots_enabled(self) -> Optional[pulumi.Input[bool]]:
        """
        Whether snapshots should be enabled.
        """
        return pulumi.get(self, "snapshots_enabled")

    @snapshots_enabled.setter
    def snapshots_enabled(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "snapshots_enabled", value)

    @property
    @pulumi.getter
    def type(self) -> Optional[pulumi.Input['VolumeConfigType']]:
        """
        The type of this Volume.
        """
        return pulumi.get(self, "type")

    @type.setter
    def type(self, value: Optional[pulumi.Input['VolumeConfigType']]):
        pulumi.set(self, "type", value)

    @property
    @pulumi.getter(name="userNote")
    def user_note(self) -> Optional[pulumi.Input[str]]:
        """
        User note field, it can be used by customers to add additional information for the BMS Ops team (b/194021617).
        """
        return pulumi.get(self, "user_note")

    @user_note.setter
    def user_note(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "user_note", value)

