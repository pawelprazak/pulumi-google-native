// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.Remotebuildexecution.V1alpha
{
    /// <summary>
    /// Creates a new instance in the specified region. Returns a long running operation which contains an instance on completion. While the long running operation is in progress, any call to `GetInstance` returns an instance in state `CREATING`.
    /// </summary>
    [GoogleCloudResourceType("google-cloud:remotebuildexecution/v1alpha:Instance")]
    public partial class Instance : Pulumi.CustomResource
    {
        /// <summary>
        /// The policy to define whether or not RBE features can be used or how they can be used.
        /// </summary>
        [Output("featurePolicy")]
        public Output<Outputs.GoogleDevtoolsRemotebuildexecutionAdminV1alphaFeaturePolicyResponse> FeaturePolicy { get; private set; } = null!;

        /// <summary>
        /// The location is a GCP region. Currently only `us-central1` is supported.
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// Whether stack driver logging is enabled for the instance.
        /// </summary>
        [Output("loggingEnabled")]
        public Output<bool> LoggingEnabled { get; private set; } = null!;

        /// <summary>
        /// Instance resource name formatted as: `projects/[PROJECT_ID]/instances/[INSTANCE_ID]`. Name should not be populated when creating an instance since it is provided in the `instance_id` field.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// State of the instance.
        /// </summary>
        [Output("state")]
        public Output<string> State { get; private set; } = null!;


        /// <summary>
        /// Create a Instance resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Instance(string name, InstanceArgs args, CustomResourceOptions? options = null)
            : base("google-cloud:remotebuildexecution/v1alpha:Instance", name, args ?? new InstanceArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Instance(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("google-cloud:remotebuildexecution/v1alpha:Instance", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing Instance resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Instance Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Instance(name, id, options);
        }
    }

    public sealed class InstanceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The policy to define whether or not RBE features can be used or how they can be used.
        /// </summary>
        [Input("featurePolicy")]
        public Input<Inputs.GoogleDevtoolsRemotebuildexecutionAdminV1alphaFeaturePolicyArgs>? FeaturePolicy { get; set; }

        /// <summary>
        /// ID of the created instance. A valid `instance_id` must: be 6-50 characters long, contain only lowercase letters, digits, hyphens and underscores, start with a lowercase letter, and end with a lowercase letter or a digit.
        /// </summary>
        [Input("instanceId")]
        public Input<string>? InstanceId { get; set; }

        [Input("instancesId", required: true)]
        public Input<string> InstancesId { get; set; } = null!;

        /// <summary>
        /// The location is a GCP region. Currently only `us-central1` is supported.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// Whether stack driver logging is enabled for the instance.
        /// </summary>
        [Input("loggingEnabled")]
        public Input<bool>? LoggingEnabled { get; set; }

        /// <summary>
        /// Instance resource name formatted as: `projects/[PROJECT_ID]/instances/[INSTANCE_ID]`. Name should not be populated when creating an instance since it is provided in the `instance_id` field.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Resource name of the project containing the instance. Format: `projects/[PROJECT_ID]`.
        /// </summary>
        [Input("parent")]
        public Input<string>? Parent { get; set; }

        [Input("projectsId", required: true)]
        public Input<string> ProjectsId { get; set; } = null!;

        /// <summary>
        /// State of the instance.
        /// </summary>
        [Input("state")]
        public Input<string>? State { get; set; }

        public InstanceArgs()
        {
        }
    }
}