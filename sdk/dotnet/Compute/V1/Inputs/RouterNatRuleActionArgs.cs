// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.Compute.V1.Inputs
{

    public sealed class RouterNatRuleActionArgs : Pulumi.ResourceArgs
    {
        [Input("sourceNatActiveIps")]
        private InputList<string>? _sourceNatActiveIps;

        /// <summary>
        /// A list of URLs of the IP resources used for this NAT rule. These IP addresses must be valid static external IP addresses assigned to the project. This field is used for public NAT.
        /// </summary>
        public InputList<string> SourceNatActiveIps
        {
            get => _sourceNatActiveIps ?? (_sourceNatActiveIps = new InputList<string>());
            set => _sourceNatActiveIps = value;
        }

        [Input("sourceNatDrainIps")]
        private InputList<string>? _sourceNatDrainIps;

        /// <summary>
        /// A list of URLs of the IP resources to be drained. These IPs must be valid static external IPs that have been assigned to the NAT. These IPs should be used for updating/patching a NAT rule only. This field is used for public NAT.
        /// </summary>
        public InputList<string> SourceNatDrainIps
        {
            get => _sourceNatDrainIps ?? (_sourceNatDrainIps = new InputList<string>());
            set => _sourceNatDrainIps = value;
        }

        public RouterNatRuleActionArgs()
        {
        }
    }
}
