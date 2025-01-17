// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha1

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Get information about a job.
func LookupJob(ctx *pulumi.Context, args *LookupJobArgs, opts ...pulumi.InvokeOption) (*LookupJobResult, error) {
	var rv LookupJobResult
	err := ctx.Invoke("google-native:run/v1alpha1:getJob", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupJobArgs struct {
	JobId       string `pulumi:"jobId"`
	NamespaceId string `pulumi:"namespaceId"`
}

type LookupJobResult struct {
	// Optional. APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources +optional
	ApiVersion string `pulumi:"apiVersion"`
	// Optional. Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds +optional
	Kind string `pulumi:"kind"`
	// Optional. Standard object's metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata +optional
	Metadata ObjectMetaResponse `pulumi:"metadata"`
	// Optional. Specification of the desired behavior of a job. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#spec-and-status +optional
	Spec JobSpecResponse `pulumi:"spec"`
	// Optional. Current status of a job. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#spec-and-status +optional
	Status JobStatusResponse `pulumi:"status"`
}

func LookupJobOutput(ctx *pulumi.Context, args LookupJobOutputArgs, opts ...pulumi.InvokeOption) LookupJobResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupJobResult, error) {
			args := v.(LookupJobArgs)
			r, err := LookupJob(ctx, &args, opts...)
			var s LookupJobResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupJobResultOutput)
}

type LookupJobOutputArgs struct {
	JobId       pulumi.StringInput `pulumi:"jobId"`
	NamespaceId pulumi.StringInput `pulumi:"namespaceId"`
}

func (LookupJobOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupJobArgs)(nil)).Elem()
}

type LookupJobResultOutput struct{ *pulumi.OutputState }

func (LookupJobResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupJobResult)(nil)).Elem()
}

func (o LookupJobResultOutput) ToLookupJobResultOutput() LookupJobResultOutput {
	return o
}

func (o LookupJobResultOutput) ToLookupJobResultOutputWithContext(ctx context.Context) LookupJobResultOutput {
	return o
}

// Optional. APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources +optional
func (o LookupJobResultOutput) ApiVersion() pulumi.StringOutput {
	return o.ApplyT(func(v LookupJobResult) string { return v.ApiVersion }).(pulumi.StringOutput)
}

// Optional. Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds +optional
func (o LookupJobResultOutput) Kind() pulumi.StringOutput {
	return o.ApplyT(func(v LookupJobResult) string { return v.Kind }).(pulumi.StringOutput)
}

// Optional. Standard object's metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata +optional
func (o LookupJobResultOutput) Metadata() ObjectMetaResponseOutput {
	return o.ApplyT(func(v LookupJobResult) ObjectMetaResponse { return v.Metadata }).(ObjectMetaResponseOutput)
}

// Optional. Specification of the desired behavior of a job. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#spec-and-status +optional
func (o LookupJobResultOutput) Spec() JobSpecResponseOutput {
	return o.ApplyT(func(v LookupJobResult) JobSpecResponse { return v.Spec }).(JobSpecResponseOutput)
}

// Optional. Current status of a job. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#spec-and-status +optional
func (o LookupJobResultOutput) Status() JobStatusResponseOutput {
	return o.ApplyT(func(v LookupJobResult) JobStatusResponse { return v.Status }).(JobStatusResponseOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupJobResultOutput{})
}
