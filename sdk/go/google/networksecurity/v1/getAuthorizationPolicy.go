// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Gets details of a single AuthorizationPolicy.
func LookupAuthorizationPolicy(ctx *pulumi.Context, args *LookupAuthorizationPolicyArgs, opts ...pulumi.InvokeOption) (*LookupAuthorizationPolicyResult, error) {
	var rv LookupAuthorizationPolicyResult
	err := ctx.Invoke("google-native:networksecurity/v1:getAuthorizationPolicy", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupAuthorizationPolicyArgs struct {
	AuthorizationPolicyId string  `pulumi:"authorizationPolicyId"`
	Location              string  `pulumi:"location"`
	Project               *string `pulumi:"project"`
}

type LookupAuthorizationPolicyResult struct {
	// The action to take when a rule match is found. Possible values are "ALLOW" or "DENY".
	Action string `pulumi:"action"`
	// The timestamp when the resource was created.
	CreateTime string `pulumi:"createTime"`
	// Optional. Free-text description of the resource.
	Description string `pulumi:"description"`
	// Optional. Set of label tags associated with the AuthorizationPolicy resource.
	Labels map[string]string `pulumi:"labels"`
	// Name of the AuthorizationPolicy resource. It matches pattern `projects/{project}/locations/{location}/authorizationPolicies/`.
	Name string `pulumi:"name"`
	// Optional. List of rules to match. Note that at least one of the rules must match in order for the action specified in the 'action' field to be taken. A rule is a match if there is a matching source and destination. If left blank, the action specified in the `action` field will be applied on every request.
	Rules []RuleResponse `pulumi:"rules"`
	// The timestamp when the resource was updated.
	UpdateTime string `pulumi:"updateTime"`
}

func LookupAuthorizationPolicyOutput(ctx *pulumi.Context, args LookupAuthorizationPolicyOutputArgs, opts ...pulumi.InvokeOption) LookupAuthorizationPolicyResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupAuthorizationPolicyResult, error) {
			args := v.(LookupAuthorizationPolicyArgs)
			r, err := LookupAuthorizationPolicy(ctx, &args, opts...)
			var s LookupAuthorizationPolicyResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupAuthorizationPolicyResultOutput)
}

type LookupAuthorizationPolicyOutputArgs struct {
	AuthorizationPolicyId pulumi.StringInput    `pulumi:"authorizationPolicyId"`
	Location              pulumi.StringInput    `pulumi:"location"`
	Project               pulumi.StringPtrInput `pulumi:"project"`
}

func (LookupAuthorizationPolicyOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupAuthorizationPolicyArgs)(nil)).Elem()
}

type LookupAuthorizationPolicyResultOutput struct{ *pulumi.OutputState }

func (LookupAuthorizationPolicyResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupAuthorizationPolicyResult)(nil)).Elem()
}

func (o LookupAuthorizationPolicyResultOutput) ToLookupAuthorizationPolicyResultOutput() LookupAuthorizationPolicyResultOutput {
	return o
}

func (o LookupAuthorizationPolicyResultOutput) ToLookupAuthorizationPolicyResultOutputWithContext(ctx context.Context) LookupAuthorizationPolicyResultOutput {
	return o
}

// The action to take when a rule match is found. Possible values are "ALLOW" or "DENY".
func (o LookupAuthorizationPolicyResultOutput) Action() pulumi.StringOutput {
	return o.ApplyT(func(v LookupAuthorizationPolicyResult) string { return v.Action }).(pulumi.StringOutput)
}

// The timestamp when the resource was created.
func (o LookupAuthorizationPolicyResultOutput) CreateTime() pulumi.StringOutput {
	return o.ApplyT(func(v LookupAuthorizationPolicyResult) string { return v.CreateTime }).(pulumi.StringOutput)
}

// Optional. Free-text description of the resource.
func (o LookupAuthorizationPolicyResultOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v LookupAuthorizationPolicyResult) string { return v.Description }).(pulumi.StringOutput)
}

// Optional. Set of label tags associated with the AuthorizationPolicy resource.
func (o LookupAuthorizationPolicyResultOutput) Labels() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupAuthorizationPolicyResult) map[string]string { return v.Labels }).(pulumi.StringMapOutput)
}

// Name of the AuthorizationPolicy resource. It matches pattern `projects/{project}/locations/{location}/authorizationPolicies/`.
func (o LookupAuthorizationPolicyResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupAuthorizationPolicyResult) string { return v.Name }).(pulumi.StringOutput)
}

// Optional. List of rules to match. Note that at least one of the rules must match in order for the action specified in the 'action' field to be taken. A rule is a match if there is a matching source and destination. If left blank, the action specified in the `action` field will be applied on every request.
func (o LookupAuthorizationPolicyResultOutput) Rules() RuleResponseArrayOutput {
	return o.ApplyT(func(v LookupAuthorizationPolicyResult) []RuleResponse { return v.Rules }).(RuleResponseArrayOutput)
}

// The timestamp when the resource was updated.
func (o LookupAuthorizationPolicyResultOutput) UpdateTime() pulumi.StringOutput {
	return o.ApplyT(func(v LookupAuthorizationPolicyResult) string { return v.UpdateTime }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupAuthorizationPolicyResultOutput{})
}