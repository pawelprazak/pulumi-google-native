// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.ServiceManagement.V1.Inputs
{

    /// <summary>
    /// A description of a log type. Example in YAML format: - name: library.googleapis.com/activity_history description: The history of borrowing and returning library items. display_name: Activity labels: - key: /customer_id description: Identifier of a library customer
    /// </summary>
    public sealed class LogDescriptorArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A human-readable description of this log. This information appears in the documentation and can contain details.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The human-readable name for this log. This information appears on the user interface and should be concise.
        /// </summary>
        [Input("displayName")]
        public Input<string>? DisplayName { get; set; }

        [Input("labels")]
        private InputList<Inputs.LabelDescriptorArgs>? _labels;

        /// <summary>
        /// The set of labels that are available to describe a specific log entry. Runtime requests that contain labels not specified here are considered invalid.
        /// </summary>
        public InputList<Inputs.LabelDescriptorArgs> Labels
        {
            get => _labels ?? (_labels = new InputList<Inputs.LabelDescriptorArgs>());
            set => _labels = value;
        }

        /// <summary>
        /// The name of the log. It must be less than 512 characters long and can include the following characters: upper- and lower-case alphanumeric characters [A-Za-z0-9], and punctuation characters including slash, underscore, hyphen, period [/_-.].
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public LogDescriptorArgs()
        {
        }
    }
}
