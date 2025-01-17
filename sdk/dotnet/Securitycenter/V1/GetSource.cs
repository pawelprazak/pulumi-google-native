// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.Securitycenter.V1
{
    public static class GetSource
    {
        /// <summary>
        /// Gets a source.
        /// </summary>
        public static Task<GetSourceResult> InvokeAsync(GetSourceArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetSourceResult>("google-native:securitycenter/v1:getSource", args ?? new GetSourceArgs(), options.WithDefaults());

        /// <summary>
        /// Gets a source.
        /// </summary>
        public static Output<GetSourceResult> Invoke(GetSourceInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetSourceResult>("google-native:securitycenter/v1:getSource", args ?? new GetSourceInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetSourceArgs : Pulumi.InvokeArgs
    {
        [Input("organizationId", required: true)]
        public string OrganizationId { get; set; } = null!;

        [Input("sourceId", required: true)]
        public string SourceId { get; set; } = null!;

        public GetSourceArgs()
        {
        }
    }

    public sealed class GetSourceInvokeArgs : Pulumi.InvokeArgs
    {
        [Input("organizationId", required: true)]
        public Input<string> OrganizationId { get; set; } = null!;

        [Input("sourceId", required: true)]
        public Input<string> SourceId { get; set; } = null!;

        public GetSourceInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetSourceResult
    {
        /// <summary>
        /// The canonical name of the finding. It's either "organizations/{organization_id}/sources/{source_id}", "folders/{folder_id}/sources/{source_id}" or "projects/{project_number}/sources/{source_id}", depending on the closest CRM ancestor of the resource associated with the finding.
        /// </summary>
        public readonly string CanonicalName;
        /// <summary>
        /// The description of the source (max of 1024 characters). Example: "Web Security Scanner is a web security scanner for common vulnerabilities in App Engine applications. It can automatically scan and detect four common vulnerabilities, including cross-site-scripting (XSS), Flash injection, mixed content (HTTP in HTTPS), and outdated or insecure libraries."
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// The source's display name. A source's display name must be unique amongst its siblings, for example, two sources with the same parent can't share the same display name. The display name must have a length between 1 and 64 characters (inclusive).
        /// </summary>
        public readonly string DisplayName;
        /// <summary>
        /// The relative resource name of this source. See: https://cloud.google.com/apis/design/resource_names#relative_resource_name Example: "organizations/{organization_id}/sources/{source_id}"
        /// </summary>
        public readonly string Name;

        [OutputConstructor]
        private GetSourceResult(
            string canonicalName,

            string description,

            string displayName,

            string name)
        {
            CanonicalName = canonicalName;
            Description = description;
            DisplayName = displayName;
            Name = name;
        }
    }
}
