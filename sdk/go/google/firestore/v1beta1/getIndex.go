// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1beta1

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Gets an index.
func LookupIndex(ctx *pulumi.Context, args *LookupIndexArgs, opts ...pulumi.InvokeOption) (*LookupIndexResult, error) {
	var rv LookupIndexResult
	err := ctx.Invoke("google-native:firestore/v1beta1:getIndex", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupIndexArgs struct {
	DatabaseId string  `pulumi:"databaseId"`
	IndexId    string  `pulumi:"indexId"`
	Project    *string `pulumi:"project"`
}

type LookupIndexResult struct {
	// The collection ID to which this index applies. Required.
	CollectionId string `pulumi:"collectionId"`
	// The fields to index.
	Fields []GoogleFirestoreAdminV1beta1IndexFieldResponse `pulumi:"fields"`
	// The resource name of the index. Output only.
	Name string `pulumi:"name"`
	// The state of the index. Output only.
	State string `pulumi:"state"`
}

func LookupIndexOutput(ctx *pulumi.Context, args LookupIndexOutputArgs, opts ...pulumi.InvokeOption) LookupIndexResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupIndexResult, error) {
			args := v.(LookupIndexArgs)
			r, err := LookupIndex(ctx, &args, opts...)
			var s LookupIndexResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupIndexResultOutput)
}

type LookupIndexOutputArgs struct {
	DatabaseId pulumi.StringInput    `pulumi:"databaseId"`
	IndexId    pulumi.StringInput    `pulumi:"indexId"`
	Project    pulumi.StringPtrInput `pulumi:"project"`
}

func (LookupIndexOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupIndexArgs)(nil)).Elem()
}

type LookupIndexResultOutput struct{ *pulumi.OutputState }

func (LookupIndexResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupIndexResult)(nil)).Elem()
}

func (o LookupIndexResultOutput) ToLookupIndexResultOutput() LookupIndexResultOutput {
	return o
}

func (o LookupIndexResultOutput) ToLookupIndexResultOutputWithContext(ctx context.Context) LookupIndexResultOutput {
	return o
}

// The collection ID to which this index applies. Required.
func (o LookupIndexResultOutput) CollectionId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupIndexResult) string { return v.CollectionId }).(pulumi.StringOutput)
}

// The fields to index.
func (o LookupIndexResultOutput) Fields() GoogleFirestoreAdminV1beta1IndexFieldResponseArrayOutput {
	return o.ApplyT(func(v LookupIndexResult) []GoogleFirestoreAdminV1beta1IndexFieldResponse { return v.Fields }).(GoogleFirestoreAdminV1beta1IndexFieldResponseArrayOutput)
}

// The resource name of the index. Output only.
func (o LookupIndexResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupIndexResult) string { return v.Name }).(pulumi.StringOutput)
}

// The state of the index. Output only.
func (o LookupIndexResultOutput) State() pulumi.StringOutput {
	return o.ApplyT(func(v LookupIndexResult) string { return v.State }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupIndexResultOutput{})
}