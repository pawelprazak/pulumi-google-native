// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.ContainerAnalysis.V1Alpha1.Outputs
{

    /// <summary>
    /// Spec defined at https://github.com/in-toto/attestation/tree/main/spec#statement The serialized InTotoStatement will be stored as Envelope.payload. Envelope.payloadType is always "application/vnd.in-toto+json".
    /// </summary>
    [OutputType]
    public sealed class InTotoStatementResponse
    {
        /// <summary>
        /// "https://slsa.dev/provenance/v0.1" for SlsaProvenance.
        /// </summary>
        public readonly string PredicateType;
        /// <summary>
        /// Generic Grafeas provenance.
        /// </summary>
        public readonly Outputs.InTotoProvenanceResponse Provenance;
        /// <summary>
        /// SLSA 0.1 provenance.
        /// </summary>
        public readonly Outputs.SlsaProvenanceResponse SlsaProvenance;
        /// <summary>
        /// SLSA 0.2 provenance.
        /// </summary>
        public readonly Outputs.SlsaProvenanceZeroTwoResponse SlsaProvenanceZeroTwo;
        /// <summary>
        /// subject is the subjects of the intoto statement
        /// </summary>
        public readonly ImmutableArray<Outputs.SubjectResponse> Subject;
        /// <summary>
        /// Always "https://in-toto.io/Statement/v0.1".
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private InTotoStatementResponse(
            string predicateType,

            Outputs.InTotoProvenanceResponse provenance,

            Outputs.SlsaProvenanceResponse slsaProvenance,

            Outputs.SlsaProvenanceZeroTwoResponse slsaProvenanceZeroTwo,

            ImmutableArray<Outputs.SubjectResponse> subject,

            string type)
        {
            PredicateType = predicateType;
            Provenance = provenance;
            SlsaProvenance = slsaProvenance;
            SlsaProvenanceZeroTwo = slsaProvenanceZeroTwo;
            Subject = subject;
            Type = type;
        }
    }
}