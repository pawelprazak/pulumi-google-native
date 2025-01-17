// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.Monitoring.V1.Inputs
{

    /// <summary>
    /// Describes a query to build the numerator or denominator of a TimeSeriesFilterRatio.
    /// </summary>
    public sealed class RatioPartArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// By default, the raw time series data is returned. Use this field to combine multiple time series for different views of the data.
        /// </summary>
        [Input("aggregation")]
        public Input<Inputs.AggregationArgs>? Aggregation { get; set; }

        /// <summary>
        /// The monitoring filter (https://cloud.google.com/monitoring/api/v3/filters) that identifies the metric types, resources, and projects to query.
        /// </summary>
        [Input("filter", required: true)]
        public Input<string> Filter { get; set; } = null!;

        public RatioPartArgs()
        {
        }
    }
}
