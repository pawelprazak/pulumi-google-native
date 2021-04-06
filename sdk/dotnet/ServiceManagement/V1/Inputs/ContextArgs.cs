// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.ServiceManagement.V1.Inputs
{

    /// <summary>
    /// `Context` defines which contexts an API requests. Example: context: rules: - selector: "*" requested: - google.rpc.context.ProjectContext - google.rpc.context.OriginContext The above specifies that all methods in the API request `google.rpc.context.ProjectContext` and `google.rpc.context.OriginContext`. Available context types are defined in package `google.rpc.context`. This also provides mechanism to allowlist any protobuf message extension that can be sent in grpc metadata using “x-goog-ext--bin” and “x-goog-ext--jspb” format. For example, list any service specific protobuf types that can appear in grpc metadata as follows in your yaml file: Example: context: rules: - selector: "google.example.library.v1.LibraryService.CreateBook" allowed_request_extensions: - google.foo.v1.NewExtension allowed_response_extensions: - google.foo.v1.NewExtension You can also specify extension ID instead of fully qualified extension name here.
    /// </summary>
    public sealed class ContextArgs : Pulumi.ResourceArgs
    {
        [Input("rules")]
        private InputList<Inputs.ContextRuleArgs>? _rules;

        /// <summary>
        /// A list of RPC context rules that apply to individual API methods. **NOTE:** All service configuration rules follow "last one wins" order.
        /// </summary>
        public InputList<Inputs.ContextRuleArgs> Rules
        {
            get => _rules ?? (_rules = new InputList<Inputs.ContextRuleArgs>());
            set => _rules = value;
        }

        public ContextArgs()
        {
        }
    }
}