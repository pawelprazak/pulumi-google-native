// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.SQLAdmin.V1Beta4.Inputs
{

    /// <summary>
    /// Disk encryption status for an instance.
    /// </summary>
    public sealed class DiskEncryptionStatusArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// This is always `sql#diskEncryptionStatus`.
        /// </summary>
        [Input("kind")]
        public Input<string>? Kind { get; set; }

        /// <summary>
        /// KMS key version used to encrypt the Cloud SQL instance resource
        /// </summary>
        [Input("kmsKeyVersionName")]
        public Input<string>? KmsKeyVersionName { get; set; }

        public DiskEncryptionStatusArgs()
        {
        }
    }
}
