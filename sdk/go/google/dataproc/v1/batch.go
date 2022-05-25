// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v1

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Creates a batch workload that executes asynchronously.
// Auto-naming is currently not supported for this resource.
type Batch struct {
	pulumi.CustomResourceState

	// The time when the batch was created.
	CreateTime pulumi.StringOutput `pulumi:"createTime"`
	// The email address of the user who created the batch.
	Creator pulumi.StringOutput `pulumi:"creator"`
	// Optional. Environment configuration for the batch execution.
	EnvironmentConfig EnvironmentConfigResponseOutput `pulumi:"environmentConfig"`
	// Optional. The labels to associate with this batch. Label keys must contain 1 to 63 characters, and must conform to RFC 1035 (https://www.ietf.org/rfc/rfc1035.txt). Label values may be empty, but, if present, must contain 1 to 63 characters, and must conform to RFC 1035 (https://www.ietf.org/rfc/rfc1035.txt). No more than 32 labels can be associated with a batch.
	Labels pulumi.StringMapOutput `pulumi:"labels"`
	// The resource name of the batch.
	Name pulumi.StringOutput `pulumi:"name"`
	// The resource name of the operation associated with this batch.
	Operation pulumi.StringOutput `pulumi:"operation"`
	// Optional. PySpark batch config.
	PysparkBatch PySparkBatchResponseOutput `pulumi:"pysparkBatch"`
	// Optional. Runtime configuration for the batch execution.
	RuntimeConfig RuntimeConfigResponseOutput `pulumi:"runtimeConfig"`
	// Runtime information about batch execution.
	RuntimeInfo RuntimeInfoResponseOutput `pulumi:"runtimeInfo"`
	// Optional. Spark batch config.
	SparkBatch SparkBatchResponseOutput `pulumi:"sparkBatch"`
	// Optional. SparkR batch config.
	SparkRBatch SparkRBatchResponseOutput `pulumi:"sparkRBatch"`
	// Optional. SparkSql batch config.
	SparkSqlBatch SparkSqlBatchResponseOutput `pulumi:"sparkSqlBatch"`
	// The state of the batch.
	State pulumi.StringOutput `pulumi:"state"`
	// Historical state information for the batch.
	StateHistory StateHistoryResponseArrayOutput `pulumi:"stateHistory"`
	// Batch state details, such as a failure description if the state is FAILED.
	StateMessage pulumi.StringOutput `pulumi:"stateMessage"`
	// The time when the batch entered a current state.
	StateTime pulumi.StringOutput `pulumi:"stateTime"`
	// A batch UUID (Unique Universal Identifier). The service generates this value when it creates the batch.
	Uuid pulumi.StringOutput `pulumi:"uuid"`
}

