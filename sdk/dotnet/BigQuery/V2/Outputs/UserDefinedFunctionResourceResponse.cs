// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.BigQuery.V2.Outputs
{

    /// <summary>
    /// This is used for defining User Defined Function (UDF) resources only when using legacy SQL. Users of Standard SQL should leverage either DDL (e.g. CREATE [TEMPORARY] FUNCTION ... ) or the Routines API to define UDF resources. For additional information on migrating, see: https://cloud.google.com/bigquery/docs/reference/standard-sql/migrating-from-legacy-sql#differences_in_user-defined_javascript_functions
    /// </summary>
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
