// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.Compute.Alpha.Outputs
{

    [OutputType]
    public sealed class SslPolicyWarningsItemResponse
    {
        /// <summary>
        /// A warning code, if applicable. For example, Compute Engine returns NO_RESULTS_ON_PAGE if there are no results in the response.
        /// </summary>
        public readonly string Code;
        /// <summary>
        /// Metadata about this warning in key: value format. For example: "data": [ { "key": "scope", "value": "zones/us-east1-d" } 
        /// </summary>
        public readonly ImmutableArray<Outputs.SslPolicyWarningsItemDataItemResponse> Data;
        /// <summary>
        /// A human-readable description of the warning code.
        /// </summary>
        public readonly string Message;

        [OutputConstructor]
        private SslPolicyWarningsItemResponse(
            string code,

            ImmutableArray<Outputs.SslPolicyWarningsItemDataItemResponse> data,

            string message)
        {
            Code = code;
            Data = data;
            Message = message;
        }
    }
}
