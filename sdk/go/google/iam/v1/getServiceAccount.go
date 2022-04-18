// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Gets a ServiceAccount.
func LookupServiceAccount(ctx *pulumi.Context, args *LookupServiceAccountArgs, opts ...pulumi.InvokeOption) (*LookupServiceAccountResult, error) {
	var rv LookupServiceAccountResult
	err := ctx.Invoke("google-native:iam/v1:getServiceAccount", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupServiceAccountArgs struct {
	Project          *string `pulumi:"project"`
	ServiceAccountId string  `pulumi:"serviceAccountId"`
}

type LookupServiceAccountResult struct {
	// Optional. A user-specified, human-readable description of the service account. The maximum length is 256 UTF-8 bytes.
	Description string `pulumi:"description"`
	// Whether the service account is disabled.
	Disabled bool `pulumi:"disabled"`
	// Optional. A user-specified, human-readable name for the service account. The maximum length is 100 UTF-8 bytes.
	DisplayName string `pulumi:"displayName"`
	// The email address of the service account.
	Email string `pulumi:"email"`
	// Deprecated. Do not use.
	//
	// Deprecated: Deprecated. Do not use.
	Etag string `pulumi:"etag"`
	// The resource name of the service account. Use one of the following formats: * `projects/{PROJECT_ID}/serviceAccounts/{EMAIL_ADDRESS}` * `projects/{PROJECT_ID}/serviceAccounts/{UNIQUE_ID}` As an alternative, you can use the `-` wildcard character instead of the project ID: * `projects/-/serviceAccounts/{EMAIL_ADDRESS}` * `projects/-/serviceAccounts/{UNIQUE_ID}` When possible, avoid using the `-` wildcard character, because it can cause response messages to contain misleading error codes. For example, if you try to get the service account `projects/-/serviceAccounts/fake@example.com`, which does not exist, the response contains an HTTP `403 Forbidden` error instead of a `404 Not Found` error.
	Name string `pulumi:"name"`
	// The OAuth 2.0 client ID for the service account.
	Oauth2ClientId string `pulumi:"oauth2ClientId"`
	// The ID of the project that owns the service account.
	Project string `pulumi:"project"`
	// The unique, stable numeric ID for the service account. Each service account retains its unique ID even if you delete the service account. For example, if you delete a service account, then create a new service account with the same name, the new service account has a different unique ID than the deleted service account.
	UniqueId string `pulumi:"uniqueId"`
}

func LookupServiceAccountOutput(ctx *pulumi.Context, args LookupServiceAccountOutputArgs, opts ...pulumi.InvokeOption) LookupServiceAccountResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupServiceAccountResult, error) {
			args := v.(LookupServiceAccountArgs)
			r, err := LookupServiceAccount(ctx, &args, opts...)
			var s LookupServiceAccountResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupServiceAccountResultOutput)
}

type LookupServiceAccountOutputArgs struct {
	Project          pulumi.StringPtrInput `pulumi:"project"`
	ServiceAccountId pulumi.StringInput    `pulumi:"serviceAccountId"`
}

func (LookupServiceAccountOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupServiceAccountArgs)(nil)).Elem()
}

type LookupServiceAccountResultOutput struct{ *pulumi.OutputState }

func (LookupServiceAccountResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupServiceAccountResult)(nil)).Elem()
}

func (o LookupServiceAccountResultOutput) ToLookupServiceAccountResultOutput() LookupServiceAccountResultOutput {
	return o
}

func (o LookupServiceAccountResultOutput) ToLookupServiceAccountResultOutputWithContext(ctx context.Context) LookupServiceAccountResultOutput {
	return o
}

// Optional. A user-specified, human-readable description of the service account. The maximum length is 256 UTF-8 bytes.
func (o LookupServiceAccountResultOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v LookupServiceAccountResult) string { return v.Description }).(pulumi.StringOutput)
}

// Whether the service account is disabled.
func (o LookupServiceAccountResultOutput) Disabled() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupServiceAccountResult) bool { return v.Disabled }).(pulumi.BoolOutput)
}

// Optional. A user-specified, human-readable name for the service account. The maximum length is 100 UTF-8 bytes.
func (o LookupServiceAccountResultOutput) DisplayName() pulumi.StringOutput {
	return o.ApplyT(func(v LookupServiceAccountResult) string { return v.DisplayName }).(pulumi.StringOutput)
}

// The email address of the service account.
func (o LookupServiceAccountResultOutput) Email() pulumi.StringOutput {
	return o.ApplyT(func(v LookupServiceAccountResult) string { return v.Email }).(pulumi.StringOutput)
}

// Deprecated. Do not use.
//
// Deprecated: Deprecated. Do not use.
func (o LookupServiceAccountResultOutput) Etag() pulumi.StringOutput {
	return o.ApplyT(func(v LookupServiceAccountResult) string { return v.Etag }).(pulumi.StringOutput)
}

// The resource name of the service account. Use one of the following formats: * `projects/{PROJECT_ID}/serviceAccounts/{EMAIL_ADDRESS}` * `projects/{PROJECT_ID}/serviceAccounts/{UNIQUE_ID}` As an alternative, you can use the `-` wildcard character instead of the project ID: * `projects/-/serviceAccounts/{EMAIL_ADDRESS}` * `projects/-/serviceAccounts/{UNIQUE_ID}` When possible, avoid using the `-` wildcard character, because it can cause response messages to contain misleading error codes. For example, if you try to get the service account `projects/-/serviceAccounts/fake@example.com`, which does not exist, the response contains an HTTP `403 Forbidden` error instead of a `404 Not Found` error.
func (o LookupServiceAccountResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupServiceAccountResult) string { return v.Name }).(pulumi.StringOutput)
}

// The OAuth 2.0 client ID for the service account.
func (o LookupServiceAccountResultOutput) Oauth2ClientId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupServiceAccountResult) string { return v.Oauth2ClientId }).(pulumi.StringOutput)
}

// The ID of the project that owns the service account.
func (o LookupServiceAccountResultOutput) Project() pulumi.StringOutput {
	return o.ApplyT(func(v LookupServiceAccountResult) string { return v.Project }).(pulumi.StringOutput)
}

// The unique, stable numeric ID for the service account. Each service account retains its unique ID even if you delete the service account. For example, if you delete a service account, then create a new service account with the same name, the new service account has a different unique ID than the deleted service account.
func (o LookupServiceAccountResultOutput) UniqueId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupServiceAccountResult) string { return v.UniqueId }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupServiceAccountResultOutput{})
}