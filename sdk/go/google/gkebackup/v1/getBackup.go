// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v1

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Retrieve the details of a single Backup.
func LookupBackup(ctx *pulumi.Context, args *LookupBackupArgs, opts ...pulumi.InvokeOption) (*LookupBackupResult, error) {
	var rv LookupBackupResult
	err := ctx.Invoke("google-native:gkebackup/v1:getBackup", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupBackupArgs struct {
	BackupId     string  `pulumi:"backupId"`
	BackupPlanId string  `pulumi:"backupPlanId"`
	Location     string  `pulumi:"location"`
	Project      *string `pulumi:"project"`
}

type LookupBackupResult struct {
	// If True, all namespaces were included in the Backup.
	AllNamespaces bool `pulumi:"allNamespaces"`
	// Information about the GKE cluster from which this Backup was created.
	ClusterMetadata ClusterMetadataResponse `pulumi:"clusterMetadata"`
	// Completion time of the Backup
	CompleteTime string `pulumi:"completeTime"`
	// The size of the config backup in bytes.
	ConfigBackupSizeBytes string `pulumi:"configBackupSizeBytes"`
	// Whether or not the Backup contains Kubernetes Secrets. Controlled by the parent BackupPlan's include_secrets value.
	ContainsSecrets bool `pulumi:"containsSecrets"`
	// Whether or not the Backup contains volume data. Controlled by the parent BackupPlan's include_volume_data value.
	ContainsVolumeData bool `pulumi:"containsVolumeData"`
	// The timestamp when this Backup resource was created.
	CreateTime string `pulumi:"createTime"`
	// Minimum age for this Backup (in days). If this field is set to a non-zero value, the Backup will be "locked" against deletion (either manual or automatic deletion) for the number of days provided (measured from the creation time of the Backup). MUST be an integer value between 0-90 (inclusive). Defaults to parent BackupPlan's backup_delete_lock_days setting and may only be increased (either at creation time or in a subsequent update).
	DeleteLockDays int `pulumi:"deleteLockDays"`
	// The time at which an existing delete lock will expire for this backup (calculated from create_time + delete_lock_days).
	DeleteLockExpireTime string `pulumi:"deleteLockExpireTime"`
	// User specified descriptive string for this Backup.
	Description string `pulumi:"description"`
	// The customer managed encryption key that was used to encrypt the Backup's artifacts. Inherited from the parent BackupPlan's encryption_key value.
	EncryptionKey EncryptionKeyResponse `pulumi:"encryptionKey"`
	// `etag` is used for optimistic concurrency control as a way to help prevent simultaneous updates of a backup from overwriting each other. It is strongly suggested that systems make use of the `etag` in the read-modify-write cycle to perform backup updates in order to avoid race conditions: An `etag` is returned in the response to `GetBackup`, and systems are expected to put that etag in the request to `UpdateBackup` or `DeleteBackup` to ensure that their change will be applied to the same version of the resource.
	Etag string `pulumi:"etag"`
	// A set of custom labels supplied by user.
	Labels map[string]string `pulumi:"labels"`
	// This flag indicates whether this Backup resource was created manually by a user or via a schedule in the BackupPlan. A value of True means that the Backup was created manually.
	Manual bool `pulumi:"manual"`
	// The fully qualified name of the Backup. projects/*/locations/*/backupPlans/*/backups/*
	Name string `pulumi:"name"`
	// The total number of Kubernetes Pods contained in the Backup.
	PodCount int `pulumi:"podCount"`
	// The total number of Kubernetes resources included in the Backup.
	ResourceCount int `pulumi:"resourceCount"`
	// The age (in days) after which this Backup will be automatically deleted. Must be an integer value >= 0: - If 0, no automatic deletion will occur for this Backup. - If not 0, this must be >= delete_lock_days. Once a Backup is created, this value may only be increased. Defaults to the parent BackupPlan's backup_retain_days value.
	RetainDays int `pulumi:"retainDays"`
	// The time at which this Backup will be automatically deleted (calculated from create_time + retain_days).
	RetainExpireTime string `pulumi:"retainExpireTime"`
	// If set, the list of ProtectedApplications whose resources were included in the Backup.
	SelectedApplications NamespacedNamesResponse `pulumi:"selectedApplications"`
	// If set, the list of namespaces that were included in the Backup.
	SelectedNamespaces NamespacesResponse `pulumi:"selectedNamespaces"`
	// The total size of the Backup in bytes = config backup size + sum(volume backup sizes)
	SizeBytes string `pulumi:"sizeBytes"`
	// Current state of the Backup
	State string `pulumi:"state"`
	// Human-readable description of why the backup is in the current `state`.
	StateReason string `pulumi:"stateReason"`
	// Server generated global unique identifier of [UUID4](https://en.wikipedia.org/wiki/Universally_unique_identifier)
	Uid string `pulumi:"uid"`
	// The timestamp when this Backup resource was last updated.
	UpdateTime string `pulumi:"updateTime"`
	// The total number of volume backups contained in the Backup.
	VolumeCount int `pulumi:"volumeCount"`
}

func LookupBackupOutput(ctx *pulumi.Context, args LookupBackupOutputArgs, opts ...pulumi.InvokeOption) LookupBackupResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupBackupResult, error) {
			args := v.(LookupBackupArgs)
			r, err := LookupBackup(ctx, &args, opts...)
			var s LookupBackupResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupBackupResultOutput)
}

