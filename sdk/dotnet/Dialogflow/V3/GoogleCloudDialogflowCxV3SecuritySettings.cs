// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.Dialogflow.V3
{
    /// <summary>
    /// Create security settings in the specified location.
    /// </summary>
    [GoogleCloudResourceType("google-cloud:dialogflow/v3:GoogleCloudDialogflowCxV3SecuritySettings")]
    public partial class GoogleCloudDialogflowCxV3SecuritySettings : Pulumi.CustomResource
    {
        /// <summary>
        /// Create a GoogleCloudDialogflowCxV3SecuritySettings resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public GoogleCloudDialogflowCxV3SecuritySettings(string name, GoogleCloudDialogflowCxV3SecuritySettingsArgs args, CustomResourceOptions? options = null)
            : base("google-cloud:dialogflow/v3:GoogleCloudDialogflowCxV3SecuritySettings", name, args ?? new GoogleCloudDialogflowCxV3SecuritySettingsArgs(), MakeResourceOptions(options, ""))
        {
        }

        private GoogleCloudDialogflowCxV3SecuritySettings(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("google-cloud:dialogflow/v3:GoogleCloudDialogflowCxV3SecuritySettings", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing GoogleCloudDialogflowCxV3SecuritySettings resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static GoogleCloudDialogflowCxV3SecuritySettings Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new GoogleCloudDialogflowCxV3SecuritySettings(name, id, options);
        }
    }

    public sealed class GoogleCloudDialogflowCxV3SecuritySettingsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Required. The human-readable name of the security settings, unique within the location.
        /// </summary>
        [Input("displayName")]
        public Input<string>? DisplayName { get; set; }

        /// <summary>
        /// DLP inspect template name. Use this template to define inspect base settings. If empty, we use the default DLP inspect config. The template name will have one of the following formats: `projects/PROJECT_ID/inspectTemplates/TEMPLATE_ID` OR `organizations/ORGANIZATION_ID/inspectTemplates/TEMPLATE_ID`
        /// </summary>
        [Input("inspectTemplate")]
        public Input<string>? InspectTemplate { get; set; }

        /// <summary>
        /// Required. Resource name of the settings. Format: `projects//locations//securitySettings/`.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Required. The location to create an SecuritySettings for. Format: `projects//locations/`.
        /// </summary>
        [Input("parent", required: true)]
        public Input<string> Parent { get; set; } = null!;

        [Input("purgeDataTypes")]
        private InputList<string>? _purgeDataTypes;

        /// <summary>
        /// List of types of data to remove when retention settings triggers purge.
        /// </summary>
        public InputList<string> PurgeDataTypes
        {
            get => _purgeDataTypes ?? (_purgeDataTypes = new InputList<string>());
            set => _purgeDataTypes = value;
        }

        /// <summary>
        /// Defines on what data we apply redaction. Note that we don't redact data to which we don't have access, e.g., Stackdriver logs.
        /// </summary>
        [Input("redactionScope")]
        public Input<string>? RedactionScope { get; set; }

        /// <summary>
        /// Strategy that defines how we do redaction.
        /// </summary>
        [Input("redactionStrategy")]
        public Input<string>? RedactionStrategy { get; set; }

        /// <summary>
        /// Retains the data for the specified number of days. User must Set a value lower than Dialogflow's default 30d TTL. Setting a value higher than that has no effect. A missing value or setting to 0 also means we use Dialogflow's default TTL.
        /// </summary>
        [Input("retentionWindowDays")]
        public Input<int>? RetentionWindowDays { get; set; }

        public GoogleCloudDialogflowCxV3SecuritySettingsArgs()
        {
        }
    }
}