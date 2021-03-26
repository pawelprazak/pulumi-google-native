// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

/**
 * Creates a new workflow. If a workflow with the specified name already exists in the specified project and location, the long running operation will return ALREADY_EXISTS error.
 */
export class Workflow extends pulumi.CustomResource {
    /**
     * Get an existing Workflow resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Workflow {
        return new Workflow(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'google-cloud:workflows/v1beta:Workflow';

    /**
     * Returns true if the given object is an instance of Workflow.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Workflow {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Workflow.__pulumiType;
    }


    /**
     * Create a Workflow resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: WorkflowArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.parent === undefined) && !opts.urn) {
                throw new Error("Missing required property 'parent'");
            }
            inputs["createTime"] = args ? args.createTime : undefined;
            inputs["description"] = args ? args.description : undefined;
            inputs["labels"] = args ? args.labels : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["parent"] = args ? args.parent : undefined;
            inputs["revisionCreateTime"] = args ? args.revisionCreateTime : undefined;
            inputs["revisionId"] = args ? args.revisionId : undefined;
            inputs["serviceAccount"] = args ? args.serviceAccount : undefined;
            inputs["sourceContents"] = args ? args.sourceContents : undefined;
            inputs["state"] = args ? args.state : undefined;
            inputs["updateTime"] = args ? args.updateTime : undefined;
            inputs["workflowId"] = args ? args.workflowId : undefined;
        } else {
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(Workflow.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Workflow resource.
 */
export interface WorkflowArgs {
    /**
     * Output only. The timestamp of when the workflow was created.
     */
    readonly createTime?: pulumi.Input<string>;
    /**
     * Description of the workflow provided by the user. Must be at most 1000 unicode characters long.
     */
    readonly description?: pulumi.Input<string>;
    /**
     * Labels associated with this workflow. Labels can contain at most 64 entries. Keys and values can be no longer than 63 characters and can only contain lowercase letters, numeric characters, underscores and dashes. Label keys must start with a letter. International characters are allowed.
     */
    readonly labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * The resource name of the workflow. Format: projects/{project}/locations/{location}/workflows/{workflow}
     */
    readonly name?: pulumi.Input<string>;
    /**
     * Required. Project and location in which the workflow should be created. Format: projects/{project}/locations/{location}
     */
    readonly parent: pulumi.Input<string>;
    /**
     * Output only. The timestamp that the latest revision of the workflow was created.
     */
    readonly revisionCreateTime?: pulumi.Input<string>;
    /**
     * Output only. The revision of the workflow. A new revision of a workflow is created as a result of updating the following properties of a workflow: - Service account - Workflow code to be executed The format is "000001-a4d", where the first 6 characters define the zero-padded revision ordinal number. They are followed by a hyphen and 3 hexadecimal random characters.
     */
    readonly revisionId?: pulumi.Input<string>;
    /**
     * Name of the service account associated with the latest workflow version. This service account represents the identity of the workflow and determines what permissions the workflow has. Format: projects/{project}/serviceAccounts/{account} Using `-` as a wildcard for the `{project}` will infer the project from the account. The `{account}` value can be the `email` address or the `unique_id` of the service account. If not provided, workflow will use the project's default service account. Modifying this field for an existing workflow results in a new workflow revision.
     */
    readonly serviceAccount?: pulumi.Input<string>;
    /**
     * Workflow code to be executed. The size limit is 128KB.
     */
    readonly sourceContents?: pulumi.Input<string>;
    /**
     * Output only. State of the workflow deployment.
     */
    readonly state?: pulumi.Input<string>;
    /**
     * Output only. The last update timestamp of the workflow.
     */
    readonly updateTime?: pulumi.Input<string>;
    /**
     * Required. The ID of the workflow to be created. It has to fulfill the following requirements: * Must contain only letters, numbers, underscores and hyphens. * Must start with a letter. * Must be between 1-64 characters. * Must end with a number or a letter. * Must be unique within the customer project and location.
     */
    readonly workflowId?: pulumi.Input<string>;
}