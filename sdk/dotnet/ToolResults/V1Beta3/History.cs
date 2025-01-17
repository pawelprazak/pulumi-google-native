// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.ToolResults.V1Beta3
{
    /// <summary>
    /// Creates a History. The returned History will have the id set. May return any of the following canonical error codes: - PERMISSION_DENIED - if the user is not authorized to write to project - INVALID_ARGUMENT - if the request is malformed - NOT_FOUND - if the containing project does not exist
    /// Note - this resource's API doesn't support deletion. When deleted, the resource will persist
    /// on Google Cloud even though it will be deleted from Pulumi state.
    /// </summary>
    [GoogleNativeResourceType("google-native:toolresults/v1beta3:History")]
    public partial class History : Pulumi.CustomResource
    {
        /// <summary>
        /// A short human-readable (plain text) name to display in the UI. Maximum of 100 characters. - In response: present if set during create. - In create request: optional
        /// </summary>
        [Output("displayName")]
        public Output<string> DisplayName { get; private set; } = null!;

        /// <summary>
        /// A unique identifier within a project for this History. Returns INVALID_ARGUMENT if this field is set or overwritten by the caller. - In response always set - In create request: never set
        /// </summary>
        [Output("historyId")]
        public Output<string> HistoryId { get; private set; } = null!;

        /// <summary>
        /// A name to uniquely identify a history within a project. Maximum of 200 characters. - In response always set - In create request: always set
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        [Output("project")]
        public Output<string> Project { get; private set; } = null!;

        /// <summary>
        /// A unique request ID for server to detect duplicated requests. For example, a UUID. Optional, but strongly recommended.
        /// </summary>
        [Output("requestId")]
        public Output<string?> RequestId { get; private set; } = null!;

        /// <summary>
        /// The platform of the test history. - In response: always set. Returns the platform of the last execution if unknown.
        /// </summary>
        [Output("testPlatform")]
        public Output<string> TestPlatform { get; private set; } = null!;


        /// <summary>
        /// Create a History resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public History(string name, HistoryArgs? args = null, CustomResourceOptions? options = null)
            : base("google-native:toolresults/v1beta3:History", name, args ?? new HistoryArgs(), MakeResourceOptions(options, ""))
        {
        }

        private History(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("google-native:toolresults/v1beta3:History", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing History resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static History Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new History(name, id, options);
        }
    }

    public sealed class HistoryArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A short human-readable (plain text) name to display in the UI. Maximum of 100 characters. - In response: present if set during create. - In create request: optional
        /// </summary>
        [Input("displayName")]
        public Input<string>? DisplayName { get; set; }

        /// <summary>
        /// A unique identifier within a project for this History. Returns INVALID_ARGUMENT if this field is set or overwritten by the caller. - In response always set - In create request: never set
        /// </summary>
        [Input("historyId")]
        public Input<string>? HistoryId { get; set; }

        /// <summary>
        /// A name to uniquely identify a history within a project. Maximum of 200 characters. - In response always set - In create request: always set
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("project")]
        public Input<string>? Project { get; set; }

        /// <summary>
        /// A unique request ID for server to detect duplicated requests. For example, a UUID. Optional, but strongly recommended.
        /// </summary>
        [Input("requestId")]
        public Input<string>? RequestId { get; set; }

        /// <summary>
        /// The platform of the test history. - In response: always set. Returns the platform of the last execution if unknown.
        /// </summary>
        [Input("testPlatform")]
        public Input<Pulumi.GoogleNative.ToolResults.V1Beta3.HistoryTestPlatform>? TestPlatform { get; set; }

        public HistoryArgs()
        {
        }
    }
}
