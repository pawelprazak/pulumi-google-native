// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.Compute.Beta.Inputs
{

    /// <summary>
    /// Specification for how requests are aborted as part of fault injection.
    /// </summary>
    public sealed class HttpFaultAbortArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The HTTP status code used to abort the request.
        /// The value must be between 200 and 599 inclusive.
        /// </summary>
        [Input("httpStatus")]
        public Input<int>? HttpStatus { get; set; }

        /// <summary>
        /// The percentage of traffic (connections/operations/requests) which will be aborted as part of fault injection.
        /// The value must be between 0.0 and 100.0 inclusive.
        /// </summary>
        [Input("percentage")]
        public Input<double>? Percentage { get; set; }

        public HttpFaultAbortArgs()
        {
        }
    }
}