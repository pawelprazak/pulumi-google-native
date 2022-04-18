// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Gets a mute config.
func LookupMuteConfig(ctx *pulumi.Context, args *LookupMuteConfigArgs, opts ...pulumi.InvokeOption) (*LookupMuteConfigResult, error) {
	var rv LookupMuteConfigResult
	err := ctx.Invoke("google-native:securitycenter/v1:getMuteConfig", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupMuteConfigArgs struct {
	MuteConfigId string  `pulumi:"muteConfigId"`
	Project      *string `pulumi:"project"`
}

type LookupMuteConfigResult struct {
	// The time at which the mute config was created. This field is set by the server and will be ignored if provided on config creation.
	CreateTime string `pulumi:"createTime"`
	// A description of the mute config.
	Description string `pulumi:"description"`
	// The human readable name to be displayed for the mute config.
	DisplayName string `pulumi:"displayName"`
	// An expression that defines the filter to apply across create/update events of findings. While creating a filter string, be mindful of the scope in which the mute configuration is being created. E.g., If a filter contains project = X but is created under the project = Y scope, it might not match any findings. The following field and operator combinations are supported: * severity: `=`, `:` * category: `=`, `:` * resource.name: `=`, `:` * resource.project_name: `=`, `:` * resource.project_display_name: `=`, `:` * resource.folders.resource_folder: `=`, `:` * resource.parent_name: `=`, `:` * resource.parent_display_name: `=`, `:` * resource.type: `=`, `:` * finding_class: `=`, `:` * indicator.ip_addresses: `=`, `:` * indicator.domains: `=`, `:`
	Filter string `pulumi:"filter"`
	// Email address of the user who last edited the mute config. This field is set by the server and will be ignored if provided on config creation or update.
	MostRecentEditor string `pulumi:"mostRecentEditor"`
	// This field will be ignored if provided on config creation. Format "organizations/{organization}/muteConfigs/{mute_config}" "folders/{folder}/muteConfigs/{mute_config}" "projects/{project}/muteConfigs/{mute_config}"
	Name string `pulumi:"name"`
	// The most recent time at which the mute config was updated. This field is set by the server and will be ignored if provided on config creation or update.
	UpdateTime string `pulumi:"updateTime"`
}

func LookupMuteConfigOutput(ctx *pulumi.Context, args LookupMuteConfigOutputArgs, opts ...pulumi.InvokeOption) LookupMuteConfigResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupMuteConfigResult, error) {
			args := v.(LookupMuteConfigArgs)
			r, err := LookupMuteConfig(ctx, &args, opts...)
			var s LookupMuteConfigResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupMuteConfigResultOutput)
}

type LookupMuteConfigOutputArgs struct {
	MuteConfigId pulumi.StringInput    `pulumi:"muteConfigId"`
	Project      pulumi.StringPtrInput `pulumi:"project"`
}

func (LookupMuteConfigOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupMuteConfigArgs)(nil)).Elem()
}

type LookupMuteConfigResultOutput struct{ *pulumi.OutputState }

func (LookupMuteConfigResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupMuteConfigResult)(nil)).Elem()
}

func (o LookupMuteConfigResultOutput) ToLookupMuteConfigResultOutput() LookupMuteConfigResultOutput {
	return o
}

func (o LookupMuteConfigResultOutput) ToLookupMuteConfigResultOutputWithContext(ctx context.Context) LookupMuteConfigResultOutput {
	return o
}

// The time at which the mute config was created. This field is set by the server and will be ignored if provided on config creation.
func (o LookupMuteConfigResultOutput) CreateTime() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMuteConfigResult) string { return v.CreateTime }).(pulumi.StringOutput)
}

// A description of the mute config.
func (o LookupMuteConfigResultOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMuteConfigResult) string { return v.Description }).(pulumi.StringOutput)
}

// The human readable name to be displayed for the mute config.
func (o LookupMuteConfigResultOutput) DisplayName() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMuteConfigResult) string { return v.DisplayName }).(pulumi.StringOutput)
}

// An expression that defines the filter to apply across create/update events of findings. While creating a filter string, be mindful of the scope in which the mute configuration is being created. E.g., If a filter contains project = X but is created under the project = Y scope, it might not match any findings. The following field and operator combinations are supported: * severity: `=`, `:` * category: `=`, `:` * resource.name: `=`, `:` * resource.project_name: `=`, `:` * resource.project_display_name: `=`, `:` * resource.folders.resource_folder: `=`, `:` * resource.parent_name: `=`, `:` * resource.parent_display_name: `=`, `:` * resource.type: `=`, `:` * finding_class: `=`, `:` * indicator.ip_addresses: `=`, `:` * indicator.domains: `=`, `:`
func (o LookupMuteConfigResultOutput) Filter() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMuteConfigResult) string { return v.Filter }).(pulumi.StringOutput)
}

// Email address of the user who last edited the mute config. This field is set by the server and will be ignored if provided on config creation or update.
func (o LookupMuteConfigResultOutput) MostRecentEditor() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMuteConfigResult) string { return v.MostRecentEditor }).(pulumi.StringOutput)
}

// This field will be ignored if provided on config creation. Format "organizations/{organization}/muteConfigs/{mute_config}" "folders/{folder}/muteConfigs/{mute_config}" "projects/{project}/muteConfigs/{mute_config}"
func (o LookupMuteConfigResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMuteConfigResult) string { return v.Name }).(pulumi.StringOutput)
}

// The most recent time at which the mute config was updated. This field is set by the server and will be ignored if provided on config creation or update.
func (o LookupMuteConfigResultOutput) UpdateTime() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMuteConfigResult) string { return v.UpdateTime }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupMuteConfigResultOutput{})
}