// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Creates a new worker pool with a specified size and configuration. Returns a long running operation which contains a worker pool on completion. While the long running operation is in progress, any call to `GetWorkerPool` returns a worker pool in state `CREATING`.
type WorkerPool struct {
	pulumi.CustomResourceState

	// The autoscale policy to apply on a pool.
	Autoscale GoogleDevtoolsRemotebuildexecutionAdminV1alphaAutoscaleResponseOutput `pulumi:"autoscale"`
	// Channel specifies the release channel of the pool.
	Channel    pulumi.StringOutput `pulumi:"channel"`
	InstanceId pulumi.StringOutput `pulumi:"instanceId"`
	// WorkerPool resource name formatted as: `projects/[PROJECT_ID]/instances/[INSTANCE_ID]/workerpools/[POOL_ID]`. name should not be populated when creating a worker pool since it is provided in the `poolId` field.
	Name    pulumi.StringOutput `pulumi:"name"`
	Project pulumi.StringOutput `pulumi:"project"`
	// State of the worker pool.
	State pulumi.StringOutput `pulumi:"state"`
	// Specifies the properties, such as machine type and disk size, used for creating workers in a worker pool.
	WorkerConfig GoogleDevtoolsRemotebuildexecutionAdminV1alphaWorkerConfigResponseOutput `pulumi:"workerConfig"`
	// The desired number of workers in the worker pool. Must be a value between 0 and 15000.
	WorkerCount pulumi.StringOutput `pulumi:"workerCount"`
}

// NewWorkerPool registers a new resource with the given unique name, arguments, and options.
func NewWorkerPool(ctx *pulumi.Context,
	name string, args *WorkerPoolArgs, opts ...pulumi.ResourceOption) (*WorkerPool, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.InstanceId == nil {
		return nil, errors.New("invalid value for required argument 'InstanceId'")
	}
	var resource WorkerPool
	err := ctx.RegisterResource("google-native:remotebuildexecution/v1alpha:WorkerPool", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetWorkerPool gets an existing WorkerPool resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetWorkerPool(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *WorkerPoolState, opts ...pulumi.ResourceOption) (*WorkerPool, error) {
	var resource WorkerPool
	err := ctx.ReadResource("google-native:remotebuildexecution/v1alpha:WorkerPool", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering WorkerPool resources.
type workerPoolState struct {
}

type WorkerPoolState struct {
}

func (WorkerPoolState) ElementType() reflect.Type {
	return reflect.TypeOf((*workerPoolState)(nil)).Elem()
}

type workerPoolArgs struct {
	// The autoscale policy to apply on a pool.
	Autoscale *GoogleDevtoolsRemotebuildexecutionAdminV1alphaAutoscale `pulumi:"autoscale"`
	// Channel specifies the release channel of the pool.
	Channel    *string `pulumi:"channel"`
	InstanceId string  `pulumi:"instanceId"`
	// WorkerPool resource name formatted as: `projects/[PROJECT_ID]/instances/[INSTANCE_ID]/workerpools/[POOL_ID]`. name should not be populated when creating a worker pool since it is provided in the `poolId` field.
	Name *string `pulumi:"name"`
	// Resource name of the instance in which to create the new worker pool. Format: `projects/[PROJECT_ID]/instances/[INSTANCE_ID]`.
	Parent *string `pulumi:"parent"`
	// ID of the created worker pool. A valid pool ID must: be 6-50 characters long, contain only lowercase letters, digits, hyphens and underscores, start with a lowercase letter, and end with a lowercase letter or a digit.
	PoolId  *string `pulumi:"poolId"`
	Project *string `pulumi:"project"`
	// Specifies the properties, such as machine type and disk size, used for creating workers in a worker pool.
	WorkerConfig *GoogleDevtoolsRemotebuildexecutionAdminV1alphaWorkerConfig `pulumi:"workerConfig"`
	// The desired number of workers in the worker pool. Must be a value between 0 and 15000.
	WorkerCount *string `pulumi:"workerCount"`
}

// The set of arguments for constructing a WorkerPool resource.
type WorkerPoolArgs struct {
	// The autoscale policy to apply on a pool.
	Autoscale GoogleDevtoolsRemotebuildexecutionAdminV1alphaAutoscalePtrInput
	// Channel specifies the release channel of the pool.
	Channel    pulumi.StringPtrInput
	InstanceId pulumi.StringInput
	// WorkerPool resource name formatted as: `projects/[PROJECT_ID]/instances/[INSTANCE_ID]/workerpools/[POOL_ID]`. name should not be populated when creating a worker pool since it is provided in the `poolId` field.
	Name pulumi.StringPtrInput
	// Resource name of the instance in which to create the new worker pool. Format: `projects/[PROJECT_ID]/instances/[INSTANCE_ID]`.
	Parent pulumi.StringPtrInput
	// ID of the created worker pool. A valid pool ID must: be 6-50 characters long, contain only lowercase letters, digits, hyphens and underscores, start with a lowercase letter, and end with a lowercase letter or a digit.
	PoolId  pulumi.StringPtrInput
	Project pulumi.StringPtrInput
	// Specifies the properties, such as machine type and disk size, used for creating workers in a worker pool.
	WorkerConfig GoogleDevtoolsRemotebuildexecutionAdminV1alphaWorkerConfigPtrInput
	// The desired number of workers in the worker pool. Must be a value between 0 and 15000.
	WorkerCount pulumi.StringPtrInput
}

func (WorkerPoolArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*workerPoolArgs)(nil)).Elem()
}

type WorkerPoolInput interface {
	pulumi.Input

	ToWorkerPoolOutput() WorkerPoolOutput
	ToWorkerPoolOutputWithContext(ctx context.Context) WorkerPoolOutput
}

func (*WorkerPool) ElementType() reflect.Type {
	return reflect.TypeOf((**WorkerPool)(nil)).Elem()
}

func (i *WorkerPool) ToWorkerPoolOutput() WorkerPoolOutput {
	return i.ToWorkerPoolOutputWithContext(context.Background())
}

func (i *WorkerPool) ToWorkerPoolOutputWithContext(ctx context.Context) WorkerPoolOutput {
	return pulumi.ToOutputWithContext(ctx, i).(WorkerPoolOutput)
}

type WorkerPoolOutput struct{ *pulumi.OutputState }

func (WorkerPoolOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**WorkerPool)(nil)).Elem()
}

