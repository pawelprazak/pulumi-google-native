// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.Dataproc.V1.Inputs
{

    /// <summary>
    /// A Dataproc job for running Apache Hadoop MapReduce (https://hadoop.apache.org/docs/current/hadoop-mapreduce-client/hadoop-mapreduce-client-core/MapReduceTutorial.html) jobs on Apache Hadoop YARN (https://hadoop.apache.org/docs/r2.7.1/hadoop-yarn/hadoop-yarn-site/YARN.html).
    /// </summary>
    public sealed class HadoopJobArgs : Pulumi.ResourceArgs
    {
        [Input("archiveUris")]
        private InputList<string>? _archiveUris;

        /// <summary>
        /// Optional. HCFS URIs of archives to be extracted in the working directory of Hadoop drivers and tasks. Supported file types: .jar, .tar, .tar.gz, .tgz, or .zip.
        /// </summary>
        public InputList<string> ArchiveUris
        {
            get => _archiveUris ?? (_archiveUris = new InputList<string>());
            set => _archiveUris = value;
        }

        [Input("args")]
        private InputList<string>? _args;

        /// <summary>
        /// Optional. The arguments to pass to the driver. Do not include arguments, such as -libjars or -Dfoo=bar, that can be set as job properties, since a collision may occur that causes an incorrect job submission.
        /// </summary>
        public InputList<string> Args
        {
            get => _args ?? (_args = new InputList<string>());
            set => _args = value;
        }

        [Input("fileUris")]
        private InputList<string>? _fileUris;

        /// <summary>
        /// Optional. HCFS (Hadoop Compatible Filesystem) URIs of files to be copied to the working directory of Hadoop drivers and distributed tasks. Useful for naively parallel tasks.
        /// </summary>
        public InputList<string> FileUris
        {
            get => _fileUris ?? (_fileUris = new InputList<string>());
            set => _fileUris = value;
        }

        [Input("jarFileUris")]
        private InputList<string>? _jarFileUris;

        /// <summary>
        /// Optional. Jar file URIs to add to the CLASSPATHs of the Hadoop driver and tasks.
        /// </summary>
        public InputList<string> JarFileUris
        {
            get => _jarFileUris ?? (_jarFileUris = new InputList<string>());
            set => _jarFileUris = value;
        }

        /// <summary>
        /// Optional. The runtime log config for job execution.
        /// </summary>
        [Input("loggingConfig")]
        public Input<Inputs.LoggingConfigArgs>? LoggingConfig { get; set; }

        /// <summary>
        /// The name of the driver's main class. The jar file containing the class must be in the default CLASSPATH or specified in jar_file_uris.
        /// </summary>
        [Input("mainClass")]
        public Input<string>? MainClass { get; set; }

        /// <summary>
        /// The HCFS URI of the jar file containing the main class. Examples: 'gs://foo-bucket/analytics-binaries/extract-useful-metrics-mr.jar' 'hdfs:/tmp/test-samples/custom-wordcount.jar' 'file:///home/usr/lib/hadoop-mapreduce/hadoop-mapreduce-examples.jar'
        /// </summary>
        [Input("mainJarFileUri")]
        public Input<string>? MainJarFileUri { get; set; }

        [Input("properties")]
        private InputMap<string>? _properties;

        /// <summary>
        /// Optional. A mapping of property names to values, used to configure Hadoop. Properties that conflict with values set by the Dataproc API may be overwritten. Can include properties set in /etc/hadoop/conf/*-site and classes in user code.
        /// </summary>
        public InputMap<string> Properties
        {
            get => _properties ?? (_properties = new InputMap<string>());
            set => _properties = value;
        }

        public HadoopJobArgs()
        {
        }
    }
}