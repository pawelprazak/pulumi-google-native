// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.BeyondCorp.V1Alpha.Inputs
{

    /// <summary>
    /// Gateway represents a user facing component that serves as an entrance to enable connectivity.
    /// </summary>
    public sealed class GoogleCloudBeyondcorpAppconnectionsV1alphaAppConnectionGatewayArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// AppGateway name in following format: projects/{project_id}/locations/{location_id}/appgateways/{gateway_id}
        /// </summary>
        [Input("appGateway", required: true)]
        public Input<string> AppGateway { get; set; } = null!;

        /// <summary>
        /// The type of hosting used by the gateway.
        /// </summary>
        [Input("type", required: true)]
        public Input<Pulumi.GoogleNative.BeyondCorp.V1Alpha.GoogleCloudBeyondcorpAppconnectionsV1alphaAppConnectionGatewayType> Type { get; set; } = null!;

        public GoogleCloudBeyondcorpAppconnectionsV1alphaAppConnectionGatewayArgs()
        {
        }
    }
}
