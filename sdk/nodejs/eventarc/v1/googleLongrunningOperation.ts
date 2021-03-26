// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

/**
 * Create a new trigger in a particular project and location.
 */
export class GoogleLongrunningOperation extends pulumi.CustomResource {
    /**
     * Get an existing GoogleLongrunningOperation resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): GoogleLongrunningOperation {
        return new GoogleLongrunningOperation(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'google-cloud:eventarc/v1:GoogleLongrunningOperation';

    /**
     * Returns true if the given object is an instance of GoogleLongrunningOperation.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is GoogleLongrunningOperation {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === GoogleLongrunningOperation.__pulumiType;
    }


    /**
     * Create a GoogleLongrunningOperation resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: GoogleLongrunningOperationArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.parent === undefined) && !opts.urn) {
                throw new Error("Missing required property 'parent'");
            }
            inputs["createTime"] = args ? args.createTime : undefined;
            inputs["destination"] = args ? args.destination : undefined;
            inputs["etag"] = args ? args.etag : undefined;
            inputs["eventFilters"] = args ? args.eventFilters : undefined;
            inputs["labels"] = args ? args.labels : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["parent"] = args ? args.parent : undefined;
            inputs["serviceAccount"] = args ? args.serviceAccount : undefined;
            inputs["transport"] = args ? args.transport : undefined;
            inputs["triggerId"] = args ? args.triggerId : undefined;
            inputs["uid"] = args ? args.uid : undefined;
            inputs["updateTime"] = args ? args.updateTime : undefined;
            inputs["validateOnly"] = args ? args.validateOnly : undefined;
        } else {
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(GoogleLongrunningOperation.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a GoogleLongrunningOperation resource.
 */
export interface GoogleLongrunningOperationArgs {
    /**
     * Output only. The creation time.
     */
    readonly createTime?: pulumi.Input<string>;
    /**
     * Required. Destination specifies where the events should be sent to.
     */
    readonly destination?: pulumi.Input<inputs.eventarc.v1.Destination>;
    /**
     * Output only. This checksum is computed by the server based on the value of other fields, and may be sent only on create requests to ensure the client has an up-to-date value before proceeding.
     */
    readonly etag?: pulumi.Input<string>;
    /**
     * Required. null The list of filters that applies to event attributes. Only events that match all the provided filters will be sent to the destination.
     */
    readonly eventFilters?: pulumi.Input<pulumi.Input<inputs.eventarc.v1.EventFilter>[]>;
    /**
     * Optional. User labels attached to the triggers that can be used to group resources.
     */
    readonly labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Required. The resource name of the trigger. Must be unique within the location on the project and must be in `projects/{project}/locations/{location}/triggers/{trigger}` format.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * Required. The parent collection in which to add this trigger.
     */
    readonly parent: pulumi.Input<string>;
    /**
     * Optional. The IAM service account email associated with the trigger. The service account represents the identity of the trigger. The principal who calls this API must have `iam.serviceAccounts.actAs` permission in the service account. See https://cloud.google.com/iam/docs/understanding-service-accounts?hl=en#sa_common for more information. For Cloud Run destinations, this service account is used to generate identity tokens when invoking the service. See https://cloud.google.com/run/docs/triggering/pubsub-push#create-service-account for information on how to invoke authenticated Cloud Run services. In order to create Audit Log triggers, the service account should also have `roles/eventarc.eventReceiver` IAM role.
     */
    readonly serviceAccount?: pulumi.Input<string>;
    /**
     * Optional. In order to deliver messages, Eventarc may use other GCP products as transport intermediary. This field contains a reference to that transport intermediary. This information can be used for debugging purposes.
     */
    readonly transport?: pulumi.Input<inputs.eventarc.v1.Transport>;
    /**
     * Required. The user-provided ID to be assigned to the trigger.
     */
    readonly triggerId?: pulumi.Input<string>;
    /**
     * Output only. Server assigned unique identifier for the trigger. The value is a UUID4 string and guaranteed to remain unchanged until the resource is deleted.
     */
    readonly uid?: pulumi.Input<string>;
    /**
     * Output only. The last-modified time.
     */
    readonly updateTime?: pulumi.Input<string>;
    /**
     * Required. If set, validate the request and preview the review, but do not actually post it.
     */
    readonly validateOnly?: pulumi.Input<boolean>;
}