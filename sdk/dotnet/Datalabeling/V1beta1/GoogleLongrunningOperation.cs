// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.Datalabeling.V1beta1
{
    /// <summary>
    /// Create a FeedbackMessage object.
    /// </summary>
    [GoogleCloudResourceType("google-cloud:datalabeling/v1beta1:GoogleLongrunningOperation")]
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
            : base("google-cloud:datalabeling/v1beta1:GoogleLongrunningOperation", name, args ?? new GoogleLongrunningOperationArgs(), MakeResourceOptions(options, ""))
        {
        }

        private GoogleLongrunningOperation(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("google-cloud:datalabeling/v1beta1:GoogleLongrunningOperation", name, null, MakeResourceOptions(options, id))
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
        /// String content of the feedback. Maximum of 10000 characters.
        /// </summary>
        [Input("body")]
        public Input<string>? Body { get; set; }

        /// <summary>
        /// Create time.
        /// </summary>
        [Input("createTime")]
        public Input<string>? CreateTime { get; set; }

        /// <summary>
        /// The image storing this feedback if the feedback is an image representing operator's comments.
        /// </summary>
        [Input("image")]
        public Input<string>? Image { get; set; }

        /// <summary>
        /// Name of the feedback message in a feedback thread. Format: 'project/{project_id}/datasets/{dataset_id}/annotatedDatasets/{annotated_dataset_id}/feedbackThreads/{feedback_thread_id}/feedbackMessage/{feedback_message_id}'
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("operatorFeedbackMetadata")]
        public Input<Inputs.GoogleCloudDatalabelingV1beta1OperatorFeedbackMetadataArgs>? OperatorFeedbackMetadata { get; set; }

        /// <summary>
        /// Required. FeedbackMessage resource parent, format: projects/{project_id}/datasets/{dataset_id}/annotatedDatasets/{annotated_dataset_id}/feedbackThreads/{feedback_thread_id}.
        /// </summary>
        [Input("parent", required: true)]
        public Input<string> Parent { get; set; } = null!;

        [Input("requesterFeedbackMetadata")]
        public Input<Inputs.GoogleCloudDatalabelingV1beta1RequesterFeedbackMetadataArgs>? RequesterFeedbackMetadata { get; set; }

        public GoogleLongrunningOperationArgs()
        {
        }
    }
}