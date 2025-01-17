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
    /// A test of an iOS application that uses the XCTest framework. Xcode supports the option to "build for testing", which generates an .xctestrun file that contains a test specification (arguments, test methods, etc). This test type accepts a zip file containing the .xctestrun file and the corresponding contents of the Build/Products directory that contains all the binaries needed to run the tests.
    /// </summary>
    public sealed class IosXcTestArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The option to test special app entitlements. Setting this would re-sign the app having special entitlements with an explicit application-identifier. Currently supports testing aps-environment entitlement.
        /// </summary>
        [Input("testSpecialEntitlements")]
        public Input<bool>? TestSpecialEntitlements { get; set; }

        /// <summary>
        /// The .zip containing the .xctestrun file and the contents of the DerivedData/Build/Products directory. The .xctestrun file in this zip is ignored if the xctestrun field is specified.
        /// </summary>
        [Input("testsZip", required: true)]
        public Input<Inputs.FileReferenceArgs> TestsZip { get; set; } = null!;

        /// <summary>
        /// The Xcode version that should be used for the test. Use the TestEnvironmentDiscoveryService to get supported options. Defaults to the latest Xcode version Firebase Test Lab supports.
        /// </summary>
        [Input("xcodeVersion")]
        public Input<string>? XcodeVersion { get; set; }

        /// <summary>
        /// An .xctestrun file that will override the .xctestrun file in the tests zip. Because the .xctestrun file contains environment variables along with test methods to run and/or ignore, this can be useful for sharding tests. Default is taken from the tests zip.
        /// </summary>
        [Input("xctestrun")]
        public Input<Inputs.FileReferenceArgs>? Xctestrun { get; set; }

        public IosXcTestArgs()
        {
        }
    }
}
