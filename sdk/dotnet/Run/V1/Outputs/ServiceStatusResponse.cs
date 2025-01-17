// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.Run.V1.Outputs
{

    /// <summary>
    /// The current state of the Service. Output only.
    /// </summary>
    [OutputType]
    public sealed class ServiceStatusResponse
    {
        /// <summary>
        /// From RouteStatus. Similar to url, information on where the service is available on HTTP.
        /// </summary>
        public readonly Outputs.AddressableResponse Address;
        /// <summary>
        /// Conditions communicates information about ongoing/complete reconciliation processes that bring the "spec" inline with the observed state of the world. Service-specific conditions include: * "ConfigurationsReady": true when the underlying Configuration is ready. * "RoutesReady": true when the underlying Route is ready. * "Ready": true when both the underlying Route and Configuration are ready.
        /// </summary>
        public readonly ImmutableArray<Outputs.GoogleCloudRunV1ConditionResponse> Conditions;
        /// <summary>
        /// From ConfigurationStatus. LatestCreatedRevisionName is the last revision that was created from this Service's Configuration. It might not be ready yet, for that use LatestReadyRevisionName.
        /// </summary>
        public readonly string LatestCreatedRevisionName;
        /// <summary>
        /// From ConfigurationStatus. LatestReadyRevisionName holds the name of the latest Revision stamped out from this Service's Configuration that has had its "Ready" condition become "True".
        /// </summary>
        public readonly string LatestReadyRevisionName;
        /// <summary>
        /// ObservedGeneration is the 'Generation' of the Route that was last processed by the controller. Clients polling for completed reconciliation should poll until observedGeneration = metadata.generation and the Ready condition's status is True or False.
        /// </summary>
        public readonly int ObservedGeneration;
        /// <summary>
        /// From RouteStatus. Traffic holds the configured traffic distribution. These entries will always contain RevisionName references. When ConfigurationName appears in the spec, this will hold the LatestReadyRevisionName that we last observed.
        /// </summary>
        public readonly ImmutableArray<Outputs.TrafficTargetResponse> Traffic;
        /// <summary>
        /// From RouteStatus. URL holds the url that will distribute traffic over the provided traffic targets. It generally has the form https://{route-hash}-{project-hash}-{cluster-level-suffix}.a.run.app
        /// </summary>
        public readonly string Url;

        [OutputConstructor]
        private ServiceStatusResponse(
            Outputs.AddressableResponse address,

            ImmutableArray<Outputs.GoogleCloudRunV1ConditionResponse> conditions,

            string latestCreatedRevisionName,

            string latestReadyRevisionName,

            int observedGeneration,

            ImmutableArray<Outputs.TrafficTargetResponse> traffic,

            string url)
        {
            Address = address;
            Conditions = conditions;
            LatestCreatedRevisionName = latestCreatedRevisionName;
            LatestReadyRevisionName = latestReadyRevisionName;
            ObservedGeneration = observedGeneration;
            Traffic = traffic;
            Url = url;
        }
    }
}
