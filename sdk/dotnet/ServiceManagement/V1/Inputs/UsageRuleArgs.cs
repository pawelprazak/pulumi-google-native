// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.ServiceManagement.V1.Inputs
{

    /// <summary>
    /// Usage configuration rules for the service. NOTE: Under development. Use this rule to configure unregistered calls for the service. Unregistered calls are calls that do not contain consumer project identity. (Example: calls that do not contain an API key). By default, API methods do not allow unregistered calls, and each method call must be identified by a consumer project identity. Use this rule to allow/disallow unregistered calls. Example of an API that wants to allow unregistered calls for entire service. usage: rules: - selector: "*" allow_unregistered_calls: true Example of a method that wants to allow unregistered calls. usage: rules: - selector: "google.example.library.v1.LibraryService.CreateBook" allow_unregistered_calls: true
    /// </summary>
    public sealed class UsageRuleArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// If true, the selected method allows unregistered calls, e.g. calls that don't identify any user or application.
        /// </summary>
        [Input("allowUnregisteredCalls")]
        public Input<bool>? AllowUnregisteredCalls { get; set; }

        /// <summary>
        /// Selects the methods to which this rule applies. Use '*' to indicate all methods in all APIs. Refer to selector for syntax details.
        /// </summary>
        [Input("selector")]
        public Input<string>? Selector { get; set; }

        /// <summary>
        /// If true, the selected method should skip service control and the control plane features, such as quota and billing, will not be available. This flag is used by Google Cloud Endpoints to bypass checks for internal methods, such as service health check methods.
        /// </summary>
        [Input("skipServiceControl")]
        public Input<bool>? SkipServiceControl { get; set; }

        public UsageRuleArgs()
        {
        }
    }
}
