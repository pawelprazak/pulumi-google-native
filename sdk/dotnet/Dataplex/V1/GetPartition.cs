// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.Dataplex.V1
{
    public static class GetPartition
    {
        /// <summary>
        /// Get a metadata partition of an entity.
        /// </summary>
        public static Task<GetPartitionResult> InvokeAsync(GetPartitionArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetPartitionResult>("google-native:dataplex/v1:getPartition", args ?? new GetPartitionArgs(), options.WithDefaults());

        /// <summary>
        /// Get a metadata partition of an entity.
        /// </summary>
        public static Output<GetPartitionResult> Invoke(GetPartitionInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetPartitionResult>("google-native:dataplex/v1:getPartition", args ?? new GetPartitionInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetPartitionArgs : Pulumi.InvokeArgs
    {
        [Input("entityId", required: true)]
        public string EntityId { get; set; } = null!;

        [Input("lakeId", required: true)]
        public string LakeId { get; set; } = null!;

        [Input("location", required: true)]
        public string Location { get; set; } = null!;

        [Input("partitionId", required: true)]
        public string PartitionId { get; set; } = null!;

        [Input("project")]
        public string? Project { get; set; }

        [Input("zone", required: true)]
        public string Zone { get; set; } = null!;

        public GetPartitionArgs()
        {
        }
    }

    public sealed class GetPartitionInvokeArgs : Pulumi.InvokeArgs
    {
        [Input("entityId", required: true)]
        public Input<string> EntityId { get; set; } = null!;

        [Input("lakeId", required: true)]
        public Input<string> LakeId { get; set; } = null!;

        [Input("location", required: true)]
        public Input<string> Location { get; set; } = null!;

        [Input("partitionId", required: true)]
        public Input<string> PartitionId { get; set; } = null!;

        [Input("project")]
        public Input<string>? Project { get; set; }

        [Input("zone", required: true)]
        public Input<string> Zone { get; set; } = null!;

        public GetPartitionInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetPartitionResult
    {
        /// <summary>
        /// Optional. The etag for this partition.
        /// </summary>
        public readonly string Etag;
        /// <summary>
        /// Immutable. The location of the entity data within the partition, for example, gs://bucket/path/to/entity/key1=value1/key2=value2. Or projects//datasets//tables/
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// Partition values used in the HTTP URL must be double encoded. For example, url_encode(url_encode(value)) can be used to encode "US:CA/CA#Sunnyvale so that the request URL ends with "/partitions/US%253ACA/CA%2523Sunnyvale". The name field in the response retains the encoded format.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Immutable. The set of values representing the partition, which correspond to the partition schema defined in the parent entity.
        /// </summary>
        public readonly ImmutableArray<string> Values;

        [OutputConstructor]
        private GetPartitionResult(
            string etag,

            string location,

            string name,

            ImmutableArray<string> values)
        {
            Etag = etag;
            Location = location;
            Name = name;
            Values = values;
        }
    }
}