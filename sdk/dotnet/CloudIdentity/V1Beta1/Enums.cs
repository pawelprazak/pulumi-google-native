// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.ComponentModel;
using Pulumi;

namespace Pulumi.GoogleNative.CloudIdentity.V1Beta1
{
    [EnumType]
    public readonly struct DynamicGroupQueryResourceType : IEquatable<DynamicGroupQueryResourceType>
    {
        private readonly string _value;

        private DynamicGroupQueryResourceType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Default value (not valid)
        /// </summary>
        public static DynamicGroupQueryResourceType ResourceTypeUnspecified { get; } = new DynamicGroupQueryResourceType("RESOURCE_TYPE_UNSPECIFIED");
        /// <summary>
        /// For queries on User
        /// </summary>
        public static DynamicGroupQueryResourceType User { get; } = new DynamicGroupQueryResourceType("USER");

        public static bool operator ==(DynamicGroupQueryResourceType left, DynamicGroupQueryResourceType right) => left.Equals(right);
        public static bool operator !=(DynamicGroupQueryResourceType left, DynamicGroupQueryResourceType right) => !left.Equals(right);

        public static explicit operator string(DynamicGroupQueryResourceType value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is DynamicGroupQueryResourceType other && Equals(other);
        public bool Equals(DynamicGroupQueryResourceType other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }
}
