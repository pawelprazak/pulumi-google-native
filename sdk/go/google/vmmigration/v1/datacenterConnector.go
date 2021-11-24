// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Creates a new DatacenterConnector in a given Source.
// Auto-naming is currently not supported for this resource.
type DatacenterConnector struct {
	pulumi.CustomResourceState

	// The communication channel between the datacenter connector and GCP.
	Bucket pulumi.StringOutput `pulumi:"bucket"`
	// The time the connector was created (as an API call, not when it was actually installed).
	CreateTime pulumi.StringOutput `pulumi:"createTime"`
	// Provides details on the state of the Datacenter Connector in case of an error.
	Error StatusResponseOutput `pulumi:"error"`
	// The connector's name.
	Name pulumi.StringOutput `pulumi:"name"`
	// Immutable. A unique key for this connector. This key is internal to the OVA connector and is supplied with its creation during the registration process and can not be modified.
	RegistrationId pulumi.StringOutput `pulumi:"registrationId"`
	// The service account to use in the connector when communicating with the cloud.
	ServiceAccount pulumi.StringOutput `pulumi:"serviceAccount"`
	// State of the DatacenterConnector, as determined by the health checks.
	State pulumi.StringOutput `pulumi:"state"`
	// The time the state was last set.
	StateTime pulumi.StringOutput `pulumi:"stateTime"`
	// The last time the connector was updated with an API call.
	UpdateTime pulumi.StringOutput `pulumi:"updateTime"`
	// The version running in the DatacenterConnector. This is supplied by the OVA connector during the registration process and can not be modified.
	Version pulumi.StringOutput `pulumi:"version"`
}

// NewDatacenterConnector registers a new resource with the given unique name, arguments, and options.
func NewDatacenterConnector(ctx *pulumi.Context,
	name string, args *DatacenterConnectorArgs, opts ...pulumi.ResourceOption) (*DatacenterConnector, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.DatacenterConnectorId == nil {
		return nil, errors.New("invalid value for required argument 'DatacenterConnectorId'")
	}
	if args.SourceId == nil {
		return nil, errors.New("invalid value for required argument 'SourceId'")
	}
	var resource DatacenterConnector
	err := ctx.RegisterResource("google-native:vmmigration/v1:DatacenterConnector", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDatacenterConnector gets an existing DatacenterConnector resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDatacenterConnector(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DatacenterConnectorState, opts ...pulumi.ResourceOption) (*DatacenterConnector, error) {
	var resource DatacenterConnector
	err := ctx.ReadResource("google-native:vmmigration/v1:DatacenterConnector", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering DatacenterConnector resources.
type datacenterConnectorState struct {
}

type DatacenterConnectorState struct {
}

func (DatacenterConnectorState) ElementType() reflect.Type {
	return reflect.TypeOf((*datacenterConnectorState)(nil)).Elem()
}

type datacenterConnectorArgs struct {
	DatacenterConnectorId string  `pulumi:"datacenterConnectorId"`
	Location              *string `pulumi:"location"`
	Project               *string `pulumi:"project"`
	// Immutable. A unique key for this connector. This key is internal to the OVA connector and is supplied with its creation during the registration process and can not be modified.
	RegistrationId *string `pulumi:"registrationId"`
	RequestId      *string `pulumi:"requestId"`
	// The service account to use in the connector when communicating with the cloud.
	ServiceAccount *string `pulumi:"serviceAccount"`
	SourceId       string  `pulumi:"sourceId"`
	// The version running in the DatacenterConnector. This is supplied by the OVA connector during the registration process and can not be modified.
	Version *string `pulumi:"version"`
}

// The set of arguments for constructing a DatacenterConnector resource.
type DatacenterConnectorArgs struct {
	DatacenterConnectorId pulumi.StringInput
	Location              pulumi.StringPtrInput
	Project               pulumi.StringPtrInput
	// Immutable. A unique key for this connector. This key is internal to the OVA connector and is supplied with its creation during the registration process and can not be modified.
	RegistrationId pulumi.StringPtrInput
	RequestId      pulumi.StringPtrInput
	// The service account to use in the connector when communicating with the cloud.
	ServiceAccount pulumi.StringPtrInput
	SourceId       pulumi.StringInput
	// The version running in the DatacenterConnector. This is supplied by the OVA connector during the registration process and can not be modified.
	Version pulumi.StringPtrInput
}

func (DatacenterConnectorArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*datacenterConnectorArgs)(nil)).Elem()
}

type DatacenterConnectorInput interface {
	pulumi.Input

	ToDatacenterConnectorOutput() DatacenterConnectorOutput
	ToDatacenterConnectorOutputWithContext(ctx context.Context) DatacenterConnectorOutput
}

func (*DatacenterConnector) ElementType() reflect.Type {
	return reflect.TypeOf((*DatacenterConnector)(nil))
}

func (i *DatacenterConnector) ToDatacenterConnectorOutput() DatacenterConnectorOutput {
	return i.ToDatacenterConnectorOutputWithContext(context.Background())
}

func (i *DatacenterConnector) ToDatacenterConnectorOutputWithContext(ctx context.Context) DatacenterConnectorOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DatacenterConnectorOutput)
}

type DatacenterConnectorOutput struct{ *pulumi.OutputState }

func (DatacenterConnectorOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*DatacenterConnector)(nil))
}

func (o DatacenterConnectorOutput) ToDatacenterConnectorOutput() DatacenterConnectorOutput {
	return o
}

func (o DatacenterConnectorOutput) ToDatacenterConnectorOutputWithContext(ctx context.Context) DatacenterConnectorOutput {
	return o
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*DatacenterConnectorInput)(nil)).Elem(), &DatacenterConnector{})
	pulumi.RegisterOutputType(DatacenterConnectorOutput{})
}