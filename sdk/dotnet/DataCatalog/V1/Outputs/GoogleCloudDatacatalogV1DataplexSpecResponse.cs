// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.DataCatalog.V1.Outputs
{

    /// <summary>
    /// Common Dataplex fields.
    /// </summary>
    [OutputType]
    public sealed class GoogleCloudDatacatalogV1DataplexSpecResponse
    {
        /// <summary>
        /// Fully qualified resource name of an asset in Dataplex, to which the underlying data source (Cloud Storage bucket or BigQuery dataset) of the entity is attached.
        /// </summary>
        public readonly string Asset;
        /// <summary>
        /// Compression format of the data, e.g., zip, gzip etc.
        /// </summary>
        public readonly string CompressionFormat;
        /// <summary>
        /// Format of the data.
        /// </summary>
        public readonly Outputs.GoogleCloudDatacatalogV1PhysicalSchemaResponse DataFormat;
        /// <summary>
        /// Project ID of the underlying Cloud Storage or BigQuery data. Note that this may not be the same project as the correspondingly Dataplex lake / zone / asset.
        /// </summary>
        public readonly string Project;

        [OutputConstructor]
        private GoogleCloudDatacatalogV1DataplexSpecResponse(
            string asset,

            string compressionFormat,

            Outputs.GoogleCloudDatacatalogV1PhysicalSchemaResponse dataFormat,

            string project)
        {
            Asset = asset;
            CompressionFormat = compressionFormat;
            DataFormat = dataFormat;
            Project = project;
        }
    }
}