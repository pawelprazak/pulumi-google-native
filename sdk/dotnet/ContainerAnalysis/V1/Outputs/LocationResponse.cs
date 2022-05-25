// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.ContainerAnalysis.V1.Outputs
{

    /// <summary>
    /// An occurrence of a particular package installation found within a system's filesystem. E.g., glibc was found in `/var/lib/dpkg/status`.
    /// </summary>
    [OutputType]
    public sealed class LocationResponse
    {
        /// <summary>
        /// Deprecated. The CPE URI in [CPE format](https://cpe.mitre.org/specification/)
        /// </summary>
        public readonly string CpeUri;
        /// <summary>
        /// The path from which we gathered that this package/version is installed.
        /// </summary>
        public readonly string Path;
        /// <summary>
        /// Deprecated. The version installed at this location.
        /// </summary>
        public readonly Outputs.VersionResponse Version;

        [OutputConstructor]
        private LocationResponse(
            string cpeUri,

            string path,

            Outputs.VersionResponse version)
        {
            CpeUri = cpeUri;
            Path = path;
            Version = version;
        }
    }
}