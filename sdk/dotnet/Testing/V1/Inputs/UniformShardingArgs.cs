// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.Testing.V1.Inputs
{

    /// <summary>
    /// Uniformly shards test cases given a total number of shards. For Instrumentation test, it will be translated to "-e numShard" "-e shardIndex" AndroidJUnitRunner arguments. Based on the sharding mechanism AndroidJUnitRunner uses, there is no guarantee that test cases will be distributed uniformly across all shards. With uniform sharding enabled, specifying these sharding arguments via environment_variables is invalid.
    /// </summary>
    public sealed class UniformShardingArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Total number of shards. When any physical devices are selected, the number must be &gt;= 1 and &lt;= 50. When no physical devices are selected, the number must be &gt;= 1 and &lt;= 500.
        /// </summary>
        [Input("numShards", required: true)]
        public Input<int> NumShards { get; set; } = null!;

        public UniformShardingArgs()
        {
        }
    }
}
