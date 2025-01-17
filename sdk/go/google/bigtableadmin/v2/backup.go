// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v2

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Starts creating a new Cloud Bigtable Backup. The returned backup long-running operation can be used to track creation of the backup. The metadata field type is CreateBackupMetadata. The response field type is Backup, if successful. Cancelling the returned operation will stop the creation and delete the backup.
// Auto-naming is currently not supported for this resource.
type Backup struct {
	pulumi.CustomResourceState

	// Required. The id of the backup to be created. The `backup_id` along with the parent `parent` are combined as {parent}/backups/{backup_id} to create the full backup name, of the form: `projects/{project}/instances/{instance}/clusters/{cluster}/backups/{backup_id}`. This string must be between 1 and 50 characters in length and match the regex _a-zA-Z0-9*.
	BackupId  pulumi.StringOutput `pulumi:"backupId"`
	ClusterId pulumi.StringOutput `pulumi:"clusterId"`
	// The encryption information for the backup.
	EncryptionInfo EncryptionInfoResponseOutput `pulumi:"encryptionInfo"`
	// `end_time` is the time that the backup was finished. The row data in the backup will be no newer than this timestamp.
	EndTime pulumi.StringOutput `pulumi:"endTime"`
	// The expiration time of the backup, with microseconds granularity that must be at least 6 hours and at most 30 days from the time the request is received. Once the `expire_time` has passed, Cloud Bigtable will delete the backup and free the resources used by the backup.
	ExpireTime pulumi.StringOutput `pulumi:"expireTime"`
	InstanceId pulumi.StringOutput `pulumi:"instanceId"`
	// A globally unique identifier for the backup which cannot be changed. Values are of the form `projects/{project}/instances/{instance}/clusters/{cluster}/ backups/_a-zA-Z0-9*` The final segment of the name must be between 1 and 50 characters in length. The backup is stored in the cluster identified by the prefix of the backup name of the form `projects/{project}/instances/{instance}/clusters/{cluster}`.
	Name    pulumi.StringOutput `pulumi:"name"`
	Project pulumi.StringOutput `pulumi:"project"`
	// Size of the backup in bytes.
	SizeBytes pulumi.StringOutput `pulumi:"sizeBytes"`
	// Immutable. Name of the table from which this backup was created. This needs to be in the same instance as the backup. Values are of the form `projects/{project}/instances/{instance}/tables/{source_table}`.
	SourceTable pulumi.StringOutput `pulumi:"sourceTable"`
	// `start_time` is the time that the backup was started (i.e. approximately the time the CreateBackup request is received). The row data in this backup will be no older than this timestamp.
	StartTime pulumi.StringOutput `pulumi:"startTime"`
	// The current state of the backup.
	State pulumi.StringOutput `pulumi:"state"`
}