type LookupBackupOutputArgs struct {
	BackupId     pulumi.StringInput    `pulumi:"backupId"`
	BackupPlanId pulumi.StringInput    `pulumi:"backupPlanId"`
	Location     pulumi.StringInput    `pulumi:"location"`
	Project      pulumi.StringPtrInput `pulumi:"project"`
}

func (LookupBackupOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupBackupArgs)(nil)).Elem()
}

type LookupBackupResultOutput struct{ *pulumi.OutputState }

func (LookupBackupResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupBackupResult)(nil)).Elem()
}

func (o LookupBackupResultOutput) ToLookupBackupResultOutput() LookupBackupResultOutput {
	return o
}

func (o LookupBackupResultOutput) ToLookupBackupResultOutputWithContext(ctx context.Context) LookupBackupResultOutput {
	return o
}

// If True, all namespaces were included in the Backup.
func (o LookupBackupResultOutput) AllNamespaces() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupBackupResult) bool { return v.AllNamespaces }).(pulumi.BoolOutput)
}

// Information about the GKE cluster from which this Backup was created.
func (o LookupBackupResultOutput) ClusterMetadata() ClusterMetadataResponseOutput {
	return o.ApplyT(func(v LookupBackupResult) ClusterMetadataResponse { return v.ClusterMetadata }).(ClusterMetadataResponseOutput)
}

// Completion time of the Backup
func (o LookupBackupResultOutput) CompleteTime() pulumi.StringOutput {
	return o.ApplyT(func(v LookupBackupResult) string { return v.CompleteTime }).(pulumi.StringOutput)
}

// The size of the config backup in bytes.
func (o LookupBackupResultOutput) ConfigBackupSizeBytes() pulumi.StringOutput {
	return o.ApplyT(func(v LookupBackupResult) string { return v.ConfigBackupSizeBytes }).(pulumi.StringOutput)
}

// Whether or not the Backup contains Kubernetes Secrets. Controlled by the parent BackupPlan's include_secrets value.
func (o LookupBackupResultOutput) ContainsSecrets() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupBackupResult) bool { return v.ContainsSecrets }).(pulumi.BoolOutput)
}

// Whether or not the Backup contains volume data. Controlled by the parent BackupPlan's include_volume_data value.
func (o LookupBackupResultOutput) ContainsVolumeData() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupBackupResult) bool { return v.ContainsVolumeData }).(pulumi.BoolOutput)
}

// The timestamp when this Backup resource was created.
func (o LookupBackupResultOutput) CreateTime() pulumi.StringOutput {
	return o.ApplyT(func(v LookupBackupResult) string { return v.CreateTime }).(pulumi.StringOutput)
}

// Minimum age for this Backup (in days). If this field is set to a non-zero value, the Backup will be "locked" against deletion (either manual or automatic deletion) for the number of days provided (measured from the creation time of the Backup). MUST be an integer value between 0-90 (inclusive). Defaults to parent BackupPlan's backup_delete_lock_days setting and may only be increased (either at creation time or in a subsequent update).
func (o LookupBackupResultOutput) DeleteLockDays() pulumi.IntOutput {
	return o.ApplyT(func(v LookupBackupResult) int { return v.DeleteLockDays }).(pulumi.IntOutput)
}

// The time at which an existing delete lock will expire for this backup (calculated from create_time + delete_lock_days).
func (o LookupBackupResultOutput) DeleteLockExpireTime() pulumi.StringOutput {
	return o.ApplyT(func(v LookupBackupResult) string { return v.DeleteLockExpireTime }).(pulumi.StringOutput)
}

// User specified descriptive string for this Backup.
func (o LookupBackupResultOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v LookupBackupResult) string { return v.Description }).(pulumi.StringOutput)
}

// The customer managed encryption key that was used to encrypt the Backup's artifacts. Inherited from the parent BackupPlan's encryption_key value.
func (o LookupBackupResultOutput) EncryptionKey() EncryptionKeyResponseOutput {
	return o.ApplyT(func(v LookupBackupResult) EncryptionKeyResponse { return v.EncryptionKey }).(EncryptionKeyResponseOutput)
}

