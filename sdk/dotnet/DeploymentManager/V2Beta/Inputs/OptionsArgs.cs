// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.DeploymentManager.V2Beta.Inputs
{

    /// <summary>
    /// Options allows customized resource handling by Deployment Manager.
    /// </summary>
    public sealed class OptionsArgs : Pulumi.ResourceArgs
    {
        [Input("asyncOptions")]
        private InputList<Inputs.AsyncOptionsArgs>? _asyncOptions;

        /// <summary>
        /// Options regarding how to thread async requests.
        /// </summary>
        public InputList<Inputs.AsyncOptionsArgs> AsyncOptions
        {
            get => _asyncOptions ?? (_asyncOptions = new InputList<Inputs.AsyncOptionsArgs>());
            set => _asyncOptions = value;
        }

        [Input("inputMappings")]
        private InputList<Inputs.InputMappingArgs>? _inputMappings;

        /// <summary>
        /// The mappings that apply for requests.
        /// </summary>
        public InputList<Inputs.InputMappingArgs> InputMappings
        {
            get => _inputMappings ?? (_inputMappings = new InputList<Inputs.InputMappingArgs>());
            set => _inputMappings = value;
        }

        /// <summary>
        /// Options for how to validate and process properties on a resource.
        /// </summary>
        [Input("validationOptions")]
        public Input<Inputs.ValidationOptionsArgs>? ValidationOptions { get; set; }

        /// <summary>
        /// Additional properties block described as a jsonSchema, these properties will never be part of the json payload, but they can be consumed by InputMappings, this must be a valid json schema draft-04. The properties specified here will be decouple in a different section. This schema will be merged to the schema validation, and properties here will be extracted From the payload and consumed explicitly by InputMappings. ex: field1: type: string field2: type: number
        /// </summary>
        [Input("virtualProperties")]
        public Input<string>? VirtualProperties { get; set; }

        public OptionsArgs()
        {
        }
    }
}
