// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

/**
 * Starts a build with the specified configuration. This method returns a long-running `Operation`, which includes the build ID. Pass the build ID to `GetBuild` to determine the build status (such as `SUCCESS` or `FAILURE`).
 */
export class Build extends pulumi.CustomResource {
    /**
     * Get an existing Build resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Build {
        return new Build(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'google-cloud:cloudbuild/v1:Build';

    /**
     * Returns true if the given object is an instance of Build.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Build {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Build.__pulumiType;
    }


    /**
     * Create a Build resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: BuildArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.projectId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'projectId'");
            }
            inputs["artifacts"] = args ? args.artifacts : undefined;
            inputs["availableSecrets"] = args ? args.availableSecrets : undefined;
            inputs["buildTriggerId"] = args ? args.buildTriggerId : undefined;
            inputs["createTime"] = args ? args.createTime : undefined;
            inputs["finishTime"] = args ? args.finishTime : undefined;
            inputs["id"] = args ? args.id : undefined;
            inputs["images"] = args ? args.images : undefined;
            inputs["logUrl"] = args ? args.logUrl : undefined;
            inputs["logsBucket"] = args ? args.logsBucket : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["options"] = args ? args.options : undefined;
            inputs["parent"] = args ? args.parent : undefined;
            inputs["projectId"] = args ? args.projectId : undefined;
            inputs["queueTtl"] = args ? args.queueTtl : undefined;
            inputs["results"] = args ? args.results : undefined;
            inputs["secrets"] = args ? args.secrets : undefined;
            inputs["serviceAccount"] = args ? args.serviceAccount : undefined;
            inputs["source"] = args ? args.source : undefined;
            inputs["sourceProvenance"] = args ? args.sourceProvenance : undefined;
            inputs["startTime"] = args ? args.startTime : undefined;
            inputs["status"] = args ? args.status : undefined;
            inputs["statusDetail"] = args ? args.statusDetail : undefined;
            inputs["steps"] = args ? args.steps : undefined;
            inputs["substitutions"] = args ? args.substitutions : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["timeout"] = args ? args.timeout : undefined;
            inputs["timing"] = args ? args.timing : undefined;
        } else {
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(Build.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Build resource.
 */
export interface BuildArgs {
    /**
     * Artifacts produced by the build that should be uploaded upon successful completion of all build steps.
     */
    readonly artifacts?: pulumi.Input<inputs.cloudbuild.v1.Artifacts>;
    /**
     * Secrets and secret environment variables.
     */
    readonly availableSecrets?: pulumi.Input<inputs.cloudbuild.v1.Secrets>;
    /**
     * Output only. The ID of the `BuildTrigger` that triggered this build, if it was triggered automatically.
     */
    readonly buildTriggerId?: pulumi.Input<string>;
    /**
     * Output only. Time at which the request to create the build was received.
     */
    readonly createTime?: pulumi.Input<string>;
    /**
     * Output only. Time at which execution of the build was finished. The difference between finish_time and start_time is the duration of the build's execution.
     */
    readonly finishTime?: pulumi.Input<string>;
    /**
     * Output only. Unique identifier of the build.
     */
    readonly id?: pulumi.Input<string>;
    /**
     * A list of images to be pushed upon the successful completion of all build steps. The images are pushed using the builder service account's credentials. The digests of the pushed images will be stored in the `Build` resource's results field. If any of the images fail to be pushed, the build status is marked `FAILURE`.
     */
    readonly images?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Output only. URL to logs for this build in Google Cloud Console.
     */
    readonly logUrl?: pulumi.Input<string>;
    /**
     * Google Cloud Storage bucket where logs should be written (see [Bucket Name Requirements](https://cloud.google.com/storage/docs/bucket-naming#requirements)). Logs file names will be of the format `${logs_bucket}/log-${build_id}.txt`.
     */
    readonly logsBucket?: pulumi.Input<string>;
    /**
     * Output only. The 'Build' name with format: `projects/{project}/locations/{location}/builds/{build}`, where {build} is a unique identifier generated by the service.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * Special options for this build.
     */
    readonly options?: pulumi.Input<inputs.cloudbuild.v1.BuildOptions>;
    /**
     * The parent resource where this build will be created. Format: `projects/{project}/locations/{location}`
     */
    readonly parent?: pulumi.Input<string>;
    /**
     * Output only. ID of the project.
     */
    readonly projectId: pulumi.Input<string>;
    /**
     * TTL in queue for this build. If provided and the build is enqueued longer than this value, the build will expire and the build status will be `EXPIRED`. The TTL starts ticking from create_time.
     */
    readonly queueTtl?: pulumi.Input<string>;
    /**
     * Output only. Results of the build.
     */
    readonly results?: pulumi.Input<inputs.cloudbuild.v1.Results>;
    /**
     * Secrets to decrypt using Cloud Key Management Service. Note: Secret Manager is the recommended technique for managing sensitive data with Cloud Build. Use `available_secrets` to configure builds to access secrets from Secret Manager. For instructions, see: https://cloud.google.com/cloud-build/docs/securing-builds/use-secrets
     */
    readonly secrets?: pulumi.Input<pulumi.Input<inputs.cloudbuild.v1.Secret>[]>;
    /**
     * IAM service account whose credentials will be used at build runtime. Must be of the format `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`. ACCOUNT can be email address or uniqueId of the service account. This field is in beta.
     */
    readonly serviceAccount?: pulumi.Input<string>;
    /**
     * The location of the source files to build.
     */
    readonly source?: pulumi.Input<inputs.cloudbuild.v1.Source>;
    /**
     * Output only. A permanent fixed identifier for source.
     */
    readonly sourceProvenance?: pulumi.Input<inputs.cloudbuild.v1.SourceProvenance>;
    /**
     * Output only. Time at which execution of the build was started.
     */
    readonly startTime?: pulumi.Input<string>;
    /**
     * Output only. Status of the build.
     */
    readonly status?: pulumi.Input<string>;
    /**
     * Output only. Customer-readable message about the current status.
     */
    readonly statusDetail?: pulumi.Input<string>;
    /**
     * Required. The operations to be performed on the workspace.
     */
    readonly steps?: pulumi.Input<pulumi.Input<inputs.cloudbuild.v1.BuildStep>[]>;
    /**
     * Substitutions data for `Build` resource.
     */
    readonly substitutions?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Tags for annotation of a `Build`. These are not docker tags.
     */
    readonly tags?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Amount of time that this build should be allowed to run, to second granularity. If this amount of time elapses, work on the build will cease and the build status will be `TIMEOUT`. `timeout` starts ticking from `startTime`. Default time is ten minutes.
     */
    readonly timeout?: pulumi.Input<string>;
    /**
     * Output only. Stores timing information for phases of the build. Valid keys are: * BUILD: time to execute all build steps * PUSH: time to push all specified images. * FETCHSOURCE: time to fetch source. If the build does not specify source or images, these keys will not be included.
     */
    readonly timing?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}