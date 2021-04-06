// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.Toolresults.V1beta3.Outputs
{

    [OutputType]
    public sealed class AndroidInstrumentationTestResponse
    {
        /// <summary>
        /// The java package for the test to be executed. Required
        /// </summary>
        public readonly string TestPackageId;
        /// <summary>
        /// The InstrumentationTestRunner class. Required
        /// </summary>
        public readonly string TestRunnerClass;
        /// <summary>
        /// Each target must be fully qualified with the package name or class name, in one of these formats: - "package package_name" - "class package_name.class_name" - "class package_name.class_name#method_name" If empty, all targets in the module will be run.
        /// </summary>
        public readonly ImmutableArray<string> TestTargets;
        /// <summary>
        /// The flag indicates whether Android Test Orchestrator will be used to run test or not.
        /// </summary>
        public readonly bool UseOrchestrator;

        [OutputConstructor]
        private AndroidInstrumentationTestResponse(
            string testPackageId,

            string testRunnerClass,

            ImmutableArray<string> testTargets,

            bool useOrchestrator)
        {
            TestPackageId = testPackageId;
            TestRunnerClass = testRunnerClass;
            TestTargets = testTargets;
            UseOrchestrator = useOrchestrator;
        }
    }
}