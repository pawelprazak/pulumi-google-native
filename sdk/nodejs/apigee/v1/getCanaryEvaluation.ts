// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Gets a CanaryEvaluation for an organization.
 */
export function getCanaryEvaluation(args: GetCanaryEvaluationArgs, opts?: pulumi.InvokeOptions): Promise<GetCanaryEvaluationResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("google-native:apigee/v1:getCanaryEvaluation", {
        "canaryevaluationId": args.canaryevaluationId,
        "instanceId": args.instanceId,
        "organizationId": args.organizationId,
    }, opts);
}

export interface GetCanaryEvaluationArgs {
    canaryevaluationId: string;
    instanceId: string;
    organizationId: string;
}

export interface GetCanaryEvaluationResult {
    /**
     * The stable version that is serving requests.
     */
    readonly control: string;
    /**
     * Create time of the canary evaluation.
     */
    readonly createTime: string;
    /**
     * End time for the evaluation's analysis.
     */
    readonly endTime: string;
    /**
     * Labels used to filter the metrics used for a canary evaluation.
     */
    readonly metricLabels: outputs.apigee.v1.GoogleCloudApigeeV1CanaryEvaluationMetricLabelsResponse;
    /**
     * Name of the canary evalution.
     */
    readonly name: string;
    /**
     * Start time for the canary evaluation's analysis.
     */
    readonly startTime: string;
    /**
     * The current state of the canary evaluation.
     */
    readonly state: string;
    /**
     * The newer version that is serving requests.
     */
    readonly treatment: string;
    /**
     * The resulting verdict of the canary evaluations: NONE, PASS, or FAIL.
     */
    readonly verdict: string;
}

export function getCanaryEvaluationOutput(args: GetCanaryEvaluationOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetCanaryEvaluationResult> {
    return pulumi.output(args).apply(a => getCanaryEvaluation(a, opts))
}

export interface GetCanaryEvaluationOutputArgs {
    canaryevaluationId: pulumi.Input<string>;
    instanceId: pulumi.Input<string>;
    organizationId: pulumi.Input<string>;
}
