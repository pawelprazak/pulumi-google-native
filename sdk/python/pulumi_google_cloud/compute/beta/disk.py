# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables
from ._inputs import *

__all__ = ['Disk']


class Disk(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 creation_timestamp: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 disk_encryption_key: Optional[pulumi.Input[pulumi.InputType['CustomerEncryptionKeyArgs']]] = None,
                 erase_windows_vss_signature: Optional[pulumi.Input[bool]] = None,
                 guest_os_features: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['GuestOsFeatureArgs']]]]] = None,
                 id: Optional[pulumi.Input[str]] = None,
                 interface: Optional[pulumi.Input[str]] = None,
                 kind: Optional[pulumi.Input[str]] = None,
                 label_fingerprint: Optional[pulumi.Input[str]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 last_attach_timestamp: Optional[pulumi.Input[str]] = None,
                 last_detach_timestamp: Optional[pulumi.Input[str]] = None,
                 license_codes: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 licenses: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 location_hint: Optional[pulumi.Input[str]] = None,
                 multi_writer: Optional[pulumi.Input[bool]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 options: Optional[pulumi.Input[str]] = None,
                 physical_block_size_bytes: Optional[pulumi.Input[str]] = None,
                 project: Optional[pulumi.Input[str]] = None,
                 provisioned_iops: Optional[pulumi.Input[str]] = None,
                 region: Optional[pulumi.Input[str]] = None,
                 replica_zones: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 request_id: Optional[pulumi.Input[str]] = None,
                 resource_policies: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 satisfies_pzs: Optional[pulumi.Input[bool]] = None,
                 self_link: Optional[pulumi.Input[str]] = None,
                 size_gb: Optional[pulumi.Input[str]] = None,
                 source_disk: Optional[pulumi.Input[str]] = None,
                 source_disk_id: Optional[pulumi.Input[str]] = None,
                 source_image: Optional[pulumi.Input[str]] = None,
                 source_image_encryption_key: Optional[pulumi.Input[pulumi.InputType['CustomerEncryptionKeyArgs']]] = None,
                 source_image_id: Optional[pulumi.Input[str]] = None,
                 source_snapshot: Optional[pulumi.Input[str]] = None,
                 source_snapshot_encryption_key: Optional[pulumi.Input[pulumi.InputType['CustomerEncryptionKeyArgs']]] = None,
                 source_snapshot_id: Optional[pulumi.Input[str]] = None,
                 source_storage_object: Optional[pulumi.Input[str]] = None,
                 status: Optional[pulumi.Input[str]] = None,
                 storage_type: Optional[pulumi.Input[str]] = None,
                 type: Optional[pulumi.Input[str]] = None,
                 users: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 zone: Optional[pulumi.Input[str]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Creates a persistent disk in the specified project using the data in the request. You can create a disk from a source (sourceImage, sourceSnapshot, or sourceDisk) or create an empty 500 GB data disk by omitting all properties. You can also create a disk that is larger than the default size by specifying the sizeGb property.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] creation_timestamp: [Output Only] Creation timestamp in RFC3339 text format.
        :param pulumi.Input[str] description: An optional description of this resource. Provide this property when you create the resource.
        :param pulumi.Input[pulumi.InputType['CustomerEncryptionKeyArgs']] disk_encryption_key: Encrypts the disk using a customer-supplied encryption key.
               
               After you encrypt a disk with a customer-supplied key, you must provide the same key if you use the disk later (e.g. to create a disk snapshot, to create a disk image, to create a machine image, or to attach the disk to a virtual machine).
               
               Customer-supplied encryption keys do not protect access to metadata of the disk.
               
               If you do not provide an encryption key when creating the disk, then the disk will be encrypted using an automatically generated key and you do not need to provide a key to use the disk later.
        :param pulumi.Input[bool] erase_windows_vss_signature: Specifies whether the disk restored from a source snapshot should erase Windows specific VSS signature.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['GuestOsFeatureArgs']]]] guest_os_features: A list of features to enable on the guest operating system. Applicable only for bootable images. Read  Enabling guest operating system features to see a list of available options.
        :param pulumi.Input[str] id: [Output Only] The unique identifier for the resource. This identifier is defined by the server.
        :param pulumi.Input[str] interface: Specifies the disk interface to use for attaching this disk, which is either SCSI or NVME. The default is SCSI.
        :param pulumi.Input[str] kind: [Output Only] Type of the resource. Always compute#disk for disks.
        :param pulumi.Input[str] label_fingerprint: A fingerprint for the labels being applied to this disk, which is essentially a hash of the labels set used for optimistic locking. The fingerprint is initially generated by Compute Engine and changes after every request to modify or update labels. You must always provide an up-to-date fingerprint hash in order to update or change labels, otherwise the request will fail with error 412 conditionNotMet.
               
               To see the latest fingerprint, make a get() request to retrieve a disk.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] labels: Labels to apply to this disk. These can be later modified by the setLabels method.
        :param pulumi.Input[str] last_attach_timestamp: [Output Only] Last attach timestamp in RFC3339 text format.
        :param pulumi.Input[str] last_detach_timestamp: [Output Only] Last detach timestamp in RFC3339 text format.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] license_codes: Integer license codes indicating which licenses are attached to this disk.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] licenses: A list of publicly visible licenses. Reserved for Google's use.
        :param pulumi.Input[str] location_hint: An opaque location hint used to place the disk close to other resources. This field is for use by internal tools that use the public API.
        :param pulumi.Input[bool] multi_writer: Indicates whether or not the disk can be read/write attached to more than one instance.
        :param pulumi.Input[str] name: Name of the resource. Provided by the client when the resource is created. The name must be 1-63 characters long, and comply with RFC1035. Specifically, the name must be 1-63 characters long and match the regular expression `[a-z]([-a-z0-9]*[a-z0-9])?` which means the first character must be a lowercase letter, and all following characters must be a dash, lowercase letter, or digit, except the last character, which cannot be a dash.
        :param pulumi.Input[str] options: Internal use only.
        :param pulumi.Input[str] physical_block_size_bytes: Physical block size of the persistent disk, in bytes. If not present in a request, a default value is used. The currently supported size is 4096, other sizes may be added in the future. If an unsupported value is requested, the error message will list the supported values for the caller's project.
        :param pulumi.Input[str] project: Project ID for this request.
        :param pulumi.Input[str] provisioned_iops: Indicates how many IOPS must be provisioned for the disk.
        :param pulumi.Input[str] region: [Output Only] URL of the region where the disk resides. Only applicable for regional resources. You must specify this field as part of the HTTP request URL. It is not settable as a field in the request body.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] replica_zones: URLs of the zones where the disk should be replicated to. Only applicable for regional resources.
        :param pulumi.Input[str] request_id: An optional request ID to identify requests. Specify a unique request ID so that if you must retry your request, the server will know to ignore the request if it has already been completed.
               
               For example, consider a situation where you make an initial request and the request times out. If you make the request again with the same request ID, the server can check if original operation with the same request ID was received, and if so, will ignore the second request. This prevents clients from accidentally creating duplicate commitments.
               
               The request ID must be a valid UUID with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
        :param pulumi.Input[Sequence[pulumi.Input[str]]] resource_policies: Resource policies applied to this disk for automatic snapshot creations.
        :param pulumi.Input[bool] satisfies_pzs: [Output Only] Reserved for future use.
        :param pulumi.Input[str] self_link: [Output Only] Server-defined fully-qualified URL for this resource.
        :param pulumi.Input[str] size_gb: Size, in GB, of the persistent disk. You can specify this field when creating a persistent disk using the sourceImage, sourceSnapshot, or sourceDisk parameter, or specify it alone to create an empty persistent disk.
               
               If you specify this field along with a source, the value of sizeGb must not be less than the size of the source. Acceptable values are 1 to 65536, inclusive.
        :param pulumi.Input[str] source_disk: The source disk used to create this disk. You can provide this as a partial or full URL to the resource. For example, the following are valid values:  
               - https://www.googleapis.com/compute/v1/projects/project/zones/zone/disks/disk  
               - https://www.googleapis.com/compute/v1/projects/project/regions/region/disks/disk  
               - projects/project/zones/zone/disks/disk  
               - projects/project/regions/region/disks/disk  
               - zones/zone/disks/disk  
               - regions/region/disks/disk
        :param pulumi.Input[str] source_disk_id: [Output Only] The unique ID of the disk used to create this disk. This value identifies the exact disk that was used to create this persistent disk. For example, if you created the persistent disk from a disk that was later deleted and recreated under the same name, the source disk ID would identify the exact version of the disk that was used.
        :param pulumi.Input[str] source_image: The source image used to create this disk. If the source image is deleted, this field will not be set.
               
               To create a disk with one of the public operating system images, specify the image by its family name. For example, specify family/debian-9 to use the latest Debian 9 image:
               projects/debian-cloud/global/images/family/debian-9
               
               
               Alternatively, use a specific version of a public operating system image:
               projects/debian-cloud/global/images/debian-9-stretch-vYYYYMMDD
               
               
               To create a disk with a custom image that you created, specify the image name in the following format:
               global/images/my-custom-image
               
               
               You can also specify a custom image by its image family, which returns the latest version of the image in that family. Replace the image name with family/family-name:
               global/images/family/my-image-family
        :param pulumi.Input[pulumi.InputType['CustomerEncryptionKeyArgs']] source_image_encryption_key: The customer-supplied encryption key of the source image. Required if the source image is protected by a customer-supplied encryption key.
        :param pulumi.Input[str] source_image_id: [Output Only] The ID value of the image used to create this disk. This value identifies the exact image that was used to create this persistent disk. For example, if you created the persistent disk from an image that was later deleted and recreated under the same name, the source image ID would identify the exact version of the image that was used.
        :param pulumi.Input[str] source_snapshot: The source snapshot used to create this disk. You can provide this as a partial or full URL to the resource. For example, the following are valid values:  
               - https://www.googleapis.com/compute/v1/projects/project/global/snapshots/snapshot 
               - projects/project/global/snapshots/snapshot 
               - global/snapshots/snapshot
        :param pulumi.Input[pulumi.InputType['CustomerEncryptionKeyArgs']] source_snapshot_encryption_key: The customer-supplied encryption key of the source snapshot. Required if the source snapshot is protected by a customer-supplied encryption key.
        :param pulumi.Input[str] source_snapshot_id: [Output Only] The unique ID of the snapshot used to create this disk. This value identifies the exact snapshot that was used to create this persistent disk. For example, if you created the persistent disk from a snapshot that was later deleted and recreated under the same name, the source snapshot ID would identify the exact version of the snapshot that was used.
        :param pulumi.Input[str] source_storage_object: The full Google Cloud Storage URI where the disk image is stored. This file must be a gzip-compressed tarball whose name ends in .tar.gz or virtual machine disk whose name ends in vmdk. Valid URIs may start with gs:// or https://storage.googleapis.com/. This flag is not optimized for creating multiple disks from a source storage object. To create many disks from a source storage object, use gcloud compute images import instead.
        :param pulumi.Input[str] status: [Output Only] The status of disk creation.  
               - CREATING: Disk is provisioning. 
               - RESTORING: Source data is being copied into the disk. 
               - FAILED: Disk creation failed. 
               - READY: Disk is ready for use. 
               - DELETING: Disk is deleting.
        :param pulumi.Input[str] storage_type: [Deprecated] Storage type of the persistent disk.
        :param pulumi.Input[str] type: URL of the disk type resource describing which disk type to use to create the disk. Provide this when creating the disk. For example: projects/project/zones/zone/diskTypes/pd-standard  or pd-ssd
        :param pulumi.Input[Sequence[pulumi.Input[str]]] users: [Output Only] Links to the users of the disk (attached instances) in form: projects/project/zones/zone/instances/instance
        :param pulumi.Input[str] zone: [Output Only] URL of the zone where the disk resides. You must specify this field as part of the HTTP request URL. It is not settable as a field in the request body.
        """
        if __name__ is not None:
            warnings.warn("explicit use of __name__ is deprecated", DeprecationWarning)
            resource_name = __name__
        if __opts__ is not None:
            warnings.warn("explicit use of __opts__ is deprecated, use 'opts' instead", DeprecationWarning)
            opts = __opts__
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = dict()

            __props__['creation_timestamp'] = creation_timestamp
            __props__['description'] = description
            __props__['disk_encryption_key'] = disk_encryption_key
            __props__['erase_windows_vss_signature'] = erase_windows_vss_signature
            __props__['guest_os_features'] = guest_os_features
            __props__['id'] = id
            __props__['interface'] = interface
            __props__['kind'] = kind
            __props__['label_fingerprint'] = label_fingerprint
            __props__['labels'] = labels
            __props__['last_attach_timestamp'] = last_attach_timestamp
            __props__['last_detach_timestamp'] = last_detach_timestamp
            __props__['license_codes'] = license_codes
            __props__['licenses'] = licenses
            __props__['location_hint'] = location_hint
            __props__['multi_writer'] = multi_writer
            __props__['name'] = name
            __props__['options'] = options
            __props__['physical_block_size_bytes'] = physical_block_size_bytes
            if project is None and not opts.urn:
                raise TypeError("Missing required property 'project'")
            __props__['project'] = project
            __props__['provisioned_iops'] = provisioned_iops
            __props__['region'] = region
            __props__['replica_zones'] = replica_zones
            __props__['request_id'] = request_id
            __props__['resource_policies'] = resource_policies
            __props__['satisfies_pzs'] = satisfies_pzs
            __props__['self_link'] = self_link
            __props__['size_gb'] = size_gb
            __props__['source_disk'] = source_disk
            __props__['source_disk_id'] = source_disk_id
            __props__['source_image'] = source_image
            __props__['source_image_encryption_key'] = source_image_encryption_key
            __props__['source_image_id'] = source_image_id
            __props__['source_snapshot'] = source_snapshot
            __props__['source_snapshot_encryption_key'] = source_snapshot_encryption_key
            __props__['source_snapshot_id'] = source_snapshot_id
            __props__['source_storage_object'] = source_storage_object
            __props__['status'] = status
            __props__['storage_type'] = storage_type
            __props__['type'] = type
            __props__['users'] = users
            if zone is None and not opts.urn:
                raise TypeError("Missing required property 'zone'")
            __props__['zone'] = zone
        super(Disk, __self__).__init__(
            'google-cloud:compute/beta:Disk',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'Disk':
        """
        Get an existing Disk resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return Disk(resource_name, opts=opts, __props__=__props__)

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop
