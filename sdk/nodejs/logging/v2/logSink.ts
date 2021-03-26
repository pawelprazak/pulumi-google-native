// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

/**
 * Creates a sink that exports specified log entries to a destination. The export of newly-ingested log entries begins immediately, unless the sink's writer_identity is not permitted to write to the destination. A sink can export log entries only from the resource owning the sink.
 */
export class LogSink extends pulumi.CustomResource {
    /**
     * Get an existing LogSink resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): LogSink {
        return new LogSink(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'google-cloud:logging/v2:LogSink';

    /**
     * Returns true if the given object is an instance of LogSink.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is LogSink {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === LogSink.__pulumiType;
    }


    /**
     * Create a LogSink resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: LogSinkArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.parent === undefined) && !opts.urn) {
                throw new Error("Missing required property 'parent'");
            }
            inputs["bigqueryOptions"] = args ? args.bigqueryOptions : undefined;
            inputs["createTime"] = args ? args.createTime : undefined;
            inputs["description"] = args ? args.description : undefined;
            inputs["destination"] = args ? args.destination : undefined;
            inputs["disabled"] = args ? args.disabled : undefined;
            inputs["exclusions"] = args ? args.exclusions : undefined;
            inputs["filter"] = args ? args.filter : undefined;
            inputs["includeChildren"] = args ? args.includeChildren : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["outputVersionFormat"] = args ? args.outputVersionFormat : undefined;
            inputs["parent"] = args ? args.parent : undefined;
            inputs["uniqueWriterIdentity"] = args ? args.uniqueWriterIdentity : undefined;
            inputs["updateTime"] = args ? args.updateTime : undefined;
            inputs["writerIdentity"] = args ? args.writerIdentity : undefined;
        } else {
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(LogSink.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a LogSink resource.
 */
export interface LogSinkArgs {
    /**
     * Optional. Options that affect sinks exporting data to BigQuery.
     */
    readonly bigqueryOptions?: pulumi.Input<inputs.logging.v2.BigQueryOptions>;
    /**
     * Output only. The creation timestamp of the sink.This field may not be present for older sinks.
     */
    readonly createTime?: pulumi.Input<string>;
    /**
     * Optional. A description of this sink. The maximum length of the description is 8000 characters.
     */
    readonly description?: pulumi.Input<string>;
    /**
     * Required. The export destination: "storage.googleapis.com/[GCS_BUCKET]" "bigquery.googleapis.com/projects/[PROJECT_ID]/datasets/[DATASET]" "pubsub.googleapis.com/projects/[PROJECT_ID]/topics/[TOPIC_ID]" The sink's writer_identity, set when the sink is created, must have permission to write to the destination or else the log entries are not exported. For more information, see Exporting Logs with Sinks (https://cloud.google.com/logging/docs/api/tasks/exporting-logs).
     */
    readonly destination?: pulumi.Input<string>;
    /**
     * Optional. If set to True, then this sink is disabled and it does not export any log entries.
     */
    readonly disabled?: pulumi.Input<boolean>;
    /**
     * Optional. Log entries that match any of the exclusion filters will not be exported. If a log entry is matched by both filter and one of exclusion_filters it will not be exported.
     */
    readonly exclusions?: pulumi.Input<pulumi.Input<inputs.logging.v2.LogExclusion>[]>;
    /**
     * Optional. An advanced logs filter (https://cloud.google.com/logging/docs/view/advanced-queries). The only exported log entries are those that are in the resource owning the sink and that match the filter. For example: logName="projects/[PROJECT_ID]/logs/[LOG_ID]" AND severity>=ERROR 
     */
    readonly filter?: pulumi.Input<string>;
    /**
     * Optional. This field applies only to sinks owned by organizations and folders. If the field is false, the default, only the logs owned by the sink's parent resource are available for export. If the field is true, then logs from all the projects, folders, and billing accounts contained in the sink's parent resource are also available for export. Whether a particular log entry from the children is exported depends on the sink's filter expression. For example, if this field is true, then the filter resource.type=gce_instance would export all Compute Engine VM instance log entries from all projects in the sink's parent. To only export entries from certain child projects, filter on the project part of the log name: logName:("projects/test-project1/" OR "projects/test-project2/") AND resource.type=gce_instance 
     */
    readonly includeChildren?: pulumi.Input<boolean>;
    /**
     * Required. The client-assigned sink identifier, unique within the project. Example: "my-syslog-errors-to-pubsub". Sink identifiers are limited to 100 characters and can include only the following characters: upper and lower-case alphanumeric characters, underscores, hyphens, and periods. First character has to be alphanumeric.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * Deprecated. This field is unused.
     */
    readonly outputVersionFormat?: pulumi.Input<string>;
    /**
     * Required. The resource in which to create the sink: "projects/[PROJECT_ID]" "organizations/[ORGANIZATION_ID]" "billingAccounts/[BILLING_ACCOUNT_ID]" "folders/[FOLDER_ID]" Examples: "projects/my-logging-project", "organizations/123456789".
     */
    readonly parent: pulumi.Input<string>;
    /**
     * Optional. Determines the kind of IAM identity returned as writer_identity in the new sink. If this value is omitted or set to false, and if the sink's parent is a project, then the value returned as writer_identity is the same group or service account used by Logging before the addition of writer identities to this API. The sink's destination must be in the same project as the sink itself.If this field is set to true, or if the sink is owned by a non-project resource such as an organization, then the value of writer_identity will be a unique service account used only for exports from the new sink. For more information, see writer_identity in LogSink.
     */
    readonly uniqueWriterIdentity?: pulumi.Input<boolean>;
    /**
     * Output only. The last update timestamp of the sink.This field may not be present for older sinks.
     */
    readonly updateTime?: pulumi.Input<string>;
    /**
     * Output only. An IAM identity—a service account or group—under which Logging writes the exported log entries to the sink's destination. This field is set by sinks.create and sinks.update based on the value of unique_writer_identity in those methods.Until you grant this identity write-access to the destination, log entry exports from this sink will fail. For more information, see Granting Access for a Resource (https://cloud.google.com/iam/docs/granting-roles-to-service-accounts#granting_access_to_a_service_account_for_a_resource). Consult the destination service's documentation to determine the appropriate IAM roles to assign to the identity.
     */
    readonly writerIdentity?: pulumi.Input<string>;
}