// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v1

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Gets a TargetServer resource.
func LookupTargetServer(ctx *pulumi.Context, args *LookupTargetServerArgs, opts ...pulumi.InvokeOption) (*LookupTargetServerResult, error) {
	var rv LookupTargetServerResult
	err := ctx.Invoke("google-native:apigee/v1:getTargetServer", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupTargetServerArgs struct {
	EnvironmentId  string `pulumi:"environmentId"`
	OrganizationId string `pulumi:"organizationId"`
	TargetserverId string `pulumi:"targetserverId"`
}

type LookupTargetServerResult struct {
	// Optional. A human-readable description of this TargetServer.
	Description string `pulumi:"description"`
	// The host name this target connects to. Value must be a valid hostname as described by RFC-1123.
	Host string `pulumi:"host"`
	// Optional. Enabling/disabling a TargetServer is useful when TargetServers are used in load balancing configurations, and one or more TargetServers need to taken out of rotation periodically. Defaults to true.
	IsEnabled bool `pulumi:"isEnabled"`
	// The resource id of this target server. Values must match the regular expression
	Name string `pulumi:"name"`
	// The port number this target connects to on the given host. Value must be between 1 and 65535, inclusive.
	Port int `pulumi:"port"`
	// Immutable. The protocol used by this TargetServer.
	Protocol string `pulumi:"protocol"`
	// Optional. Specifies TLS configuration info for this TargetServer. The JSON name is `sSLInfo` for legacy/backwards compatibility reasons -- Edge originally supported SSL, and the name is still used for TLS configuration.
	SSLInfo GoogleCloudApigeeV1TlsInfoResponse `pulumi:"sSLInfo"`
}

func LookupTargetServerOutput(ctx *pulumi.Context, args LookupTargetServerOutputArgs, opts ...pulumi.InvokeOption) LookupTargetServerResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupTargetServerResult, error) {
			args := v.(LookupTargetServerArgs)
			r, err := LookupTargetServer(ctx, &args, opts...)
			var s LookupTargetServerResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupTargetServerResultOutput)
}

type LookupTargetServerOutputArgs struct {
	EnvironmentId  pulumi.StringInput `pulumi:"environmentId"`
	OrganizationId pulumi.StringInput `pulumi:"organizationId"`
	TargetserverId pulumi.StringInput `pulumi:"targetserverId"`
}

func (LookupTargetServerOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupTargetServerArgs)(nil)).Elem()
}

type LookupTargetServerResultOutput struct{ *pulumi.OutputState }

func (LookupTargetServerResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupTargetServerResult)(nil)).Elem()
}

func (o LookupTargetServerResultOutput) ToLookupTargetServerResultOutput() LookupTargetServerResultOutput {
	return o
}

func (o LookupTargetServerResultOutput) ToLookupTargetServerResultOutputWithContext(ctx context.Context) LookupTargetServerResultOutput {
	return o
}

// Optional. A human-readable description of this TargetServer.
func (o LookupTargetServerResultOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v LookupTargetServerResult) string { return v.Description }).(pulumi.StringOutput)
}

// The host name this target connects to. Value must be a valid hostname as described by RFC-1123.
func (o LookupTargetServerResultOutput) Host() pulumi.StringOutput {
	return o.ApplyT(func(v LookupTargetServerResult) string { return v.Host }).(pulumi.StringOutput)
}

// Optional. Enabling/disabling a TargetServer is useful when TargetServers are used in load balancing configurations, and one or more TargetServers need to taken out of rotation periodically. Defaults to true.
func (o LookupTargetServerResultOutput) IsEnabled() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupTargetServerResult) bool { return v.IsEnabled }).(pulumi.BoolOutput)
}

// The resource id of this target server. Values must match the regular expression
func (o LookupTargetServerResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupTargetServerResult) string { return v.Name }).(pulumi.StringOutput)
}

// The port number this target connects to on the given host. Value must be between 1 and 65535, inclusive.
func (o LookupTargetServerResultOutput) Port() pulumi.IntOutput {
	return o.ApplyT(func(v LookupTargetServerResult) int { return v.Port }).(pulumi.IntOutput)
}

// Immutable. The protocol used by this TargetServer.
func (o LookupTargetServerResultOutput) Protocol() pulumi.StringOutput {
	return o.ApplyT(func(v LookupTargetServerResult) string { return v.Protocol }).(pulumi.StringOutput)
}

// Optional. Specifies TLS configuration info for this TargetServer. The JSON name is `sSLInfo` for legacy/backwards compatibility reasons -- Edge originally supported SSL, and the name is still used for TLS configuration.
func (o LookupTargetServerResultOutput) SSLInfo() GoogleCloudApigeeV1TlsInfoResponseOutput {
	return o.ApplyT(func(v LookupTargetServerResult) GoogleCloudApigeeV1TlsInfoResponse { return v.SSLInfo }).(GoogleCloudApigeeV1TlsInfoResponseOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupTargetServerResultOutput{})
}
