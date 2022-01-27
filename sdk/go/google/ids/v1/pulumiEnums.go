// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// The log type that this config enables.
type AuditLogConfigLogType string

const (
	// Default case. Should never be this.
	AuditLogConfigLogTypeLogTypeUnspecified = AuditLogConfigLogType("LOG_TYPE_UNSPECIFIED")
	// Admin reads. Example: CloudIAM getIamPolicy
	AuditLogConfigLogTypeAdminRead = AuditLogConfigLogType("ADMIN_READ")
	// Data writes. Example: CloudSQL Users create
	AuditLogConfigLogTypeDataWrite = AuditLogConfigLogType("DATA_WRITE")
	// Data reads. Example: CloudSQL Users list
	AuditLogConfigLogTypeDataRead = AuditLogConfigLogType("DATA_READ")
)

func (AuditLogConfigLogType) ElementType() reflect.Type {
	return reflect.TypeOf((*AuditLogConfigLogType)(nil)).Elem()
}

func (e AuditLogConfigLogType) ToAuditLogConfigLogTypeOutput() AuditLogConfigLogTypeOutput {
	return pulumi.ToOutput(e).(AuditLogConfigLogTypeOutput)
}

func (e AuditLogConfigLogType) ToAuditLogConfigLogTypeOutputWithContext(ctx context.Context) AuditLogConfigLogTypeOutput {
	return pulumi.ToOutputWithContext(ctx, e).(AuditLogConfigLogTypeOutput)
}

func (e AuditLogConfigLogType) ToAuditLogConfigLogTypePtrOutput() AuditLogConfigLogTypePtrOutput {
	return e.ToAuditLogConfigLogTypePtrOutputWithContext(context.Background())
}

func (e AuditLogConfigLogType) ToAuditLogConfigLogTypePtrOutputWithContext(ctx context.Context) AuditLogConfigLogTypePtrOutput {
	return AuditLogConfigLogType(e).ToAuditLogConfigLogTypeOutputWithContext(ctx).ToAuditLogConfigLogTypePtrOutputWithContext(ctx)
}

func (e AuditLogConfigLogType) ToStringOutput() pulumi.StringOutput {
	return pulumi.ToOutput(pulumi.String(e)).(pulumi.StringOutput)
}

func (e AuditLogConfigLogType) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return pulumi.ToOutputWithContext(ctx, pulumi.String(e)).(pulumi.StringOutput)
}

func (e AuditLogConfigLogType) ToStringPtrOutput() pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringPtrOutputWithContext(context.Background())
}

func (e AuditLogConfigLogType) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringOutputWithContext(ctx).ToStringPtrOutputWithContext(ctx)
}

type AuditLogConfigLogTypeOutput struct{ *pulumi.OutputState }

func (AuditLogConfigLogTypeOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*AuditLogConfigLogType)(nil)).Elem()
}

func (o AuditLogConfigLogTypeOutput) ToAuditLogConfigLogTypeOutput() AuditLogConfigLogTypeOutput {
	return o
}

func (o AuditLogConfigLogTypeOutput) ToAuditLogConfigLogTypeOutputWithContext(ctx context.Context) AuditLogConfigLogTypeOutput {
	return o
}

func (o AuditLogConfigLogTypeOutput) ToAuditLogConfigLogTypePtrOutput() AuditLogConfigLogTypePtrOutput {
	return o.ToAuditLogConfigLogTypePtrOutputWithContext(context.Background())
}

func (o AuditLogConfigLogTypeOutput) ToAuditLogConfigLogTypePtrOutputWithContext(ctx context.Context) AuditLogConfigLogTypePtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v AuditLogConfigLogType) *AuditLogConfigLogType {
		return &v
	}).(AuditLogConfigLogTypePtrOutput)
}

func (o AuditLogConfigLogTypeOutput) ToStringOutput() pulumi.StringOutput {
	return o.ToStringOutputWithContext(context.Background())
}

func (o AuditLogConfigLogTypeOutput) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e AuditLogConfigLogType) string {
		return string(e)
	}).(pulumi.StringOutput)
}

func (o AuditLogConfigLogTypeOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o AuditLogConfigLogTypeOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e AuditLogConfigLogType) *string {
		v := string(e)
		return &v
	}).(pulumi.StringPtrOutput)
}

type AuditLogConfigLogTypePtrOutput struct{ *pulumi.OutputState }

func (AuditLogConfigLogTypePtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**AuditLogConfigLogType)(nil)).Elem()
}

func (o AuditLogConfigLogTypePtrOutput) ToAuditLogConfigLogTypePtrOutput() AuditLogConfigLogTypePtrOutput {
	return o
}

func (o AuditLogConfigLogTypePtrOutput) ToAuditLogConfigLogTypePtrOutputWithContext(ctx context.Context) AuditLogConfigLogTypePtrOutput {
	return o
}

