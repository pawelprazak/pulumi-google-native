// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.ContainerAnalysis.V1Alpha1.Outputs
{

    /// <summary>
    /// Identifies the event that kicked off the build.
    /// </summary>
    [OutputType]
    public sealed class GoogleDevtoolsContaineranalysisV1alpha1SlsaProvenanceZeroTwoSlsaInvocationResponse
    {
        /// <summary>
        /// Describes where the config file that kicked off the build came from.
        /// </summary>
        public readonly Outputs.GoogleDevtoolsContaineranalysisV1alpha1SlsaProvenanceZeroTwoSlsaConfigSourceResponse ConfigSource;
        /// <summary>
        /// Any other builder-controlled inputs necessary for correctly evaluating the build.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Environment;
        /// <summary>
        /// Collection of all external inputs that influenced the build on top of invocation.configSource.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Parameters;

        [OutputConstructor]
        private GoogleDevtoolsContaineranalysisV1alpha1SlsaProvenanceZeroTwoSlsaInvocationResponse(
            Outputs.GoogleDevtoolsContaineranalysisV1alpha1SlsaProvenanceZeroTwoSlsaConfigSourceResponse configSource,

            ImmutableDictionary<string, string> environment,

            ImmutableDictionary<string, string> parameters)
        {
            ConfigSource = configSource;
            Environment = environment;
            Parameters = parameters;
        }
    }
}