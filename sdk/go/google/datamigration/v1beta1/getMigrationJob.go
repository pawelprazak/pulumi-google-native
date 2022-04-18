// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1beta1

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Gets details of a single migration job.
func LookupMigrationJob(ctx *pulumi.Context, args *LookupMigrationJobArgs, opts ...pulumi.InvokeOption) (*LookupMigrationJobResult, error) {
	var rv LookupMigrationJobResult
	err := ctx.Invoke("google-native:datamigration/v1beta1:getMigrationJob", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupMigrationJobArgs struct {
	Location       string  `pulumi:"location"`
	MigrationJobId string  `pulumi:"migrationJobId"`
	Project        *string `pulumi:"project"`
}

type LookupMigrationJobResult struct {
	// The timestamp when the migration job resource was created. A timestamp in RFC3339 UTC "Zulu" format, accurate to nanoseconds. Example: "2014-10-02T15:01:23.045123456Z".
	CreateTime string `pulumi:"createTime"`
	// The resource name (URI) of the destination connection profile.
	Destination string `pulumi:"destination"`
	// The database engine type and provider of the destination.
	DestinationDatabase DatabaseTypeResponse `pulumi:"destinationDatabase"`
	// The migration job display name.
	DisplayName string `pulumi:"displayName"`
	// The path to the dump file in Google Cloud Storage, in the format: (gs://[BUCKET_NAME]/[OBJECT_NAME]).
	DumpPath string `pulumi:"dumpPath"`
	// The duration of the migration job (in seconds). A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s".
	Duration string `pulumi:"duration"`
	// If the migration job is completed, the time when it was completed.
	EndTime string `pulumi:"endTime"`
	// The error details in case of state FAILED.
	Error StatusResponse `pulumi:"error"`
	// The resource labels for migration job to use to annotate any related underlying resources such as Compute Engine VMs. An object containing a list of "key": "value" pairs. Example: `{ "name": "wrench", "mass": "1.3kg", "count": "3" }`.
	Labels map[string]string `pulumi:"labels"`
	// The name (URI) of this migration job resource, in the form of: projects/{project}/locations/{location}/migrationJobs/{migrationJob}.
	Name string `pulumi:"name"`
	// The current migration job phase.
	Phase string `pulumi:"phase"`
	// The details needed to communicate to the source over Reverse SSH tunnel connectivity.
	ReverseSshConnectivity ReverseSshConnectivityResponse `pulumi:"reverseSshConnectivity"`
	// The resource name (URI) of the source connection profile.
	Source string `pulumi:"source"`
	// The database engine type and provider of the source.
	SourceDatabase DatabaseTypeResponse `pulumi:"sourceDatabase"`
	// The current migration job state.
	State string `pulumi:"state"`
	// static ip connectivity data (default, no additional details needed).
	StaticIpConnectivity StaticIpConnectivityResponse `pulumi:"staticIpConnectivity"`
	// The migration job type.
	Type string `pulumi:"type"`
	// The timestamp when the migration job resource was last updated. A timestamp in RFC3339 UTC "Zulu" format, accurate to nanoseconds. Example: "2014-10-02T15:01:23.045123456Z".
	UpdateTime string `pulumi:"updateTime"`
	// The details of the VPC network that the source database is located in.
	VpcPeeringConnectivity VpcPeeringConnectivityResponse `pulumi:"vpcPeeringConnectivity"`
}

func LookupMigrationJobOutput(ctx *pulumi.Context, args LookupMigrationJobOutputArgs, opts ...pulumi.InvokeOption) LookupMigrationJobResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupMigrationJobResult, error) {
			args := v.(LookupMigrationJobArgs)
			r, err := LookupMigrationJob(ctx, &args, opts...)
			var s LookupMigrationJobResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupMigrationJobResultOutput)
}

type LookupMigrationJobOutputArgs struct {
	Location       pulumi.StringInput    `pulumi:"location"`
	MigrationJobId pulumi.StringInput    `pulumi:"migrationJobId"`
	Project        pulumi.StringPtrInput `pulumi:"project"`
}

func (LookupMigrationJobOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupMigrationJobArgs)(nil)).Elem()
}

type LookupMigrationJobResultOutput struct{ *pulumi.OutputState }

func (LookupMigrationJobResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupMigrationJobResult)(nil)).Elem()
}

func (o LookupMigrationJobResultOutput) ToLookupMigrationJobResultOutput() LookupMigrationJobResultOutput {
	return o
}

func (o LookupMigrationJobResultOutput) ToLookupMigrationJobResultOutputWithContext(ctx context.Context) LookupMigrationJobResultOutput {
	return o
}

// The timestamp when the migration job resource was created. A timestamp in RFC3339 UTC "Zulu" format, accurate to nanoseconds. Example: "2014-10-02T15:01:23.045123456Z".
func (o LookupMigrationJobResultOutput) CreateTime() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMigrationJobResult) string { return v.CreateTime }).(pulumi.StringOutput)
}

