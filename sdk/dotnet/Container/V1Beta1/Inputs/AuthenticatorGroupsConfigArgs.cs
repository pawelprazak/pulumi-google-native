// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.Container.V1Beta1.Inputs
{

    /// <summary>
    /// Configuration for returning group information from authenticators.
    /// </summary>
    public sealed class AuthenticatorGroupsConfigArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Whether this cluster should return group membership lookups during authentication using a group of security groups.
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// The name of the security group-of-groups to be used. Only relevant if enabled = true.
        /// </summary>
        [Input("securityGroup")]
        public Input<string>? SecurityGroup { get; set; }

        public AuthenticatorGroupsConfigArgs()
        {
        }
    }
}