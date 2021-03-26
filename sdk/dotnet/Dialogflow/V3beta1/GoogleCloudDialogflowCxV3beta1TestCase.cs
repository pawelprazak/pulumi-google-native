// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.Dialogflow.V3beta1
{
    /// <summary>
    /// Creates a test case for the given agent.
    /// </summary>
    [GoogleCloudResourceType("google-cloud:dialogflow/v3beta1:GoogleCloudDialogflowCxV3beta1TestCase")]
    public partial class GoogleCloudDialogflowCxV3beta1TestCase : Pulumi.CustomResource
    {
        /// <summary>
        /// Create a GoogleCloudDialogflowCxV3beta1TestCase resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public GoogleCloudDialogflowCxV3beta1TestCase(string name, GoogleCloudDialogflowCxV3beta1TestCaseArgs args, CustomResourceOptions? options = null)
            : base("google-cloud:dialogflow/v3beta1:GoogleCloudDialogflowCxV3beta1TestCase", name, args ?? new GoogleCloudDialogflowCxV3beta1TestCaseArgs(), MakeResourceOptions(options, ""))
        {
        }

        private GoogleCloudDialogflowCxV3beta1TestCase(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("google-cloud:dialogflow/v3beta1:GoogleCloudDialogflowCxV3beta1TestCase", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing GoogleCloudDialogflowCxV3beta1TestCase resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static GoogleCloudDialogflowCxV3beta1TestCase Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new GoogleCloudDialogflowCxV3beta1TestCase(name, id, options);
        }
    }

    public sealed class GoogleCloudDialogflowCxV3beta1TestCaseArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Output only. When the test was created.
        /// </summary>
        [Input("creationTime")]
        public Input<string>? CreationTime { get; set; }

        /// <summary>
        /// Required. The human-readable name of the test case, unique within the agent. Limit of 200 characters.
        /// </summary>
        [Input("displayName")]
        public Input<string>? DisplayName { get; set; }

        /// <summary>
        /// The latest test result.
        /// </summary>
        [Input("lastTestResult")]
        public Input<Inputs.GoogleCloudDialogflowCxV3beta1TestCaseResultArgs>? LastTestResult { get; set; }

        /// <summary>
        /// The unique identifier of the test case. TestCases.CreateTestCase will populate the name automatically. Otherwise use format: `projects//locations//agents/ /testCases/`.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Additional freeform notes about the test case. Limit of 400 characters.
        /// </summary>
        [Input("notes")]
        public Input<string>? Notes { get; set; }

        /// <summary>
        /// Required. The agent to create the test case for. Format: `projects//locations//agents/`.
        /// </summary>
        [Input("parent", required: true)]
        public Input<string> Parent { get; set; } = null!;

        [Input("tags")]
        private InputList<string>? _tags;

        /// <summary>
        /// Tags are short descriptions that users may apply to test cases for organizational and filtering purposes. Each tag should start with "#" and has a limit of 30 characters.
        /// </summary>
        public InputList<string> Tags
        {
            get => _tags ?? (_tags = new InputList<string>());
            set => _tags = value;
        }

        [Input("testCaseConversationTurns")]
        private InputList<Inputs.GoogleCloudDialogflowCxV3beta1ConversationTurnArgs>? _testCaseConversationTurns;

        /// <summary>
        /// The conversation turns uttered when the test case was created, in chronological order. These include the canonical set of agent utterances that should occur when the agent is working properly.
        /// </summary>
        public InputList<Inputs.GoogleCloudDialogflowCxV3beta1ConversationTurnArgs> TestCaseConversationTurns
        {
            get => _testCaseConversationTurns ?? (_testCaseConversationTurns = new InputList<Inputs.GoogleCloudDialogflowCxV3beta1ConversationTurnArgs>());
            set => _testCaseConversationTurns = value;
        }

        /// <summary>
        /// Config for the test case.
        /// </summary>
        [Input("testConfig")]
        public Input<Inputs.GoogleCloudDialogflowCxV3beta1TestConfigArgs>? TestConfig { get; set; }

        public GoogleCloudDialogflowCxV3beta1TestCaseArgs()
        {
        }
    }
}