// The resource name (URI) of the destination connection profile.
func (o LookupMigrationJobResultOutput) Destination() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMigrationJobResult) string { return v.Destination }).(pulumi.StringOutput)
}

// The database engine type and provider of the destination.
func (o LookupMigrationJobResultOutput) DestinationDatabase() DatabaseTypeResponseOutput {
	return o.ApplyT(func(v LookupMigrationJobResult) DatabaseTypeResponse { return v.DestinationDatabase }).(DatabaseTypeResponseOutput)
}

// The migration job display name.
func (o LookupMigrationJobResultOutput) DisplayName() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMigrationJobResult) string { return v.DisplayName }).(pulumi.StringOutput)
}

// The path to the dump file in Google Cloud Storage, in the format: (gs://[BUCKET_NAME]/[OBJECT_NAME]).
func (o LookupMigrationJobResultOutput) DumpPath() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMigrationJobResult) string { return v.DumpPath }).(pulumi.StringOutput)
}

// The duration of the migration job (in seconds). A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s".
func (o LookupMigrationJobResultOutput) Duration() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMigrationJobResult) string { return v.Duration }).(pulumi.StringOutput)
}

// If the migration job is completed, the time when it was completed.
func (o LookupMigrationJobResultOutput) EndTime() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMigrationJobResult) string { return v.EndTime }).(pulumi.StringOutput)
}

// The error details in case of state FAILED.
func (o LookupMigrationJobResultOutput) Error() StatusResponseOutput {
	return o.ApplyT(func(v LookupMigrationJobResult) StatusResponse { return v.Error }).(StatusResponseOutput)
}

// The resource labels for migration job to use to annotate any related underlying resources such as Compute Engine VMs. An object containing a list of "key": "value" pairs. Example: `{ "name": "wrench", "mass": "1.3kg", "count": "3" }`.
func (o LookupMigrationJobResultOutput) Labels() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupMigrationJobResult) map[string]string { return v.Labels }).(pulumi.StringMapOutput)
}

// The name (URI) of this migration job resource, in the form of: projects/{project}/locations/{location}/migrationJobs/{migrationJob}.
func (o LookupMigrationJobResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMigrationJobResult) string { return v.Name }).(pulumi.StringOutput)
}

// The current migration job phase.
func (o LookupMigrationJobResultOutput) Phase() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMigrationJobResult) string { return v.Phase }).(pulumi.StringOutput)
}

// The details needed to communicate to the source over Reverse SSH tunnel connectivity.
func (o LookupMigrationJobResultOutput) ReverseSshConnectivity() ReverseSshConnectivityResponseOutput {
	return o.ApplyT(func(v LookupMigrationJobResult) ReverseSshConnectivityResponse { return v.ReverseSshConnectivity }).(ReverseSshConnectivityResponseOutput)
}

// The resource name (URI) of the source connection profile.
func (o LookupMigrationJobResultOutput) Source() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMigrationJobResult) string { return v.Source }).(pulumi.StringOutput)
}

// The database engine type and provider of the source.
func (o LookupMigrationJobResultOutput) SourceDatabase() DatabaseTypeResponseOutput {
	return o.ApplyT(func(v LookupMigrationJobResult) DatabaseTypeResponse { return v.SourceDatabase }).(DatabaseTypeResponseOutput)
}

// The current migration job state.
func (o LookupMigrationJobResultOutput) State() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMigrationJobResult) string { return v.State }).(pulumi.StringOutput)
}

// static ip connectivity data (default, no additional details needed).
func (o LookupMigrationJobResultOutput) StaticIpConnectivity() StaticIpConnectivityResponseOutput {
	return o.ApplyT(func(v LookupMigrationJobResult) StaticIpConnectivityResponse { return v.StaticIpConnectivity }).(StaticIpConnectivityResponseOutput)
}

// The migration job type.
func (o LookupMigrationJobResultOutput) Type() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMigrationJobResult) string { return v.Type }).(pulumi.StringOutput)
}

// The timestamp when the migration job resource was last updated. A timestamp in RFC3339 UTC "Zulu" format, accurate to nanoseconds. Example: "2014-10-02T15:01:23.045123456Z".
func (o LookupMigrationJobResultOutput) UpdateTime() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMigrationJobResult) string { return v.UpdateTime }).(pulumi.StringOutput)
}

// The details of the VPC network that the source database is located in.
func (o LookupMigrationJobResultOutput) VpcPeeringConnectivity() VpcPeeringConnectivityResponseOutput {
	return o.ApplyT(func(v LookupMigrationJobResult) VpcPeeringConnectivityResponse { return v.VpcPeeringConnectivity }).(VpcPeeringConnectivityResponseOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupMigrationJobResultOutput{})
}