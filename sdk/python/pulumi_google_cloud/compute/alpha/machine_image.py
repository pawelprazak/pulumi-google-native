# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables
from ._inputs import *

__all__ = ['MachineImage']


class MachineImage(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 creation_timestamp: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 guest_flush: Optional[pulumi.Input[bool]] = None,
                 id: Optional[pulumi.Input[str]] = None,
                 kind: Optional[pulumi.Input[str]] = None,
                 machine_image_encryption_key: Optional[pulumi.Input[pulumi.InputType['CustomerEncryptionKeyArgs']]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 project: Optional[pulumi.Input[str]] = None,
                 request_id: Optional[pulumi.Input[str]] = None,
                 satisfies_pzs: Optional[pulumi.Input[bool]] = None,
                 self_link: Optional[pulumi.Input[str]] = None,
                 self_link_with_id: Optional[pulumi.Input[str]] = None,
                 source_disk_encryption_keys: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['SourceDiskEncryptionKeyArgs']]]]] = None,
                 source_instance: Optional[pulumi.Input[str]] = None,
                 source_instance_properties: Optional[pulumi.Input[pulumi.InputType['SourceInstancePropertiesArgs']]] = None,
                 status: Optional[pulumi.Input[str]] = None,
                 storage_locations: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 total_storage_bytes: Optional[pulumi.Input[str]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Creates a machine image in the specified project using the data that is included in the request. If you are creating a new machine image to update an existing instance, your new machine image should use the same network or, if applicable, the same subnetwork as the original instance.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] creation_timestamp: [Output Only] The creation timestamp for this machine image in RFC3339 text format.
        :param pulumi.Input[str] description: An optional description of this resource. Provide this property when you create the resource.
        :param pulumi.Input[bool] guest_flush: [Input Only] Whether to attempt an application consistent machine image by informing the OS to prepare for the snapshot process. Currently only supported on Windows instances using the Volume Shadow Copy Service (VSS).
        :param pulumi.Input[str] id: [Output Only] A unique identifier for this machine image. The server defines this identifier.
        :param pulumi.Input[str] kind: [Output Only] The resource type, which is always compute#machineImage for machine image.
        :param pulumi.Input[pulumi.InputType['CustomerEncryptionKeyArgs']] machine_image_encryption_key: Encrypts the machine image using a customer-supplied encryption key.
               
               After you encrypt a machine image using a customer-supplied key, you must provide the same key if you use the machine image later. For example, you must provide the encryption key when you create an instance from the encrypted machine image in a future request.
               
               Customer-supplied encryption keys do not protect access to metadata of the machine image.
               
               If you do not provide an encryption key when creating the machine image, then the machine image will be encrypted using an automatically generated key and you do not need to provide a key to use the machine image later.
        :param pulumi.Input[str] name: Name of the resource; provided by the client when the resource is created. The name must be 1-63 characters long, and comply with RFC1035. Specifically, the name must be 1-63 characters long and match the regular expression `[a-z]([-a-z0-9]*[a-z0-9])?` which means the first character must be a lowercase letter, and all following characters must be a dash, lowercase letter, or digit, except the last character, which cannot be a dash.
        :param pulumi.Input[str] project: Project ID for this request.
        :param pulumi.Input[str] request_id: An optional request ID to identify requests. Specify a unique request ID so that if you must retry your request, the server will know to ignore the request if it has already been completed.
               
               For example, consider a situation where you make an initial request and the request times out. If you make the request again with the same request ID, the server can check if original operation with the same request ID was received, and if so, will ignore the second request. This prevents clients from accidentally creating duplicate commitments.
               
               The request ID must be a valid UUID with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
        :param pulumi.Input[bool] satisfies_pzs: [Output Only] Reserved for future use.
        :param pulumi.Input[str] self_link: [Output Only] The URL for this machine image. The server defines this URL.
        :param pulumi.Input[str] self_link_with_id: [Output Only] Server-defined URL for this resource with the resource id.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['SourceDiskEncryptionKeyArgs']]]] source_disk_encryption_keys: [Input Only] The customer-supplied encryption key of the disks attached to the source instance. Required if the source disk is protected by a customer-supplied encryption key.
        :param pulumi.Input[str] source_instance: The source instance used to create the machine image. You can provide this as a partial or full URL to the resource. For example, the following are valid values:  
               - https://www.googleapis.com/compute/v1/projects/project/zones/zone/instances/instance 
               - projects/project/zones/zone/instances/instance
        :param pulumi.Input[pulumi.InputType['SourceInstancePropertiesArgs']] source_instance_properties: [Output Only] Properties of source instance.
        :param pulumi.Input[str] status: [Output Only] The status of the machine image. One of the following values: INVALID, CREATING, READY, DELETING, and UPLOADING.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] storage_locations: The regional or multi-regional Cloud Storage bucket location where the machine image is stored.
        :param pulumi.Input[str] total_storage_bytes: [Output Only] Total size of the storage used by the machine image.
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
            __props__['guest_flush'] = guest_flush
            __props__['id'] = id
            __props__['kind'] = kind
            __props__['machine_image_encryption_key'] = machine_image_encryption_key
            __props__['name'] = name
            if project is None and not opts.urn:
                raise TypeError("Missing required property 'project'")
            __props__['project'] = project
            __props__['request_id'] = request_id
            __props__['satisfies_pzs'] = satisfies_pzs
            __props__['self_link'] = self_link
            __props__['self_link_with_id'] = self_link_with_id
            __props__['source_disk_encryption_keys'] = source_disk_encryption_keys
            __props__['source_instance'] = source_instance
            __props__['source_instance_properties'] = source_instance_properties
            __props__['status'] = status
            __props__['storage_locations'] = storage_locations
            __props__['total_storage_bytes'] = total_storage_bytes
        super(MachineImage, __self__).__init__(
            'google-cloud:compute/alpha:MachineImage',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'MachineImage':
        """
        Get an existing MachineImage resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return MachineImage(resource_name, opts=opts, __props__=__props__)

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop
