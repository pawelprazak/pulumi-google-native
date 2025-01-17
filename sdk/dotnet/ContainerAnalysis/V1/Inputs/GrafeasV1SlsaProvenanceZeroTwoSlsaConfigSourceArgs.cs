// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.ContainerAnalysis.V1.Inputs
{

    /// <summary>
    /// Describes where the config file that kicked off the build came from. This is effectively a pointer to the source where buildConfig came from.
    /// </summary>
    public sealed class GrafeasV1SlsaProvenanceZeroTwoSlsaConfigSourceArgs : Pulumi.ResourceArgs
    {
        [Input("digest")]
        private InputMap<string>? _digest;
        public InputMap<string> Digest
        {
            get => _digest ?? (_digest = new InputMap<string>());
            set => _digest = value;
        }

        [Input("entryPoint")]
        public Input<string>? EntryPoint { get; set; }

        [Input("uri")]
        public Input<string>? Uri { get; set; }

        public GrafeasV1SlsaProvenanceZeroTwoSlsaConfigSourceArgs()
        {
        }
    }
}
