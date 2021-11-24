// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.VMMigration.V1
{
    /// <summary>
    /// Creates a new TargetProject in a given project. NOTE: TargetProject is a global resource; hence the only supported value for location is `global`.
    /// </summary>
    [GoogleNativeResourceType("google-native:vmmigration/v1:TargetProject")]
    public partial class TargetProject : Pulumi.CustomResource
    {
        /// <summary>
        /// The time this target project resource was created (not related to when the Compute Engine project it points to was created).
        /// </summary>
        [Output("createTime")]
        public Output<string> CreateTime { get; private set; } = null!;

        /// <summary>
        /// The target project's description.
        /// </summary>
        [Output("description")]
        public Output<string> Description { get; private set; } = null!;

        /// <summary>
        /// The name of the target project.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The target project ID (number) or project name.
        /// </summary>
        [Output("project")]
        public Output<string> Project { get; private set; } = null!;

        /// <summary>
        /// The last time the target project resource was updated.
        /// </summary>
        [Output("updateTime")]
        public Output<string> UpdateTime { get; private set; } = null!;


        /// <summary>
        /// Create a TargetProject resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public TargetProject(string name, TargetProjectArgs args, CustomResourceOptions? options = null)
            : base("google-native:vmmigration/v1:TargetProject", name, args ?? new TargetProjectArgs(), MakeResourceOptions(options, ""))
        {
        }

        private TargetProject(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("google-native:vmmigration/v1:TargetProject", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing TargetProject resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static TargetProject Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new TargetProject(name, id, options);
        }
    }

    public sealed class TargetProjectArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The target project's description.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// The name of the target project.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The target project ID (number) or project name.
        /// </summary>
        [Input("project")]
        public Input<string>? Project { get; set; }

        [Input("requestId")]
        public Input<string>? RequestId { get; set; }

        [Input("targetProjectId", required: true)]
        public Input<string> TargetProjectId { get; set; } = null!;

        public TargetProjectArgs()
        {
        }
    }
}