// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v1

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Create a new Certificate in a given Project, Location from a particular CaPool.
// Auto-naming is currently not supported for this resource.
// Note - this resource's API doesn't support deletion. When deleted, the resource will persist
// on Google Cloud even though it will be deleted from Pulumi state.
type Certificate struct {
	pulumi.CustomResourceState

	CaPoolId pulumi.StringOutput `pulumi:"caPoolId"`
	// A structured description of the issued X.509 certificate.
	CertificateDescription CertificateDescriptionResponseOutput `pulumi:"certificateDescription"`
	// Optional. It must be unique within a location and match the regular expression `[a-zA-Z0-9_-]{1,63}`. This field is required when using a CertificateAuthority in the Enterprise CertificateAuthority.Tier, but is optional and its value is ignored otherwise.
	CertificateId pulumi.StringPtrOutput `pulumi:"certificateId"`
	// Immutable. The resource name for a CertificateTemplate used to issue this certificate, in the format `projects/*/locations/*/certificateTemplates/*`. If this is specified, the caller must have the necessary permission to use this template. If this is omitted, no template will be used. This template must be in the same location as the Certificate.
	CertificateTemplate pulumi.StringOutput `pulumi:"certificateTemplate"`
	// Immutable. A description of the certificate and key that does not require X.509 or ASN.1.
	Config CertificateConfigResponseOutput `pulumi:"config"`
	// The time at which this Certificate was created.
	CreateTime pulumi.StringOutput `pulumi:"createTime"`
	// The resource name of the issuing CertificateAuthority in the format `projects/*/locations/*/caPools/*/certificateAuthorities/*`.
	IssuerCertificateAuthority pulumi.StringOutput `pulumi:"issuerCertificateAuthority"`
	// Optional. The resource ID of the CertificateAuthority that should issue the certificate. This optional field will ignore the load-balancing scheme of the Pool and directly issue the certificate from the CA with the specified ID, contained in the same CaPool referenced by `parent`. Per-CA quota rules apply. If left empty, a CertificateAuthority will be chosen from the CaPool by the service. For example, to issue a Certificate from a Certificate Authority with resource name "projects/my-project/locations/us-central1/caPools/my-pool/certificateAuthorities/my-ca", you can set the parent to "projects/my-project/locations/us-central1/caPools/my-pool" and the issuing_certificate_authority_id to "my-ca".
	IssuingCertificateAuthorityId pulumi.StringPtrOutput `pulumi:"issuingCertificateAuthorityId"`
	// Optional. Labels with user-defined metadata.
	Labels pulumi.StringMapOutput `pulumi:"labels"`
	// Immutable. The desired lifetime of a certificate. Used to create the "not_before_time" and "not_after_time" fields inside an X.509 certificate. Note that the lifetime may be truncated if it would extend past the life of any certificate authority in the issuing chain.
	Lifetime pulumi.StringOutput `pulumi:"lifetime"`
	Location pulumi.StringOutput `pulumi:"location"`
	// The resource name for this Certificate in the format `projects/*/locations/*/caPools/*/certificates/*`.
	Name pulumi.StringOutput `pulumi:"name"`
	// The pem-encoded, signed X.509 certificate.
	PemCertificate pulumi.StringOutput `pulumi:"pemCertificate"`
	// The chain that may be used to verify the X.509 certificate. Expected to be in issuer-to-root order according to RFC 5246.
	PemCertificateChain pulumi.StringArrayOutput `pulumi:"pemCertificateChain"`
	// Immutable. A pem-encoded X.509 certificate signing request (CSR).
	PemCsr  pulumi.StringOutput `pulumi:"pemCsr"`
	Project pulumi.StringOutput `pulumi:"project"`
	// Optional. An ID to identify requests. Specify a unique request ID so that if you must retry your request, the server will know to ignore the request if it has already been completed. The server will guarantee that for at least 60 minutes since the first request. For example, consider a situation where you make an initial request and the request times out. If you make the request again with the same request ID, the server can check if original operation with the same request ID was received, and if so, will ignore the second request. This prevents clients from accidentally creating duplicate commitments. The request ID must be a valid UUID with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
	RequestId pulumi.StringPtrOutput `pulumi:"requestId"`
	// Details regarding the revocation of this Certificate. This Certificate is considered revoked if and only if this field is present.
	RevocationDetails RevocationDetailsResponseOutput `pulumi:"revocationDetails"`
	// Immutable. Specifies how the Certificate's identity fields are to be decided. If this is omitted, the `DEFAULT` subject mode will be used.
	SubjectMode pulumi.StringOutput `pulumi:"subjectMode"`
	// The time at which this Certificate was updated.
	UpdateTime pulumi.StringOutput `pulumi:"updateTime"`
	// Optional. If this is true, no Certificate resource will be persisted regardless of the CaPool's tier, and the returned Certificate will not contain the pem_certificate field.
	ValidateOnly pulumi.StringPtrOutput `pulumi:"validateOnly"`
}

