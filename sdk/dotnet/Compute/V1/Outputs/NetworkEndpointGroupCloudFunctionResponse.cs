// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.Compute.V1.Outputs
{

    /// <summary>
    /// Configuration for a Cloud Function network endpoint group (NEG). The function must be provided explicitly or in the URL mask. Note: Cloud Function must be in the same project and located in the same region as the Serverless NEG.
    /// </summary>
    [OutputType]
    public sealed class NetworkEndpointGroupCloudFunctionResponse
    {
        /// <summary>
        /// A user-defined name of the Cloud Function. The function name is case-sensitive and must be 1-63 characters long. Example value: "func1".
        /// </summary>
        public readonly string Function;
        /// <summary>
        /// A template to parse function field from a request URL. URL mask allows for routing to multiple Cloud Functions without having to create multiple Network Endpoint Groups and backend services. For example, request URLs " mydomain.com/function1" and "mydomain.com/function2" can be backed by the same Serverless NEG with URL mask "/". The URL mask will parse them to { function = "function1" } and { function = "function2" } respectively.
        /// </summary>
        public readonly string UrlMask;

        [OutputConstructor]
        private NetworkEndpointGroupCloudFunctionResponse(
            string function,

            string urlMask)
        {
            Function = function;
            UrlMask = urlMask;
        }
    }
}
