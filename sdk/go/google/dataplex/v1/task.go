// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v1

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Creates a task resource within a lake.
// Auto-naming is currently not supported for this resource.
type Task struct {
	pulumi.CustomResourceState

	// The time when the task was created.
	CreateTime pulumi.StringOutput `pulumi:"createTime"`
	// Optional. Description of the task.
	Description pulumi.StringOutput `pulumi:"description"`
	// Optional. User friendly display name.
	DisplayName pulumi.StringOutput `pulumi:"displayName"`
	// Spec related to how a task is executed.
	ExecutionSpec GoogleCloudDataplexV1TaskExecutionSpecResponseOutput `pulumi:"executionSpec"`
	// Status of the latest task executions.
	ExecutionStatus GoogleCloudDataplexV1TaskExecutionStatusResponseOutput `pulumi:"executionStatus"`
	// Optional. User-defined labels for the task.
	Labels   pulumi.StringMapOutput `pulumi:"labels"`
	LakeId   pulumi.StringOutput    `pulumi:"lakeId"`
	Location pulumi.StringOutput    `pulumi:"location"`
	// The relative resource name of the task, of the form: projects/{project_number}/locations/{location_id}/lakes/{lake_id}/ tasks/{task_id}.
	Name    pulumi.StringOutput `pulumi:"name"`
	Project pulumi.StringOutput `pulumi:"project"`
	// Config related to running custom Spark tasks.
	Spark GoogleCloudDataplexV1TaskSparkTaskConfigResponseOutput `pulumi:"spark"`
	// Current state of the task.
	State pulumi.StringOutput `pulumi:"state"`
	// Required. Task identifier.
	TaskId pulumi.StringOutput `pulumi:"taskId"`
	// Spec related to how often and when a task should be triggered.
	TriggerSpec GoogleCloudDataplexV1TaskTriggerSpecResponseOutput `pulumi:"triggerSpec"`
	// System generated globally unique ID for the task. This ID will be different if the task is deleted and re-created with the same name.
	Uid pulumi.StringOutput `pulumi:"uid"`
	// The time when the task was last updated.
	UpdateTime pulumi.StringOutput `pulumi:"updateTime"`
	// Optional. Only validate the request, but do not perform mutations. The default is false.
	ValidateOnly pulumi.StringPtrOutput `pulumi:"validateOnly"`
}

// NewTask registers a new resource with the given unique name, arguments, and options.
func NewTask(ctx *pulumi.Context,
	name string, args *TaskArgs, opts ...pulumi.ResourceOption) (*Task, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ExecutionSpec == nil {
		return nil, errors.New("invalid value for required argument 'ExecutionSpec'")
	}
	if args.LakeId == nil {
		return nil, errors.New("invalid value for required argument 'LakeId'")
	}
	if args.TaskId == nil {
		return nil, errors.New("invalid value for required argument 'TaskId'")
	}
	if args.TriggerSpec == nil {
		return nil, errors.New("invalid value for required argument 'TriggerSpec'")
	}
	var resource Task
	err := ctx.RegisterResource("google-native:dataplex/v1:Task", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetTask gets an existing Task resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetTask(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *TaskState, opts ...pulumi.ResourceOption) (*Task, error) {
	var resource Task
	err := ctx.ReadResource("google-native:dataplex/v1:Task", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Task resources.
type taskState struct {
}

type TaskState struct {
}

func (TaskState) ElementType() reflect.Type {
	return reflect.TypeOf((*taskState)(nil)).Elem()
}

type taskArgs struct {
	// Optional. Description of the task.
	Description *string `pulumi:"description"`
	// Optional. User friendly display name.
	DisplayName *string `pulumi:"displayName"`
	// Spec related to how a task is executed.
	ExecutionSpec GoogleCloudDataplexV1TaskExecutionSpec `pulumi:"executionSpec"`
	// Optional. User-defined labels for the task.
	Labels   map[string]string `pulumi:"labels"`
	LakeId   string            `pulumi:"lakeId"`
	Location *string           `pulumi:"location"`
	Project  *string           `pulumi:"project"`
	// Config related to running custom Spark tasks.
	Spark *GoogleCloudDataplexV1TaskSparkTaskConfig `pulumi:"spark"`
	// Required. Task identifier.
	TaskId string `pulumi:"taskId"`
	// Spec related to how often and when a task should be triggered.
	TriggerSpec GoogleCloudDataplexV1TaskTriggerSpec `pulumi:"triggerSpec"`
	// Optional. Only validate the request, but do not perform mutations. The default is false.
	ValidateOnly *string `pulumi:"validateOnly"`
}

// The set of arguments for constructing a Task resource.
type TaskArgs struct {
	// Optional. Description of the task.
	Description pulumi.StringPtrInput
	// Optional. User friendly display name.
	DisplayName pulumi.StringPtrInput
	// Spec related to how a task is executed.
	ExecutionSpec GoogleCloudDataplexV1TaskExecutionSpecInput
	// Optional. User-defined labels for the task.
	Labels   pulumi.StringMapInput
	LakeId   pulumi.StringInput
	Location pulumi.StringPtrInput
	Project  pulumi.StringPtrInput
	// Config related to running custom Spark tasks.
	Spark GoogleCloudDataplexV1TaskSparkTaskConfigPtrInput
	// Required. Task identifier.
	TaskId pulumi.StringInput
	// Spec related to how often and when a task should be triggered.
	TriggerSpec GoogleCloudDataplexV1TaskTriggerSpecInput
	// Optional. Only validate the request, but do not perform mutations. The default is false.
	ValidateOnly pulumi.StringPtrInput
}

func (TaskArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*taskArgs)(nil)).Elem()
}

type TaskInput interface {
	pulumi.Input

	ToTaskOutput() TaskOutput
	ToTaskOutputWithContext(ctx context.Context) TaskOutput
}

func (*Task) ElementType() reflect.Type {
	return reflect.TypeOf((**Task)(nil)).Elem()
}

func (i *Task) ToTaskOutput() TaskOutput {
	return i.ToTaskOutputWithContext(context.Background())
}

func (i *Task) ToTaskOutputWithContext(ctx context.Context) TaskOutput {
	return pulumi.ToOutputWithContext(ctx, i).(TaskOutput)
}

type TaskOutput struct{ *pulumi.OutputState }

func (TaskOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**Task)(nil)).Elem()
}