// `etag` is used for optimistic concurrency control as a way to help prevent simultaneous updates of a backup from overwriting each other. It is strongly suggested that systems make use of the `etag` in the read-modify-write cycle to perform backup updates in order to avoid race conditions: An `etag` is returned in the response to `GetBackup`, and systems are expected to put that etag in the request to `UpdateBackup` or `DeleteBackup` to ensure that their change will be applied to the same version of the resource.
func (o LookupBackupResultOutput) Etag() pulumi.StringOutput {
	return o.ApplyT(func(v LookupBackupResult) string { return v.Etag }).(pulumi.StringOutput)
}

// A set of custom labels supplied by user.
func (o LookupBackupResultOutput) Labels() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupBackupResult) map[string]string { return v.Labels }).(pulumi.StringMapOutput)
}

// This flag indicates whether this Backup resource was created manually by a user or via a schedule in the BackupPlan. A value of True means that the Backup was created manually.
func (o LookupBackupResultOutput) Manual() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupBackupResult) bool { return v.Manual }).(pulumi.BoolOutput)
}

// The fully qualified name of the Backup. projects/*/locations/*/backupPlans/*/backups/*
func (o LookupBackupResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupBackupResult) string { return v.Name }).(pulumi.StringOutput)
}

// The total number of Kubernetes Pods contained in the Backup.
func (o LookupBackupResultOutput) PodCount() pulumi.IntOutput {
	return o.ApplyT(func(v LookupBackupResult) int { return v.PodCount }).(pulumi.IntOutput)
}

// The total number of Kubernetes resources included in the Backup.
func (o LookupBackupResultOutput) ResourceCount() pulumi.IntOutput {
	return o.ApplyT(func(v LookupBackupResult) int { return v.ResourceCount }).(pulumi.IntOutput)
}

// The age (in days) after which this Backup will be automatically deleted. Must be an integer value >= 0: - If 0, no automatic deletion will occur for this Backup. - If not 0, this must be >= delete_lock_days. Once a Backup is created, this value may only be increased. Defaults to the parent BackupPlan's backup_retain_days value.
func (o LookupBackupResultOutput) RetainDays() pulumi.IntOutput {
	return o.ApplyT(func(v LookupBackupResult) int { return v.RetainDays }).(pulumi.IntOutput)
}

// The time at which this Backup will be automatically deleted (calculated from create_time + retain_days).
func (o LookupBackupResultOutput) RetainExpireTime() pulumi.StringOutput {
	return o.ApplyT(func(v LookupBackupResult) string { return v.RetainExpireTime }).(pulumi.StringOutput)
}

// If set, the list of ProtectedApplications whose resources were included in the Backup.
func (o LookupBackupResultOutput) SelectedApplications() NamespacedNamesResponseOutput {
	return o.ApplyT(func(v LookupBackupResult) NamespacedNamesResponse { return v.SelectedApplications }).(NamespacedNamesResponseOutput)
}

// If set, the list of namespaces that were included in the Backup.
func (o LookupBackupResultOutput) SelectedNamespaces() NamespacesResponseOutput {
	return o.ApplyT(func(v LookupBackupResult) NamespacesResponse { return v.SelectedNamespaces }).(NamespacesResponseOutput)
}

// The total size of the Backup in bytes = config backup size + sum(volume backup sizes)
func (o LookupBackupResultOutput) SizeBytes() pulumi.StringOutput {
	return o.ApplyT(func(v LookupBackupResult) string { return v.SizeBytes }).(pulumi.StringOutput)
}

// Current state of the Backup
func (o LookupBackupResultOutput) State() pulumi.StringOutput {
	return o.ApplyT(func(v LookupBackupResult) string { return v.State }).(pulumi.StringOutput)
}

// Human-readable description of why the backup is in the current `state`.
func (o LookupBackupResultOutput) StateReason() pulumi.StringOutput {
	return o.ApplyT(func(v LookupBackupResult) string { return v.StateReason }).(pulumi.StringOutput)
}

// Server generated global unique identifier of [UUID4](https://en.wikipedia.org/wiki/Universally_unique_identifier)
func (o LookupBackupResultOutput) Uid() pulumi.StringOutput {
	return o.ApplyT(func(v LookupBackupResult) string { return v.Uid }).(pulumi.StringOutput)
}

// The timestamp when this Backup resource was last updated.
func (o LookupBackupResultOutput) UpdateTime() pulumi.StringOutput {
	return o.ApplyT(func(v LookupBackupResult) string { return v.UpdateTime }).(pulumi.StringOutput)
}

// The total number of volume backups contained in the Backup.
func (o LookupBackupResultOutput) VolumeCount() pulumi.IntOutput {
	return o.ApplyT(func(v LookupBackupResult) int { return v.VolumeCount }).(pulumi.IntOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupBackupResultOutput{})
}