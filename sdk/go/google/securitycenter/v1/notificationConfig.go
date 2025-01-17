// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v1

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Creates a notification config.
type NotificationConfig struct {
	pulumi.CustomResourceState

	// Required. Unique identifier provided by the client within the parent scope. It must be between 1 and 128 characters, and contains alphanumeric characters, underscores or hyphens only.
	ConfigId pulumi.StringOutput `pulumi:"configId"`
	// The description of the notification config (max of 1024 characters).
	Description pulumi.StringOutput `pulumi:"description"`
	// The relative resource name of this notification config. See: https://cloud.google.com/apis/design/resource_names#relative_resource_name Example: "organizations/{organization_id}/notificationConfigs/notify_public_bucket".
	Name           pulumi.StringOutput `pulumi:"name"`
	OrganizationId pulumi.StringOutput `pulumi:"organizationId"`
	// The Pub/Sub topic to send notifications to. Its format is "projects/[project_id]/topics/[topic]".
	PubsubTopic pulumi.StringOutput `pulumi:"pubsubTopic"`
	// The service account that needs "pubsub.topics.publish" permission to publish to the Pub/Sub topic.
	ServiceAccount pulumi.StringOutput `pulumi:"serviceAccount"`
	// The config for triggering streaming-based notifications.
	StreamingConfig StreamingConfigResponseOutput `pulumi:"streamingConfig"`
}

// NewNotificationConfig registers a new resource with the given unique name, arguments, and options.
func NewNotificationConfig(ctx *pulumi.Context,
	name string, args *NotificationConfigArgs, opts ...pulumi.ResourceOption) (*NotificationConfig, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ConfigId == nil {
		return nil, errors.New("invalid value for required argument 'ConfigId'")
	}
	if args.OrganizationId == nil {
		return nil, errors.New("invalid value for required argument 'OrganizationId'")
	}
	var resource NotificationConfig
	err := ctx.RegisterResource("google-native:securitycenter/v1:NotificationConfig", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetNotificationConfig gets an existing NotificationConfig resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetNotificationConfig(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *NotificationConfigState, opts ...pulumi.ResourceOption) (*NotificationConfig, error) {
	var resource NotificationConfig
	err := ctx.ReadResource("google-native:securitycenter/v1:NotificationConfig", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering NotificationConfig resources.
type notificationConfigState struct {
}

type NotificationConfigState struct {
}

func (NotificationConfigState) ElementType() reflect.Type {
	return reflect.TypeOf((*notificationConfigState)(nil)).Elem()
}

type notificationConfigArgs struct {
	// Required. Unique identifier provided by the client within the parent scope. It must be between 1 and 128 characters, and contains alphanumeric characters, underscores or hyphens only.
	ConfigId string `pulumi:"configId"`
	// The description of the notification config (max of 1024 characters).
	Description *string `pulumi:"description"`
	// The relative resource name of this notification config. See: https://cloud.google.com/apis/design/resource_names#relative_resource_name Example: "organizations/{organization_id}/notificationConfigs/notify_public_bucket".
	Name           *string `pulumi:"name"`
	OrganizationId string  `pulumi:"organizationId"`
	// The Pub/Sub topic to send notifications to. Its format is "projects/[project_id]/topics/[topic]".
	PubsubTopic *string `pulumi:"pubsubTopic"`
	// The config for triggering streaming-based notifications.
	StreamingConfig *StreamingConfig `pulumi:"streamingConfig"`
}

// The set of arguments for constructing a NotificationConfig resource.
type NotificationConfigArgs struct {
	// Required. Unique identifier provided by the client within the parent scope. It must be between 1 and 128 characters, and contains alphanumeric characters, underscores or hyphens only.
	ConfigId pulumi.StringInput
	// The description of the notification config (max of 1024 characters).
	Description pulumi.StringPtrInput
	// The relative resource name of this notification config. See: https://cloud.google.com/apis/design/resource_names#relative_resource_name Example: "organizations/{organization_id}/notificationConfigs/notify_public_bucket".
	Name           pulumi.StringPtrInput
	OrganizationId pulumi.StringInput
	// The Pub/Sub topic to send notifications to. Its format is "projects/[project_id]/topics/[topic]".
	PubsubTopic pulumi.StringPtrInput
	// The config for triggering streaming-based notifications.
	StreamingConfig StreamingConfigPtrInput
}

func (NotificationConfigArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*notificationConfigArgs)(nil)).Elem()
}

type NotificationConfigInput interface {
	pulumi.Input

	ToNotificationConfigOutput() NotificationConfigOutput
	ToNotificationConfigOutputWithContext(ctx context.Context) NotificationConfigOutput
}

func (*NotificationConfig) ElementType() reflect.Type {
	return reflect.TypeOf((**NotificationConfig)(nil)).Elem()
}

func (i *NotificationConfig) ToNotificationConfigOutput() NotificationConfigOutput {
	return i.ToNotificationConfigOutputWithContext(context.Background())
}

func (i *NotificationConfig) ToNotificationConfigOutputWithContext(ctx context.Context) NotificationConfigOutput {
	return pulumi.ToOutputWithContext(ctx, i).(NotificationConfigOutput)
}

type NotificationConfigOutput struct{ *pulumi.OutputState }

func (NotificationConfigOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**NotificationConfig)(nil)).Elem()
}

