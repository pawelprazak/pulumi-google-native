// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v1

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// CreateApiVersion creates a specified version.
type Version struct {
	pulumi.CustomResourceState

	// Annotations attach non-identifying metadata to resources. Annotation keys and values are less restricted than those of labels, but should be generally used for small values of broad interest. Larger, topic- specific metadata should be stored in Artifacts.
	Annotations pulumi.StringMapOutput `pulumi:"annotations"`
	// Creation timestamp.
	CreateTime pulumi.StringOutput `pulumi:"createTime"`
	// A detailed description.
	Description pulumi.StringOutput `pulumi:"description"`
	// Human-meaningful name.
	DisplayName pulumi.StringOutput `pulumi:"displayName"`
	// Labels attach identifying metadata to resources. Identifying metadata can be used to filter list operations. Label keys and values can be no longer than 64 characters (Unicode codepoints), can only contain lowercase letters, numeric characters, underscores and dashes. International characters are allowed. No more than 64 user labels can be associated with one resource (System labels are excluded). See https://goo.gl/xmQnxf for more information and examples of labels. System reserved label keys are prefixed with "apigeeregistry.googleapis.com/" and cannot be changed.
	Labels pulumi.StringMapOutput `pulumi:"labels"`
	// Resource name.
	Name pulumi.StringOutput `pulumi:"name"`
	// A user-definable description of the lifecycle phase of this API version. Format: free-form, but we expect single words that describe API maturity, e.g. "CONCEPT", "DESIGN", "DEVELOPMENT", "STAGING", "PRODUCTION", "DEPRECATED", "RETIRED".
	State pulumi.StringOutput `pulumi:"state"`
	// Last update timestamp.
	UpdateTime pulumi.StringOutput `pulumi:"updateTime"`
}

// NewVersion registers a new resource with the given unique name, arguments, and options.
func NewVersion(ctx *pulumi.Context,
	name string, args *VersionArgs, opts ...pulumi.ResourceOption) (*Version, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ApiId == nil {
		return nil, errors.New("invalid value for required argument 'ApiId'")
	}
	if args.ApiVersionId == nil {
		return nil, errors.New("invalid value for required argument 'ApiVersionId'")
	}
	var resource Version
	err := ctx.RegisterResource("google-native:apigeeregistry/v1:Version", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetVersion gets an existing Version resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetVersion(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *VersionState, opts ...pulumi.ResourceOption) (*Version, error) {
	var resource Version
	err := ctx.ReadResource("google-native:apigeeregistry/v1:Version", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Version resources.
type versionState struct {
}

type VersionState struct {
}

func (VersionState) ElementType() reflect.Type {
	return reflect.TypeOf((*versionState)(nil)).Elem()
}

type versionArgs struct {
	// Annotations attach non-identifying metadata to resources. Annotation keys and values are less restricted than those of labels, but should be generally used for small values of broad interest. Larger, topic- specific metadata should be stored in Artifacts.
	Annotations map[string]string `pulumi:"annotations"`
	ApiId       string            `pulumi:"apiId"`
	// Required. The ID to use for the version, which will become the final component of the version's resource name. This value should be 1-63 characters, and valid characters are /a-z-/. Following AIP-162, IDs must not have the form of a UUID.
	ApiVersionId string `pulumi:"apiVersionId"`
	// A detailed description.
	Description *string `pulumi:"description"`
	// Human-meaningful name.
	DisplayName *string `pulumi:"displayName"`
	// Labels attach identifying metadata to resources. Identifying metadata can be used to filter list operations. Label keys and values can be no longer than 64 characters (Unicode codepoints), can only contain lowercase letters, numeric characters, underscores and dashes. International characters are allowed. No more than 64 user labels can be associated with one resource (System labels are excluded). See https://goo.gl/xmQnxf for more information and examples of labels. System reserved label keys are prefixed with "apigeeregistry.googleapis.com/" and cannot be changed.
	Labels   map[string]string `pulumi:"labels"`
	Location *string           `pulumi:"location"`
	// Resource name.
	Name    *string `pulumi:"name"`
	Project *string `pulumi:"project"`
	// A user-definable description of the lifecycle phase of this API version. Format: free-form, but we expect single words that describe API maturity, e.g. "CONCEPT", "DESIGN", "DEVELOPMENT", "STAGING", "PRODUCTION", "DEPRECATED", "RETIRED".
	State *string `pulumi:"state"`
}

// The set of arguments for constructing a Version resource.
type VersionArgs struct {
	// Annotations attach non-identifying metadata to resources. Annotation keys and values are less restricted than those of labels, but should be generally used for small values of broad interest. Larger, topic- specific metadata should be stored in Artifacts.
	Annotations pulumi.StringMapInput
	ApiId       pulumi.StringInput
	// Required. The ID to use for the version, which will become the final component of the version's resource name. This value should be 1-63 characters, and valid characters are /a-z-/. Following AIP-162, IDs must not have the form of a UUID.
	ApiVersionId pulumi.StringInput
	// A detailed description.
	Description pulumi.StringPtrInput
	// Human-meaningful name.
	DisplayName pulumi.StringPtrInput
	// Labels attach identifying metadata to resources. Identifying metadata can be used to filter list operations. Label keys and values can be no longer than 64 characters (Unicode codepoints), can only contain lowercase letters, numeric characters, underscores and dashes. International characters are allowed. No more than 64 user labels can be associated with one resource (System labels are excluded). See https://goo.gl/xmQnxf for more information and examples of labels. System reserved label keys are prefixed with "apigeeregistry.googleapis.com/" and cannot be changed.
	Labels   pulumi.StringMapInput
	Location pulumi.StringPtrInput
	// Resource name.
	Name    pulumi.StringPtrInput
	Project pulumi.StringPtrInput
	// A user-definable description of the lifecycle phase of this API version. Format: free-form, but we expect single words that describe API maturity, e.g. "CONCEPT", "DESIGN", "DEVELOPMENT", "STAGING", "PRODUCTION", "DEPRECATED", "RETIRED".
	State pulumi.StringPtrInput
}

func (VersionArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*versionArgs)(nil)).Elem()
}

type VersionInput interface {
	pulumi.Input

	ToVersionOutput() VersionOutput
	ToVersionOutputWithContext(ctx context.Context) VersionOutput
}

func (*Version) ElementType() reflect.Type {
	return reflect.TypeOf((**Version)(nil)).Elem()
}

func (i *Version) ToVersionOutput() VersionOutput {
	return i.ToVersionOutputWithContext(context.Background())
}

func (i *Version) ToVersionOutputWithContext(ctx context.Context) VersionOutput {
	return pulumi.ToOutputWithContext(ctx, i).(VersionOutput)
}

type VersionOutput struct{ *pulumi.OutputState }

func (VersionOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**Version)(nil)).Elem()
}

