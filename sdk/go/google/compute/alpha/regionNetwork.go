// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package alpha

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Creates a network in the specified project and region using the data included in the request.
type RegionNetwork struct {
	pulumi.CustomResourceState

	// Must be set to create a VPC network. If not set, a legacy network is created. When set to true, the VPC network is created in auto mode. When set to false, the VPC network is created in custom mode. An auto mode VPC network starts with one subnet per region. Each subnet has a predetermined range as described in Auto mode VPC network IP ranges. For custom mode VPC networks, you can add subnets using the subnetworks insert method.
	AutoCreateSubnetworks pulumi.BoolOutput `pulumi:"autoCreateSubnetworks"`
	// Creation timestamp in RFC3339 text format.
	CreationTimestamp pulumi.StringOutput `pulumi:"creationTimestamp"`
	// An optional description of this resource. Provide this field when you create the resource.
	Description pulumi.StringOutput `pulumi:"description"`
	// Enable ULA internal ipv6 on this network. Enabling this feature will assign a /48 from google defined ULA prefix fd20::/20. .
	EnableUlaInternalIpv6 pulumi.BoolOutput `pulumi:"enableUlaInternalIpv6"`
	// URL of the firewall policy the network is associated with.
	FirewallPolicy pulumi.StringOutput `pulumi:"firewallPolicy"`
	// The gateway address for default routing out of the network, selected by GCP.
	GatewayIPv4 pulumi.StringOutput `pulumi:"gatewayIPv4"`
	// When enabling ula internal ipv6, caller optionally can specify the /48 range they want from the google defined ULA prefix fd20::/20. The input must be a valid /48 ULA IPv6 address and must be within the fd20::/20. Operation will fail if the speficied /48 is already in used by another resource. If the field is not speficied, then a /48 range will be randomly allocated from fd20::/20 and returned via this field. .
	InternalIpv6Range pulumi.StringOutput `pulumi:"internalIpv6Range"`
	// Deprecated in favor of subnet mode networks. The range of internal addresses that are legal on this network. This range is a CIDR specification, for example: 192.168.0.0/16. Provided by the client when the network is created.
	//
	// Deprecated: Deprecated in favor of subnet mode networks. The range of internal addresses that are legal on this network. This range is a CIDR specification, for example: 192.168.0.0/16. Provided by the client when the network is created.
	Ipv4Range pulumi.StringOutput `pulumi:"ipv4Range"`
	// Type of the resource. Always compute#network for networks.
	Kind pulumi.StringOutput `pulumi:"kind"`
	// Maximum Transmission Unit in bytes. The minimum value for this field is 1460 and the maximum value is 1500 bytes. If unspecified, defaults to 1460.
	Mtu pulumi.IntOutput `pulumi:"mtu"`
	// Name of the resource. Provided by the client when the resource is created. The name must be 1-63 characters long, and comply with RFC1035. Specifically, the name must be 1-63 characters long and match the regular expression `[a-z]([-a-z0-9]*[a-z0-9])?`. The first character must be a lowercase letter, and all following characters (except for the last character) must be a dash, lowercase letter, or digit. The last character must be a lowercase letter or digit.
	Name pulumi.StringOutput `pulumi:"name"`
	// The network firewall policy enforcement order. Can be either AFTER_CLASSIC_FIREWALL or BEFORE_CLASSIC_FIREWALL. Defaults to AFTER_CLASSIC_FIREWALL if the field is not specified.
	NetworkFirewallPolicyEnforcementOrder pulumi.StringOutput `pulumi:"networkFirewallPolicyEnforcementOrder"`
	// A list of network peerings for the resource.
	Peerings NetworkPeeringResponseArrayOutput `pulumi:"peerings"`
	Project  pulumi.StringOutput               `pulumi:"project"`
	Region   pulumi.StringOutput               `pulumi:"region"`
	// An optional request ID to identify requests. Specify a unique request ID so that if you must retry your request, the server will know to ignore the request if it has already been completed. For example, consider a situation where you make an initial request and the request times out. If you make the request again with the same request ID, the server can check if original operation with the same request ID was received, and if so, will ignore the second request. This prevents clients from accidentally creating duplicate commitments. The request ID must be a valid UUID with the exception that zero UUID is not supported ( 00000000-0000-0000-0000-000000000000).
	RequestId pulumi.StringPtrOutput `pulumi:"requestId"`
	// The network-level routing configuration for this network. Used by Cloud Router to determine what type of network-wide routing behavior to enforce.
	RoutingConfig NetworkRoutingConfigResponseOutput `pulumi:"routingConfig"`
	// Server-defined URL for the resource.
	SelfLink pulumi.StringOutput `pulumi:"selfLink"`
	// Server-defined URL for this resource with the resource id.
	SelfLinkWithId pulumi.StringOutput `pulumi:"selfLinkWithId"`
	// Server-defined fully-qualified URLs for all subnetworks in this VPC network.
	Subnetworks pulumi.StringArrayOutput `pulumi:"subnetworks"`
}

