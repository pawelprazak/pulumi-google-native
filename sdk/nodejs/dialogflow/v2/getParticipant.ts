// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

/**
 * Retrieves a conversation participant.
 */
export function getParticipant(args: GetParticipantArgs, opts?: pulumi.InvokeOptions): Promise<GetParticipantResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("google-native:dialogflow/v2:getParticipant", {
        "conversationId": args.conversationId,
        "location": args.location,
        "participantId": args.participantId,
        "project": args.project,
    }, opts);
}

export interface GetParticipantArgs {
    conversationId: string;
    location: string;
    participantId: string;
    project?: string;
}

export interface GetParticipantResult {
    /**
     * Optional. Key-value filters on the metadata of documents returned by article suggestion. If specified, article suggestion only returns suggested documents that match all filters in their Document.metadata. Multiple values for a metadata key should be concatenated by comma. For example, filters to match all documents that have 'US' or 'CA' in their market metadata values and 'agent' in their user metadata values will be ``` documents_metadata_filters { key: "market" value: "US,CA" } documents_metadata_filters { key: "user" value: "agent" } ```
     */
    readonly documentsMetadataFilters: {[key: string]: string};
    /**
     * Optional. The unique identifier of this participant. Format: `projects//locations//conversations//participants/`.
     */
    readonly name: string;
    /**
     * Immutable. The role this participant plays in the conversation. This field must be set during participant creation and is then immutable.
     */
    readonly role: string;
    /**
     * Optional. Label applied to streams representing this participant in SIPREC XML metadata and SDP. This is used to assign transcriptions from that media stream to this participant. This field can be updated.
     */
    readonly sipRecordingMediaLabel: string;
}

export function getParticipantOutput(args: GetParticipantOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetParticipantResult> {
    return pulumi.output(args).apply(a => getParticipant(a, opts))
}

export interface GetParticipantOutputArgs {
    conversationId: pulumi.Input<string>;
    location: pulumi.Input<string>;
    participantId: pulumi.Input<string>;
    project?: pulumi.Input<string>;
}
