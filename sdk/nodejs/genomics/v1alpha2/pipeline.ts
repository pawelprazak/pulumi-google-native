// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

/**
 * Creates a pipeline that can be run later. Create takes a Pipeline that has all fields other than `pipelineId` populated, and then returns the same pipeline with `pipelineId` populated. This id can be used to run the pipeline. Caller must have WRITE permission to the project.
 */
export class Pipeline extends pulumi.CustomResource {
    /**
     * Get an existing Pipeline resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Pipeline {
        return new Pipeline(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'google-cloud:genomics/v1alpha2:Pipeline';

    /**
     * Returns true if the given object is an instance of Pipeline.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Pipeline {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Pipeline.__pulumiType;
    }


    /**
     * Create a Pipeline resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: PipelineArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            inputs["description"] = args ? args.description : undefined;
            inputs["docker"] = args ? args.docker : undefined;
            inputs["inputParameters"] = args ? args.inputParameters : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["outputParameters"] = args ? args.outputParameters : undefined;
            inputs["pipelineId"] = args ? args.pipelineId : undefined;
            inputs["projectId"] = args ? args.projectId : undefined;
            inputs["resources"] = args ? args.resources : undefined;
        } else {
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(Pipeline.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Pipeline resource.
 */
export interface PipelineArgs {
    /**
     * User-specified description.
     */
    readonly description?: pulumi.Input<string>;
    /**
     * Specifies the docker run information.
     */
    readonly docker?: pulumi.Input<inputs.genomics.v1alpha2.DockerExecutor>;
    /**
     * Input parameters of the pipeline.
     */
    readonly inputParameters?: pulumi.Input<pulumi.Input<inputs.genomics.v1alpha2.PipelineParameter>[]>;
    /**
     * Required. A user specified pipeline name that does not have to be unique. This name can be used for filtering Pipelines in ListPipelines.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * Output parameters of the pipeline.
     */
    readonly outputParameters?: pulumi.Input<pulumi.Input<inputs.genomics.v1alpha2.PipelineParameter>[]>;
    /**
     * Unique pipeline id that is generated by the service when CreatePipeline is called. Cannot be specified in the Pipeline used in the CreatePipelineRequest, and will be populated in the response to CreatePipeline and all subsequent Get and List calls. Indicates that the service has registered this pipeline.
     */
    readonly pipelineId?: pulumi.Input<string>;
    /**
     * Required. The project in which to create the pipeline. The caller must have WRITE access.
     */
    readonly projectId?: pulumi.Input<string>;
    /**
     * Required. Specifies resource requirements for the pipeline run. Required fields: * minimumCpuCores * minimumRamGb
     */
    readonly resources?: pulumi.Input<inputs.genomics.v1alpha2.PipelineResources>;
}