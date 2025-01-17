// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.Pubsub.V1.Inputs
{

    /// <summary>
    /// Configuration for a BigQuery subscription.
    /// </summary>
    public sealed class BigQueryConfigArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// When true and use_topic_schema is true, any fields that are a part of the topic schema that are not part of the BigQuery table schema are dropped when writing to BigQuery. Otherwise, the schemas must be kept in sync and any messages with extra fields are not written and remain in the subscription's backlog.
        /// </summary>
        [Input("dropUnknownFields")]
        public Input<bool>? DropUnknownFields { get; set; }

        /// <summary>
        /// The name of the table to which to write data, of the form {projectId}.{datasetId}.{tableId}
        /// </summary>
        [Input("table")]
        public Input<string>? Table { get; set; }

        /// <summary>
        /// When true, use the topic's schema as the columns to write to in BigQuery, if it exists.
        /// </summary>
        [Input("useTopicSchema")]
        public Input<bool>? UseTopicSchema { get; set; }

        /// <summary>
        /// When true, write the subscription name, message_id, publish_time, attributes, and ordering_key to additional columns in the table. The subscription name, message_id, and publish_time fields are put in their own columns while all other message properties (other than data) are written to a JSON object in the attributes column.
        /// </summary>
        [Input("writeMetadata")]
        public Input<bool>? WriteMetadata { get; set; }

        public BigQueryConfigArgs()
        {
        }
    }
}