// NewBatch registers a new resource with the given unique name, arguments, and options.
func NewBatch(ctx *pulumi.Context,
	name string, args *BatchArgs, opts ...pulumi.ResourceOption) (*Batch, error) {
	if args == nil {
		args = &BatchArgs{}
	}

	var resource Batch
	err := ctx.RegisterResource("google-native:dataproc/v1:Batch", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetBatch gets an existing Batch resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetBatch(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *BatchState, opts ...pulumi.ResourceOption) (*Batch, error) {
	var resource Batch
	err := ctx.ReadResource("google-native:dataproc/v1:Batch", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Batch resources.
type batchState struct {
}

type BatchState struct {
}

func (BatchState) ElementType() reflect.Type {
	return reflect.TypeOf((*batchState)(nil)).Elem()
}

type batchArgs struct {
	// Optional. The ID to use for the batch, which will become the final component of the batch's resource name.This value must be 4-63 characters. Valid characters are /[a-z][0-9]-/.
	BatchId *string `pulumi:"batchId"`
	// Optional. Environment configuration for the batch execution.
	EnvironmentConfig *EnvironmentConfig `pulumi:"environmentConfig"`
	// Optional. The labels to associate with this batch. Label keys must contain 1 to 63 characters, and must conform to RFC 1035 (https://www.ietf.org/rfc/rfc1035.txt). Label values may be empty, but, if present, must contain 1 to 63 characters, and must conform to RFC 1035 (https://www.ietf.org/rfc/rfc1035.txt). No more than 32 labels can be associated with a batch.
	Labels   map[string]string `pulumi:"labels"`
	Location *string           `pulumi:"location"`
	Project  *string           `pulumi:"project"`
	// Optional. PySpark batch config.
	PysparkBatch *PySparkBatch `pulumi:"pysparkBatch"`
	// Optional. A unique ID used to identify the request. If the service receives two CreateBatchRequest (https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#google.cloud.dataproc.v1.CreateBatchRequest)s with the same request_id, the second request is ignored and the Operation that corresponds to the first Batch created and stored in the backend is returned.Recommendation: Set this value to a UUID (https://en.wikipedia.org/wiki/Universally_unique_identifier).The value must contain only letters (a-z, A-Z), numbers (0-9), underscores (_), and hyphens (-). The maximum length is 40 characters.
	RequestId *string `pulumi:"requestId"`
	// Optional. Runtime configuration for the batch execution.
	RuntimeConfig *RuntimeConfig `pulumi:"runtimeConfig"`
	// Optional. Spark batch config.
	SparkBatch *SparkBatch `pulumi:"sparkBatch"`
	// Optional. SparkR batch config.
	SparkRBatch *SparkRBatch `pulumi:"sparkRBatch"`
	// Optional. SparkSql batch config.
	SparkSqlBatch *SparkSqlBatch `pulumi:"sparkSqlBatch"`
}

// The set of arguments for constructing a Batch resource.
type BatchArgs struct {
	// Optional. The ID to use for the batch, which will become the final component of the batch's resource name.This value must be 4-63 characters. Valid characters are /[a-z][0-9]-/.
	BatchId pulumi.StringPtrInput
	// Optional. Environment configuration for the batch execution.
	EnvironmentConfig EnvironmentConfigPtrInput
	// Optional. The labels to associate with this batch. Label keys must contain 1 to 63 characters, and must conform to RFC 1035 (https://www.ietf.org/rfc/rfc1035.txt). Label values may be empty, but, if present, must contain 1 to 63 characters, and must conform to RFC 1035 (https://www.ietf.org/rfc/rfc1035.txt). No more than 32 labels can be associated with a batch.
	Labels   pulumi.StringMapInput
	Location pulumi.StringPtrInput
	Project  pulumi.StringPtrInput
	// Optional. PySpark batch config.
	PysparkBatch PySparkBatchPtrInput
	// Optional. A unique ID used to identify the request. If the service receives two CreateBatchRequest (https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#google.cloud.dataproc.v1.CreateBatchRequest)s with the same request_id, the second request is ignored and the Operation that corresponds to the first Batch created and stored in the backend is returned.Recommendation: Set this value to a UUID (https://en.wikipedia.org/wiki/Universally_unique_identifier).The value must contain only letters (a-z, A-Z), numbers (0-9), underscores (_), and hyphens (-). The maximum length is 40 characters.
	RequestId pulumi.StringPtrInput
	// Optional. Runtime configuration for the batch execution.
	RuntimeConfig RuntimeConfigPtrInput
	// Optional. Spark batch config.
	SparkBatch SparkBatchPtrInput
	// Optional. SparkR batch config.
	SparkRBatch SparkRBatchPtrInput
	// Optional. SparkSql batch config.
	SparkSqlBatch SparkSqlBatchPtrInput
}

func (BatchArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*batchArgs)(nil)).Elem()
}

type BatchInput interface {
	pulumi.Input

	ToBatchOutput() BatchOutput
	ToBatchOutputWithContext(ctx context.Context) BatchOutput
}

func (*Batch) ElementType() reflect.Type {
	return reflect.TypeOf((**Batch)(nil)).Elem()
}

func (i *Batch) ToBatchOutput() BatchOutput {
	return i.ToBatchOutputWithContext(context.Background())
}

func (i *Batch) ToBatchOutputWithContext(ctx context.Context) BatchOutput {
	return pulumi.ToOutputWithContext(ctx, i).(BatchOutput)
}

type BatchOutput struct{ *pulumi.OutputState }

func (BatchOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**Batch)(nil)).Elem()
}

func (o BatchOutput) ToBatchOutput() BatchOutput {
	return o
}

func (o BatchOutput) ToBatchOutputWithContext(ctx context.Context) BatchOutput {
	return o
}

// The time when the batch was created.
func (o BatchOutput) CreateTime() pulumi.StringOutput {
	return o.ApplyT(func(v *Batch) pulumi.StringOutput { return v.CreateTime }).(pulumi.StringOutput)
}

