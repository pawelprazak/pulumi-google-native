// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.Appengine.V1
{
    /// <summary>
    /// Deploys code and resource files to a new version.
    /// </summary>
    [GoogleCloudResourceType("google-cloud:appengine/v1:Version")]
    public partial class Version : Pulumi.CustomResource
    {
        /// <summary>
        /// Create a Version resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Version(string name, VersionArgs args, CustomResourceOptions? options = null)
            : base("google-cloud:appengine/v1:Version", name, args ?? new VersionArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Version(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("google-cloud:appengine/v1:Version", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing Version resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Version Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Version(name, id, options);
        }
    }

    public sealed class VersionArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Serving configuration for Google Cloud Endpoints (https://cloud.google.com/appengine/docs/python/endpoints/).Only returned in GET requests if view=FULL is set.
        /// </summary>
        [Input("apiConfig")]
        public Input<Inputs.ApiConfigHandlerArgs>? ApiConfig { get; set; }

        /// <summary>
        /// Part of `parent`. Name of the parent resource to create this version under. Example: apps/myapp/services/default.
        /// </summary>
        [Input("appsId", required: true)]
        public Input<string> AppsId { get; set; } = null!;

        /// <summary>
        /// Automatic scaling is based on request rate, response latencies, and other application metrics. Instances are dynamically created and destroyed as needed in order to handle traffic.
        /// </summary>
        [Input("automaticScaling")]
        public Input<Inputs.AutomaticScalingArgs>? AutomaticScaling { get; set; }

        /// <summary>
        /// A service with basic scaling will create an instance when the application receives a request. The instance will be turned down when the app becomes idle. Basic scaling is ideal for work that is intermittent or driven by user activity.
        /// </summary>
        [Input("basicScaling")]
        public Input<Inputs.BasicScalingArgs>? BasicScaling { get; set; }

        [Input("betaSettings")]
        private InputMap<string>? _betaSettings;

        /// <summary>
        /// Metadata settings that are supplied to this version to enable beta runtime features.
        /// </summary>
        public InputMap<string> BetaSettings
        {
            get => _betaSettings ?? (_betaSettings = new InputMap<string>());
            set => _betaSettings = value;
        }

        [Input("buildEnvVariables")]
        private InputMap<string>? _buildEnvVariables;

        /// <summary>
        /// Environment variables available to the build environment.Only returned in GET requests if view=FULL is set.
        /// </summary>
        public InputMap<string> BuildEnvVariables
        {
            get => _buildEnvVariables ?? (_buildEnvVariables = new InputMap<string>());
            set => _buildEnvVariables = value;
        }

        /// <summary>
        /// Time that this version was created.@OutputOnly
        /// </summary>
        [Input("createTime")]
        public Input<string>? CreateTime { get; set; }

        /// <summary>
        /// Email address of the user who created this version.@OutputOnly
        /// </summary>
        [Input("createdBy")]
        public Input<string>? CreatedBy { get; set; }

        /// <summary>
        /// Duration that static files should be cached by web proxies and browsers. Only applicable if the corresponding StaticFilesHandler (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#StaticFilesHandler) does not specify its own expiration time.Only returned in GET requests if view=FULL is set.
        /// </summary>
        [Input("defaultExpiration")]
        public Input<string>? DefaultExpiration { get; set; }

        /// <summary>
        /// Code and application artifacts that make up this version.Only returned in GET requests if view=FULL is set.
        /// </summary>
        [Input("deployment")]
        public Input<Inputs.DeploymentArgs>? Deployment { get; set; }

        /// <summary>
        /// Total size in bytes of all the files that are included in this version and currently hosted on the App Engine disk.@OutputOnly
        /// </summary>
        [Input("diskUsageBytes")]
        public Input<string>? DiskUsageBytes { get; set; }

        /// <summary>
        /// Cloud Endpoints configuration.If endpoints_api_service is set, the Cloud Endpoints Extensible Service Proxy will be provided to serve the API implemented by the app.
        /// </summary>
        [Input("endpointsApiService")]
        public Input<Inputs.EndpointsApiServiceArgs>? EndpointsApiService { get; set; }

        /// <summary>
        /// The entrypoint for the application.
        /// </summary>
        [Input("entrypoint")]
        public Input<Inputs.EntrypointArgs>? Entrypoint { get; set; }

        /// <summary>
        /// App Engine execution environment for this version.Defaults to standard.
        /// </summary>
        [Input("env")]
        public Input<string>? Env { get; set; }

        [Input("envVariables")]
        private InputMap<string>? _envVariables;

        /// <summary>
        /// Environment variables available to the application.Only returned in GET requests if view=FULL is set.
        /// </summary>
        public InputMap<string> EnvVariables
        {
            get => _envVariables ?? (_envVariables = new InputMap<string>());
            set => _envVariables = value;
        }

        [Input("errorHandlers")]
        private InputList<Inputs.ErrorHandlerArgs>? _errorHandlers;

        /// <summary>
        /// Custom static error pages. Limited to 10KB per page.Only returned in GET requests if view=FULL is set.
        /// </summary>
        public InputList<Inputs.ErrorHandlerArgs> ErrorHandlers
        {
            get => _errorHandlers ?? (_errorHandlers = new InputList<Inputs.ErrorHandlerArgs>());
            set => _errorHandlers = value;
        }

        [Input("handlers")]
        private InputList<Inputs.UrlMapArgs>? _handlers;

        /// <summary>
        /// An ordered list of URL-matching patterns that should be applied to incoming requests. The first matching URL handles the request and other request handlers are not attempted.Only returned in GET requests if view=FULL is set.
        /// </summary>
        public InputList<Inputs.UrlMapArgs> Handlers
        {
            get => _handlers ?? (_handlers = new InputList<Inputs.UrlMapArgs>());
            set => _handlers = value;
        }

        /// <summary>
        /// Configures health checking for instances. Unhealthy instances are stopped and replaced with new instances. Only applicable in the App Engine flexible environment.Only returned in GET requests if view=FULL is set.
        /// </summary>
        [Input("healthCheck")]
        public Input<Inputs.HealthCheckArgs>? HealthCheck { get; set; }

        /// <summary>
        /// Relative name of the version within the service. Example: v1. Version names can contain only lowercase letters, numbers, or hyphens. Reserved names: "default", "latest", and any name with the prefix "ah-".
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        [Input("inboundServices")]
        private InputList<string>? _inboundServices;

        /// <summary>
        /// Before an application can receive email or XMPP messages, the application must be configured to enable the service.
        /// </summary>
        public InputList<string> InboundServices
        {
            get => _inboundServices ?? (_inboundServices = new InputList<string>());
            set => _inboundServices = value;
        }

        /// <summary>
        /// Instance class that is used to run this version. Valid values are: AutomaticScaling: F1, F2, F4, F4_1G ManualScaling or BasicScaling: B1, B2, B4, B8, B4_1GDefaults to F1 for AutomaticScaling and B1 for ManualScaling or BasicScaling.
        /// </summary>
        [Input("instanceClass")]
        public Input<string>? InstanceClass { get; set; }

        [Input("libraries")]
        private InputList<Inputs.LibraryArgs>? _libraries;

        /// <summary>
        /// Configuration for third-party Python runtime libraries that are required by the application.Only returned in GET requests if view=FULL is set.
        /// </summary>
        public InputList<Inputs.LibraryArgs> Libraries
        {
            get => _libraries ?? (_libraries = new InputList<Inputs.LibraryArgs>());
            set => _libraries = value;
        }

        /// <summary>
        /// Configures liveness health checking for instances. Unhealthy instances are stopped and replaced with new instancesOnly returned in GET requests if view=FULL is set.
        /// </summary>
        [Input("livenessCheck")]
        public Input<Inputs.LivenessCheckArgs>? LivenessCheck { get; set; }

        /// <summary>
        /// A service with manual scaling runs continuously, allowing you to perform complex initialization and rely on the state of its memory over time. Manually scaled versions are sometimes referred to as "backends".
        /// </summary>
        [Input("manualScaling")]
        public Input<Inputs.ManualScalingArgs>? ManualScaling { get; set; }

        /// <summary>
        /// Full path to the Version resource in the API. Example: apps/myapp/services/default/versions/v1.@OutputOnly
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Extra network settings. Only applicable in the App Engine flexible environment.
        /// </summary>
        [Input("network")]
        public Input<Inputs.NetworkArgs>? Network { get; set; }

        /// <summary>
        /// Files that match this pattern will not be built into this version. Only applicable for Go runtimes.Only returned in GET requests if view=FULL is set.
        /// </summary>
        [Input("nobuildFilesRegex")]
        public Input<string>? NobuildFilesRegex { get; set; }

        /// <summary>
        /// Configures readiness health checking for instances. Unhealthy instances are not put into the backend traffic rotation.Only returned in GET requests if view=FULL is set.
        /// </summary>
        [Input("readinessCheck")]
        public Input<Inputs.ReadinessCheckArgs>? ReadinessCheck { get; set; }

        /// <summary>
        /// Machine resources for this version. Only applicable in the App Engine flexible environment.
        /// </summary>
        [Input("resources")]
        public Input<Inputs.ResourcesArgs>? Resources { get; set; }

        /// <summary>
        /// Desired runtime. Example: python27.
        /// </summary>
        [Input("runtime")]
        public Input<string>? Runtime { get; set; }

        /// <summary>
        /// The version of the API in the given runtime environment. Please see the app.yaml reference for valid values at https://cloud.google.com/appengine/docs/standard//config/appref
        /// </summary>
        [Input("runtimeApiVersion")]
        public Input<string>? RuntimeApiVersion { get; set; }

        /// <summary>
        /// The channel of the runtime to use. Only available for some runtimes. Defaults to the default channel.
        /// </summary>
        [Input("runtimeChannel")]
        public Input<string>? RuntimeChannel { get; set; }

        /// <summary>
        /// The path or name of the app's main executable.
        /// </summary>
        [Input("runtimeMainExecutablePath")]
        public Input<string>? RuntimeMainExecutablePath { get; set; }

        /// <summary>
        /// The identity that the deployed version will run as. Admin API will use the App Engine Appspot service account as default if this field is neither provided in app.yaml file nor through CLI flag.
        /// </summary>
        [Input("serviceAccount")]
        public Input<string>? ServiceAccount { get; set; }

        /// <summary>
        /// Part of `parent`. See documentation of `appsId`.
        /// </summary>
        [Input("servicesId", required: true)]
        public Input<string> ServicesId { get; set; } = null!;

        /// <summary>
        /// Current serving status of this version. Only the versions with a SERVING status create instances and can be billed.SERVING_STATUS_UNSPECIFIED is an invalid value. Defaults to SERVING.
        /// </summary>
        [Input("servingStatus")]
        public Input<string>? ServingStatus { get; set; }

        /// <summary>
        /// Whether multiple requests can be dispatched to this version at once.
        /// </summary>
        [Input("threadsafe")]
        public Input<bool>? Threadsafe { get; set; }

        /// <summary>
        /// Serving URL for this version. Example: "https://myversion-dot-myservice-dot-myapp.appspot.com"@OutputOnly
        /// </summary>
        [Input("versionUrl")]
        public Input<string>? VersionUrl { get; set; }

        /// <summary>
        /// Whether to deploy this version in a container on a virtual machine.
        /// </summary>
        [Input("vm")]
        public Input<bool>? Vm { get; set; }

        /// <summary>
        /// Enables VPC connectivity for standard apps.
        /// </summary>
        [Input("vpcAccessConnector")]
        public Input<Inputs.VpcAccessConnectorArgs>? VpcAccessConnector { get; set; }

        [Input("zones")]
        private InputList<string>? _zones;

        /// <summary>
        /// The Google Compute Engine zones that are supported by this version in the App Engine flexible environment. Deprecated.
        /// </summary>
        public InputList<string> Zones
        {
            get => _zones ?? (_zones = new InputList<string>());
            set => _zones = value;
        }

        public VersionArgs()
        {
        }
    }
}