// NewCertificate registers a new resource with the given unique name, arguments, and options.
func NewCertificate(ctx *pulumi.Context,
	name string, args *CertificateArgs, opts ...pulumi.ResourceOption) (*Certificate, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.CaPoolId == nil {
		return nil, errors.New("invalid value for required argument 'CaPoolId'")
	}
	if args.Lifetime == nil {
		return nil, errors.New("invalid value for required argument 'Lifetime'")
	}
	var resource Certificate
	err := ctx.RegisterResource("google-native:privateca/v1:Certificate", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetCertificate gets an existing Certificate resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetCertificate(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *CertificateState, opts ...pulumi.ResourceOption) (*Certificate, error) {
	var resource Certificate
	err := ctx.ReadResource("google-native:privateca/v1:Certificate", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Certificate resources.
type certificateState struct {
}

type CertificateState struct {
}

func (CertificateState) ElementType() reflect.Type {
	return reflect.TypeOf((*certificateState)(nil)).Elem()
}

type certificateArgs struct {
	CaPoolId string `pulumi:"caPoolId"`
	// Optional. It must be unique within a location and match the regular expression `[a-zA-Z0-9_-]{1,63}`. This field is required when using a CertificateAuthority in the Enterprise CertificateAuthority.Tier, but is optional and its value is ignored otherwise.
	CertificateId *string `pulumi:"certificateId"`
	// Immutable. The resource name for a CertificateTemplate used to issue this certificate, in the format `projects/*/locations/*/certificateTemplates/*`. If this is specified, the caller must have the necessary permission to use this template. If this is omitted, no template will be used. This template must be in the same location as the Certificate.
	CertificateTemplate *string `pulumi:"certificateTemplate"`
	// Immutable. A description of the certificate and key that does not require X.509 or ASN.1.
	Config *CertificateConfig `pulumi:"config"`
	// Optional. The resource ID of the CertificateAuthority that should issue the certificate. This optional field will ignore the load-balancing scheme of the Pool and directly issue the certificate from the CA with the specified ID, contained in the same CaPool referenced by `parent`. Per-CA quota rules apply. If left empty, a CertificateAuthority will be chosen from the CaPool by the service. For example, to issue a Certificate from a Certificate Authority with resource name "projects/my-project/locations/us-central1/caPools/my-pool/certificateAuthorities/my-ca", you can set the parent to "projects/my-project/locations/us-central1/caPools/my-pool" and the issuing_certificate_authority_id to "my-ca".
	IssuingCertificateAuthorityId *string `pulumi:"issuingCertificateAuthorityId"`
	// Optional. Labels with user-defined metadata.
	Labels map[string]string `pulumi:"labels"`
	// Immutable. The desired lifetime of a certificate. Used to create the "not_before_time" and "not_after_time" fields inside an X.509 certificate. Note that the lifetime may be truncated if it would extend past the life of any certificate authority in the issuing chain.
	Lifetime string  `pulumi:"lifetime"`
	Location *string `pulumi:"location"`
	// Immutable. A pem-encoded X.509 certificate signing request (CSR).
	PemCsr  *string `pulumi:"pemCsr"`
	Project *string `pulumi:"project"`
	// Optional. An ID to identify requests. Specify a unique request ID so that if you must retry your request, the server will know to ignore the request if it has already been completed. The server will guarantee that for at least 60 minutes since the first request. For example, consider a situation where you make an initial request and the request times out. If you make the request again with the same request ID, the server can check if original operation with the same request ID was received, and if so, will ignore the second request. This prevents clients from accidentally creating duplicate commitments. The request ID must be a valid UUID with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
	RequestId *string `pulumi:"requestId"`
	// Immutable. Specifies how the Certificate's identity fields are to be decided. If this is omitted, the `DEFAULT` subject mode will be used.
	SubjectMode *CertificateSubjectMode `pulumi:"subjectMode"`
	// Optional. If this is true, no Certificate resource will be persisted regardless of the CaPool's tier, and the returned Certificate will not contain the pem_certificate field.
	ValidateOnly *string `pulumi:"validateOnly"`
}

// The set of arguments for constructing a Certificate resource.
type CertificateArgs struct {
	CaPoolId pulumi.StringInput
	// Optional. It must be unique within a location and match the regular expression `[a-zA-Z0-9_-]{1,63}`. This field is required when using a CertificateAuthority in the Enterprise CertificateAuthority.Tier, but is optional and its value is ignored otherwise.
	CertificateId pulumi.StringPtrInput
	// Immutable. The resource name for a CertificateTemplate used to issue this certificate, in the format `projects/*/locations/*/certificateTemplates/*`. If this is specified, the caller must have the necessary permission to use this template. If this is omitted, no template will be used. This template must be in the same location as the Certificate.
	CertificateTemplate pulumi.StringPtrInput
	// Immutable. A description of the certificate and key that does not require X.509 or ASN.1.
	Config CertificateConfigPtrInput
	// Optional. The resource ID of the CertificateAuthority that should issue the certificate. This optional field will ignore the load-balancing scheme of the Pool and directly issue the certificate from the CA with the specified ID, contained in the same CaPool referenced by `parent`. Per-CA quota rules apply. If left empty, a CertificateAuthority will be chosen from the CaPool by the service. For example, to issue a Certificate from a Certificate Authority with resource name "projects/my-project/locations/us-central1/caPools/my-pool/certificateAuthorities/my-ca", you can set the parent to "projects/my-project/locations/us-central1/caPools/my-pool" and the issuing_certificate_authority_id to "my-ca".
	IssuingCertificateAuthorityId pulumi.StringPtrInput
	// Optional. Labels with user-defined metadata.
	Labels pulumi.StringMapInput
	// Immutable. The desired lifetime of a certificate. Used to create the "not_before_time" and "not_after_time" fields inside an X.509 certificate. Note that the lifetime may be truncated if it would extend past the life of any certificate authority in the issuing chain.
	Lifetime pulumi.StringInput
	Location pulumi.StringPtrInput
	// Immutable. A pem-encoded X.509 certificate signing request (CSR).
	PemCsr  pulumi.StringPtrInput
	Project pulumi.StringPtrInput
	// Optional. An ID to identify requests. Specify a unique request ID so that if you must retry your request, the server will know to ignore the request if it has already been completed. The server will guarantee that for at least 60 minutes since the first request. For example, consider a situation where you make an initial request and the request times out. If you make the request again with the same request ID, the server can check if original operation with the same request ID was received, and if so, will ignore the second request. This prevents clients from accidentally creating duplicate commitments. The request ID must be a valid UUID with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
	RequestId pulumi.StringPtrInput
	// Immutable. Specifies how the Certificate's identity fields are to be decided. If this is omitted, the `DEFAULT` subject mode will be used.
	SubjectMode CertificateSubjectModePtrInput
	// Optional. If this is true, no Certificate resource will be persisted regardless of the CaPool's tier, and the returned Certificate will not contain the pem_certificate field.
	ValidateOnly pulumi.StringPtrInput
}

func (CertificateArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*certificateArgs)(nil)).Elem()
}

type CertificateInput interface {
	pulumi.Input

	ToCertificateOutput() CertificateOutput
	ToCertificateOutputWithContext(ctx context.Context) CertificateOutput
}

func (*Certificate) ElementType() reflect.Type {
	return reflect.TypeOf((**Certificate)(nil)).Elem()
}

func (i *Certificate) ToCertificateOutput() CertificateOutput {
	return i.ToCertificateOutputWithContext(context.Background())
}

func (i *Certificate) ToCertificateOutputWithContext(ctx context.Context) CertificateOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CertificateOutput)
}

