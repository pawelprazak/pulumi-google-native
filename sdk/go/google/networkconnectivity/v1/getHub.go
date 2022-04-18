// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Gets details about the specified hub.
func LookupHub(ctx *pulumi.Context, args *LookupHubArgs, opts ...pulumi.InvokeOption) (*LookupHubResult, error) {
	var rv LookupHubResult
	err := ctx.Invoke("google-native:networkconnectivity/v1:getHub", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupHubArgs struct {
	HubId   string  `pulumi:"hubId"`
	Project *string `pulumi:"project"`
}

type LookupHubResult struct {
	// The time the hub was created.
	CreateTime string `pulumi:"createTime"`
	// An optional description of the hub.
	Description string `pulumi:"description"`
	// Optional labels in key:value format. For more information about labels, see [Requirements for labels](https://cloud.google.com/resource-manager/docs/creating-managing-labels#requirements).
	Labels map[string]string `pulumi:"labels"`
	// Immutable. The name of the hub. Hub names must be unique. They use the following form: `projects/{project_number}/locations/global/hubs/{hub_id}`
	Name string `pulumi:"name"`
	// The VPC networks associated with this hub's spokes. This field is read-only. Network Connectivity Center automatically populates it based on the set of spokes attached to the hub.
	RoutingVpcs []RoutingVPCResponse `pulumi:"routingVpcs"`
	// The current lifecycle state of this hub.
	State string `pulumi:"state"`
	// The Google-generated UUID for the hub. This value is unique across all hub resources. If a hub is deleted and another with the same name is created, the new hub is assigned a different unique_id.
	UniqueId string `pulumi:"uniqueId"`
	// The time the hub was last updated.
	UpdateTime string `pulumi:"updateTime"`
}

func LookupHubOutput(ctx *pulumi.Context, args LookupHubOutputArgs, opts ...pulumi.InvokeOption) LookupHubResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupHubResult, error) {
			args := v.(LookupHubArgs)
			r, err := LookupHub(ctx, &args, opts...)
			var s LookupHubResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupHubResultOutput)
}

type LookupHubOutputArgs struct {
	HubId   pulumi.StringInput    `pulumi:"hubId"`
	Project pulumi.StringPtrInput `pulumi:"project"`
}

func (LookupHubOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupHubArgs)(nil)).Elem()
}

type LookupHubResultOutput struct{ *pulumi.OutputState }

func (LookupHubResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupHubResult)(nil)).Elem()
}

func (o LookupHubResultOutput) ToLookupHubResultOutput() LookupHubResultOutput {
	return o
}

func (o LookupHubResultOutput) ToLookupHubResultOutputWithContext(ctx context.Context) LookupHubResultOutput {
	return o
}

// The time the hub was created.
func (o LookupHubResultOutput) CreateTime() pulumi.StringOutput {
	return o.ApplyT(func(v LookupHubResult) string { return v.CreateTime }).(pulumi.StringOutput)
}

// An optional description of the hub.
func (o LookupHubResultOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v LookupHubResult) string { return v.Description }).(pulumi.StringOutput)
}

// Optional labels in key:value format. For more information about labels, see [Requirements for labels](https://cloud.google.com/resource-manager/docs/creating-managing-labels#requirements).
func (o LookupHubResultOutput) Labels() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupHubResult) map[string]string { return v.Labels }).(pulumi.StringMapOutput)
}

// Immutable. The name of the hub. Hub names must be unique. They use the following form: `projects/{project_number}/locations/global/hubs/{hub_id}`
func (o LookupHubResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupHubResult) string { return v.Name }).(pulumi.StringOutput)
}

// The VPC networks associated with this hub's spokes. This field is read-only. Network Connectivity Center automatically populates it based on the set of spokes attached to the hub.
func (o LookupHubResultOutput) RoutingVpcs() RoutingVPCResponseArrayOutput {
	return o.ApplyT(func(v LookupHubResult) []RoutingVPCResponse { return v.RoutingVpcs }).(RoutingVPCResponseArrayOutput)
}

// The current lifecycle state of this hub.
func (o LookupHubResultOutput) State() pulumi.StringOutput {
	return o.ApplyT(func(v LookupHubResult) string { return v.State }).(pulumi.StringOutput)
}

// The Google-generated UUID for the hub. This value is unique across all hub resources. If a hub is deleted and another with the same name is created, the new hub is assigned a different unique_id.
func (o LookupHubResultOutput) UniqueId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupHubResult) string { return v.UniqueId }).(pulumi.StringOutput)
}

// The time the hub was last updated.
func (o LookupHubResultOutput) UpdateTime() pulumi.StringOutput {
	return o.ApplyT(func(v LookupHubResult) string { return v.UpdateTime }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupHubResultOutput{})
}