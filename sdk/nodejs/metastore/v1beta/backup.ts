// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

/**
 * Creates a new backup in a given project and location.
 */
export class Backup extends pulumi.CustomResource {
    /**
     * Get an existing Backup resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Backup {
        return new Backup(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'google-native:metastore/v1beta:Backup';

    /**
     * Returns true if the given object is an instance of Backup.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Backup {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Backup.__pulumiType;
    }

    /**
     * The time when the backup was started.
     */
    public /*out*/ readonly createTime!: pulumi.Output<string>;
    /**
     * The description of the backup.
     */
    public readonly description!: pulumi.Output<string>;
    /**
     * The time when the backup finished creating.
     */
    public /*out*/ readonly endTime!: pulumi.Output<string>;
    /**
     * Immutable. The relative resource name of the backup, in the following form:projects/{project_number}/locations/{location_id}/services/{service_id}/backups/{backup_id}
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * The revision of the service at the time of backup.
     */
    public /*out*/ readonly serviceRevision!: pulumi.Output<outputs.metastore.v1beta.ServiceResponse>;
    /**
     * The current state of the backup.
     */
    public /*out*/ readonly state!: pulumi.Output<string>;

    /**
     * Create a Backup resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: BackupArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.backupId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'backupId'");
            }
            if ((!args || args.location === undefined) && !opts.urn) {
                throw new Error("Missing required property 'location'");
            }
            if ((!args || args.project === undefined) && !opts.urn) {
                throw new Error("Missing required property 'project'");
            }
            if ((!args || args.serviceId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'serviceId'");
            }
            inputs["backupId"] = args ? args.backupId : undefined;
            inputs["description"] = args ? args.description : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["project"] = args ? args.project : undefined;
            inputs["requestId"] = args ? args.requestId : undefined;
            inputs["serviceId"] = args ? args.serviceId : undefined;
            inputs["createTime"] = undefined /*out*/;
            inputs["endTime"] = undefined /*out*/;
            inputs["serviceRevision"] = undefined /*out*/;
            inputs["state"] = undefined /*out*/;
        } else {
            inputs["createTime"] = undefined /*out*/;
            inputs["description"] = undefined /*out*/;
            inputs["endTime"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["serviceRevision"] = undefined /*out*/;
            inputs["state"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(Backup.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Backup resource.
 */
export interface BackupArgs {
    backupId: pulumi.Input<string>;
    /**
     * The description of the backup.
     */
    description?: pulumi.Input<string>;
    location: pulumi.Input<string>;
    /**
     * Immutable. The relative resource name of the backup, in the following form:projects/{project_number}/locations/{location_id}/services/{service_id}/backups/{backup_id}
     */
    name?: pulumi.Input<string>;
    project: pulumi.Input<string>;
    requestId?: pulumi.Input<string>;
    serviceId: pulumi.Input<string>;
}