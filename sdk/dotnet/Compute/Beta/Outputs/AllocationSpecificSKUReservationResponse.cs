// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.Compute.Beta.Outputs
{

    /// <summary>
    /// This reservation type allows to pre allocate specific instance configuration. Next ID: 6
    /// </summary>
    [OutputType]
    public sealed class AllocationSpecificSKUReservationResponse
    {
        /// <summary>
        /// Indicates how many instances are actually usable currently.
        /// </summary>
        public readonly string AssuredCount;
        /// <summary>
        /// Specifies the number of resources that are allocated.
        /// </summary>
        public readonly string Count;
        /// <summary>
        /// Indicates how many instances are in use.
        /// </summary>
        public readonly string InUseCount;
        /// <summary>
        /// The instance properties for the reservation.
        /// </summary>
        public readonly Outputs.AllocationSpecificSKUAllocationReservedInstancePropertiesResponse InstanceProperties;

        [OutputConstructor]
        private AllocationSpecificSKUReservationResponse(
            string assuredCount,

            string count,

            string inUseCount,

            Outputs.AllocationSpecificSKUAllocationReservedInstancePropertiesResponse instanceProperties)
        {
            AssuredCount = assuredCount;
            Count = count;
            InUseCount = inUseCount;
            InstanceProperties = instanceProperties;
        }
    }
}
