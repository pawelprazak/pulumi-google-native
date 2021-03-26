// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

/**
 * Creates a composite type.
 */
export class CompositeType extends pulumi.CustomResource {
    /**
     * Get an existing CompositeType resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): CompositeType {
        return new CompositeType(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'google-cloud:deploymentmanager/v2beta:CompositeType';

    /**
     * Returns true if the given object is an instance of CompositeType.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is CompositeType {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === CompositeType.__pulumiType;
    }


    /**
     * Create a CompositeType resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: CompositeTypeArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.project === undefined) && !opts.urn) {
                throw new Error("Missing required property 'project'");
            }
            inputs["description"] = args ? args.description : undefined;
            inputs["id"] = args ? args.id : undefined;
            inputs["insertTime"] = args ? args.insertTime : undefined;
            inputs["labels"] = args ? args.labels : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["operation"] = args ? args.operation : undefined;
            inputs["project"] = args ? args.project : undefined;
            inputs["selfLink"] = args ? args.selfLink : undefined;
            inputs["status"] = args ? args.status : undefined;
            inputs["templateContents"] = args ? args.templateContents : undefined;
        } else {
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(CompositeType.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a CompositeType resource.
 */
export interface CompositeTypeArgs {
    /**
     * An optional textual description of the resource; provided by the client when the resource is created.
     */
    readonly description?: pulumi.Input<string>;
    readonly id?: pulumi.Input<string>;
    /**
     * Output only. Creation timestamp in RFC3339 text format.
     */
    readonly insertTime?: pulumi.Input<string>;
    /**
     * Map of labels; provided by the client when the resource is created or updated. Specifically: Label keys must be between 1 and 63 characters long and must conform to the following regular expression: `[a-z]([-a-z0-9]*[a-z0-9])?` Label values must be between 0 and 63 characters long and must conform to the regular expression `([a-z]([-a-z0-9]*[a-z0-9])?)?`.
     */
    readonly labels?: pulumi.Input<pulumi.Input<inputs.deploymentmanager.v2beta.CompositeTypeLabelEntry>[]>;
    /**
     * Name of the composite type, must follow the expression: `[a-z]([-a-z0-9_.]{0,61}[a-z0-9])?`.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * Output only. The Operation that most recently ran, or is currently running, on this composite type.
     */
    readonly operation?: pulumi.Input<inputs.deploymentmanager.v2beta.Operation>;
    /**
     * The project ID for this request.
     */
    readonly project: pulumi.Input<string>;
    /**
     * Output only. Server defined URL for the resource.
     */
    readonly selfLink?: pulumi.Input<string>;
    readonly status?: pulumi.Input<string>;
    /**
     * Files for the template type.
     */
    readonly templateContents?: pulumi.Input<inputs.deploymentmanager.v2beta.TemplateContents>;
}