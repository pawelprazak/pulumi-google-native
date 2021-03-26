// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.Compute.V1.Inputs
{

    public sealed class DistributionPolicyArgs : Pulumi.ResourceArgs
    {
        [Input("zones")]
        private InputList<Inputs.DistributionPolicyZoneConfigurationArgs>? _zones;

        /// <summary>
        /// Zones where the regional managed instance group will create and manage its instances.
        /// </summary>
        public InputList<Inputs.DistributionPolicyZoneConfigurationArgs> Zones
        {
            get => _zones ?? (_zones = new InputList<Inputs.DistributionPolicyZoneConfigurationArgs>());
            set => _zones = value;
        }

        public DistributionPolicyArgs()
        {
        }
    }
}