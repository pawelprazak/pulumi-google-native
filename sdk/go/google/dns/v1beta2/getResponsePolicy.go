// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1beta2

import (
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Fetches the representation of an existing Response Policy.
func LookupResponsePolicy(ctx *pulumi.Context, args *LookupResponsePolicyArgs, opts ...pulumi.InvokeOption) (*LookupResponsePolicyResult, error) {
	var rv LookupResponsePolicyResult
	err := ctx.Invoke("google-native:dns/v1beta2:getResponsePolicy", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupResponsePolicyArgs struct {
	ClientOperationId *string `pulumi:"clientOperationId"`
	Project           string  `pulumi:"project"`
	ResponsePolicy    string  `pulumi:"responsePolicy"`
}

type LookupResponsePolicyResult struct {
	// User-provided description for this Response Policy.
	Description string `pulumi:"description"`
	// The list of Google Kubernetes Engine clusters to which this response policy is applied.
	GkeClusters []ResponsePolicyGKEClusterResponse `pulumi:"gkeClusters"`
	Kind        string                             `pulumi:"kind"`
	// List of network names specifying networks to which this policy is applied.
	Networks []ResponsePolicyNetworkResponse `pulumi:"networks"`
	// User assigned name for this Response Policy.
	ResponsePolicyName string `pulumi:"responsePolicyName"`
}