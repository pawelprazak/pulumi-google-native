// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.CloudChannel.V1.Inputs
{

    /// <summary>
    /// Configuration for repricing a Google bill over a period of time.
    /// </summary>
    public sealed class GoogleCloudChannelV1RepricingConfigArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Information about the adjustment.
        /// </summary>
        [Input("adjustment", required: true)]
        public Input<Inputs.GoogleCloudChannelV1RepricingAdjustmentArgs> Adjustment { get; set; } = null!;

        /// <summary>
        /// Applies the repricing configuration at the channel partner level. This is the only supported value for ChannelPartnerRepricingConfig.
        /// </summary>
        [Input("channelPartnerGranularity")]
        public Input<Inputs.GoogleCloudChannelV1RepricingConfigChannelPartnerGranularityArgs>? ChannelPartnerGranularity { get; set; }

        /// <summary>
        /// The YearMonth when these adjustments activate. The Day field needs to be "0" since we only accept YearMonth repricing boundaries.
        /// </summary>
        [Input("effectiveInvoiceMonth", required: true)]
        public Input<Inputs.GoogleTypeDateArgs> EffectiveInvoiceMonth { get; set; } = null!;

        /// <summary>
        /// Applies the repricing configuration at the entitlement level. This is the only supported value for CustomerRepricingConfig.
        /// </summary>
        [Input("entitlementGranularity")]
        public Input<Inputs.GoogleCloudChannelV1RepricingConfigEntitlementGranularityArgs>? EntitlementGranularity { get; set; }

        /// <summary>
        /// The RebillingBasis to use for this bill. Specifies the relative cost based on repricing costs you will apply.
        /// </summary>
        [Input("rebillingBasis", required: true)]
        public Input<Pulumi.GoogleNative.CloudChannel.V1.GoogleCloudChannelV1RepricingConfigRebillingBasis> RebillingBasis { get; set; } = null!;

        public GoogleCloudChannelV1RepricingConfigArgs()
        {
        }
    }
}
