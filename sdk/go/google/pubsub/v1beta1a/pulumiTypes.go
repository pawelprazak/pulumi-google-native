// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1beta1a

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Configuration for a push delivery endpoint.
type PushConfig struct {
	// A URL locating the endpoint to which messages should be pushed. For example, a Webhook endpoint might use "https://example.com/push".
	PushEndpoint *string `pulumi:"pushEndpoint"`
}

// PushConfigInput is an input type that accepts PushConfigArgs and PushConfigOutput values.
// You can construct a concrete instance of `PushConfigInput` via:
//
//          PushConfigArgs{...}
type PushConfigInput interface {
	pulumi.Input

	ToPushConfigOutput() PushConfigOutput
	ToPushConfigOutputWithContext(context.Context) PushConfigOutput
}

// Configuration for a push delivery endpoint.
type PushConfigArgs struct {
	// A URL locating the endpoint to which messages should be pushed. For example, a Webhook endpoint might use "https://example.com/push".
	PushEndpoint pulumi.StringPtrInput `pulumi:"pushEndpoint"`
}

func (PushConfigArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*PushConfig)(nil)).Elem()
}

func (i PushConfigArgs) ToPushConfigOutput() PushConfigOutput {
	return i.ToPushConfigOutputWithContext(context.Background())
}

func (i PushConfigArgs) ToPushConfigOutputWithContext(ctx context.Context) PushConfigOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PushConfigOutput)
}

func (i PushConfigArgs) ToPushConfigPtrOutput() PushConfigPtrOutput {
	return i.ToPushConfigPtrOutputWithContext(context.Background())
}

func (i PushConfigArgs) ToPushConfigPtrOutputWithContext(ctx context.Context) PushConfigPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PushConfigOutput).ToPushConfigPtrOutputWithContext(ctx)
}

// PushConfigPtrInput is an input type that accepts PushConfigArgs, PushConfigPtr and PushConfigPtrOutput values.
// You can construct a concrete instance of `PushConfigPtrInput` via:
//
//          PushConfigArgs{...}
//
//  or:
//
//          nil
type PushConfigPtrInput interface {
	pulumi.Input

	ToPushConfigPtrOutput() PushConfigPtrOutput
	ToPushConfigPtrOutputWithContext(context.Context) PushConfigPtrOutput
}

type pushConfigPtrType PushConfigArgs

func PushConfigPtr(v *PushConfigArgs) PushConfigPtrInput {
	return (*pushConfigPtrType)(v)
}

func (*pushConfigPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**PushConfig)(nil)).Elem()
}

func (i *pushConfigPtrType) ToPushConfigPtrOutput() PushConfigPtrOutput {
	return i.ToPushConfigPtrOutputWithContext(context.Background())
}

func (i *pushConfigPtrType) ToPushConfigPtrOutputWithContext(ctx context.Context) PushConfigPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PushConfigPtrOutput)
}

// Configuration for a push delivery endpoint.
type PushConfigOutput struct{ *pulumi.OutputState }

func (PushConfigOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*PushConfig)(nil)).Elem()
}

func (o PushConfigOutput) ToPushConfigOutput() PushConfigOutput {
	return o
}

func (o PushConfigOutput) ToPushConfigOutputWithContext(ctx context.Context) PushConfigOutput {
	return o
}

func (o PushConfigOutput) ToPushConfigPtrOutput() PushConfigPtrOutput {
	return o.ToPushConfigPtrOutputWithContext(context.Background())
}

func (o PushConfigOutput) ToPushConfigPtrOutputWithContext(ctx context.Context) PushConfigPtrOutput {
	return o.ApplyT(func(v PushConfig) *PushConfig {
		return &v
	}).(PushConfigPtrOutput)
}

// A URL locating the endpoint to which messages should be pushed. For example, a Webhook endpoint might use "https://example.com/push".
func (o PushConfigOutput) PushEndpoint() pulumi.StringPtrOutput {
	return o.ApplyT(func(v PushConfig) *string { return v.PushEndpoint }).(pulumi.StringPtrOutput)
}

type PushConfigPtrOutput struct{ *pulumi.OutputState }

func (PushConfigPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**PushConfig)(nil)).Elem()
}

func (o PushConfigPtrOutput) ToPushConfigPtrOutput() PushConfigPtrOutput {
	return o
}

func (o PushConfigPtrOutput) ToPushConfigPtrOutputWithContext(ctx context.Context) PushConfigPtrOutput {
	return o
}

func (o PushConfigPtrOutput) Elem() PushConfigOutput {
	return o.ApplyT(func(v *PushConfig) PushConfig { return *v }).(PushConfigOutput)
}

// A URL locating the endpoint to which messages should be pushed. For example, a Webhook endpoint might use "https://example.com/push".
func (o PushConfigPtrOutput) PushEndpoint() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *PushConfig) *string {
		if v == nil {
			return nil
		}
		return v.PushEndpoint
	}).(pulumi.StringPtrOutput)
}

// Configuration for a push delivery endpoint.
type PushConfigResponse struct {
	// A URL locating the endpoint to which messages should be pushed. For example, a Webhook endpoint might use "https://example.com/push".
	PushEndpoint string `pulumi:"pushEndpoint"`
}

