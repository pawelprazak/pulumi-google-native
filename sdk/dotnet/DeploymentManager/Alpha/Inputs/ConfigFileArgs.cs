// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.DeploymentManager.Alpha.Inputs
{

    public sealed class ConfigFileArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The contents of the file.
        /// </summary>
        [Input("content")]
        public Input<string>? Content { get; set; }

        public ConfigFileArgs()
        {
        }
    }
}
