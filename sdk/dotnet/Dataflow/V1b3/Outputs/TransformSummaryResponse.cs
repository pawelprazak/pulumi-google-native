// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.Dataflow.V1b3.Outputs
{

    /// <summary>
    /// Description of the type, names/ids, and input/outputs for a transform.
    /// </summary>
    [OutputType]
    public sealed class TransformSummaryResponse
    {
        /// <summary>
        /// Transform-specific display data.
        /// </summary>
        public readonly ImmutableArray<Outputs.DisplayDataResponse> DisplayData;
        /// <summary>
        /// User names for all collection inputs to this transform.
        /// </summary>
        public readonly ImmutableArray<string> InputCollectionName;
        /// <summary>
        /// Type of transform.
        /// </summary>
        public readonly string Kind;
        /// <summary>
        /// User provided name for this transform instance.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// User names for all collection outputs to this transform.
        /// </summary>
        public readonly ImmutableArray<string> OutputCollectionName;

        [OutputConstructor]
        private TransformSummaryResponse(
            ImmutableArray<Outputs.DisplayDataResponse> displayData,

            ImmutableArray<string> inputCollectionName,

            string kind,

            string name,

            ImmutableArray<string> outputCollectionName)
        {
            DisplayData = displayData;
            InputCollectionName = inputCollectionName;
            Kind = kind;
            Name = name;
            OutputCollectionName = outputCollectionName;
        }
    }
}
