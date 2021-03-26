// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.Pubsub.V1
{
    /// <summary>
    /// Creates the given topic with the given name. See the [resource name rules] (https://cloud.google.com/pubsub/docs/admin#resource_names).
    /// </summary>
    [GoogleCloudResourceType("google-cloud:pubsub/v1:Topic")]
    public partial class Topic : Pulumi.CustomResource
    {
        /// <summary>
        /// Create a Topic resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Topic(string name, TopicArgs args, CustomResourceOptions? options = null)
            : base("google-cloud:pubsub/v1:Topic", name, args ?? new TopicArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Topic(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("google-cloud:pubsub/v1:Topic", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing Topic resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Topic Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Topic(name, id, options);
        }
    }

    public sealed class TopicArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The resource name of the Cloud KMS CryptoKey to be used to protect access to messages published on this topic. The expected format is `projects/*/locations/*/keyRings/*/cryptoKeys/*`.
        /// </summary>
        [Input("kmsKeyName")]
        public Input<string>? KmsKeyName { get; set; }

        [Input("labels")]
        private InputMap<string>? _labels;

        /// <summary>
        /// See [Creating and managing labels] (https://cloud.google.com/pubsub/docs/labels).
        /// </summary>
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        /// <summary>
        /// Policy constraining the set of Google Cloud Platform regions where messages published to the topic may be stored. If not present, then no constraints are in effect.
        /// </summary>
        [Input("messageStoragePolicy")]
        public Input<Inputs.MessageStoragePolicyArgs>? MessageStoragePolicy { get; set; }

        /// <summary>
        /// Required. The name of the topic. It must have the format `"projects/{project}/topics/{topic}"`. `{topic}` must start with a letter, and contain only letters (`[A-Za-z]`), numbers (`[0-9]`), dashes (`-`), underscores (`_`), periods (`.`), tildes (`~`), plus (`+`) or percent signs (`%`). It must be between 3 and 255 characters in length, and it must not start with `"goog"`.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// Reserved for future use. This field is set only in responses from the server; it is ignored if it is set in any requests.
        /// </summary>
        [Input("satisfiesPzs")]
        public Input<bool>? SatisfiesPzs { get; set; }

        /// <summary>
        /// Settings for validating messages published against a schema.
        /// </summary>
        [Input("schemaSettings")]
        public Input<Inputs.SchemaSettingsArgs>? SchemaSettings { get; set; }

        public TopicArgs()
        {
        }
    }
}