func (o TaskOutput) ToTaskOutput() TaskOutput {
	return o
}

func (o TaskOutput) ToTaskOutputWithContext(ctx context.Context) TaskOutput {
	return o
}

// The time when the task was created.
func (o TaskOutput) CreateTime() pulumi.StringOutput {
	return o.ApplyT(func(v *Task) pulumi.StringOutput { return v.CreateTime }).(pulumi.StringOutput)
}

// Optional. Description of the task.
func (o TaskOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v *Task) pulumi.StringOutput { return v.Description }).(pulumi.StringOutput)
}

// Optional. User friendly display name.
func (o TaskOutput) DisplayName() pulumi.StringOutput {
	return o.ApplyT(func(v *Task) pulumi.StringOutput { return v.DisplayName }).(pulumi.StringOutput)
}

// Spec related to how a task is executed.
func (o TaskOutput) ExecutionSpec() GoogleCloudDataplexV1TaskExecutionSpecResponseOutput {
	return o.ApplyT(func(v *Task) GoogleCloudDataplexV1TaskExecutionSpecResponseOutput { return v.ExecutionSpec }).(GoogleCloudDataplexV1TaskExecutionSpecResponseOutput)
}

// Status of the latest task executions.
func (o TaskOutput) ExecutionStatus() GoogleCloudDataplexV1TaskExecutionStatusResponseOutput {
	return o.ApplyT(func(v *Task) GoogleCloudDataplexV1TaskExecutionStatusResponseOutput { return v.ExecutionStatus }).(GoogleCloudDataplexV1TaskExecutionStatusResponseOutput)
}

// Optional. User-defined labels for the task.
func (o TaskOutput) Labels() pulumi.StringMapOutput {
	return o.ApplyT(func(v *Task) pulumi.StringMapOutput { return v.Labels }).(pulumi.StringMapOutput)
}

func (o TaskOutput) LakeId() pulumi.StringOutput {
	return o.ApplyT(func(v *Task) pulumi.StringOutput { return v.LakeId }).(pulumi.StringOutput)
}

func (o TaskOutput) Location() pulumi.StringOutput {
	return o.ApplyT(func(v *Task) pulumi.StringOutput { return v.Location }).(pulumi.StringOutput)
}

// The relative resource name of the task, of the form: projects/{project_number}/locations/{location_id}/lakes/{lake_id}/ tasks/{task_id}.
func (o TaskOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *Task) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

func (o TaskOutput) Project() pulumi.StringOutput {
	return o.ApplyT(func(v *Task) pulumi.StringOutput { return v.Project }).(pulumi.StringOutput)
}

// Config related to running custom Spark tasks.
func (o TaskOutput) Spark() GoogleCloudDataplexV1TaskSparkTaskConfigResponseOutput {
	return o.ApplyT(func(v *Task) GoogleCloudDataplexV1TaskSparkTaskConfigResponseOutput { return v.Spark }).(GoogleCloudDataplexV1TaskSparkTaskConfigResponseOutput)
}

// Current state of the task.
func (o TaskOutput) State() pulumi.StringOutput {
	return o.ApplyT(func(v *Task) pulumi.StringOutput { return v.State }).(pulumi.StringOutput)
}

// Required. Task identifier.
func (o TaskOutput) TaskId() pulumi.StringOutput {
	return o.ApplyT(func(v *Task) pulumi.StringOutput { return v.TaskId }).(pulumi.StringOutput)
}

// Spec related to how often and when a task should be triggered.
func (o TaskOutput) TriggerSpec() GoogleCloudDataplexV1TaskTriggerSpecResponseOutput {
	return o.ApplyT(func(v *Task) GoogleCloudDataplexV1TaskTriggerSpecResponseOutput { return v.TriggerSpec }).(GoogleCloudDataplexV1TaskTriggerSpecResponseOutput)
}

// System generated globally unique ID for the task. This ID will be different if the task is deleted and re-created with the same name.
func (o TaskOutput) Uid() pulumi.StringOutput {
	return o.ApplyT(func(v *Task) pulumi.StringOutput { return v.Uid }).(pulumi.StringOutput)
}

// The time when the task was last updated.
func (o TaskOutput) UpdateTime() pulumi.StringOutput {
	return o.ApplyT(func(v *Task) pulumi.StringOutput { return v.UpdateTime }).(pulumi.StringOutput)
}

// Optional. Only validate the request, but do not perform mutations. The default is false.
func (o TaskOutput) ValidateOnly() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Task) pulumi.StringPtrOutput { return v.ValidateOnly }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*TaskInput)(nil)).Elem(), &Task{})
	pulumi.RegisterOutputType(TaskOutput{})
}
