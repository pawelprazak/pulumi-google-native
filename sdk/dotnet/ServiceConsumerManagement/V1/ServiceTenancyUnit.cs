// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.ServiceConsumerManagement.V1
{
    /// <summary>
    /// Creates a tenancy unit with no tenant resources. If tenancy unit already exists, it will be returned, however, in this case, returned TenancyUnit does not have tenant_resources field set and ListTenancyUnits has to be used to get a complete TenancyUnit with all fields populated.
    /// </summary>
    [GoogleCloudResourceType("google-cloud:serviceconsumermanagement/v1:ServiceTenancyUnit")]
    public partial class ServiceTenancyUnit : Pulumi.CustomResource
    {
        /// <summary>
        /// Create a ServiceTenancyUnit resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ServiceTenancyUnit(string name, ServiceTenancyUnitArgs args, CustomResourceOptions? options = null)
            : base("google-cloud:serviceconsumermanagement/v1:ServiceTenancyUnit", name, args ?? new ServiceTenancyUnitArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ServiceTenancyUnit(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("google-cloud:serviceconsumermanagement/v1:ServiceTenancyUnit", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing ServiceTenancyUnit resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ServiceTenancyUnit Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new ServiceTenancyUnit(name, id, options);
        }
    }

    public sealed class ServiceTenancyUnitArgs : Pulumi.ResourceArgs
    {
        [Input("servicesId", required: true)]
        public Input<string> ServicesId { get; set; } = null!;

        [Input("servicesId1", required: true)]
        public Input<string> ServicesId1 { get; set; } = null!;

        [Input("servicesId2", required: true)]
        public Input<string> ServicesId2 { get; set; } = null!;

        /// <summary>
        /// Optional. Optional service producer-provided identifier of the tenancy unit. Must be no longer than 40 characters and preferably URI friendly. If it isn't provided, a UID for the tenancy unit is automatically generated. The identifier must be unique across a managed service. If the tenancy unit already exists for the managed service and service consumer pair, calling `CreateTenancyUnit` returns the existing tenancy unit if the provided identifier is identical or empty, otherwise the call fails.
        /// </summary>
        [Input("tenancyUnitId")]
        public Input<string>? TenancyUnitId { get; set; }

        [Input("tenancyUnitsId", required: true)]
        public Input<string> TenancyUnitsId { get; set; } = null!;

        public ServiceTenancyUnitArgs()
        {
        }
    }
}