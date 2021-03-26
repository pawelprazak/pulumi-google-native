// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

/**
 * Creates a new connection.
 */
export class Connection extends pulumi.CustomResource {
    /**
     * Get an existing Connection resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Connection {
        return new Connection(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'google-cloud:bigqueryconnection/v1beta1:Connection';

    /**
     * Returns true if the given object is an instance of Connection.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Connection {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Connection.__pulumiType;
    }


    /**
     * Create a Connection resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ConnectionArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.parent === undefined) && !opts.urn) {
                throw new Error("Missing required property 'parent'");
            }
            inputs["cloudSql"] = args ? args.cloudSql : undefined;
            inputs["connectionId"] = args ? args.connectionId : undefined;
            inputs["creationTime"] = args ? args.creationTime : undefined;
            inputs["description"] = args ? args.description : undefined;
            inputs["friendlyName"] = args ? args.friendlyName : undefined;
            inputs["hasCredential"] = args ? args.hasCredential : undefined;
            inputs["lastModifiedTime"] = args ? args.lastModifiedTime : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["parent"] = args ? args.parent : undefined;
        } else {
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(Connection.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Connection resource.
 */
export interface ConnectionArgs {
    /**
     * Cloud SQL properties.
     */
    readonly cloudSql?: pulumi.Input<inputs.bigqueryconnection.v1beta1.CloudSqlProperties>;
    /**
     * Optional. Connection id that should be assigned to the created connection.
     */
    readonly connectionId?: pulumi.Input<string>;
    /**
     * Output only. The creation timestamp of the connection.
     */
    readonly creationTime?: pulumi.Input<string>;
    /**
     * User provided description.
     */
    readonly description?: pulumi.Input<string>;
    /**
     * User provided display name for the connection.
     */
    readonly friendlyName?: pulumi.Input<string>;
    /**
     * Output only. True, if credential is configured for this connection.
     */
    readonly hasCredential?: pulumi.Input<boolean>;
    /**
     * Output only. The last update timestamp of the connection.
     */
    readonly lastModifiedTime?: pulumi.Input<string>;
    /**
     * The resource name of the connection in the form of: `projects/{project_id}/locations/{location_id}/connections/{connection_id}`
     */
    readonly name?: pulumi.Input<string>;
    /**
     * Required. Parent resource name. Must be in the format `projects/{project_id}/locations/{location_id}`
     */
    readonly parent: pulumi.Input<string>;
}