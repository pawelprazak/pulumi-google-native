// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.Jobs.V3.Inputs
{

    /// <summary>
    /// Compensation range.
    /// </summary>
    public sealed class CompensationRangeArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Optional. The maximum amount of compensation. If left empty, the value is set to a maximal compensation value and the currency code is set to match the currency code of min_compensation.
        /// </summary>
        [Input("maxCompensation")]
        public Input<Inputs.MoneyArgs>? MaxCompensation { get; set; }

        /// <summary>
        /// Optional. The minimum amount of compensation. If left empty, the value is set to zero and the currency code is set to match the currency code of max_compensation.
        /// </summary>
        [Input("minCompensation")]
        public Input<Inputs.MoneyArgs>? MinCompensation { get; set; }

        public CompensationRangeArgs()
        {
        }
    }
}