// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.NetworkManagement.V1.Outputs
{

    [OutputType]
    public sealed class AbortInfoResponse
    {
        /// <summary>
        /// Causes that the analysis is aborted.
        /// </summary>
        public readonly string Cause;
        /// <summary>
        /// URI of the resource that caused the abort.
        /// </summary>
        public readonly string ResourceUri;

        [OutputConstructor]
        private AbortInfoResponse(
            string cause,

            string resourceUri)
        {
            Cause = cause;
            ResourceUri = resourceUri;
        }
    }
}