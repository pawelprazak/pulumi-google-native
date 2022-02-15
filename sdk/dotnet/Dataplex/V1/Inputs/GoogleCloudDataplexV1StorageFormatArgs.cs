// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.Dataplex.V1.Inputs
{

    /// <summary>
    /// Describes the format of the data within its storage location.
    /// </summary>
    public sealed class GoogleCloudDataplexV1StorageFormatArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Optional. The compression type associated with the stored data. If unspecified, the data is uncompressed.
        /// </summary>
        [Input("compressionFormat")]
        public Input<Pulumi.GoogleNative.Dataplex.V1.GoogleCloudDataplexV1StorageFormatCompressionFormat>? CompressionFormat { get; set; }

        /// <summary>
        /// Optional. Additional information about CSV formatted data.
        /// </summary>
        [Input("csv")]
        public Input<Inputs.GoogleCloudDataplexV1StorageFormatCsvOptionsArgs>? Csv { get; set; }

        /// <summary>
        /// Optional. Additional information about CSV formatted data.
        /// </summary>
        [Input("json")]
        public Input<Inputs.GoogleCloudDataplexV1StorageFormatJsonOptionsArgs>? Json { get; set; }

        /// <summary>
        /// The mime type descriptor for the data. Must match the pattern {type}/{subtype}. Supported values: - application/x-parquet - application/x-avro - application/x-orc - application/x-tfrecord - application/json - application/{subtypes} - text/csv - text/ - image/{image subtype} - video/{video subtype} - audio/{audio subtype}
        /// </summary>
        [Input("mimeType", required: true)]
        public Input<string> MimeType { get; set; } = null!;

        public GoogleCloudDataplexV1StorageFormatArgs()
        {
        }
    }
}