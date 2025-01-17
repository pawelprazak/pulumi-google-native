// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.Compute.Alpha.Inputs
{

    public sealed class ResourcePolicyVmMaintenancePolicyArgs : Pulumi.ResourceArgs
    {
        [Input("concurrencyControlGroup")]
        public Input<Inputs.ResourcePolicyVmMaintenancePolicyConcurrencyControlArgs>? ConcurrencyControlGroup { get; set; }

        /// <summary>
        /// Maintenance windows that are applied to VMs covered by this policy.
        /// </summary>
        [Input("maintenanceWindow")]
        public Input<Inputs.ResourcePolicyVmMaintenancePolicyMaintenanceWindowArgs>? MaintenanceWindow { get; set; }

        public ResourcePolicyVmMaintenancePolicyArgs()
        {
        }
    }
}
