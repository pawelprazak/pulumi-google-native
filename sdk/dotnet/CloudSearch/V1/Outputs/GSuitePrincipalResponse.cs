// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.CloudSearch.V1.Outputs
{

    [OutputType]
    public sealed class GSuitePrincipalResponse
    {
        /// <summary>
        /// This principal represents all users of the G Suite domain of the customer.
        /// </summary>
        public readonly bool GsuiteDomain;
        /// <summary>
        /// This principal references a G Suite group account
        /// </summary>
        public readonly string GsuiteGroupEmail;
        /// <summary>
        /// This principal references a G Suite user account
        /// </summary>
        public readonly string GsuiteUserEmail;

        [OutputConstructor]
        private GSuitePrincipalResponse(
            bool gsuiteDomain,

            string gsuiteGroupEmail,

            string gsuiteUserEmail)
        {
            GsuiteDomain = gsuiteDomain;
            GsuiteGroupEmail = gsuiteGroupEmail;
            GsuiteUserEmail = gsuiteUserEmail;
        }
    }
}
