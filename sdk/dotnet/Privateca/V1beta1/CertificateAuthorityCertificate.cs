// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.Privateca.V1beta1
{
    /// <summary>
    /// Create a new Certificate in a given Project, Location from a particular CertificateAuthority.
    /// </summary>
    [GoogleCloudResourceType("google-cloud:privateca/v1beta1:CertificateAuthorityCertificate")]
    public partial class CertificateAuthorityCertificate : Pulumi.CustomResource
    {
        /// <summary>
        /// A structured description of the issued X.509 certificate.
        /// </summary>
        [Output("certificateDescription")]
        public Output<Outputs.CertificateDescriptionResponse> CertificateDescription { get; private set; } = null!;

        /// <summary>
        /// Immutable. A description of the certificate and key that does not require X.509 or ASN.1.
        /// </summary>
        [Output("config")]
        public Output<Outputs.CertificateConfigResponse> Config { get; private set; } = null!;

        /// <summary>
        /// The time at which this Certificate was created.
        /// </summary>
        [Output("createTime")]
        public Output<string> CreateTime { get; private set; } = null!;

        /// <summary>
        /// Optional. Labels with user-defined metadata.
        /// </summary>
        [Output("labels")]
        public Output<ImmutableDictionary<string, string>> Labels { get; private set; } = null!;

        /// <summary>
        /// Required. Immutable. The desired lifetime of a certificate. Used to create the "not_before_time" and "not_after_time" fields inside an X.509 certificate. Note that the lifetime may be truncated if it would extend past the life of any certificate authority in the issuing chain.
        /// </summary>
        [Output("lifetime")]
        public Output<string> Lifetime { get; private set; } = null!;

        /// <summary>
        /// The resource path for this Certificate in the format `projects/*/locations/*/certificateAuthorities/*/certificates/*`.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The pem-encoded, signed X.509 certificate.
        /// </summary>
        [Output("pemCertificate")]
        public Output<string> PemCertificate { get; private set; } = null!;

        /// <summary>
        /// The chain that may be used to verify the X.509 certificate. Expected to be in issuer-to-root order according to RFC 5246.
        /// </summary>
        [Output("pemCertificateChain")]
        public Output<ImmutableArray<string>> PemCertificateChain { get; private set; } = null!;

        /// <summary>
        /// Immutable. A pem-encoded X.509 certificate signing request (CSR).
        /// </summary>
        [Output("pemCsr")]
        public Output<string> PemCsr { get; private set; } = null!;

        /// <summary>
        /// Details regarding the revocation of this Certificate. This Certificate is considered revoked if and only if this field is present.
        /// </summary>
        [Output("revocationDetails")]
        public Output<Outputs.RevocationDetailsResponse> RevocationDetails { get; private set; } = null!;

        /// <summary>
        /// The time at which this Certificate was updated.
        /// </summary>
        [Output("updateTime")]
        public Output<string> UpdateTime { get; private set; } = null!;


        /// <summary>
        /// Create a CertificateAuthorityCertificate resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public CertificateAuthorityCertificate(string name, CertificateAuthorityCertificateArgs args, CustomResourceOptions? options = null)
            : base("google-cloud:privateca/v1beta1:CertificateAuthorityCertificate", name, args ?? new CertificateAuthorityCertificateArgs(), MakeResourceOptions(options, ""))
        {
        }

        private CertificateAuthorityCertificate(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("google-cloud:privateca/v1beta1:CertificateAuthorityCertificate", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing CertificateAuthorityCertificate resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static CertificateAuthorityCertificate Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new CertificateAuthorityCertificate(name, id, options);
        }
    }

    public sealed class CertificateAuthorityCertificateArgs : Pulumi.ResourceArgs
    {
        [Input("certificateAuthoritiesId", required: true)]
        public Input<string> CertificateAuthoritiesId { get; set; } = null!;

        [Input("certificatesId", required: true)]
        public Input<string> CertificatesId { get; set; } = null!;

        /// <summary>
        /// Immutable. A description of the certificate and key that does not require X.509 or ASN.1.
        /// </summary>
        [Input("config")]
        public Input<Inputs.CertificateConfigArgs>? Config { get; set; }

        [Input("labels")]
        private InputMap<string>? _labels;

        /// <summary>
        /// Optional. Labels with user-defined metadata.
        /// </summary>
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        /// <summary>
        /// Required. Immutable. The desired lifetime of a certificate. Used to create the "not_before_time" and "not_after_time" fields inside an X.509 certificate. Note that the lifetime may be truncated if it would extend past the life of any certificate authority in the issuing chain.
        /// </summary>
        [Input("lifetime")]
        public Input<string>? Lifetime { get; set; }

        [Input("locationsId", required: true)]
        public Input<string> LocationsId { get; set; } = null!;

        /// <summary>
        /// Immutable. A pem-encoded X.509 certificate signing request (CSR).
        /// </summary>
        [Input("pemCsr")]
        public Input<string>? PemCsr { get; set; }

        [Input("projectsId", required: true)]
        public Input<string> ProjectsId { get; set; } = null!;

        public CertificateAuthorityCertificateArgs()
        {
        }
    }
}