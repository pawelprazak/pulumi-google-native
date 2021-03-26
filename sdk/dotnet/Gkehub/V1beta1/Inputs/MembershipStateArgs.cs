// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.Gkehub.V1beta1.Inputs
{

    /// <summary>
    /// State of the Membership resource.
    /// </summary>
    public sealed class MembershipStateArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Output only. The current state of the Membership resource.
        /// </summary>
        [Input("code")]
        public Input<string>? Code { get; set; }

        /// <summary>
        /// This field is never set by the Hub Service.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// This field is never set by the Hub Service.
        /// </summary>
        [Input("updateTime")]
        public Input<string>? UpdateTime { get; set; }

        public MembershipStateArgs()
        {
        }
    }
}