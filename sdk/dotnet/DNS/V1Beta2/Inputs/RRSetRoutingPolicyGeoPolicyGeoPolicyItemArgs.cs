// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.DNS.V1Beta2.Inputs
{

    /// <summary>
    /// ResourceRecordSet data for one geo location.
    /// </summary>
    public sealed class RRSetRoutingPolicyGeoPolicyGeoPolicyItemArgs : Pulumi.ResourceArgs
    {
        [Input("kind")]
        public Input<string>? Kind { get; set; }

        /// <summary>
        /// The geo-location granularity is a GCP region. This location string should correspond to a GCP region. e.g. "us-east1", "southamerica-east1", "asia-east1", etc.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        [Input("rrdatas")]
        private InputList<string>? _rrdatas;
        public InputList<string> Rrdatas
        {
            get => _rrdatas ?? (_rrdatas = new InputList<string>());
            set => _rrdatas = value;
        }

        [Input("signatureRrdatas")]
        private InputList<string>? _signatureRrdatas;

        /// <summary>
        /// DNSSEC generated signatures for all the rrdata within this item. Note that if health checked targets are provided for DNSSEC enabled zones, there's a restriction of 1 ip per item. .
        /// </summary>
        public InputList<string> SignatureRrdatas
        {
            get => _signatureRrdatas ?? (_signatureRrdatas = new InputList<string>());
            set => _signatureRrdatas = value;
        }

        public RRSetRoutingPolicyGeoPolicyGeoPolicyItemArgs()
        {
        }
    }
}
