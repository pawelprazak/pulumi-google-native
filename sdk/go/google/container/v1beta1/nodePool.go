// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1beta1

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Creates a node pool for a cluster.
type NodePool struct {
	pulumi.CustomResourceState
}

// NewNodePool registers a new resource with the given unique name, arguments, and options.
func NewNodePool(ctx *pulumi.Context,
	name string, args *NodePoolArgs, opts ...pulumi.ResourceOption) (*NodePool, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ClusterId == nil {
		return nil, errors.New("invalid value for required argument 'ClusterId'")
	}
	if args.ProjectId == nil {
		return nil, errors.New("invalid value for required argument 'ProjectId'")
	}
	if args.Zone == nil {
		return nil, errors.New("invalid value for required argument 'Zone'")
	}
	var resource NodePool
	err := ctx.RegisterResource("google-cloud:container/v1beta1:NodePool", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetNodePool gets an existing NodePool resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetNodePool(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *NodePoolState, opts ...pulumi.ResourceOption) (*NodePool, error) {
	var resource NodePool
	err := ctx.ReadResource("google-cloud:container/v1beta1:NodePool", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering NodePool resources.
type nodePoolState struct {
}

type NodePoolState struct {
}

func (NodePoolState) ElementType() reflect.Type {
	return reflect.TypeOf((*nodePoolState)(nil)).Elem()
}

type nodePoolArgs struct {
	// Required. Deprecated. The name of the cluster. This field has been deprecated and replaced by the parent field.
	ClusterId string `pulumi:"clusterId"`
	// Required. The node pool to create.
	NodePool *NodePoolType `pulumi:"nodePool"`
	// The parent (project, location, cluster id) where the node pool will be created. Specified in the format `projects/*/locations/*/clusters/*`.
	Parent *string `pulumi:"parent"`
	// Required. Deprecated. The Google Developers Console [project ID or project number](https://developers.google.com/console/help/new/#projectnumber). This field has been deprecated and replaced by the parent field.
	ProjectId string `pulumi:"projectId"`
	// Required. Deprecated. The name of the Google Compute Engine [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides. This field has been deprecated and replaced by the parent field.
	Zone string `pulumi:"zone"`
}

// The set of arguments for constructing a NodePool resource.
type NodePoolArgs struct {
	// Required. Deprecated. The name of the cluster. This field has been deprecated and replaced by the parent field.
	ClusterId pulumi.StringInput
	// Required. The node pool to create.
	NodePool NodePoolTypePtrInput
	// The parent (project, location, cluster id) where the node pool will be created. Specified in the format `projects/*/locations/*/clusters/*`.
	Parent pulumi.StringPtrInput
	// Required. Deprecated. The Google Developers Console [project ID or project number](https://developers.google.com/console/help/new/#projectnumber). This field has been deprecated and replaced by the parent field.
	ProjectId pulumi.StringInput
	// Required. Deprecated. The name of the Google Compute Engine [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides. This field has been deprecated and replaced by the parent field.
	Zone pulumi.StringInput
}

func (NodePoolArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*nodePoolArgs)(nil)).Elem()
}

type NodePoolInput interface {
	pulumi.Input

	ToNodePoolOutput() NodePoolOutput
	ToNodePoolOutputWithContext(ctx context.Context) NodePoolOutput
}

func (*NodePool) ElementType() reflect.Type {
	return reflect.TypeOf((*NodePool)(nil))
}

func (i *NodePool) ToNodePoolOutput() NodePoolOutput {
	return i.ToNodePoolOutputWithContext(context.Background())
}

func (i *NodePool) ToNodePoolOutputWithContext(ctx context.Context) NodePoolOutput {
	return pulumi.ToOutputWithContext(ctx, i).(NodePoolOutput)
}

type NodePoolOutput struct {
	*pulumi.OutputState
}

func (NodePoolOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*NodePool)(nil))
}

func (o NodePoolOutput) ToNodePoolOutput() NodePoolOutput {
	return o
}

func (o NodePoolOutput) ToNodePoolOutputWithContext(ctx context.Context) NodePoolOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(NodePoolOutput{})
}