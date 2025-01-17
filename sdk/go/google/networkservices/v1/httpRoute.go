// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v1

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Creates a new HttpRoute in a given project and location.
type HttpRoute struct {
	pulumi.CustomResourceState

	// The timestamp when the resource was created.
	CreateTime pulumi.StringOutput `pulumi:"createTime"`
	// Optional. A free-text description of the resource. Max length 1024 characters.
	Description pulumi.StringOutput `pulumi:"description"`
	// Optional. Gateways defines a list of gateways this HttpRoute is attached to, as one of the routing rules to route the requests served by the gateway. Each gateway reference should match the pattern: `projects/*/locations/global/gateways/`
	Gateways pulumi.StringArrayOutput `pulumi:"gateways"`
	// Hostnames define a set of hosts that should match against the HTTP host header to select a HttpRoute to process the request. Hostname is the fully qualified domain name of a network host, as defined by RFC 1123 with the exception that: - IPs are not allowed. - A hostname may be prefixed with a wildcard label (*.). The wildcard label must appear by itself as the first label. Hostname can be "precise" which is a domain name without the terminating dot of a network host (e.g. "foo.example.com") or "wildcard", which is a domain name prefixed with a single wildcard label (e.g. *.example.com). Note that as per RFC1035 and RFC1123, a label must consist of lower case alphanumeric characters or '-', and must start and end with an alphanumeric character. No other punctuation is allowed. The routes associated with a Mesh or Gateways must have unique hostnames. If you attempt to attach multiple routes with conflicting hostnames, the configuration will be rejected. For example, while it is acceptable for routes for the hostnames "*.foo.bar.com" and "*.bar.com" to be associated with the same Mesh (or Gateways under the same scope), it is not possible to associate two routes both with "*.bar.com" or both with "bar.com".
	Hostnames pulumi.StringArrayOutput `pulumi:"hostnames"`
	// Required. Short name of the HttpRoute resource to be created.
	HttpRouteId pulumi.StringOutput `pulumi:"httpRouteId"`
	// Optional. Set of label tags associated with the HttpRoute resource.
	Labels   pulumi.StringMapOutput `pulumi:"labels"`
	Location pulumi.StringOutput    `pulumi:"location"`
	// Optional. Meshes defines a list of meshes this HttpRoute is attached to, as one of the routing rules to route the requests served by the mesh. Each mesh reference should match the pattern: `projects/*/locations/global/meshes/` The attached Mesh should be of a type SIDECAR
	Meshes pulumi.StringArrayOutput `pulumi:"meshes"`
	// Name of the HttpRoute resource. It matches pattern `projects/*/locations/global/httpRoutes/http_route_name>`.
	Name    pulumi.StringOutput `pulumi:"name"`
	Project pulumi.StringOutput `pulumi:"project"`
	// Rules that define how traffic is routed and handled. Rules will be matched sequentially based on the RouteMatch specified for the rule.
	Rules HttpRouteRouteRuleResponseArrayOutput `pulumi:"rules"`
	// Server-defined URL of this resource
	SelfLink pulumi.StringOutput `pulumi:"selfLink"`
	// The timestamp when the resource was updated.
	UpdateTime pulumi.StringOutput `pulumi:"updateTime"`
}

