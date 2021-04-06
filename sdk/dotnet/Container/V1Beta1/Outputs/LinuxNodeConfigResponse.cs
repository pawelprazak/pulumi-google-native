// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.Container.V1Beta1.Outputs
{

    [OutputType]
    public sealed class LinuxNodeConfigResponse
    {
        /// <summary>
        /// The Linux kernel parameters to be applied to the nodes and all pods running on the nodes. The following parameters are supported. net.core.netdev_max_backlog net.core.rmem_max net.core.wmem_default net.core.wmem_max net.core.optmem_max net.core.somaxconn net.ipv4.tcp_rmem net.ipv4.tcp_wmem net.ipv4.tcp_tw_reuse
        /// </summary>
        public readonly ImmutableDictionary<string, string> Sysctls;

        [OutputConstructor]
        private LinuxNodeConfigResponse(ImmutableDictionary<string, string> sysctls)
        {
            Sysctls = sysctls;
        }
    }
}