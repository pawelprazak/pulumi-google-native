// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Gets a ScanConfig.
func LookupScanConfig(ctx *pulumi.Context, args *LookupScanConfigArgs, opts ...pulumi.InvokeOption) (*LookupScanConfigResult, error) {
	var rv LookupScanConfigResult
	err := ctx.Invoke("google-native:websecurityscanner/v1alpha:getScanConfig", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupScanConfigArgs struct {
	Project      *string `pulumi:"project"`
	ScanConfigId string  `pulumi:"scanConfigId"`
}

type LookupScanConfigResult struct {
	// The authentication configuration. If specified, service will use the authentication configuration during scanning.
	Authentication AuthenticationResponse `pulumi:"authentication"`
	// The excluded URL patterns as described in https://cloud.google.com/security-command-center/docs/how-to-use-web-security-scanner#excluding_urls
	BlacklistPatterns []string `pulumi:"blacklistPatterns"`
	// The user provided display name of the ScanConfig.
	DisplayName string `pulumi:"displayName"`
	// Latest ScanRun if available.
	LatestRun ScanRunResponse `pulumi:"latestRun"`
	// The maximum QPS during scanning. A valid value ranges from 5 to 20 inclusively. If the field is unspecified or its value is set 0, server will default to 15. Other values outside of [5, 20] range will be rejected with INVALID_ARGUMENT error.
	MaxQps int `pulumi:"maxQps"`
	// The resource name of the ScanConfig. The name follows the format of 'projects/{projectId}/scanConfigs/{scanConfigId}'. The ScanConfig IDs are generated by the system.
	Name string `pulumi:"name"`
	// The schedule of the ScanConfig.
	Schedule ScheduleResponse `pulumi:"schedule"`
	// The starting URLs from which the scanner finds site pages.
	StartingUrls []string `pulumi:"startingUrls"`
	// Set of Google Cloud platforms targeted by the scan. If empty, APP_ENGINE will be used as a default.
	TargetPlatforms []string `pulumi:"targetPlatforms"`
	// The user agent used during scanning.
	UserAgent string `pulumi:"userAgent"`
}

func LookupScanConfigOutput(ctx *pulumi.Context, args LookupScanConfigOutputArgs, opts ...pulumi.InvokeOption) LookupScanConfigResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupScanConfigResult, error) {
			args := v.(LookupScanConfigArgs)
			r, err := LookupScanConfig(ctx, &args, opts...)
			return *r, err
		}).(LookupScanConfigResultOutput)
}

type LookupScanConfigOutputArgs struct {
	Project      pulumi.StringPtrInput `pulumi:"project"`
	ScanConfigId pulumi.StringInput    `pulumi:"scanConfigId"`
}

func (LookupScanConfigOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupScanConfigArgs)(nil)).Elem()
}

type LookupScanConfigResultOutput struct{ *pulumi.OutputState }

func (LookupScanConfigResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupScanConfigResult)(nil)).Elem()
}

func (o LookupScanConfigResultOutput) ToLookupScanConfigResultOutput() LookupScanConfigResultOutput {
	return o
}

func (o LookupScanConfigResultOutput) ToLookupScanConfigResultOutputWithContext(ctx context.Context) LookupScanConfigResultOutput {
	return o
}

// The authentication configuration. If specified, service will use the authentication configuration during scanning.
func (o LookupScanConfigResultOutput) Authentication() AuthenticationResponseOutput {
	return o.ApplyT(func(v LookupScanConfigResult) AuthenticationResponse { return v.Authentication }).(AuthenticationResponseOutput)
}

// The excluded URL patterns as described in https://cloud.google.com/security-command-center/docs/how-to-use-web-security-scanner#excluding_urls
func (o LookupScanConfigResultOutput) BlacklistPatterns() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupScanConfigResult) []string { return v.BlacklistPatterns }).(pulumi.StringArrayOutput)
}

// The user provided display name of the ScanConfig.
func (o LookupScanConfigResultOutput) DisplayName() pulumi.StringOutput {
	return o.ApplyT(func(v LookupScanConfigResult) string { return v.DisplayName }).(pulumi.StringOutput)
}

// Latest ScanRun if available.
func (o LookupScanConfigResultOutput) LatestRun() ScanRunResponseOutput {
	return o.ApplyT(func(v LookupScanConfigResult) ScanRunResponse { return v.LatestRun }).(ScanRunResponseOutput)
}

// The maximum QPS during scanning. A valid value ranges from 5 to 20 inclusively. If the field is unspecified or its value is set 0, server will default to 15. Other values outside of [5, 20] range will be rejected with INVALID_ARGUMENT error.
func (o LookupScanConfigResultOutput) MaxQps() pulumi.IntOutput {
	return o.ApplyT(func(v LookupScanConfigResult) int { return v.MaxQps }).(pulumi.IntOutput)
}

// The resource name of the ScanConfig. The name follows the format of 'projects/{projectId}/scanConfigs/{scanConfigId}'. The ScanConfig IDs are generated by the system.
func (o LookupScanConfigResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupScanConfigResult) string { return v.Name }).(pulumi.StringOutput)
}

// The schedule of the ScanConfig.
func (o LookupScanConfigResultOutput) Schedule() ScheduleResponseOutput {
	return o.ApplyT(func(v LookupScanConfigResult) ScheduleResponse { return v.Schedule }).(ScheduleResponseOutput)
}

// The starting URLs from which the scanner finds site pages.
func (o LookupScanConfigResultOutput) StartingUrls() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupScanConfigResult) []string { return v.StartingUrls }).(pulumi.StringArrayOutput)
}

// Set of Google Cloud platforms targeted by the scan. If empty, APP_ENGINE will be used as a default.
func (o LookupScanConfigResultOutput) TargetPlatforms() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupScanConfigResult) []string { return v.TargetPlatforms }).(pulumi.StringArrayOutput)
}

// The user agent used during scanning.
func (o LookupScanConfigResultOutput) UserAgent() pulumi.StringOutput {
	return o.ApplyT(func(v LookupScanConfigResult) string { return v.UserAgent }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupScanConfigResultOutput{})
}