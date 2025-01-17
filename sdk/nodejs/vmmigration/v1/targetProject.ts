// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

/**
 * Creates a new TargetProject in a given project. NOTE: TargetProject is a global resource; hence the only supported value for location is `global`.
 * Auto-naming is currently not supported for this resource.
 */
export class TargetProject extends pulumi.CustomResource {
    /**
     * Get an existing TargetProject resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): TargetProject {
        return new TargetProject(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'google-native:vmmigration/v1:TargetProject';

    /**
     * Returns true if the given object is an instance of TargetProject.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is TargetProject {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === TargetProject.__pulumiType;
    }

    /**
     * The time this target project resource was created (not related to when the Compute Engine project it points to was created).
     */
    public /*out*/ readonly createTime!: pulumi.Output<string>;
    /**
     * The target project's description.
     */
    public readonly description!: pulumi.Output<string>;
    public readonly location!: pulumi.Output<string>;
    /**
     * The name of the target project.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    public readonly project!: pulumi.Output<string>;
    /**
     * A request ID to identify requests. Specify a unique request ID so that if you must retry your request, the server will know to ignore the request if it has already been completed. The server will guarantee that for at least 60 minutes since the first request. For example, consider a situation where you make an initial request and t he request times out. If you make the request again with the same request ID, the server can check if original operation with the same request ID was received, and if so, will ignore the second request. This prevents clients from accidentally creating duplicate commitments. The request ID must be a valid UUID with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
     */
    public readonly requestId!: pulumi.Output<string | undefined>;
    /**
     * Required. The target_project identifier.
     */
    public readonly targetProjectId!: pulumi.Output<string>;
    /**
     * The last time the target project resource was updated.
     */
    public /*out*/ readonly updateTime!: pulumi.Output<string>;

    /**
     * Create a TargetProject resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: TargetProjectArgs, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.targetProjectId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'targetProjectId'");
            }
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["location"] = args ? args.location : undefined;
            resourceInputs["project"] = args ? args.project : undefined;
            resourceInputs["requestId"] = args ? args.requestId : undefined;
            resourceInputs["targetProjectId"] = args ? args.targetProjectId : undefined;
            resourceInputs["createTime"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["updateTime"] = undefined /*out*/;
        } else {
            resourceInputs["createTime"] = undefined /*out*/;
            resourceInputs["description"] = undefined /*out*/;
            resourceInputs["location"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["project"] = undefined /*out*/;
            resourceInputs["requestId"] = undefined /*out*/;
            resourceInputs["targetProjectId"] = undefined /*out*/;
            resourceInputs["updateTime"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(TargetProject.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * The set of arguments for constructing a TargetProject resource.
 */
export interface TargetProjectArgs {
    /**
     * The target project's description.
     */
    description?: pulumi.Input<string>;
    location?: pulumi.Input<string>;
    /**
     * The target project ID (number) or project name.
     */
    project?: pulumi.Input<string>;
    /**
     * A request ID to identify requests. Specify a unique request ID so that if you must retry your request, the server will know to ignore the request if it has already been completed. The server will guarantee that for at least 60 minutes since the first request. For example, consider a situation where you make an initial request and t he request times out. If you make the request again with the same request ID, the server can check if original operation with the same request ID was received, and if so, will ignore the second request. This prevents clients from accidentally creating duplicate commitments. The request ID must be a valid UUID with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
     */
    requestId?: pulumi.Input<string>;
    /**
     * Required. The target_project identifier.
     */
    targetProjectId: pulumi.Input<string>;
}
