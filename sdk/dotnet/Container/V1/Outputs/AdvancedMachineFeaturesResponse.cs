// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.Container.V1.Outputs
{

    /// <summary>
    /// Specifies options for controlling advanced machine features.
    /// </summary>
    [OutputType]
    public sealed class AdvancedMachineFeaturesResponse
    {
        /// <summary>
        /// The number of threads per physical core. To disable simultaneous multithreading (SMT) set this to 1. If unset, the maximum number of threads supported per core by the underlying processor is assumed.
        /// </summary>
        public readonly string ThreadsPerCore;

        [OutputConstructor]
        private AdvancedMachineFeaturesResponse(string threadsPerCore)
        {
            ThreadsPerCore = threadsPerCore;
        }
    }
}