// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.GameServices.V1.Inputs
{

    /// <summary>
    /// The game server cluster connection information.
    /// </summary>
    public sealed class GameServerClusterConnectionInfoArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Reference to the GKE cluster where the game servers are installed.
        /// </summary>
        [Input("gkeClusterReference")]
        public Input<Inputs.GkeClusterReferenceArgs>? GkeClusterReference { get; set; }

        /// <summary>
        /// Namespace designated on the game server cluster where the Agones game server instances will be created. Existence of the namespace will be validated during creation.
        /// </summary>
        [Input("namespace")]
        public Input<string>? Namespace { get; set; }

        public GameServerClusterConnectionInfoArgs()
        {
        }
    }
}
