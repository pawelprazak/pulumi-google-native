// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.NetworkServices.V1Beta1.Outputs
{

    /// <summary>
    /// Criteria for matching traffic. A RouteMatch will be considered to match when all supplied fields match.
    /// </summary>
    [OutputType]
    public sealed class GrpcRouteRouteMatchResponse
    {
        /// <summary>
        /// Optional. Specifies a collection of headers to match.
        /// </summary>
        public readonly ImmutableArray<Outputs.GrpcRouteHeaderMatchResponse> Headers;
        /// <summary>
        /// Optional. A gRPC method to match against. If this field is empty or omitted, will match all methods.
        /// </summary>
        public readonly Outputs.GrpcRouteMethodMatchResponse Method;

        [OutputConstructor]
        private GrpcRouteRouteMatchResponse(
            ImmutableArray<Outputs.GrpcRouteHeaderMatchResponse> headers,

            Outputs.GrpcRouteMethodMatchResponse method)
        {
            Headers = headers;
            Method = method;
        }
    }
}