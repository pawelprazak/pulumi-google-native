// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.ContainerAnalysis.V1.Inputs
{

    /// <summary>
    /// The period during which some deployable was active in a runtime.
    /// </summary>
    public sealed class DeploymentOccurrenceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Address of the runtime element hosting this deployment.
        /// </summary>
        [Input("address")]
        public Input<string>? Address { get; set; }

        /// <summary>
        /// Configuration used to create this deployment.
        /// </summary>
        [Input("config")]
        public Input<string>? Config { get; set; }

        /// <summary>
        /// Beginning of the lifetime of this deployment.
        /// </summary>
        [Input("deployTime", required: true)]
        public Input<string> DeployTime { get; set; } = null!;

        /// <summary>
        /// Platform hosting this deployment.
        /// </summary>
        [Input("platform")]
        public Input<Pulumi.GoogleNative.ContainerAnalysis.V1.DeploymentOccurrencePlatform>? Platform { get; set; }

        /// <summary>
        /// End of the lifetime of this deployment.
        /// </summary>
        [Input("undeployTime")]
        public Input<string>? UndeployTime { get; set; }

        /// <summary>
        /// Identity of the user that triggered this deployment.
        /// </summary>
        [Input("userEmail")]
        public Input<string>? UserEmail { get; set; }

        public DeploymentOccurrenceArgs()
        {
        }
    }
}
