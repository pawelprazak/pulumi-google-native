// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.Datacatalog.V1beta1.Inputs
{

    /// <summary>
    /// Spec for a group of BigQuery tables with name pattern `[prefix]YYYYMMDD`. Context: https://cloud.google.com/bigquery/docs/partitioned-tables#partitioning_versus_sharding
    /// </summary>
    public sealed class GoogleCloudDatacatalogV1beta1BigQueryDateShardedSpecArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Output only. The Data Catalog resource name of the dataset entry the current table belongs to, for example, `projects/{project_id}/locations/{location}/entrygroups/{entry_group_id}/entries/{entry_id}`.
        /// </summary>
        [Input("dataset")]
        public Input<string>? Dataset { get; set; }

        /// <summary>
        /// Output only. Total number of shards.
        /// </summary>
        [Input("shardCount")]
        public Input<string>? ShardCount { get; set; }

        /// <summary>
        /// Output only. The table name prefix of the shards. The name of any given shard is `[table_prefix]YYYYMMDD`, for example, for shard `MyTable20180101`, the `table_prefix` is `MyTable`.
        /// </summary>
        [Input("tablePrefix")]
        public Input<string>? TablePrefix { get; set; }

        public GoogleCloudDatacatalogV1beta1BigQueryDateShardedSpecArgs()
        {
        }
    }
}