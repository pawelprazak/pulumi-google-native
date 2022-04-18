// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.Ml.V1.Inputs
{

    /// <summary>
    /// Configuration for Automated Early Stopping of Trials. If no implementation_config is set, automated early stopping will not be run.
    /// </summary>
    public sealed class GoogleCloudMlV1__AutomatedStoppingConfigArgs : Pulumi.ResourceArgs
    {
        [Input("decayCurveStoppingConfig")]
        public Input<Inputs.GoogleCloudMlV1_AutomatedStoppingConfig_DecayCurveAutomatedStoppingConfigArgs>? DecayCurveStoppingConfig { get; set; }

        [Input("medianAutomatedStoppingConfig")]
        public Input<Inputs.GoogleCloudMlV1_AutomatedStoppingConfig_MedianAutomatedStoppingConfigArgs>? MedianAutomatedStoppingConfig { get; set; }

        public GoogleCloudMlV1__AutomatedStoppingConfigArgs()
        {
        }
    }
}