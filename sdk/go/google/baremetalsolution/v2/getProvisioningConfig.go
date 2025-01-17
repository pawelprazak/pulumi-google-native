// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v2

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Get ProvisioningConfig by name.
func LookupProvisioningConfig(ctx *pulumi.Context, args *LookupProvisioningConfigArgs, opts ...pulumi.InvokeOption) (*LookupProvisioningConfigResult, error) {
	var rv LookupProvisioningConfigResult
	err := ctx.Invoke("google-native:baremetalsolution/v2:getProvisioningConfig", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupProvisioningConfigArgs struct {
	Location             string  `pulumi:"location"`
	Project              *string `pulumi:"project"`
	ProvisioningConfigId string  `pulumi:"provisioningConfigId"`
}

type LookupProvisioningConfigResult struct {
	// URI to Cloud Console UI view of this provisioning config.
	CloudConsoleUri string `pulumi:"cloudConsoleUri"`
	// Email provided to send a confirmation with provisioning config to. Deprecated in favour of email field in request messages.
	//
	// Deprecated: Email provided to send a confirmation with provisioning config to. Deprecated in favour of email field in request messages.
	Email string `pulumi:"email"`
	// A service account to enable customers to access instance credentials upon handover.
	HandoverServiceAccount string `pulumi:"handoverServiceAccount"`
	// Instances to be created.
	Instances []InstanceConfigResponse `pulumi:"instances"`
	// Optional. Location name of this ProvisioningConfig. It is optional only for Intake UI transition period.
	Location string `pulumi:"location"`
	// The name of the provisioning config.
	Name string `pulumi:"name"`
	// Networks to be created.
	Networks []NetworkConfigResponse `pulumi:"networks"`
	// State of ProvisioningConfig.
	State string `pulumi:"state"`
	// Optional status messages associated with the FAILED state.
	StatusMessage string `pulumi:"statusMessage"`
	// A generated ticket id to track provisioning request.
	TicketId string `pulumi:"ticketId"`
	// Last update timestamp.
	UpdateTime string `pulumi:"updateTime"`
	// Volumes to be created.
	Volumes []VolumeConfigResponse `pulumi:"volumes"`
	// If true, VPC SC is enabled for the cluster.
	VpcScEnabled bool `pulumi:"vpcScEnabled"`
}

func LookupProvisioningConfigOutput(ctx *pulumi.Context, args LookupProvisioningConfigOutputArgs, opts ...pulumi.InvokeOption) LookupProvisioningConfigResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupProvisioningConfigResult, error) {
			args := v.(LookupProvisioningConfigArgs)
			r, err := LookupProvisioningConfig(ctx, &args, opts...)
			var s LookupProvisioningConfigResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupProvisioningConfigResultOutput)
}

type LookupProvisioningConfigOutputArgs struct {
	Location             pulumi.StringInput    `pulumi:"location"`
	Project              pulumi.StringPtrInput `pulumi:"project"`
	ProvisioningConfigId pulumi.StringInput    `pulumi:"provisioningConfigId"`
}

func (LookupProvisioningConfigOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupProvisioningConfigArgs)(nil)).Elem()
}

type LookupProvisioningConfigResultOutput struct{ *pulumi.OutputState }

func (LookupProvisioningConfigResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupProvisioningConfigResult)(nil)).Elem()
}

func (o LookupProvisioningConfigResultOutput) ToLookupProvisioningConfigResultOutput() LookupProvisioningConfigResultOutput {
	return o
}

func (o LookupProvisioningConfigResultOutput) ToLookupProvisioningConfigResultOutputWithContext(ctx context.Context) LookupProvisioningConfigResultOutput {
	return o
}

// URI to Cloud Console UI view of this provisioning config.
func (o LookupProvisioningConfigResultOutput) CloudConsoleUri() pulumi.StringOutput {
	return o.ApplyT(func(v LookupProvisioningConfigResult) string { return v.CloudConsoleUri }).(pulumi.StringOutput)
}

// Email provided to send a confirmation with provisioning config to. Deprecated in favour of email field in request messages.
//
// Deprecated: Email provided to send a confirmation with provisioning config to. Deprecated in favour of email field in request messages.
func (o LookupProvisioningConfigResultOutput) Email() pulumi.StringOutput {
	return o.ApplyT(func(v LookupProvisioningConfigResult) string { return v.Email }).(pulumi.StringOutput)
}

// A service account to enable customers to access instance credentials upon handover.
func (o LookupProvisioningConfigResultOutput) HandoverServiceAccount() pulumi.StringOutput {
	return o.ApplyT(func(v LookupProvisioningConfigResult) string { return v.HandoverServiceAccount }).(pulumi.StringOutput)
}

// Instances to be created.
func (o LookupProvisioningConfigResultOutput) Instances() InstanceConfigResponseArrayOutput {
	return o.ApplyT(func(v LookupProvisioningConfigResult) []InstanceConfigResponse { return v.Instances }).(InstanceConfigResponseArrayOutput)
}

// Optional. Location name of this ProvisioningConfig. It is optional only for Intake UI transition period.
func (o LookupProvisioningConfigResultOutput) Location() pulumi.StringOutput {
	return o.ApplyT(func(v LookupProvisioningConfigResult) string { return v.Location }).(pulumi.StringOutput)
}

// The name of the provisioning config.
func (o LookupProvisioningConfigResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupProvisioningConfigResult) string { return v.Name }).(pulumi.StringOutput)
}

// Networks to be created.
func (o LookupProvisioningConfigResultOutput) Networks() NetworkConfigResponseArrayOutput {
	return o.ApplyT(func(v LookupProvisioningConfigResult) []NetworkConfigResponse { return v.Networks }).(NetworkConfigResponseArrayOutput)
}

// State of ProvisioningConfig.
func (o LookupProvisioningConfigResultOutput) State() pulumi.StringOutput {
	return o.ApplyT(func(v LookupProvisioningConfigResult) string { return v.State }).(pulumi.StringOutput)
}

// Optional status messages associated with the FAILED state.
func (o LookupProvisioningConfigResultOutput) StatusMessage() pulumi.StringOutput {
	return o.ApplyT(func(v LookupProvisioningConfigResult) string { return v.StatusMessage }).(pulumi.StringOutput)
}

// A generated ticket id to track provisioning request.
func (o LookupProvisioningConfigResultOutput) TicketId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupProvisioningConfigResult) string { return v.TicketId }).(pulumi.StringOutput)
}

// Last update timestamp.
func (o LookupProvisioningConfigResultOutput) UpdateTime() pulumi.StringOutput {
	return o.ApplyT(func(v LookupProvisioningConfigResult) string { return v.UpdateTime }).(pulumi.StringOutput)
}

// Volumes to be created.
func (o LookupProvisioningConfigResultOutput) Volumes() VolumeConfigResponseArrayOutput {
	return o.ApplyT(func(v LookupProvisioningConfigResult) []VolumeConfigResponse { return v.Volumes }).(VolumeConfigResponseArrayOutput)
}

// If true, VPC SC is enabled for the cluster.
func (o LookupProvisioningConfigResultOutput) VpcScEnabled() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupProvisioningConfigResult) bool { return v.VpcScEnabled }).(pulumi.BoolOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupProvisioningConfigResultOutput{})
}
