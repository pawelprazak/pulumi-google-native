// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.NetworkServices.V1Beta1
{
    /// <summary>
    /// Creates a new Mesh in a given project and location.
    /// </summary>
    [GoogleNativeResourceType("google-native:networkservices/v1beta1:Mesh")]
    public partial class Mesh : Pulumi.CustomResource
    {
        /// <summary>
        /// The timestamp when the resource was created.
        /// </summary>
        [Output("createTime")]
        public Output<string> CreateTime { get; private set; } = null!;

        /// <summary>
        /// Optional. A free-text description of the resource. Max length 1024 characters.
        /// </summary>
        [Output("description")]
        public Output<string> Description { get; private set; } = null!;

        /// <summary>
        /// Optional. If set to a valid TCP port (1-65535), instructs the SIDECAR proxy to listen on the specified port of localhost (127.0.0.1) address. The SIDECAR proxy will expect all traffic to be redirected to this port regardless of its actual ip:port destination. If unset, a port '15001' is used as the interception port. This will is applicable only for sidecar proxy deployments.
        /// </summary>
        [Output("interceptionPort")]
        public Output<int> InterceptionPort { get; private set; } = null!;

        /// <summary>
        /// Optional. Set of label tags associated with the Mesh resource.
        /// </summary>
        [Output("labels")]
        public Output<ImmutableDictionary<string, string>> Labels { get; private set; } = null!;

        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// Required. Short name of the Mesh resource to be created.
        /// </summary>
        [Output("meshId")]
        public Output<string> MeshId { get; private set; } = null!;

        /// <summary>
        /// Name of the Mesh resource. It matches pattern `projects/*/locations/global/meshes/`.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        [Output("project")]
        public Output<string> Project { get; private set; } = null!;

        /// <summary>
        /// Server-defined URL of this resource
        /// </summary>
        [Output("selfLink")]
        public Output<string> SelfLink { get; private set; } = null!;

        /// <summary>
        /// The timestamp when the resource was updated.
        /// </summary>
        [Output("updateTime")]
        public Output<string> UpdateTime { get; private set; } = null!;


        /// <summary>
        /// Create a Mesh resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Mesh(string name, MeshArgs args, CustomResourceOptions? options = null)
            : base("google-native:networkservices/v1beta1:Mesh", name, args ?? new MeshArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Mesh(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("google-native:networkservices/v1beta1:Mesh", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing Mesh resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Mesh Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Mesh(name, id, options);
        }
    }

    public sealed class MeshArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Optional. A free-text description of the resource. Max length 1024 characters.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Optional. If set to a valid TCP port (1-65535), instructs the SIDECAR proxy to listen on the specified port of localhost (127.0.0.1) address. The SIDECAR proxy will expect all traffic to be redirected to this port regardless of its actual ip:port destination. If unset, a port '15001' is used as the interception port. This will is applicable only for sidecar proxy deployments.
        /// </summary>
        [Input("interceptionPort")]
        public Input<int>? InterceptionPort { get; set; }

        [Input("labels")]
        private InputMap<string>? _labels;

        /// <summary>
        /// Optional. Set of label tags associated with the Mesh resource.
        /// </summary>
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// Required. Short name of the Mesh resource to be created.
        /// </summary>
        [Input("meshId", required: true)]
        public Input<string> MeshId { get; set; } = null!;

        /// <summary>
        /// Name of the Mesh resource. It matches pattern `projects/*/locations/global/meshes/`.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("project")]
        public Input<string>? Project { get; set; }

        public MeshArgs()
        {
        }
    }
}