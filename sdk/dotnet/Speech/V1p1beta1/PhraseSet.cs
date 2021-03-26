// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.Speech.V1p1beta1
{
    /// <summary>
    /// Create a set of phrase hints. Each item in the set can be a single word or a multi-word phrase. The items in the PhraseSet are favored by the recognition model when you send a call that includes the PhraseSet.
    /// </summary>
    [GoogleCloudResourceType("google-cloud:speech/v1p1beta1:PhraseSet")]
    public partial class PhraseSet : Pulumi.CustomResource
    {
        /// <summary>
        /// Create a PhraseSet resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public PhraseSet(string name, PhraseSetArgs args, CustomResourceOptions? options = null)
            : base("google-cloud:speech/v1p1beta1:PhraseSet", name, args ?? new PhraseSetArgs(), MakeResourceOptions(options, ""))
        {
        }

        private PhraseSet(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("google-cloud:speech/v1p1beta1:PhraseSet", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing PhraseSet resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static PhraseSet Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new PhraseSet(name, id, options);
        }
    }

    public sealed class PhraseSetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Required. The parent resource where this phrase set will be created. Format: {api_version}/projects/{project}/locations/{location}/phraseSets
        /// </summary>
        [Input("parent", required: true)]
        public Input<string> Parent { get; set; } = null!;

        /// <summary>
        /// Required. The phrase set to create.
        /// </summary>
        [Input("phraseSet")]
        public Input<Inputs.PhraseSetArgs>? PhraseSet { get; set; }

        /// <summary>
        /// The ID to use for the phrase set, which will become the final component of the phrase set's resource name. This value should be 4-63 characters, and valid characters are /a-z-/.
        /// </summary>
        [Input("phraseSetId")]
        public Input<string>? PhraseSetId { get; set; }

        public PhraseSetArgs()
        {
        }
    }
}