// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.Compute.V1.Inputs
{

    /// <summary>
    /// Represents a reservation resource. A reservation ensures that capacity is held in a specific zone even if the reserved VMs are not running. For more information, read  Reserving zonal resources. (== resource_for {$api_version}.reservations ==)
    /// </summary>
    public sealed class ReservationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// [Output Only] Full or partial URL to a parent commitment. This field displays for reservations that are tied to a commitment.
        /// </summary>
        [Input("commitment")]
        public Input<string>? Commitment { get; set; }

        /// <summary>
        /// [Output Only] Creation timestamp in RFC3339 text format.
        /// </summary>
        [Input("creationTimestamp")]
        public Input<string>? CreationTimestamp { get; set; }

        /// <summary>
        /// An optional description of this resource. Provide this property when you create the resource.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// [Output Only] The unique identifier for the resource. This identifier is defined by the server.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// [Output Only] Type of the resource. Always compute#reservations for reservations.
        /// </summary>
        [Input("kind")]
        public Input<string>? Kind { get; set; }

        /// <summary>
        /// The name of the resource, provided by the client when initially creating the resource. The resource name must be 1-63 characters long, and comply with RFC1035. Specifically, the name must be 1-63 characters long and match the regular expression `[a-z]([-a-z0-9]*[a-z0-9])?` which means the first character must be a lowercase letter, and all following characters must be a dash, lowercase letter, or digit, except the last character, which cannot be a dash.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// [Output Only] Reserved for future use.
        /// </summary>
        [Input("satisfiesPzs")]
        public Input<bool>? SatisfiesPzs { get; set; }

        /// <summary>
        /// [Output Only] Server-defined fully-qualified URL for this resource.
        /// </summary>
        [Input("selfLink")]
        public Input<string>? SelfLink { get; set; }

        /// <summary>
        /// Reservation for instances with specific machine shapes.
        /// </summary>
        [Input("specificReservation")]
        public Input<Inputs.AllocationSpecificSKUReservationArgs>? SpecificReservation { get; set; }

        /// <summary>
        /// Indicates whether the reservation can be consumed by VMs with affinity for "any" reservation. If the field is set, then only VMs that target the reservation by name can consume from this reservation.
        /// </summary>
        [Input("specificReservationRequired")]
        public Input<bool>? SpecificReservationRequired { get; set; }

        /// <summary>
        /// [Output Only] The status of the reservation.
        /// </summary>
        [Input("status")]
        public Input<string>? Status { get; set; }

        /// <summary>
        /// Zone in which the reservation resides. A zone must be provided if the reservation is created within a commitment.
        /// </summary>
        [Input("zone")]
        public Input<string>? Zone { get; set; }

        public ReservationArgs()
        {
        }
    }
}