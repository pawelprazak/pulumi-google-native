// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.Spanner.V1
{
    /// <summary>
    /// Creates a new session. A session can be used to perform transactions that read and/or modify data in a Cloud Spanner database. Sessions are meant to be reused for many consecutive transactions. Sessions can only execute one transaction at a time. To execute multiple concurrent read-write/write-only transactions, create multiple sessions. Note that standalone reads and queries use a transaction internally, and count toward the one transaction limit. Active sessions use additional server resources, so it is a good idea to delete idle and unneeded sessions. Aside from explicit deletes, Cloud Spanner may delete sessions for which no operations are sent for more than an hour. If a session is deleted, requests to it return `NOT_FOUND`. Idle sessions can be kept alive by sending a trivial SQL query periodically, e.g., `"SELECT 1"`.
    /// </summary>
    [GoogleCloudResourceType("google-cloud:spanner/v1:Session")]
    public partial class Session : Pulumi.CustomResource
    {
        /// <summary>
        /// Create a Session resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Session(string name, SessionArgs args, CustomResourceOptions? options = null)
            : base("google-cloud:spanner/v1:Session", name, args ?? new SessionArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Session(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("google-cloud:spanner/v1:Session", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Session resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Session Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Session(name, id, options);
        }
    }

    public sealed class SessionArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Required. The database in which the new session is created.
        /// </summary>
        [Input("database", required: true)]
        public Input<string> Database { get; set; } = null!;

        /// <summary>
        /// Required. The session to create.
        /// </summary>
        [Input("session")]
        public Input<Inputs.SessionArgs>? Session { get; set; }

        public SessionArgs()
        {
        }
    }
}