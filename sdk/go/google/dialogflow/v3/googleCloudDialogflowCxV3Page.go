// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v3

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Creates a page in the specified flow.
type GoogleCloudDialogflowCxV3Page struct {
	pulumi.CustomResourceState
}

// NewGoogleCloudDialogflowCxV3Page registers a new resource with the given unique name, arguments, and options.
func NewGoogleCloudDialogflowCxV3Page(ctx *pulumi.Context,
	name string, args *GoogleCloudDialogflowCxV3PageArgs, opts ...pulumi.ResourceOption) (*GoogleCloudDialogflowCxV3Page, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Parent == nil {
		return nil, errors.New("invalid value for required argument 'Parent'")
	}
	var resource GoogleCloudDialogflowCxV3Page
	err := ctx.RegisterResource("google-cloud:dialogflow/v3:GoogleCloudDialogflowCxV3Page", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetGoogleCloudDialogflowCxV3Page gets an existing GoogleCloudDialogflowCxV3Page resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetGoogleCloudDialogflowCxV3Page(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *GoogleCloudDialogflowCxV3PageState, opts ...pulumi.ResourceOption) (*GoogleCloudDialogflowCxV3Page, error) {
	var resource GoogleCloudDialogflowCxV3Page
	err := ctx.ReadResource("google-cloud:dialogflow/v3:GoogleCloudDialogflowCxV3Page", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering GoogleCloudDialogflowCxV3Page resources.
type googleCloudDialogflowCxV3PageState struct {
}

type GoogleCloudDialogflowCxV3PageState struct {
}

func (GoogleCloudDialogflowCxV3PageState) ElementType() reflect.Type {
	return reflect.TypeOf((*googleCloudDialogflowCxV3PageState)(nil)).Elem()
}

type googleCloudDialogflowCxV3PageArgs struct {
	// Required. The human-readable name of the page, unique within the agent.
	DisplayName *string `pulumi:"displayName"`
	// The fulfillment to call when the session is entering the page.
	EntryFulfillment *GoogleCloudDialogflowCxV3Fulfillment `pulumi:"entryFulfillment"`
	// Handlers associated with the page to handle events such as webhook errors, no match or no input.
	EventHandlers []GoogleCloudDialogflowCxV3EventHandler `pulumi:"eventHandlers"`
	// The form associated with the page, used for collecting parameters relevant to the page.
	Form *GoogleCloudDialogflowCxV3Form `pulumi:"form"`
	// The language of the following fields in `page`: * `Page.entry_fulfillment.messages` * `Page.form.parameters.fill_behavior.initial_prompt_fulfillment.messages` * `Page.form.parameters.fill_behavior.reprompt_event_handlers.messages` * `Page.transition_routes.trigger_fulfillment.messages` * `Page.transition_route_groups.transition_routes.trigger_fulfillment.messages` If not specified, the agent's default language is used. [Many languages](https://cloud.google.com/dialogflow/cx/docs/reference/language) are supported. Note: languages must be enabled in the agent before they can be used.
	LanguageCode *string `pulumi:"languageCode"`
	// The unique identifier of the page. Required for the Pages.UpdatePage method. Pages.CreatePage populates the name automatically. Format: `projects//locations//agents//flows//pages/`.
	Name *string `pulumi:"name"`
	// Required. The flow to create a page for. Format: `projects//locations//agents//flows/`.
	Parent string `pulumi:"parent"`
	// Ordered list of `TransitionRouteGroups` associated with the page. Transition route groups must be unique within a page. * If multiple transition routes within a page scope refer to the same intent, then the precedence order is: page's transition route -> page's transition route group -> flow's transition routes. * If multiple transition route groups within a page contain the same intent, then the first group in the ordered list takes precedence. Format:`projects//locations//agents//flows//transitionRouteGroups/`.
	TransitionRouteGroups []string `pulumi:"transitionRouteGroups"`
	// A list of transitions for the transition rules of this page. They route the conversation to another page in the same flow, or another flow. When we are in a certain page, the TransitionRoutes are evalauted in the following order: * TransitionRoutes defined in the page with intent specified. * TransitionRoutes defined in the transition route groups with intent specified. * TransitionRoutes defined in flow with intent specified. * TransitionRoutes defined in the transition route groups with intent specified. * TransitionRoutes defined in the page with only condition specified. * TransitionRoutes defined in the transition route groups with only condition specified.
	TransitionRoutes []GoogleCloudDialogflowCxV3TransitionRoute `pulumi:"transitionRoutes"`
}

// The set of arguments for constructing a GoogleCloudDialogflowCxV3Page resource.
type GoogleCloudDialogflowCxV3PageArgs struct {
	// Required. The human-readable name of the page, unique within the agent.
	DisplayName pulumi.StringPtrInput
	// The fulfillment to call when the session is entering the page.
	EntryFulfillment GoogleCloudDialogflowCxV3FulfillmentPtrInput
	// Handlers associated with the page to handle events such as webhook errors, no match or no input.
	EventHandlers GoogleCloudDialogflowCxV3EventHandlerArrayInput
	// The form associated with the page, used for collecting parameters relevant to the page.
	Form GoogleCloudDialogflowCxV3FormPtrInput
	// The language of the following fields in `page`: * `Page.entry_fulfillment.messages` * `Page.form.parameters.fill_behavior.initial_prompt_fulfillment.messages` * `Page.form.parameters.fill_behavior.reprompt_event_handlers.messages` * `Page.transition_routes.trigger_fulfillment.messages` * `Page.transition_route_groups.transition_routes.trigger_fulfillment.messages` If not specified, the agent's default language is used. [Many languages](https://cloud.google.com/dialogflow/cx/docs/reference/language) are supported. Note: languages must be enabled in the agent before they can be used.
	LanguageCode pulumi.StringPtrInput
	// The unique identifier of the page. Required for the Pages.UpdatePage method. Pages.CreatePage populates the name automatically. Format: `projects//locations//agents//flows//pages/`.
	Name pulumi.StringPtrInput
	// Required. The flow to create a page for. Format: `projects//locations//agents//flows/`.
	Parent pulumi.StringInput
	// Ordered list of `TransitionRouteGroups` associated with the page. Transition route groups must be unique within a page. * If multiple transition routes within a page scope refer to the same intent, then the precedence order is: page's transition route -> page's transition route group -> flow's transition routes. * If multiple transition route groups within a page contain the same intent, then the first group in the ordered list takes precedence. Format:`projects//locations//agents//flows//transitionRouteGroups/`.
	TransitionRouteGroups pulumi.StringArrayInput
	// A list of transitions for the transition rules of this page. They route the conversation to another page in the same flow, or another flow. When we are in a certain page, the TransitionRoutes are evalauted in the following order: * TransitionRoutes defined in the page with intent specified. * TransitionRoutes defined in the transition route groups with intent specified. * TransitionRoutes defined in flow with intent specified. * TransitionRoutes defined in the transition route groups with intent specified. * TransitionRoutes defined in the page with only condition specified. * TransitionRoutes defined in the transition route groups with only condition specified.
	TransitionRoutes GoogleCloudDialogflowCxV3TransitionRouteArrayInput
}

func (GoogleCloudDialogflowCxV3PageArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*googleCloudDialogflowCxV3PageArgs)(nil)).Elem()
}

type GoogleCloudDialogflowCxV3PageInput interface {
	pulumi.Input

	ToGoogleCloudDialogflowCxV3PageOutput() GoogleCloudDialogflowCxV3PageOutput
	ToGoogleCloudDialogflowCxV3PageOutputWithContext(ctx context.Context) GoogleCloudDialogflowCxV3PageOutput
}

func (*GoogleCloudDialogflowCxV3Page) ElementType() reflect.Type {
	return reflect.TypeOf((*GoogleCloudDialogflowCxV3Page)(nil))
}

func (i *GoogleCloudDialogflowCxV3Page) ToGoogleCloudDialogflowCxV3PageOutput() GoogleCloudDialogflowCxV3PageOutput {
	return i.ToGoogleCloudDialogflowCxV3PageOutputWithContext(context.Background())
}

func (i *GoogleCloudDialogflowCxV3Page) ToGoogleCloudDialogflowCxV3PageOutputWithContext(ctx context.Context) GoogleCloudDialogflowCxV3PageOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GoogleCloudDialogflowCxV3PageOutput)
}

type GoogleCloudDialogflowCxV3PageOutput struct {
	*pulumi.OutputState
}

func (GoogleCloudDialogflowCxV3PageOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GoogleCloudDialogflowCxV3Page)(nil))
}

func (o GoogleCloudDialogflowCxV3PageOutput) ToGoogleCloudDialogflowCxV3PageOutput() GoogleCloudDialogflowCxV3PageOutput {
	return o
}

func (o GoogleCloudDialogflowCxV3PageOutput) ToGoogleCloudDialogflowCxV3PageOutputWithContext(ctx context.Context) GoogleCloudDialogflowCxV3PageOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(GoogleCloudDialogflowCxV3PageOutput{})
}