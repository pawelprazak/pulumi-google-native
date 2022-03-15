// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v2

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Gets a `Policy` on a resource. If no `Policy` is set on the resource, NOT_FOUND is returned. The `etag` value can be used with `UpdatePolicy()` to update a `Policy` during read-modify-write.
func LookupFolderPolicy(ctx *pulumi.Context, args *LookupFolderPolicyArgs, opts ...pulumi.InvokeOption) (*LookupFolderPolicyResult, error) {
	var rv LookupFolderPolicyResult
	err := ctx.Invoke("google-native:orgpolicy/v2:getFolderPolicy", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupFolderPolicyArgs struct {
	FolderId string `pulumi:"folderId"`
	PolicyId string `pulumi:"policyId"`
}

type LookupFolderPolicyResult struct {
	// Deprecated.
	//
	// Deprecated: Deprecated.
	Alternate GoogleCloudOrgpolicyV2AlternatePolicySpecResponse `pulumi:"alternate"`
	// Immutable. The resource name of the Policy. Must be one of the following forms, where constraint_name is the name of the constraint which this Policy configures: * `projects/{project_number}/policies/{constraint_name}` * `folders/{folder_id}/policies/{constraint_name}` * `organizations/{organization_id}/policies/{constraint_name}` For example, "projects/123/policies/compute.disableSerialPortAccess". Note: `projects/{project_id}/policies/{constraint_name}` is also an acceptable name for API requests, but responses will return the name using the equivalent project number.
	Name string `pulumi:"name"`
	// Basic information about the Organization Policy.
	Spec GoogleCloudOrgpolicyV2PolicySpecResponse `pulumi:"spec"`
}

func LookupFolderPolicyOutput(ctx *pulumi.Context, args LookupFolderPolicyOutputArgs, opts ...pulumi.InvokeOption) LookupFolderPolicyResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupFolderPolicyResult, error) {
			args := v.(LookupFolderPolicyArgs)
			r, err := LookupFolderPolicy(ctx, &args, opts...)
			return *r, err
		}).(LookupFolderPolicyResultOutput)
}

type LookupFolderPolicyOutputArgs struct {
	FolderId pulumi.StringInput `pulumi:"folderId"`
	PolicyId pulumi.StringInput `pulumi:"policyId"`
}

func (LookupFolderPolicyOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupFolderPolicyArgs)(nil)).Elem()
}

type LookupFolderPolicyResultOutput struct{ *pulumi.OutputState }

func (LookupFolderPolicyResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupFolderPolicyResult)(nil)).Elem()
}

func (o LookupFolderPolicyResultOutput) ToLookupFolderPolicyResultOutput() LookupFolderPolicyResultOutput {
	return o
}

func (o LookupFolderPolicyResultOutput) ToLookupFolderPolicyResultOutputWithContext(ctx context.Context) LookupFolderPolicyResultOutput {
	return o
}

// Deprecated.
//
// Deprecated: Deprecated.
func (o LookupFolderPolicyResultOutput) Alternate() GoogleCloudOrgpolicyV2AlternatePolicySpecResponseOutput {
	return o.ApplyT(func(v LookupFolderPolicyResult) GoogleCloudOrgpolicyV2AlternatePolicySpecResponse { return v.Alternate }).(GoogleCloudOrgpolicyV2AlternatePolicySpecResponseOutput)
}

// Immutable. The resource name of the Policy. Must be one of the following forms, where constraint_name is the name of the constraint which this Policy configures: * `projects/{project_number}/policies/{constraint_name}` * `folders/{folder_id}/policies/{constraint_name}` * `organizations/{organization_id}/policies/{constraint_name}` For example, "projects/123/policies/compute.disableSerialPortAccess". Note: `projects/{project_id}/policies/{constraint_name}` is also an acceptable name for API requests, but responses will return the name using the equivalent project number.
func (o LookupFolderPolicyResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupFolderPolicyResult) string { return v.Name }).(pulumi.StringOutput)
}

// Basic information about the Organization Policy.
func (o LookupFolderPolicyResultOutput) Spec() GoogleCloudOrgpolicyV2PolicySpecResponseOutput {
	return o.ApplyT(func(v LookupFolderPolicyResult) GoogleCloudOrgpolicyV2PolicySpecResponse { return v.Spec }).(GoogleCloudOrgpolicyV2PolicySpecResponseOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupFolderPolicyResultOutput{})
}