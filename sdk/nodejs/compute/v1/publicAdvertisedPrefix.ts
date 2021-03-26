// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

/**
 * Creates a PublicAdvertisedPrefix in the specified project using the parameters that are included in the request.
 */
export class PublicAdvertisedPrefix extends pulumi.CustomResource {
    /**
     * Get an existing PublicAdvertisedPrefix resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): PublicAdvertisedPrefix {
        return new PublicAdvertisedPrefix(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'google-cloud:compute/v1:PublicAdvertisedPrefix';

    /**
     * Returns true if the given object is an instance of PublicAdvertisedPrefix.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is PublicAdvertisedPrefix {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === PublicAdvertisedPrefix.__pulumiType;
    }


    /**
     * Create a PublicAdvertisedPrefix resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: PublicAdvertisedPrefixArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.project === undefined) && !opts.urn) {
                throw new Error("Missing required property 'project'");
            }
            inputs["creationTimestamp"] = args ? args.creationTimestamp : undefined;
            inputs["description"] = args ? args.description : undefined;
            inputs["dnsVerificationIp"] = args ? args.dnsVerificationIp : undefined;
            inputs["fingerprint"] = args ? args.fingerprint : undefined;
            inputs["id"] = args ? args.id : undefined;
            inputs["ipCidrRange"] = args ? args.ipCidrRange : undefined;
            inputs["kind"] = args ? args.kind : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["project"] = args ? args.project : undefined;
            inputs["publicDelegatedPrefixs"] = args ? args.publicDelegatedPrefixs : undefined;
            inputs["requestId"] = args ? args.requestId : undefined;
            inputs["selfLink"] = args ? args.selfLink : undefined;
            inputs["sharedSecret"] = args ? args.sharedSecret : undefined;
            inputs["status"] = args ? args.status : undefined;
        } else {
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(PublicAdvertisedPrefix.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a PublicAdvertisedPrefix resource.
 */
export interface PublicAdvertisedPrefixArgs {
    /**
     * [Output Only] Creation timestamp in RFC3339 text format.
     */
    readonly creationTimestamp?: pulumi.Input<string>;
    /**
     * An optional description of this resource. Provide this property when you create the resource.
     */
    readonly description?: pulumi.Input<string>;
    /**
     * The IPv4 address to be used for reverse DNS verification.
     */
    readonly dnsVerificationIp?: pulumi.Input<string>;
    /**
     * Fingerprint of this resource. A hash of the contents stored in this object. This field is used in optimistic locking. This field will be ignored when inserting a new PublicAdvertisedPrefix. An up-to-date fingerprint must be provided in order to update the PublicAdvertisedPrefix, otherwise the request will fail with error 412 conditionNotMet.
     *
     * To see the latest fingerprint, make a get() request to retrieve a PublicAdvertisedPrefix.
     */
    readonly fingerprint?: pulumi.Input<string>;
    /**
     * [Output Only] The unique identifier for the resource type. The server generates this identifier.
     */
    readonly id?: pulumi.Input<string>;
    /**
     * The IPv4 address range, in CIDR format, represented by this public advertised prefix.
     */
    readonly ipCidrRange?: pulumi.Input<string>;
    /**
     * [Output Only] Type of the resource. Always compute#publicAdvertisedPrefix for public advertised prefixes.
     */
    readonly kind?: pulumi.Input<string>;
    /**
     * Name of the resource. Provided by the client when the resource is created. The name must be 1-63 characters long, and comply with RFC1035. Specifically, the name must be 1-63 characters long and match the regular expression `[a-z]([-a-z0-9]*[a-z0-9])?` which means the first character must be a lowercase letter, and all following characters must be a dash, lowercase letter, or digit, except the last character, which cannot be a dash.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * Project ID for this request.
     */
    readonly project: pulumi.Input<string>;
    /**
     * [Output Only] The list of public delegated prefixes that exist for this public advertised prefix.
     */
    readonly publicDelegatedPrefixs?: pulumi.Input<pulumi.Input<inputs.compute.v1.PublicAdvertisedPrefixPublicDelegatedPrefix>[]>;
    /**
     * An optional request ID to identify requests. Specify a unique request ID so that if you must retry your request, the server will know to ignore the request if it has already been completed.
     *
     * For example, consider a situation where you make an initial request and the request times out. If you make the request again with the same request ID, the server can check if original operation with the same request ID was received, and if so, will ignore the second request. This prevents clients from accidentally creating duplicate commitments.
     *
     * The request ID must be a valid UUID with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
     */
    readonly requestId?: pulumi.Input<string>;
    /**
     * [Output Only] Server-defined URL for the resource.
     */
    readonly selfLink?: pulumi.Input<string>;
    /**
     * [Output Only] The shared secret to be used for reverse DNS verification.
     */
    readonly sharedSecret?: pulumi.Input<string>;
    /**
     * The status of the public advertised prefix.
     */
    readonly status?: pulumi.Input<string>;
}