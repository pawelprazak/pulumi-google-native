// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Creates a ChannelPartnerRepricingConfig. Call this method to set modifications for a specific ChannelPartner's bill. You can only create configs if the RepricingConfig.effective_invoice_month is a future month. If needed, you can create a config for the current month, with some restrictions. When creating a config for a future month, make sure there are no existing configs for that RepricingConfig.effective_invoice_month. The following restrictions are for creating configs in the current month. * This functionality is reserved for recovering from an erroneous config, and should not be used for regular business cases. * The new config will not modify exports used with other configs. Changes to the config may be immediate, but may take up to 24 hours. * There is a limit of ten configs for any ChannelPartner or RepricingConfig.effective_invoice_month. * The contained ChannelPartnerRepricingConfig.repricing_config vaule must be different from the value used in the current config for a ChannelPartner. Possible Error Codes: * PERMISSION_DENIED: If the account making the request and the account being queried are different. * INVALID_ARGUMENT: Missing or invalid required parameters in the request. Also displays if the updated config is for the current month or past months. * NOT_FOUND: The ChannelPartnerRepricingConfig specified does not exist or is not associated with the given account. * INTERNAL: Any non-user error related to technical issues in the backend. In this case, contact Cloud Channel support. Return Value: If successful, the updated ChannelPartnerRepricingConfig resource, otherwise returns an error.
 * Auto-naming is currently not supported for this resource.
 */
export class ChannelPartnerRepricingConfig extends pulumi.CustomResource {
    /**
     * Get an existing ChannelPartnerRepricingConfig resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): ChannelPartnerRepricingConfig {
        return new ChannelPartnerRepricingConfig(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'google-native:cloudchannel/v1:ChannelPartnerRepricingConfig';

    /**
     * Returns true if the given object is an instance of ChannelPartnerRepricingConfig.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ChannelPartnerRepricingConfig {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ChannelPartnerRepricingConfig.__pulumiType;
    }

    public readonly accountId!: pulumi.Output<string>;
    public readonly channelPartnerLinkId!: pulumi.Output<string>;
    /**
     * Resource name of the ChannelPartnerRepricingConfig. Format: accounts/{account_id}/channelPartnerLinks/{channel_partner_id}/channelPartnerRepricingConfigs/{id}.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * The configuration for bill modifications made by a reseller before sending it to ChannelPartner.
     */
    public readonly repricingConfig!: pulumi.Output<outputs.cloudchannel.v1.GoogleCloudChannelV1RepricingConfigResponse>;
    /**
     * Timestamp of an update to the repricing rule. If `update_time` is after RepricingConfig.effective_invoice_month then it indicates this was set mid-month.
     */
    public /*out*/ readonly updateTime!: pulumi.Output<string>;

    /**
     * Create a ChannelPartnerRepricingConfig resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ChannelPartnerRepricingConfigArgs, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.accountId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'accountId'");
            }
            if ((!args || args.channelPartnerLinkId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'channelPartnerLinkId'");
            }
            if ((!args || args.repricingConfig === undefined) && !opts.urn) {
                throw new Error("Missing required property 'repricingConfig'");
            }
            resourceInputs["accountId"] = args ? args.accountId : undefined;
            resourceInputs["channelPartnerLinkId"] = args ? args.channelPartnerLinkId : undefined;
            resourceInputs["repricingConfig"] = args ? args.repricingConfig : undefined;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["updateTime"] = undefined /*out*/;
        } else {
            resourceInputs["accountId"] = undefined /*out*/;
            resourceInputs["channelPartnerLinkId"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["repricingConfig"] = undefined /*out*/;
            resourceInputs["updateTime"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(ChannelPartnerRepricingConfig.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * The set of arguments for constructing a ChannelPartnerRepricingConfig resource.
 */
export interface ChannelPartnerRepricingConfigArgs {
    accountId: pulumi.Input<string>;
    channelPartnerLinkId: pulumi.Input<string>;
    /**
     * The configuration for bill modifications made by a reseller before sending it to ChannelPartner.
     */
    repricingConfig: pulumi.Input<inputs.cloudchannel.v1.GoogleCloudChannelV1RepricingConfigArgs>;
}
