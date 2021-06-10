// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

/**
 * Creates a new Cloud Spanner database and starts to prepare it for serving. The returned long-running operation will have a name of the format `/operations/` and can be used to track preparation of the database. The metadata field type is CreateDatabaseMetadata. The response field type is Database, if successful.
 */
export class Database extends pulumi.CustomResource {
    /**
     * Get an existing Database resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Database {
        return new Database(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'google-native:spanner/v1:Database';

    /**
     * Returns true if the given object is an instance of Database.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Database {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Database.__pulumiType;
    }

    /**
     * If exists, the time at which the database creation started.
     */
    public /*out*/ readonly createTime!: pulumi.Output<string>;
    /**
     * Earliest timestamp at which older versions of the data can be read. This value is continuously updated by Cloud Spanner and becomes stale the moment it is queried. If you are using this value to recover data, make sure to account for the time from the moment when the value is queried to the moment when you initiate the recovery.
     */
    public /*out*/ readonly earliestVersionTime!: pulumi.Output<string>;
    /**
     * For databases that are using customer managed encryption, this field contains the encryption configuration for the database. For databases that are using Google default or other types of encryption, this field is empty.
     */
    public readonly encryptionConfig!: pulumi.Output<outputs.spanner.v1.EncryptionConfigResponse>;
    /**
     * For databases that are using customer managed encryption, this field contains the encryption information for the database, such as encryption state and the Cloud KMS key versions that are in use. For databases that are using Google default or other types of encryption, this field is empty. This field is propagated lazily from the backend. There might be a delay from when a key version is being used and when it appears in this field.
     */
    public /*out*/ readonly encryptionInfo!: pulumi.Output<outputs.spanner.v1.EncryptionInfoResponse[]>;
    /**
     * Required. The name of the database. Values are of the form `projects//instances//databases/`, where `` is as specified in the `CREATE DATABASE` statement. This name can be passed to other API methods to identify the database.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * Applicable only for restored databases. Contains information about the restore source.
     */
    public /*out*/ readonly restoreInfo!: pulumi.Output<outputs.spanner.v1.RestoreInfoResponse>;
    /**
     * The current database state.
     */
    public /*out*/ readonly state!: pulumi.Output<string>;
    /**
     * The period in which Cloud Spanner retains all versions of data for the database. This is the same as the value of version_retention_period database option set using UpdateDatabaseDdl. Defaults to 1 hour, if not set.
     */
    public /*out*/ readonly versionRetentionPeriod!: pulumi.Output<string>;

    /**
     * Create a Database resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: DatabaseArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.instanceId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'instanceId'");
            }
            if ((!args || args.project === undefined) && !opts.urn) {
                throw new Error("Missing required property 'project'");
            }
            inputs["createStatement"] = args ? args.createStatement : undefined;
            inputs["encryptionConfig"] = args ? args.encryptionConfig : undefined;
            inputs["extraStatements"] = args ? args.extraStatements : undefined;
            inputs["instanceId"] = args ? args.instanceId : undefined;
            inputs["project"] = args ? args.project : undefined;
            inputs["createTime"] = undefined /*out*/;
            inputs["earliestVersionTime"] = undefined /*out*/;
            inputs["encryptionInfo"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["restoreInfo"] = undefined /*out*/;
            inputs["state"] = undefined /*out*/;
            inputs["versionRetentionPeriod"] = undefined /*out*/;
        } else {
            inputs["createTime"] = undefined /*out*/;
            inputs["earliestVersionTime"] = undefined /*out*/;
            inputs["encryptionConfig"] = undefined /*out*/;
            inputs["encryptionInfo"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["restoreInfo"] = undefined /*out*/;
            inputs["state"] = undefined /*out*/;
            inputs["versionRetentionPeriod"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(Database.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Database resource.
 */
export interface DatabaseArgs {
    /**
     * Required. A `CREATE DATABASE` statement, which specifies the ID of the new database. The database ID must conform to the regular expression `a-z*[a-z0-9]` and be between 2 and 30 characters in length. If the database ID is a reserved word or if it contains a hyphen, the database ID must be enclosed in backticks (`` ` ``).
     */
    createStatement?: pulumi.Input<string>;
    /**
     * Optional. The encryption configuration for the database. If this field is not specified, Cloud Spanner will encrypt/decrypt all data at rest using Google default encryption.
     */
    encryptionConfig?: pulumi.Input<inputs.spanner.v1.EncryptionConfigArgs>;
    /**
     * Optional. A list of DDL statements to run inside the newly created database. Statements can create tables, indexes, etc. These statements execute atomically with the creation of the database: if there is an error in any statement, the database is not created.
     */
    extraStatements?: pulumi.Input<pulumi.Input<string>[]>;
    instanceId: pulumi.Input<string>;
    project: pulumi.Input<string>;
}