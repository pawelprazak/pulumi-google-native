// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.Container.V1Beta1.Outputs
{

    /// <summary>
    /// NodeManagement defines the set of node management services turned on for the node pool.
    /// </summary>
    [OutputType]
    public sealed class NodeManagementResponse
    {
        /// <summary>
        /// Whether the nodes will be automatically repaired.
        /// </summary>
        public readonly bool AutoRepair;
        /// <summary>
        /// Whether the nodes will be automatically upgraded.
        /// </summary>
        public readonly bool AutoUpgrade;
        /// <summary>
        /// Specifies the Auto Upgrade knobs for the node pool.
        /// </summary>
        public readonly Outputs.AutoUpgradeOptionsResponse UpgradeOptions;

        [OutputConstructor]
        private NodeManagementResponse(
            bool autoRepair,

            bool autoUpgrade,

            Outputs.AutoUpgradeOptionsResponse upgradeOptions)
        {
            AutoRepair = autoRepair;
            AutoUpgrade = autoUpgrade;
            UpgradeOptions = upgradeOptions;
        }
    }
}