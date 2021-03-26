// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

/**
 * Create a License resource in the specified project.  Caution This resource is intended for use only by third-party partners who are creating Cloud Marketplace images.
 */
export class License extends pulumi.CustomResource {
    /**
     * Get an existing License resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): License {
        return new License(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'google-cloud:compute/alpha:License';

    /**
     * Returns true if the given object is an instance of License.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is License {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === License.__pulumiType;
    }


    /**
     * Create a License resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: LicenseArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.project === undefined) && !opts.urn) {
                throw new Error("Missing required property 'project'");
            }
            inputs["chargesUseFee"] = args ? args.chargesUseFee : undefined;
            inputs["creationTimestamp"] = args ? args.creationTimestamp : undefined;
            inputs["description"] = args ? args.description : undefined;
            inputs["id"] = args ? args.id : undefined;
            inputs["kind"] = args ? args.kind : undefined;
            inputs["licenseCode"] = args ? args.licenseCode : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["project"] = args ? args.project : undefined;
            inputs["requestId"] = args ? args.requestId : undefined;
            inputs["resourceRequirements"] = args ? args.resourceRequirements : undefined;
            inputs["selfLink"] = args ? args.selfLink : undefined;
            inputs["selfLinkWithId"] = args ? args.selfLinkWithId : undefined;
            inputs["transferable"] = args ? args.transferable : undefined;
        } else {
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(License.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a License resource.
 */
export interface LicenseArgs {
    /**
     * [Output Only] Deprecated. This field no longer reflects whether a license charges a usage fee.
     */
    readonly chargesUseFee?: pulumi.Input<boolean>;
    /**
     * [Output Only] Creation timestamp in RFC3339 text format.
     */
    readonly creationTimestamp?: pulumi.Input<string>;
    /**
     * An optional textual description of the resource; provided by the client when the resource is created.
     */
    readonly description?: pulumi.Input<string>;
    /**
     * [Output Only] The unique identifier for the resource. This identifier is defined by the server.
     */
    readonly id?: pulumi.Input<string>;
    /**
     * [Output Only] Type of resource. Always compute#license for licenses.
     */
    readonly kind?: pulumi.Input<string>;
    /**
     * [Output Only] The unique code used to attach this license to images, snapshots, and disks.
     */
    readonly licenseCode?: pulumi.Input<string>;
    /**
     * Name of the resource. The name must be 1-63 characters long and comply with RFC1035.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * Project ID for this request.
     */
    readonly project: pulumi.Input<string>;
    /**
     * An optional request ID to identify requests. Specify a unique request ID so that if you must retry your request, the server will know to ignore the request if it has already been completed.
     *
     * For example, consider a situation where you make an initial request and the request times out. If you make the request again with the same request ID, the server can check if original operation with the same request ID was received, and if so, will ignore the second request. This prevents clients from accidentally creating duplicate commitments.
     *
     * The request ID must be a valid UUID with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
     */
    readonly requestId?: pulumi.Input<string>;
    readonly resourceRequirements?: pulumi.Input<inputs.compute.alpha.LicenseResourceRequirements>;
    /**
     * [Output Only] Server-defined URL for the resource.
     */
    readonly selfLink?: pulumi.Input<string>;
    /**
     * [Output Only] Server-defined URL for this resource with the resource id.
     */
    readonly selfLinkWithId?: pulumi.Input<string>;
    /**
     * If false, licenses will not be copied from the source resource when creating an image from a disk, disk from snapshot, or snapshot from disk.
     */
    readonly transferable?: pulumi.Input<boolean>;
}