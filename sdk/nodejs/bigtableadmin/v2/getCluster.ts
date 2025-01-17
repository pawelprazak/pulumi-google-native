// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Gets information about a cluster.
 */
export function getCluster(args: GetClusterArgs, opts?: pulumi.InvokeOptions): Promise<GetClusterResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("google-native:bigtableadmin/v2:getCluster", {
        "clusterId": args.clusterId,
        "instanceId": args.instanceId,
        "project": args.project,
    }, opts);
}

export interface GetClusterArgs {
    clusterId: string;
    instanceId: string;
    project?: string;
}

export interface GetClusterResult {
    /**
     * Configuration for this cluster.
     */
    readonly clusterConfig: outputs.bigtableadmin.v2.ClusterConfigResponse;
    /**
     * Immutable. The type of storage used by this cluster to serve its parent instance's tables, unless explicitly overridden.
     */
    readonly defaultStorageType: string;
    /**
     * Immutable. The encryption configuration for CMEK-protected clusters.
     */
    readonly encryptionConfig: outputs.bigtableadmin.v2.EncryptionConfigResponse;
    /**
     * Immutable. The location where this cluster's nodes and storage reside. For best performance, clients should be located as close as possible to this cluster. Currently only zones are supported, so values should be of the form `projects/{project}/locations/{zone}`.
     */
    readonly location: string;
    /**
     * The unique name of the cluster. Values are of the form `projects/{project}/instances/{instance}/clusters/a-z*`.
     */
    readonly name: string;
    /**
     * The number of nodes allocated to this cluster. More nodes enable higher throughput and more consistent performance.
     */
    readonly serveNodes: number;
    /**
     * The current state of the cluster.
     */
    readonly state: string;
}

export function getClusterOutput(args: GetClusterOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetClusterResult> {
    return pulumi.output(args).apply(a => getCluster(a, opts))
}

export interface GetClusterOutputArgs {
    clusterId: pulumi.Input<string>;
    instanceId: pulumi.Input<string>;
    project?: pulumi.Input<string>;
}
