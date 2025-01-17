// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v1beta

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Creates a new realm in a given project and location.
type Realm struct {
	pulumi.CustomResourceState

	// The creation time.
	CreateTime pulumi.StringOutput `pulumi:"createTime"`
	// Human readable description of the realm.
	Description pulumi.StringOutput `pulumi:"description"`
	// Used to perform consistent read-modify-write updates. If not set, a blind "overwrite" update happens.
	Etag pulumi.StringOutput `pulumi:"etag"`
	// The labels associated with this realm. Each label is a key-value pair.
	Labels   pulumi.StringMapOutput `pulumi:"labels"`
	Location pulumi.StringOutput    `pulumi:"location"`
	// The resource name of the realm, in the following form: `projects/{project}/locations/{locationId}/realms/{realmId}`. For example, `projects/my-project/locations/global/realms/my-realm`.
	Name    pulumi.StringOutput `pulumi:"name"`
	Project pulumi.StringOutput `pulumi:"project"`
	// Required. The ID of the realm resource to create.
	RealmId pulumi.StringOutput `pulumi:"realmId"`
	// Time zone where all policies targeting this realm are evaluated. The value of this field must be from the [IANA time zone database](https://www.iana.org/time-zones).
	TimeZone pulumi.StringOutput `pulumi:"timeZone"`
	// The last-modified time.
	UpdateTime pulumi.StringOutput `pulumi:"updateTime"`
}

// NewRealm registers a new resource with the given unique name, arguments, and options.
func NewRealm(ctx *pulumi.Context,
	name string, args *RealmArgs, opts ...pulumi.ResourceOption) (*Realm, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.RealmId == nil {
		return nil, errors.New("invalid value for required argument 'RealmId'")
	}
	if args.TimeZone == nil {
		return nil, errors.New("invalid value for required argument 'TimeZone'")
	}
	var resource Realm
	err := ctx.RegisterResource("google-native:gameservices/v1beta:Realm", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetRealm gets an existing Realm resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetRealm(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *RealmState, opts ...pulumi.ResourceOption) (*Realm, error) {
	var resource Realm
	err := ctx.ReadResource("google-native:gameservices/v1beta:Realm", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Realm resources.
type realmState struct {
}

type RealmState struct {
}

func (RealmState) ElementType() reflect.Type {
	return reflect.TypeOf((*realmState)(nil)).Elem()
}

type realmArgs struct {
	// Human readable description of the realm.
	Description *string `pulumi:"description"`
	// Used to perform consistent read-modify-write updates. If not set, a blind "overwrite" update happens.
	Etag *string `pulumi:"etag"`
	// The labels associated with this realm. Each label is a key-value pair.
	Labels   map[string]string `pulumi:"labels"`
	Location *string           `pulumi:"location"`
	// The resource name of the realm, in the following form: `projects/{project}/locations/{locationId}/realms/{realmId}`. For example, `projects/my-project/locations/global/realms/my-realm`.
	Name    *string `pulumi:"name"`
	Project *string `pulumi:"project"`
	// Required. The ID of the realm resource to create.
	RealmId string `pulumi:"realmId"`
	// Time zone where all policies targeting this realm are evaluated. The value of this field must be from the [IANA time zone database](https://www.iana.org/time-zones).
	TimeZone string `pulumi:"timeZone"`
}

// The set of arguments for constructing a Realm resource.
type RealmArgs struct {
	// Human readable description of the realm.
	Description pulumi.StringPtrInput
	// Used to perform consistent read-modify-write updates. If not set, a blind "overwrite" update happens.
	Etag pulumi.StringPtrInput
	// The labels associated with this realm. Each label is a key-value pair.
	Labels   pulumi.StringMapInput
	Location pulumi.StringPtrInput
	// The resource name of the realm, in the following form: `projects/{project}/locations/{locationId}/realms/{realmId}`. For example, `projects/my-project/locations/global/realms/my-realm`.
	Name    pulumi.StringPtrInput
	Project pulumi.StringPtrInput
	// Required. The ID of the realm resource to create.
	RealmId pulumi.StringInput
	// Time zone where all policies targeting this realm are evaluated. The value of this field must be from the [IANA time zone database](https://www.iana.org/time-zones).
	TimeZone pulumi.StringInput
}

func (RealmArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*realmArgs)(nil)).Elem()
}

type RealmInput interface {
	pulumi.Input

	ToRealmOutput() RealmOutput
	ToRealmOutputWithContext(ctx context.Context) RealmOutput
}

func (*Realm) ElementType() reflect.Type {
	return reflect.TypeOf((**Realm)(nil)).Elem()
}

func (i *Realm) ToRealmOutput() RealmOutput {
	return i.ToRealmOutputWithContext(context.Background())
}

func (i *Realm) ToRealmOutputWithContext(ctx context.Context) RealmOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RealmOutput)
}

type RealmOutput struct{ *pulumi.OutputState }

func (RealmOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**Realm)(nil)).Elem()
}

func (o RealmOutput) ToRealmOutput() RealmOutput {
	return o
}

func (o RealmOutput) ToRealmOutputWithContext(ctx context.Context) RealmOutput {
	return o
}

// The creation time.
func (o RealmOutput) CreateTime() pulumi.StringOutput {
	return o.ApplyT(func(v *Realm) pulumi.StringOutput { return v.CreateTime }).(pulumi.StringOutput)
}

// Human readable description of the realm.
func (o RealmOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v *Realm) pulumi.StringOutput { return v.Description }).(pulumi.StringOutput)
}

// Used to perform consistent read-modify-write updates. If not set, a blind "overwrite" update happens.
func (o RealmOutput) Etag() pulumi.StringOutput {
	return o.ApplyT(func(v *Realm) pulumi.StringOutput { return v.Etag }).(pulumi.StringOutput)
}

// The labels associated with this realm. Each label is a key-value pair.
func (o RealmOutput) Labels() pulumi.StringMapOutput {
	return o.ApplyT(func(v *Realm) pulumi.StringMapOutput { return v.Labels }).(pulumi.StringMapOutput)
}

func (o RealmOutput) Location() pulumi.StringOutput {
	return o.ApplyT(func(v *Realm) pulumi.StringOutput { return v.Location }).(pulumi.StringOutput)
}

// The resource name of the realm, in the following form: `projects/{project}/locations/{locationId}/realms/{realmId}`. For example, `projects/my-project/locations/global/realms/my-realm`.
func (o RealmOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *Realm) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

func (o RealmOutput) Project() pulumi.StringOutput {
	return o.ApplyT(func(v *Realm) pulumi.StringOutput { return v.Project }).(pulumi.StringOutput)
}

// Required. The ID of the realm resource to create.
func (o RealmOutput) RealmId() pulumi.StringOutput {
	return o.ApplyT(func(v *Realm) pulumi.StringOutput { return v.RealmId }).(pulumi.StringOutput)
}

// Time zone where all policies targeting this realm are evaluated. The value of this field must be from the [IANA time zone database](https://www.iana.org/time-zones).
func (o RealmOutput) TimeZone() pulumi.StringOutput {
	return o.ApplyT(func(v *Realm) pulumi.StringOutput { return v.TimeZone }).(pulumi.StringOutput)
}

// The last-modified time.
func (o RealmOutput) UpdateTime() pulumi.StringOutput {
	return o.ApplyT(func(v *Realm) pulumi.StringOutput { return v.UpdateTime }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*RealmInput)(nil)).Elem(), &Realm{})
	pulumi.RegisterOutputType(RealmOutput{})
}
