// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package alpha

import (
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Returns the specified InPlaceSnapshot resource in the specified zone.
func LookupZoneInPlaceSnapshot(ctx *pulumi.Context, args *LookupZoneInPlaceSnapshotArgs, opts ...pulumi.InvokeOption) (*LookupZoneInPlaceSnapshotResult, error) {
	var rv LookupZoneInPlaceSnapshotResult
	err := ctx.Invoke("google-native:compute/alpha:getZoneInPlaceSnapshot", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupZoneInPlaceSnapshotArgs struct {
	InPlaceSnapshot string `pulumi:"inPlaceSnapshot"`
	Project         string `pulumi:"project"`
	Zone            string `pulumi:"zone"`
}

type LookupZoneInPlaceSnapshotResult struct {
	// [Output Only] Creation timestamp in RFC3339 text format.
	CreationTimestamp string `pulumi:"creationTimestamp"`
	// An optional description of this resource. Provide this property when you create the resource.
	Description string `pulumi:"description"`
	// [Output Only] Size of the source disk, specified in GB.
	DiskSizeGb string `pulumi:"diskSizeGb"`
	// Specifies to create an application consistent in-place snapshot by informing the OS to prepare for the snapshot process. Currently only supported on Windows instances using the Volume Shadow Copy Service (VSS).
	GuestFlush bool `pulumi:"guestFlush"`
	// [Output Only] Type of the resource. Always compute#inPlaceSnapshot for InPlaceSnapshot resources.
	Kind string `pulumi:"kind"`
	// A fingerprint for the labels being applied to this InPlaceSnapshot, which is essentially a hash of the labels set used for optimistic locking. The fingerprint is initially generated by Compute Engine and changes after every request to modify or update labels. You must always provide an up-to-date fingerprint hash in order to update or change labels, otherwise the request will fail with error 412 conditionNotMet.
	//
	// To see the latest fingerprint, make a get() request to retrieve a InPlaceSnapshot.
	LabelFingerprint string `pulumi:"labelFingerprint"`
	// Labels to apply to this InPlaceSnapshot. These can be later modified by the setLabels method. Label values may be empty.
	Labels map[string]string `pulumi:"labels"`
	// Name of the resource; provided by the client when the resource is created. The name must be 1-63 characters long, and comply with RFC1035. Specifically, the name must be 1-63 characters long and match the regular expression `[a-z]([-a-z0-9]*[a-z0-9])?` which means the first character must be a lowercase letter, and all following characters must be a dash, lowercase letter, or digit, except the last character, which cannot be a dash.
	Name string `pulumi:"name"`
	// [Output Only] URL of the region where the in-place snapshot resides. You must specify this field as part of the HTTP request URL. It is not settable as a field in the request body.
	Region string `pulumi:"region"`
	// [Output Only] Server-defined URL for the resource.
	SelfLink string `pulumi:"selfLink"`
	// [Output Only] Server-defined URL for this resource's resource id.
	SelfLinkWithId string `pulumi:"selfLinkWithId"`
	// URL of the source disk used to create this in-place snapshot. Note that the source disk must be in the same zone/region as the in-place snapshot to be created. This can be a full or valid partial URL. For example, the following are valid values:
	// - https://www.googleapis.com/compute/v1/projects/project/zones/zone/disks/disk
	// - projects/project/zones/zone/disks/disk
	// - zones/zone/disks/disk
	SourceDisk string `pulumi:"sourceDisk"`
	// [Output Only] The ID value of the disk used to create this InPlaceSnapshot. This value may be used to determine whether the InPlaceSnapshot was taken from the current or a previous instance of a given disk name.
	SourceDiskId string `pulumi:"sourceDiskId"`
	// [Output Only] The status of the inPlaceSnapshot. This can be CREATING, DELETING, FAILED, or READY.
	Status string `pulumi:"status"`
	// [Output Only] URL of the zone where the in-place snapshot resides. You must specify this field as part of the HTTP request URL. It is not settable as a field in the request body.
	Zone string `pulumi:"zone"`
}