// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Gets the specified Consent artifact.
 */
export function getConsentArtifact(args: GetConsentArtifactArgs, opts?: pulumi.InvokeOptions): Promise<GetConsentArtifactResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("google-native:healthcare/v1beta1:getConsentArtifact", {
        "consentArtifactId": args.consentArtifactId,
        "consentStoreId": args.consentStoreId,
        "datasetId": args.datasetId,
        "location": args.location,
        "project": args.project,
    }, opts);
}

export interface GetConsentArtifactArgs {
    consentArtifactId: string;
    consentStoreId: string;
    datasetId: string;
    location: string;
    project: string;
}

export interface GetConsentArtifactResult {
    /**
     * Optional. Screenshots, PDFs, or other binary information documenting the user's consent.
     */
    readonly consentContentScreenshots: outputs.healthcare.v1beta1.ImageResponse[];
    /**
     * Optional. An string indicating the version of the consent information shown to the user.
     */
    readonly consentContentVersion: string;
    /**
     * Optional. A signature from a guardian.
     */
    readonly guardianSignature: outputs.healthcare.v1beta1.SignatureResponse;
    /**
     * Optional. Metadata associated with the Consent artifact. For example, the consent locale or user agent version.
     */
    readonly metadata: {[key: string]: string};
    /**
     * Resource name of the Consent artifact, of the form `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/consentStores/{consent_store_id}/consentArtifacts/{consent_artifact_id}`. Cannot be changed after creation.
     */
    readonly name: string;
    /**
     * Required. User's UUID provided by the client.
     */
    readonly userId: string;
    /**
     * Optional. User's signature.
     */
    readonly userSignature: outputs.healthcare.v1beta1.SignatureResponse;
    /**
     * Optional. A signature from a witness.
     */
    readonly witnessSignature: outputs.healthcare.v1beta1.SignatureResponse;
}