func (o WorkerPoolOutput) ToWorkerPoolOutput() WorkerPoolOutput {
	return o
}

func (o WorkerPoolOutput) ToWorkerPoolOutputWithContext(ctx context.Context) WorkerPoolOutput {
	return o
}

// The autoscale policy to apply on a pool.
func (o WorkerPoolOutput) Autoscale() GoogleDevtoolsRemotebuildexecutionAdminV1alphaAutoscaleResponseOutput {
	return o.ApplyT(func(v *WorkerPool) GoogleDevtoolsRemotebuildexecutionAdminV1alphaAutoscaleResponseOutput {
		return v.Autoscale
	}).(GoogleDevtoolsRemotebuildexecutionAdminV1alphaAutoscaleResponseOutput)
}

// Channel specifies the release channel of the pool.
func (o WorkerPoolOutput) Channel() pulumi.StringOutput {
	return o.ApplyT(func(v *WorkerPool) pulumi.StringOutput { return v.Channel }).(pulumi.StringOutput)
}

func (o WorkerPoolOutput) InstanceId() pulumi.StringOutput {
	return o.ApplyT(func(v *WorkerPool) pulumi.StringOutput { return v.InstanceId }).(pulumi.StringOutput)
}

// WorkerPool resource name formatted as: `projects/[PROJECT_ID]/instances/[INSTANCE_ID]/workerpools/[POOL_ID]`. name should not be populated when creating a worker pool since it is provided in the `poolId` field.
func (o WorkerPoolOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *WorkerPool) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

func (o WorkerPoolOutput) Project() pulumi.StringOutput {
	return o.ApplyT(func(v *WorkerPool) pulumi.StringOutput { return v.Project }).(pulumi.StringOutput)
}

// State of the worker pool.
func (o WorkerPoolOutput) State() pulumi.StringOutput {
	return o.ApplyT(func(v *WorkerPool) pulumi.StringOutput { return v.State }).(pulumi.StringOutput)
}

// Specifies the properties, such as machine type and disk size, used for creating workers in a worker pool.
func (o WorkerPoolOutput) WorkerConfig() GoogleDevtoolsRemotebuildexecutionAdminV1alphaWorkerConfigResponseOutput {
	return o.ApplyT(func(v *WorkerPool) GoogleDevtoolsRemotebuildexecutionAdminV1alphaWorkerConfigResponseOutput {
		return v.WorkerConfig
	}).(GoogleDevtoolsRemotebuildexecutionAdminV1alphaWorkerConfigResponseOutput)
}

// The desired number of workers in the worker pool. Must be a value between 0 and 15000.
func (o WorkerPoolOutput) WorkerCount() pulumi.StringOutput {
	return o.ApplyT(func(v *WorkerPool) pulumi.StringOutput { return v.WorkerCount }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*WorkerPoolInput)(nil)).Elem(), &WorkerPool{})
	pulumi.RegisterOutputType(WorkerPoolOutput{})
}
