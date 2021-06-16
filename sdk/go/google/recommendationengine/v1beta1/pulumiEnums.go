// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1beta1

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Optional. Online stock state of the catalog item. Default is `IN_STOCK`.
type GoogleCloudRecommendationengineV1beta1ProductCatalogItemStockState pulumi.String

const (
	// Default item stock status. Should never be used.
	GoogleCloudRecommendationengineV1beta1ProductCatalogItemStockStateStockStateUnspecified = GoogleCloudRecommendationengineV1beta1ProductCatalogItemStockState("STOCK_STATE_UNSPECIFIED")
	// Item in stock.
	GoogleCloudRecommendationengineV1beta1ProductCatalogItemStockStateInStock = GoogleCloudRecommendationengineV1beta1ProductCatalogItemStockState("IN_STOCK")
	// Item out of stock.
	GoogleCloudRecommendationengineV1beta1ProductCatalogItemStockStateOutOfStock = GoogleCloudRecommendationengineV1beta1ProductCatalogItemStockState("OUT_OF_STOCK")
	// Item that is in pre-order state.
	GoogleCloudRecommendationengineV1beta1ProductCatalogItemStockStatePreorder = GoogleCloudRecommendationengineV1beta1ProductCatalogItemStockState("PREORDER")
	// Item that is back-ordered (i.e. temporarily out of stock).
	GoogleCloudRecommendationengineV1beta1ProductCatalogItemStockStateBackorder = GoogleCloudRecommendationengineV1beta1ProductCatalogItemStockState("BACKORDER")
)

func (GoogleCloudRecommendationengineV1beta1ProductCatalogItemStockState) ElementType() reflect.Type {
	return reflect.TypeOf((*pulumi.String)(nil)).Elem()
}

func (e GoogleCloudRecommendationengineV1beta1ProductCatalogItemStockState) ToStringOutput() pulumi.StringOutput {
	return pulumi.ToOutput(pulumi.String(e)).(pulumi.StringOutput)
}

func (e GoogleCloudRecommendationengineV1beta1ProductCatalogItemStockState) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return pulumi.ToOutputWithContext(ctx, pulumi.String(e)).(pulumi.StringOutput)
}

func (e GoogleCloudRecommendationengineV1beta1ProductCatalogItemStockState) ToStringPtrOutput() pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringPtrOutputWithContext(context.Background())
}

func (e GoogleCloudRecommendationengineV1beta1ProductCatalogItemStockState) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringOutputWithContext(ctx).ToStringPtrOutputWithContext(ctx)
}