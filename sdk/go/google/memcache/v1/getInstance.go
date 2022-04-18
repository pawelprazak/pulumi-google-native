// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Gets details of a single Instance.
func LookupInstance(ctx *pulumi.Context, args *LookupInstanceArgs, opts ...pulumi.InvokeOption) (*LookupInstanceResult, error) {
	var rv LookupInstanceResult
	err := ctx.Invoke("google-native:memcache/v1:getInstance", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupInstanceArgs struct {
	InstanceId string  `pulumi:"instanceId"`
	Location   string  `pulumi:"location"`
	Project    *string `pulumi:"project"`
}

type LookupInstanceResult struct {
	// The full name of the Google Compute Engine [network](/compute/docs/networks-and-firewalls#networks) to which the instance is connected. If left unspecified, the `default` network will be used.
	AuthorizedNetwork string `pulumi:"authorizedNetwork"`
	// The time the instance was created.
	CreateTime string `pulumi:"createTime"`
	// Endpoint for the Discovery API.
	DiscoveryEndpoint string `pulumi:"discoveryEndpoint"`
	// User provided name for the instance, which is only used for display purposes. Cannot be more than 80 characters.
	DisplayName string `pulumi:"displayName"`
	// List of messages that describe the current state of the Memcached instance.
	InstanceMessages []InstanceMessageResponse `pulumi:"instanceMessages"`
	// Resource labels to represent user-provided metadata. Refer to cloud documentation on labels for more details. https://cloud.google.com/compute/docs/labeling-resources
	Labels map[string]string `pulumi:"labels"`
	// The maintenance policy for the instance. If not provided, the maintenance event will be performed based on Memorystore internal rollout schedule.
	MaintenancePolicy GoogleCloudMemcacheV1MaintenancePolicyResponse `pulumi:"maintenancePolicy"`
	// Published maintenance schedule.
	MaintenanceSchedule MaintenanceScheduleResponse `pulumi:"maintenanceSchedule"`
	// The full version of memcached server running on this instance. System automatically determines the full memcached version for an instance based on the input MemcacheVersion. The full version format will be "memcached-1.5.16".
	MemcacheFullVersion string `pulumi:"memcacheFullVersion"`
	// List of Memcached nodes. Refer to Node message for more details.
	MemcacheNodes []NodeResponse `pulumi:"memcacheNodes"`
	// The major version of Memcached software. If not provided, latest supported version will be used. Currently the latest supported major version is `MEMCACHE_1_5`. The minor version will be automatically determined by our system based on the latest supported minor version.
	MemcacheVersion string `pulumi:"memcacheVersion"`
	// Unique name of the resource in this scope including project and location using the form: `projects/{project_id}/locations/{location_id}/instances/{instance_id}` Note: Memcached instances are managed and addressed at the regional level so `location_id` here refers to a Google Cloud region; however, users may choose which zones Memcached nodes should be provisioned in within an instance. Refer to zones field for more details.
	Name string `pulumi:"name"`
	// Configuration for Memcached nodes.
	NodeConfig NodeConfigResponse `pulumi:"nodeConfig"`
	// Number of nodes in the Memcached instance.
	NodeCount int `pulumi:"nodeCount"`
	// User defined parameters to apply to the memcached process on each node.
	Parameters MemcacheParametersResponse `pulumi:"parameters"`
	// The state of this Memcached instance.
	State string `pulumi:"state"`
	// The time the instance was updated.
	UpdateTime string `pulumi:"updateTime"`
	// Zones in which Memcached nodes should be provisioned. Memcached nodes will be equally distributed across these zones. If not provided, the service will by default create nodes in all zones in the region for the instance.
	Zones []string `pulumi:"zones"`
}

func LookupInstanceOutput(ctx *pulumi.Context, args LookupInstanceOutputArgs, opts ...pulumi.InvokeOption) LookupInstanceResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupInstanceResult, error) {
			args := v.(LookupInstanceArgs)
			r, err := LookupInstance(ctx, &args, opts...)
			var s LookupInstanceResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupInstanceResultOutput)
}

type LookupInstanceOutputArgs struct {
	InstanceId pulumi.StringInput    `pulumi:"instanceId"`
	Location   pulumi.StringInput    `pulumi:"location"`
	Project    pulumi.StringPtrInput `pulumi:"project"`
}

func (LookupInstanceOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupInstanceArgs)(nil)).Elem()
}

type LookupInstanceResultOutput struct{ *pulumi.OutputState }

func (LookupInstanceResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupInstanceResult)(nil)).Elem()
}

func (o LookupInstanceResultOutput) ToLookupInstanceResultOutput() LookupInstanceResultOutput {
	return o
}

func (o LookupInstanceResultOutput) ToLookupInstanceResultOutputWithContext(ctx context.Context) LookupInstanceResultOutput {
	return o
}

// The full name of the Google Compute Engine [network](/compute/docs/networks-and-firewalls#networks) to which the instance is connected. If left unspecified, the `default` network will be used.
func (o LookupInstanceResultOutput) AuthorizedNetwork() pulumi.StringOutput {
	return o.ApplyT(func(v LookupInstanceResult) string { return v.AuthorizedNetwork }).(pulumi.StringOutput)
}

// The time the instance was created.
func (o LookupInstanceResultOutput) CreateTime() pulumi.StringOutput {
	return o.ApplyT(func(v LookupInstanceResult) string { return v.CreateTime }).(pulumi.StringOutput)
}

