// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package alpha

import (
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Returns the specified Instance resource. Gets a list of available instances by making a list() request.
func LookupInstance(ctx *pulumi.Context, args *LookupInstanceArgs, opts ...pulumi.InvokeOption) (*LookupInstanceResult, error) {
	var rv LookupInstanceResult
	err := ctx.Invoke("google-native:compute/alpha:getInstance", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupInstanceArgs struct {
	Instance string `pulumi:"instance"`
	Project  string `pulumi:"project"`
	Zone     string `pulumi:"zone"`
}

type LookupInstanceResult struct {
	// Controls for advanced machine-related behavior features.
	AdvancedMachineFeatures AdvancedMachineFeaturesResponse `pulumi:"advancedMachineFeatures"`
	// Allows this instance to send and receive packets with non-matching destination or source IPs. This is required if you plan to use this instance to forward routes. For more information, see Enabling IP Forwarding.
	CanIpForward               bool                               `pulumi:"canIpForward"`
	ConfidentialInstanceConfig ConfidentialInstanceConfigResponse `pulumi:"confidentialInstanceConfig"`
	// [Output Only] The CPU platform used by this instance.
	CpuPlatform string `pulumi:"cpuPlatform"`
	// [Output Only] Creation timestamp in RFC3339 text format.
	CreationTimestamp string `pulumi:"creationTimestamp"`
	// Whether the resource should be protected against deletion.
	DeletionProtection bool `pulumi:"deletionProtection"`
	// An optional description of this resource. Provide this property when you create the resource.
	Description string `pulumi:"description"`
	// Array of disks associated with this instance. Persistent disks must be created before you can assign them.
	Disks []AttachedDiskResponse `pulumi:"disks"`
	// Enables display device for the instance.
	DisplayDevice DisplayDeviceResponse `pulumi:"displayDevice"`
	// Specifies whether the disks restored from source snapshots or source machine image should erase Windows specific VSS signature.
	EraseWindowsVssSignature bool `pulumi:"eraseWindowsVssSignature"`
	// Specifies a fingerprint for this resource, which is essentially a hash of the instance's contents and used for optimistic locking. The fingerprint is initially generated by Compute Engine and changes after every request to modify or update the instance. You must always provide an up-to-date fingerprint hash in order to update the instance.
	//
	// To see the latest fingerprint, make get() request to the instance.
	Fingerprint string `pulumi:"fingerprint"`
	// A list of the type and count of accelerator cards attached to the instance.
	GuestAccelerators []AcceleratorConfigResponse `pulumi:"guestAccelerators"`
	// Specifies the hostname of the instance. The specified hostname must be RFC1035 compliant. If hostname is not specified, the default hostname is [INSTANCE_NAME].c.[PROJECT_ID].internal when using the global DNS, and [INSTANCE_NAME].[ZONE].c.[PROJECT_ID].internal when using zonal DNS.
	Hostname string `pulumi:"hostname"`
	// Encrypts or decrypts data for an instance with a customer-supplied encryption key.
	//
	// If you are creating a new instance, this field encrypts the local SSD and in-memory contents of the instance using a key that you provide.
	//
	// If you are restarting an instance protected with a customer-supplied encryption key, you must provide the correct key in order to successfully restart the instance.
	//
	// If you do not provide an encryption key when creating the instance, then the local SSD and in-memory contents will be encrypted using an automatically generated key and you do not need to provide a key to start the instance later.
	//
	// Instance templates do not store customer-supplied encryption keys, so you cannot use your own keys to encrypt local SSDs and in-memory content in a managed instance group.
	InstanceEncryptionKey CustomerEncryptionKeyResponse `pulumi:"instanceEncryptionKey"`
	// [Output Only] Type of the resource. Always compute#instance for instances.
	Kind string `pulumi:"kind"`
	// A fingerprint for this request, which is essentially a hash of the label's contents and used for optimistic locking. The fingerprint is initially generated by Compute Engine and changes after every request to modify or update labels. You must always provide an up-to-date fingerprint hash in order to update or change labels.
	//
	// To see the latest fingerprint, make get() request to the instance.
	LabelFingerprint string `pulumi:"labelFingerprint"`
	// Labels to apply to this instance. These can be later modified by the setLabels method.
	Labels map[string]string `pulumi:"labels"`
	// [Output Only] Last start timestamp in RFC3339 text format.
	LastStartTimestamp string `pulumi:"lastStartTimestamp"`
	// [Output Only] Last stop timestamp in RFC3339 text format.
	LastStopTimestamp string `pulumi:"lastStopTimestamp"`
	// [Output Only] Last suspended timestamp in RFC3339 text format.
	LastSuspendedTimestamp string `pulumi:"lastSuspendedTimestamp"`
	// Full or partial URL of the machine type resource to use for this instance, in the format: zones/zone/machineTypes/machine-type. This is provided by the client when the instance is created. For example, the following is a valid partial url to a predefined machine type:
	// zones/us-central1-f/machineTypes/n1-standard-1
	//
	// To create a custom machine type, provide a URL to a machine type in the following format, where CPUS is 1 or an even number up to 32 (2, 4, 6, ... 24, etc), and MEMORY is the total memory for this instance. Memory must be a multiple of 256 MB and must be supplied in MB (e.g. 5 GB of memory is 5120 MB):
	// zones/zone/machineTypes/custom-CPUS-MEMORY
	//
	// For example: zones/us-central1-f/machineTypes/custom-4-5120
	//
	// For a full list of restrictions, read the Specifications for custom machine types.
	MachineType string `pulumi:"machineType"`
	// The metadata key/value pairs assigned to this instance. This includes custom metadata and predefined keys.
	Metadata MetadataResponse `pulumi:"metadata"`
	// Specifies a minimum CPU platform for the VM instance. Applicable values are the friendly names of CPU platforms, such as minCpuPlatform: "Intel Haswell" or minCpuPlatform: "Intel Sandy Bridge".
	MinCpuPlatform string `pulumi:"minCpuPlatform"`
	// The name of the resource, provided by the client when initially creating the resource. The resource name must be 1-63 characters long, and comply with RFC1035. Specifically, the name must be 1-63 characters long and match the regular expression `[a-z]([-a-z0-9]*[a-z0-9])?` which means the first character must be a lowercase letter, and all following characters must be a dash, lowercase letter, or digit, except the last character, which cannot be a dash.
	Name string `pulumi:"name"`
	// An array of network configurations for this instance. These specify how interfaces are configured to interact with other network services, such as connecting to the internet. Multiple interfaces are supported per instance.
	NetworkInterfaces        []NetworkInterfaceResponse       `pulumi:"networkInterfaces"`
	NetworkPerformanceConfig NetworkPerformanceConfigResponse `pulumi:"networkPerformanceConfig"`
	// PostKeyRevocationActionType of the instance.
	PostKeyRevocationActionType string `pulumi:"postKeyRevocationActionType"`
	// Total amount of preserved state for SUSPENDED instances. Read-only in the api.
	PreservedStateSizeGb string `pulumi:"preservedStateSizeGb"`
	// The private IPv6 google access type for the VM. If not specified, use  INHERIT_FROM_SUBNETWORK as default.
	PrivateIpv6GoogleAccess string `pulumi:"privateIpv6GoogleAccess"`
	// Specifies the reservations that this instance can consume from.
	ReservationAffinity ReservationAffinityResponse `pulumi:"reservationAffinity"`
	// Resource policies applied to this instance.
	ResourcePolicies []string `pulumi:"resourcePolicies"`
	// [Output Only] Specifies values set for instance attributes as compared to the values requested by user in the corresponding input only field.
	ResourceStatus ResourceStatusResponse `pulumi:"resourceStatus"`
	// [Output Only] Reserved for future use.
	SatisfiesPzs bool `pulumi:"satisfiesPzs"`
	// Sets the scheduling options for this instance.
	Scheduling SchedulingResponse `pulumi:"scheduling"`
	// Secure labels to apply to this instance. These can be later modified by the update method. Maximum number of secure labels allowed is 300.
	SecureLabels []string `pulumi:"secureLabels"`
	// Secure tags to apply to this instance. These can be later modified by the update method. Maximum number of secure tags allowed is 300.
	SecureTags []string `pulumi:"secureTags"`
	// [Output Only] Server-defined URL for this resource.
	SelfLink string `pulumi:"selfLink"`
	// [Output Only] Server-defined URL for this resource with the resource id.
	SelfLinkWithId string `pulumi:"selfLinkWithId"`
	// A list of service accounts, with their specified scopes, authorized for this instance. Only one service account per VM instance is supported.
	//
	// Service accounts generate access tokens that can be accessed through the metadata server and used to authenticate applications on the instance. See Service Accounts for more information.
	ServiceAccounts                 []ServiceAccountResponse                `pulumi:"serviceAccounts"`
	ShieldedInstanceConfig          ShieldedInstanceConfigResponse          `pulumi:"shieldedInstanceConfig"`
	ShieldedInstanceIntegrityPolicy ShieldedInstanceIntegrityPolicyResponse `pulumi:"shieldedInstanceIntegrityPolicy"`
	// Deprecating, please use shielded_instance_config.
	ShieldedVmConfig ShieldedVmConfigResponse `pulumi:"shieldedVmConfig"`
	// Deprecating, please use shielded_instance_integrity_policy.
	ShieldedVmIntegrityPolicy ShieldedVmIntegrityPolicyResponse `pulumi:"shieldedVmIntegrityPolicy"`
	// Source machine image
	SourceMachineImage string `pulumi:"sourceMachineImage"`
	// Source machine image encryption key when creating an instance from a machine image.
	SourceMachineImageEncryptionKey CustomerEncryptionKeyResponse `pulumi:"sourceMachineImageEncryptionKey"`
	// [Output Only] Whether a VM has been restricted for start because Compute Engine has detected suspicious activity.
	StartRestricted bool `pulumi:"startRestricted"`
	// [Output Only] The status of the instance. One of the following values: PROVISIONING, STAGING, RUNNING, STOPPING, SUSPENDING, SUSPENDED, REPAIRING, and TERMINATED. For more information about the status of the instance, see  Instance life cycle.
	Status string `pulumi:"status"`
	// [Output Only] An optional, human-readable explanation of the status.
	StatusMessage string `pulumi:"statusMessage"`
	// Tags to apply to this instance. Tags are used to identify valid sources or targets for network firewalls and are specified by the client during instance creation. The tags can be later modified by the setTags method. Each tag within the list must comply with RFC1035. Multiple tags can be specified via the 'tags.items' field.
	Tags TagsResponse `pulumi:"tags"`
	// [Output Only] Specifies upcoming maintenance for the instance.
	UpcomingMaintenance UpcomingMaintenanceResponse `pulumi:"upcomingMaintenance"`
	// [Output Only] URL of the zone where the instance resides. You must specify this field as part of the HTTP request URL. It is not settable as a field in the request body.
	Zone string `pulumi:"zone"`
}