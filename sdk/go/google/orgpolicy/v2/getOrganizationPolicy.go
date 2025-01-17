// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v2

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Gets a `Policy` on a resource. If no `Policy` is set on the resource, NOT_FOUND is returned. The `etag` value can be used with `UpdatePolicy()` to update a `Policy` during read-modify-write.
func LookupOrganizationPolicy(ctx *pulumi.Context, args *LookupOrganizationPolicyArgs, opts ...pulumi.InvokeOption) (*LookupOrganizationPolicyResult, error) {
	var rv LookupOrganizationPolicyResult
	err := ctx.Invoke("google-native:orgpolicy/v2:getOrganizationPolicy", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupOrganizationPolicyArgs struct {
	OrganizationId string `pulumi:"organizationId"`
	PolicyId       string `pulumi:"policyId"`
}

type LookupOrganizationPolicyResult struct {
	// Deprecated.
	//
	// Deprecated: Deprecated.
	Alternate GoogleCloudOrgpolicyV2AlternatePolicySpecResponse `pulumi:"alternate"`
	// Immutable. The resource name of the Policy. Must be one of the following forms, where constraint_name is the name of the constraint which this Policy configures: * `projects/{project_number}/policies/{constraint_name}` * `folders/{folder_id}/policies/{constraint_name}` * `organizations/{organization_id}/policies/{constraint_name}` For example, "projects/123/policies/compute.disableSerialPortAccess". Note: `projects/{project_id}/policies/{constraint_name}` is also an acceptable name for API requests, but responses will return the name using the equivalent project number.
	Name string `pulumi:"name"`
	// Basic information about the Organization Policy.
	Spec GoogleCloudOrgpolicyV2PolicySpecResponse `pulumi:"spec"`
}

func LookupOrganizationPolicyOutput(ctx *pulumi.Context, args LookupOrganizationPolicyOutputArgs, opts ...pulumi.InvokeOption) LookupOrganizationPolicyResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupOrganizationPolicyResult, error) {
			args := v.(LookupOrganizationPolicyArgs)
			r, err := LookupOrganizationPolicy(ctx, &args, opts...)
			var s LookupOrganizationPolicyResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupOrganizationPolicyResultOutput)
}

type LookupOrganizationPolicyOutputArgs struct {
	OrganizationId pulumi.StringInput `pulumi:"organizationId"`
	PolicyId       pulumi.StringInput `pulumi:"policyId"`
}

func (LookupOrganizationPolicyOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupOrganizationPolicyArgs)(nil)).Elem()
}

type LookupOrganizationPolicyResultOutput struct{ *pulumi.OutputState }

func (LookupOrganizationPolicyResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupOrganizationPolicyResult)(nil)).Elem()
}

func (o LookupOrganizationPolicyResultOutput) ToLookupOrganizationPolicyResultOutput() LookupOrganizationPolicyResultOutput {
	return o
}

func (o LookupOrganizationPolicyResultOutput) ToLookupOrganizationPolicyResultOutputWithContext(ctx context.Context) LookupOrganizationPolicyResultOutput {
	return o
}

// Deprecated.
//
// Deprecated: Deprecated.
func (o LookupOrganizationPolicyResultOutput) Alternate() GoogleCloudOrgpolicyV2AlternatePolicySpecResponseOutput {
	return o.ApplyT(func(v LookupOrganizationPolicyResult) GoogleCloudOrgpolicyV2AlternatePolicySpecResponse {
		return v.Alternate
	}).(GoogleCloudOrgpolicyV2AlternatePolicySpecResponseOutput)
}

// Immutable. The resource name of the Policy. Must be one of the following forms, where constraint_name is the name of the constraint which this Policy configures: * `projects/{project_number}/policies/{constraint_name}` * `folders/{folder_id}/policies/{constraint_name}` * `organizations/{organization_id}/policies/{constraint_name}` For example, "projects/123/policies/compute.disableSerialPortAccess". Note: `projects/{project_id}/policies/{constraint_name}` is also an acceptable name for API requests, but responses will return the name using the equivalent project number.
func (o LookupOrganizationPolicyResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupOrganizationPolicyResult) string { return v.Name }).(pulumi.StringOutput)
}

// Basic information about the Organization Policy.
func (o LookupOrganizationPolicyResultOutput) Spec() GoogleCloudOrgpolicyV2PolicySpecResponseOutput {
	return o.ApplyT(func(v LookupOrganizationPolicyResult) GoogleCloudOrgpolicyV2PolicySpecResponse { return v.Spec }).(GoogleCloudOrgpolicyV2PolicySpecResponseOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupOrganizationPolicyResultOutput{})
}
