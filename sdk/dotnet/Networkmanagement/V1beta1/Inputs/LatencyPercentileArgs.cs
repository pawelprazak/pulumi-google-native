// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.Networkmanagement.V1beta1.Inputs
{

    /// <summary>
    /// Latency percentile rank and value.
    /// </summary>
    public sealed class LatencyPercentileArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// percent-th percentile of latency observed, in microseconds. Fraction of percent/100 of samples have latency lower or equal to the value of this field.
        /// </summary>
        [Input("latencyMicros")]
        public Input<string>? LatencyMicros { get; set; }

        /// <summary>
        /// Percentage of samples this data point applies to.
        /// </summary>
        [Input("percent")]
        public Input<int>? Percent { get; set; }

        public LatencyPercentileArgs()
        {
        }
    }
}