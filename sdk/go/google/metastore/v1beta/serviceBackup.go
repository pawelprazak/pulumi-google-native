// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1beta

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Creates a new backup in a given project and location.
type ServiceBackup struct {
	pulumi.CustomResourceState

	// The time when the backup was started.
	CreateTime pulumi.StringOutput `pulumi:"createTime"`
	// The description of the backup.
	Description pulumi.StringOutput `pulumi:"description"`
	// The time when the backup finished creating.
	EndTime pulumi.StringOutput `pulumi:"endTime"`
	// Immutable. The relative resource name of the backup, in the following form:projects/{project_number}/locations/{location_id}/services/{service_id}/backups/{backup_id}
	Name pulumi.StringOutput `pulumi:"name"`
	// The revision of the service at the time of backup.
	ServiceRevision ServiceResponseOutput `pulumi:"serviceRevision"`
	// The current state of the backup.
	State pulumi.StringOutput `pulumi:"state"`
}

// NewServiceBackup registers a new resource with the given unique name, arguments, and options.
func NewServiceBackup(ctx *pulumi.Context,
	name string, args *ServiceBackupArgs, opts ...pulumi.ResourceOption) (*ServiceBackup, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.BackupsId == nil {
		return nil, errors.New("invalid value for required argument 'BackupsId'")
	}
	if args.LocationsId == nil {
		return nil, errors.New("invalid value for required argument 'LocationsId'")
	}
	if args.ProjectsId == nil {
		return nil, errors.New("invalid value for required argument 'ProjectsId'")
	}
	if args.ServicesId == nil {
		return nil, errors.New("invalid value for required argument 'ServicesId'")
	}
	var resource ServiceBackup
	err := ctx.RegisterResource("google-native:metastore/v1beta:ServiceBackup", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetServiceBackup gets an existing ServiceBackup resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetServiceBackup(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ServiceBackupState, opts ...pulumi.ResourceOption) (*ServiceBackup, error) {
	var resource ServiceBackup
	err := ctx.ReadResource("google-native:metastore/v1beta:ServiceBackup", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ServiceBackup resources.
type serviceBackupState struct {
	// The time when the backup was started.
	CreateTime *string `pulumi:"createTime"`
	// The description of the backup.
	Description *string `pulumi:"description"`
	// The time when the backup finished creating.
	EndTime *string `pulumi:"endTime"`
	// Immutable. The relative resource name of the backup, in the following form:projects/{project_number}/locations/{location_id}/services/{service_id}/backups/{backup_id}
	Name *string `pulumi:"name"`
	// The revision of the service at the time of backup.
	ServiceRevision *ServiceResponse `pulumi:"serviceRevision"`
	// The current state of the backup.
	State *string `pulumi:"state"`
}

type ServiceBackupState struct {
	// The time when the backup was started.
	CreateTime pulumi.StringPtrInput
	// The description of the backup.
	Description pulumi.StringPtrInput
	// The time when the backup finished creating.
	EndTime pulumi.StringPtrInput
	// Immutable. The relative resource name of the backup, in the following form:projects/{project_number}/locations/{location_id}/services/{service_id}/backups/{backup_id}
	Name pulumi.StringPtrInput
	// The revision of the service at the time of backup.
	ServiceRevision ServiceResponsePtrInput
	// The current state of the backup.
	State pulumi.StringPtrInput
}

func (ServiceBackupState) ElementType() reflect.Type {
	return reflect.TypeOf((*serviceBackupState)(nil)).Elem()
}

type serviceBackupArgs struct {
	BackupsId string `pulumi:"backupsId"`
	// The description of the backup.
	Description *string `pulumi:"description"`
	LocationsId string  `pulumi:"locationsId"`
	// Immutable. The relative resource name of the backup, in the following form:projects/{project_number}/locations/{location_id}/services/{service_id}/backups/{backup_id}
	Name       *string `pulumi:"name"`
	ProjectsId string  `pulumi:"projectsId"`
	ServicesId string  `pulumi:"servicesId"`
}

// The set of arguments for constructing a ServiceBackup resource.
type ServiceBackupArgs struct {
	BackupsId pulumi.StringInput
	// The description of the backup.
	Description pulumi.StringPtrInput
	LocationsId pulumi.StringInput
	// Immutable. The relative resource name of the backup, in the following form:projects/{project_number}/locations/{location_id}/services/{service_id}/backups/{backup_id}
	Name       pulumi.StringPtrInput
	ProjectsId pulumi.StringInput
	ServicesId pulumi.StringInput
}

func (ServiceBackupArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*serviceBackupArgs)(nil)).Elem()
}

type ServiceBackupInput interface {
	pulumi.Input

	ToServiceBackupOutput() ServiceBackupOutput
	ToServiceBackupOutputWithContext(ctx context.Context) ServiceBackupOutput
}

func (*ServiceBackup) ElementType() reflect.Type {
	return reflect.TypeOf((*ServiceBackup)(nil))
}

func (i *ServiceBackup) ToServiceBackupOutput() ServiceBackupOutput {
	return i.ToServiceBackupOutputWithContext(context.Background())
}

func (i *ServiceBackup) ToServiceBackupOutputWithContext(ctx context.Context) ServiceBackupOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ServiceBackupOutput)
}

type ServiceBackupOutput struct {
	*pulumi.OutputState
}

func (ServiceBackupOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ServiceBackup)(nil))
}

func (o ServiceBackupOutput) ToServiceBackupOutput() ServiceBackupOutput {
	return o
}

func (o ServiceBackupOutput) ToServiceBackupOutputWithContext(ctx context.Context) ServiceBackupOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(ServiceBackupOutput{})
}