func (o VersionOutput) ToVersionOutput() VersionOutput {
	return o
}

func (o VersionOutput) ToVersionOutputWithContext(ctx context.Context) VersionOutput {
	return o
}

// Annotations attach non-identifying metadata to resources. Annotation keys and values are less restricted than those of labels, but should be generally used for small values of broad interest. Larger, topic- specific metadata should be stored in Artifacts.
func (o VersionOutput) Annotations() pulumi.StringMapOutput {
	return o.ApplyT(func(v *Version) pulumi.StringMapOutput { return v.Annotations }).(pulumi.StringMapOutput)
}

// Creation timestamp.
func (o VersionOutput) CreateTime() pulumi.StringOutput {
	return o.ApplyT(func(v *Version) pulumi.StringOutput { return v.CreateTime }).(pulumi.StringOutput)
}

// A detailed description.
func (o VersionOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v *Version) pulumi.StringOutput { return v.Description }).(pulumi.StringOutput)
}

// Human-meaningful name.
func (o VersionOutput) DisplayName() pulumi.StringOutput {
	return o.ApplyT(func(v *Version) pulumi.StringOutput { return v.DisplayName }).(pulumi.StringOutput)
}

// Labels attach identifying metadata to resources. Identifying metadata can be used to filter list operations. Label keys and values can be no longer than 64 characters (Unicode codepoints), can only contain lowercase letters, numeric characters, underscores and dashes. International characters are allowed. No more than 64 user labels can be associated with one resource (System labels are excluded). See https://goo.gl/xmQnxf for more information and examples of labels. System reserved label keys are prefixed with "apigeeregistry.googleapis.com/" and cannot be changed.
func (o VersionOutput) Labels() pulumi.StringMapOutput {
	return o.ApplyT(func(v *Version) pulumi.StringMapOutput { return v.Labels }).(pulumi.StringMapOutput)
}

// Resource name.
func (o VersionOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *Version) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// A user-definable description of the lifecycle phase of this API version. Format: free-form, but we expect single words that describe API maturity, e.g. "CONCEPT", "DESIGN", "DEVELOPMENT", "STAGING", "PRODUCTION", "DEPRECATED", "RETIRED".
func (o VersionOutput) State() pulumi.StringOutput {
	return o.ApplyT(func(v *Version) pulumi.StringOutput { return v.State }).(pulumi.StringOutput)
}

// Last update timestamp.
func (o VersionOutput) UpdateTime() pulumi.StringOutput {
	return o.ApplyT(func(v *Version) pulumi.StringOutput { return v.UpdateTime }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*VersionInput)(nil)).Elem(), &Version{})
	pulumi.RegisterOutputType(VersionOutput{})
}