func (o AuditLogConfigLogTypePtrOutput) Elem() AuditLogConfigLogTypeOutput {
	return o.ApplyT(func(v *AuditLogConfigLogType) AuditLogConfigLogType {
		if v != nil {
			return *v
		}
		var ret AuditLogConfigLogType
		return ret
	}).(AuditLogConfigLogTypeOutput)
}

func (o AuditLogConfigLogTypePtrOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o AuditLogConfigLogTypePtrOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e *AuditLogConfigLogType) *string {
		if e == nil {
			return nil
		}
		v := string(*e)
		return &v
	}).(pulumi.StringPtrOutput)
}

// AuditLogConfigLogTypeInput is an input type that accepts AuditLogConfigLogTypeArgs and AuditLogConfigLogTypeOutput values.
// You can construct a concrete instance of `AuditLogConfigLogTypeInput` via:
//
//          AuditLogConfigLogTypeArgs{...}
type AuditLogConfigLogTypeInput interface {
	pulumi.Input

	ToAuditLogConfigLogTypeOutput() AuditLogConfigLogTypeOutput
	ToAuditLogConfigLogTypeOutputWithContext(context.Context) AuditLogConfigLogTypeOutput
}

var auditLogConfigLogTypePtrType = reflect.TypeOf((**AuditLogConfigLogType)(nil)).Elem()

type AuditLogConfigLogTypePtrInput interface {
	pulumi.Input

	ToAuditLogConfigLogTypePtrOutput() AuditLogConfigLogTypePtrOutput
	ToAuditLogConfigLogTypePtrOutputWithContext(context.Context) AuditLogConfigLogTypePtrOutput
}

type auditLogConfigLogTypePtr string

func AuditLogConfigLogTypePtr(v string) AuditLogConfigLogTypePtrInput {
	return (*auditLogConfigLogTypePtr)(&v)
}

func (*auditLogConfigLogTypePtr) ElementType() reflect.Type {
	return auditLogConfigLogTypePtrType
}

func (in *auditLogConfigLogTypePtr) ToAuditLogConfigLogTypePtrOutput() AuditLogConfigLogTypePtrOutput {
	return pulumi.ToOutput(in).(AuditLogConfigLogTypePtrOutput)
}

func (in *auditLogConfigLogTypePtr) ToAuditLogConfigLogTypePtrOutputWithContext(ctx context.Context) AuditLogConfigLogTypePtrOutput {
	return pulumi.ToOutputWithContext(ctx, in).(AuditLogConfigLogTypePtrOutput)
}

// Required. Lowest threat severity that this endpoint will alert on.
type EndpointSeverity string

const (
	// Not set.
	EndpointSeveritySeverityUnspecified = EndpointSeverity("SEVERITY_UNSPECIFIED")
	// Informational alerts.
	EndpointSeverityInformational = EndpointSeverity("INFORMATIONAL")
	// Low severity alerts.
	EndpointSeverityLow = EndpointSeverity("LOW")
	// Medium severity alerts.
	EndpointSeverityMedium = EndpointSeverity("MEDIUM")
	// High severity alerts.
	EndpointSeverityHigh = EndpointSeverity("HIGH")
	// Critical severity alerts.
	EndpointSeverityCritical = EndpointSeverity("CRITICAL")
)

func (EndpointSeverity) ElementType() reflect.Type {
	return reflect.TypeOf((*EndpointSeverity)(nil)).Elem()
}

func (e EndpointSeverity) ToEndpointSeverityOutput() EndpointSeverityOutput {
	return pulumi.ToOutput(e).(EndpointSeverityOutput)
}

func (e EndpointSeverity) ToEndpointSeverityOutputWithContext(ctx context.Context) EndpointSeverityOutput {
	return pulumi.ToOutputWithContext(ctx, e).(EndpointSeverityOutput)
}

func (e EndpointSeverity) ToEndpointSeverityPtrOutput() EndpointSeverityPtrOutput {
	return e.ToEndpointSeverityPtrOutputWithContext(context.Background())
}

func (e EndpointSeverity) ToEndpointSeverityPtrOutputWithContext(ctx context.Context) EndpointSeverityPtrOutput {
	return EndpointSeverity(e).ToEndpointSeverityOutputWithContext(ctx).ToEndpointSeverityPtrOutputWithContext(ctx)
}

func (e EndpointSeverity) ToStringOutput() pulumi.StringOutput {
	return pulumi.ToOutput(pulumi.String(e)).(pulumi.StringOutput)
}

func (e EndpointSeverity) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return pulumi.ToOutputWithContext(ctx, pulumi.String(e)).(pulumi.StringOutput)
}

func (e EndpointSeverity) ToStringPtrOutput() pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringPtrOutputWithContext(context.Background())
}

func (e EndpointSeverity) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringOutputWithContext(ctx).ToStringPtrOutputWithContext(ctx)
}

type EndpointSeverityOutput struct{ *pulumi.OutputState }

