// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v2

import (
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Gets a DeidentifyTemplate. See https://cloud.google.com/dlp/docs/creating-templates-deid to learn more.
func LookupDeidentifyTemplate(ctx *pulumi.Context, args *LookupDeidentifyTemplateArgs, opts ...pulumi.InvokeOption) (*LookupDeidentifyTemplateResult, error) {
	var rv LookupDeidentifyTemplateResult
	err := ctx.Invoke("google-native:dlp/v2:getDeidentifyTemplate", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupDeidentifyTemplateArgs struct {
	DeidentifyTemplateId string `pulumi:"deidentifyTemplateId"`
	Location             string `pulumi:"location"`
	Project              string `pulumi:"project"`
}

type LookupDeidentifyTemplateResult struct {
	// The creation timestamp of an inspectTemplate.
	CreateTime string `pulumi:"createTime"`
	// The core content of the template.
	DeidentifyConfig GooglePrivacyDlpV2DeidentifyConfigResponse `pulumi:"deidentifyConfig"`
	// Short description (max 256 chars).
	Description string `pulumi:"description"`
	// Display name (max 256 chars).
	DisplayName string `pulumi:"displayName"`
	// The template name. The template will have one of the following formats: `projects/PROJECT_ID/deidentifyTemplates/TEMPLATE_ID` OR `organizations/ORGANIZATION_ID/deidentifyTemplates/TEMPLATE_ID`
	Name string `pulumi:"name"`
	// The last update timestamp of an inspectTemplate.
	UpdateTime string `pulumi:"updateTime"`
}