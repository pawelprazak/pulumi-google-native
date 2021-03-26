// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.Cloudbuild.V1
{
    /// <summary>
    /// Creates a new `BuildTrigger`. This API is experimental.
    /// </summary>
    [GoogleCloudResourceType("google-cloud:cloudbuild/v1:BuildTrigger")]
    public partial class BuildTrigger : Pulumi.CustomResource
    {
        /// <summary>
        /// Create a BuildTrigger resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public BuildTrigger(string name, BuildTriggerArgs args, CustomResourceOptions? options = null)
            : base("google-cloud:cloudbuild/v1:BuildTrigger", name, args ?? new BuildTriggerArgs(), MakeResourceOptions(options, ""))
        {
        }

        private BuildTrigger(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("google-cloud:cloudbuild/v1:BuildTrigger", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing BuildTrigger resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static BuildTrigger Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new BuildTrigger(name, id, options);
        }
    }

    public sealed class BuildTriggerArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Contents of the build template.
        /// </summary>
        [Input("build")]
        public Input<Inputs.BuildArgs>? Build { get; set; }

        /// <summary>
        /// Output only. Time when the trigger was created.
        /// </summary>
        [Input("createTime")]
        public Input<string>? CreateTime { get; set; }

        /// <summary>
        /// Human-readable description of this trigger.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// If true, the trigger will never automatically execute a build.
        /// </summary>
        [Input("disabled")]
        public Input<bool>? Disabled { get; set; }

        /// <summary>
        /// Path, from the source root, to the build configuration file (i.e. cloudbuild.yaml).
        /// </summary>
        [Input("filename")]
        public Input<string>? Filename { get; set; }

        /// <summary>
        /// GitHubEventsConfig describes the configuration of a trigger that creates a build whenever a GitHub event is received. Mutually exclusive with `trigger_template`.
        /// </summary>
        [Input("github")]
        public Input<Inputs.GitHubEventsConfigArgs>? Github { get; set; }

        /// <summary>
        /// Output only. Unique identifier of the trigger.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        [Input("ignoredFiles")]
        private InputList<string>? _ignoredFiles;

        /// <summary>
        /// ignored_files and included_files are file glob matches using https://golang.org/pkg/path/filepath/#Match extended with support for "**". If ignored_files and changed files are both empty, then they are not used to determine whether or not to trigger a build. If ignored_files is not empty, then we ignore any files that match any of the ignored_file globs. If the change has no files that are outside of the ignored_files globs, then we do not trigger a build.
        /// </summary>
        public InputList<string> IgnoredFiles
        {
            get => _ignoredFiles ?? (_ignoredFiles = new InputList<string>());
            set => _ignoredFiles = value;
        }

        [Input("includedFiles")]
        private InputList<string>? _includedFiles;

        /// <summary>
        /// If any of the files altered in the commit pass the ignored_files filter and included_files is empty, then as far as this filter is concerned, we should trigger the build. If any of the files altered in the commit pass the ignored_files filter and included_files is not empty, then we make sure that at least one of those files matches a included_files glob. If not, then we do not trigger a build.
        /// </summary>
        public InputList<string> IncludedFiles
        {
            get => _includedFiles ?? (_includedFiles = new InputList<string>());
            set => _includedFiles = value;
        }

        /// <summary>
        /// User-assigned name of the trigger. Must be unique within the project. Trigger names must meet the following requirements: + They must contain only alphanumeric characters and dashes. + They can be 1-64 characters long. + They must begin and end with an alphanumeric character.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Required. ID of the project for which to configure automatic builds.
        /// </summary>
        [Input("projectId", required: true)]
        public Input<string> ProjectId { get; set; } = null!;

        [Input("substitutions")]
        private InputMap<string>? _substitutions;

        /// <summary>
        /// Substitutions for Build resource. The keys must match the following regular expression: `^_[A-Z0-9_]+$`.
        /// </summary>
        public InputMap<string> Substitutions
        {
            get => _substitutions ?? (_substitutions = new InputMap<string>());
            set => _substitutions = value;
        }

        [Input("tags")]
        private InputList<string>? _tags;

        /// <summary>
        /// Tags for annotation of a `BuildTrigger`
        /// </summary>
        public InputList<string> Tags
        {
            get => _tags ?? (_tags = new InputList<string>());
            set => _tags = value;
        }

        /// <summary>
        /// Template describing the types of source changes to trigger a build. Branch and tag names in trigger templates are interpreted as regular expressions. Any branch or tag change that matches that regular expression will trigger a build. Mutually exclusive with `github`.
        /// </summary>
        [Input("triggerTemplate")]
        public Input<Inputs.RepoSourceArgs>? TriggerTemplate { get; set; }

        public BuildTriggerArgs()
        {
        }
    }
}