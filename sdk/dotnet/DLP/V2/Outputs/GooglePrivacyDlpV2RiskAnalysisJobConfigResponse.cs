// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.DLP.V2.Outputs
{

    [OutputType]
    public sealed class GooglePrivacyDlpV2RiskAnalysisJobConfigResponse
    {
        /// <summary>
        /// Actions to execute at the completion of the job. Are executed in the order provided.
        /// </summary>
        public readonly ImmutableArray<Outputs.GooglePrivacyDlpV2ActionResponse> Actions;
        /// <summary>
        /// Privacy metric to compute.
        /// </summary>
        public readonly Outputs.GooglePrivacyDlpV2PrivacyMetricResponse PrivacyMetric;
        /// <summary>
        /// Input dataset to compute metrics over.
        /// </summary>
        public readonly Outputs.GooglePrivacyDlpV2BigQueryTableResponse SourceTable;

        [OutputConstructor]
        private GooglePrivacyDlpV2RiskAnalysisJobConfigResponse(
            ImmutableArray<Outputs.GooglePrivacyDlpV2ActionResponse> actions,

            Outputs.GooglePrivacyDlpV2PrivacyMetricResponse privacyMetric,

            Outputs.GooglePrivacyDlpV2BigQueryTableResponse sourceTable)
        {
            Actions = actions;
            PrivacyMetric = privacyMetric;
            SourceTable = sourceTable;
        }
    }
}