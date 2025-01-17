// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.Gkebackup.V1.Inputs
{

    /// <summary>
    /// Schedule defines scheduling parameters for automatically creating Backups via this BackupPlan.
    /// </summary>
    public sealed class ScheduleArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A standard [cron](https://wikipedia.com/wiki/cron) string that defines a repeating schedule for creating Backups via this BackupPlan. Default (empty): no automatic backup creation will occur.
        /// </summary>
        [Input("cronSchedule")]
        public Input<string>? CronSchedule { get; set; }

        /// <summary>
        /// This flag denotes whether automatic Backup creation is paused for this BackupPlan. Default: False
        /// </summary>
        [Input("paused")]
        public Input<bool>? Paused { get; set; }

        public ScheduleArgs()
        {
        }
    }
}
