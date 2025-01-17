// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.DNS.V2.Inputs
{

    public sealed class ManagedZonePeeringConfigTargetNetworkArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The time at which the zone was deactivated, in RFC 3339 date-time format. An empty string indicates that the peering connection is active. The producer network can deactivate a zone. The zone is automatically deactivated if the producer network that the zone targeted is deleted. Output only.
        /// </summary>
        [Input("deactivateTime")]
        public Input<string>? DeactivateTime { get; set; }

        [Input("kind")]
        public Input<string>? Kind { get; set; }

        /// <summary>
        /// The fully qualified URL of the VPC network to forward queries to. This should be formatted like https://www.googleapis.com/compute/v1/projects/{project}/global/networks/{network}
        /// </summary>
        [Input("networkUrl")]
        public Input<string>? NetworkUrl { get; set; }

        public ManagedZonePeeringConfigTargetNetworkArgs()
        {
        }
    }
}
