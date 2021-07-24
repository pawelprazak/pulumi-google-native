// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.CloudBuild.V1.Outputs
{

    [OutputType]
    public sealed class PoolOptionResponse
    {
        /// <summary>
        /// The `WorkerPool` resource to execute the build on. You must have `cloudbuild.workerpools.use` on the project hosting the WorkerPool. Format projects/{project}/locations/{location}/workerPools/{workerPoolId}
        /// </summary>
        public readonly string Name;

        [OutputConstructor]
        private PoolOptionResponse(string name)
        {
            Name = name;
        }
    }
}