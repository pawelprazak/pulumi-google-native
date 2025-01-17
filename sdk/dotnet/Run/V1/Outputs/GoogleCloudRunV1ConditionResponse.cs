// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.Run.V1.Outputs
{

    /// <summary>
    /// Condition defines a generic condition for a Resource.
    /// </summary>
    [OutputType]
    public sealed class GoogleCloudRunV1ConditionResponse
    {
        /// <summary>
        /// Optional. Last time the condition transitioned from one status to another.
        /// </summary>
        public readonly string LastTransitionTime;
        /// <summary>
        /// Optional. Human readable message indicating details about the current status.
        /// </summary>
        public readonly string Message;
        /// <summary>
        /// Optional. One-word CamelCase reason for the condition's last transition.
        /// </summary>
        public readonly string Reason;
        /// <summary>
        /// Optional. How to interpret failures of this condition, one of Error, Warning, Info
        /// </summary>
        public readonly string Severity;
        /// <summary>
        /// Status of the condition, one of True, False, Unknown.
        /// </summary>
        public readonly string Status;
        /// <summary>
        /// type is used to communicate the status of the reconciliation process. See also: https://github.com/knative/serving/blob/main/docs/spec/errors.md#error-conditions-and-reporting Types common to all resources include: * "Ready": True when the Resource is ready.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GoogleCloudRunV1ConditionResponse(
            string lastTransitionTime,

            string message,

            string reason,

            string severity,

            string status,

            string type)
        {
            LastTransitionTime = lastTransitionTime;
            Message = message;
            Reason = reason;
            Severity = severity;
            Status = status;
            Type = type;
        }
    }
}
