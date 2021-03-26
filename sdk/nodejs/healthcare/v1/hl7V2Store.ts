// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

/**
 * Creates a new HL7v2 store within the parent dataset.
 */
export class Hl7V2Store extends pulumi.CustomResource {
    /**
     * Get an existing Hl7V2Store resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Hl7V2Store {
        return new Hl7V2Store(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'google-cloud:healthcare/v1:Hl7V2Store';

    /**
     * Returns true if the given object is an instance of Hl7V2Store.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Hl7V2Store {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Hl7V2Store.__pulumiType;
    }


    /**
     * Create a Hl7V2Store resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: Hl7V2StoreArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.parent === undefined) && !opts.urn) {
                throw new Error("Missing required property 'parent'");
            }
            inputs["hl7V2StoreId"] = args ? args.hl7V2StoreId : undefined;
            inputs["labels"] = args ? args.labels : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["notificationConfigs"] = args ? args.notificationConfigs : undefined;
            inputs["parent"] = args ? args.parent : undefined;
            inputs["parserConfig"] = args ? args.parserConfig : undefined;
            inputs["rejectDuplicateMessage"] = args ? args.rejectDuplicateMessage : undefined;
        } else {
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(Hl7V2Store.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Hl7V2Store resource.
 */
export interface Hl7V2StoreArgs {
    /**
     * The ID of the HL7v2 store that is being created. The string must match the following regex: `[\p{L}\p{N}_\-\.]{1,256}`.
     */
    readonly hl7V2StoreId?: pulumi.Input<string>;
    /**
     * User-supplied key-value pairs used to organize HL7v2 stores. Label keys must be between 1 and 63 characters long, have a UTF-8 encoding of maximum 128 bytes, and must conform to the following PCRE regular expression: \p{Ll}\p{Lo}{0,62} Label values are optional, must be between 1 and 63 characters long, have a UTF-8 encoding of maximum 128 bytes, and must conform to the following PCRE regular expression: [\p{Ll}\p{Lo}\p{N}_-]{0,63} No more than 64 labels can be associated with a given store.
     */
    readonly labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Resource name of the HL7v2 store, of the form `projects/{project_id}/datasets/{dataset_id}/hl7V2Stores/{hl7v2_store_id}`.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * A list of notification configs. Each configuration uses a filter to determine whether to publish a message (both Ingest & Create) on the corresponding notification destination. Only the message name is sent as part of the notification. Supplied by the client.
     */
    readonly notificationConfigs?: pulumi.Input<pulumi.Input<inputs.healthcare.v1.Hl7V2NotificationConfig>[]>;
    /**
     * The name of the dataset this HL7v2 store belongs to.
     */
    readonly parent: pulumi.Input<string>;
    /**
     * The configuration for the parser. It determines how the server parses the messages.
     */
    readonly parserConfig?: pulumi.Input<inputs.healthcare.v1.ParserConfig>;
    /**
     * Determines whether to reject duplicate messages. A duplicate message is a message with the same raw bytes as a message that has already been ingested/created in this HL7v2 store. The default value is false, meaning that the store accepts the duplicate messages and it also returns the same ACK message in the IngestMessageResponse as has been returned previously. Note that only one resource is created in the store. When this field is set to true, CreateMessage/IngestMessage requests with a duplicate message will be rejected by the store, and IngestMessageErrorDetail returns a NACK message upon rejection.
     */
    readonly rejectDuplicateMessage?: pulumi.Input<boolean>;
}