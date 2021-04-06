// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.ContainerAnalysis.V1Beta1.Inputs
{

    /// <summary>
    /// A SourceContext is a reference to a tree of files. A SourceContext together with a path point to a unique revision of a single file or directory.
    /// </summary>
    public sealed class SourceContextArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A SourceContext referring to a revision in a Google Cloud Source Repo.
        /// </summary>
        [Input("cloudRepo")]
        public Input<Inputs.CloudRepoSourceContextArgs>? CloudRepo { get; set; }

        /// <summary>
        /// A SourceContext referring to a Gerrit project.
        /// </summary>
        [Input("gerrit")]
        public Input<Inputs.GerritSourceContextArgs>? Gerrit { get; set; }

        /// <summary>
        /// A SourceContext referring to any third party Git repo (e.g., GitHub).
        /// </summary>
        [Input("git")]
        public Input<Inputs.GitSourceContextArgs>? Git { get; set; }

        [Input("labels")]
        private InputMap<string>? _labels;

        /// <summary>
        /// Labels with user defined metadata.
        /// </summary>
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        public SourceContextArgs()
        {
        }
    }
}