// NewRegionNetwork registers a new resource with the given unique name, arguments, and options.
func NewRegionNetwork(ctx *pulumi.Context,
	name string, args *RegionNetworkArgs, opts ...pulumi.ResourceOption) (*RegionNetwork, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Region == nil {
		return nil, errors.New("invalid value for required argument 'Region'")
	}
	var resource RegionNetwork
	err := ctx.RegisterResource("google-native:compute/alpha:RegionNetwork", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetRegionNetwork gets an existing RegionNetwork resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetRegionNetwork(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *RegionNetworkState, opts ...pulumi.ResourceOption) (*RegionNetwork, error) {
	var resource RegionNetwork
	err := ctx.ReadResource("google-native:compute/alpha:RegionNetwork", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering RegionNetwork resources.
type regionNetworkState struct {
}

type RegionNetworkState struct {
}

func (RegionNetworkState) ElementType() reflect.Type {
	return reflect.TypeOf((*regionNetworkState)(nil)).Elem()
}

type regionNetworkArgs struct {
	// Must be set to create a VPC network. If not set, a legacy network is created. When set to true, the VPC network is created in auto mode. When set to false, the VPC network is created in custom mode. An auto mode VPC network starts with one subnet per region. Each subnet has a predetermined range as described in Auto mode VPC network IP ranges. For custom mode VPC networks, you can add subnets using the subnetworks insert method.
	AutoCreateSubnetworks *bool `pulumi:"autoCreateSubnetworks"`
	// An optional description of this resource. Provide this field when you create the resource.
	Description *string `pulumi:"description"`
	// Enable ULA internal ipv6 on this network. Enabling this feature will assign a /48 from google defined ULA prefix fd20::/20. .
	EnableUlaInternalIpv6 *bool `pulumi:"enableUlaInternalIpv6"`
	// When enabling ula internal ipv6, caller optionally can specify the /48 range they want from the google defined ULA prefix fd20::/20. The input must be a valid /48 ULA IPv6 address and must be within the fd20::/20. Operation will fail if the speficied /48 is already in used by another resource. If the field is not speficied, then a /48 range will be randomly allocated from fd20::/20 and returned via this field. .
	InternalIpv6Range *string `pulumi:"internalIpv6Range"`
	// Deprecated in favor of subnet mode networks. The range of internal addresses that are legal on this network. This range is a CIDR specification, for example: 192.168.0.0/16. Provided by the client when the network is created.
	//
	// Deprecated: Deprecated in favor of subnet mode networks. The range of internal addresses that are legal on this network. This range is a CIDR specification, for example: 192.168.0.0/16. Provided by the client when the network is created.
	Ipv4Range *string `pulumi:"ipv4Range"`
	// Maximum Transmission Unit in bytes. The minimum value for this field is 1460 and the maximum value is 1500 bytes. If unspecified, defaults to 1460.
	Mtu *int `pulumi:"mtu"`
	// Name of the resource. Provided by the client when the resource is created. The name must be 1-63 characters long, and comply with RFC1035. Specifically, the name must be 1-63 characters long and match the regular expression `[a-z]([-a-z0-9]*[a-z0-9])?`. The first character must be a lowercase letter, and all following characters (except for the last character) must be a dash, lowercase letter, or digit. The last character must be a lowercase letter or digit.
	Name *string `pulumi:"name"`
	// The network firewall policy enforcement order. Can be either AFTER_CLASSIC_FIREWALL or BEFORE_CLASSIC_FIREWALL. Defaults to AFTER_CLASSIC_FIREWALL if the field is not specified.
	NetworkFirewallPolicyEnforcementOrder *RegionNetworkNetworkFirewallPolicyEnforcementOrder `pulumi:"networkFirewallPolicyEnforcementOrder"`
	Project                               *string                                             `pulumi:"project"`
	Region                                string                                              `pulumi:"region"`
	// An optional request ID to identify requests. Specify a unique request ID so that if you must retry your request, the server will know to ignore the request if it has already been completed. For example, consider a situation where you make an initial request and the request times out. If you make the request again with the same request ID, the server can check if original operation with the same request ID was received, and if so, will ignore the second request. This prevents clients from accidentally creating duplicate commitments. The request ID must be a valid UUID with the exception that zero UUID is not supported ( 00000000-0000-0000-0000-000000000000).
	RequestId *string `pulumi:"requestId"`
	// The network-level routing configuration for this network. Used by Cloud Router to determine what type of network-wide routing behavior to enforce.
	RoutingConfig *NetworkRoutingConfig `pulumi:"routingConfig"`
}

// The set of arguments for constructing a RegionNetwork resource.
type RegionNetworkArgs struct {
	// Must be set to create a VPC network. If not set, a legacy network is created. When set to true, the VPC network is created in auto mode. When set to false, the VPC network is created in custom mode. An auto mode VPC network starts with one subnet per region. Each subnet has a predetermined range as described in Auto mode VPC network IP ranges. For custom mode VPC networks, you can add subnets using the subnetworks insert method.
	AutoCreateSubnetworks pulumi.BoolPtrInput
	// An optional description of this resource. Provide this field when you create the resource.
	Description pulumi.StringPtrInput
	// Enable ULA internal ipv6 on this network. Enabling this feature will assign a /48 from google defined ULA prefix fd20::/20. .
	EnableUlaInternalIpv6 pulumi.BoolPtrInput
	// When enabling ula internal ipv6, caller optionally can specify the /48 range they want from the google defined ULA prefix fd20::/20. The input must be a valid /48 ULA IPv6 address and must be within the fd20::/20. Operation will fail if the speficied /48 is already in used by another resource. If the field is not speficied, then a /48 range will be randomly allocated from fd20::/20 and returned via this field. .
	InternalIpv6Range pulumi.StringPtrInput
	// Deprecated in favor of subnet mode networks. The range of internal addresses that are legal on this network. This range is a CIDR specification, for example: 192.168.0.0/16. Provided by the client when the network is created.
	//
	// Deprecated: Deprecated in favor of subnet mode networks. The range of internal addresses that are legal on this network. This range is a CIDR specification, for example: 192.168.0.0/16. Provided by the client when the network is created.
	Ipv4Range pulumi.StringPtrInput
	// Maximum Transmission Unit in bytes. The minimum value for this field is 1460 and the maximum value is 1500 bytes. If unspecified, defaults to 1460.
	Mtu pulumi.IntPtrInput
	// Name of the resource. Provided by the client when the resource is created. The name must be 1-63 characters long, and comply with RFC1035. Specifically, the name must be 1-63 characters long and match the regular expression `[a-z]([-a-z0-9]*[a-z0-9])?`. The first character must be a lowercase letter, and all following characters (except for the last character) must be a dash, lowercase letter, or digit. The last character must be a lowercase letter or digit.
	Name pulumi.StringPtrInput
	// The network firewall policy enforcement order. Can be either AFTER_CLASSIC_FIREWALL or BEFORE_CLASSIC_FIREWALL. Defaults to AFTER_CLASSIC_FIREWALL if the field is not specified.
	NetworkFirewallPolicyEnforcementOrder RegionNetworkNetworkFirewallPolicyEnforcementOrderPtrInput
	Project                               pulumi.StringPtrInput
	Region                                pulumi.StringInput
	// An optional request ID to identify requests. Specify a unique request ID so that if you must retry your request, the server will know to ignore the request if it has already been completed. For example, consider a situation where you make an initial request and the request times out. If you make the request again with the same request ID, the server can check if original operation with the same request ID was received, and if so, will ignore the second request. This prevents clients from accidentally creating duplicate commitments. The request ID must be a valid UUID with the exception that zero UUID is not supported ( 00000000-0000-0000-0000-000000000000).
	RequestId pulumi.StringPtrInput
	// The network-level routing configuration for this network. Used by Cloud Router to determine what type of network-wide routing behavior to enforce.
	RoutingConfig NetworkRoutingConfigPtrInput
}

func (RegionNetworkArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*regionNetworkArgs)(nil)).Elem()
}

type RegionNetworkInput interface {
	pulumi.Input

	ToRegionNetworkOutput() RegionNetworkOutput
	ToRegionNetworkOutputWithContext(ctx context.Context) RegionNetworkOutput
}

func (*RegionNetwork) ElementType() reflect.Type {
	return reflect.TypeOf((**RegionNetwork)(nil)).Elem()
}

func (i *RegionNetwork) ToRegionNetworkOutput() RegionNetworkOutput {
	return i.ToRegionNetworkOutputWithContext(context.Background())
}

func (i *RegionNetwork) ToRegionNetworkOutputWithContext(ctx context.Context) RegionNetworkOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RegionNetworkOutput)
}

