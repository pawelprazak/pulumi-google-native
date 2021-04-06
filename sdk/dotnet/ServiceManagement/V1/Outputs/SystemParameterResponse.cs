// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.ServiceManagement.V1.Outputs
{

    [OutputType]
    public sealed class SystemParameterResponse
    {
        /// <summary>
        /// Define the HTTP header name to use for the parameter. It is case insensitive.
        /// </summary>
        public readonly string HttpHeader;
        /// <summary>
        /// Define the name of the parameter, such as "api_key" . It is case sensitive.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Define the URL query parameter name to use for the parameter. It is case sensitive.
        /// </summary>
        public readonly string UrlQueryParameter;

        [OutputConstructor]
        private SystemParameterResponse(
            string httpHeader,

            string name,

            string urlQueryParameter)
        {
            HttpHeader = httpHeader;
            Name = name;
            UrlQueryParameter = urlQueryParameter;
        }
    }
}