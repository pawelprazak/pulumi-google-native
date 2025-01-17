// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v1beta1

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Gets the specified IosApp.
func LookupIosApp(ctx *pulumi.Context, args *LookupIosAppArgs, opts ...pulumi.InvokeOption) (*LookupIosAppResult, error) {
	var rv LookupIosAppResult
	err := ctx.Invoke("google-native:firebase/v1beta1:getIosApp", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupIosAppArgs struct {
	IosAppId string  `pulumi:"iosAppId"`
	Project  *string `pulumi:"project"`
}

type LookupIosAppResult struct {
	// The key_id of the GCP ApiKey associated with this App. If set must have no restrictions, or only have restrictions that are valid for the associated Firebase App. Cannot be set in create requests, instead an existing valid API Key will be chosen, or if no valid API Keys exist, one will be provisioned for you. Cannot be set to an empty value in update requests.
	ApiKeyId string `pulumi:"apiKeyId"`
	// Immutable. The globally unique, Firebase-assigned identifier for the `IosApp`. This identifier should be treated as an opaque token, as the data format is not specified.
	AppId string `pulumi:"appId"`
	// The automatically generated Apple ID assigned to the iOS app by Apple in the iOS App Store.
	AppStoreId string `pulumi:"appStoreId"`
	// Immutable. The canonical bundle ID of the iOS app as it would appear in the iOS AppStore.
	BundleId string `pulumi:"bundleId"`
	// The user-assigned display name for the `IosApp`.
	DisplayName string `pulumi:"displayName"`
	// The resource name of the IosApp, in the format: projects/PROJECT_IDENTIFIER /iosApps/APP_ID * PROJECT_IDENTIFIER: the parent Project's [`ProjectNumber`](../projects#FirebaseProject.FIELDS.project_number) ***(recommended)*** or its [`ProjectId`](../projects#FirebaseProject.FIELDS.project_id). Learn more about using project identifiers in Google's [AIP 2510 standard](https://google.aip.dev/cloud/2510). Note that the value for PROJECT_IDENTIFIER in any response body will be the `ProjectId`. * APP_ID: the globally unique, Firebase-assigned identifier for the App (see [`appId`](../projects.iosApps#IosApp.FIELDS.app_id)).
	Name string `pulumi:"name"`
	// Immutable. A user-assigned unique identifier of the parent FirebaseProject for the `IosApp`.
	Project string `pulumi:"project"`
	// The lifecycle state of the App.
	State string `pulumi:"state"`
	// The Apple Developer Team ID associated with the App in the App Store.
	TeamId string `pulumi:"teamId"`
}

func LookupIosAppOutput(ctx *pulumi.Context, args LookupIosAppOutputArgs, opts ...pulumi.InvokeOption) LookupIosAppResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupIosAppResult, error) {
			args := v.(LookupIosAppArgs)
			r, err := LookupIosApp(ctx, &args, opts...)
			var s LookupIosAppResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupIosAppResultOutput)
}

type LookupIosAppOutputArgs struct {
	IosAppId pulumi.StringInput    `pulumi:"iosAppId"`
	Project  pulumi.StringPtrInput `pulumi:"project"`
}

func (LookupIosAppOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupIosAppArgs)(nil)).Elem()
}

type LookupIosAppResultOutput struct{ *pulumi.OutputState }

func (LookupIosAppResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupIosAppResult)(nil)).Elem()
}

func (o LookupIosAppResultOutput) ToLookupIosAppResultOutput() LookupIosAppResultOutput {
	return o
}

func (o LookupIosAppResultOutput) ToLookupIosAppResultOutputWithContext(ctx context.Context) LookupIosAppResultOutput {
	return o
}

// The key_id of the GCP ApiKey associated with this App. If set must have no restrictions, or only have restrictions that are valid for the associated Firebase App. Cannot be set in create requests, instead an existing valid API Key will be chosen, or if no valid API Keys exist, one will be provisioned for you. Cannot be set to an empty value in update requests.
func (o LookupIosAppResultOutput) ApiKeyId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupIosAppResult) string { return v.ApiKeyId }).(pulumi.StringOutput)
}

// Immutable. The globally unique, Firebase-assigned identifier for the `IosApp`. This identifier should be treated as an opaque token, as the data format is not specified.
func (o LookupIosAppResultOutput) AppId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupIosAppResult) string { return v.AppId }).(pulumi.StringOutput)
}

// The automatically generated Apple ID assigned to the iOS app by Apple in the iOS App Store.
func (o LookupIosAppResultOutput) AppStoreId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupIosAppResult) string { return v.AppStoreId }).(pulumi.StringOutput)
}

// Immutable. The canonical bundle ID of the iOS app as it would appear in the iOS AppStore.
func (o LookupIosAppResultOutput) BundleId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupIosAppResult) string { return v.BundleId }).(pulumi.StringOutput)
}

// The user-assigned display name for the `IosApp`.
func (o LookupIosAppResultOutput) DisplayName() pulumi.StringOutput {
	return o.ApplyT(func(v LookupIosAppResult) string { return v.DisplayName }).(pulumi.StringOutput)
}

// The resource name of the IosApp, in the format: projects/PROJECT_IDENTIFIER /iosApps/APP_ID * PROJECT_IDENTIFIER: the parent Project's [`ProjectNumber`](../projects#FirebaseProject.FIELDS.project_number) ***(recommended)*** or its [`ProjectId`](../projects#FirebaseProject.FIELDS.project_id). Learn more about using project identifiers in Google's [AIP 2510 standard](https://google.aip.dev/cloud/2510). Note that the value for PROJECT_IDENTIFIER in any response body will be the `ProjectId`. * APP_ID: the globally unique, Firebase-assigned identifier for the App (see [`appId`](../projects.iosApps#IosApp.FIELDS.app_id)).
func (o LookupIosAppResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupIosAppResult) string { return v.Name }).(pulumi.StringOutput)
}

// Immutable. A user-assigned unique identifier of the parent FirebaseProject for the `IosApp`.
func (o LookupIosAppResultOutput) Project() pulumi.StringOutput {
	return o.ApplyT(func(v LookupIosAppResult) string { return v.Project }).(pulumi.StringOutput)
}

// The lifecycle state of the App.
func (o LookupIosAppResultOutput) State() pulumi.StringOutput {
	return o.ApplyT(func(v LookupIosAppResult) string { return v.State }).(pulumi.StringOutput)
}

// The Apple Developer Team ID associated with the App in the App Store.
func (o LookupIosAppResultOutput) TeamId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupIosAppResult) string { return v.TeamId }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupIosAppResultOutput{})
}
