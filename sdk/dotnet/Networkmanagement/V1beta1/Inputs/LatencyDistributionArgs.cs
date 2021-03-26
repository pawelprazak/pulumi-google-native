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
    /// Describes measured latency distribution.
    /// </summary>
    public sealed class LatencyDistributionArgs : Pulumi.ResourceArgs
    {
        [Input("latencyPercentiles")]
        private InputList<Inputs.LatencyPercentileArgs>? _latencyPercentiles;

        /// <summary>
        /// Representative latency percentiles.
        /// </summary>
        public InputList<Inputs.LatencyPercentileArgs> LatencyPercentiles
        {
            get => _latencyPercentiles ?? (_latencyPercentiles = new InputList<Inputs.LatencyPercentileArgs>());
            set => _latencyPercentiles = value;
        }

        public LatencyDistributionArgs()
        {
        }
    }
}