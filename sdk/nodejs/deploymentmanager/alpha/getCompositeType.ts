// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Gets information about a specific composite type.
 */
export function getCompositeType(args: GetCompositeTypeArgs, opts?: pulumi.InvokeOptions): Promise<GetCompositeTypeResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("google-native:deploymentmanager/alpha:getCompositeType", {
        "compositeType": args.compositeType,
        "project": args.project,
    }, opts);
}

export interface GetCompositeTypeArgs {
    compositeType: string;
    project?: string;
}

export interface GetCompositeTypeResult {
    /**
     * An optional textual description of the resource; provided by the client when the resource is created.
     */
    readonly description: string;
    /**
     * Creation timestamp in RFC3339 text format.
     */
    readonly insertTime: string;
    /**
     * Map of labels; provided by the client when the resource is created or updated. Specifically: Label keys must be between 1 and 63 characters long and must conform to the following regular expression: `[a-z]([-a-z0-9]*[a-z0-9])?` Label values must be between 0 and 63 characters long and must conform to the regular expression `([a-z]([-a-z0-9]*[a-z0-9])?)?`.
     */
    readonly labels: outputs.deploymentmanager.alpha.CompositeTypeLabelEntryResponse[];
    /**
     * Name of the composite type, must follow the expression: `[a-z]([-a-z0-9_.]{0,61}[a-z0-9])?`.
     */
    readonly name: string;
    /**
     * The Operation that most recently ran, or is currently running, on this composite type.
     */
    readonly operation: outputs.deploymentmanager.alpha.OperationResponse;
    /**
     * Server defined URL for the resource.
     */
    readonly selfLink: string;
    readonly status: string;
    /**
     * Files for the template type.
     */
    readonly templateContents: outputs.deploymentmanager.alpha.TemplateContentsResponse;
}

export function getCompositeTypeOutput(args: GetCompositeTypeOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetCompositeTypeResult> {
    return pulumi.output(args).apply(a => getCompositeType(a, opts))
}

export interface GetCompositeTypeOutputArgs {
    compositeType: pulumi.Input<string>;
    project?: pulumi.Input<string>;
}
