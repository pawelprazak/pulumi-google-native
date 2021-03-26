// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.Redis.V1.Inputs
{

    /// <summary>
    /// TlsCertificate Resource
    /// </summary>
    public sealed class TlsCertificateArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// PEM representation.
        /// </summary>
        [Input("cert")]
        public Input<string>? Cert { get; set; }

        /// <summary>
        /// Output only. The time when the certificate was created in [RFC 3339](https://tools.ietf.org/html/rfc3339) format, for example `2020-05-18T00:00:00.094Z`.
        /// </summary>
        [Input("createTime")]
        public Input<string>? CreateTime { get; set; }

        /// <summary>
        /// Output only. The time when the certificate expires in [RFC 3339](https://tools.ietf.org/html/rfc3339) format, for example `2020-05-18T00:00:00.094Z`.
        /// </summary>
        [Input("expireTime")]
        public Input<string>? ExpireTime { get; set; }

        /// <summary>
        /// Serial number, as extracted from the certificate.
        /// </summary>
        [Input("serialNumber")]
        public Input<string>? SerialNumber { get; set; }

        /// <summary>
        /// Sha1 Fingerprint of the certificate.
        /// </summary>
        [Input("sha1Fingerprint")]
        public Input<string>? Sha1Fingerprint { get; set; }

        public TlsCertificateArgs()
        {
        }
    }
}