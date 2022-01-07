// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v2

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Gets information about a Service.
func LookupService(ctx *pulumi.Context, args *LookupServiceArgs, opts ...pulumi.InvokeOption) (*LookupServiceResult, error) {
	var rv LookupServiceResult
	err := ctx.Invoke("google-native:run/v2:getService", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupServiceArgs struct {
	Location  string  `pulumi:"location"`
	Project   *string `pulumi:"project"`
	ServiceId string  `pulumi:"serviceId"`
}

type LookupServiceResult struct {
	// Unstructured key value map that may be set by external tools to store and arbitrary metadata. They are not queryable and should be preserved when modifying objects. Cloud Run will populate some annotations using 'run.googleapis.com' or 'serving.knative.dev' namespaces. This field follows Kubernetes annotations' namespacing, limits, and rules. More info: http://kubernetes.io/docs/user-guide/annotations
	Annotations map[string]string `pulumi:"annotations"`
	// Settings for the Binary Authorization feature.
	BinaryAuthorization GoogleCloudRunOpV2BinaryAuthorizationResponse `pulumi:"binaryAuthorization"`
	// Arbitrary identifier for the API client.
	Client string `pulumi:"client"`
	// Arbitrary version identifier for the API client.
	ClientVersion string `pulumi:"clientVersion"`
	// The Conditions of all other associated sub-resources. They contain additional diagnostics information in case the Service does not reach its Serving state. See comments in `reconciling` for additional information on reconciliation process in Cloud Run.
	Conditions []GoogleCloudRunOpV2ConditionResponse `pulumi:"conditions"`
	// The creation time.
	CreateTime string `pulumi:"createTime"`
	// Email address of the authenticated creator.
	Creator string `pulumi:"creator"`
	// The deletion time.
	DeleteTime string `pulumi:"deleteTime"`
	// User-provided description of the Service.
	Description string `pulumi:"description"`
	// A system-generated fingerprint for this version of the resource. May be used to detect modification conflict during updates.
	Etag string `pulumi:"etag"`
	// For a deleted resource, the time after which it will be permamently deleted.
	ExpireTime string `pulumi:"expireTime"`
	// A number that monotonically increases every time the user modifies the desired state.
	Generation string `pulumi:"generation"`
	// Provides the ingress settings for this Service. On output, returns the currently observed ingress settings, or INGRESS_TRAFFIC_UNSPECIFIED if no revision is active.
	Ingress string `pulumi:"ingress"`
	// Map of string keys and values that can be used to organize and categorize objects. User-provided labels are shared with Google's billing system, so they can be used to filter, or break down billing charges by team, component, environment, state, etc. For more information, visit https://cloud.google.com/resource-manager/docs/creating-managing-labels or https://cloud.google.com/run/docs/configuring/labels Cloud Run will populate some labels with 'run.googleapis.com' or 'serving.knative.dev' namespaces. Those labels are read-only, and user changes will not be preserved.
	Labels map[string]string `pulumi:"labels"`
	// Email address of the last authenticated modifier.
	LastModifier string `pulumi:"lastModifier"`
	// Name of the last created revision. See comments in `reconciling` for additional information on reconciliation process in Cloud Run.
	LatestCreatedRevision string `pulumi:"latestCreatedRevision"`
	// Name of the latest revision that is serving traffic. See comments in `reconciling` for additional information on reconciliation process in Cloud Run.
	LatestReadyRevision string `pulumi:"latestReadyRevision"`
	// The launch stage as defined by [Google Cloud Platform Launch Stages](http://cloud.google.com/terms/launch-stages). Cloud Run supports `ALPHA`, `BETA`, and `GA`. If no value is specified, GA is assumed.
	LaunchStage string `pulumi:"launchStage"`
	// The fully qualified name of this Service. In CreateServiceRequest, this field is ignored, and instead composed from CreateServiceRequest.parent and CreateServiceRequest.service_id. Format: projects/{project}/locations/{location}/services/{service_id}
	Name string `pulumi:"name"`
	// The generation of this Service currently serving traffic. See comments in `reconciling` for additional information on reconciliation process in Cloud Run.
	ObservedGeneration string `pulumi:"observedGeneration"`
	// Returns true if the Service is currently being acted upon by the system to bring it into the desired state. When a new Service is created, or an existing one is updated, Cloud Run will asynchronously perform all necessary steps to bring the Service to the desired serving state. This process is called reconciliation. While reconciliation is in process, `observed_generation`, `latest_ready_revison`, `traffic_statuses`, and `uri` will have transient values that might mismatch the intended state: Once reconciliation is over (and this field is false), there are two possible outcomes: reconciliation succeeded and the serving state matches the Service, or there was an error, and reconciliation failed. This state can be found in `terminal_condition.state`. If reconciliation succeeded, the following fields will match: `traffic` and `traffic_statuses`, `observed_generation` and `generation`, `latest_ready_revision` and `latest_created_revision`. If reconciliation failed, `traffic_statuses`, `observed_generation`, and `latest_ready_revision` will have the state of the last serving revision, or empty for newly created Services. Additional information on the failure can be found in `terminal_condition` and `conditions`.
	Reconciling bool `pulumi:"reconciling"`
	// The template used to create revisions for this Service.
	Template GoogleCloudRunOpV2RevisionTemplateResponse `pulumi:"template"`
	// The Condition of this Service, containing its readiness status, and detailed error information in case it did not reach a serving state. See comments in `reconciling` for additional information on reconciliation process in Cloud Run.
	TerminalCondition GoogleCloudRunOpV2ConditionResponse `pulumi:"terminalCondition"`
	// Specifies how to distribute traffic over a collection of Revisions belonging to the Service. If traffic is empty or not provided, defaults to 100% traffic to the latest `Ready` Revision.
	Traffic []GoogleCloudRunOpV2TrafficTargetResponse `pulumi:"traffic"`
	// Detailed status information for corresponding traffic targets. See comments in `reconciling` for additional information on reconciliation process in Cloud Run.
	TrafficStatuses []GoogleCloudRunOpV2TrafficTargetStatusResponse `pulumi:"trafficStatuses"`
	// Server assigned unique identifier for the trigger. The value is a UUID4 string and guaranteed to remain unchanged until the resource is deleted.
	Uid string `pulumi:"uid"`
	// The last-modified time.
	UpdateTime string `pulumi:"updateTime"`
	// The main URI in which this Service is serving traffic.
	Uri string `pulumi:"uri"`
}

func LookupServiceOutput(ctx *pulumi.Context, args LookupServiceOutputArgs, opts ...pulumi.InvokeOption) LookupServiceResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupServiceResult, error) {
			args := v.(LookupServiceArgs)
			r, err := LookupService(ctx, &args, opts...)
			return *r, err
		}).(LookupServiceResultOutput)
}

