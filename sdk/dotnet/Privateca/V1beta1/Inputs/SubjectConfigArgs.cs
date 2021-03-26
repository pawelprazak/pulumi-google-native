// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.Privateca.V1beta1.Inputs
{

    /// <summary>
    /// These values are used to create the distinguished name and subject alternative name fields in an X.509 certificate.
    /// </summary>
    public sealed class SubjectConfigArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Optional. The "common name" of the distinguished name.
        /// </summary>
        [Input("commonName")]
        public Input<string>? CommonName { get; set; }

        /// <summary>
        /// Required. Contains distinguished name fields such as the location and organization.
        /// </summary>
        [Input("subject")]
        public Input<Inputs.SubjectArgs>? Subject { get; set; }

        /// <summary>
        /// Optional. The subject alternative name fields.
        /// </summary>
        [Input("subjectAltName")]
        public Input<Inputs.SubjectAltNamesArgs>? SubjectAltName { get; set; }

        public SubjectConfigArgs()
        {
        }
    }
}