// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.Compute.V1.Inputs
{

    public sealed class StatefulPolicyArgs : Pulumi.ResourceArgs
    {
        [Input("preservedState")]
        public Input<Inputs.StatefulPolicyPreservedStateArgs>? PreservedState { get; set; }

        public StatefulPolicyArgs()
        {
        }
    }
}
