// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Retrieve the specified case.
 */
export function getCase(args: GetCaseArgs, opts?: pulumi.InvokeOptions): Promise<GetCaseResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("google-native:cloudsupport/v2beta:getCase", {
        "caseId": args.caseId,
        "v2betaId1": args.v2betaId1,
        "v2betumId": args.v2betumId,
    }, opts);
}

export interface GetCaseArgs {
    caseId: string;
    v2betaId1: string;
    v2betumId: string;
}

export interface GetCaseResult {
    /**
     * The issue classification applicable to this case.
     */
    readonly classification: outputs.cloudsupport.v2beta.CaseClassificationResponse;
    /**
     * The time this case was created.
     */
    readonly createTime: string;
    /**
     * The user who created the case. Note: The name and email will be obfuscated if the case was created by Google Support.
     */
    readonly creator: outputs.cloudsupport.v2beta.ActorResponse;
    /**
     * A broad description of the issue.
     */
    readonly description: string;
    /**
     * The short summary of the issue reported in this case.
     */
    readonly displayName: string;
    /**
     * Whether the case is currently escalated.
     */
    readonly escalated: boolean;
    /**
     * The resource name for the case.
     */
    readonly name: string;
    /**
     * The severity of this case.
     */
    readonly severity: string;
    /**
     * The current status of the support case.
     */
    readonly state: string;
    /**
     * The email addresses to receive updates on this case.
     */
    readonly subscriberEmailAddresses: string[];
    /**
     * Whether this case was created for internal API testing and should not be acted on by the support team.
     */
    readonly testCase: boolean;
    /**
     * The timezone of the user who created the support case. It should be in a format IANA recognizes: https://www.iana.org/time-zones. There is no additional validation done by the API.
     */
    readonly timeZone: string;
    /**
     * The time this case was last updated.
     */
    readonly updateTime: string;
}

export function getCaseOutput(args: GetCaseOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetCaseResult> {
    return pulumi.output(args).apply(a => getCase(a, opts))
}

export interface GetCaseOutputArgs {
    caseId: pulumi.Input<string>;
    v2betaId1: pulumi.Input<string>;
    v2betumId: pulumi.Input<string>;
}