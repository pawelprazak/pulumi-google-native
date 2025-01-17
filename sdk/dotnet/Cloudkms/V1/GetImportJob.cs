// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.Cloudkms.V1
{
    public static class GetImportJob
    {
        /// <summary>
        /// Returns metadata for a given ImportJob.
        /// </summary>
        public static Task<GetImportJobResult> InvokeAsync(GetImportJobArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetImportJobResult>("google-native:cloudkms/v1:getImportJob", args ?? new GetImportJobArgs(), options.WithDefaults());

        /// <summary>
        /// Returns metadata for a given ImportJob.
        /// </summary>
        public static Output<GetImportJobResult> Invoke(GetImportJobInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetImportJobResult>("google-native:cloudkms/v1:getImportJob", args ?? new GetImportJobInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetImportJobArgs : Pulumi.InvokeArgs
    {
        [Input("importJobId", required: true)]
        public string ImportJobId { get; set; } = null!;

        [Input("keyRingId", required: true)]
        public string KeyRingId { get; set; } = null!;

        [Input("location", required: true)]
        public string Location { get; set; } = null!;

        [Input("project")]
        public string? Project { get; set; }

        public GetImportJobArgs()
        {
        }
    }

    public sealed class GetImportJobInvokeArgs : Pulumi.InvokeArgs
    {
        [Input("importJobId", required: true)]
        public Input<string> ImportJobId { get; set; } = null!;

        [Input("keyRingId", required: true)]
        public Input<string> KeyRingId { get; set; } = null!;

        [Input("location", required: true)]
        public Input<string> Location { get; set; } = null!;

        [Input("project")]
        public Input<string>? Project { get; set; }

        public GetImportJobInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetImportJobResult
    {
        /// <summary>
        /// Statement that was generated and signed by the key creator (for example, an HSM) at key creation time. Use this statement to verify attributes of the key as stored on the HSM, independently of Google. Only present if the chosen ImportMethod is one with a protection level of HSM.
        /// </summary>
        public readonly Outputs.KeyOperationAttestationResponse Attestation;
        /// <summary>
        /// The time at which this ImportJob was created.
        /// </summary>
        public readonly string CreateTime;
        /// <summary>
        /// The time this ImportJob expired. Only present if state is EXPIRED.
        /// </summary>
        public readonly string ExpireEventTime;
        /// <summary>
        /// The time at which this ImportJob is scheduled for expiration and can no longer be used to import key material.
        /// </summary>
        public readonly string ExpireTime;
        /// <summary>
        /// The time this ImportJob's key material was generated.
        /// </summary>
        public readonly string GenerateTime;
        /// <summary>
        /// Immutable. The wrapping method to be used for incoming key material.
        /// </summary>
        public readonly string ImportMethod;
        /// <summary>
        /// The resource name for this ImportJob in the format `projects/*/locations/*/keyRings/*/importJobs/*`.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Immutable. The protection level of the ImportJob. This must match the protection_level of the version_template on the CryptoKey you attempt to import into.
        /// </summary>
        public readonly string ProtectionLevel;
        /// <summary>
        /// The public key with which to wrap key material prior to import. Only returned if state is ACTIVE.
        /// </summary>
        public readonly Outputs.WrappingPublicKeyResponse PublicKey;
        /// <summary>
        /// The current state of the ImportJob, indicating if it can be used.
        /// </summary>
        public readonly string State;

        [OutputConstructor]
        private GetImportJobResult(
            Outputs.KeyOperationAttestationResponse attestation,

            string createTime,

            string expireEventTime,

            string expireTime,

            string generateTime,

            string importMethod,

            string name,

            string protectionLevel,

            Outputs.WrappingPublicKeyResponse publicKey,

            string state)
        {
            Attestation = attestation;
            CreateTime = createTime;
            ExpireEventTime = expireEventTime;
            ExpireTime = expireTime;
            GenerateTime = generateTime;
            ImportMethod = importMethod;
            Name = name;
            ProtectionLevel = protectionLevel;
            PublicKey = publicKey;
            State = state;
        }
    }
}
