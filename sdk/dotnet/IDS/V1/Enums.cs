// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.ComponentModel;
using Pulumi;

namespace Pulumi.GoogleNative.IDS.V1
{
    /// <summary>
    /// The log type that this config enables.
    /// </summary>
    [EnumType]
    public readonly struct AuditLogConfigLogType : IEquatable<AuditLogConfigLogType>
    {
        private readonly string _value;

        private AuditLogConfigLogType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Default case. Should never be this.
        /// </summary>
        public static AuditLogConfigLogType LogTypeUnspecified { get; } = new AuditLogConfigLogType("LOG_TYPE_UNSPECIFIED");
        /// <summary>
        /// Admin reads. Example: CloudIAM getIamPolicy
        /// </summary>
        public static AuditLogConfigLogType AdminRead { get; } = new AuditLogConfigLogType("ADMIN_READ");
        /// <summary>
        /// Data writes. Example: CloudSQL Users create
        /// </summary>
        public static AuditLogConfigLogType DataWrite { get; } = new AuditLogConfigLogType("DATA_WRITE");
        /// <summary>
        /// Data reads. Example: CloudSQL Users list
        /// </summary>
        public static AuditLogConfigLogType DataRead { get; } = new AuditLogConfigLogType("DATA_READ");

        public static bool operator ==(AuditLogConfigLogType left, AuditLogConfigLogType right) => left.Equals(right);
        public static bool operator !=(AuditLogConfigLogType left, AuditLogConfigLogType right) => !left.Equals(right);

        public static explicit operator string(AuditLogConfigLogType value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is AuditLogConfigLogType other && Equals(other);
        public bool Equals(AuditLogConfigLogType other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Required. Lowest threat severity that this endpoint will alert on.
    /// </summary>
    [EnumType]
    public readonly struct EndpointSeverity : IEquatable<EndpointSeverity>
    {
        private readonly string _value;

        private EndpointSeverity(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Not set.
        /// </summary>
        public static EndpointSeverity SeverityUnspecified { get; } = new EndpointSeverity("SEVERITY_UNSPECIFIED");
        /// <summary>
        /// Informational alerts.
        /// </summary>
        public static EndpointSeverity Informational { get; } = new EndpointSeverity("INFORMATIONAL");
        /// <summary>
        /// Low severity alerts.
        /// </summary>
        public static EndpointSeverity Low { get; } = new EndpointSeverity("LOW");
        /// <summary>
        /// Medium severity alerts.
        /// </summary>
        public static EndpointSeverity Medium { get; } = new EndpointSeverity("MEDIUM");
        /// <summary>
        /// High severity alerts.
        /// </summary>
        public static EndpointSeverity High { get; } = new EndpointSeverity("HIGH");
        /// <summary>
        /// Critical severity alerts.
        /// </summary>
        public static EndpointSeverity Critical { get; } = new EndpointSeverity("CRITICAL");

        public static bool operator ==(EndpointSeverity left, EndpointSeverity right) => left.Equals(right);
        public static bool operator !=(EndpointSeverity left, EndpointSeverity right) => !left.Equals(right);

        public static explicit operator string(EndpointSeverity value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is EndpointSeverity other && Equals(other);
        public bool Equals(EndpointSeverity other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }
}