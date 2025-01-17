// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.OSConfig.V1.Outputs
{

    /// <summary>
    /// Yum patching is performed by executing `yum update`. Additional options can be set to control how this is executed. Note that not all settings are supported on all platforms.
    /// </summary>
    [OutputType]
    public sealed class YumSettingsResponse
    {
        /// <summary>
        /// List of packages to exclude from update. These packages are excluded by using the yum `--exclude` flag.
        /// </summary>
        public readonly ImmutableArray<string> Excludes;
        /// <summary>
        /// An exclusive list of packages to be updated. These are the only packages that will be updated. If these packages are not installed, they will be ignored. This field must not be specified with any other patch configuration fields.
        /// </summary>
        public readonly ImmutableArray<string> ExclusivePackages;
        /// <summary>
        /// Will cause patch to run `yum update-minimal` instead.
        /// </summary>
        public readonly bool Minimal;
        /// <summary>
        /// Adds the `--security` flag to `yum update`. Not supported on all platforms.
        /// </summary>
        public readonly bool Security;

        [OutputConstructor]
        private YumSettingsResponse(
            ImmutableArray<string> excludes,

            ImmutableArray<string> exclusivePackages,

            bool minimal,

            bool security)
        {
            Excludes = excludes;
            ExclusivePackages = exclusivePackages;
            Minimal = minimal;
            Security = security;
        }
    }
}
