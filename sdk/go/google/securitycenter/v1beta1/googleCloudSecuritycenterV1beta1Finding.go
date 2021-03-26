// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1beta1

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Creates a finding. The corresponding source must exist for finding creation to succeed.
type GoogleCloudSecuritycenterV1beta1Finding struct {
	pulumi.CustomResourceState
}

// NewGoogleCloudSecuritycenterV1beta1Finding registers a new resource with the given unique name, arguments, and options.
func NewGoogleCloudSecuritycenterV1beta1Finding(ctx *pulumi.Context,
	name string, args *GoogleCloudSecuritycenterV1beta1FindingArgs, opts ...pulumi.ResourceOption) (*GoogleCloudSecuritycenterV1beta1Finding, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Parent == nil {
		return nil, errors.New("invalid value for required argument 'Parent'")
	}
	var resource GoogleCloudSecuritycenterV1beta1Finding
	err := ctx.RegisterResource("google-cloud:securitycenter/v1beta1:GoogleCloudSecuritycenterV1beta1Finding", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetGoogleCloudSecuritycenterV1beta1Finding gets an existing GoogleCloudSecuritycenterV1beta1Finding resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetGoogleCloudSecuritycenterV1beta1Finding(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *GoogleCloudSecuritycenterV1beta1FindingState, opts ...pulumi.ResourceOption) (*GoogleCloudSecuritycenterV1beta1Finding, error) {
	var resource GoogleCloudSecuritycenterV1beta1Finding
	err := ctx.ReadResource("google-cloud:securitycenter/v1beta1:GoogleCloudSecuritycenterV1beta1Finding", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering GoogleCloudSecuritycenterV1beta1Finding resources.
type googleCloudSecuritycenterV1beta1FindingState struct {
}

type GoogleCloudSecuritycenterV1beta1FindingState struct {
}

func (GoogleCloudSecuritycenterV1beta1FindingState) ElementType() reflect.Type {
	return reflect.TypeOf((*googleCloudSecuritycenterV1beta1FindingState)(nil)).Elem()
}

type googleCloudSecuritycenterV1beta1FindingArgs struct {
	// The additional taxonomy group within findings from a given source. This field is immutable after creation time. Example: "XSS_FLASH_INJECTION"
	Category *string `pulumi:"category"`
	// The time at which the finding was created in Security Command Center.
	CreateTime *string `pulumi:"createTime"`
	// The time at which the event took place, or when an update to the finding occurred. For example, if the finding represents an open firewall it would capture the time the detector believes the firewall became open. The accuracy is determined by the detector. If the finding were to be resolved afterward, this time would reflect when the finding was resolved.
	EventTime *string `pulumi:"eventTime"`
	// The URI that, if available, points to a web page outside of Security Command Center where additional information about the finding can be found. This field is guaranteed to be either empty or a well formed URL.
	ExternalUri *string `pulumi:"externalUri"`
	// Required. Unique identifier provided by the client within the parent scope. It must be alphanumeric and less than or equal to 32 characters and greater than 0 characters in length.
	FindingId *string `pulumi:"findingId"`
	// The relative resource name of this finding. See: https://cloud.google.com/apis/design/resource_names#relative_resource_name Example: "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}"
	Name *string `pulumi:"name"`
	// Immutable. The relative resource name of the source the finding belongs to. See: https://cloud.google.com/apis/design/resource_names#relative_resource_name This field is immutable after creation time. For example: "organizations/{organization_id}/sources/{source_id}"
	Parent string `pulumi:"parent"`
	// For findings on Google Cloud resources, the full resource name of the Google Cloud resource this finding is for. See: https://cloud.google.com/apis/design/resource_names#full_resource_name When the finding is for a non-Google Cloud resource, the resourceName can be a customer or partner defined string. This field is immutable after creation time.
	ResourceName *string `pulumi:"resourceName"`
	// Output only. User specified security marks. These marks are entirely managed by the user and come from the SecurityMarks resource that belongs to the finding.
	SecurityMarks *GoogleCloudSecuritycenterV1beta1SecurityMarks `pulumi:"securityMarks"`
	// Source specific properties. These properties are managed by the source that writes the finding. The key names in the source_properties map must be between 1 and 255 characters, and must start with a letter and contain alphanumeric characters or underscores only.
	SourceProperties map[string]string `pulumi:"sourceProperties"`
	// The state of the finding.
	State *string `pulumi:"state"`
}

// The set of arguments for constructing a GoogleCloudSecuritycenterV1beta1Finding resource.
type GoogleCloudSecuritycenterV1beta1FindingArgs struct {
	// The additional taxonomy group within findings from a given source. This field is immutable after creation time. Example: "XSS_FLASH_INJECTION"
	Category pulumi.StringPtrInput
	// The time at which the finding was created in Security Command Center.
	CreateTime pulumi.StringPtrInput
	// The time at which the event took place, or when an update to the finding occurred. For example, if the finding represents an open firewall it would capture the time the detector believes the firewall became open. The accuracy is determined by the detector. If the finding were to be resolved afterward, this time would reflect when the finding was resolved.
	EventTime pulumi.StringPtrInput
	// The URI that, if available, points to a web page outside of Security Command Center where additional information about the finding can be found. This field is guaranteed to be either empty or a well formed URL.
	ExternalUri pulumi.StringPtrInput
	// Required. Unique identifier provided by the client within the parent scope. It must be alphanumeric and less than or equal to 32 characters and greater than 0 characters in length.
	FindingId pulumi.StringPtrInput
	// The relative resource name of this finding. See: https://cloud.google.com/apis/design/resource_names#relative_resource_name Example: "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}"
	Name pulumi.StringPtrInput
	// Immutable. The relative resource name of the source the finding belongs to. See: https://cloud.google.com/apis/design/resource_names#relative_resource_name This field is immutable after creation time. For example: "organizations/{organization_id}/sources/{source_id}"
	Parent pulumi.StringInput
	// For findings on Google Cloud resources, the full resource name of the Google Cloud resource this finding is for. See: https://cloud.google.com/apis/design/resource_names#full_resource_name When the finding is for a non-Google Cloud resource, the resourceName can be a customer or partner defined string. This field is immutable after creation time.
	ResourceName pulumi.StringPtrInput
	// Output only. User specified security marks. These marks are entirely managed by the user and come from the SecurityMarks resource that belongs to the finding.
	SecurityMarks GoogleCloudSecuritycenterV1beta1SecurityMarksPtrInput
	// Source specific properties. These properties are managed by the source that writes the finding. The key names in the source_properties map must be between 1 and 255 characters, and must start with a letter and contain alphanumeric characters or underscores only.
	SourceProperties pulumi.StringMapInput
	// The state of the finding.
	State pulumi.StringPtrInput
}

func (GoogleCloudSecuritycenterV1beta1FindingArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*googleCloudSecuritycenterV1beta1FindingArgs)(nil)).Elem()
}

type GoogleCloudSecuritycenterV1beta1FindingInput interface {
	pulumi.Input

	ToGoogleCloudSecuritycenterV1beta1FindingOutput() GoogleCloudSecuritycenterV1beta1FindingOutput
	ToGoogleCloudSecuritycenterV1beta1FindingOutputWithContext(ctx context.Context) GoogleCloudSecuritycenterV1beta1FindingOutput
}

func (*GoogleCloudSecuritycenterV1beta1Finding) ElementType() reflect.Type {
	return reflect.TypeOf((*GoogleCloudSecuritycenterV1beta1Finding)(nil))
}

func (i *GoogleCloudSecuritycenterV1beta1Finding) ToGoogleCloudSecuritycenterV1beta1FindingOutput() GoogleCloudSecuritycenterV1beta1FindingOutput {
	return i.ToGoogleCloudSecuritycenterV1beta1FindingOutputWithContext(context.Background())
}

func (i *GoogleCloudSecuritycenterV1beta1Finding) ToGoogleCloudSecuritycenterV1beta1FindingOutputWithContext(ctx context.Context) GoogleCloudSecuritycenterV1beta1FindingOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GoogleCloudSecuritycenterV1beta1FindingOutput)
}

type GoogleCloudSecuritycenterV1beta1FindingOutput struct {
	*pulumi.OutputState
}

func (GoogleCloudSecuritycenterV1beta1FindingOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GoogleCloudSecuritycenterV1beta1Finding)(nil))
}

func (o GoogleCloudSecuritycenterV1beta1FindingOutput) ToGoogleCloudSecuritycenterV1beta1FindingOutput() GoogleCloudSecuritycenterV1beta1FindingOutput {
	return o
}

func (o GoogleCloudSecuritycenterV1beta1FindingOutput) ToGoogleCloudSecuritycenterV1beta1FindingOutputWithContext(ctx context.Context) GoogleCloudSecuritycenterV1beta1FindingOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(GoogleCloudSecuritycenterV1beta1FindingOutput{})
}