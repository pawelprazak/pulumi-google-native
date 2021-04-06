// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Creates a key value map in an api proxy.
type OrganizationApiKeyvaluemap struct {
	pulumi.CustomResourceState
}

// NewOrganizationApiKeyvaluemap registers a new resource with the given unique name, arguments, and options.
func NewOrganizationApiKeyvaluemap(ctx *pulumi.Context,
	name string, args *OrganizationApiKeyvaluemapArgs, opts ...pulumi.ResourceOption) (*OrganizationApiKeyvaluemap, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ApisId == nil {
		return nil, errors.New("invalid value for required argument 'ApisId'")
	}
	if args.KeyvaluemapsId == nil {
		return nil, errors.New("invalid value for required argument 'KeyvaluemapsId'")
	}
	if args.OrganizationsId == nil {
		return nil, errors.New("invalid value for required argument 'OrganizationsId'")
	}
	var resource OrganizationApiKeyvaluemap
	err := ctx.RegisterResource("google-cloud:apigee/v1:OrganizationApiKeyvaluemap", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetOrganizationApiKeyvaluemap gets an existing OrganizationApiKeyvaluemap resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetOrganizationApiKeyvaluemap(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *OrganizationApiKeyvaluemapState, opts ...pulumi.ResourceOption) (*OrganizationApiKeyvaluemap, error) {
	var resource OrganizationApiKeyvaluemap
	err := ctx.ReadResource("google-cloud:apigee/v1:OrganizationApiKeyvaluemap", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering OrganizationApiKeyvaluemap resources.
type organizationApiKeyvaluemapState struct {
}

type OrganizationApiKeyvaluemapState struct {
}

func (OrganizationApiKeyvaluemapState) ElementType() reflect.Type {
	return reflect.TypeOf((*organizationApiKeyvaluemapState)(nil)).Elem()
}

type organizationApiKeyvaluemapArgs struct {
	ApisId string `pulumi:"apisId"`
	// Optional. If `true` entry values will be encrypted.
	Encrypted      *bool  `pulumi:"encrypted"`
	KeyvaluemapsId string `pulumi:"keyvaluemapsId"`
	// Required. The id of the key value map.
	Name            *string `pulumi:"name"`
	OrganizationsId string  `pulumi:"organizationsId"`
}

// The set of arguments for constructing a OrganizationApiKeyvaluemap resource.
type OrganizationApiKeyvaluemapArgs struct {
	ApisId pulumi.StringInput
	// Optional. If `true` entry values will be encrypted.
	Encrypted      pulumi.BoolPtrInput
	KeyvaluemapsId pulumi.StringInput
	// Required. The id of the key value map.
	Name            pulumi.StringPtrInput
	OrganizationsId pulumi.StringInput
}

func (OrganizationApiKeyvaluemapArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*organizationApiKeyvaluemapArgs)(nil)).Elem()
}

type OrganizationApiKeyvaluemapInput interface {
	pulumi.Input

	ToOrganizationApiKeyvaluemapOutput() OrganizationApiKeyvaluemapOutput
	ToOrganizationApiKeyvaluemapOutputWithContext(ctx context.Context) OrganizationApiKeyvaluemapOutput
}

func (*OrganizationApiKeyvaluemap) ElementType() reflect.Type {
	return reflect.TypeOf((*OrganizationApiKeyvaluemap)(nil))
}

func (i *OrganizationApiKeyvaluemap) ToOrganizationApiKeyvaluemapOutput() OrganizationApiKeyvaluemapOutput {
	return i.ToOrganizationApiKeyvaluemapOutputWithContext(context.Background())
}

func (i *OrganizationApiKeyvaluemap) ToOrganizationApiKeyvaluemapOutputWithContext(ctx context.Context) OrganizationApiKeyvaluemapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(OrganizationApiKeyvaluemapOutput)
}

type OrganizationApiKeyvaluemapOutput struct {
	*pulumi.OutputState
}

func (OrganizationApiKeyvaluemapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*OrganizationApiKeyvaluemap)(nil))
}

func (o OrganizationApiKeyvaluemapOutput) ToOrganizationApiKeyvaluemapOutput() OrganizationApiKeyvaluemapOutput {
	return o
}

func (o OrganizationApiKeyvaluemapOutput) ToOrganizationApiKeyvaluemapOutputWithContext(ctx context.Context) OrganizationApiKeyvaluemapOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(OrganizationApiKeyvaluemapOutput{})
}