// NewHttpRoute registers a new resource with the given unique name, arguments, and options.
func NewHttpRoute(ctx *pulumi.Context,
	name string, args *HttpRouteArgs, opts ...pulumi.ResourceOption) (*HttpRoute, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Hostnames == nil {
		return nil, errors.New("invalid value for required argument 'Hostnames'")
	}
	if args.HttpRouteId == nil {
		return nil, errors.New("invalid value for required argument 'HttpRouteId'")
	}
	if args.Rules == nil {
		return nil, errors.New("invalid value for required argument 'Rules'")
	}
	var resource HttpRoute
	err := ctx.RegisterResource("google-native:networkservices/v1:HttpRoute", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetHttpRoute gets an existing HttpRoute resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetHttpRoute(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *HttpRouteState, opts ...pulumi.ResourceOption) (*HttpRoute, error) {
	var resource HttpRoute
	err := ctx.ReadResource("google-native:networkservices/v1:HttpRoute", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering HttpRoute resources.
type httpRouteState struct {
}

type HttpRouteState struct {
}

func (HttpRouteState) ElementType() reflect.Type {
	return reflect.TypeOf((*httpRouteState)(nil)).Elem()
}

type httpRouteArgs struct {
	// Optional. A free-text description of the resource. Max length 1024 characters.
	Description *string `pulumi:"description"`
	// Optional. Gateways defines a list of gateways this HttpRoute is attached to, as one of the routing rules to route the requests served by the gateway. Each gateway reference should match the pattern: `projects/*/locations/global/gateways/`
	Gateways []string `pulumi:"gateways"`
	// Hostnames define a set of hosts that should match against the HTTP host header to select a HttpRoute to process the request. Hostname is the fully qualified domain name of a network host, as defined by RFC 1123 with the exception that: - IPs are not allowed. - A hostname may be prefixed with a wildcard label (*.). The wildcard label must appear by itself as the first label. Hostname can be "precise" which is a domain name without the terminating dot of a network host (e.g. "foo.example.com") or "wildcard", which is a domain name prefixed with a single wildcard label (e.g. *.example.com). Note that as per RFC1035 and RFC1123, a label must consist of lower case alphanumeric characters or '-', and must start and end with an alphanumeric character. No other punctuation is allowed. The routes associated with a Mesh or Gateways must have unique hostnames. If you attempt to attach multiple routes with conflicting hostnames, the configuration will be rejected. For example, while it is acceptable for routes for the hostnames "*.foo.bar.com" and "*.bar.com" to be associated with the same Mesh (or Gateways under the same scope), it is not possible to associate two routes both with "*.bar.com" or both with "bar.com".
	Hostnames []string `pulumi:"hostnames"`
	// Required. Short name of the HttpRoute resource to be created.
	HttpRouteId string `pulumi:"httpRouteId"`
	// Optional. Set of label tags associated with the HttpRoute resource.
	Labels   map[string]string `pulumi:"labels"`
	Location *string           `pulumi:"location"`
	// Optional. Meshes defines a list of meshes this HttpRoute is attached to, as one of the routing rules to route the requests served by the mesh. Each mesh reference should match the pattern: `projects/*/locations/global/meshes/` The attached Mesh should be of a type SIDECAR
	Meshes []string `pulumi:"meshes"`
	// Name of the HttpRoute resource. It matches pattern `projects/*/locations/global/httpRoutes/http_route_name>`.
	Name    *string `pulumi:"name"`
	Project *string `pulumi:"project"`
	// Rules that define how traffic is routed and handled. Rules will be matched sequentially based on the RouteMatch specified for the rule.
	Rules []HttpRouteRouteRule `pulumi:"rules"`
}

// The set of arguments for constructing a HttpRoute resource.
type HttpRouteArgs struct {
	// Optional. A free-text description of the resource. Max length 1024 characters.
	Description pulumi.StringPtrInput
	// Optional. Gateways defines a list of gateways this HttpRoute is attached to, as one of the routing rules to route the requests served by the gateway. Each gateway reference should match the pattern: `projects/*/locations/global/gateways/`
	Gateways pulumi.StringArrayInput
	// Hostnames define a set of hosts that should match against the HTTP host header to select a HttpRoute to process the request. Hostname is the fully qualified domain name of a network host, as defined by RFC 1123 with the exception that: - IPs are not allowed. - A hostname may be prefixed with a wildcard label (*.). The wildcard label must appear by itself as the first label. Hostname can be "precise" which is a domain name without the terminating dot of a network host (e.g. "foo.example.com") or "wildcard", which is a domain name prefixed with a single wildcard label (e.g. *.example.com). Note that as per RFC1035 and RFC1123, a label must consist of lower case alphanumeric characters or '-', and must start and end with an alphanumeric character. No other punctuation is allowed. The routes associated with a Mesh or Gateways must have unique hostnames. If you attempt to attach multiple routes with conflicting hostnames, the configuration will be rejected. For example, while it is acceptable for routes for the hostnames "*.foo.bar.com" and "*.bar.com" to be associated with the same Mesh (or Gateways under the same scope), it is not possible to associate two routes both with "*.bar.com" or both with "bar.com".
	Hostnames pulumi.StringArrayInput
	// Required. Short name of the HttpRoute resource to be created.
	HttpRouteId pulumi.StringInput
	// Optional. Set of label tags associated with the HttpRoute resource.
	Labels   pulumi.StringMapInput
	Location pulumi.StringPtrInput
	// Optional. Meshes defines a list of meshes this HttpRoute is attached to, as one of the routing rules to route the requests served by the mesh. Each mesh reference should match the pattern: `projects/*/locations/global/meshes/` The attached Mesh should be of a type SIDECAR
	Meshes pulumi.StringArrayInput
	// Name of the HttpRoute resource. It matches pattern `projects/*/locations/global/httpRoutes/http_route_name>`.
	Name    pulumi.StringPtrInput
	Project pulumi.StringPtrInput
	// Rules that define how traffic is routed and handled. Rules will be matched sequentially based on the RouteMatch specified for the rule.
	Rules HttpRouteRouteRuleArrayInput
}

func (HttpRouteArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*httpRouteArgs)(nil)).Elem()
}

type HttpRouteInput interface {
	pulumi.Input

	ToHttpRouteOutput() HttpRouteOutput
	ToHttpRouteOutputWithContext(ctx context.Context) HttpRouteOutput
}

func (*HttpRoute) ElementType() reflect.Type {
	return reflect.TypeOf((**HttpRoute)(nil)).Elem()
}

func (i *HttpRoute) ToHttpRouteOutput() HttpRouteOutput {
	return i.ToHttpRouteOutputWithContext(context.Background())
}

func (i *HttpRoute) ToHttpRouteOutputWithContext(ctx context.Context) HttpRouteOutput {
	return pulumi.ToOutputWithContext(ctx, i).(HttpRouteOutput)
}

type HttpRouteOutput struct{ *pulumi.OutputState }

func (HttpRouteOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**HttpRoute)(nil)).Elem()
}

