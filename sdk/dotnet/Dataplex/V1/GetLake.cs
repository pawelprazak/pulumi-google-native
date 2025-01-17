// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.Dataplex.V1
{
    public static class GetLake
    {
        /// <summary>
        /// Retrieves a lake resource.
        /// </summary>
        public static Task<GetLakeResult> InvokeAsync(GetLakeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetLakeResult>("google-native:dataplex/v1:getLake", args ?? new GetLakeArgs(), options.WithDefaults());

        /// <summary>
        /// Retrieves a lake resource.
        /// </summary>
        public static Output<GetLakeResult> Invoke(GetLakeInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetLakeResult>("google-native:dataplex/v1:getLake", args ?? new GetLakeInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetLakeArgs : Pulumi.InvokeArgs
    {
        [Input("lakeId", required: true)]
        public string LakeId { get; set; } = null!;

        [Input("location", required: true)]
        public string Location { get; set; } = null!;

        [Input("project")]
        public string? Project { get; set; }

        public GetLakeArgs()
        {
        }
    }

    public sealed class GetLakeInvokeArgs : Pulumi.InvokeArgs
    {
        [Input("lakeId", required: true)]
        public Input<string> LakeId { get; set; } = null!;

        [Input("location", required: true)]
        public Input<string> Location { get; set; } = null!;

        [Input("project")]
        public Input<string>? Project { get; set; }

        public GetLakeInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetLakeResult
    {
        /// <summary>
        /// Aggregated status of the underlying assets of the lake.
        /// </summary>
        public readonly Outputs.GoogleCloudDataplexV1AssetStatusResponse AssetStatus;
        /// <summary>
        /// The time when the lake was created.
        /// </summary>
        public readonly string CreateTime;
        /// <summary>
        /// Optional. Description of the lake.
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// Optional. User friendly display name.
        /// </summary>
        public readonly string DisplayName;
        /// <summary>
        /// Optional. User-defined labels for the lake.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Labels;
        /// <summary>
        /// Optional. Settings to manage lake and Dataproc Metastore service instance association.
        /// </summary>
        public readonly Outputs.GoogleCloudDataplexV1LakeMetastoreResponse Metastore;
        /// <summary>
        /// Metastore status of the lake.
        /// </summary>
        public readonly Outputs.GoogleCloudDataplexV1LakeMetastoreStatusResponse MetastoreStatus;
        /// <summary>
        /// The relative resource name of the lake, of the form: projects/{project_number}/locations/{location_id}/lakes/{lake_id}.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Service account associated with this lake. This service account must be authorized to access or operate on resources managed by the lake.
        /// </summary>
        public readonly string ServiceAccount;
        /// <summary>
        /// Current state of the lake.
        /// </summary>
        public readonly string State;
        /// <summary>
        /// System generated globally unique ID for the lake. This ID will be different if the lake is deleted and re-created with the same name.
        /// </summary>
        public readonly string Uid;
        /// <summary>
        /// The time when the lake was last updated.
        /// </summary>
        public readonly string UpdateTime;

        [OutputConstructor]
        private GetLakeResult(
            Outputs.GoogleCloudDataplexV1AssetStatusResponse assetStatus,

            string createTime,

            string description,

            string displayName,

            ImmutableDictionary<string, string> labels,

            Outputs.GoogleCloudDataplexV1LakeMetastoreResponse metastore,

            Outputs.GoogleCloudDataplexV1LakeMetastoreStatusResponse metastoreStatus,

            string name,

            string serviceAccount,

            string state,

            string uid,

            string updateTime)
        {
            AssetStatus = assetStatus;
            CreateTime = createTime;
            Description = description;
            DisplayName = displayName;
            Labels = labels;
            Metastore = metastore;
            MetastoreStatus = metastoreStatus;
            Name = name;
            ServiceAccount = serviceAccount;
            State = state;
            Uid = uid;
            UpdateTime = updateTime;
        }
    }
}
