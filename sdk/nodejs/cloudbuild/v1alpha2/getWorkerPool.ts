// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Returns details of a `WorkerPool`.
 */
export function getWorkerPool(args: GetWorkerPoolArgs, opts?: pulumi.InvokeOptions): Promise<GetWorkerPoolResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("google-native:cloudbuild/v1alpha2:getWorkerPool", {
        "project": args.project,
        "workerPoolId": args.workerPoolId,
    }, opts);
}

export interface GetWorkerPoolArgs {
    project?: string;
    workerPoolId: string;
}

export interface GetWorkerPoolResult {
    /**
     * Time at which the request to create the `WorkerPool` was received.
     */
    readonly createTime: string;
    /**
     * Time at which the request to delete the `WorkerPool` was received.
     */
    readonly deleteTime: string;
    /**
     * The resource name of the `WorkerPool`. Format of the name is `projects/{project_id}/workerPools/{worker_pool_id}`, where the value of {worker_pool_id} is provided in the CreateWorkerPool request.
     */
    readonly name: string;
    /**
     * Network configuration for the `WorkerPool`.
     */
    readonly networkConfig: outputs.cloudbuild.v1alpha2.NetworkConfigResponse;
    /**
     * Immutable. The region where the `WorkerPool` runs. Only "us-central1" is currently supported. Note that `region` cannot be changed once the `WorkerPool` is created.
     */
    readonly region: string;
    /**
     * WorkerPool state.
     */
    readonly state: string;
    /**
     * Time at which the request to update the `WorkerPool` was received.
     */
    readonly updateTime: string;
    /**
     * Worker configuration for the `WorkerPool`.
     */
    readonly workerConfig: outputs.cloudbuild.v1alpha2.WorkerConfigResponse;
}

export function getWorkerPoolOutput(args: GetWorkerPoolOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetWorkerPoolResult> {
    return pulumi.output(args).apply(a => getWorkerPool(a, opts))
}

export interface GetWorkerPoolOutputArgs {
    project?: pulumi.Input<string>;
    workerPoolId: pulumi.Input<string>;
}
