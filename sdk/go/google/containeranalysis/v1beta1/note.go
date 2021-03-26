// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1beta1

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Creates a new note.
type Note struct {
	pulumi.CustomResourceState
}

// NewNote registers a new resource with the given unique name, arguments, and options.
func NewNote(ctx *pulumi.Context,
	name string, args *NoteArgs, opts ...pulumi.ResourceOption) (*Note, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Parent == nil {
		return nil, errors.New("invalid value for required argument 'Parent'")
	}
	var resource Note
	err := ctx.RegisterResource("google-cloud:containeranalysis/v1beta1:Note", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetNote gets an existing Note resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetNote(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *NoteState, opts ...pulumi.ResourceOption) (*Note, error) {
	var resource Note
	err := ctx.ReadResource("google-cloud:containeranalysis/v1beta1:Note", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Note resources.
type noteState struct {
}

type NoteState struct {
}

func (NoteState) ElementType() reflect.Type {
	return reflect.TypeOf((*noteState)(nil)).Elem()
}

type noteArgs struct {
	// A note describing an attestation role.
	AttestationAuthority *Authority `pulumi:"attestationAuthority"`
	// A note describing a base image.
	BaseImage *Basis `pulumi:"baseImage"`
	// A note describing build provenance for a verifiable build.
	Build *Build `pulumi:"build"`
	// Output only. The time this note was created. This field can be used as a filter in list requests.
	CreateTime *string `pulumi:"createTime"`
	// A note describing something that can be deployed.
	Deployable *Deployable `pulumi:"deployable"`
	// A note describing the initial analysis of a resource.
	Discovery *Discovery `pulumi:"discovery"`
	// Time of expiration for this note. Empty if note does not expire.
	ExpirationTime *string `pulumi:"expirationTime"`
	// A note describing an in-toto link.
	Intoto *InToto `pulumi:"intoto"`
	// Output only. The type of analysis. This field can be used as a filter in list requests.
	Kind *string `pulumi:"kind"`
	// A detailed description of this note.
	LongDescription *string `pulumi:"longDescription"`
	// Output only. The name of the note in the form of `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
	Name *string `pulumi:"name"`
	// Required. The ID to use for this note.
	NoteId *string `pulumi:"noteId"`
	// A note describing a package hosted by various package managers.
	Package *Package `pulumi:"package"`
	// Required. The name of the project in the form of `projects/[PROJECT_ID]`, under which the note is to be created.
	Parent string `pulumi:"parent"`
	// Other notes related to this note.
	RelatedNoteNames []string `pulumi:"relatedNoteNames"`
	// URLs associated with this note.
	RelatedUrl []RelatedUrl `pulumi:"relatedUrl"`
	// A one sentence description of this note.
	ShortDescription *string `pulumi:"shortDescription"`
	// Output only. The time this note was last updated. This field can be used as a filter in list requests.
	UpdateTime *string `pulumi:"updateTime"`
	// A note describing a package vulnerability.
	Vulnerability *Vulnerability `pulumi:"vulnerability"`
}

// The set of arguments for constructing a Note resource.
type NoteArgs struct {
	// A note describing an attestation role.
	AttestationAuthority AuthorityPtrInput
	// A note describing a base image.
	BaseImage BasisPtrInput
	// A note describing build provenance for a verifiable build.
	Build BuildPtrInput
	// Output only. The time this note was created. This field can be used as a filter in list requests.
	CreateTime pulumi.StringPtrInput
	// A note describing something that can be deployed.
	Deployable DeployablePtrInput
	// A note describing the initial analysis of a resource.
	Discovery DiscoveryPtrInput
	// Time of expiration for this note. Empty if note does not expire.
	ExpirationTime pulumi.StringPtrInput
	// A note describing an in-toto link.
	Intoto InTotoPtrInput
	// Output only. The type of analysis. This field can be used as a filter in list requests.
	Kind pulumi.StringPtrInput
	// A detailed description of this note.
	LongDescription pulumi.StringPtrInput
	// Output only. The name of the note in the form of `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
	Name pulumi.StringPtrInput
	// Required. The ID to use for this note.
	NoteId pulumi.StringPtrInput
	// A note describing a package hosted by various package managers.
	Package PackagePtrInput
	// Required. The name of the project in the form of `projects/[PROJECT_ID]`, under which the note is to be created.
	Parent pulumi.StringInput
	// Other notes related to this note.
	RelatedNoteNames pulumi.StringArrayInput
	// URLs associated with this note.
	RelatedUrl RelatedUrlArrayInput
	// A one sentence description of this note.
	ShortDescription pulumi.StringPtrInput
	// Output only. The time this note was last updated. This field can be used as a filter in list requests.
	UpdateTime pulumi.StringPtrInput
	// A note describing a package vulnerability.
	Vulnerability VulnerabilityPtrInput
}

func (NoteArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*noteArgs)(nil)).Elem()
}

type NoteInput interface {
	pulumi.Input

	ToNoteOutput() NoteOutput
	ToNoteOutputWithContext(ctx context.Context) NoteOutput
}

func (*Note) ElementType() reflect.Type {
	return reflect.TypeOf((*Note)(nil))
}

func (i *Note) ToNoteOutput() NoteOutput {
	return i.ToNoteOutputWithContext(context.Background())
}

func (i *Note) ToNoteOutputWithContext(ctx context.Context) NoteOutput {
	return pulumi.ToOutputWithContext(ctx, i).(NoteOutput)
}

type NoteOutput struct {
	*pulumi.OutputState
}

func (NoteOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Note)(nil))
}

func (o NoteOutput) ToNoteOutput() NoteOutput {
	return o
}

func (o NoteOutput) ToNoteOutputWithContext(ctx context.Context) NoteOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(NoteOutput{})
}