type RegionNetworkOutput struct{ *pulumi.OutputState }

func (RegionNetworkOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**RegionNetwork)(nil)).Elem()
}

func (o RegionNetworkOutput) ToRegionNetworkOutput() RegionNetworkOutput {
	return o
}

func (o RegionNetworkOutput) ToRegionNetworkOutputWithContext(ctx context.Context) RegionNetworkOutput {
	return o
}

// Must be set to create a VPC network. If not set, a legacy network is created. When set to true, the VPC network is created in auto mode. When set to false, the VPC network is created in custom mode. An auto mode VPC network starts with one subnet per region. Each subnet has a predetermined range as described in Auto mode VPC network IP ranges. For custom mode VPC networks, you can add subnets using the subnetworks insert method.
func (o RegionNetworkOutput) AutoCreateSubnetworks() pulumi.BoolOutput {
	return o.ApplyT(func(v *RegionNetwork) pulumi.BoolOutput { return v.AutoCreateSubnetworks }).(pulumi.BoolOutput)
}

// Creation timestamp in RFC3339 text format.
func (o RegionNetworkOutput) CreationTimestamp() pulumi.StringOutput {
	return o.ApplyT(func(v *RegionNetwork) pulumi.StringOutput { return v.CreationTimestamp }).(pulumi.StringOutput)
}

