// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package beta

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Creates a TargetSslProxy resource in the specified project using the data included in the request.
type TargetSslProxy struct {
	pulumi.CustomResourceState
}

// NewTargetSslProxy registers a new resource with the given unique name, arguments, and options.
func NewTargetSslProxy(ctx *pulumi.Context,
	name string, args *TargetSslProxyArgs, opts ...pulumi.ResourceOption) (*TargetSslProxy, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Project == nil {
		return nil, errors.New("invalid value for required argument 'Project'")
	}
	var resource TargetSslProxy
	err := ctx.RegisterResource("google-cloud:compute/beta:TargetSslProxy", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetTargetSslProxy gets an existing TargetSslProxy resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetTargetSslProxy(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *TargetSslProxyState, opts ...pulumi.ResourceOption) (*TargetSslProxy, error) {
	var resource TargetSslProxy
	err := ctx.ReadResource("google-cloud:compute/beta:TargetSslProxy", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering TargetSslProxy resources.
type targetSslProxyState struct {
}

type TargetSslProxyState struct {
}

func (TargetSslProxyState) ElementType() reflect.Type {
	return reflect.TypeOf((*targetSslProxyState)(nil)).Elem()
}

type targetSslProxyArgs struct {
	// [Output Only] Creation timestamp in RFC3339 text format.
	CreationTimestamp *string `pulumi:"creationTimestamp"`
	// An optional description of this resource. Provide this property when you create the resource.
	Description *string `pulumi:"description"`
	// [Output Only] The unique identifier for the resource. This identifier is defined by the server.
	Id *string `pulumi:"id"`
	// [Output Only] Type of the resource. Always compute#targetSslProxy for target SSL proxies.
	Kind *string `pulumi:"kind"`
	// Name of the resource. Provided by the client when the resource is created. The name must be 1-63 characters long, and comply with RFC1035. Specifically, the name must be 1-63 characters long and match the regular expression `[a-z]([-a-z0-9]*[a-z0-9])?` which means the first character must be a lowercase letter, and all following characters must be a dash, lowercase letter, or digit, except the last character, which cannot be a dash.
	Name *string `pulumi:"name"`
	// Project ID for this request.
	Project string `pulumi:"project"`
	// Specifies the type of proxy header to append before sending data to the backend, either NONE or PROXY_V1. The default is NONE.
	ProxyHeader *string `pulumi:"proxyHeader"`
	// An optional request ID to identify requests. Specify a unique request ID so that if you must retry your request, the server will know to ignore the request if it has already been completed.
	//
	// For example, consider a situation where you make an initial request and the request times out. If you make the request again with the same request ID, the server can check if original operation with the same request ID was received, and if so, will ignore the second request. This prevents clients from accidentally creating duplicate commitments.
	//
	// The request ID must be a valid UUID with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
	RequestId *string `pulumi:"requestId"`
	// [Output Only] Server-defined URL for the resource.
	SelfLink *string `pulumi:"selfLink"`
	// URL to the BackendService resource.
	Service *string `pulumi:"service"`
	// URLs to SslCertificate resources that are used to authenticate connections to Backends. At least one SSL certificate must be specified. Currently, you may specify up to 15 SSL certificates.
	SslCertificates []string `pulumi:"sslCertificates"`
	// URL of SslPolicy resource that will be associated with the TargetSslProxy resource. If not set, the TargetSslProxy resource will not have any SSL policy configured.
	SslPolicy *string `pulumi:"sslPolicy"`
}

// The set of arguments for constructing a TargetSslProxy resource.
type TargetSslProxyArgs struct {
	// [Output Only] Creation timestamp in RFC3339 text format.
	CreationTimestamp pulumi.StringPtrInput
	// An optional description of this resource. Provide this property when you create the resource.
	Description pulumi.StringPtrInput
	// [Output Only] The unique identifier for the resource. This identifier is defined by the server.
	Id pulumi.StringPtrInput
	// [Output Only] Type of the resource. Always compute#targetSslProxy for target SSL proxies.
	Kind pulumi.StringPtrInput
	// Name of the resource. Provided by the client when the resource is created. The name must be 1-63 characters long, and comply with RFC1035. Specifically, the name must be 1-63 characters long and match the regular expression `[a-z]([-a-z0-9]*[a-z0-9])?` which means the first character must be a lowercase letter, and all following characters must be a dash, lowercase letter, or digit, except the last character, which cannot be a dash.
	Name pulumi.StringPtrInput
	// Project ID for this request.
	Project pulumi.StringInput
	// Specifies the type of proxy header to append before sending data to the backend, either NONE or PROXY_V1. The default is NONE.
	ProxyHeader pulumi.StringPtrInput
	// An optional request ID to identify requests. Specify a unique request ID so that if you must retry your request, the server will know to ignore the request if it has already been completed.
	//
	// For example, consider a situation where you make an initial request and the request times out. If you make the request again with the same request ID, the server can check if original operation with the same request ID was received, and if so, will ignore the second request. This prevents clients from accidentally creating duplicate commitments.
	//
	// The request ID must be a valid UUID with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
	RequestId pulumi.StringPtrInput
	// [Output Only] Server-defined URL for the resource.
	SelfLink pulumi.StringPtrInput
	// URL to the BackendService resource.
	Service pulumi.StringPtrInput
	// URLs to SslCertificate resources that are used to authenticate connections to Backends. At least one SSL certificate must be specified. Currently, you may specify up to 15 SSL certificates.
	SslCertificates pulumi.StringArrayInput
	// URL of SslPolicy resource that will be associated with the TargetSslProxy resource. If not set, the TargetSslProxy resource will not have any SSL policy configured.
	SslPolicy pulumi.StringPtrInput
}

func (TargetSslProxyArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*targetSslProxyArgs)(nil)).Elem()
}

type TargetSslProxyInput interface {
	pulumi.Input

	ToTargetSslProxyOutput() TargetSslProxyOutput
	ToTargetSslProxyOutputWithContext(ctx context.Context) TargetSslProxyOutput
}

func (*TargetSslProxy) ElementType() reflect.Type {
	return reflect.TypeOf((*TargetSslProxy)(nil))
}

func (i *TargetSslProxy) ToTargetSslProxyOutput() TargetSslProxyOutput {
	return i.ToTargetSslProxyOutputWithContext(context.Background())
}

func (i *TargetSslProxy) ToTargetSslProxyOutputWithContext(ctx context.Context) TargetSslProxyOutput {
	return pulumi.ToOutputWithContext(ctx, i).(TargetSslProxyOutput)
}

type TargetSslProxyOutput struct {
	*pulumi.OutputState
}

func (TargetSslProxyOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*TargetSslProxy)(nil))
}

func (o TargetSslProxyOutput) ToTargetSslProxyOutput() TargetSslProxyOutput {
	return o
}

func (o TargetSslProxyOutput) ToTargetSslProxyOutputWithContext(ctx context.Context) TargetSslProxyOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(TargetSslProxyOutput{})
}