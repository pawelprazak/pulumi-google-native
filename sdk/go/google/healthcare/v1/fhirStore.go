// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Creates a new FHIR store within the parent dataset.
type FhirStore struct {
	pulumi.CustomResourceState
}

// NewFhirStore registers a new resource with the given unique name, arguments, and options.
func NewFhirStore(ctx *pulumi.Context,
	name string, args *FhirStoreArgs, opts ...pulumi.ResourceOption) (*FhirStore, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Parent == nil {
		return nil, errors.New("invalid value for required argument 'Parent'")
	}
	var resource FhirStore
	err := ctx.RegisterResource("google-cloud:healthcare/v1:FhirStore", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetFhirStore gets an existing FhirStore resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetFhirStore(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *FhirStoreState, opts ...pulumi.ResourceOption) (*FhirStore, error) {
	var resource FhirStore
	err := ctx.ReadResource("google-cloud:healthcare/v1:FhirStore", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering FhirStore resources.
type fhirStoreState struct {
}

type FhirStoreState struct {
}

func (FhirStoreState) ElementType() reflect.Type {
	return reflect.TypeOf((*fhirStoreState)(nil)).Elem()
}

type fhirStoreArgs struct {
	// Immutable. Whether to disable referential integrity in this FHIR store. This field is immutable after FHIR store creation. The default value is false, meaning that the API enforces referential integrity and fails the requests that result in inconsistent state in the FHIR store. When this field is set to true, the API skips referential integrity checks. Consequently, operations that rely on references, such as GetPatientEverything, do not return all the results if broken references exist.
	DisableReferentialIntegrity *bool `pulumi:"disableReferentialIntegrity"`
	// Immutable. Whether to disable resource versioning for this FHIR store. This field can not be changed after the creation of FHIR store. If set to false, which is the default behavior, all write operations cause historical versions to be recorded automatically. The historical versions can be fetched through the history APIs, but cannot be updated. If set to true, no historical versions are kept. The server sends errors for attempts to read the historical versions.
	DisableResourceVersioning *bool `pulumi:"disableResourceVersioning"`
	// Whether this FHIR store has the [updateCreate capability](https://www.hl7.org/fhir/capabilitystatement-definitions.html#CapabilityStatement.rest.resource.updateCreate). This determines if the client can use an Update operation to create a new resource with a client-specified ID. If false, all IDs are server-assigned through the Create operation and attempts to update a non-existent resource return errors. It is strongly advised not to include or encode any sensitive data such as patient identifiers in client-specified resource IDs. Those IDs are part of the FHIR resource path recorded in Cloud audit logs and Cloud Pub/Sub notifications. Those IDs can also be contained in reference fields within other resources.
	EnableUpdateCreate *bool `pulumi:"enableUpdateCreate"`
	// The ID of the FHIR store that is being created. The string must match the following regex: `[\p{L}\p{N}_\-\.]{1,256}`.
	FhirStoreId *string `pulumi:"fhirStoreId"`
	// User-supplied key-value pairs used to organize FHIR stores. Label keys must be between 1 and 63 characters long, have a UTF-8 encoding of maximum 128 bytes, and must conform to the following PCRE regular expression: \p{Ll}\p{Lo}{0,62} Label values are optional, must be between 1 and 63 characters long, have a UTF-8 encoding of maximum 128 bytes, and must conform to the following PCRE regular expression: [\p{Ll}\p{Lo}\p{N}_-]{0,63} No more than 64 labels can be associated with a given store.
	Labels map[string]string `pulumi:"labels"`
	// Output only. Resource name of the FHIR store, of the form `projects/{project_id}/datasets/{dataset_id}/fhirStores/{fhir_store_id}`.
	Name *string `pulumi:"name"`
	// If non-empty, publish all resource modifications of this FHIR store to this destination. The Cloud Pub/Sub message attributes contain a map with a string describing the action that has triggered the notification. For example, "action":"CreateResource".
	NotificationConfig *NotificationConfig `pulumi:"notificationConfig"`
	// The name of the dataset this FHIR store belongs to.
	Parent string `pulumi:"parent"`
	// A list of streaming configs that configure the destinations of streaming export for every resource mutation in this FHIR store. Each store is allowed to have up to 10 streaming configs. After a new config is added, the next resource mutation is streamed to the new location in addition to the existing ones. When a location is removed from the list, the server stops streaming to that location. Before adding a new config, you must add the required [`bigquery.dataEditor`](https://cloud.google.com/bigquery/docs/access-control#bigquery.dataEditor) role to your project's **Cloud Healthcare Service Agent** [service account](https://cloud.google.com/iam/docs/service-accounts). Some lag (typically on the order of dozens of seconds) is expected before the results show up in the streaming destination.
	StreamConfigs []StreamConfig `pulumi:"streamConfigs"`
	// Immutable. The FHIR specification version that this FHIR store supports natively. This field is immutable after store creation. Requests are rejected if they contain FHIR resources of a different version. Version is required for every FHIR store.
	Version *string `pulumi:"version"`
}

// The set of arguments for constructing a FhirStore resource.
type FhirStoreArgs struct {
	// Immutable. Whether to disable referential integrity in this FHIR store. This field is immutable after FHIR store creation. The default value is false, meaning that the API enforces referential integrity and fails the requests that result in inconsistent state in the FHIR store. When this field is set to true, the API skips referential integrity checks. Consequently, operations that rely on references, such as GetPatientEverything, do not return all the results if broken references exist.
	DisableReferentialIntegrity pulumi.BoolPtrInput
	// Immutable. Whether to disable resource versioning for this FHIR store. This field can not be changed after the creation of FHIR store. If set to false, which is the default behavior, all write operations cause historical versions to be recorded automatically. The historical versions can be fetched through the history APIs, but cannot be updated. If set to true, no historical versions are kept. The server sends errors for attempts to read the historical versions.
	DisableResourceVersioning pulumi.BoolPtrInput
	// Whether this FHIR store has the [updateCreate capability](https://www.hl7.org/fhir/capabilitystatement-definitions.html#CapabilityStatement.rest.resource.updateCreate). This determines if the client can use an Update operation to create a new resource with a client-specified ID. If false, all IDs are server-assigned through the Create operation and attempts to update a non-existent resource return errors. It is strongly advised not to include or encode any sensitive data such as patient identifiers in client-specified resource IDs. Those IDs are part of the FHIR resource path recorded in Cloud audit logs and Cloud Pub/Sub notifications. Those IDs can also be contained in reference fields within other resources.
	EnableUpdateCreate pulumi.BoolPtrInput
	// The ID of the FHIR store that is being created. The string must match the following regex: `[\p{L}\p{N}_\-\.]{1,256}`.
	FhirStoreId pulumi.StringPtrInput
	// User-supplied key-value pairs used to organize FHIR stores. Label keys must be between 1 and 63 characters long, have a UTF-8 encoding of maximum 128 bytes, and must conform to the following PCRE regular expression: \p{Ll}\p{Lo}{0,62} Label values are optional, must be between 1 and 63 characters long, have a UTF-8 encoding of maximum 128 bytes, and must conform to the following PCRE regular expression: [\p{Ll}\p{Lo}\p{N}_-]{0,63} No more than 64 labels can be associated with a given store.
	Labels pulumi.StringMapInput
	// Output only. Resource name of the FHIR store, of the form `projects/{project_id}/datasets/{dataset_id}/fhirStores/{fhir_store_id}`.
	Name pulumi.StringPtrInput
	// If non-empty, publish all resource modifications of this FHIR store to this destination. The Cloud Pub/Sub message attributes contain a map with a string describing the action that has triggered the notification. For example, "action":"CreateResource".
	NotificationConfig NotificationConfigPtrInput
	// The name of the dataset this FHIR store belongs to.
	Parent pulumi.StringInput
	// A list of streaming configs that configure the destinations of streaming export for every resource mutation in this FHIR store. Each store is allowed to have up to 10 streaming configs. After a new config is added, the next resource mutation is streamed to the new location in addition to the existing ones. When a location is removed from the list, the server stops streaming to that location. Before adding a new config, you must add the required [`bigquery.dataEditor`](https://cloud.google.com/bigquery/docs/access-control#bigquery.dataEditor) role to your project's **Cloud Healthcare Service Agent** [service account](https://cloud.google.com/iam/docs/service-accounts). Some lag (typically on the order of dozens of seconds) is expected before the results show up in the streaming destination.
	StreamConfigs StreamConfigArrayInput
	// Immutable. The FHIR specification version that this FHIR store supports natively. This field is immutable after store creation. Requests are rejected if they contain FHIR resources of a different version. Version is required for every FHIR store.
	Version pulumi.StringPtrInput
}

func (FhirStoreArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*fhirStoreArgs)(nil)).Elem()
}

type FhirStoreInput interface {
	pulumi.Input

	ToFhirStoreOutput() FhirStoreOutput
	ToFhirStoreOutputWithContext(ctx context.Context) FhirStoreOutput
}

func (*FhirStore) ElementType() reflect.Type {
	return reflect.TypeOf((*FhirStore)(nil))
}

func (i *FhirStore) ToFhirStoreOutput() FhirStoreOutput {
	return i.ToFhirStoreOutputWithContext(context.Background())
}

func (i *FhirStore) ToFhirStoreOutputWithContext(ctx context.Context) FhirStoreOutput {
	return pulumi.ToOutputWithContext(ctx, i).(FhirStoreOutput)
}

type FhirStoreOutput struct {
	*pulumi.OutputState
}

func (FhirStoreOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*FhirStore)(nil))
}

func (o FhirStoreOutput) ToFhirStoreOutput() FhirStoreOutput {
	return o
}

func (o FhirStoreOutput) ToFhirStoreOutputWithContext(ctx context.Context) FhirStoreOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(FhirStoreOutput{})
}