func (o HttpRouteOutput) ToHttpRouteOutput() HttpRouteOutput {
	return o
}

func (o HttpRouteOutput) ToHttpRouteOutputWithContext(ctx context.Context) HttpRouteOutput {
	return o
}

// The timestamp when the resource was created.
func (o HttpRouteOutput) CreateTime() pulumi.StringOutput {
	return o.ApplyT(func(v *HttpRoute) pulumi.StringOutput { return v.CreateTime }).(pulumi.StringOutput)
}

// Optional. A free-text description of the resource. Max length 1024 characters.
func (o HttpRouteOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v *HttpRoute) pulumi.StringOutput { return v.Description }).(pulumi.StringOutput)
}

// Optional. Gateways defines a list of gateways this HttpRoute is attached to, as one of the routing rules to route the requests served by the gateway. Each gateway reference should match the pattern: `projects/*/locations/global/gateways/`
func (o HttpRouteOutput) Gateways() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *HttpRoute) pulumi.StringArrayOutput { return v.Gateways }).(pulumi.StringArrayOutput)
}

// Hostnames define a set of hosts that should match against the HTTP host header to select a HttpRoute to process the request. Hostname is the fully qualified domain name of a network host, as defined by RFC 1123 with the exception that: - IPs are not allowed. - A hostname may be prefixed with a wildcard label (*.). The wildcard label must appear by itself as the first label. Hostname can be "precise" which is a domain name without the terminating dot of a network host (e.g. "foo.example.com") or "wildcard", which is a domain name prefixed with a single wildcard label (e.g. *.example.com). Note that as per RFC1035 and RFC1123, a label must consist of lower case alphanumeric characters or '-', and must start and end with an alphanumeric character. No other punctuation is allowed. The routes associated with a Mesh or Gateways must have unique hostnames. If you attempt to attach multiple routes with conflicting hostnames, the configuration will be rejected. For example, while it is acceptable for routes for the hostnames "*.foo.bar.com" and "*.bar.com" to be associated with the same Mesh (or Gateways under the same scope), it is not possible to associate two routes both with "*.bar.com" or both with "bar.com".
func (o HttpRouteOutput) Hostnames() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *HttpRoute) pulumi.StringArrayOutput { return v.Hostnames }).(pulumi.StringArrayOutput)
}

// Required. Short name of the HttpRoute resource to be created.
func (o HttpRouteOutput) HttpRouteId() pulumi.StringOutput {
	return o.ApplyT(func(v *HttpRoute) pulumi.StringOutput { return v.HttpRouteId }).(pulumi.StringOutput)
}

// Optional. Set of label tags associated with the HttpRoute resource.
func (o HttpRouteOutput) Labels() pulumi.StringMapOutput {
	return o.ApplyT(func(v *HttpRoute) pulumi.StringMapOutput { return v.Labels }).(pulumi.StringMapOutput)
}

func (o HttpRouteOutput) Location() pulumi.StringOutput {
	return o.ApplyT(func(v *HttpRoute) pulumi.StringOutput { return v.Location }).(pulumi.StringOutput)
}

// Optional. Meshes defines a list of meshes this HttpRoute is attached to, as one of the routing rules to route the requests served by the mesh. Each mesh reference should match the pattern: `projects/*/locations/global/meshes/` The attached Mesh should be of a type SIDECAR
func (o HttpRouteOutput) Meshes() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *HttpRoute) pulumi.StringArrayOutput { return v.Meshes }).(pulumi.StringArrayOutput)
}

// Name of the HttpRoute resource. It matches pattern `projects/*/locations/global/httpRoutes/http_route_name>`.
func (o HttpRouteOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *HttpRoute) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

func (o HttpRouteOutput) Project() pulumi.StringOutput {
	return o.ApplyT(func(v *HttpRoute) pulumi.StringOutput { return v.Project }).(pulumi.StringOutput)
}

// Rules that define how traffic is routed and handled. Rules will be matched sequentially based on the RouteMatch specified for the rule.
func (o HttpRouteOutput) Rules() HttpRouteRouteRuleResponseArrayOutput {
	return o.ApplyT(func(v *HttpRoute) HttpRouteRouteRuleResponseArrayOutput { return v.Rules }).(HttpRouteRouteRuleResponseArrayOutput)
}

// Server-defined URL of this resource
func (o HttpRouteOutput) SelfLink() pulumi.StringOutput {
	return o.ApplyT(func(v *HttpRoute) pulumi.StringOutput { return v.SelfLink }).(pulumi.StringOutput)
}

// The timestamp when the resource was updated.
func (o HttpRouteOutput) UpdateTime() pulumi.StringOutput {
	return o.ApplyT(func(v *HttpRoute) pulumi.StringOutput { return v.UpdateTime }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*HttpRouteInput)(nil)).Elem(), &HttpRoute{})
	pulumi.RegisterOutputType(HttpRouteOutput{})
}
