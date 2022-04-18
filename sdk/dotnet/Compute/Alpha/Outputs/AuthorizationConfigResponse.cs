// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.Compute.Alpha.Outputs
{

    /// <summary>
    /// [Deprecated] Authorization configuration provides service-level and method-level access control for a service. control for a service.
    /// </summary>
    [OutputType]
    public sealed class AuthorizationConfigResponse
    {
        /// <summary>
        /// List of RbacPolicies.
        /// </summary>
        public readonly ImmutableArray<Outputs.RbacPolicyResponse> Policies;

        [OutputConstructor]
        private AuthorizationConfigResponse(ImmutableArray<Outputs.RbacPolicyResponse> policies)
        {
            Policies = policies;
        }
    }
}