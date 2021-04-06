// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.Dialogflow.V2Beta1.Outputs
{

    [OutputType]
    public sealed class GoogleCloudDialogflowV2beta1IntentParameterResponse
    {
        /// <summary>
        /// Optional. The default value to use when the `value` yields an empty result. Default values can be extracted from contexts by using the following syntax: `#context_name.parameter_name`.
        /// </summary>
        public readonly string DefaultValue;
        /// <summary>
        /// Required. The name of the parameter.
        /// </summary>
        public readonly string DisplayName;
        /// <summary>
        /// Optional. The name of the entity type, prefixed with `@`, that describes values of the parameter. If the parameter is required, this must be provided.
        /// </summary>
        public readonly string EntityTypeDisplayName;
        /// <summary>
        /// Optional. Indicates whether the parameter represents a list of values.
        /// </summary>
        public readonly bool IsList;
        /// <summary>
        /// Optional. Indicates whether the parameter is required. That is, whether the intent cannot be completed without collecting the parameter value.
        /// </summary>
        public readonly bool Mandatory;
        /// <summary>
        /// The unique identifier of this parameter.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Optional. The collection of prompts that the agent can present to the user in order to collect a value for the parameter.
        /// </summary>
        public readonly ImmutableArray<string> Prompts;
        /// <summary>
        /// Optional. The definition of the parameter value. It can be: - a constant string, - a parameter value defined as `$parameter_name`, - an original parameter value defined as `$parameter_name.original`, - a parameter value from some context defined as `#context_name.parameter_name`.
        /// </summary>
        public readonly string Value;

        [OutputConstructor]
        private GoogleCloudDialogflowV2beta1IntentParameterResponse(
            string defaultValue,

            string displayName,

            string entityTypeDisplayName,

            bool isList,

            bool mandatory,

            string name,

            ImmutableArray<string> prompts,

            string value)
        {
            DefaultValue = defaultValue;
            DisplayName = displayName;
            EntityTypeDisplayName = entityTypeDisplayName;
            IsList = isList;
            Mandatory = mandatory;
            Name = name;
            Prompts = prompts;
            Value = value;
        }
    }
}