// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.Bigquery.V2.Outputs
{

    [OutputType]
    public sealed class UserDefinedFunctionResourceResponse
    {
        /// <summary>
        /// [Pick one] An inline resource that contains code for a user-defined function (UDF). Providing a inline code resource is equivalent to providing a URI for a file containing the same code.
        /// </summary>
        public readonly string InlineCode;
        /// <summary>
        /// [Pick one] A code resource to load from a Google Cloud Storage URI (gs://bucket/path).
        /// </summary>
        public readonly string ResourceUri;

        [OutputConstructor]
        private UserDefinedFunctionResourceResponse(
            string inlineCode,

            string resourceUri)
        {
            InlineCode = inlineCode;
            ResourceUri = resourceUri;
        }
    }
}