// NewBackup registers a new resource with the given unique name, arguments, and options.
func NewBackup(ctx *pulumi.Context,
	name string, args *BackupArgs, opts ...pulumi.ResourceOption) (*Backup, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.BackupId == nil {
		return nil, errors.New("invalid value for required argument 'BackupId'")
	}
	if args.ClusterId == nil {
		return nil, errors.New("invalid value for required argument 'ClusterId'")
	}
	if args.ExpireTime == nil {
		return nil, errors.New("invalid value for required argument 'ExpireTime'")
	}
	if args.InstanceId == nil {
		return nil, errors.New("invalid value for required argument 'InstanceId'")
	}
	if args.SourceTable == nil {
		return nil, errors.New("invalid value for required argument 'SourceTable'")
	}
	var resource Backup
	err := ctx.RegisterResource("google-native:bigtableadmin/v2:Backup", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetBackup gets an existing Backup resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetBackup(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *BackupState, opts ...pulumi.ResourceOption) (*Backup, error) {
	var resource Backup
	err := ctx.ReadResource("google-native:bigtableadmin/v2:Backup", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Backup resources.
type backupState struct {
}

type BackupState struct {
}

func (BackupState) ElementType() reflect.Type {
	return reflect.TypeOf((*backupState)(nil)).Elem()
}

type backupArgs struct {
	// Required. The id of the backup to be created. The `backup_id` along with the parent `parent` are combined as {parent}/backups/{backup_id} to create the full backup name, of the form: `projects/{project}/instances/{instance}/clusters/{cluster}/backups/{backup_id}`. This string must be between 1 and 50 characters in length and match the regex _a-zA-Z0-9*.
	BackupId  string `pulumi:"backupId"`
	ClusterId string `pulumi:"clusterId"`
	// The expiration time of the backup, with microseconds granularity that must be at least 6 hours and at most 30 days from the time the request is received. Once the `expire_time` has passed, Cloud Bigtable will delete the backup and free the resources used by the backup.
	ExpireTime string `pulumi:"expireTime"`
	InstanceId string `pulumi:"instanceId"`
	// A globally unique identifier for the backup which cannot be changed. Values are of the form `projects/{project}/instances/{instance}/clusters/{cluster}/ backups/_a-zA-Z0-9*` The final segment of the name must be between 1 and 50 characters in length. The backup is stored in the cluster identified by the prefix of the backup name of the form `projects/{project}/instances/{instance}/clusters/{cluster}`.
	Name    *string `pulumi:"name"`
	Project *string `pulumi:"project"`
	// Immutable. Name of the table from which this backup was created. This needs to be in the same instance as the backup. Values are of the form `projects/{project}/instances/{instance}/tables/{source_table}`.
	SourceTable string `pulumi:"sourceTable"`
}

// The set of arguments for constructing a Backup resource.
type BackupArgs struct {
	// Required. The id of the backup to be created. The `backup_id` along with the parent `parent` are combined as {parent}/backups/{backup_id} to create the full backup name, of the form: `projects/{project}/instances/{instance}/clusters/{cluster}/backups/{backup_id}`. This string must be between 1 and 50 characters in length and match the regex _a-zA-Z0-9*.
	BackupId  pulumi.StringInput
	ClusterId pulumi.StringInput
	// The expiration time of the backup, with microseconds granularity that must be at least 6 hours and at most 30 days from the time the request is received. Once the `expire_time` has passed, Cloud Bigtable will delete the backup and free the resources used by the backup.
	ExpireTime pulumi.StringInput
	InstanceId pulumi.StringInput
	// A globally unique identifier for the backup which cannot be changed. Values are of the form `projects/{project}/instances/{instance}/clusters/{cluster}/ backups/_a-zA-Z0-9*` The final segment of the name must be between 1 and 50 characters in length. The backup is stored in the cluster identified by the prefix of the backup name of the form `projects/{project}/instances/{instance}/clusters/{cluster}`.
	Name    pulumi.StringPtrInput
	Project pulumi.StringPtrInput
	// Immutable. Name of the table from which this backup was created. This needs to be in the same instance as the backup. Values are of the form `projects/{project}/instances/{instance}/tables/{source_table}`.
	SourceTable pulumi.StringInput
}

func (BackupArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*backupArgs)(nil)).Elem()
}

type BackupInput interface {
	pulumi.Input

	ToBackupOutput() BackupOutput
	ToBackupOutputWithContext(ctx context.Context) BackupOutput
}

func (*Backup) ElementType() reflect.Type {
	return reflect.TypeOf((**Backup)(nil)).Elem()
}

func (i *Backup) ToBackupOutput() BackupOutput {
	return i.ToBackupOutputWithContext(context.Background())
}

func (i *Backup) ToBackupOutputWithContext(ctx context.Context) BackupOutput {
	return pulumi.ToOutputWithContext(ctx, i).(BackupOutput)
}

type BackupOutput struct{ *pulumi.OutputState }

func (BackupOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**Backup)(nil)).Elem()
}

func (o BackupOutput) ToBackupOutput() BackupOutput {
	return o
}

