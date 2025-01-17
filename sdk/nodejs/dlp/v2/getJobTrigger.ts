// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Gets a job trigger. See https://cloud.google.com/dlp/docs/creating-job-triggers to learn more.
 */
export function getJobTrigger(args: GetJobTriggerArgs, opts?: pulumi.InvokeOptions): Promise<GetJobTriggerResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("google-native:dlp/v2:getJobTrigger", {
        "jobTriggerId": args.jobTriggerId,
        "location": args.location,
        "project": args.project,
    }, opts);
}

export interface GetJobTriggerArgs {
    jobTriggerId: string;
    location: string;
    project?: string;
}

export interface GetJobTriggerResult {
    /**
     * The creation timestamp of a triggeredJob.
     */
    readonly createTime: string;
    /**
     * User provided description (max 256 chars)
     */
    readonly description: string;
    /**
     * Display name (max 100 chars)
     */
    readonly displayName: string;
    /**
     * A stream of errors encountered when the trigger was activated. Repeated errors may result in the JobTrigger automatically being paused. Will return the last 100 errors. Whenever the JobTrigger is modified this list will be cleared.
     */
    readonly errors: outputs.dlp.v2.GooglePrivacyDlpV2ErrorResponse[];
    /**
     * For inspect jobs, a snapshot of the configuration.
     */
    readonly inspectJob: outputs.dlp.v2.GooglePrivacyDlpV2InspectJobConfigResponse;
    /**
     * The timestamp of the last time this trigger executed.
     */
    readonly lastRunTime: string;
    /**
     * Unique resource name for the triggeredJob, assigned by the service when the triggeredJob is created, for example `projects/dlp-test-project/jobTriggers/53234423`.
     */
    readonly name: string;
    /**
     * A status for this trigger.
     */
    readonly status: string;
    /**
     * A list of triggers which will be OR'ed together. Only one in the list needs to trigger for a job to be started. The list may contain only a single Schedule trigger and must have at least one object.
     */
    readonly triggers: outputs.dlp.v2.GooglePrivacyDlpV2TriggerResponse[];
    /**
     * The last update timestamp of a triggeredJob.
     */
    readonly updateTime: string;
}

export function getJobTriggerOutput(args: GetJobTriggerOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetJobTriggerResult> {
    return pulumi.output(args).apply(a => getJobTrigger(a, opts))
}

export interface GetJobTriggerOutputArgs {
    jobTriggerId: pulumi.Input<string>;
    location: pulumi.Input<string>;
    project?: pulumi.Input<string>;
}