type CertificateOutput struct{ *pulumi.OutputState }

func (CertificateOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**Certificate)(nil)).Elem()
}

func (o CertificateOutput) ToCertificateOutput() CertificateOutput {
	return o
}

func (o CertificateOutput) ToCertificateOutputWithContext(ctx context.Context) CertificateOutput {
	return o
}

func (o CertificateOutput) CaPoolId() pulumi.StringOutput {
	return o.ApplyT(func(v *Certificate) pulumi.StringOutput { return v.CaPoolId }).(pulumi.StringOutput)
}

// A structured description of the issued X.509 certificate.
func (o CertificateOutput) CertificateDescription() CertificateDescriptionResponseOutput {
	return o.ApplyT(func(v *Certificate) CertificateDescriptionResponseOutput { return v.CertificateDescription }).(CertificateDescriptionResponseOutput)
}

// Optional. It must be unique within a location and match the regular expression `[a-zA-Z0-9_-]{1,63}`. This field is required when using a CertificateAuthority in the Enterprise CertificateAuthority.Tier, but is optional and its value is ignored otherwise.
func (o CertificateOutput) CertificateId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Certificate) pulumi.StringPtrOutput { return v.CertificateId }).(pulumi.StringPtrOutput)
}

// Immutable. The resource name for a CertificateTemplate used to issue this certificate, in the format `projects/*/locations/*/certificateTemplates/*`. If this is specified, the caller must have the necessary permission to use this template. If this is omitted, no template will be used. This template must be in the same location as the Certificate.
func (o CertificateOutput) CertificateTemplate() pulumi.StringOutput {
	return o.ApplyT(func(v *Certificate) pulumi.StringOutput { return v.CertificateTemplate }).(pulumi.StringOutput)
}

