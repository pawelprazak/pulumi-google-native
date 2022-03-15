// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.Dialogflow.V2.Outputs
{

    /// <summary>
    /// Smart reply specific configuration for evaluation job.
    /// </summary>
    [OutputType]
    public sealed class GoogleCloudDialogflowV2EvaluationConfigSmartReplyConfigResponse
    {
        /// <summary>
        /// The allowlist document resource name. Format: `projects//knowledgeBases//documents/`. Only used for smart reply model.
        /// </summary>
        public readonly string AllowlistDocument;
        /// <summary>
        /// The model to be evaluated can return multiple results with confidence score on each query. These results will be sorted by the descending order of the scores and we only keep the first max_result_count results as the final results to evaluate.
        /// </summary>
        public readonly int MaxResultCount;

        [OutputConstructor]
        private GoogleCloudDialogflowV2EvaluationConfigSmartReplyConfigResponse(
            string allowlistDocument,

            int maxResultCount)
        {
            AllowlistDocument = allowlistDocument;
            MaxResultCount = maxResultCount;
        }
    }
}