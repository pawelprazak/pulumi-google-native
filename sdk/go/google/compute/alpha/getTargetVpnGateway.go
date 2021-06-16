// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package alpha

import (
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Returns the specified target VPN gateway. Gets a list of available target VPN gateways by making a list() request.
func LookupTargetVpnGateway(ctx *pulumi.Context, args *LookupTargetVpnGatewayArgs, opts ...pulumi.InvokeOption) (*LookupTargetVpnGatewayResult, error) {
	var rv LookupTargetVpnGatewayResult
	err := ctx.Invoke("google-native:compute/alpha:getTargetVpnGateway", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupTargetVpnGatewayArgs struct {
	Project          string `pulumi:"project"`
	Region           string `pulumi:"region"`
	TargetVpnGateway string `pulumi:"targetVpnGateway"`
}

type LookupTargetVpnGatewayResult struct {
	// [Output Only] Creation timestamp in RFC3339 text format.
	CreationTimestamp string `pulumi:"creationTimestamp"`
	// An optional description of this resource. Provide this property when you create the resource.
	Description string `pulumi:"description"`
	// [Output Only] A list of URLs to the ForwardingRule resources. ForwardingRules are created using compute.forwardingRules.insert and associated with a VPN gateway.
	ForwardingRules []string `pulumi:"forwardingRules"`
	// [Output Only] Type of resource. Always compute#targetVpnGateway for target VPN gateways.
	Kind string `pulumi:"kind"`
	// A fingerprint for the labels being applied to this TargetVpnGateway, which is essentially a hash of the labels set used for optimistic locking. The fingerprint is initially generated by Compute Engine and changes after every request to modify or update labels. You must always provide an up-to-date fingerprint hash in order to update or change labels, otherwise the request will fail with error 412 conditionNotMet.
	//
	// To see the latest fingerprint, make a get() request to retrieve a TargetVpnGateway.
	LabelFingerprint string `pulumi:"labelFingerprint"`
	// Labels for this resource. These can only be added or modified by the setLabels method. Each label key/value pair must comply with RFC1035. Label values may be empty.
	Labels map[string]string `pulumi:"labels"`
	// Name of the resource. Provided by the client when the resource is created. The name must be 1-63 characters long, and comply with RFC1035. Specifically, the name must be 1-63 characters long and match the regular expression `[a-z]([-a-z0-9]*[a-z0-9])?` which means the first character must be a lowercase letter, and all following characters must be a dash, lowercase letter, or digit, except the last character, which cannot be a dash.
	Name string `pulumi:"name"`
	// URL of the network to which this VPN gateway is attached. Provided by the client when the VPN gateway is created.
	Network string `pulumi:"network"`
	// [Output Only] URL of the region where the target VPN gateway resides. You must specify this field as part of the HTTP request URL. It is not settable as a field in the request body.
	Region string `pulumi:"region"`
	// [Output Only] Server-defined URL for the resource.
	SelfLink string `pulumi:"selfLink"`
	// [Output Only] The status of the VPN gateway, which can be one of the following: CREATING, READY, FAILED, or DELETING.
	Status string `pulumi:"status"`
	// [Output Only] A list of URLs to VpnTunnel resources. VpnTunnels are created using the compute.vpntunnels.insert method and associated with a VPN gateway.
	Tunnels []string `pulumi:"tunnels"`
}