// An optional description of this resource. Provide this field when you create the resource.
func (o RegionNetworkOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v *RegionNetwork) pulumi.StringOutput { return v.Description }).(pulumi.StringOutput)
}

// Enable ULA internal ipv6 on this network. Enabling this feature will assign a /48 from google defined ULA prefix fd20::/20. .
func (o RegionNetworkOutput) EnableUlaInternalIpv6() pulumi.BoolOutput {
	return o.ApplyT(func(v *RegionNetwork) pulumi.BoolOutput { return v.EnableUlaInternalIpv6 }).(pulumi.BoolOutput)
}

// URL of the firewall policy the network is associated with.
func (o RegionNetworkOutput) FirewallPolicy() pulumi.StringOutput {
	return o.ApplyT(func(v *RegionNetwork) pulumi.StringOutput { return v.FirewallPolicy }).(pulumi.StringOutput)
}

// The gateway address for default routing out of the network, selected by GCP.
func (o RegionNetworkOutput) GatewayIPv4() pulumi.StringOutput {
	return o.ApplyT(func(v *RegionNetwork) pulumi.StringOutput { return v.GatewayIPv4 }).(pulumi.StringOutput)
}

// When enabling ula internal ipv6, caller optionally can specify the /48 range they want from the google defined ULA prefix fd20::/20. The input must be a valid /48 ULA IPv6 address and must be within the fd20::/20. Operation will fail if the speficied /48 is already in used by another resource. If the field is not speficied, then a /48 range will be randomly allocated from fd20::/20 and returned via this field. .
func (o RegionNetworkOutput) InternalIpv6Range() pulumi.StringOutput {
	return o.ApplyT(func(v *RegionNetwork) pulumi.StringOutput { return v.InternalIpv6Range }).(pulumi.StringOutput)
}

// Deprecated in favor of subnet mode networks. The range of internal addresses that are legal on this network. This range is a CIDR specification, for example: 192.168.0.0/16. Provided by the client when the network is created.
//
// Deprecated: Deprecated in favor of subnet mode networks. The range of internal addresses that are legal on this network. This range is a CIDR specification, for example: 192.168.0.0/16. Provided by the client when the network is created.
func (o RegionNetworkOutput) Ipv4Range() pulumi.StringOutput {
	return o.ApplyT(func(v *RegionNetwork) pulumi.StringOutput { return v.Ipv4Range }).(pulumi.StringOutput)
}

