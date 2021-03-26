// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v3beta1

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Creates a flow in the specified agent.
type GoogleCloudDialogflowCxV3beta1Flow struct {
	pulumi.CustomResourceState
}

// NewGoogleCloudDialogflowCxV3beta1Flow registers a new resource with the given unique name, arguments, and options.
func NewGoogleCloudDialogflowCxV3beta1Flow(ctx *pulumi.Context,
	name string, args *GoogleCloudDialogflowCxV3beta1FlowArgs, opts ...pulumi.ResourceOption) (*GoogleCloudDialogflowCxV3beta1Flow, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Parent == nil {
		return nil, errors.New("invalid value for required argument 'Parent'")
	}
	var resource GoogleCloudDialogflowCxV3beta1Flow
	err := ctx.RegisterResource("google-cloud:dialogflow/v3beta1:GoogleCloudDialogflowCxV3beta1Flow", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetGoogleCloudDialogflowCxV3beta1Flow gets an existing GoogleCloudDialogflowCxV3beta1Flow resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetGoogleCloudDialogflowCxV3beta1Flow(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *GoogleCloudDialogflowCxV3beta1FlowState, opts ...pulumi.ResourceOption) (*GoogleCloudDialogflowCxV3beta1Flow, error) {
	var resource GoogleCloudDialogflowCxV3beta1Flow
	err := ctx.ReadResource("google-cloud:dialogflow/v3beta1:GoogleCloudDialogflowCxV3beta1Flow", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering GoogleCloudDialogflowCxV3beta1Flow resources.
type googleCloudDialogflowCxV3beta1FlowState struct {
}

type GoogleCloudDialogflowCxV3beta1FlowState struct {
}

func (GoogleCloudDialogflowCxV3beta1FlowState) ElementType() reflect.Type {
	return reflect.TypeOf((*googleCloudDialogflowCxV3beta1FlowState)(nil)).Elem()
}

type googleCloudDialogflowCxV3beta1FlowArgs struct {
	// The description of the flow. The maximum length is 500 characters. If exceeded, the request is rejected.
	Description *string `pulumi:"description"`
	// Required. The human-readable name of the flow.
	DisplayName *string `pulumi:"displayName"`
	// A flow's event handlers serve two purposes: * They are responsible for handling events (e.g. no match, webhook errors) in the flow. * They are inherited by every page's event handlers, which can be used to handle common events regardless of the current page. Event handlers defined in the page have higher priority than those defined in the flow. Unlike transition_routes, these handlers are evaluated on a first-match basis. The first one that matches the event get executed, with the rest being ignored.
	EventHandlers []GoogleCloudDialogflowCxV3beta1EventHandler `pulumi:"eventHandlers"`
	// The language of the following fields in `flow`: * `Flow.event_handlers.trigger_fulfillment.messages` * `Flow.transition_routes.trigger_fulfillment.messages` If not specified, the agent's default language is used. [Many languages](https://cloud.google.com/dialogflow/cx/docs/reference/language) are supported. Note: languages must be enabled in the agent before they can be used.
	LanguageCode *string `pulumi:"languageCode"`
	// The unique identifier of the flow. Format: `projects//locations//agents//flows/`.
	Name *string `pulumi:"name"`
	// NLU related settings of the flow.
	NluSettings *GoogleCloudDialogflowCxV3beta1NluSettings `pulumi:"nluSettings"`
	// Required. The agent to create a flow for. Format: `projects//locations//agents/`.
	Parent string `pulumi:"parent"`
	// A flow's transition routes serve two purposes: * They are responsible for matching the user's first utterances in the flow. * They are inherited by every page's transition routes and can support use cases such as the user saying "help" or "can I talk to a human?", which can be handled in a common way regardless of the current page. Transition routes defined in the page have higher priority than those defined in the flow. TransitionRoutes are evalauted in the following order: * TransitionRoutes with intent specified.. * TransitionRoutes with only condition specified. TransitionRoutes with intent specified are inherited by pages in the flow.
	TransitionRoutes []GoogleCloudDialogflowCxV3beta1TransitionRoute `pulumi:"transitionRoutes"`
}

// The set of arguments for constructing a GoogleCloudDialogflowCxV3beta1Flow resource.
type GoogleCloudDialogflowCxV3beta1FlowArgs struct {
	// The description of the flow. The maximum length is 500 characters. If exceeded, the request is rejected.
	Description pulumi.StringPtrInput
	// Required. The human-readable name of the flow.
	DisplayName pulumi.StringPtrInput
	// A flow's event handlers serve two purposes: * They are responsible for handling events (e.g. no match, webhook errors) in the flow. * They are inherited by every page's event handlers, which can be used to handle common events regardless of the current page. Event handlers defined in the page have higher priority than those defined in the flow. Unlike transition_routes, these handlers are evaluated on a first-match basis. The first one that matches the event get executed, with the rest being ignored.
	EventHandlers GoogleCloudDialogflowCxV3beta1EventHandlerArrayInput
	// The language of the following fields in `flow`: * `Flow.event_handlers.trigger_fulfillment.messages` * `Flow.transition_routes.trigger_fulfillment.messages` If not specified, the agent's default language is used. [Many languages](https://cloud.google.com/dialogflow/cx/docs/reference/language) are supported. Note: languages must be enabled in the agent before they can be used.
	LanguageCode pulumi.StringPtrInput
	// The unique identifier of the flow. Format: `projects//locations//agents//flows/`.
	Name pulumi.StringPtrInput
	// NLU related settings of the flow.
	NluSettings GoogleCloudDialogflowCxV3beta1NluSettingsPtrInput
	// Required. The agent to create a flow for. Format: `projects//locations//agents/`.
	Parent pulumi.StringInput
	// A flow's transition routes serve two purposes: * They are responsible for matching the user's first utterances in the flow. * They are inherited by every page's transition routes and can support use cases such as the user saying "help" or "can I talk to a human?", which can be handled in a common way regardless of the current page. Transition routes defined in the page have higher priority than those defined in the flow. TransitionRoutes are evalauted in the following order: * TransitionRoutes with intent specified.. * TransitionRoutes with only condition specified. TransitionRoutes with intent specified are inherited by pages in the flow.
	TransitionRoutes GoogleCloudDialogflowCxV3beta1TransitionRouteArrayInput
}

func (GoogleCloudDialogflowCxV3beta1FlowArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*googleCloudDialogflowCxV3beta1FlowArgs)(nil)).Elem()
}

type GoogleCloudDialogflowCxV3beta1FlowInput interface {
	pulumi.Input

	ToGoogleCloudDialogflowCxV3beta1FlowOutput() GoogleCloudDialogflowCxV3beta1FlowOutput
	ToGoogleCloudDialogflowCxV3beta1FlowOutputWithContext(ctx context.Context) GoogleCloudDialogflowCxV3beta1FlowOutput
}

func (*GoogleCloudDialogflowCxV3beta1Flow) ElementType() reflect.Type {
	return reflect.TypeOf((*GoogleCloudDialogflowCxV3beta1Flow)(nil))
}

func (i *GoogleCloudDialogflowCxV3beta1Flow) ToGoogleCloudDialogflowCxV3beta1FlowOutput() GoogleCloudDialogflowCxV3beta1FlowOutput {
	return i.ToGoogleCloudDialogflowCxV3beta1FlowOutputWithContext(context.Background())
}

func (i *GoogleCloudDialogflowCxV3beta1Flow) ToGoogleCloudDialogflowCxV3beta1FlowOutputWithContext(ctx context.Context) GoogleCloudDialogflowCxV3beta1FlowOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GoogleCloudDialogflowCxV3beta1FlowOutput)
}

type GoogleCloudDialogflowCxV3beta1FlowOutput struct {
	*pulumi.OutputState
}

func (GoogleCloudDialogflowCxV3beta1FlowOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GoogleCloudDialogflowCxV3beta1Flow)(nil))
}

func (o GoogleCloudDialogflowCxV3beta1FlowOutput) ToGoogleCloudDialogflowCxV3beta1FlowOutput() GoogleCloudDialogflowCxV3beta1FlowOutput {
	return o
}

func (o GoogleCloudDialogflowCxV3beta1FlowOutput) ToGoogleCloudDialogflowCxV3beta1FlowOutputWithContext(ctx context.Context) GoogleCloudDialogflowCxV3beta1FlowOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(GoogleCloudDialogflowCxV3beta1FlowOutput{})
}