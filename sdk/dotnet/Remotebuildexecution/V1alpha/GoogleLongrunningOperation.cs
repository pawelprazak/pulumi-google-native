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
    /// Creates a new worker pool with a specified size and configuration. Returns a long running operation which contains a worker pool on completion. While the long running operation is in progress, any call to `GetWorkerPool` returns a worker pool in state `CREATING`.
    /// </summary>
    [GoogleCloudResourceType("google-cloud:remotebuildexecution/v1alpha:GoogleLongrunningOperation")]
    public partial class GoogleLongrunningOperation : Pulumi.CustomResource
    {
        /// <summary>
        /// Create a GoogleLongrunningOperation resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public GoogleLongrunningOperation(string name, GoogleLongrunningOperationArgs args, CustomResourceOptions? options = null)
            : base("google-cloud:remotebuildexecution/v1alpha:GoogleLongrunningOperation", name, args ?? new GoogleLongrunningOperationArgs(), MakeResourceOptions(options, ""))
        {
        }

        private GoogleLongrunningOperation(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("google-cloud:remotebuildexecution/v1alpha:GoogleLongrunningOperation", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing GoogleLongrunningOperation resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static GoogleLongrunningOperation Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new GoogleLongrunningOperation(name, id, options);
        }
    }

    public sealed class GoogleLongrunningOperationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Resource name of the instance in which to create the new worker pool. Format: `projects/[PROJECT_ID]/instances/[INSTANCE_ID]`.
        /// </summary>
        [Input("parent", required: true)]
        public Input<string> Parent { get; set; } = null!;

        /// <summary>
        /// ID of the created worker pool. A valid pool ID must: be 6-50 characters long, contain only lowercase letters, digits, hyphens and underscores, start with a lowercase letter, and end with a lowercase letter or a digit.
        /// </summary>
        [Input("poolId")]
        public Input<string>? PoolId { get; set; }

        /// <summary>
        /// Specifies the worker pool to create. The name in the worker pool, if specified, is ignored.
        /// </summary>
        [Input("workerPool")]
        public Input<Inputs.GoogleDevtoolsRemotebuildexecutionAdminV1alphaWorkerPoolArgs>? WorkerPool { get; set; }

        public GoogleLongrunningOperationArgs()
        {
        }
    }
}