// Type of the resource. Always compute#network for networks.
func (o RegionNetworkOutput) Kind() pulumi.StringOutput {
	return o.ApplyT(func(v *RegionNetwork) pulumi.StringOutput { return v.Kind }).(pulumi.StringOutput)
}

// Maximum Transmission Unit in bytes. The minimum value for this field is 1460 and the maximum value is 1500 bytes. If unspecified, defaults to 1460.
func (o RegionNetworkOutput) Mtu() pulumi.IntOutput {
	return o.ApplyT(func(v *RegionNetwork) pulumi.IntOutput { return v.Mtu }).(pulumi.IntOutput)
}

// Name of the resource. Provided by the client when the resource is created. The name must be 1-63 characters long, and comply with RFC1035. Specifically, the name must be 1-63 characters long and match the regular expression `[a-z]([-a-z0-9]*[a-z0-9])?`. The first character must be a lowercase letter, and all following characters (except for the last character) must be a dash, lowercase letter, or digit. The last character must be a lowercase letter or digit.
func (o RegionNetworkOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *RegionNetwork) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// The network firewall policy enforcement order. Can be either AFTER_CLASSIC_FIREWALL or BEFORE_CLASSIC_FIREWALL. Defaults to AFTER_CLASSIC_FIREWALL if the field is not specified.
func (o RegionNetworkOutput) NetworkFirewallPolicyEnforcementOrder() pulumi.StringOutput {
	return o.ApplyT(func(v *RegionNetwork) pulumi.StringOutput { return v.NetworkFirewallPolicyEnforcementOrder }).(pulumi.StringOutput)
}

// A list of network peerings for the resource.
func (o RegionNetworkOutput) Peerings() NetworkPeeringResponseArrayOutput {
	return o.ApplyT(func(v *RegionNetwork) NetworkPeeringResponseArrayOutput { return v.Peerings }).(NetworkPeeringResponseArrayOutput)
}

func (o RegionNetworkOutput) Project() pulumi.StringOutput {
	return o.ApplyT(func(v *RegionNetwork) pulumi.StringOutput { return v.Project }).(pulumi.StringOutput)
}

func (o RegionNetworkOutput) Region() pulumi.StringOutput {
	return o.ApplyT(func(v *RegionNetwork) pulumi.StringOutput { return v.Region }).(pulumi.StringOutput)
}

// An optional request ID to identify requests. Specify a unique request ID so that if you must retry your request, the server will know to ignore the request if it has already been completed. For example, consider a situation where you make an initial request and the request times out. If you make the request again with the same request ID, the server can check if original operation with the same request ID was received, and if so, will ignore the second request. This prevents clients from accidentally creating duplicate commitments. The request ID must be a valid UUID with the exception that zero UUID is not supported ( 00000000-0000-0000-0000-000000000000).
func (o RegionNetworkOutput) RequestId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *RegionNetwork) pulumi.StringPtrOutput { return v.RequestId }).(pulumi.StringPtrOutput)
}

// The network-level routing configuration for this network. Used by Cloud Router to determine what type of network-wide routing behavior to enforce.
func (o RegionNetworkOutput) RoutingConfig() NetworkRoutingConfigResponseOutput {
	return o.ApplyT(func(v *RegionNetwork) NetworkRoutingConfigResponseOutput { return v.RoutingConfig }).(NetworkRoutingConfigResponseOutput)
}

// Server-defined URL for the resource.
func (o RegionNetworkOutput) SelfLink() pulumi.StringOutput {
	return o.ApplyT(func(v *RegionNetwork) pulumi.StringOutput { return v.SelfLink }).(pulumi.StringOutput)
}

// Server-defined URL for this resource with the resource id.
func (o RegionNetworkOutput) SelfLinkWithId() pulumi.StringOutput {
	return o.ApplyT(func(v *RegionNetwork) pulumi.StringOutput { return v.SelfLinkWithId }).(pulumi.StringOutput)
}

// Server-defined fully-qualified URLs for all subnetworks in this VPC network.
func (o RegionNetworkOutput) Subnetworks() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *RegionNetwork) pulumi.StringArrayOutput { return v.Subnetworks }).(pulumi.StringArrayOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*RegionNetworkInput)(nil)).Elem(), &RegionNetwork{})
	pulumi.RegisterOutputType(RegionNetworkOutput{})
}
