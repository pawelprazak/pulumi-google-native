// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.DeploymentManager.Alpha.Inputs
{

    /// <summary>
    /// Deployment Manager will call these methods during the events of creation/deletion/update/get/setIamPolicy
    /// </summary>
    public sealed class MethodMapArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The action identifier for the create method to be used for this collection
        /// </summary>
        [Input("create")]
        public Input<string>? Create { get; set; }

        /// <summary>
        /// The action identifier for the delete method to be used for this collection
        /// </summary>
        [Input("delete")]
        public Input<string>? Delete { get; set; }

        /// <summary>
        /// The action identifier for the get method to be used for this collection
        /// </summary>
        [Input("get")]
        public Input<string>? Get { get; set; }

        /// <summary>
        /// The action identifier for the setIamPolicy method to be used for this collection
        /// </summary>
        [Input("setIamPolicy")]
        public Input<string>? SetIamPolicy { get; set; }

        /// <summary>
        /// The action identifier for the update method to be used for this collection
        /// </summary>
        [Input("update")]
        public Input<string>? Update { get; set; }

        public MethodMapArgs()
        {
        }
    }
}
