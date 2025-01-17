// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.AppEngine.V1Beta.Inputs
{

    /// <summary>
    /// Google Cloud Endpoints (https://cloud.google.com/appengine/docs/python/endpoints/) configuration for API handlers.
    /// </summary>
    public sealed class ApiConfigHandlerArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Action to take when users access resources that require authentication. Defaults to redirect.
        /// </summary>
        [Input("authFailAction")]
        public Input<Pulumi.GoogleNative.AppEngine.V1Beta.ApiConfigHandlerAuthFailAction>? AuthFailAction { get; set; }

        /// <summary>
        /// Level of login required to access this resource. Defaults to optional.
        /// </summary>
        [Input("login")]
        public Input<Pulumi.GoogleNative.AppEngine.V1Beta.ApiConfigHandlerLogin>? Login { get; set; }

        /// <summary>
        /// Path to the script from the application root directory.
        /// </summary>
        [Input("script")]
        public Input<string>? Script { get; set; }

        /// <summary>
        /// Security (HTTPS) enforcement for this URL.
        /// </summary>
        [Input("securityLevel")]
        public Input<Pulumi.GoogleNative.AppEngine.V1Beta.ApiConfigHandlerSecurityLevel>? SecurityLevel { get; set; }

        /// <summary>
        /// URL to serve the endpoint at.
        /// </summary>
        [Input("url")]
        public Input<string>? Url { get; set; }

        public ApiConfigHandlerArgs()
        {
        }
    }
}
