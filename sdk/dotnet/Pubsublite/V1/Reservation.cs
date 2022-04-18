// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.Pubsublite.V1
{
    /// <summary>
    /// Creates a new reservation.
    /// </summary>
    [GoogleNativeResourceType("google-native:pubsublite/v1:Reservation")]
    public partial class Reservation : Pulumi.CustomResource
    {
        /// <summary>
        /// The name of the reservation. Structured like: projects/{project_number}/locations/{location}/reservations/{reservation_id}
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The reserved throughput capacity. Every unit of throughput capacity is equivalent to 1 MiB/s of published messages or 2 MiB/s of subscribed messages. Any topics which are declared as using capacity from a Reservation will consume resources from this reservation instead of being charged individually.
        /// </summary>
        [Output("throughputCapacity")]
        public Output<string> ThroughputCapacity { get; private set; } = null!;


        /// <summary>
        /// Create a Reservation resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Reservation(string name, ReservationArgs args, CustomResourceOptions? options = null)
            : base("google-native:pubsublite/v1:Reservation", name, args ?? new ReservationArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Reservation(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("google-native:pubsublite/v1:Reservation", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Reservation resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Reservation Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Reservation(name, id, options);
        }
    }

    public sealed class ReservationArgs : Pulumi.ResourceArgs
    {
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// The name of the reservation. Structured like: projects/{project_number}/locations/{location}/reservations/{reservation_id}
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("project")]
        public Input<string>? Project { get; set; }

        /// <summary>
        /// Required. The ID to use for the reservation, which will become the final component of the reservation's name. This value is structured like: `my-reservation-name`.
        /// </summary>
        [Input("reservationId", required: true)]
        public Input<string> ReservationId { get; set; } = null!;

        /// <summary>
        /// The reserved throughput capacity. Every unit of throughput capacity is equivalent to 1 MiB/s of published messages or 2 MiB/s of subscribed messages. Any topics which are declared as using capacity from a Reservation will consume resources from this reservation instead of being charged individually.
        /// </summary>
        [Input("throughputCapacity")]
        public Input<string>? ThroughputCapacity { get; set; }

        public ReservationArgs()
        {
        }
    }
}