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
    /// FileOccurrence represents an SPDX File Information section: https://spdx.github.io/spdx-spec/4-file-information/
    /// </summary>
    [OutputType]
    public sealed class FileOccurrenceResponse
    {
        /// <summary>
        /// This field provides a place for the SPDX data creator to record, at the file level, acknowledgements that may be needed to be communicated in some contexts
        /// </summary>
        public readonly ImmutableArray<string> Attributions;
        /// <summary>
        /// This field provides a place for the SPDX file creator to record any general comments about the file
        /// </summary>
        public readonly string Comment;
        /// <summary>
        /// This field provides a place for the SPDX file creator to record file contributors
        /// </summary>
        public readonly ImmutableArray<string> Contributors;
        /// <summary>
        /// Identify the copyright holder of the file, as well as any dates present
        /// </summary>
        public readonly string Copyright;
        /// <summary>
        /// This field contains the license information actually found in the file, if any
        /// </summary>
        public readonly ImmutableArray<string> FilesLicenseInfo;
        /// <summary>
        /// This field contains the license the SPDX file creator has concluded as governing the file or alternative values if the governing license cannot be determined
        /// </summary>
        public readonly Outputs.LicenseResponse LicenseConcluded;
        /// <summary>
        /// This field provides a place for the SPDX file creator to record license notices or other such related notices found in the file
        /// </summary>
        public readonly string Notice;

        [OutputConstructor]
        private FileOccurrenceResponse(
            ImmutableArray<string> attributions,

            string comment,

            ImmutableArray<string> contributors,

            string copyright,

            ImmutableArray<string> filesLicenseInfo,

            Outputs.LicenseResponse licenseConcluded,

            string notice)
        {
            Attributions = attributions;
            Comment = comment;
            Contributors = contributors;
            Copyright = copyright;
            FilesLicenseInfo = filesLicenseInfo;
            LicenseConcluded = licenseConcluded;
            Notice = notice;
        }
    }
}