func (o NotificationConfigOutput) ToNotificationConfigOutput() NotificationConfigOutput {
	return o
}

func (o NotificationConfigOutput) ToNotificationConfigOutputWithContext(ctx context.Context) NotificationConfigOutput {
	return o
}

// Required. Unique identifier provided by the client within the parent scope. It must be between 1 and 128 characters, and contains alphanumeric characters, underscores or hyphens only.
func (o NotificationConfigOutput) ConfigId() pulumi.StringOutput {
	return o.ApplyT(func(v *NotificationConfig) pulumi.StringOutput { return v.ConfigId }).(pulumi.StringOutput)
}

// The description of the notification config (max of 1024 characters).
func (o NotificationConfigOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v *NotificationConfig) pulumi.StringOutput { return v.Description }).(pulumi.StringOutput)
}

// The relative resource name of this notification config. See: https://cloud.google.com/apis/design/resource_names#relative_resource_name Example: "organizations/{organization_id}/notificationConfigs/notify_public_bucket".
func (o NotificationConfigOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *NotificationConfig) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

func (o NotificationConfigOutput) OrganizationId() pulumi.StringOutput {
	return o.ApplyT(func(v *NotificationConfig) pulumi.StringOutput { return v.OrganizationId }).(pulumi.StringOutput)
}

// The Pub/Sub topic to send notifications to. Its format is "projects/[project_id]/topics/[topic]".
func (o NotificationConfigOutput) PubsubTopic() pulumi.StringOutput {
	return o.ApplyT(func(v *NotificationConfig) pulumi.StringOutput { return v.PubsubTopic }).(pulumi.StringOutput)
}

// The service account that needs "pubsub.topics.publish" permission to publish to the Pub/Sub topic.
func (o NotificationConfigOutput) ServiceAccount() pulumi.StringOutput {
	return o.ApplyT(func(v *NotificationConfig) pulumi.StringOutput { return v.ServiceAccount }).(pulumi.StringOutput)
}

// The config for triggering streaming-based notifications.
func (o NotificationConfigOutput) StreamingConfig() StreamingConfigResponseOutput {
	return o.ApplyT(func(v *NotificationConfig) StreamingConfigResponseOutput { return v.StreamingConfig }).(StreamingConfigResponseOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*NotificationConfigInput)(nil)).Elem(), &NotificationConfig{})
	pulumi.RegisterOutputType(NotificationConfigOutput{})
}
