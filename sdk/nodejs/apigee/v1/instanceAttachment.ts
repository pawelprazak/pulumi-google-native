// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

/**
 * Creates a new attachment of an environment to an instance. **Note:** Not supported for Apigee hybrid.
 * Auto-naming is currently not supported for this resource.
 */
export class InstanceAttachment extends pulumi.CustomResource {
    /**
     * Get an existing InstanceAttachment resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): InstanceAttachment {
        return new InstanceAttachment(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'google-native:apigee/v1:InstanceAttachment';

    /**
     * Returns true if the given object is an instance of InstanceAttachment.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is InstanceAttachment {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === InstanceAttachment.__pulumiType;
    }

    /**
     * Time the attachment was created in milliseconds since epoch.
     */
    public /*out*/ readonly createdAt!: pulumi.Output<string>;
    /**
     * ID of the attached environment.
     */
    public readonly environment!: pulumi.Output<string>;
    /**
     * ID of the attachment.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;

    /**
     * Create a InstanceAttachment resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: InstanceAttachmentArgs, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.instanceId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'instanceId'");
            }
            if ((!args || args.organizationId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'organizationId'");
            }
            resourceInputs["environment"] = args ? args.environment : undefined;
            resourceInputs["instanceId"] = args ? args.instanceId : undefined;
            resourceInputs["organizationId"] = args ? args.organizationId : undefined;
            resourceInputs["createdAt"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
        } else {
            resourceInputs["createdAt"] = undefined /*out*/;
            resourceInputs["environment"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(InstanceAttachment.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * The set of arguments for constructing a InstanceAttachment resource.
 */
export interface InstanceAttachmentArgs {
    /**
     * ID of the attached environment.
     */
    environment?: pulumi.Input<string>;
    instanceId: pulumi.Input<string>;
    organizationId: pulumi.Input<string>;
}