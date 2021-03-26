// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Creates a new session. A session can be used to perform transactions that read and/or modify data in a Cloud Spanner database. Sessions are meant to be reused for many consecutive transactions. Sessions can only execute one transaction at a time. To execute multiple concurrent read-write/write-only transactions, create multiple sessions. Note that standalone reads and queries use a transaction internally, and count toward the one transaction limit. Active sessions use additional server resources, so it is a good idea to delete idle and unneeded sessions. Aside from explicit deletes, Cloud Spanner may delete sessions for which no operations are sent for more than an hour. If a session is deleted, requests to it return `NOT_FOUND`. Idle sessions can be kept alive by sending a trivial SQL query periodically, e.g., `"SELECT 1"`.
type Session struct {
	pulumi.CustomResourceState
}

// NewSession registers a new resource with the given unique name, arguments, and options.
func NewSession(ctx *pulumi.Context,
	name string, args *SessionArgs, opts ...pulumi.ResourceOption) (*Session, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Database == nil {
		return nil, errors.New("invalid value for required argument 'Database'")
	}
	var resource Session
	err := ctx.RegisterResource("google-cloud:spanner/v1:Session", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetSession gets an existing Session resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSession(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *SessionState, opts ...pulumi.ResourceOption) (*Session, error) {
	var resource Session
	err := ctx.ReadResource("google-cloud:spanner/v1:Session", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Session resources.
type sessionState struct {
}

type SessionState struct {
}

func (SessionState) ElementType() reflect.Type {
	return reflect.TypeOf((*sessionState)(nil)).Elem()
}

type sessionArgs struct {
	// Required. The database in which the new session is created.
	Database string `pulumi:"database"`
	// Required. The session to create.
	Session *SessionType `pulumi:"session"`
}

// The set of arguments for constructing a Session resource.
type SessionArgs struct {
	// Required. The database in which the new session is created.
	Database pulumi.StringInput
	// Required. The session to create.
	Session SessionTypePtrInput
}

func (SessionArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*sessionArgs)(nil)).Elem()
}

type SessionInput interface {
	pulumi.Input

	ToSessionOutput() SessionOutput
	ToSessionOutputWithContext(ctx context.Context) SessionOutput
}

func (*Session) ElementType() reflect.Type {
	return reflect.TypeOf((*Session)(nil))
}

func (i *Session) ToSessionOutput() SessionOutput {
	return i.ToSessionOutputWithContext(context.Background())
}

func (i *Session) ToSessionOutputWithContext(ctx context.Context) SessionOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SessionOutput)
}

type SessionOutput struct {
	*pulumi.OutputState
}

func (SessionOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Session)(nil))
}

func (o SessionOutput) ToSessionOutput() SessionOutput {
	return o
}

func (o SessionOutput) ToSessionOutputWithContext(ctx context.Context) SessionOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(SessionOutput{})
}