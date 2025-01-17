// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.Notebooks.V1.Inputs
{

    /// <summary>
    /// Specifies the selection and configuration of software inside the runtime. The properties to set on runtime. Properties keys are specified in `key:value` format, for example: * `idle_shutdown: true` * `idle_shutdown_timeout: 180` * `enable_health_monitoring: true`
    /// </summary>
    public sealed class RuntimeSoftwareConfigArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specify a custom Cloud Storage path where the GPU driver is stored. If not specified, we'll automatically choose from official GPU drivers.
        /// </summary>
        [Input("customGpuDriverPath")]
        public Input<string>? CustomGpuDriverPath { get; set; }

        /// <summary>
        /// Verifies core internal services are running. Default: True
        /// </summary>
        [Input("enableHealthMonitoring")]
        public Input<bool>? EnableHealthMonitoring { get; set; }

        /// <summary>
        /// Runtime will automatically shutdown after idle_shutdown_time. Default: True
        /// </summary>
        [Input("idleShutdown")]
        public Input<bool>? IdleShutdown { get; set; }

        /// <summary>
        /// Time in minutes to wait before shutting down runtime. Default: 180 minutes
        /// </summary>
        [Input("idleShutdownTimeout")]
        public Input<int>? IdleShutdownTimeout { get; set; }

        /// <summary>
        /// Install Nvidia Driver automatically. Default: True
        /// </summary>
        [Input("installGpuDriver")]
        public Input<bool>? InstallGpuDriver { get; set; }

        [Input("kernels")]
        private InputList<Inputs.ContainerImageArgs>? _kernels;

        /// <summary>
        /// Optional. Use a list of container images to use as Kernels in the notebook instance.
        /// </summary>
        public InputList<Inputs.ContainerImageArgs> Kernels
        {
            get => _kernels ?? (_kernels = new InputList<Inputs.ContainerImageArgs>());
            set => _kernels = value;
        }

        /// <summary>
        /// Cron expression in UTC timezone, used to schedule instance auto upgrade. Please follow the [cron format](https://en.wikipedia.org/wiki/Cron).
        /// </summary>
        [Input("notebookUpgradeSchedule")]
        public Input<string>? NotebookUpgradeSchedule { get; set; }

        /// <summary>
        /// Path to a Bash script that automatically runs after a notebook instance fully boots up. The path must be a URL or Cloud Storage path (`gs://path-to-file/file-name`).
        /// </summary>
        [Input("postStartupScript")]
        public Input<string>? PostStartupScript { get; set; }

        /// <summary>
        /// Behavior for the post startup script.
        /// </summary>
        [Input("postStartupScriptBehavior")]
        public Input<Pulumi.GoogleNative.Notebooks.V1.RuntimeSoftwareConfigPostStartupScriptBehavior>? PostStartupScriptBehavior { get; set; }

        public RuntimeSoftwareConfigArgs()
        {
        }
    }
}
