// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.ComponentModel;
using Pulumi;

namespace Pulumi.GoogleNative.CloudBuild.V1Alpha1
{
    [EnumType]
    public readonly struct WorkerPoolRegionsItem : IEquatable<WorkerPoolRegionsItem>
    {
        private readonly string _value;

        private WorkerPoolRegionsItem(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// no region
        /// </summary>
        public static WorkerPoolRegionsItem RegionUnspecified { get; } = new WorkerPoolRegionsItem("REGION_UNSPECIFIED");
        /// <summary>
        /// us-central1 region
        /// </summary>
        public static WorkerPoolRegionsItem UsCentral1 { get; } = new WorkerPoolRegionsItem("us-central1");
        /// <summary>
        /// us-west1 region
        /// </summary>
        public static WorkerPoolRegionsItem UsWest1 { get; } = new WorkerPoolRegionsItem("us-west1");
        /// <summary>
        /// us-east1 region
        /// </summary>
        public static WorkerPoolRegionsItem UsEast1 { get; } = new WorkerPoolRegionsItem("us-east1");
        /// <summary>
        /// us-east4 region
        /// </summary>
        public static WorkerPoolRegionsItem UsEast4 { get; } = new WorkerPoolRegionsItem("us-east4");

        public static bool operator ==(WorkerPoolRegionsItem left, WorkerPoolRegionsItem right) => left.Equals(right);
        public static bool operator !=(WorkerPoolRegionsItem left, WorkerPoolRegionsItem right) => !left.Equals(right);

        public static explicit operator string(WorkerPoolRegionsItem value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is WorkerPoolRegionsItem other && Equals(other);
        public bool Equals(WorkerPoolRegionsItem other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }
}