// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Creates a TargetHttpsProxy resource in the specified project using the data included in the request.
type TargetHttpsProxy struct {
	pulumi.CustomResourceState
}

// NewTargetHttpsProxy registers a new resource with the given unique name, arguments, and options.
func NewTargetHttpsProxy(ctx *pulumi.Context,
	name string, args *TargetHttpsProxyArgs, opts ...pulumi.ResourceOption) (*TargetHttpsProxy, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Project == nil {
		return nil, errors.New("invalid value for required argument 'Project'")
	}
	var resource TargetHttpsProxy
	err := ctx.RegisterResource("google-cloud:compute/v1:TargetHttpsProxy", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetTargetHttpsProxy gets an existing TargetHttpsProxy resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetTargetHttpsProxy(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *TargetHttpsProxyState, opts ...pulumi.ResourceOption) (*TargetHttpsProxy, error) {
	var resource TargetHttpsProxy
	err := ctx.ReadResource("google-cloud:compute/v1:TargetHttpsProxy", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering TargetHttpsProxy resources.
type targetHttpsProxyState struct {
}

type TargetHttpsProxyState struct {
}

func (TargetHttpsProxyState) ElementType() reflect.Type {
	return reflect.TypeOf((*targetHttpsProxyState)(nil)).Elem()
}

type targetHttpsProxyArgs struct {
	// Optional. A URL referring to a networksecurity.AuthorizationPolicy resource that describes how the proxy should authorize inbound traffic. If left blank, access will not be restricted by an authorization policy.
	// Refer to the AuthorizationPolicy resource for additional details.
	// authorizationPolicy only applies to a global TargetHttpsProxy attached to globalForwardingRules with the loadBalancingScheme set to INTERNAL_SELF_MANAGED.
	// Note: This field currently has no impact.
	AuthorizationPolicy *string `pulumi:"authorizationPolicy"`
	// [Output Only] Creation timestamp in RFC3339 text format.
	CreationTimestamp *string `pulumi:"creationTimestamp"`
	// An optional description of this resource. Provide this property when you create the resource.
	Description *string `pulumi:"description"`
	// Fingerprint of this resource. A hash of the contents stored in this object. This field is used in optimistic locking. This field will be ignored when inserting a TargetHttpsProxy. An up-to-date fingerprint must be provided in order to patch the TargetHttpsProxy; otherwise, the request will fail with error 412 conditionNotMet. To see the latest fingerprint, make a get() request to retrieve the TargetHttpsProxy.
	Fingerprint *string `pulumi:"fingerprint"`
	// [Output Only] The unique identifier for the resource. This identifier is defined by the server.
	Id *string `pulumi:"id"`
	// [Output Only] Type of resource. Always compute#targetHttpsProxy for target HTTPS proxies.
	Kind *string `pulumi:"kind"`
	// Name of the resource. Provided by the client when the resource is created. The name must be 1-63 characters long, and comply with RFC1035. Specifically, the name must be 1-63 characters long and match the regular expression `[a-z]([-a-z0-9]*[a-z0-9])?` which means the first character must be a lowercase letter, and all following characters must be a dash, lowercase letter, or digit, except the last character, which cannot be a dash.
	Name *string `pulumi:"name"`
	// Project ID for this request.
	Project string `pulumi:"project"`
	// This field only applies when the forwarding rule that references this target proxy has a loadBalancingScheme set to INTERNAL_SELF_MANAGED.
	//
	// When this field is set to true, Envoy proxies set up inbound traffic interception and bind to the IP address and port specified in the forwarding rule. This is generally useful when using Traffic Director to configure Envoy as a gateway or middle proxy (in other words, not a sidecar proxy). The Envoy proxy listens for inbound requests and handles requests when it receives them.
	//
	// The default is false.
	ProxyBind *bool `pulumi:"proxyBind"`
	// Specifies the QUIC override policy for this TargetHttpsProxy resource. This setting determines whether the load balancer attempts to negotiate QUIC with clients. You can specify NONE, ENABLE, or DISABLE.
	// - When quic-override is set to NONE, Google manages whether QUIC is used.
	// - When quic-override is set to ENABLE, the load balancer uses QUIC when possible.
	// - When quic-override is set to DISABLE, the load balancer doesn't use QUIC.
	// - If the quic-override flag is not specified, NONE is implied.
	QuicOverride *string `pulumi:"quicOverride"`
	// [Output Only] URL of the region where the regional TargetHttpsProxy resides. This field is not applicable to global TargetHttpsProxies.
	Region *string `pulumi:"region"`
	// An optional request ID to identify requests. Specify a unique request ID so that if you must retry your request, the server will know to ignore the request if it has already been completed.
	//
	// For example, consider a situation where you make an initial request and the request times out. If you make the request again with the same request ID, the server can check if original operation with the same request ID was received, and if so, will ignore the second request. This prevents clients from accidentally creating duplicate commitments.
	//
	// The request ID must be a valid UUID with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
	RequestId *string `pulumi:"requestId"`
	// [Output Only] Server-defined URL for the resource.
	SelfLink *string `pulumi:"selfLink"`
	// Optional. A URL referring to a networksecurity.ServerTlsPolicy resource that describes how the proxy should authenticate inbound traffic.
	// serverTlsPolicy only applies to a global TargetHttpsProxy attached to globalForwardingRules with the loadBalancingScheme set to INTERNAL_SELF_MANAGED.
	// If left blank, communications are not encrypted.
	// Note: This field currently has no impact.
	ServerTlsPolicy *string `pulumi:"serverTlsPolicy"`
	// URLs to SslCertificate resources that are used to authenticate connections between users and the load balancer. At least one SSL certificate must be specified. Currently, you may specify up to 15 SSL certificates.
	SslCertificates []string `pulumi:"sslCertificates"`
	// URL of SslPolicy resource that will be associated with the TargetHttpsProxy resource. If not set, the TargetHttpsProxy resource has no SSL policy configured.
	SslPolicy *string `pulumi:"sslPolicy"`
	// A fully-qualified or valid partial URL to the UrlMap resource that defines the mapping from URL to the BackendService. For example, the following are all valid URLs for specifying a URL map:
	// - https://www.googleapis.compute/v1/projects/project/global/urlMaps/url-map
	// - projects/project/global/urlMaps/url-map
	// - global/urlMaps/url-map
	UrlMap *string `pulumi:"urlMap"`
}

// The set of arguments for constructing a TargetHttpsProxy resource.
type TargetHttpsProxyArgs struct {
	// Optional. A URL referring to a networksecurity.AuthorizationPolicy resource that describes how the proxy should authorize inbound traffic. If left blank, access will not be restricted by an authorization policy.
	// Refer to the AuthorizationPolicy resource for additional details.
	// authorizationPolicy only applies to a global TargetHttpsProxy attached to globalForwardingRules with the loadBalancingScheme set to INTERNAL_SELF_MANAGED.
	// Note: This field currently has no impact.
	AuthorizationPolicy pulumi.StringPtrInput
	// [Output Only] Creation timestamp in RFC3339 text format.
	CreationTimestamp pulumi.StringPtrInput
	// An optional description of this resource. Provide this property when you create the resource.
	Description pulumi.StringPtrInput
	// Fingerprint of this resource. A hash of the contents stored in this object. This field is used in optimistic locking. This field will be ignored when inserting a TargetHttpsProxy. An up-to-date fingerprint must be provided in order to patch the TargetHttpsProxy; otherwise, the request will fail with error 412 conditionNotMet. To see the latest fingerprint, make a get() request to retrieve the TargetHttpsProxy.
	Fingerprint pulumi.StringPtrInput
	// [Output Only] The unique identifier for the resource. This identifier is defined by the server.
	Id pulumi.StringPtrInput
	// [Output Only] Type of resource. Always compute#targetHttpsProxy for target HTTPS proxies.
	Kind pulumi.StringPtrInput
	// Name of the resource. Provided by the client when the resource is created. The name must be 1-63 characters long, and comply with RFC1035. Specifically, the name must be 1-63 characters long and match the regular expression `[a-z]([-a-z0-9]*[a-z0-9])?` which means the first character must be a lowercase letter, and all following characters must be a dash, lowercase letter, or digit, except the last character, which cannot be a dash.
	Name pulumi.StringPtrInput
	// Project ID for this request.
	Project pulumi.StringInput
	// This field only applies when the forwarding rule that references this target proxy has a loadBalancingScheme set to INTERNAL_SELF_MANAGED.
	//
	// When this field is set to true, Envoy proxies set up inbound traffic interception and bind to the IP address and port specified in the forwarding rule. This is generally useful when using Traffic Director to configure Envoy as a gateway or middle proxy (in other words, not a sidecar proxy). The Envoy proxy listens for inbound requests and handles requests when it receives them.
	//
	// The default is false.
	ProxyBind pulumi.BoolPtrInput
	// Specifies the QUIC override policy for this TargetHttpsProxy resource. This setting determines whether the load balancer attempts to negotiate QUIC with clients. You can specify NONE, ENABLE, or DISABLE.
	// - When quic-override is set to NONE, Google manages whether QUIC is used.
	// - When quic-override is set to ENABLE, the load balancer uses QUIC when possible.
	// - When quic-override is set to DISABLE, the load balancer doesn't use QUIC.
	// - If the quic-override flag is not specified, NONE is implied.
	QuicOverride pulumi.StringPtrInput
	// [Output Only] URL of the region where the regional TargetHttpsProxy resides. This field is not applicable to global TargetHttpsProxies.
	Region pulumi.StringPtrInput
	// An optional request ID to identify requests. Specify a unique request ID so that if you must retry your request, the server will know to ignore the request if it has already been completed.
	//
	// For example, consider a situation where you make an initial request and the request times out. If you make the request again with the same request ID, the server can check if original operation with the same request ID was received, and if so, will ignore the second request. This prevents clients from accidentally creating duplicate commitments.
	//
	// The request ID must be a valid UUID with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
	RequestId pulumi.StringPtrInput
	// [Output Only] Server-defined URL for the resource.
	SelfLink pulumi.StringPtrInput
	// Optional. A URL referring to a networksecurity.ServerTlsPolicy resource that describes how the proxy should authenticate inbound traffic.
	// serverTlsPolicy only applies to a global TargetHttpsProxy attached to globalForwardingRules with the loadBalancingScheme set to INTERNAL_SELF_MANAGED.
	// If left blank, communications are not encrypted.
	// Note: This field currently has no impact.
	ServerTlsPolicy pulumi.StringPtrInput
	// URLs to SslCertificate resources that are used to authenticate connections between users and the load balancer. At least one SSL certificate must be specified. Currently, you may specify up to 15 SSL certificates.
	SslCertificates pulumi.StringArrayInput
	// URL of SslPolicy resource that will be associated with the TargetHttpsProxy resource. If not set, the TargetHttpsProxy resource has no SSL policy configured.
	SslPolicy pulumi.StringPtrInput
	// A fully-qualified or valid partial URL to the UrlMap resource that defines the mapping from URL to the BackendService. For example, the following are all valid URLs for specifying a URL map:
	// - https://www.googleapis.compute/v1/projects/project/global/urlMaps/url-map
	// - projects/project/global/urlMaps/url-map
	// - global/urlMaps/url-map
	UrlMap pulumi.StringPtrInput
}

func (TargetHttpsProxyArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*targetHttpsProxyArgs)(nil)).Elem()
}

type TargetHttpsProxyInput interface {
	pulumi.Input

	ToTargetHttpsProxyOutput() TargetHttpsProxyOutput
	ToTargetHttpsProxyOutputWithContext(ctx context.Context) TargetHttpsProxyOutput
}

func (*TargetHttpsProxy) ElementType() reflect.Type {
	return reflect.TypeOf((*TargetHttpsProxy)(nil))
}

func (i *TargetHttpsProxy) ToTargetHttpsProxyOutput() TargetHttpsProxyOutput {
	return i.ToTargetHttpsProxyOutputWithContext(context.Background())
}

func (i *TargetHttpsProxy) ToTargetHttpsProxyOutputWithContext(ctx context.Context) TargetHttpsProxyOutput {
	return pulumi.ToOutputWithContext(ctx, i).(TargetHttpsProxyOutput)
}

type TargetHttpsProxyOutput struct {
	*pulumi.OutputState
}

func (TargetHttpsProxyOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*TargetHttpsProxy)(nil))
}

func (o TargetHttpsProxyOutput) ToTargetHttpsProxyOutput() TargetHttpsProxyOutput {
	return o
}

func (o TargetHttpsProxyOutput) ToTargetHttpsProxyOutputWithContext(ctx context.Context) TargetHttpsProxyOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(TargetHttpsProxyOutput{})
}