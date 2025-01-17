// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.Compute.Alpha.Inputs
{

    public sealed class SecurityPolicyAssociationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The resource that the security policy is attached to.
        /// </summary>
        [Input("attachmentId")]
        public Input<string>? AttachmentId { get; set; }

        /// <summary>
        /// The name for an association.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public SecurityPolicyAssociationArgs()
        {
        }
    }
}
