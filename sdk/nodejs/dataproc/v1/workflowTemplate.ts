// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

/**
 * Creates new workflow template.
 */
export class WorkflowTemplate extends pulumi.CustomResource {
    /**
     * Get an existing WorkflowTemplate resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): WorkflowTemplate {
        return new WorkflowTemplate(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'google-cloud:dataproc/v1:WorkflowTemplate';

    /**
     * Returns true if the given object is an instance of WorkflowTemplate.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is WorkflowTemplate {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === WorkflowTemplate.__pulumiType;
    }


    /**
     * Create a WorkflowTemplate resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: WorkflowTemplateArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.parent === undefined) && !opts.urn) {
                throw new Error("Missing required property 'parent'");
            }
            inputs["createTime"] = args ? args.createTime : undefined;
            inputs["dagTimeout"] = args ? args.dagTimeout : undefined;
            inputs["id"] = args ? args.id : undefined;
            inputs["jobs"] = args ? args.jobs : undefined;
            inputs["labels"] = args ? args.labels : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["parameters"] = args ? args.parameters : undefined;
            inputs["parent"] = args ? args.parent : undefined;
            inputs["placement"] = args ? args.placement : undefined;
            inputs["updateTime"] = args ? args.updateTime : undefined;
            inputs["version"] = args ? args.version : undefined;
        } else {
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(WorkflowTemplate.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a WorkflowTemplate resource.
 */
export interface WorkflowTemplateArgs {
    /**
     * Output only. The time template was created.
     */
    readonly createTime?: pulumi.Input<string>;
    /**
     * Optional. Timeout duration for the DAG of jobs, expressed in seconds (see JSON representation of duration (https://developers.google.com/protocol-buffers/docs/proto3#json)). The timeout duration must be from 10 minutes ("600s") to 24 hours ("86400s"). The timer begins when the first job is submitted. If the workflow is running at the end of the timeout period, any remaining jobs are cancelled, the workflow is ended, and if the workflow was running on a managed cluster, the cluster is deleted.
     */
    readonly dagTimeout?: pulumi.Input<string>;
    readonly id?: pulumi.Input<string>;
    /**
     * Required. The Directed Acyclic Graph of Jobs to submit.
     */
    readonly jobs?: pulumi.Input<pulumi.Input<inputs.dataproc.v1.OrderedJob>[]>;
    /**
     * Optional. The labels to associate with this template. These labels will be propagated to all jobs and clusters created by the workflow instance.Label keys must contain 1 to 63 characters, and must conform to RFC 1035 (https://www.ietf.org/rfc/rfc1035.txt).Label values may be empty, but, if present, must contain 1 to 63 characters, and must conform to RFC 1035 (https://www.ietf.org/rfc/rfc1035.txt).No more than 32 labels can be associated with a template.
     */
    readonly labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Output only. The resource name of the workflow template, as described in https://cloud.google.com/apis/design/resource_names. For projects.regions.workflowTemplates, the resource name of the template has the following format: projects/{project_id}/regions/{region}/workflowTemplates/{template_id} For projects.locations.workflowTemplates, the resource name of the template has the following format: projects/{project_id}/locations/{location}/workflowTemplates/{template_id}
     */
    readonly name?: pulumi.Input<string>;
    /**
     * Optional. Template parameters whose values are substituted into the template. Values for parameters must be provided when the template is instantiated.
     */
    readonly parameters?: pulumi.Input<pulumi.Input<inputs.dataproc.v1.TemplateParameter>[]>;
    /**
     * Required. The resource name of the region or location, as described in https://cloud.google.com/apis/design/resource_names. For projects.regions.workflowTemplates,create, the resource name of the region has the following format: projects/{project_id}/regions/{region} For projects.locations.workflowTemplates.create, the resource name of the location has the following format: projects/{project_id}/locations/{location}
     */
    readonly parent: pulumi.Input<string>;
    /**
     * Required. WorkflowTemplate scheduling information.
     */
    readonly placement?: pulumi.Input<inputs.dataproc.v1.WorkflowTemplatePlacement>;
    /**
     * Output only. The time template was last updated.
     */
    readonly updateTime?: pulumi.Input<string>;
    /**
     * Optional. Used to perform a consistent read-modify-write.This field should be left blank for a CreateWorkflowTemplate request. It is required for an UpdateWorkflowTemplate request, and must match the current server version. A typical update template flow would fetch the current template with a GetWorkflowTemplate request, which will return the current template with the version field filled in with the current server version. The user updates other fields in the template, then returns it as part of the UpdateWorkflowTemplate request.
     */
    readonly version?: pulumi.Input<number>;
}