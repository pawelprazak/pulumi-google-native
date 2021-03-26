// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.Servicemanagement.V1.Inputs
{

    /// <summary>
    /// A protocol buffer message type.
    /// </summary>
    public sealed class TypeArgs : Pulumi.ResourceArgs
    {
        [Input("fields")]
        private InputList<Inputs.FieldArgs>? _fields;

        /// <summary>
        /// The list of fields.
        /// </summary>
        public InputList<Inputs.FieldArgs> Fields
        {
            get => _fields ?? (_fields = new InputList<Inputs.FieldArgs>());
            set => _fields = value;
        }

        /// <summary>
        /// The fully qualified message name.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("oneofs")]
        private InputList<string>? _oneofs;

        /// <summary>
        /// The list of types appearing in `oneof` definitions in this type.
        /// </summary>
        public InputList<string> Oneofs
        {
            get => _oneofs ?? (_oneofs = new InputList<string>());
            set => _oneofs = value;
        }

        [Input("options")]
        private InputList<Inputs.OptionArgs>? _options;

        /// <summary>
        /// The protocol buffer options.
        /// </summary>
        public InputList<Inputs.OptionArgs> Options
        {
            get => _options ?? (_options = new InputList<Inputs.OptionArgs>());
            set => _options = value;
        }

        /// <summary>
        /// The source context.
        /// </summary>
        [Input("sourceContext")]
        public Input<Inputs.SourceContextArgs>? SourceContext { get; set; }

        /// <summary>
        /// The source syntax.
        /// </summary>
        [Input("syntax")]
        public Input<string>? Syntax { get; set; }

        public TypeArgs()
        {
        }
    }
}