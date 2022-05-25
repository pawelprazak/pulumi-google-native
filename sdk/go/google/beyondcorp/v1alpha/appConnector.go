// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Creates a new AppConnector in a given project and location.
type AppConnector struct {
	pulumi.CustomResourceState

	// Timestamp when the resource was created.
	CreateTime pulumi.StringOutput `pulumi:"createTime"`
	// Optional. An arbitrary user-provided name for the AppConnector. Cannot exceed 64 characters.
	DisplayName pulumi.StringOutput `pulumi:"displayName"`
	// Optional. Resource labels to represent user provided metadata.
	Labels pulumi.StringMapOutput `pulumi:"labels"`
	// Unique resource name of the AppConnector. The name is ignored when creating a AppConnector.
	Name pulumi.StringOutput `pulumi:"name"`
	// Principal information about the Identity of the AppConnector.
	PrincipalInfo GoogleCloudBeyondcorpAppconnectorsV1alphaAppConnectorPrincipalInfoResponseOutput `pulumi:"principalInfo"`
	// Optional. Resource info of the connector.
	ResourceInfo GoogleCloudBeyondcorpAppconnectorsV1alphaResourceInfoResponseOutput `pulumi:"resourceInfo"`
	// The current state of the AppConnector.
	State pulumi.StringOutput `pulumi:"state"`
	// A unique identifier for the instance generated by the system.
	Uid pulumi.StringOutput `pulumi:"uid"`
	// Timestamp when the resource was last modified.
	UpdateTime pulumi.StringOutput `pulumi:"updateTime"`
}

// NewAppConnector registers a new resource with the given unique name, arguments, and options.
func NewAppConnector(ctx *pulumi.Context,
	name string, args *AppConnectorArgs, opts ...pulumi.ResourceOption) (*AppConnector, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.PrincipalInfo == nil {
		return nil, errors.New("invalid value for required argument 'PrincipalInfo'")
	}
	var resource AppConnector
	err := ctx.RegisterResource("google-native:beyondcorp/v1alpha:AppConnector", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetAppConnector gets an existing AppConnector resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetAppConnector(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *AppConnectorState, opts ...pulumi.ResourceOption) (*AppConnector, error) {
	var resource AppConnector
	err := ctx.ReadResource("google-native:beyondcorp/v1alpha:AppConnector", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering AppConnector resources.
type appConnectorState struct {
}

type AppConnectorState struct {
}

func (AppConnectorState) ElementType() reflect.Type {
	return reflect.TypeOf((*appConnectorState)(nil)).Elem()
}

type appConnectorArgs struct {
	// Optional. User-settable AppConnector resource ID. * Must start with a letter. * Must contain between 4-63 characters from (/a-z-/). * Must end with a number or a letter.
	AppConnectorId *string `pulumi:"appConnectorId"`
	// Optional. An arbitrary user-provided name for the AppConnector. Cannot exceed 64 characters.
	DisplayName *string `pulumi:"displayName"`
	// Optional. Resource labels to represent user provided metadata.
	Labels   map[string]string `pulumi:"labels"`
	Location *string           `pulumi:"location"`
	// Unique resource name of the AppConnector. The name is ignored when creating a AppConnector.
	Name *string `pulumi:"name"`
	// Principal information about the Identity of the AppConnector.
	PrincipalInfo GoogleCloudBeyondcorpAppconnectorsV1alphaAppConnectorPrincipalInfo `pulumi:"principalInfo"`
	Project       *string                                                            `pulumi:"project"`
	// Optional. An optional request ID to identify requests. Specify a unique request ID so that if you must retry your request, the server will know to ignore the request if it has already been completed. The server will guarantee that for at least 60 minutes since the first request. For example, consider a situation where you make an initial request and t he request times out. If you make the request again with the same request ID, the server can check if original operation with the same request ID was received, and if so, will ignore the second request. This prevents clients from accidentally creating duplicate commitments. The request ID must be a valid UUID with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
	RequestId *string `pulumi:"requestId"`
	// Optional. Resource info of the connector.
	ResourceInfo *GoogleCloudBeyondcorpAppconnectorsV1alphaResourceInfo `pulumi:"resourceInfo"`
	// Optional. If set, validates request by executing a dry-run which would not alter the resource in any way.
	ValidateOnly *string `pulumi:"validateOnly"`
}

// The set of arguments for constructing a AppConnector resource.
type AppConnectorArgs struct {
	// Optional. User-settable AppConnector resource ID. * Must start with a letter. * Must contain between 4-63 characters from (/a-z-/). * Must end with a number or a letter.
	AppConnectorId pulumi.StringPtrInput
	// Optional. An arbitrary user-provided name for the AppConnector. Cannot exceed 64 characters.
	DisplayName pulumi.StringPtrInput
	// Optional. Resource labels to represent user provided metadata.
	Labels   pulumi.StringMapInput
	Location pulumi.StringPtrInput
	// Unique resource name of the AppConnector. The name is ignored when creating a AppConnector.
	Name pulumi.StringPtrInput
	// Principal information about the Identity of the AppConnector.
	PrincipalInfo GoogleCloudBeyondcorpAppconnectorsV1alphaAppConnectorPrincipalInfoInput
	Project       pulumi.StringPtrInput
	// Optional. An optional request ID to identify requests. Specify a unique request ID so that if you must retry your request, the server will know to ignore the request if it has already been completed. The server will guarantee that for at least 60 minutes since the first request. For example, consider a situation where you make an initial request and t he request times out. If you make the request again with the same request ID, the server can check if original operation with the same request ID was received, and if so, will ignore the second request. This prevents clients from accidentally creating duplicate commitments. The request ID must be a valid UUID with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
	RequestId pulumi.StringPtrInput
	// Optional. Resource info of the connector.
	ResourceInfo GoogleCloudBeyondcorpAppconnectorsV1alphaResourceInfoPtrInput
	// Optional. If set, validates request by executing a dry-run which would not alter the resource in any way.
	ValidateOnly pulumi.StringPtrInput
}

func (AppConnectorArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*appConnectorArgs)(nil)).Elem()
}

type AppConnectorInput interface {
	pulumi.Input

	ToAppConnectorOutput() AppConnectorOutput
	ToAppConnectorOutputWithContext(ctx context.Context) AppConnectorOutput
}

func (*AppConnector) ElementType() reflect.Type {
	return reflect.TypeOf((**AppConnector)(nil)).Elem()
}

func (i *AppConnector) ToAppConnectorOutput() AppConnectorOutput {
	return i.ToAppConnectorOutputWithContext(context.Background())
}

func (i *AppConnector) ToAppConnectorOutputWithContext(ctx context.Context) AppConnectorOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AppConnectorOutput)
}

