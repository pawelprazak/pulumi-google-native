// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.ToolResults.V1Beta3.Inputs
{

    /// <summary>
    /// Testing timing break down to know phases.
    /// </summary>
    public sealed class TestTimingArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// How long it took to run the test process. - In response: present if previously set. - In create/update request: optional
        /// </summary>
        [Input("testProcessDuration")]
        public Input<Inputs.DurationArgs>? TestProcessDuration { get; set; }

        public TestTimingArgs()
        {
        }
    }
}
