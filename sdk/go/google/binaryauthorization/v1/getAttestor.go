// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v1

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Gets an attestor. Returns NOT_FOUND if the attestor does not exist.
func LookupAttestor(ctx *pulumi.Context, args *LookupAttestorArgs, opts ...pulumi.InvokeOption) (*LookupAttestorResult, error) {
	var rv LookupAttestorResult
	err := ctx.Invoke("google-native:binaryauthorization/v1:getAttestor", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupAttestorArgs struct {
	AttestorId string  `pulumi:"attestorId"`
	Project    *string `pulumi:"project"`
}

type LookupAttestorResult struct {
	// Optional. A descriptive comment. This field may be updated. The field may be displayed in chooser dialogs.
	Description string `pulumi:"description"`
	// Optional. A checksum, returned by the server, that can be sent on update requests to ensure the attestor has an up-to-date value before attempting to update it. See https://google.aip.dev/154.
	Etag string `pulumi:"etag"`
	// The resource name, in the format: `projects/*/attestors/*`. This field may not be updated.
	Name string `pulumi:"name"`
	// Time when the attestor was last updated.
	UpdateTime string `pulumi:"updateTime"`
	// This specifies how an attestation will be read, and how it will be used during policy enforcement.
	UserOwnedGrafeasNote UserOwnedGrafeasNoteResponse `pulumi:"userOwnedGrafeasNote"`
}

func LookupAttestorOutput(ctx *pulumi.Context, args LookupAttestorOutputArgs, opts ...pulumi.InvokeOption) LookupAttestorResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupAttestorResult, error) {
			args := v.(LookupAttestorArgs)
			r, err := LookupAttestor(ctx, &args, opts...)
			var s LookupAttestorResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupAttestorResultOutput)
}

type LookupAttestorOutputArgs struct {
	AttestorId pulumi.StringInput    `pulumi:"attestorId"`
	Project    pulumi.StringPtrInput `pulumi:"project"`
}

func (LookupAttestorOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupAttestorArgs)(nil)).Elem()
}

type LookupAttestorResultOutput struct{ *pulumi.OutputState }

func (LookupAttestorResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupAttestorResult)(nil)).Elem()
}

func (o LookupAttestorResultOutput) ToLookupAttestorResultOutput() LookupAttestorResultOutput {
	return o
}

func (o LookupAttestorResultOutput) ToLookupAttestorResultOutputWithContext(ctx context.Context) LookupAttestorResultOutput {
	return o
}

// Optional. A descriptive comment. This field may be updated. The field may be displayed in chooser dialogs.
func (o LookupAttestorResultOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v LookupAttestorResult) string { return v.Description }).(pulumi.StringOutput)
}

// Optional. A checksum, returned by the server, that can be sent on update requests to ensure the attestor has an up-to-date value before attempting to update it. See https://google.aip.dev/154.
func (o LookupAttestorResultOutput) Etag() pulumi.StringOutput {
	return o.ApplyT(func(v LookupAttestorResult) string { return v.Etag }).(pulumi.StringOutput)
}

// The resource name, in the format: `projects/*/attestors/*`. This field may not be updated.
func (o LookupAttestorResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupAttestorResult) string { return v.Name }).(pulumi.StringOutput)
}

// Time when the attestor was last updated.
func (o LookupAttestorResultOutput) UpdateTime() pulumi.StringOutput {
	return o.ApplyT(func(v LookupAttestorResult) string { return v.UpdateTime }).(pulumi.StringOutput)
}

// This specifies how an attestation will be read, and how it will be used during policy enforcement.
func (o LookupAttestorResultOutput) UserOwnedGrafeasNote() UserOwnedGrafeasNoteResponseOutput {
	return o.ApplyT(func(v LookupAttestorResult) UserOwnedGrafeasNoteResponse { return v.UserOwnedGrafeasNote }).(UserOwnedGrafeasNoteResponseOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupAttestorResultOutput{})
}
