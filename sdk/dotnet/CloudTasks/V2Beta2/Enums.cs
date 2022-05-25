// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.ComponentModel;
using Pulumi;

namespace Pulumi.GoogleNative.CloudTasks.V2Beta2
{
    /// <summary>
    /// The HTTP method to use for the request. The default is POST. The app's request handler for the task's target URL must be able to handle HTTP requests with this http_method, otherwise the task attempt fails with error code 405 (Method Not Allowed). See [Writing a push task request handler](https://cloud.google.com/appengine/docs/java/taskqueue/push/creating-handlers#writing_a_push_task_request_handler) and the App Engine documentation for your runtime on [How Requests are Handled](https://cloud.google.com/appengine/docs/standard/python3/how-requests-are-handled).
    /// </summary>
    [EnumType]
    public readonly struct AppEngineHttpRequestHttpMethod : IEquatable<AppEngineHttpRequestHttpMethod>
    {
        private readonly string _value;

        private AppEngineHttpRequestHttpMethod(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// HTTP method unspecified
        /// </summary>
        public static AppEngineHttpRequestHttpMethod HttpMethodUnspecified { get; } = new AppEngineHttpRequestHttpMethod("HTTP_METHOD_UNSPECIFIED");
        /// <summary>
        /// HTTP POST
        /// </summary>
        public static AppEngineHttpRequestHttpMethod Post { get; } = new AppEngineHttpRequestHttpMethod("POST");
        /// <summary>
        /// HTTP GET
        /// </summary>
        public static AppEngineHttpRequestHttpMethod Get { get; } = new AppEngineHttpRequestHttpMethod("GET");
        /// <summary>
        /// HTTP HEAD
        /// </summary>
        public static AppEngineHttpRequestHttpMethod Head { get; } = new AppEngineHttpRequestHttpMethod("HEAD");
        /// <summary>
        /// HTTP PUT
        /// </summary>
        public static AppEngineHttpRequestHttpMethod Put { get; } = new AppEngineHttpRequestHttpMethod("PUT");
        /// <summary>
        /// HTTP DELETE
        /// </summary>
        public static AppEngineHttpRequestHttpMethod Delete { get; } = new AppEngineHttpRequestHttpMethod("DELETE");

        public static bool operator ==(AppEngineHttpRequestHttpMethod left, AppEngineHttpRequestHttpMethod right) => left.Equals(right);
        public static bool operator !=(AppEngineHttpRequestHttpMethod left, AppEngineHttpRequestHttpMethod right) => !left.Equals(right);

        public static explicit operator string(AppEngineHttpRequestHttpMethod value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is AppEngineHttpRequestHttpMethod other && Equals(other);
        public bool Equals(AppEngineHttpRequestHttpMethod other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// The response_view specifies which subset of the Task will be returned. By default response_view is BASIC; not all information is retrieved by default because some data, such as payloads, might be desirable to return only when needed because of its large size or because of the sensitivity of data that it contains. Authorization for FULL requires `cloudtasks.tasks.fullView` [Google IAM](https://cloud.google.com/iam/) permission on the Task resource.
    /// </summary>
    [EnumType]
    public readonly struct TaskResponseView : IEquatable<TaskResponseView>
    {
        private readonly string _value;

        private TaskResponseView(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Unspecified. Defaults to BASIC.
        /// </summary>
        public static TaskResponseView ViewUnspecified { get; } = new TaskResponseView("VIEW_UNSPECIFIED");
        /// <summary>
        /// The basic view omits fields which can be large or can contain sensitive data. This view does not include the (payload in AppEngineHttpRequest and payload in PullMessage). These payloads are desirable to return only when needed, because they can be large and because of the sensitivity of the data that you choose to store in it.
        /// </summary>
        public static TaskResponseView Basic { get; } = new TaskResponseView("BASIC");
        /// <summary>
        /// All information is returned. Authorization for FULL requires `cloudtasks.tasks.fullView` [Google IAM](https://cloud.google.com/iam/) permission on the Queue resource.
        /// </summary>
        public static TaskResponseView Full { get; } = new TaskResponseView("FULL");

        public static bool operator ==(TaskResponseView left, TaskResponseView right) => left.Equals(right);
        public static bool operator !=(TaskResponseView left, TaskResponseView right) => !left.Equals(right);

        public static explicit operator string(TaskResponseView value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is TaskResponseView other && Equals(other);
        public bool Equals(TaskResponseView other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }
}