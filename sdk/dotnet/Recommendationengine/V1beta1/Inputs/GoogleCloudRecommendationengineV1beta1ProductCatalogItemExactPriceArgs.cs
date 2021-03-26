// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.Recommendationengine.V1beta1.Inputs
{

    /// <summary>
    /// Exact product price.
    /// </summary>
    public sealed class GoogleCloudRecommendationengineV1beta1ProductCatalogItemExactPriceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Optional. Display price of the product.
        /// </summary>
        [Input("displayPrice")]
        public Input<double>? DisplayPrice { get; set; }

        /// <summary>
        /// Optional. Price of the product without any discount. If zero, by default set to be the 'displayPrice'.
        /// </summary>
        [Input("originalPrice")]
        public Input<double>? OriginalPrice { get; set; }

        public GoogleCloudRecommendationengineV1beta1ProductCatalogItemExactPriceArgs()
        {
        }
    }
}