type LookupServiceOutputArgs struct {
	Location  pulumi.StringInput    `pulumi:"location"`
	Project   pulumi.StringPtrInput `pulumi:"project"`
	ServiceId pulumi.StringInput    `pulumi:"serviceId"`
}

func (LookupServiceOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupServiceArgs)(nil)).Elem()
}

type LookupServiceResultOutput struct{ *pulumi.OutputState }

func (LookupServiceResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupServiceResult)(nil)).Elem()
}

func (o LookupServiceResultOutput) ToLookupServiceResultOutput() LookupServiceResultOutput {
	return o
}

func (o LookupServiceResultOutput) ToLookupServiceResultOutputWithContext(ctx context.Context) LookupServiceResultOutput {
	return o
}

// Unstructured key value map that may be set by external tools to store and arbitrary metadata. They are not queryable and should be preserved when modifying objects. Cloud Run will populate some annotations using 'run.googleapis.com' or 'serving.knative.dev' namespaces. This field follows Kubernetes annotations' namespacing, limits, and rules. More info: http://kubernetes.io/docs/user-guide/annotations
func (o LookupServiceResultOutput) Annotations() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupServiceResult) map[string]string { return v.Annotations }).(pulumi.StringMapOutput)
}

// Settings for the Binary Authorization feature.
func (o LookupServiceResultOutput) BinaryAuthorization() GoogleCloudRunOpV2BinaryAuthorizationResponseOutput {
	return o.ApplyT(func(v LookupServiceResult) GoogleCloudRunOpV2BinaryAuthorizationResponse {
		return v.BinaryAuthorization
	}).(GoogleCloudRunOpV2BinaryAuthorizationResponseOutput)
}

// Arbitrary identifier for the API client.
func (o LookupServiceResultOutput) Client() pulumi.StringOutput {
	return o.ApplyT(func(v LookupServiceResult) string { return v.Client }).(pulumi.StringOutput)
}

// Arbitrary version identifier for the API client.
func (o LookupServiceResultOutput) ClientVersion() pulumi.StringOutput {
	return o.ApplyT(func(v LookupServiceResult) string { return v.ClientVersion }).(pulumi.StringOutput)
}

