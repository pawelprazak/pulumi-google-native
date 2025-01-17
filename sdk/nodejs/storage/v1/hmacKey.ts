// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

/**
 * Creates a new HMAC key for the specified service account.
 * Auto-naming is currently not supported for this resource.
 */
export class HmacKey extends pulumi.CustomResource {
    /**
     * Get an existing HmacKey resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): HmacKey {
        return new HmacKey(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'google-native:storage/v1:HmacKey';

    /**
     * Returns true if the given object is an instance of HmacKey.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is HmacKey {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === HmacKey.__pulumiType;
    }

    /**
     * The ID of the HMAC Key.
     */
    public /*out*/ readonly accessId!: pulumi.Output<string>;
    /**
     * HTTP 1.1 Entity tag for the HMAC key.
     */
    public /*out*/ readonly etag!: pulumi.Output<string>;
    /**
     * The kind of item this is. For HMAC Key metadata, this is always storage#hmacKeyMetadata.
     */
    public /*out*/ readonly kind!: pulumi.Output<string>;
    public readonly project!: pulumi.Output<string>;
    /**
     * The link to this resource.
     */
    public /*out*/ readonly selfLink!: pulumi.Output<string>;
    /**
     * Email address of the service account.
     */
    public readonly serviceAccountEmail!: pulumi.Output<string>;
    /**
     * The state of the key. Can be one of ACTIVE, INACTIVE, or DELETED.
     */
    public /*out*/ readonly state!: pulumi.Output<string>;
    /**
     * The creation time of the HMAC key in RFC 3339 format.
     */
    public /*out*/ readonly timeCreated!: pulumi.Output<string>;
    /**
     * The last modification time of the HMAC key metadata in RFC 3339 format.
     */
    public /*out*/ readonly updated!: pulumi.Output<string>;
    /**
     * The project to be billed for this request.
     */
    public readonly userProject!: pulumi.Output<string | undefined>;

    /**
     * Create a HmacKey resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: HmacKeyArgs, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.serviceAccountEmail === undefined) && !opts.urn) {
                throw new Error("Missing required property 'serviceAccountEmail'");
            }
            resourceInputs["project"] = args ? args.project : undefined;
            resourceInputs["serviceAccountEmail"] = args ? args.serviceAccountEmail : undefined;
            resourceInputs["userProject"] = args ? args.userProject : undefined;
            resourceInputs["accessId"] = undefined /*out*/;
            resourceInputs["etag"] = undefined /*out*/;
            resourceInputs["kind"] = undefined /*out*/;
            resourceInputs["selfLink"] = undefined /*out*/;
            resourceInputs["state"] = undefined /*out*/;
            resourceInputs["timeCreated"] = undefined /*out*/;
            resourceInputs["updated"] = undefined /*out*/;
        } else {
            resourceInputs["accessId"] = undefined /*out*/;
            resourceInputs["etag"] = undefined /*out*/;
            resourceInputs["kind"] = undefined /*out*/;
            resourceInputs["project"] = undefined /*out*/;
            resourceInputs["selfLink"] = undefined /*out*/;
            resourceInputs["serviceAccountEmail"] = undefined /*out*/;
            resourceInputs["state"] = undefined /*out*/;
            resourceInputs["timeCreated"] = undefined /*out*/;
            resourceInputs["updated"] = undefined /*out*/;
            resourceInputs["userProject"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(HmacKey.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * The set of arguments for constructing a HmacKey resource.
 */
export interface HmacKeyArgs {
    project?: pulumi.Input<string>;
    /**
     * Email address of the service account.
     */
    serviceAccountEmail: pulumi.Input<string>;
    /**
     * The project to be billed for this request.
     */
    userProject?: pulumi.Input<string>;
}
