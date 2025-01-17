// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.CloudBilling.V1
{
    public static class GetBillingAccount
    {
        /// <summary>
        /// Gets information about a billing account. The current authenticated user must be a [viewer of the billing account](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// </summary>
        public static Task<GetBillingAccountResult> InvokeAsync(GetBillingAccountArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetBillingAccountResult>("google-native:cloudbilling/v1:getBillingAccount", args ?? new GetBillingAccountArgs(), options.WithDefaults());

        /// <summary>
        /// Gets information about a billing account. The current authenticated user must be a [viewer of the billing account](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// </summary>
        public static Output<GetBillingAccountResult> Invoke(GetBillingAccountInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetBillingAccountResult>("google-native:cloudbilling/v1:getBillingAccount", args ?? new GetBillingAccountInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetBillingAccountArgs : Pulumi.InvokeArgs
    {
        [Input("billingAccountId", required: true)]
        public string BillingAccountId { get; set; } = null!;

        public GetBillingAccountArgs()
        {
        }
    }

    public sealed class GetBillingAccountInvokeArgs : Pulumi.InvokeArgs
    {
        [Input("billingAccountId", required: true)]
        public Input<string> BillingAccountId { get; set; } = null!;

        public GetBillingAccountInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetBillingAccountResult
    {
        /// <summary>
        /// The display name given to the billing account, such as `My Billing Account`. This name is displayed in the Google Cloud Console.
        /// </summary>
        public readonly string DisplayName;
        /// <summary>
        /// If this account is a [subaccount](https://cloud.google.com/billing/docs/concepts), then this will be the resource name of the parent billing account that it is being resold through. Otherwise this will be empty.
        /// </summary>
        public readonly string MasterBillingAccount;
        /// <summary>
        /// The resource name of the billing account. The resource name has the form `billingAccounts/{billing_account_id}`. For example, `billingAccounts/012345-567890-ABCDEF` would be the resource name for billing account `012345-567890-ABCDEF`.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// True if the billing account is open, and will therefore be charged for any usage on associated projects. False if the billing account is closed, and therefore projects associated with it will be unable to use paid services.
        /// </summary>
        public readonly bool Open;

        [OutputConstructor]
        private GetBillingAccountResult(
            string displayName,

            string masterBillingAccount,

            string name,

            bool open)
        {
            DisplayName = displayName;
            MasterBillingAccount = masterBillingAccount;
            Name = name;
            Open = open;
        }
    }
}
