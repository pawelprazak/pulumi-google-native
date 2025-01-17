// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

/**
 * GetArtifact returns a specified artifact.
 */
export function getArtifact(args: GetArtifactArgs, opts?: pulumi.InvokeOptions): Promise<GetArtifactResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("google-native:apigeeregistry/v1:getArtifact", {
        "apiId": args.apiId,
        "artifactId": args.artifactId,
        "location": args.location,
        "project": args.project,
        "specId": args.specId,
        "versionId": args.versionId,
    }, opts);
}

export interface GetArtifactArgs {
    apiId: string;
    artifactId: string;
    location: string;
    project?: string;
    specId: string;
    versionId: string;
}

export interface GetArtifactResult {
    /**
     * Input only. The contents of the artifact. Provided by API callers when artifacts are created or replaced. To access the contents of an artifact, use GetArtifactContents.
     */
    readonly contents: string;
    /**
     * Creation timestamp.
     */
    readonly createTime: string;
    /**
     * A SHA-256 hash of the artifact's contents. If the artifact is gzipped, this is the hash of the uncompressed artifact.
     */
    readonly hash: string;
    /**
     * A content type specifier for the artifact. Content type specifiers are Media Types (https://en.wikipedia.org/wiki/Media_type) with a possible "schema" parameter that specifies a schema for the stored information. Content types can specify compression. Currently only GZip compression is supported (indicated with "+gzip").
     */
    readonly mimeType: string;
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * The size of the artifact in bytes. If the artifact is gzipped, this is the size of the uncompressed artifact.
     */
    readonly sizeBytes: number;
    /**
     * Last update timestamp.
     */
    readonly updateTime: string;
}

export function getArtifactOutput(args: GetArtifactOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetArtifactResult> {
    return pulumi.output(args).apply(a => getArtifact(a, opts))
}

export interface GetArtifactOutputArgs {
    apiId: pulumi.Input<string>;
    artifactId: pulumi.Input<string>;
    location: pulumi.Input<string>;
    project?: pulumi.Input<string>;
    specId: pulumi.Input<string>;
    versionId: pulumi.Input<string>;
}
