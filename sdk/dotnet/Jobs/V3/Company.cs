// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.Jobs.V3
{
    /// <summary>
    /// Creates a new company entity.
    /// </summary>
    [GoogleCloudResourceType("google-cloud:jobs/v3:Company")]
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
            : base("google-cloud:jobs/v3:Company", name, args ?? new CompanyArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Company(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("google-cloud:jobs/v3:Company", name, null, MakeResourceOptions(options, id))
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
        /// Required. The company to be created.
        /// </summary>
        [Input("company")]
        public Input<Inputs.CompanyArgs>? Company { get; set; }

        /// <summary>
        /// Required. Resource name of the project under which the company is created. The format is "projects/{project_id}", for example, "projects/api-test-project".
        /// </summary>
        [Input("parent", required: true)]
        public Input<string> Parent { get; set; } = null!;

        public CompanyArgs()
        {
        }
    }
}