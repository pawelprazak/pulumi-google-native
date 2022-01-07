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
    /// Entry metadata relevant only to the user and private to them.
    /// </summary>
    [OutputType]
    public sealed class GoogleCloudDatacatalogV1PersonalDetailsResponse
    {
        /// <summary>
        /// Set if the entry is starred; unset otherwise.
        /// </summary>
        public readonly string StarTime;
        /// <summary>
        /// True if the entry is starred by the user; false otherwise.
        /// </summary>
        public readonly bool Starred;

        [OutputConstructor]
        private GoogleCloudDatacatalogV1PersonalDetailsResponse(
            string starTime,

            bool starred)
        {
            StarTime = starTime;
            Starred = starred;
        }
    }
}