// PushConfigResponseInput is an input type that accepts PushConfigResponseArgs and PushConfigResponseOutput values.
// You can construct a concrete instance of `PushConfigResponseInput` via:
//
//          PushConfigResponseArgs{...}
type PushConfigResponseInput interface {
	pulumi.Input

	ToPushConfigResponseOutput() PushConfigResponseOutput
	ToPushConfigResponseOutputWithContext(context.Context) PushConfigResponseOutput
}

// Configuration for a push delivery endpoint.
type PushConfigResponseArgs struct {
	// A URL locating the endpoint to which messages should be pushed. For example, a Webhook endpoint might use "https://example.com/push".
	PushEndpoint pulumi.StringInput `pulumi:"pushEndpoint"`
}

func (PushConfigResponseArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*PushConfigResponse)(nil)).Elem()
}

func (i PushConfigResponseArgs) ToPushConfigResponseOutput() PushConfigResponseOutput {
	return i.ToPushConfigResponseOutputWithContext(context.Background())
}

func (i PushConfigResponseArgs) ToPushConfigResponseOutputWithContext(ctx context.Context) PushConfigResponseOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PushConfigResponseOutput)
}

func (i PushConfigResponseArgs) ToPushConfigResponsePtrOutput() PushConfigResponsePtrOutput {
	return i.ToPushConfigResponsePtrOutputWithContext(context.Background())
}

func (i PushConfigResponseArgs) ToPushConfigResponsePtrOutputWithContext(ctx context.Context) PushConfigResponsePtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PushConfigResponseOutput).ToPushConfigResponsePtrOutputWithContext(ctx)
}

// PushConfigResponsePtrInput is an input type that accepts PushConfigResponseArgs, PushConfigResponsePtr and PushConfigResponsePtrOutput values.
// You can construct a concrete instance of `PushConfigResponsePtrInput` via:
//
//          PushConfigResponseArgs{...}
//
//  or:
//
//          nil
type PushConfigResponsePtrInput interface {
	pulumi.Input

	ToPushConfigResponsePtrOutput() PushConfigResponsePtrOutput
	ToPushConfigResponsePtrOutputWithContext(context.Context) PushConfigResponsePtrOutput
}

type pushConfigResponsePtrType PushConfigResponseArgs

func PushConfigResponsePtr(v *PushConfigResponseArgs) PushConfigResponsePtrInput {
	return (*pushConfigResponsePtrType)(v)
}

func (*pushConfigResponsePtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**PushConfigResponse)(nil)).Elem()
}

func (i *pushConfigResponsePtrType) ToPushConfigResponsePtrOutput() PushConfigResponsePtrOutput {
	return i.ToPushConfigResponsePtrOutputWithContext(context.Background())
}

func (i *pushConfigResponsePtrType) ToPushConfigResponsePtrOutputWithContext(ctx context.Context) PushConfigResponsePtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PushConfigResponsePtrOutput)
}

// Configuration for a push delivery endpoint.
type PushConfigResponseOutput struct{ *pulumi.OutputState }

func (PushConfigResponseOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*PushConfigResponse)(nil)).Elem()
}

func (o PushConfigResponseOutput) ToPushConfigResponseOutput() PushConfigResponseOutput {
	return o
}

func (o PushConfigResponseOutput) ToPushConfigResponseOutputWithContext(ctx context.Context) PushConfigResponseOutput {
	return o
}

func (o PushConfigResponseOutput) ToPushConfigResponsePtrOutput() PushConfigResponsePtrOutput {
	return o.ToPushConfigResponsePtrOutputWithContext(context.Background())
}

func (o PushConfigResponseOutput) ToPushConfigResponsePtrOutputWithContext(ctx context.Context) PushConfigResponsePtrOutput {
	return o.ApplyT(func(v PushConfigResponse) *PushConfigResponse {
		return &v
	}).(PushConfigResponsePtrOutput)
}

// A URL locating the endpoint to which messages should be pushed. For example, a Webhook endpoint might use "https://example.com/push".
func (o PushConfigResponseOutput) PushEndpoint() pulumi.StringOutput {
	return o.ApplyT(func(v PushConfigResponse) string { return v.PushEndpoint }).(pulumi.StringOutput)
}

type PushConfigResponsePtrOutput struct{ *pulumi.OutputState }

func (PushConfigResponsePtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**PushConfigResponse)(nil)).Elem()
}

func (o PushConfigResponsePtrOutput) ToPushConfigResponsePtrOutput() PushConfigResponsePtrOutput {
	return o
}

func (o PushConfigResponsePtrOutput) ToPushConfigResponsePtrOutputWithContext(ctx context.Context) PushConfigResponsePtrOutput {
	return o
}

func (o PushConfigResponsePtrOutput) Elem() PushConfigResponseOutput {
	return o.ApplyT(func(v *PushConfigResponse) PushConfigResponse { return *v }).(PushConfigResponseOutput)
}

// A URL locating the endpoint to which messages should be pushed. For example, a Webhook endpoint might use "https://example.com/push".
func (o PushConfigResponsePtrOutput) PushEndpoint() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *PushConfigResponse) *string {
		if v == nil {
			return nil
		}
		return &v.PushEndpoint
	}).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(PushConfigOutput{})
	pulumi.RegisterOutputType(PushConfigPtrOutput{})
	pulumi.RegisterOutputType(PushConfigResponseOutput{})
	pulumi.RegisterOutputType(PushConfigResponsePtrOutput{})
}