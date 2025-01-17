// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v1

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Gets a single contact.
func LookupOrganizationContact(ctx *pulumi.Context, args *LookupOrganizationContactArgs, opts ...pulumi.InvokeOption) (*LookupOrganizationContactResult, error) {
	var rv LookupOrganizationContactResult
	err := ctx.Invoke("google-native:essentialcontacts/v1:getOrganizationContact", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupOrganizationContactArgs struct {
	ContactId      string `pulumi:"contactId"`
	OrganizationId string `pulumi:"organizationId"`
}

type LookupOrganizationContactResult struct {
	// The email address to send notifications to. This does not need to be a Google account.
	Email string `pulumi:"email"`
	// The preferred language for notifications, as a ISO 639-1 language code. See [Supported languages](https://cloud.google.com/resource-manager/docs/managing-notification-contacts#supported-languages) for a list of supported languages.
	LanguageTag string `pulumi:"languageTag"`
	// The identifier for the contact. Format: {resource_type}/{resource_id}/contacts/{contact_id}
	Name string `pulumi:"name"`
	// The categories of notifications that the contact will receive communications for.
	NotificationCategorySubscriptions []string `pulumi:"notificationCategorySubscriptions"`
	// The last time the validation_state was updated, either manually or automatically. A contact is considered stale if its validation state was updated more than 1 year ago.
	ValidateTime string `pulumi:"validateTime"`
	// The validity of the contact. A contact is considered valid if it is the correct recipient for notifications for a particular resource.
	ValidationState string `pulumi:"validationState"`
}

func LookupOrganizationContactOutput(ctx *pulumi.Context, args LookupOrganizationContactOutputArgs, opts ...pulumi.InvokeOption) LookupOrganizationContactResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupOrganizationContactResult, error) {
			args := v.(LookupOrganizationContactArgs)
			r, err := LookupOrganizationContact(ctx, &args, opts...)
			var s LookupOrganizationContactResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupOrganizationContactResultOutput)
}

type LookupOrganizationContactOutputArgs struct {
	ContactId      pulumi.StringInput `pulumi:"contactId"`
	OrganizationId pulumi.StringInput `pulumi:"organizationId"`
}

func (LookupOrganizationContactOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupOrganizationContactArgs)(nil)).Elem()
}

type LookupOrganizationContactResultOutput struct{ *pulumi.OutputState }

func (LookupOrganizationContactResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupOrganizationContactResult)(nil)).Elem()
}

func (o LookupOrganizationContactResultOutput) ToLookupOrganizationContactResultOutput() LookupOrganizationContactResultOutput {
	return o
}

func (o LookupOrganizationContactResultOutput) ToLookupOrganizationContactResultOutputWithContext(ctx context.Context) LookupOrganizationContactResultOutput {
	return o
}

// The email address to send notifications to. This does not need to be a Google account.
func (o LookupOrganizationContactResultOutput) Email() pulumi.StringOutput {
	return o.ApplyT(func(v LookupOrganizationContactResult) string { return v.Email }).(pulumi.StringOutput)
}

// The preferred language for notifications, as a ISO 639-1 language code. See [Supported languages](https://cloud.google.com/resource-manager/docs/managing-notification-contacts#supported-languages) for a list of supported languages.
func (o LookupOrganizationContactResultOutput) LanguageTag() pulumi.StringOutput {
	return o.ApplyT(func(v LookupOrganizationContactResult) string { return v.LanguageTag }).(pulumi.StringOutput)
}

// The identifier for the contact. Format: {resource_type}/{resource_id}/contacts/{contact_id}
func (o LookupOrganizationContactResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupOrganizationContactResult) string { return v.Name }).(pulumi.StringOutput)
}

// The categories of notifications that the contact will receive communications for.
func (o LookupOrganizationContactResultOutput) NotificationCategorySubscriptions() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupOrganizationContactResult) []string { return v.NotificationCategorySubscriptions }).(pulumi.StringArrayOutput)
}

// The last time the validation_state was updated, either manually or automatically. A contact is considered stale if its validation state was updated more than 1 year ago.
func (o LookupOrganizationContactResultOutput) ValidateTime() pulumi.StringOutput {
	return o.ApplyT(func(v LookupOrganizationContactResult) string { return v.ValidateTime }).(pulumi.StringOutput)
}

// The validity of the contact. A contact is considered valid if it is the correct recipient for notifications for a particular resource.
func (o LookupOrganizationContactResultOutput) ValidationState() pulumi.StringOutput {
	return o.ApplyT(func(v LookupOrganizationContactResult) string { return v.ValidationState }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupOrganizationContactResultOutput{})
}
