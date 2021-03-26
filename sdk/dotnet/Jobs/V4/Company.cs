// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.Jobs.V4
{
    /// <summary>
    /// Creates a new company entity.
    /// </summary>
    [GoogleCloudResourceType("google-cloud:jobs/v4:Company")]
    public partial class Company : Pulumi.CustomResource
    {
        /// <summary>
        /// Create a Company resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Company(string name, CompanyArgs args, CustomResourceOptions? options = null)
            : base("google-cloud:jobs/v4:Company", name, args ?? new CompanyArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Company(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("google-cloud:jobs/v4:Company", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing Company resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Company Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Company(name, id, options);
        }
    }

    public sealed class CompanyArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The URI to employer's career site or careers page on the employer's web site, for example, "https://careers.google.com".
        /// </summary>
        [Input("careerSiteUri")]
        public Input<string>? CareerSiteUri { get; set; }

        /// <summary>
        /// Output only. Derived details about the company.
        /// </summary>
        [Input("derivedInfo")]
        public Input<Inputs.CompanyDerivedInfoArgs>? DerivedInfo { get; set; }

        /// <summary>
        /// Required. The display name of the company, for example, "Google LLC".
        /// </summary>
        [Input("displayName")]
        public Input<string>? DisplayName { get; set; }

        /// <summary>
        /// Equal Employment Opportunity legal disclaimer text to be associated with all jobs, and typically to be displayed in all roles. The maximum number of allowed characters is 500.
        /// </summary>
        [Input("eeoText")]
        public Input<string>? EeoText { get; set; }

        /// <summary>
        /// Required. Client side company identifier, used to uniquely identify the company. The maximum number of allowed characters is 255.
        /// </summary>
        [Input("externalId")]
        public Input<string>? ExternalId { get; set; }

        /// <summary>
        /// The street address of the company's main headquarters, which may be different from the job location. The service attempts to geolocate the provided address, and populates a more specific location wherever possible in DerivedInfo.headquarters_location.
        /// </summary>
        [Input("headquartersAddress")]
        public Input<string>? HeadquartersAddress { get; set; }

        /// <summary>
        /// Set to true if it is the hiring agency that post jobs for other employers. Defaults to false if not provided.
        /// </summary>
        [Input("hiringAgency")]
        public Input<bool>? HiringAgency { get; set; }

        /// <summary>
        /// A URI that hosts the employer's company logo.
        /// </summary>
        [Input("imageUri")]
        public Input<string>? ImageUri { get; set; }

        [Input("keywordSearchableJobCustomAttributes")]
        private InputList<string>? _keywordSearchableJobCustomAttributes;

        /// <summary>
        /// A list of keys of filterable Job.custom_attributes, whose corresponding `string_values` are used in keyword searches. Jobs with `string_values` under these specified field keys are returned if any of the values match the search keyword. Custom field values with parenthesis, brackets and special symbols are not searchable as-is, and those keyword queries must be surrounded by quotes.
        /// </summary>
        public InputList<string> KeywordSearchableJobCustomAttributes
        {
            get => _keywordSearchableJobCustomAttributes ?? (_keywordSearchableJobCustomAttributes = new InputList<string>());
            set => _keywordSearchableJobCustomAttributes = value;
        }

        /// <summary>
        /// Required during company update. The resource name for a company. This is generated by the service when a company is created. The format is "projects/{project_id}/tenants/{tenant_id}/companies/{company_id}", for example, "projects/foo/tenants/bar/companies/baz".
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Required. Resource name of the tenant under which the company is created. The format is "projects/{project_id}/tenants/{tenant_id}", for example, "projects/foo/tenants/bar".
        /// </summary>
        [Input("parent", required: true)]
        public Input<string> Parent { get; set; } = null!;

        /// <summary>
        /// The employer's company size.
        /// </summary>
        [Input("size")]
        public Input<string>? Size { get; set; }

        /// <summary>
        /// Output only. Indicates whether a company is flagged to be suspended from public availability by the service when job content appears suspicious, abusive, or spammy.
        /// </summary>
        [Input("suspended")]
        public Input<bool>? Suspended { get; set; }

        /// <summary>
        /// The URI representing the company's primary web site or home page, for example, "https://www.google.com". The maximum number of allowed characters is 255.
        /// </summary>
        [Input("websiteUri")]
        public Input<string>? WebsiteUri { get; set; }

        public CompanyArgs()
        {
        }
    }
}