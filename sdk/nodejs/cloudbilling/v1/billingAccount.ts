// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

/**
 * Creates a billing account. This method can only be used to create [billing subaccounts](https://cloud.google.com/billing/docs/concepts) by Google Cloud resellers. When creating a subaccount, the current authenticated user must have the `billing.accounts.update` IAM permission on the master account, which is typically given to billing account [administrators](https://cloud.google.com/billing/docs/how-to/billing-access). This method will return an error if the master account has not been provisioned as a reseller account.
 */
export class BillingAccount extends pulumi.CustomResource {
    /**
     * Get an existing BillingAccount resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): BillingAccount {
        return new BillingAccount(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'google-cloud:cloudbilling/v1:BillingAccount';

    /**
     * Returns true if the given object is an instance of BillingAccount.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is BillingAccount {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === BillingAccount.__pulumiType;
    }


    /**
     * Create a BillingAccount resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: BillingAccountArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            inputs["displayName"] = args ? args.displayName : undefined;
            inputs["masterBillingAccount"] = args ? args.masterBillingAccount : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["open"] = args ? args.open : undefined;
        } else {
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(BillingAccount.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a BillingAccount resource.
 */
export interface BillingAccountArgs {
    /**
     * The display name given to the billing account, such as `My Billing Account`. This name is displayed in the Google Cloud Console.
     */
    readonly displayName?: pulumi.Input<string>;
    /**
     * If this account is a [subaccount](https://cloud.google.com/billing/docs/concepts), then this will be the resource name of the master billing account that it is being resold through. Otherwise this will be empty.
     */
    readonly masterBillingAccount?: pulumi.Input<string>;
    /**
     * Output only. The resource name of the billing account. The resource name has the form `billingAccounts/{billing_account_id}`. For example, `billingAccounts/012345-567890-ABCDEF` would be the resource name for billing account `012345-567890-ABCDEF`.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * Output only. True if the billing account is open, and will therefore be charged for any usage on associated projects. False if the billing account is closed, and therefore projects associated with it will be unable to use paid services.
     */
    readonly open?: pulumi.Input<boolean>;
}