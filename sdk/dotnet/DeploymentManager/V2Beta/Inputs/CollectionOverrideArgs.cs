// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.DeploymentManager.V2Beta.Inputs
{

    /// <summary>
    /// CollectionOverride allows resource handling overrides for specific resources within a BaseType
    /// </summary>
    public sealed class CollectionOverrideArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The collection that identifies this resource within its service.
        /// </summary>
        [Input("collection")]
        public Input<string>? Collection { get; set; }

        /// <summary>
        /// The options to apply to this resource-level override
        /// </summary>
        [Input("options")]
        public Input<Inputs.OptionsArgs>? Options { get; set; }

        public CollectionOverrideArgs()
        {
        }
    }
}