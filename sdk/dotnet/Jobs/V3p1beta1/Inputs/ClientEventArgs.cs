// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.Jobs.V3p1beta1.Inputs
{

    /// <summary>
    /// An event issued when an end user interacts with the application that implements Cloud Talent Solution. Providing this information improves the quality of search and recommendation for the API clients, enabling the service to perform optimally. The number of events sent must be consistent with other calls, such as job searches, issued to the service by the client.
    /// </summary>
    public sealed class ClientEventArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Required. The timestamp of the event.
        /// </summary>
        [Input("createTime")]
        public Input<string>? CreateTime { get; set; }

        /// <summary>
        /// Required. A unique identifier, generated by the client application. This `event_id` is used to establish the relationship between different events (see parent_event_id).
        /// </summary>
        [Input("eventId")]
        public Input<string>? EventId { get; set; }

        [Input("extraInfo")]
        private InputMap<string>? _extraInfo;

        /// <summary>
        /// Optional. Extra information about this event. Used for storing information with no matching field in event payload, for example, user application specific context or details. At most 20 keys are supported. The maximum total size of all keys and values is 2 KB.
        /// </summary>
        public InputMap<string> ExtraInfo
        {
            get => _extraInfo ?? (_extraInfo = new InputMap<string>());
            set => _extraInfo = value;
        }

        /// <summary>
        /// A event issued when a job seeker interacts with the application that implements Cloud Talent Solution.
        /// </summary>
        [Input("jobEvent")]
        public Input<Inputs.JobEventArgs>? JobEvent { get; set; }

        /// <summary>
        /// Optional. The event_id of an event that resulted in the current event. For example, a Job view event usually follows a parent impression event: A job seeker first does a search where a list of jobs appears (impression). The job seeker then selects a result and views the description of a particular job (Job view).
        /// </summary>
        [Input("parentEventId")]
        public Input<string>? ParentEventId { get; set; }

        /// <summary>
        /// Required. A unique ID generated in the API responses. It can be found in ResponseMetadata.request_id.
        /// </summary>
        [Input("requestId")]
        public Input<string>? RequestId { get; set; }

        public ClientEventArgs()
        {
        }
    }
}