// The Conditions of all other associated sub-resources. They contain additional diagnostics information in case the Service does not reach its Serving state. See comments in `reconciling` for additional information on reconciliation process in Cloud Run.
func (o LookupServiceResultOutput) Conditions() GoogleCloudRunOpV2ConditionResponseArrayOutput {
	return o.ApplyT(func(v LookupServiceResult) []GoogleCloudRunOpV2ConditionResponse { return v.Conditions }).(GoogleCloudRunOpV2ConditionResponseArrayOutput)
}

// The creation time.
func (o LookupServiceResultOutput) CreateTime() pulumi.StringOutput {
	return o.ApplyT(func(v LookupServiceResult) string { return v.CreateTime }).(pulumi.StringOutput)
}

// Email address of the authenticated creator.
func (o LookupServiceResultOutput) Creator() pulumi.StringOutput {
	return o.ApplyT(func(v LookupServiceResult) string { return v.Creator }).(pulumi.StringOutput)
}

// The deletion time.
func (o LookupServiceResultOutput) DeleteTime() pulumi.StringOutput {
	return o.ApplyT(func(v LookupServiceResult) string { return v.DeleteTime }).(pulumi.StringOutput)
}

// User-provided description of the Service.
func (o LookupServiceResultOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v LookupServiceResult) string { return v.Description }).(pulumi.StringOutput)
}

// A system-generated fingerprint for this version of the resource. May be used to detect modification conflict during updates.
func (o LookupServiceResultOutput) Etag() pulumi.StringOutput {
	return o.ApplyT(func(v LookupServiceResult) string { return v.Etag }).(pulumi.StringOutput)
}

// For a deleted resource, the time after which it will be permamently deleted.
func (o LookupServiceResultOutput) ExpireTime() pulumi.StringOutput {
	return o.ApplyT(func(v LookupServiceResult) string { return v.ExpireTime }).(pulumi.StringOutput)
}

// A number that monotonically increases every time the user modifies the desired state.
func (o LookupServiceResultOutput) Generation() pulumi.StringOutput {
	return o.ApplyT(func(v LookupServiceResult) string { return v.Generation }).(pulumi.StringOutput)
}

// Provides the ingress settings for this Service. On output, returns the currently observed ingress settings, or INGRESS_TRAFFIC_UNSPECIFIED if no revision is active.
func (o LookupServiceResultOutput) Ingress() pulumi.StringOutput {
	return o.ApplyT(func(v LookupServiceResult) string { return v.Ingress }).(pulumi.StringOutput)
}

// Map of string keys and values that can be used to organize and categorize objects. User-provided labels are shared with Google's billing system, so they can be used to filter, or break down billing charges by team, component, environment, state, etc. For more information, visit https://cloud.google.com/resource-manager/docs/creating-managing-labels or https://cloud.google.com/run/docs/configuring/labels Cloud Run will populate some labels with 'run.googleapis.com' or 'serving.knative.dev' namespaces. Those labels are read-only, and user changes will not be preserved.
func (o LookupServiceResultOutput) Labels() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupServiceResult) map[string]string { return v.Labels }).(pulumi.StringMapOutput)
}

// Email address of the last authenticated modifier.
func (o LookupServiceResultOutput) LastModifier() pulumi.StringOutput {
	return o.ApplyT(func(v LookupServiceResult) string { return v.LastModifier }).(pulumi.StringOutput)
}

// Name of the last created revision. See comments in `reconciling` for additional information on reconciliation process in Cloud Run.
func (o LookupServiceResultOutput) LatestCreatedRevision() pulumi.StringOutput {
	return o.ApplyT(func(v LookupServiceResult) string { return v.LatestCreatedRevision }).(pulumi.StringOutput)
}

// Name of the latest revision that is serving traffic. See comments in `reconciling` for additional information on reconciliation process in Cloud Run.
func (o LookupServiceResultOutput) LatestReadyRevision() pulumi.StringOutput {
	return o.ApplyT(func(v LookupServiceResult) string { return v.LatestReadyRevision }).(pulumi.StringOutput)
}

// The launch stage as defined by [Google Cloud Platform Launch Stages](http://cloud.google.com/terms/launch-stages). Cloud Run supports `ALPHA`, `BETA`, and `GA`. If no value is specified, GA is assumed.
func (o LookupServiceResultOutput) LaunchStage() pulumi.StringOutput {
	return o.ApplyT(func(v LookupServiceResult) string { return v.LaunchStage }).(pulumi.StringOutput)
}

