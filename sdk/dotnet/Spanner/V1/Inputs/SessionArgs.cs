// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.Spanner.V1.Inputs
{

    /// <summary>
    /// A session in the Cloud Spanner API.
    /// </summary>
    public sealed class SessionArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Output only. The approximate timestamp when the session is last used. It is typically earlier than the actual last use time.
        /// </summary>
        [Input("approximateLastUseTime")]
        public Input<string>? ApproximateLastUseTime { get; set; }

        /// <summary>
        /// Output only. The timestamp when the session is created.
        /// </summary>
        [Input("createTime")]
        public Input<string>? CreateTime { get; set; }

        [Input("labels")]
        private InputMap<string>? _labels;

        /// <summary>
        /// The labels for the session. * Label keys must be between 1 and 63 characters long and must conform to the following regular expression: `[a-z]([-a-z0-9]*[a-z0-9])?`. * Label values must be between 0 and 63 characters long and must conform to the regular expression `([a-z]([-a-z0-9]*[a-z0-9])?)?`. * No more than 64 labels can be associated with a given session. See https://goo.gl/xmQnxf for more information on and examples of labels.
        /// </summary>
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        /// <summary>
        /// Output only. The name of the session. This is always system-assigned.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public SessionArgs()
        {
        }
    }
}