// Endpoint for the Discovery API.
func (o LookupInstanceResultOutput) DiscoveryEndpoint() pulumi.StringOutput {
	return o.ApplyT(func(v LookupInstanceResult) string { return v.DiscoveryEndpoint }).(pulumi.StringOutput)
}

// User provided name for the instance, which is only used for display purposes. Cannot be more than 80 characters.
func (o LookupInstanceResultOutput) DisplayName() pulumi.StringOutput {
	return o.ApplyT(func(v LookupInstanceResult) string { return v.DisplayName }).(pulumi.StringOutput)
}

// List of messages that describe the current state of the Memcached instance.
func (o LookupInstanceResultOutput) InstanceMessages() InstanceMessageResponseArrayOutput {
	return o.ApplyT(func(v LookupInstanceResult) []InstanceMessageResponse { return v.InstanceMessages }).(InstanceMessageResponseArrayOutput)
}

// Resource labels to represent user-provided metadata. Refer to cloud documentation on labels for more details. https://cloud.google.com/compute/docs/labeling-resources
func (o LookupInstanceResultOutput) Labels() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupInstanceResult) map[string]string { return v.Labels }).(pulumi.StringMapOutput)
}

// The maintenance policy for the instance. If not provided, the maintenance event will be performed based on Memorystore internal rollout schedule.
func (o LookupInstanceResultOutput) MaintenancePolicy() GoogleCloudMemcacheV1MaintenancePolicyResponseOutput {
	return o.ApplyT(func(v LookupInstanceResult) GoogleCloudMemcacheV1MaintenancePolicyResponse {
		return v.MaintenancePolicy
	}).(GoogleCloudMemcacheV1MaintenancePolicyResponseOutput)
}

// Published maintenance schedule.
func (o LookupInstanceResultOutput) MaintenanceSchedule() MaintenanceScheduleResponseOutput {
	return o.ApplyT(func(v LookupInstanceResult) MaintenanceScheduleResponse { return v.MaintenanceSchedule }).(MaintenanceScheduleResponseOutput)
}

// The full version of memcached server running on this instance. System automatically determines the full memcached version for an instance based on the input MemcacheVersion. The full version format will be "memcached-1.5.16".
func (o LookupInstanceResultOutput) MemcacheFullVersion() pulumi.StringOutput {
	return o.ApplyT(func(v LookupInstanceResult) string { return v.MemcacheFullVersion }).(pulumi.StringOutput)
}

// List of Memcached nodes. Refer to Node message for more details.
func (o LookupInstanceResultOutput) MemcacheNodes() NodeResponseArrayOutput {
	return o.ApplyT(func(v LookupInstanceResult) []NodeResponse { return v.MemcacheNodes }).(NodeResponseArrayOutput)
}

// The major version of Memcached software. If not provided, latest supported version will be used. Currently the latest supported major version is `MEMCACHE_1_5`. The minor version will be automatically determined by our system based on the latest supported minor version.
func (o LookupInstanceResultOutput) MemcacheVersion() pulumi.StringOutput {
	return o.ApplyT(func(v LookupInstanceResult) string { return v.MemcacheVersion }).(pulumi.StringOutput)
}

// Unique name of the resource in this scope including project and location using the form: `projects/{project_id}/locations/{location_id}/instances/{instance_id}` Note: Memcached instances are managed and addressed at the regional level so `location_id` here refers to a Google Cloud region; however, users may choose which zones Memcached nodes should be provisioned in within an instance. Refer to zones field for more details.
func (o LookupInstanceResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupInstanceResult) string { return v.Name }).(pulumi.StringOutput)
}

// Configuration for Memcached nodes.
func (o LookupInstanceResultOutput) NodeConfig() NodeConfigResponseOutput {
	return o.ApplyT(func(v LookupInstanceResult) NodeConfigResponse { return v.NodeConfig }).(NodeConfigResponseOutput)
}

// Number of nodes in the Memcached instance.
func (o LookupInstanceResultOutput) NodeCount() pulumi.IntOutput {
	return o.ApplyT(func(v LookupInstanceResult) int { return v.NodeCount }).(pulumi.IntOutput)
}

// User defined parameters to apply to the memcached process on each node.
func (o LookupInstanceResultOutput) Parameters() MemcacheParametersResponseOutput {
	return o.ApplyT(func(v LookupInstanceResult) MemcacheParametersResponse { return v.Parameters }).(MemcacheParametersResponseOutput)
}

// The state of this Memcached instance.
func (o LookupInstanceResultOutput) State() pulumi.StringOutput {
	return o.ApplyT(func(v LookupInstanceResult) string { return v.State }).(pulumi.StringOutput)
}

// The time the instance was updated.
func (o LookupInstanceResultOutput) UpdateTime() pulumi.StringOutput {
	return o.ApplyT(func(v LookupInstanceResult) string { return v.UpdateTime }).(pulumi.StringOutput)
}

// Zones in which Memcached nodes should be provisioned. Memcached nodes will be equally distributed across these zones. If not provided, the service will by default create nodes in all zones in the region for the instance.
func (o LookupInstanceResultOutput) Zones() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupInstanceResult) []string { return v.Zones }).(pulumi.StringArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupInstanceResultOutput{})
}