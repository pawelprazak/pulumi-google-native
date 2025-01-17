// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Creates a PerfSampleSeries. May return any of the following error code(s): - ALREADY_EXISTS - PerfMetricSummary already exists for the given Step - NOT_FOUND - The containing Step does not exist
 * Auto-naming is currently not supported for this resource.
 * Note - this resource's API doesn't support deletion. When deleted, the resource will persist
 * on Google Cloud even though it will be deleted from Pulumi state.
 */
export class PerfSampleSeries extends pulumi.CustomResource {
    /**
     * Get an existing PerfSampleSeries resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): PerfSampleSeries {
        return new PerfSampleSeries(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'google-native:toolresults/v1beta3:PerfSampleSeries';

    /**
     * Returns true if the given object is an instance of PerfSampleSeries.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is PerfSampleSeries {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === PerfSampleSeries.__pulumiType;
    }

    /**
     * Basic series represented by a line chart
     */
    public readonly basicPerfSampleSeries!: pulumi.Output<outputs.toolresults.v1beta3.BasicPerfSampleSeriesResponse>;
    public readonly executionId!: pulumi.Output<string>;
    public readonly historyId!: pulumi.Output<string>;
    public readonly project!: pulumi.Output<string>;
    /**
     * A sample series id 
     */
    public /*out*/ readonly sampleSeriesId!: pulumi.Output<string>;
    public readonly stepId!: pulumi.Output<string>;

    /**
     * Create a PerfSampleSeries resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: PerfSampleSeriesArgs, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.executionId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'executionId'");
            }
            if ((!args || args.historyId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'historyId'");
            }
            if ((!args || args.stepId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'stepId'");
            }
            resourceInputs["basicPerfSampleSeries"] = args ? args.basicPerfSampleSeries : undefined;
            resourceInputs["executionId"] = args ? args.executionId : undefined;
            resourceInputs["historyId"] = args ? args.historyId : undefined;
            resourceInputs["project"] = args ? args.project : undefined;
            resourceInputs["stepId"] = args ? args.stepId : undefined;
            resourceInputs["sampleSeriesId"] = undefined /*out*/;
        } else {
            resourceInputs["basicPerfSampleSeries"] = undefined /*out*/;
            resourceInputs["executionId"] = undefined /*out*/;
            resourceInputs["historyId"] = undefined /*out*/;
            resourceInputs["project"] = undefined /*out*/;
            resourceInputs["sampleSeriesId"] = undefined /*out*/;
            resourceInputs["stepId"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(PerfSampleSeries.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * The set of arguments for constructing a PerfSampleSeries resource.
 */
export interface PerfSampleSeriesArgs {
    /**
     * Basic series represented by a line chart
     */
    basicPerfSampleSeries?: pulumi.Input<inputs.toolresults.v1beta3.BasicPerfSampleSeriesArgs>;
    executionId: pulumi.Input<string>;
    historyId: pulumi.Input<string>;
    project?: pulumi.Input<string>;
    stepId: pulumi.Input<string>;
}
