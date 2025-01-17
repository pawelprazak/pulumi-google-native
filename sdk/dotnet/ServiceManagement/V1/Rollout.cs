// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.ServiceManagement.V1
{
    /// <summary>
    /// Creates a new service configuration rollout. Based on rollout, the Google Service Management will roll out the service configurations to different backend services. For example, the logging configuration will be pushed to Google Cloud Logging. Please note that any previous pending and running Rollouts and associated Operations will be automatically cancelled so that the latest Rollout will not be blocked by previous Rollouts. Only the 100 most recent (in any state) and the last 10 successful (if not already part of the set of 100 most recent) rollouts are kept for each service. The rest will be deleted eventually. Operation
    /// Auto-naming is currently not supported for this resource.
    /// Note - this resource's API doesn't support deletion. When deleted, the resource will persist
    /// on Google Cloud even though it will be deleted from Pulumi state.
    /// </summary>
    [GoogleNativeResourceType("google-native:servicemanagement/v1:Rollout")]
    public partial class Rollout : Pulumi.CustomResource
    {
        /// <summary>
        /// Creation time of the rollout. Readonly.
        /// </summary>
        [Output("createTime")]
        public Output<string> CreateTime { get; private set; } = null!;

        /// <summary>
        /// The user who created the Rollout. Readonly.
        /// </summary>
        [Output("createdBy")]
        public Output<string> CreatedBy { get; private set; } = null!;

        /// <summary>
        /// The strategy associated with a rollout to delete a `ManagedService`. Readonly.
        /// </summary>
        [Output("deleteServiceStrategy")]
        public Output<Outputs.DeleteServiceStrategyResponse> DeleteServiceStrategy { get; private set; } = null!;

        /// <summary>
        /// Optional. Unique identifier of this Rollout. Must be no longer than 63 characters and only lower case letters, digits, '.', '_' and '-' are allowed. If not specified by client, the server will generate one. The generated id will have the form of , where "date" is the create date in ISO 8601 format. "revision number" is a monotonically increasing positive number that is reset every day for each service. An example of the generated rollout_id is '2016-02-16r1'
        /// </summary>
        [Output("rolloutId")]
        public Output<string> RolloutId { get; private set; } = null!;

        [Output("serviceName")]
        public Output<string> ServiceName { get; private set; } = null!;

        /// <summary>
        /// The status of this rollout. Readonly. In case of a failed rollout, the system will automatically rollback to the current Rollout version. Readonly.
        /// </summary>
        [Output("status")]
        public Output<string> Status { get; private set; } = null!;

        /// <summary>
        /// Google Service Control selects service configurations based on traffic percentage.
        /// </summary>
        [Output("trafficPercentStrategy")]
        public Output<Outputs.TrafficPercentStrategyResponse> TrafficPercentStrategy { get; private set; } = null!;


        /// <summary>
        /// Create a Rollout resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Rollout(string name, RolloutArgs args, CustomResourceOptions? options = null)
            : base("google-native:servicemanagement/v1:Rollout", name, args ?? new RolloutArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Rollout(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("google-native:servicemanagement/v1:Rollout", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing Rollout resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Rollout Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Rollout(name, id, options);
        }
    }

    public sealed class RolloutArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Creation time of the rollout. Readonly.
        /// </summary>
        [Input("createTime")]
        public Input<string>? CreateTime { get; set; }

        /// <summary>
        /// The user who created the Rollout. Readonly.
        /// </summary>
        [Input("createdBy")]
        public Input<string>? CreatedBy { get; set; }

        /// <summary>
        /// The strategy associated with a rollout to delete a `ManagedService`. Readonly.
        /// </summary>
        [Input("deleteServiceStrategy")]
        public Input<Inputs.DeleteServiceStrategyArgs>? DeleteServiceStrategy { get; set; }

        /// <summary>
        /// Optional. Unique identifier of this Rollout. Must be no longer than 63 characters and only lower case letters, digits, '.', '_' and '-' are allowed. If not specified by client, the server will generate one. The generated id will have the form of , where "date" is the create date in ISO 8601 format. "revision number" is a monotonically increasing positive number that is reset every day for each service. An example of the generated rollout_id is '2016-02-16r1'
        /// </summary>
        [Input("rolloutId")]
        public Input<string>? RolloutId { get; set; }

        /// <summary>
        /// The name of the service associated with this Rollout.
        /// </summary>
        [Input("serviceName", required: true)]
        public Input<string> ServiceName { get; set; } = null!;

        /// <summary>
        /// Google Service Control selects service configurations based on traffic percentage.
        /// </summary>
        [Input("trafficPercentStrategy")]
        public Input<Inputs.TrafficPercentStrategyArgs>? TrafficPercentStrategy { get; set; }

        public RolloutArgs()
        {
        }
    }
}
