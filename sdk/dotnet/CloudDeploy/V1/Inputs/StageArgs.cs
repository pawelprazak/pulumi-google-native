// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.CloudDeploy.V1.Inputs
{

    /// <summary>
    /// Stage specifies a location to which to deploy.
    /// </summary>
    public sealed class StageArgs : Pulumi.ResourceArgs
    {
        [Input("profiles")]
        private InputList<string>? _profiles;

        /// <summary>
        /// Skaffold profiles to use when rendering the manifest for this stage's `Target`.
        /// </summary>
        public InputList<string> Profiles
        {
            get => _profiles ?? (_profiles = new InputList<string>());
            set => _profiles = value;
        }

        /// <summary>
        /// The target_id to which this stage points. This field refers exclusively to the last segment of a target name. For example, this field would just be `my-target` (rather than `projects/project/locations/location/targets/my-target`). The location of the `Target` is inferred to be the same as the location of the `DeliveryPipeline` that contains this `Stage`.
        /// </summary>
        [Input("targetId")]
        public Input<string>? TargetId { get; set; }

        public StageArgs()
        {
        }
    }
}
