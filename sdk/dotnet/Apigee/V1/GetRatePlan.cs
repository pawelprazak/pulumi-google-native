// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.Apigee.V1
{
    public static class GetRatePlan
    {
        /// <summary>
        /// Gets the details of a rate plan.
        /// </summary>
        public static Task<GetRatePlanResult> InvokeAsync(GetRatePlanArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetRatePlanResult>("google-native:apigee/v1:getRatePlan", args ?? new GetRatePlanArgs(), options.WithDefaults());

        /// <summary>
        /// Gets the details of a rate plan.
        /// </summary>
        public static Output<GetRatePlanResult> Invoke(GetRatePlanInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetRatePlanResult>("google-native:apigee/v1:getRatePlan", args ?? new GetRatePlanInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetRatePlanArgs : Pulumi.InvokeArgs
    {
        [Input("apiproductId", required: true)]
        public string ApiproductId { get; set; } = null!;

        [Input("organizationId", required: true)]
        public string OrganizationId { get; set; } = null!;

        [Input("rateplanId", required: true)]
        public string RateplanId { get; set; } = null!;

        public GetRatePlanArgs()
        {
        }
    }

    public sealed class GetRatePlanInvokeArgs : Pulumi.InvokeArgs
    {
        [Input("apiproductId", required: true)]
        public Input<string> ApiproductId { get; set; } = null!;

        [Input("organizationId", required: true)]
        public Input<string> OrganizationId { get; set; } = null!;

        [Input("rateplanId", required: true)]
        public Input<string> RateplanId { get; set; } = null!;

        public GetRatePlanInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetRatePlanResult
    {
        /// <summary>
        /// Name of the API product that the rate plan is associated with.
        /// </summary>
        public readonly string Apiproduct;
        /// <summary>
        /// Frequency at which the customer will be billed.
        /// </summary>
        public readonly string BillingPeriod;
        /// <summary>
        /// API call volume ranges and the fees charged when the total number of API calls is within a given range. The method used to calculate the final fee depends on the selected pricing model. For example, if the pricing model is `STAIRSTEP` and the ranges are defined as follows: ``` { "start": 1, "end": 100, "fee": 75 }, { "start": 101, "end": 200, "fee": 100 }, } ``` Then the following fees would be charged based on the total number of API calls (assuming the currency selected is `USD`): * 1 call costs $75 * 50 calls cost $75 * 150 calls cost $100 The number of API calls cannot exceed 200.
        /// </summary>
        public readonly ImmutableArray<Outputs.GoogleCloudApigeeV1RateRangeResponse> ConsumptionPricingRates;
        /// <summary>
        /// Pricing model used for consumption-based charges.
        /// </summary>
        public readonly string ConsumptionPricingType;
        /// <summary>
        /// Time that the rate plan was created in milliseconds since epoch.
        /// </summary>
        public readonly string CreatedAt;
        /// <summary>
        /// Currency to be used for billing. Consists of a three-letter code as defined by the [ISO 4217](https://en.wikipedia.org/wiki/ISO_4217) standard.
        /// </summary>
        public readonly string CurrencyCode;
        /// <summary>
        /// Description of the rate plan.
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// Display name of the rate plan.
        /// </summary>
        public readonly string DisplayName;
        /// <summary>
        /// Time when the rate plan will expire in milliseconds since epoch. Set to 0 or `null` to indicate that the rate plan should never expire.
        /// </summary>
        public readonly string EndTime;
        /// <summary>
        /// Frequency at which the fixed fee is charged.
        /// </summary>
        public readonly int FixedFeeFrequency;
        /// <summary>
        /// Fixed amount that is charged at a defined interval and billed in advance of use of the API product. The fee will be prorated for the first billing period.
        /// </summary>
        public readonly Outputs.GoogleTypeMoneyResponse FixedRecurringFee;
        /// <summary>
        /// Time the rate plan was last modified in milliseconds since epoch.
        /// </summary>
        public readonly string LastModifiedAt;
        /// <summary>
        /// Name of the rate plan.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// DEPRECATED: This field is no longer supported and will eventually be removed when Apigee Hybrid 1.5/1.6 is no longer supported. Instead, use the `billingType` field inside `DeveloperMonetizationConfig` resource. Flag that specifies the billing account type, prepaid or postpaid.
        /// </summary>
        public readonly string PaymentFundingModel;
        /// <summary>
        /// Details of the revenue sharing model.
        /// </summary>
        public readonly ImmutableArray<Outputs.GoogleCloudApigeeV1RevenueShareRangeResponse> RevenueShareRates;
        /// <summary>
        /// Method used to calculate the revenue that is shared with developers.
        /// </summary>
        public readonly string RevenueShareType;
        /// <summary>
        /// Initial, one-time fee paid when purchasing the API product.
        /// </summary>
        public readonly Outputs.GoogleTypeMoneyResponse SetupFee;
        /// <summary>
        /// Time when the rate plan becomes active in milliseconds since epoch.
        /// </summary>
        public readonly string StartTime;
        /// <summary>
        /// Current state of the rate plan (draft or published).
        /// </summary>
        public readonly string State;

        [OutputConstructor]
        private GetRatePlanResult(
            string apiproduct,

            string billingPeriod,

            ImmutableArray<Outputs.GoogleCloudApigeeV1RateRangeResponse> consumptionPricingRates,

            string consumptionPricingType,

            string createdAt,

            string currencyCode,

            string description,

            string displayName,

            string endTime,

            int fixedFeeFrequency,

            Outputs.GoogleTypeMoneyResponse fixedRecurringFee,

            string lastModifiedAt,

            string name,

            string paymentFundingModel,

            ImmutableArray<Outputs.GoogleCloudApigeeV1RevenueShareRangeResponse> revenueShareRates,

            string revenueShareType,

            Outputs.GoogleTypeMoneyResponse setupFee,

            string startTime,

            string state)
        {
            Apiproduct = apiproduct;
            BillingPeriod = billingPeriod;
            ConsumptionPricingRates = consumptionPricingRates;
            ConsumptionPricingType = consumptionPricingType;
            CreatedAt = createdAt;
            CurrencyCode = currencyCode;
            Description = description;
            DisplayName = displayName;
            EndTime = endTime;
            FixedFeeFrequency = fixedFeeFrequency;
            FixedRecurringFee = fixedRecurringFee;
            LastModifiedAt = lastModifiedAt;
            Name = name;
            PaymentFundingModel = paymentFundingModel;
            RevenueShareRates = revenueShareRates;
            RevenueShareType = revenueShareType;
            SetupFee = setupFee;
            StartTime = startTime;
            State = state;
        }
    }
}