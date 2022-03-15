// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.BigQuery.V2.Outputs
{

    [OutputType]
    public sealed class QueryParameterValueResponse
    {
        /// <summary>
        /// [Optional] The array values, if this is an array type.
        /// </summary>
        public readonly ImmutableArray<Outputs.QueryParameterValueResponse> ArrayValues;
        /// <summary>
        /// [Optional] The struct field values, in order of the struct type's declaration.
        /// </summary>
        public readonly ImmutableDictionary<string, string> StructValues;
        /// <summary>
        /// [Optional] The value of this value, if a simple scalar type.
        /// </summary>
        public readonly string Value;

        [OutputConstructor]
        private QueryParameterValueResponse(
            ImmutableArray<Outputs.QueryParameterValueResponse> arrayValues,

            ImmutableDictionary<string, string> structValues,

            string value)
        {
            ArrayValues = arrayValues;
            StructValues = structValues;
            Value = value;
        }
    }
}