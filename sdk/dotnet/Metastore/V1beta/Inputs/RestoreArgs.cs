// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.Metastore.V1beta.Inputs
{

    /// <summary>
    /// The details of a metadata restore operation.
    /// </summary>
    public sealed class RestoreArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Output only. The relative resource name of the metastore service backup to restore from, in the following form:projects/{project_id}/locations/{location_id}/services/{service_id}/backups/{backup_id}
        /// </summary>
        [Input("backup")]
        public Input<string>? Backup { get; set; }

        /// <summary>
        /// Output only. The restore details containing the revision of the service to be restored to, in format of JSON.
        /// </summary>
        [Input("details")]
        public Input<string>? Details { get; set; }

        /// <summary>
        /// Output only. The time when the restore ended.
        /// </summary>
        [Input("endTime")]
        public Input<string>? EndTime { get; set; }

        /// <summary>
        /// Output only. The time when the restore started.
        /// </summary>
        [Input("startTime")]
        public Input<string>? StartTime { get; set; }

        /// <summary>
        /// Output only. The current state of the restore.
        /// </summary>
        [Input("state")]
        public Input<string>? State { get; set; }

        /// <summary>
        /// Output only. The type of restore.
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        public RestoreArgs()
        {
        }
    }
}