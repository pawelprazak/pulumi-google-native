// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha1

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Rpc to create a service.
type Service struct {
	pulumi.CustomResourceState

	// The API version for this call such as "serving.knative.dev/v1alpha1".
	ApiVersion pulumi.StringOutput `pulumi:"apiVersion"`
	// The kind of resource, in this case "Service".
	Kind pulumi.StringOutput `pulumi:"kind"`
	// Metadata associated with this Service, including name, namespace, labels, and annotations.
	Metadata ObjectMetaResponseOutput `pulumi:"metadata"`
	// Spec holds the desired state of the Service (from the client).
	Spec ServiceSpecResponseOutput `pulumi:"spec"`
	// Status communicates the observed state of the Service (from the controller).
	Status ServiceStatusResponseOutput `pulumi:"status"`
}

// NewService registers a new resource with the given unique name, arguments, and options.
func NewService(ctx *pulumi.Context,
	name string, args *ServiceArgs, opts ...pulumi.ResourceOption) (*Service, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.LocationsId == nil {
		return nil, errors.New("invalid value for required argument 'LocationsId'")
	}
	if args.ProjectsId == nil {
		return nil, errors.New("invalid value for required argument 'ProjectsId'")
	}
	if args.ServicesId == nil {
		return nil, errors.New("invalid value for required argument 'ServicesId'")
	}
	var resource Service
	err := ctx.RegisterResource("gcp-native:run/v1alpha1:Service", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetService gets an existing Service resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetService(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ServiceState, opts ...pulumi.ResourceOption) (*Service, error) {
	var resource Service
	err := ctx.ReadResource("gcp-native:run/v1alpha1:Service", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Service resources.
type serviceState struct {
	// The API version for this call such as "serving.knative.dev/v1alpha1".
	ApiVersion *string `pulumi:"apiVersion"`
	// The kind of resource, in this case "Service".
	Kind *string `pulumi:"kind"`
	// Metadata associated with this Service, including name, namespace, labels, and annotations.
	Metadata *ObjectMetaResponse `pulumi:"metadata"`
	// Spec holds the desired state of the Service (from the client).
	Spec *ServiceSpecResponse `pulumi:"spec"`
	// Status communicates the observed state of the Service (from the controller).
	Status *ServiceStatusResponse `pulumi:"status"`
}

type ServiceState struct {
	// The API version for this call such as "serving.knative.dev/v1alpha1".
	ApiVersion pulumi.StringPtrInput
	// The kind of resource, in this case "Service".
	Kind pulumi.StringPtrInput
	// Metadata associated with this Service, including name, namespace, labels, and annotations.
	Metadata ObjectMetaResponsePtrInput
	// Spec holds the desired state of the Service (from the client).
	Spec ServiceSpecResponsePtrInput
	// Status communicates the observed state of the Service (from the controller).
	Status ServiceStatusResponsePtrInput
}

func (ServiceState) ElementType() reflect.Type {
	return reflect.TypeOf((*serviceState)(nil)).Elem()
}

type serviceArgs struct {
	// The API version for this call such as "serving.knative.dev/v1alpha1".
	ApiVersion *string `pulumi:"apiVersion"`
	// The kind of resource, in this case "Service".
	Kind        *string `pulumi:"kind"`
	LocationsId string  `pulumi:"locationsId"`
	// Metadata associated with this Service, including name, namespace, labels, and annotations.
	Metadata   *ObjectMeta `pulumi:"metadata"`
	ProjectsId string      `pulumi:"projectsId"`
	ServicesId string      `pulumi:"servicesId"`
	// Spec holds the desired state of the Service (from the client).
	Spec *ServiceSpec `pulumi:"spec"`
	// Status communicates the observed state of the Service (from the controller).
	Status *ServiceStatus `pulumi:"status"`
}

// The set of arguments for constructing a Service resource.
type ServiceArgs struct {
	// The API version for this call such as "serving.knative.dev/v1alpha1".
	ApiVersion pulumi.StringPtrInput
	// The kind of resource, in this case "Service".
	Kind        pulumi.StringPtrInput
	LocationsId pulumi.StringInput
	// Metadata associated with this Service, including name, namespace, labels, and annotations.
	Metadata   ObjectMetaPtrInput
	ProjectsId pulumi.StringInput
	ServicesId pulumi.StringInput
	// Spec holds the desired state of the Service (from the client).
	Spec ServiceSpecPtrInput
	// Status communicates the observed state of the Service (from the controller).
	Status ServiceStatusPtrInput
}

func (ServiceArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*serviceArgs)(nil)).Elem()
}

type ServiceInput interface {
	pulumi.Input

	ToServiceOutput() ServiceOutput
	ToServiceOutputWithContext(ctx context.Context) ServiceOutput
}

func (*Service) ElementType() reflect.Type {
	return reflect.TypeOf((*Service)(nil))
}

func (i *Service) ToServiceOutput() ServiceOutput {
	return i.ToServiceOutputWithContext(context.Background())
}

func (i *Service) ToServiceOutputWithContext(ctx context.Context) ServiceOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ServiceOutput)
}

type ServiceOutput struct {
	*pulumi.OutputState
}

func (ServiceOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Service)(nil))
}

func (o ServiceOutput) ToServiceOutput() ServiceOutput {
	return o
}

func (o ServiceOutput) ToServiceOutputWithContext(ctx context.Context) ServiceOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(ServiceOutput{})
}