// The fully qualified name of this Service. In CreateServiceRequest, this field is ignored, and instead composed from CreateServiceRequest.parent and CreateServiceRequest.service_id. Format: projects/{project}/locations/{location}/services/{service_id}
func (o LookupServiceResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupServiceResult) string { return v.Name }).(pulumi.StringOutput)
}

// The generation of this Service currently serving traffic. See comments in `reconciling` for additional information on reconciliation process in Cloud Run.
func (o LookupServiceResultOutput) ObservedGeneration() pulumi.StringOutput {
	return o.ApplyT(func(v LookupServiceResult) string { return v.ObservedGeneration }).(pulumi.StringOutput)
}

// Returns true if the Service is currently being acted upon by the system to bring it into the desired state. When a new Service is created, or an existing one is updated, Cloud Run will asynchronously perform all necessary steps to bring the Service to the desired serving state. This process is called reconciliation. While reconciliation is in process, `observed_generation`, `latest_ready_revison`, `traffic_statuses`, and `uri` will have transient values that might mismatch the intended state: Once reconciliation is over (and this field is false), there are two possible outcomes: reconciliation succeeded and the serving state matches the Service, or there was an error, and reconciliation failed. This state can be found in `terminal_condition.state`. If reconciliation succeeded, the following fields will match: `traffic` and `traffic_statuses`, `observed_generation` and `generation`, `latest_ready_revision` and `latest_created_revision`. If reconciliation failed, `traffic_statuses`, `observed_generation`, and `latest_ready_revision` will have the state of the last serving revision, or empty for newly created Services. Additional information on the failure can be found in `terminal_condition` and `conditions`.
func (o LookupServiceResultOutput) Reconciling() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupServiceResult) bool { return v.Reconciling }).(pulumi.BoolOutput)
}

// The template used to create revisions for this Service.
func (o LookupServiceResultOutput) Template() GoogleCloudRunOpV2RevisionTemplateResponseOutput {
	return o.ApplyT(func(v LookupServiceResult) GoogleCloudRunOpV2RevisionTemplateResponse { return v.Template }).(GoogleCloudRunOpV2RevisionTemplateResponseOutput)
}

// The Condition of this Service, containing its readiness status, and detailed error information in case it did not reach a serving state. See comments in `reconciling` for additional information on reconciliation process in Cloud Run.
func (o LookupServiceResultOutput) TerminalCondition() GoogleCloudRunOpV2ConditionResponseOutput {
	return o.ApplyT(func(v LookupServiceResult) GoogleCloudRunOpV2ConditionResponse { return v.TerminalCondition }).(GoogleCloudRunOpV2ConditionResponseOutput)
}

// Specifies how to distribute traffic over a collection of Revisions belonging to the Service. If traffic is empty or not provided, defaults to 100% traffic to the latest `Ready` Revision.
func (o LookupServiceResultOutput) Traffic() GoogleCloudRunOpV2TrafficTargetResponseArrayOutput {
	return o.ApplyT(func(v LookupServiceResult) []GoogleCloudRunOpV2TrafficTargetResponse { return v.Traffic }).(GoogleCloudRunOpV2TrafficTargetResponseArrayOutput)
}

// Detailed status information for corresponding traffic targets. See comments in `reconciling` for additional information on reconciliation process in Cloud Run.
func (o LookupServiceResultOutput) TrafficStatuses() GoogleCloudRunOpV2TrafficTargetStatusResponseArrayOutput {
	return o.ApplyT(func(v LookupServiceResult) []GoogleCloudRunOpV2TrafficTargetStatusResponse { return v.TrafficStatuses }).(GoogleCloudRunOpV2TrafficTargetStatusResponseArrayOutput)
}

// Server assigned unique identifier for the trigger. The value is a UUID4 string and guaranteed to remain unchanged until the resource is deleted.
func (o LookupServiceResultOutput) Uid() pulumi.StringOutput {
	return o.ApplyT(func(v LookupServiceResult) string { return v.Uid }).(pulumi.StringOutput)
}

// The last-modified time.
func (o LookupServiceResultOutput) UpdateTime() pulumi.StringOutput {
	return o.ApplyT(func(v LookupServiceResult) string { return v.UpdateTime }).(pulumi.StringOutput)
}

// The main URI in which this Service is serving traffic.
func (o LookupServiceResultOutput) Uri() pulumi.StringOutput {
	return o.ApplyT(func(v LookupServiceResult) string { return v.Uri }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupServiceResultOutput{})
}