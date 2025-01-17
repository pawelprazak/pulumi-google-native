// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.reCAPTCHAEnterprise.V1
{
    /// <summary>
    /// Creates a new reCAPTCHA Enterprise key.
    /// </summary>
    [GoogleNativeResourceType("google-native:recaptchaenterprise/v1:Key")]
    public partial class Key : Pulumi.CustomResource
    {
        /// <summary>
        /// Settings for keys that can be used by Android apps.
        /// </summary>
        [Output("androidSettings")]
        public Output<Outputs.GoogleCloudRecaptchaenterpriseV1AndroidKeySettingsResponse> AndroidSettings { get; private set; } = null!;

        /// <summary>
        /// The timestamp corresponding to the creation of this Key.
        /// </summary>
        [Output("createTime")]
        public Output<string> CreateTime { get; private set; } = null!;

        /// <summary>
        /// Human-readable display name of this key. Modifiable by user.
        /// </summary>
        [Output("displayName")]
        public Output<string> DisplayName { get; private set; } = null!;

        /// <summary>
        /// Settings for keys that can be used by iOS apps.
        /// </summary>
        [Output("iosSettings")]
        public Output<Outputs.GoogleCloudRecaptchaenterpriseV1IOSKeySettingsResponse> IosSettings { get; private set; } = null!;

        /// <summary>
        /// See Creating and managing labels.
        /// </summary>
        [Output("labels")]
        public Output<ImmutableDictionary<string, string>> Labels { get; private set; } = null!;

        /// <summary>
        /// The resource name for the Key in the format "projects/{project}/keys/{key}".
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        [Output("project")]
        public Output<string> Project { get; private set; } = null!;

        /// <summary>
        /// Options for user acceptance testing.
        /// </summary>
        [Output("testingOptions")]
        public Output<Outputs.GoogleCloudRecaptchaenterpriseV1TestingOptionsResponse> TestingOptions { get; private set; } = null!;

        /// <summary>
        /// Settings for WAF
        /// </summary>
        [Output("wafSettings")]
        public Output<Outputs.GoogleCloudRecaptchaenterpriseV1WafSettingsResponse> WafSettings { get; private set; } = null!;

        /// <summary>
        /// Settings for keys that can be used by websites.
        /// </summary>
        [Output("webSettings")]
        public Output<Outputs.GoogleCloudRecaptchaenterpriseV1WebKeySettingsResponse> WebSettings { get; private set; } = null!;


        /// <summary>
        /// Create a Key resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Key(string name, KeyArgs? args = null, CustomResourceOptions? options = null)
            : base("google-native:recaptchaenterprise/v1:Key", name, args ?? new KeyArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Key(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("google-native:recaptchaenterprise/v1:Key", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing Key resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Key Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Key(name, id, options);
        }
    }

    public sealed class KeyArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Settings for keys that can be used by Android apps.
        /// </summary>
        [Input("androidSettings")]
        public Input<Inputs.GoogleCloudRecaptchaenterpriseV1AndroidKeySettingsArgs>? AndroidSettings { get; set; }

        /// <summary>
        /// The timestamp corresponding to the creation of this Key.
        /// </summary>
        [Input("createTime")]
        public Input<string>? CreateTime { get; set; }

        /// <summary>
        /// Human-readable display name of this key. Modifiable by user.
        /// </summary>
        [Input("displayName")]
        public Input<string>? DisplayName { get; set; }

        /// <summary>
        /// Settings for keys that can be used by iOS apps.
        /// </summary>
        [Input("iosSettings")]
        public Input<Inputs.GoogleCloudRecaptchaenterpriseV1IOSKeySettingsArgs>? IosSettings { get; set; }

        [Input("labels")]
        private InputMap<string>? _labels;

        /// <summary>
        /// See Creating and managing labels.
        /// </summary>
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        /// <summary>
        /// The resource name for the Key in the format "projects/{project}/keys/{key}".
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("project")]
        public Input<string>? Project { get; set; }

        /// <summary>
        /// Options for user acceptance testing.
        /// </summary>
        [Input("testingOptions")]
        public Input<Inputs.GoogleCloudRecaptchaenterpriseV1TestingOptionsArgs>? TestingOptions { get; set; }

        /// <summary>
        /// Settings for WAF
        /// </summary>
        [Input("wafSettings")]
        public Input<Inputs.GoogleCloudRecaptchaenterpriseV1WafSettingsArgs>? WafSettings { get; set; }

        /// <summary>
        /// Settings for keys that can be used by websites.
        /// </summary>
        [Input("webSettings")]
        public Input<Inputs.GoogleCloudRecaptchaenterpriseV1WebKeySettingsArgs>? WebSettings { get; set; }

        public KeyArgs()
        {
        }
    }
}
