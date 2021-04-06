// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.DLP.V2.Inputs
{

    /// <summary>
    /// A task to execute on the completion of a job. See https://cloud.google.com/dlp/docs/concepts-actions to learn more.
    /// </summary>
    public sealed class GooglePrivacyDlpV2ActionArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Enable email notification for project owners and editors on job's completion/failure.
        /// </summary>
        [Input("jobNotificationEmails")]
        public Input<Inputs.GooglePrivacyDlpV2JobNotificationEmailsArgs>? JobNotificationEmails { get; set; }

        /// <summary>
        /// Publish a notification to a pubsub topic.
        /// </summary>
        [Input("pubSub")]
        public Input<Inputs.GooglePrivacyDlpV2PublishToPubSubArgs>? PubSub { get; set; }

        /// <summary>
        /// Publish findings to Cloud Datahub.
        /// </summary>
        [Input("publishFindingsToCloudDataCatalog")]
        public Input<Inputs.GooglePrivacyDlpV2PublishFindingsToCloudDataCatalogArgs>? PublishFindingsToCloudDataCatalog { get; set; }

        /// <summary>
        /// Publish summary to Cloud Security Command Center (Alpha).
        /// </summary>
        [Input("publishSummaryToCscc")]
        public Input<Inputs.GooglePrivacyDlpV2PublishSummaryToCsccArgs>? PublishSummaryToCscc { get; set; }

        /// <summary>
        /// Enable Stackdriver metric dlp.googleapis.com/finding_count.
        /// </summary>
        [Input("publishToStackdriver")]
        public Input<Inputs.GooglePrivacyDlpV2PublishToStackdriverArgs>? PublishToStackdriver { get; set; }

        /// <summary>
        /// Save resulting findings in a provided location.
        /// </summary>
        [Input("saveFindings")]
        public Input<Inputs.GooglePrivacyDlpV2SaveFindingsArgs>? SaveFindings { get; set; }

        public GooglePrivacyDlpV2ActionArgs()
        {
        }
    }
}