// Immutable. A description of the certificate and key that does not require X.509 or ASN.1.
func (o CertificateOutput) Config() CertificateConfigResponseOutput {
	return o.ApplyT(func(v *Certificate) CertificateConfigResponseOutput { return v.Config }).(CertificateConfigResponseOutput)
}

// The time at which this Certificate was created.
func (o CertificateOutput) CreateTime() pulumi.StringOutput {
	return o.ApplyT(func(v *Certificate) pulumi.StringOutput { return v.CreateTime }).(pulumi.StringOutput)
}

// The resource name of the issuing CertificateAuthority in the format `projects/*/locations/*/caPools/*/certificateAuthorities/*`.
func (o CertificateOutput) IssuerCertificateAuthority() pulumi.StringOutput {
	return o.ApplyT(func(v *Certificate) pulumi.StringOutput { return v.IssuerCertificateAuthority }).(pulumi.StringOutput)
}

// Optional. The resource ID of the CertificateAuthority that should issue the certificate. This optional field will ignore the load-balancing scheme of the Pool and directly issue the certificate from the CA with the specified ID, contained in the same CaPool referenced by `parent`. Per-CA quota rules apply. If left empty, a CertificateAuthority will be chosen from the CaPool by the service. For example, to issue a Certificate from a Certificate Authority with resource name "projects/my-project/locations/us-central1/caPools/my-pool/certificateAuthorities/my-ca", you can set the parent to "projects/my-project/locations/us-central1/caPools/my-pool" and the issuing_certificate_authority_id to "my-ca".
func (o CertificateOutput) IssuingCertificateAuthorityId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Certificate) pulumi.StringPtrOutput { return v.IssuingCertificateAuthorityId }).(pulumi.StringPtrOutput)
}