func (o BackupOutput) ToBackupOutputWithContext(ctx context.Context) BackupOutput {
	return o
}

// Required. The id of the backup to be created. The `backup_id` along with the parent `parent` are combined as {parent}/backups/{backup_id} to create the full backup name, of the form: `projects/{project}/instances/{instance}/clusters/{cluster}/backups/{backup_id}`. This string must be between 1 and 50 characters in length and match the regex _a-zA-Z0-9*.
func (o BackupOutput) BackupId() pulumi.StringOutput {
	return o.ApplyT(func(v *Backup) pulumi.StringOutput { return v.BackupId }).(pulumi.StringOutput)
}

func (o BackupOutput) ClusterId() pulumi.StringOutput {
	return o.ApplyT(func(v *Backup) pulumi.StringOutput { return v.ClusterId }).(pulumi.StringOutput)
}

// The encryption information for the backup.
func (o BackupOutput) EncryptionInfo() EncryptionInfoResponseOutput {
	return o.ApplyT(func(v *Backup) EncryptionInfoResponseOutput { return v.EncryptionInfo }).(EncryptionInfoResponseOutput)
}

// `end_time` is the time that the backup was finished. The row data in the backup will be no newer than this timestamp.
func (o BackupOutput) EndTime() pulumi.StringOutput {
	return o.ApplyT(func(v *Backup) pulumi.StringOutput { return v.EndTime }).(pulumi.StringOutput)
}

// The expiration time of the backup, with microseconds granularity that must be at least 6 hours and at most 30 days from the time the request is received. Once the `expire_time` has passed, Cloud Bigtable will delete the backup and free the resources used by the backup.
func (o BackupOutput) ExpireTime() pulumi.StringOutput {
	return o.ApplyT(func(v *Backup) pulumi.StringOutput { return v.ExpireTime }).(pulumi.StringOutput)
}

func (o BackupOutput) InstanceId() pulumi.StringOutput {
	return o.ApplyT(func(v *Backup) pulumi.StringOutput { return v.InstanceId }).(pulumi.StringOutput)
}

// A globally unique identifier for the backup which cannot be changed. Values are of the form `projects/{project}/instances/{instance}/clusters/{cluster}/ backups/_a-zA-Z0-9*` The final segment of the name must be between 1 and 50 characters in length. The backup is stored in the cluster identified by the prefix of the backup name of the form `projects/{project}/instances/{instance}/clusters/{cluster}`.
func (o BackupOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *Backup) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

func (o BackupOutput) Project() pulumi.StringOutput {
	return o.ApplyT(func(v *Backup) pulumi.StringOutput { return v.Project }).(pulumi.StringOutput)
}

// Size of the backup in bytes.
func (o BackupOutput) SizeBytes() pulumi.StringOutput {
	return o.ApplyT(func(v *Backup) pulumi.StringOutput { return v.SizeBytes }).(pulumi.StringOutput)
}

// Immutable. Name of the table from which this backup was created. This needs to be in the same instance as the backup. Values are of the form `projects/{project}/instances/{instance}/tables/{source_table}`.
func (o BackupOutput) SourceTable() pulumi.StringOutput {
	return o.ApplyT(func(v *Backup) pulumi.StringOutput { return v.SourceTable }).(pulumi.StringOutput)
}

// `start_time` is the time that the backup was started (i.e. approximately the time the CreateBackup request is received). The row data in this backup will be no older than this timestamp.
func (o BackupOutput) StartTime() pulumi.StringOutput {
	return o.ApplyT(func(v *Backup) pulumi.StringOutput { return v.StartTime }).(pulumi.StringOutput)
}

// The current state of the backup.
func (o BackupOutput) State() pulumi.StringOutput {
	return o.ApplyT(func(v *Backup) pulumi.StringOutput { return v.State }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*BackupInput)(nil)).Elem(), &Backup{})
	pulumi.RegisterOutputType(BackupOutput{})
}
