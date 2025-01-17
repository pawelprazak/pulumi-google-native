// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.OSConfig.V1Beta.Inputs
{

    /// <summary>
    /// Defines the criteria for selecting VM Instances by OS type.
    /// </summary>
    public sealed class AssignmentOsTypeArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Targets VM instances with OS Inventory enabled and having the following OS architecture.
        /// </summary>
        [Input("osArchitecture")]
        public Input<string>? OsArchitecture { get; set; }

        /// <summary>
        /// Targets VM instances with OS Inventory enabled and having the following OS short name, for example "debian" or "windows".
        /// </summary>
        [Input("osShortName")]
        public Input<string>? OsShortName { get; set; }

        /// <summary>
        /// Targets VM instances with OS Inventory enabled and having the following following OS version.
        /// </summary>
        [Input("osVersion")]
        public Input<string>? OsVersion { get; set; }

        public AssignmentOsTypeArgs()
        {
        }
    }
}
