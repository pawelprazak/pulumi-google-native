// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Gets the details and status of an analytics export job. If the export job is still in progress, its `state` is set to "running". After the export job has completed successfully, its `state` is set to "completed". If the export job fails, its `state` is set to `failed`.
func LookupExport(ctx *pulumi.Context, args *LookupExportArgs, opts ...pulumi.InvokeOption) (*LookupExportResult, error) {
	var rv LookupExportResult
	err := ctx.Invoke("google-native:apigee/v1:getExport", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupExportArgs struct {
	EnvironmentId  string `pulumi:"environmentId"`
	ExportId       string `pulumi:"exportId"`
	OrganizationId string `pulumi:"organizationId"`
}

type LookupExportResult struct {
	// Time the export job was created.
	Created string `pulumi:"created"`
	// Name of the datastore that is the destination of the export job [datastore]
	DatastoreName string `pulumi:"datastoreName"`
	// Description of the export job.
	Description string `pulumi:"description"`
	// Error is set when export fails
	Error string `pulumi:"error"`
	// Execution time for this export job. If the job is still in progress, it will be set to the amount of time that has elapsed since`created`, in seconds. Else, it will set to (`updated` - `created`), in seconds.
	ExecutionTime string `pulumi:"executionTime"`
	// Display name of the export job.
	Name string `pulumi:"name"`
	// Self link of the export job. A URI that can be used to retrieve the status of an export job. Example: `/organizations/myorg/environments/myenv/analytics/exports/9cfc0d85-0f30-46d6-ae6f-318d0cb961bd`
	Self string `pulumi:"self"`
	// Status of the export job. Valid values include `enqueued`, `running`, `completed`, and `failed`.
	State string `pulumi:"state"`
	// Time the export job was last updated.
	Updated string `pulumi:"updated"`
}

func LookupExportOutput(ctx *pulumi.Context, args LookupExportOutputArgs, opts ...pulumi.InvokeOption) LookupExportResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupExportResult, error) {
			args := v.(LookupExportArgs)
			r, err := LookupExport(ctx, &args, opts...)
			var s LookupExportResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupExportResultOutput)
}

type LookupExportOutputArgs struct {
	EnvironmentId  pulumi.StringInput `pulumi:"environmentId"`
	ExportId       pulumi.StringInput `pulumi:"exportId"`
	OrganizationId pulumi.StringInput `pulumi:"organizationId"`
}

func (LookupExportOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupExportArgs)(nil)).Elem()
}

type LookupExportResultOutput struct{ *pulumi.OutputState }

func (LookupExportResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupExportResult)(nil)).Elem()
}

func (o LookupExportResultOutput) ToLookupExportResultOutput() LookupExportResultOutput {
	return o
}

func (o LookupExportResultOutput) ToLookupExportResultOutputWithContext(ctx context.Context) LookupExportResultOutput {
	return o
}

// Time the export job was created.
func (o LookupExportResultOutput) Created() pulumi.StringOutput {
	return o.ApplyT(func(v LookupExportResult) string { return v.Created }).(pulumi.StringOutput)
}

// Name of the datastore that is the destination of the export job [datastore]
func (o LookupExportResultOutput) DatastoreName() pulumi.StringOutput {
	return o.ApplyT(func(v LookupExportResult) string { return v.DatastoreName }).(pulumi.StringOutput)
}

// Description of the export job.
func (o LookupExportResultOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v LookupExportResult) string { return v.Description }).(pulumi.StringOutput)
}

// Error is set when export fails
func (o LookupExportResultOutput) Error() pulumi.StringOutput {
	return o.ApplyT(func(v LookupExportResult) string { return v.Error }).(pulumi.StringOutput)
}

// Execution time for this export job. If the job is still in progress, it will be set to the amount of time that has elapsed since`created`, in seconds. Else, it will set to (`updated` - `created`), in seconds.
func (o LookupExportResultOutput) ExecutionTime() pulumi.StringOutput {
	return o.ApplyT(func(v LookupExportResult) string { return v.ExecutionTime }).(pulumi.StringOutput)
}

// Display name of the export job.
func (o LookupExportResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupExportResult) string { return v.Name }).(pulumi.StringOutput)
}

// Self link of the export job. A URI that can be used to retrieve the status of an export job. Example: `/organizations/myorg/environments/myenv/analytics/exports/9cfc0d85-0f30-46d6-ae6f-318d0cb961bd`
func (o LookupExportResultOutput) Self() pulumi.StringOutput {
	return o.ApplyT(func(v LookupExportResult) string { return v.Self }).(pulumi.StringOutput)
}

// Status of the export job. Valid values include `enqueued`, `running`, `completed`, and `failed`.
func (o LookupExportResultOutput) State() pulumi.StringOutput {
	return o.ApplyT(func(v LookupExportResult) string { return v.State }).(pulumi.StringOutput)
}

// Time the export job was last updated.
func (o LookupExportResultOutput) Updated() pulumi.StringOutput {
	return o.ApplyT(func(v LookupExportResult) string { return v.Updated }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupExportResultOutput{})
}