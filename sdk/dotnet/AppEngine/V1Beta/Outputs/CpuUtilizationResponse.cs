// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.AppEngine.V1Beta.Outputs
{

    /// <summary>
    /// Target scaling by CPU usage.
    /// </summary>
    [OutputType]
    public sealed class CpuUtilizationResponse
    {
        /// <summary>
        /// Period of time over which CPU utilization is calculated.
        /// </summary>
        public readonly string AggregationWindowLength;
        /// <summary>
        /// Target CPU utilization ratio to maintain when scaling. Must be between 0 and 1.
        /// </summary>
        public readonly double TargetUtilization;

        [OutputConstructor]
        private CpuUtilizationResponse(
            string aggregationWindowLength,

            double targetUtilization)
        {
            AggregationWindowLength = aggregationWindowLength;
            TargetUtilization = targetUtilization;
        }
    }
}