type AppConnectorOutput struct{ *pulumi.OutputState }

func (AppConnectorOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**AppConnector)(nil)).Elem()
}

func (o AppConnectorOutput) ToAppConnectorOutput() AppConnectorOutput {
	return o
}

func (o AppConnectorOutput) ToAppConnectorOutputWithContext(ctx context.Context) AppConnectorOutput {
	return o
}

// Timestamp when the resource was created.
func (o AppConnectorOutput) CreateTime() pulumi.StringOutput {
	return o.ApplyT(func(v *AppConnector) pulumi.StringOutput { return v.CreateTime }).(pulumi.StringOutput)
}

// Optional. An arbitrary user-provided name for the AppConnector. Cannot exceed 64 characters.
func (o AppConnectorOutput) DisplayName() pulumi.StringOutput {
	return o.ApplyT(func(v *AppConnector) pulumi.StringOutput { return v.DisplayName }).(pulumi.StringOutput)
}

// Optional. Resource labels to represent user provided metadata.
func (o AppConnectorOutput) Labels() pulumi.StringMapOutput {
	return o.ApplyT(func(v *AppConnector) pulumi.StringMapOutput { return v.Labels }).(pulumi.StringMapOutput)
}

// Unique resource name of the AppConnector. The name is ignored when creating a AppConnector.
func (o AppConnectorOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *AppConnector) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// Principal information about the Identity of the AppConnector.
func (o AppConnectorOutput) PrincipalInfo() GoogleCloudBeyondcorpAppconnectorsV1alphaAppConnectorPrincipalInfoResponseOutput {
	return o.ApplyT(func(v *AppConnector) GoogleCloudBeyondcorpAppconnectorsV1alphaAppConnectorPrincipalInfoResponseOutput {
		return v.PrincipalInfo
	}).(GoogleCloudBeyondcorpAppconnectorsV1alphaAppConnectorPrincipalInfoResponseOutput)
}

// Optional. Resource info of the connector.
func (o AppConnectorOutput) ResourceInfo() GoogleCloudBeyondcorpAppconnectorsV1alphaResourceInfoResponseOutput {
	return o.ApplyT(func(v *AppConnector) GoogleCloudBeyondcorpAppconnectorsV1alphaResourceInfoResponseOutput {
		return v.ResourceInfo
	}).(GoogleCloudBeyondcorpAppconnectorsV1alphaResourceInfoResponseOutput)
}

// The current state of the AppConnector.
func (o AppConnectorOutput) State() pulumi.StringOutput {
	return o.ApplyT(func(v *AppConnector) pulumi.StringOutput { return v.State }).(pulumi.StringOutput)
}

// A unique identifier for the instance generated by the system.
func (o AppConnectorOutput) Uid() pulumi.StringOutput {
	return o.ApplyT(func(v *AppConnector) pulumi.StringOutput { return v.Uid }).(pulumi.StringOutput)
}

// Timestamp when the resource was last modified.
func (o AppConnectorOutput) UpdateTime() pulumi.StringOutput {
	return o.ApplyT(func(v *AppConnector) pulumi.StringOutput { return v.UpdateTime }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*AppConnectorInput)(nil)).Elem(), &AppConnector{})
	pulumi.RegisterOutputType(AppConnectorOutput{})
}