// Optional. Labels with user-defined metadata.
func (o CertificateOutput) Labels() pulumi.StringMapOutput {
	return o.ApplyT(func(v *Certificate) pulumi.StringMapOutput { return v.Labels }).(pulumi.StringMapOutput)
}

// Immutable. The desired lifetime of a certificate. Used to create the "not_before_time" and "not_after_time" fields inside an X.509 certificate. Note that the lifetime may be truncated if it would extend past the life of any certificate authority in the issuing chain.
func (o CertificateOutput) Lifetime() pulumi.StringOutput {
	return o.ApplyT(func(v *Certificate) pulumi.StringOutput { return v.Lifetime }).(pulumi.StringOutput)
}

func (o CertificateOutput) Location() pulumi.StringOutput {
	return o.ApplyT(func(v *Certificate) pulumi.StringOutput { return v.Location }).(pulumi.StringOutput)
}

// The resource name for this Certificate in the format `projects/*/locations/*/caPools/*/certificates/*`.
func (o CertificateOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *Certificate) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// The pem-encoded, signed X.509 certificate.
func (o CertificateOutput) PemCertificate() pulumi.StringOutput {
	return o.ApplyT(func(v *Certificate) pulumi.StringOutput { return v.PemCertificate }).(pulumi.StringOutput)
}

// The chain that may be used to verify the X.509 certificate. Expected to be in issuer-to-root order according to RFC 5246.
func (o CertificateOutput) PemCertificateChain() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *Certificate) pulumi.StringArrayOutput { return v.PemCertificateChain }).(pulumi.StringArrayOutput)
}

// Immutable. A pem-encoded X.509 certificate signing request (CSR).
func (o CertificateOutput) PemCsr() pulumi.StringOutput {
	return o.ApplyT(func(v *Certificate) pulumi.StringOutput { return v.PemCsr }).(pulumi.StringOutput)
}

func (o CertificateOutput) Project() pulumi.StringOutput {
	return o.ApplyT(func(v *Certificate) pulumi.StringOutput { return v.Project }).(pulumi.StringOutput)
}

// Optional. An ID to identify requests. Specify a unique request ID so that if you must retry your request, the server will know to ignore the request if it has already been completed. The server will guarantee that for at least 60 minutes since the first request. For example, consider a situation where you make an initial request and the request times out. If you make the request again with the same request ID, the server can check if original operation with the same request ID was received, and if so, will ignore the second request. This prevents clients from accidentally creating duplicate commitments. The request ID must be a valid UUID with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
func (o CertificateOutput) RequestId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Certificate) pulumi.StringPtrOutput { return v.RequestId }).(pulumi.StringPtrOutput)
}

// Details regarding the revocation of this Certificate. This Certificate is considered revoked if and only if this field is present.
func (o CertificateOutput) RevocationDetails() RevocationDetailsResponseOutput {
	return o.ApplyT(func(v *Certificate) RevocationDetailsResponseOutput { return v.RevocationDetails }).(RevocationDetailsResponseOutput)
}

// Immutable. Specifies how the Certificate's identity fields are to be decided. If this is omitted, the `DEFAULT` subject mode will be used.
func (o CertificateOutput) SubjectMode() pulumi.StringOutput {
	return o.ApplyT(func(v *Certificate) pulumi.StringOutput { return v.SubjectMode }).(pulumi.StringOutput)
}

// The time at which this Certificate was updated.
func (o CertificateOutput) UpdateTime() pulumi.StringOutput {
	return o.ApplyT(func(v *Certificate) pulumi.StringOutput { return v.UpdateTime }).(pulumi.StringOutput)
}

// Optional. If this is true, no Certificate resource will be persisted regardless of the CaPool's tier, and the returned Certificate will not contain the pem_certificate field.
func (o CertificateOutput) ValidateOnly() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Certificate) pulumi.StringPtrOutput { return v.ValidateOnly }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*CertificateInput)(nil)).Elem(), &Certificate{})
	pulumi.RegisterOutputType(CertificateOutput{})
}