// The email address of the user who created the batch.
func (o BatchOutput) Creator() pulumi.StringOutput {
	return o.ApplyT(func(v *Batch) pulumi.StringOutput { return v.Creator }).(pulumi.StringOutput)
}

// Optional. Environment configuration for the batch execution.
func (o BatchOutput) EnvironmentConfig() EnvironmentConfigResponseOutput {
	return o.ApplyT(func(v *Batch) EnvironmentConfigResponseOutput { return v.EnvironmentConfig }).(EnvironmentConfigResponseOutput)
}

// Optional. The labels to associate with this batch. Label keys must contain 1 to 63 characters, and must conform to RFC 1035 (https://www.ietf.org/rfc/rfc1035.txt). Label values may be empty, but, if present, must contain 1 to 63 characters, and must conform to RFC 1035 (https://www.ietf.org/rfc/rfc1035.txt). No more than 32 labels can be associated with a batch.
func (o BatchOutput) Labels() pulumi.StringMapOutput {
	return o.ApplyT(func(v *Batch) pulumi.StringMapOutput { return v.Labels }).(pulumi.StringMapOutput)
}

// The resource name of the batch.
func (o BatchOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *Batch) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// The resource name of the operation associated with this batch.
func (o BatchOutput) Operation() pulumi.StringOutput {
	return o.ApplyT(func(v *Batch) pulumi.StringOutput { return v.Operation }).(pulumi.StringOutput)
}

// Optional. PySpark batch config.
func (o BatchOutput) PysparkBatch() PySparkBatchResponseOutput {
	return o.ApplyT(func(v *Batch) PySparkBatchResponseOutput { return v.PysparkBatch }).(PySparkBatchResponseOutput)
}

// Optional. Runtime configuration for the batch execution.
func (o BatchOutput) RuntimeConfig() RuntimeConfigResponseOutput {
	return o.ApplyT(func(v *Batch) RuntimeConfigResponseOutput { return v.RuntimeConfig }).(RuntimeConfigResponseOutput)
}

// Runtime information about batch execution.
func (o BatchOutput) RuntimeInfo() RuntimeInfoResponseOutput {
	return o.ApplyT(func(v *Batch) RuntimeInfoResponseOutput { return v.RuntimeInfo }).(RuntimeInfoResponseOutput)
}

// Optional. Spark batch config.
func (o BatchOutput) SparkBatch() SparkBatchResponseOutput {
	return o.ApplyT(func(v *Batch) SparkBatchResponseOutput { return v.SparkBatch }).(SparkBatchResponseOutput)
}

// Optional. SparkR batch config.
func (o BatchOutput) SparkRBatch() SparkRBatchResponseOutput {
	return o.ApplyT(func(v *Batch) SparkRBatchResponseOutput { return v.SparkRBatch }).(SparkRBatchResponseOutput)
}

// Optional. SparkSql batch config.
func (o BatchOutput) SparkSqlBatch() SparkSqlBatchResponseOutput {
	return o.ApplyT(func(v *Batch) SparkSqlBatchResponseOutput { return v.SparkSqlBatch }).(SparkSqlBatchResponseOutput)
}

// The state of the batch.
func (o BatchOutput) State() pulumi.StringOutput {
	return o.ApplyT(func(v *Batch) pulumi.StringOutput { return v.State }).(pulumi.StringOutput)
}

// Historical state information for the batch.
func (o BatchOutput) StateHistory() StateHistoryResponseArrayOutput {
	return o.ApplyT(func(v *Batch) StateHistoryResponseArrayOutput { return v.StateHistory }).(StateHistoryResponseArrayOutput)
}

// Batch state details, such as a failure description if the state is FAILED.
func (o BatchOutput) StateMessage() pulumi.StringOutput {
	return o.ApplyT(func(v *Batch) pulumi.StringOutput { return v.StateMessage }).(pulumi.StringOutput)
}

// The time when the batch entered a current state.
func (o BatchOutput) StateTime() pulumi.StringOutput {
	return o.ApplyT(func(v *Batch) pulumi.StringOutput { return v.StateTime }).(pulumi.StringOutput)
}

// A batch UUID (Unique Universal Identifier). The service generates this value when it creates the batch.
func (o BatchOutput) Uuid() pulumi.StringOutput {
	return o.ApplyT(func(v *Batch) pulumi.StringOutput { return v.Uuid }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*BatchInput)(nil)).Elem(), &Batch{})
	pulumi.RegisterOutputType(BatchOutput{})
}