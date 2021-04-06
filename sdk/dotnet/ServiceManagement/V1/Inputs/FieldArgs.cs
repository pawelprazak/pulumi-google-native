// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.ServiceManagement.V1.Inputs
{

    /// <summary>
    /// A single field of a message type.
    /// </summary>
    public sealed class FieldArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The field cardinality.
        /// </summary>
        [Input("cardinality")]
        public Input<string>? Cardinality { get; set; }

        /// <summary>
        /// The string value of the default value of this field. Proto2 syntax only.
        /// </summary>
        [Input("defaultValue")]
        public Input<string>? DefaultValue { get; set; }

        /// <summary>
        /// The field JSON name.
        /// </summary>
        [Input("jsonName")]
        public Input<string>? JsonName { get; set; }

        /// <summary>
        /// The field type.
        /// </summary>
        [Input("kind")]
        public Input<string>? Kind { get; set; }

        /// <summary>
        /// The field name.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The field number.
        /// </summary>
        [Input("number")]
        public Input<int>? Number { get; set; }

        /// <summary>
        /// The index of the field type in `Type.oneofs`, for message or enumeration types. The first type has index 1; zero means the type is not in the list.
        /// </summary>
        [Input("oneofIndex")]
        public Input<int>? OneofIndex { get; set; }

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
        /// Whether to use alternative packed wire representation.
        /// </summary>
        [Input("packed")]
        public Input<bool>? Packed { get; set; }

        /// <summary>
        /// The field type URL, without the scheme, for message or enumeration types. Example: `"type.googleapis.com/google.protobuf.Timestamp"`.
        /// </summary>
        [Input("typeUrl")]
        public Input<string>? TypeUrl { get; set; }

        public FieldArgs()
        {
        }
    }
}