// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Creates a `WorkerPool` to run the builds, and returns the new worker pool.
 */
export class WorkerPool extends pulumi.CustomResource {
    /**
     * Get an existing WorkerPool resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): WorkerPool {
        return new WorkerPool(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'google-native:cloudbuild/v1alpha1:WorkerPool';

    /**
     * Returns true if the given object is an instance of WorkerPool.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is WorkerPool {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === WorkerPool.__pulumiType;
    }

    /**
     * Time at which the request to create the `WorkerPool` was received.
     */
    public /*out*/ readonly createTime!: pulumi.Output<string>;
    /**
     * Time at which the request to delete the `WorkerPool` was received.
     */
    public /*out*/ readonly deleteTime!: pulumi.Output<string>;
    /**
     * User-defined name of the `WorkerPool`.
     */
    public readonly name!: pulumi.Output<string>;
    public readonly project!: pulumi.Output<string>;
    /**
     * List of regions to create the `WorkerPool`. Regions can't be empty. If Cloud Build adds a new GCP region in the future, the existing `WorkerPool` will not be enabled in the new region automatically; you must add the new region to the `regions` field to enable the `WorkerPool` in that region.
     */
    public readonly regions!: pulumi.Output<string[]>;
    /**
     * The service account used to manage the `WorkerPool`. The service account must have the Compute Instance Admin (Beta) permission at the project level.
     */
    public /*out*/ readonly serviceAccountEmail!: pulumi.Output<string>;
    /**
     * WorkerPool Status.
     */
    public /*out*/ readonly status!: pulumi.Output<string>;
    /**
     * Time at which the request to update the `WorkerPool` was received.
     */
    public /*out*/ readonly updateTime!: pulumi.Output<string>;
    /**
     * Configuration to be used for a creating workers in the `WorkerPool`.
     */
    public readonly workerConfig!: pulumi.Output<outputs.cloudbuild.v1alpha1.WorkerConfigResponse>;
    /**
     * Total number of workers to be created across all requested regions.
     */
    public readonly workerCount!: pulumi.Output<string>;

    /**
     * Create a WorkerPool resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: WorkerPoolArgs, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["project"] = args ? args.project : undefined;
            resourceInputs["regions"] = args ? args.regions : undefined;
            resourceInputs["workerConfig"] = args ? args.workerConfig : undefined;
            resourceInputs["workerCount"] = args ? args.workerCount : undefined;
            resourceInputs["createTime"] = undefined /*out*/;
            resourceInputs["deleteTime"] = undefined /*out*/;
            resourceInputs["serviceAccountEmail"] = undefined /*out*/;
            resourceInputs["status"] = undefined /*out*/;
            resourceInputs["updateTime"] = undefined /*out*/;
        } else {
            resourceInputs["createTime"] = undefined /*out*/;
            resourceInputs["deleteTime"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["project"] = undefined /*out*/;
            resourceInputs["regions"] = undefined /*out*/;
            resourceInputs["serviceAccountEmail"] = undefined /*out*/;
            resourceInputs["status"] = undefined /*out*/;
            resourceInputs["updateTime"] = undefined /*out*/;
            resourceInputs["workerConfig"] = undefined /*out*/;
            resourceInputs["workerCount"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(WorkerPool.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * The set of arguments for constructing a WorkerPool resource.
 */
export interface WorkerPoolArgs {
    /**
     * User-defined name of the `WorkerPool`.
     */
    name?: pulumi.Input<string>;
    /**
     * The project ID of the GCP project for which the `WorkerPool` is created.
     */
    project?: pulumi.Input<string>;
    /**
     * List of regions to create the `WorkerPool`. Regions can't be empty. If Cloud Build adds a new GCP region in the future, the existing `WorkerPool` will not be enabled in the new region automatically; you must add the new region to the `regions` field to enable the `WorkerPool` in that region.
     */
    regions?: pulumi.Input<pulumi.Input<enums.cloudbuild.v1alpha1.WorkerPoolRegionsItem>[]>;
    /**
     * Configuration to be used for a creating workers in the `WorkerPool`.
     */
    workerConfig?: pulumi.Input<inputs.cloudbuild.v1alpha1.WorkerConfigArgs>;
    /**
     * Total number of workers to be created across all requested regions.
     */
    workerCount?: pulumi.Input<string>;
}
