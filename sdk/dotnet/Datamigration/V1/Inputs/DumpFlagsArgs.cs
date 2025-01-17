// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.Datamigration.V1.Inputs
{

    /// <summary>
    /// Dump flags definition.
    /// </summary>
    public sealed class DumpFlagsArgs : Pulumi.ResourceArgs
    {
        [Input("dumpFlags")]
        private InputList<Inputs.DumpFlagArgs>? _dumpFlags;

        /// <summary>
        /// The flags for the initial dump.
        /// </summary>
        public InputList<Inputs.DumpFlagArgs> DumpFlags
        {
            get => _dumpFlags ?? (_dumpFlags = new InputList<Inputs.DumpFlagArgs>());
            set => _dumpFlags = value;
        }

        public DumpFlagsArgs()
        {
        }
    }
}
