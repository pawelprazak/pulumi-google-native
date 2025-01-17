// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.DLP.V2.Outputs
{

    /// <summary>
    /// Options defining BigQuery table and row identifiers.
    /// </summary>
    [OutputType]
    public sealed class GooglePrivacyDlpV2BigQueryOptionsResponse
    {
        /// <summary>
        /// References to fields excluded from scanning. This allows you to skip inspection of entire columns which you know have no findings.
        /// </summary>
        public readonly ImmutableArray<Outputs.GooglePrivacyDlpV2FieldIdResponse> ExcludedFields;
        /// <summary>
        /// Table fields that may uniquely identify a row within the table. When `actions.saveFindings.outputConfig.table` is specified, the values of columns specified here are available in the output table under `location.content_locations.record_location.record_key.id_values`. Nested fields such as `person.birthdate.year` are allowed.
        /// </summary>
        public readonly ImmutableArray<Outputs.GooglePrivacyDlpV2FieldIdResponse> IdentifyingFields;
        /// <summary>
        /// Limit scanning only to these fields.
        /// </summary>
        public readonly ImmutableArray<Outputs.GooglePrivacyDlpV2FieldIdResponse> IncludedFields;
        /// <summary>
        /// Max number of rows to scan. If the table has more rows than this value, the rest of the rows are omitted. If not set, or if set to 0, all rows will be scanned. Only one of rows_limit and rows_limit_percent can be specified. Cannot be used in conjunction with TimespanConfig.
        /// </summary>
        public readonly string RowsLimit;
        /// <summary>
        /// Max percentage of rows to scan. The rest are omitted. The number of rows scanned is rounded down. Must be between 0 and 100, inclusively. Both 0 and 100 means no limit. Defaults to 0. Only one of rows_limit and rows_limit_percent can be specified. Cannot be used in conjunction with TimespanConfig.
        /// </summary>
        public readonly int RowsLimitPercent;
        public readonly string SampleMethod;
        /// <summary>
        /// Complete BigQuery table reference.
        /// </summary>
        public readonly Outputs.GooglePrivacyDlpV2BigQueryTableResponse TableReference;

        [OutputConstructor]
        private GooglePrivacyDlpV2BigQueryOptionsResponse(
            ImmutableArray<Outputs.GooglePrivacyDlpV2FieldIdResponse> excludedFields,

            ImmutableArray<Outputs.GooglePrivacyDlpV2FieldIdResponse> identifyingFields,

            ImmutableArray<Outputs.GooglePrivacyDlpV2FieldIdResponse> includedFields,

            string rowsLimit,

            int rowsLimitPercent,

            string sampleMethod,

            Outputs.GooglePrivacyDlpV2BigQueryTableResponse tableReference)
        {
            ExcludedFields = excludedFields;
            IdentifyingFields = identifyingFields;
            IncludedFields = includedFields;
            RowsLimit = rowsLimit;
            RowsLimitPercent = rowsLimitPercent;
            SampleMethod = sampleMethod;
            TableReference = tableReference;
        }
    }
}
