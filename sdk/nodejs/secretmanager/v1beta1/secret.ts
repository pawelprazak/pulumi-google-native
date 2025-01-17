// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Creates a new Secret containing no SecretVersions.
 * Auto-naming is currently not supported for this resource.
 */
export class Secret extends pulumi.CustomResource {
    /**
     * Get an existing Secret resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Secret {
        return new Secret(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'google-native:secretmanager/v1beta1:Secret';

    /**
     * Returns true if the given object is an instance of Secret.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Secret {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Secret.__pulumiType;
    }

    /**
     * The time at which the Secret was created.
     */
    public /*out*/ readonly createTime!: pulumi.Output<string>;
    /**
     * The labels assigned to this Secret. Label keys must be between 1 and 63 characters long, have a UTF-8 encoding of maximum 128 bytes, and must conform to the following PCRE regular expression: `\p{Ll}\p{Lo}{0,62}` Label values must be between 0 and 63 characters long, have a UTF-8 encoding of maximum 128 bytes, and must conform to the following PCRE regular expression: `[\p{Ll}\p{Lo}\p{N}_-]{0,63}` No more than 64 labels can be assigned to a given resource.
     */
    public readonly labels!: pulumi.Output<{[key: string]: string}>;
    /**
     * The resource name of the Secret in the format `projects/*&#47;secrets/*`.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    public readonly project!: pulumi.Output<string>;
    /**
     * Immutable. The replication policy of the secret data attached to the Secret. The replication policy cannot be changed after the Secret has been created.
     */
    public readonly replication!: pulumi.Output<outputs.secretmanager.v1beta1.ReplicationResponse>;
    /**
     * Required. This must be unique within the project. A secret ID is a string with a maximum length of 255 characters and can contain uppercase and lowercase letters, numerals, and the hyphen (`-`) and underscore (`_`) characters.
     */
    public readonly secretId!: pulumi.Output<string>;

    /**
     * Create a Secret resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: SecretArgs, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.replication === undefined) && !opts.urn) {
                throw new Error("Missing required property 'replication'");
            }
            if ((!args || args.secretId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'secretId'");
            }
            resourceInputs["labels"] = args ? args.labels : undefined;
            resourceInputs["project"] = args ? args.project : undefined;
            resourceInputs["replication"] = args ? args.replication : undefined;
            resourceInputs["secretId"] = args ? args.secretId : undefined;
            resourceInputs["createTime"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
        } else {
            resourceInputs["createTime"] = undefined /*out*/;
            resourceInputs["labels"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["project"] = undefined /*out*/;
            resourceInputs["replication"] = undefined /*out*/;
            resourceInputs["secretId"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(Secret.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * The set of arguments for constructing a Secret resource.
 */
export interface SecretArgs {
    /**
     * The labels assigned to this Secret. Label keys must be between 1 and 63 characters long, have a UTF-8 encoding of maximum 128 bytes, and must conform to the following PCRE regular expression: `\p{Ll}\p{Lo}{0,62}` Label values must be between 0 and 63 characters long, have a UTF-8 encoding of maximum 128 bytes, and must conform to the following PCRE regular expression: `[\p{Ll}\p{Lo}\p{N}_-]{0,63}` No more than 64 labels can be assigned to a given resource.
     */
    labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    project?: pulumi.Input<string>;
    /**
     * Immutable. The replication policy of the secret data attached to the Secret. The replication policy cannot be changed after the Secret has been created.
     */
    replication: pulumi.Input<inputs.secretmanager.v1beta1.ReplicationArgs>;
    /**
     * Required. This must be unique within the project. A secret ID is a string with a maximum length of 255 characters and can contain uppercase and lowercase letters, numerals, and the hyphen (`-`) and underscore (`_`) characters.
     */
    secretId: pulumi.Input<string>;
}
