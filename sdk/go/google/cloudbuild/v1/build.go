// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Starts a build with the specified configuration. This method returns a long-running `Operation`, which includes the build ID. Pass the build ID to `GetBuild` to determine the build status (such as `SUCCESS` or `FAILURE`).
type Build struct {
	pulumi.CustomResourceState
}

// NewBuild registers a new resource with the given unique name, arguments, and options.
func NewBuild(ctx *pulumi.Context,
	name string, args *BuildArgs, opts ...pulumi.ResourceOption) (*Build, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ProjectId == nil {
		return nil, errors.New("invalid value for required argument 'ProjectId'")
	}
	var resource Build
	err := ctx.RegisterResource("google-cloud:cloudbuild/v1:Build", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetBuild gets an existing Build resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetBuild(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *BuildState, opts ...pulumi.ResourceOption) (*Build, error) {
	var resource Build
	err := ctx.ReadResource("google-cloud:cloudbuild/v1:Build", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Build resources.
type buildState struct {
}

type BuildState struct {
}

func (BuildState) ElementType() reflect.Type {
	return reflect.TypeOf((*buildState)(nil)).Elem()
}

type buildArgs struct {
	// Artifacts produced by the build that should be uploaded upon successful completion of all build steps.
	Artifacts *Artifacts `pulumi:"artifacts"`
	// Secrets and secret environment variables.
	AvailableSecrets *Secrets `pulumi:"availableSecrets"`
	// Output only. The ID of the `BuildTrigger` that triggered this build, if it was triggered automatically.
	BuildTriggerId *string `pulumi:"buildTriggerId"`
	// Output only. Time at which the request to create the build was received.
	CreateTime *string `pulumi:"createTime"`
	// Output only. Time at which execution of the build was finished. The difference between finish_time and start_time is the duration of the build's execution.
	FinishTime *string `pulumi:"finishTime"`
	// Output only. Unique identifier of the build.
	Id *string `pulumi:"id"`
	// A list of images to be pushed upon the successful completion of all build steps. The images are pushed using the builder service account's credentials. The digests of the pushed images will be stored in the `Build` resource's results field. If any of the images fail to be pushed, the build status is marked `FAILURE`.
	Images []string `pulumi:"images"`
	// Output only. URL to logs for this build in Google Cloud Console.
	LogUrl *string `pulumi:"logUrl"`
	// Google Cloud Storage bucket where logs should be written (see [Bucket Name Requirements](https://cloud.google.com/storage/docs/bucket-naming#requirements)). Logs file names will be of the format `${logs_bucket}/log-${build_id}.txt`.
	LogsBucket *string `pulumi:"logsBucket"`
	// Output only. The 'Build' name with format: `projects/{project}/locations/{location}/builds/{build}`, where {build} is a unique identifier generated by the service.
	Name *string `pulumi:"name"`
	// Special options for this build.
	Options *BuildOptions `pulumi:"options"`
	// The parent resource where this build will be created. Format: `projects/{project}/locations/{location}`
	Parent *string `pulumi:"parent"`
	// Output only. ID of the project.
	ProjectId string `pulumi:"projectId"`
	// TTL in queue for this build. If provided and the build is enqueued longer than this value, the build will expire and the build status will be `EXPIRED`. The TTL starts ticking from create_time.
	QueueTtl *string `pulumi:"queueTtl"`
	// Output only. Results of the build.
	Results *Results `pulumi:"results"`
	// Secrets to decrypt using Cloud Key Management Service. Note: Secret Manager is the recommended technique for managing sensitive data with Cloud Build. Use `available_secrets` to configure builds to access secrets from Secret Manager. For instructions, see: https://cloud.google.com/cloud-build/docs/securing-builds/use-secrets
	Secrets []Secret `pulumi:"secrets"`
	// IAM service account whose credentials will be used at build runtime. Must be of the format `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`. ACCOUNT can be email address or uniqueId of the service account. This field is in beta.
	ServiceAccount *string `pulumi:"serviceAccount"`
	// The location of the source files to build.
	Source *Source `pulumi:"source"`
	// Output only. A permanent fixed identifier for source.
	SourceProvenance *SourceProvenance `pulumi:"sourceProvenance"`
	// Output only. Time at which execution of the build was started.
	StartTime *string `pulumi:"startTime"`
	// Output only. Status of the build.
	Status *string `pulumi:"status"`
	// Output only. Customer-readable message about the current status.
	StatusDetail *string `pulumi:"statusDetail"`
	// Required. The operations to be performed on the workspace.
	Steps []BuildStep `pulumi:"steps"`
	// Substitutions data for `Build` resource.
	Substitutions map[string]string `pulumi:"substitutions"`
	// Tags for annotation of a `Build`. These are not docker tags.
	Tags []string `pulumi:"tags"`
	// Amount of time that this build should be allowed to run, to second granularity. If this amount of time elapses, work on the build will cease and the build status will be `TIMEOUT`. `timeout` starts ticking from `startTime`. Default time is ten minutes.
	Timeout *string `pulumi:"timeout"`
	// Output only. Stores timing information for phases of the build. Valid keys are: * BUILD: time to execute all build steps * PUSH: time to push all specified images. * FETCHSOURCE: time to fetch source. If the build does not specify source or images, these keys will not be included.
	Timing map[string]string `pulumi:"timing"`
}

// The set of arguments for constructing a Build resource.
type BuildArgs struct {
	// Artifacts produced by the build that should be uploaded upon successful completion of all build steps.
	Artifacts ArtifactsPtrInput
	// Secrets and secret environment variables.
	AvailableSecrets SecretsPtrInput
	// Output only. The ID of the `BuildTrigger` that triggered this build, if it was triggered automatically.
	BuildTriggerId pulumi.StringPtrInput
	// Output only. Time at which the request to create the build was received.
	CreateTime pulumi.StringPtrInput
	// Output only. Time at which execution of the build was finished. The difference between finish_time and start_time is the duration of the build's execution.
	FinishTime pulumi.StringPtrInput
	// Output only. Unique identifier of the build.
	Id pulumi.StringPtrInput
	// A list of images to be pushed upon the successful completion of all build steps. The images are pushed using the builder service account's credentials. The digests of the pushed images will be stored in the `Build` resource's results field. If any of the images fail to be pushed, the build status is marked `FAILURE`.
	Images pulumi.StringArrayInput
	// Output only. URL to logs for this build in Google Cloud Console.
	LogUrl pulumi.StringPtrInput
	// Google Cloud Storage bucket where logs should be written (see [Bucket Name Requirements](https://cloud.google.com/storage/docs/bucket-naming#requirements)). Logs file names will be of the format `${logs_bucket}/log-${build_id}.txt`.
	LogsBucket pulumi.StringPtrInput
	// Output only. The 'Build' name with format: `projects/{project}/locations/{location}/builds/{build}`, where {build} is a unique identifier generated by the service.
	Name pulumi.StringPtrInput
	// Special options for this build.
	Options BuildOptionsPtrInput
	// The parent resource where this build will be created. Format: `projects/{project}/locations/{location}`
	Parent pulumi.StringPtrInput
	// Output only. ID of the project.
	ProjectId pulumi.StringInput
	// TTL in queue for this build. If provided and the build is enqueued longer than this value, the build will expire and the build status will be `EXPIRED`. The TTL starts ticking from create_time.
	QueueTtl pulumi.StringPtrInput
	// Output only. Results of the build.
	Results ResultsPtrInput
	// Secrets to decrypt using Cloud Key Management Service. Note: Secret Manager is the recommended technique for managing sensitive data with Cloud Build. Use `available_secrets` to configure builds to access secrets from Secret Manager. For instructions, see: https://cloud.google.com/cloud-build/docs/securing-builds/use-secrets
	Secrets SecretArrayInput
	// IAM service account whose credentials will be used at build runtime. Must be of the format `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`. ACCOUNT can be email address or uniqueId of the service account. This field is in beta.
	ServiceAccount pulumi.StringPtrInput
	// The location of the source files to build.
	Source SourcePtrInput
	// Output only. A permanent fixed identifier for source.
	SourceProvenance SourceProvenancePtrInput
	// Output only. Time at which execution of the build was started.
	StartTime pulumi.StringPtrInput
	// Output only. Status of the build.
	Status pulumi.StringPtrInput
	// Output only. Customer-readable message about the current status.
	StatusDetail pulumi.StringPtrInput
	// Required. The operations to be performed on the workspace.
	Steps BuildStepArrayInput
	// Substitutions data for `Build` resource.
	Substitutions pulumi.StringMapInput
	// Tags for annotation of a `Build`. These are not docker tags.
	Tags pulumi.StringArrayInput
	// Amount of time that this build should be allowed to run, to second granularity. If this amount of time elapses, work on the build will cease and the build status will be `TIMEOUT`. `timeout` starts ticking from `startTime`. Default time is ten minutes.
	Timeout pulumi.StringPtrInput
	// Output only. Stores timing information for phases of the build. Valid keys are: * BUILD: time to execute all build steps * PUSH: time to push all specified images. * FETCHSOURCE: time to fetch source. If the build does not specify source or images, these keys will not be included.
	Timing pulumi.StringMapInput
}

func (BuildArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*buildArgs)(nil)).Elem()
}

type BuildInput interface {
	pulumi.Input

	ToBuildOutput() BuildOutput
	ToBuildOutputWithContext(ctx context.Context) BuildOutput
}

func (*Build) ElementType() reflect.Type {
	return reflect.TypeOf((*Build)(nil))
}

func (i *Build) ToBuildOutput() BuildOutput {
	return i.ToBuildOutputWithContext(context.Background())
}

func (i *Build) ToBuildOutputWithContext(ctx context.Context) BuildOutput {
	return pulumi.ToOutputWithContext(ctx, i).(BuildOutput)
}

type BuildOutput struct {
	*pulumi.OutputState
}

func (BuildOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Build)(nil))
}

func (o BuildOutput) ToBuildOutput() BuildOutput {
	return o
}

func (o BuildOutput) ToBuildOutputWithContext(ctx context.Context) BuildOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(BuildOutput{})
}