func (EndpointSeverityOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*EndpointSeverity)(nil)).Elem()
}

func (o EndpointSeverityOutput) ToEndpointSeverityOutput() EndpointSeverityOutput {
	return o
}

func (o EndpointSeverityOutput) ToEndpointSeverityOutputWithContext(ctx context.Context) EndpointSeverityOutput {
	return o
}

func (o EndpointSeverityOutput) ToEndpointSeverityPtrOutput() EndpointSeverityPtrOutput {
	return o.ToEndpointSeverityPtrOutputWithContext(context.Background())
}

func (o EndpointSeverityOutput) ToEndpointSeverityPtrOutputWithContext(ctx context.Context) EndpointSeverityPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v EndpointSeverity) *EndpointSeverity {
		return &v
	}).(EndpointSeverityPtrOutput)
}

func (o EndpointSeverityOutput) ToStringOutput() pulumi.StringOutput {
	return o.ToStringOutputWithContext(context.Background())
}

func (o EndpointSeverityOutput) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e EndpointSeverity) string {
		return string(e)
	}).(pulumi.StringOutput)
}

func (o EndpointSeverityOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o EndpointSeverityOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e EndpointSeverity) *string {
		v := string(e)
		return &v
	}).(pulumi.StringPtrOutput)
}

type EndpointSeverityPtrOutput struct{ *pulumi.OutputState }

func (EndpointSeverityPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**EndpointSeverity)(nil)).Elem()
}

func (o EndpointSeverityPtrOutput) ToEndpointSeverityPtrOutput() EndpointSeverityPtrOutput {
	return o
}

func (o EndpointSeverityPtrOutput) ToEndpointSeverityPtrOutputWithContext(ctx context.Context) EndpointSeverityPtrOutput {
	return o
}

func (o EndpointSeverityPtrOutput) Elem() EndpointSeverityOutput {
	return o.ApplyT(func(v *EndpointSeverity) EndpointSeverity {
		if v != nil {
			return *v
		}
		var ret EndpointSeverity
		return ret
	}).(EndpointSeverityOutput)
}

func (o EndpointSeverityPtrOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o EndpointSeverityPtrOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e *EndpointSeverity) *string {
		if e == nil {
			return nil
		}
		v := string(*e)
		return &v
	}).(pulumi.StringPtrOutput)
}

// EndpointSeverityInput is an input type that accepts EndpointSeverityArgs and EndpointSeverityOutput values.
// You can construct a concrete instance of `EndpointSeverityInput` via:
//
//          EndpointSeverityArgs{...}
type EndpointSeverityInput interface {
	pulumi.Input

	ToEndpointSeverityOutput() EndpointSeverityOutput
	ToEndpointSeverityOutputWithContext(context.Context) EndpointSeverityOutput
}

var endpointSeverityPtrType = reflect.TypeOf((**EndpointSeverity)(nil)).Elem()

type EndpointSeverityPtrInput interface {
	pulumi.Input

	ToEndpointSeverityPtrOutput() EndpointSeverityPtrOutput
	ToEndpointSeverityPtrOutputWithContext(context.Context) EndpointSeverityPtrOutput
}

type endpointSeverityPtr string

func EndpointSeverityPtr(v string) EndpointSeverityPtrInput {
	return (*endpointSeverityPtr)(&v)
}

func (*endpointSeverityPtr) ElementType() reflect.Type {
	return endpointSeverityPtrType
}

func (in *endpointSeverityPtr) ToEndpointSeverityPtrOutput() EndpointSeverityPtrOutput {
	return pulumi.ToOutput(in).(EndpointSeverityPtrOutput)
}

func (in *endpointSeverityPtr) ToEndpointSeverityPtrOutputWithContext(ctx context.Context) EndpointSeverityPtrOutput {
	return pulumi.ToOutputWithContext(ctx, in).(EndpointSeverityPtrOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*AuditLogConfigLogTypeInput)(nil)).Elem(), AuditLogConfigLogType("LOG_TYPE_UNSPECIFIED"))
	pulumi.RegisterInputType(reflect.TypeOf((*AuditLogConfigLogTypePtrInput)(nil)).Elem(), AuditLogConfigLogType("LOG_TYPE_UNSPECIFIED"))
	pulumi.RegisterInputType(reflect.TypeOf((*EndpointSeverityInput)(nil)).Elem(), EndpointSeverity("SEVERITY_UNSPECIFIED"))
	pulumi.RegisterInputType(reflect.TypeOf((*EndpointSeverityPtrInput)(nil)).Elem(), EndpointSeverity("SEVERITY_UNSPECIFIED"))
	pulumi.RegisterOutputType(AuditLogConfigLogTypeOutput{})
	pulumi.RegisterOutputType(AuditLogConfigLogTypePtrOutput{})
	pulumi.RegisterOutputType(EndpointSeverityOutput{})
	pulumi.RegisterOutputType(EndpointSeverityPtrOutput{})
}