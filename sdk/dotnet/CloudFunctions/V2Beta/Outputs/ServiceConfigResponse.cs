// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.CloudFunctions.V2Beta.Outputs
{

    /// <summary>
    /// Describes the Service being deployed. Currently Supported : Cloud Run (fully managed).
    /// </summary>
    [OutputType]
    public sealed class ServiceConfigResponse
    {
        /// <summary>
        /// Whether 100% of traffic is routed to the latest revision. On CreateFunction and UpdateFunction, when set to true, the revision being deployed will serve 100% of traffic, ignoring any traffic split settings, if any. On GetFunction, true will be returned if the latest revision is serving 100% of traffic.
        /// </summary>
        public readonly bool AllTrafficOnLatestRevision;
        /// <summary>
        /// The amount of memory available for a function. Defaults to 256M. Supported units are k, M, G, Mi, Gi. If no unit is supplied the value is interpreted as bytes. See https://github.com/kubernetes/kubernetes/blob/master/staging/src/k8s.io/apimachinery/pkg/api/resource/quantity.go a full description.
        /// </summary>
        public readonly string AvailableMemory;
        /// <summary>
        /// Environment variables that shall be available during function execution.
        /// </summary>
        public readonly ImmutableDictionary<string, string> EnvironmentVariables;
        /// <summary>
        /// The ingress settings for the function, controlling what traffic can reach it.
        /// </summary>
        public readonly string IngressSettings;
        /// <summary>
        /// The limit on the maximum number of function instances that may coexist at a given time. In some cases, such as rapid traffic surges, Cloud Functions may, for a short period of time, create more instances than the specified max instances limit. If your function cannot tolerate this temporary behavior, you may want to factor in a safety margin and set a lower max instances value than your function can tolerate. See the [Max Instances](https://cloud.google.com/functions/docs/max-instances) Guide for more details.
        /// </summary>
        public readonly int MaxInstanceCount;
        /// <summary>
        /// The limit on the minimum number of function instances that may coexist at a given time. Function instances are kept in idle state for a short period after they finished executing the request to reduce cold start time for subsequent requests. Setting a minimum instance count will ensure that the given number of instances are kept running in idle state always. This can help with cold start times when jump in incoming request count occurs after the idle instance would have been stopped in the default case.
        /// </summary>
        public readonly int MinInstanceCount;
        /// <summary>
        /// Name of the service associated with a Function. The format of this field is `projects/{project}/locations/{region}/services/{service}`
        /// </summary>
        public readonly string Service;
        /// <summary>
        /// The email of the service's service account. If empty, defaults to `{project_number}-compute@developer.gserviceaccount.com`.
        /// </summary>
        public readonly string ServiceAccountEmail;
        /// <summary>
        /// The function execution timeout. Execution is considered failed and can be terminated if the function is not completed at the end of the timeout period. Defaults to 60 seconds.
        /// </summary>
        public readonly int TimeoutSeconds;
        /// <summary>
        /// URI of the Service deployed.
        /// </summary>
        public readonly string Uri;
        /// <summary>
        /// The Serverless VPC Access connector that this cloud function can connect to. The format of this field is `projects/*/locations/*/connectors/*`.
        /// </summary>
        public readonly string VpcConnector;
        /// <summary>
        /// The egress settings for the connector, controlling what traffic is diverted through it.
        /// </summary>
        public readonly string VpcConnectorEgressSettings;

        [OutputConstructor]
        private ServiceConfigResponse(
            bool allTrafficOnLatestRevision,

            string availableMemory,

            ImmutableDictionary<string, string> environmentVariables,

            string ingressSettings,

            int maxInstanceCount,

            int minInstanceCount,

            string service,

            string serviceAccountEmail,

            int timeoutSeconds,

            string uri,

            string vpcConnector,

            string vpcConnectorEgressSettings)
        {
            AllTrafficOnLatestRevision = allTrafficOnLatestRevision;
            AvailableMemory = availableMemory;
            EnvironmentVariables = environmentVariables;
            IngressSettings = ingressSettings;
            MaxInstanceCount = maxInstanceCount;
            MinInstanceCount = minInstanceCount;
            Service = service;
            ServiceAccountEmail = serviceAccountEmail;
            TimeoutSeconds = timeoutSeconds;
            Uri = uri;
            VpcConnector = vpcConnector;
            VpcConnectorEgressSettings = vpcConnectorEgressSettings;
        }
    }
}