// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.Metastore.V1Beta.Inputs
{

    /// <summary>
    /// Network configuration for the Dataproc Metastore service.
    /// </summary>
    public sealed class NetworkConfigArgs : Pulumi.ResourceArgs
    {
        [Input("consumers")]
        private InputList<Inputs.ConsumerArgs>? _consumers;

        /// <summary>
        /// Immutable. The consumer-side network configuration for the Dataproc Metastore instance.
        /// </summary>
        public InputList<Inputs.ConsumerArgs> Consumers
        {
            get => _consumers ?? (_consumers = new InputList<Inputs.ConsumerArgs>());
            set => _consumers = value;
        }

        public NetworkConfigArgs()
        {
        }
    }
}
