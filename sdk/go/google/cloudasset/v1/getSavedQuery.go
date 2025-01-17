// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v1

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Gets details about a saved query.
func LookupSavedQuery(ctx *pulumi.Context, args *LookupSavedQueryArgs, opts ...pulumi.InvokeOption) (*LookupSavedQueryResult, error) {
	var rv LookupSavedQueryResult
	err := ctx.Invoke("google-native:cloudasset/v1:getSavedQuery", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupSavedQueryArgs struct {
	SavedQueryId string `pulumi:"savedQueryId"`
	V1Id         string `pulumi:"v1Id"`
	V1Id1        string `pulumi:"v1Id1"`
}

type LookupSavedQueryResult struct {
	// The query content.
	Content QueryContentResponse `pulumi:"content"`
	// The create time of this saved query.
	CreateTime string `pulumi:"createTime"`
	// The account's email address who has created this saved query.
	Creator string `pulumi:"creator"`
	// The description of this saved query. This value should be fewer than 255 characters.
	Description string `pulumi:"description"`
	// Labels applied on the resource. This value should not contain more than 10 entries. The key and value of each entry must be non-empty and fewer than 64 characters.
	Labels map[string]string `pulumi:"labels"`
	// The last update time of this saved query.
	LastUpdateTime string `pulumi:"lastUpdateTime"`
	// The account's email address who has updated this saved query most recently.
	LastUpdater string `pulumi:"lastUpdater"`
	// The resource name of the saved query. The format must be: * projects/project_number/savedQueries/saved_query_id * folders/folder_number/savedQueries/saved_query_id * organizations/organization_number/savedQueries/saved_query_id
	Name string `pulumi:"name"`
}

func LookupSavedQueryOutput(ctx *pulumi.Context, args LookupSavedQueryOutputArgs, opts ...pulumi.InvokeOption) LookupSavedQueryResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupSavedQueryResult, error) {
			args := v.(LookupSavedQueryArgs)
			r, err := LookupSavedQuery(ctx, &args, opts...)
			var s LookupSavedQueryResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupSavedQueryResultOutput)
}

type LookupSavedQueryOutputArgs struct {
	SavedQueryId pulumi.StringInput `pulumi:"savedQueryId"`
	V1Id         pulumi.StringInput `pulumi:"v1Id"`
	V1Id1        pulumi.StringInput `pulumi:"v1Id1"`
}

func (LookupSavedQueryOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupSavedQueryArgs)(nil)).Elem()
}

type LookupSavedQueryResultOutput struct{ *pulumi.OutputState }

func (LookupSavedQueryResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupSavedQueryResult)(nil)).Elem()
}

func (o LookupSavedQueryResultOutput) ToLookupSavedQueryResultOutput() LookupSavedQueryResultOutput {
	return o
}

func (o LookupSavedQueryResultOutput) ToLookupSavedQueryResultOutputWithContext(ctx context.Context) LookupSavedQueryResultOutput {
	return o
}

// The query content.
func (o LookupSavedQueryResultOutput) Content() QueryContentResponseOutput {
	return o.ApplyT(func(v LookupSavedQueryResult) QueryContentResponse { return v.Content }).(QueryContentResponseOutput)
}

// The create time of this saved query.
func (o LookupSavedQueryResultOutput) CreateTime() pulumi.StringOutput {
	return o.ApplyT(func(v LookupSavedQueryResult) string { return v.CreateTime }).(pulumi.StringOutput)
}

// The account's email address who has created this saved query.
func (o LookupSavedQueryResultOutput) Creator() pulumi.StringOutput {
	return o.ApplyT(func(v LookupSavedQueryResult) string { return v.Creator }).(pulumi.StringOutput)
}

// The description of this saved query. This value should be fewer than 255 characters.
func (o LookupSavedQueryResultOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v LookupSavedQueryResult) string { return v.Description }).(pulumi.StringOutput)
}

// Labels applied on the resource. This value should not contain more than 10 entries. The key and value of each entry must be non-empty and fewer than 64 characters.
func (o LookupSavedQueryResultOutput) Labels() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupSavedQueryResult) map[string]string { return v.Labels }).(pulumi.StringMapOutput)
}

// The last update time of this saved query.
func (o LookupSavedQueryResultOutput) LastUpdateTime() pulumi.StringOutput {
	return o.ApplyT(func(v LookupSavedQueryResult) string { return v.LastUpdateTime }).(pulumi.StringOutput)
}

// The account's email address who has updated this saved query most recently.
func (o LookupSavedQueryResultOutput) LastUpdater() pulumi.StringOutput {
	return o.ApplyT(func(v LookupSavedQueryResult) string { return v.LastUpdater }).(pulumi.StringOutput)
}

// The resource name of the saved query. The format must be: * projects/project_number/savedQueries/saved_query_id * folders/folder_number/savedQueries/saved_query_id * organizations/organization_number/savedQueries/saved_query_id
func (o LookupSavedQueryResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupSavedQueryResult) string { return v.Name }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupSavedQueryResultOutput{})
}
