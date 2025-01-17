// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.ComponentModel;
using Pulumi;

namespace Pulumi.GoogleNative.DNS.V2
{
    /// <summary>
    /// String mnemonic specifying the DNSSEC algorithm of this key.
    /// </summary>
    [EnumType]
    public readonly struct DnsKeySpecAlgorithm : IEquatable<DnsKeySpecAlgorithm>
    {
        private readonly string _value;

        private DnsKeySpecAlgorithm(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static DnsKeySpecAlgorithm Rsasha1 { get; } = new DnsKeySpecAlgorithm("RSASHA1");
        public static DnsKeySpecAlgorithm Rsasha256 { get; } = new DnsKeySpecAlgorithm("RSASHA256");
        public static DnsKeySpecAlgorithm Rsasha512 { get; } = new DnsKeySpecAlgorithm("RSASHA512");
        public static DnsKeySpecAlgorithm Ecdsap256sha256 { get; } = new DnsKeySpecAlgorithm("ECDSAP256SHA256");
        public static DnsKeySpecAlgorithm Ecdsap384sha384 { get; } = new DnsKeySpecAlgorithm("ECDSAP384SHA384");

        public static bool operator ==(DnsKeySpecAlgorithm left, DnsKeySpecAlgorithm right) => left.Equals(right);
        public static bool operator !=(DnsKeySpecAlgorithm left, DnsKeySpecAlgorithm right) => !left.Equals(right);

        public static explicit operator string(DnsKeySpecAlgorithm value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is DnsKeySpecAlgorithm other && Equals(other);
        public bool Equals(DnsKeySpecAlgorithm other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Specifies whether this is a key signing key (KSK) or a zone signing key (ZSK). Key signing keys have the Secure Entry Point flag set and, when active, are only used to sign resource record sets of type DNSKEY. Zone signing keys do not have the Secure Entry Point flag set and are used to sign all other types of resource record sets.
    /// </summary>
    [EnumType]
    public readonly struct DnsKeySpecKeyType : IEquatable<DnsKeySpecKeyType>
    {
        private readonly string _value;

        private DnsKeySpecKeyType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static DnsKeySpecKeyType KeySigning { get; } = new DnsKeySpecKeyType("KEY_SIGNING");
        public static DnsKeySpecKeyType ZoneSigning { get; } = new DnsKeySpecKeyType("ZONE_SIGNING");

        public static bool operator ==(DnsKeySpecKeyType left, DnsKeySpecKeyType right) => left.Equals(right);
        public static bool operator !=(DnsKeySpecKeyType left, DnsKeySpecKeyType right) => !left.Equals(right);

        public static explicit operator string(DnsKeySpecKeyType value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is DnsKeySpecKeyType other && Equals(other);
        public bool Equals(DnsKeySpecKeyType other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Specifies the mechanism for authenticated denial-of-existence responses. Can only be changed while the state is OFF.
    /// </summary>
    [EnumType]
    public readonly struct ManagedZoneDnsSecConfigNonExistence : IEquatable<ManagedZoneDnsSecConfigNonExistence>
    {
        private readonly string _value;

        private ManagedZoneDnsSecConfigNonExistence(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static ManagedZoneDnsSecConfigNonExistence Nsec { get; } = new ManagedZoneDnsSecConfigNonExistence("NSEC");
        public static ManagedZoneDnsSecConfigNonExistence Nsec3 { get; } = new ManagedZoneDnsSecConfigNonExistence("NSEC3");

        public static bool operator ==(ManagedZoneDnsSecConfigNonExistence left, ManagedZoneDnsSecConfigNonExistence right) => left.Equals(right);
        public static bool operator !=(ManagedZoneDnsSecConfigNonExistence left, ManagedZoneDnsSecConfigNonExistence right) => !left.Equals(right);

        public static explicit operator string(ManagedZoneDnsSecConfigNonExistence value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is ManagedZoneDnsSecConfigNonExistence other && Equals(other);
        public bool Equals(ManagedZoneDnsSecConfigNonExistence other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Specifies whether DNSSEC is enabled, and what mode it is in.
    /// </summary>
    [EnumType]
    public readonly struct ManagedZoneDnsSecConfigState : IEquatable<ManagedZoneDnsSecConfigState>
    {
        private readonly string _value;

        private ManagedZoneDnsSecConfigState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// DNSSEC is disabled; the zone is not signed.
        /// </summary>
        public static ManagedZoneDnsSecConfigState Off { get; } = new ManagedZoneDnsSecConfigState("OFF");
        /// <summary>
        /// DNSSEC is enabled; the zone is signed and fully managed.
        /// </summary>
        public static ManagedZoneDnsSecConfigState On { get; } = new ManagedZoneDnsSecConfigState("ON");
        /// <summary>
        /// DNSSEC is enabled, but in a "transfer" mode.
        /// </summary>
        public static ManagedZoneDnsSecConfigState Transfer { get; } = new ManagedZoneDnsSecConfigState("TRANSFER");

        public static bool operator ==(ManagedZoneDnsSecConfigState left, ManagedZoneDnsSecConfigState right) => left.Equals(right);
        public static bool operator !=(ManagedZoneDnsSecConfigState left, ManagedZoneDnsSecConfigState right) => !left.Equals(right);

        public static explicit operator string(ManagedZoneDnsSecConfigState value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is ManagedZoneDnsSecConfigState other && Equals(other);
        public bool Equals(ManagedZoneDnsSecConfigState other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Forwarding path for this NameServerTarget. If unset or set to DEFAULT, Cloud DNS makes forwarding decisions based on IP address ranges; that is, RFC1918 addresses go to the VPC network, non-RFC1918 addresses go to the internet. When set to PRIVATE, Cloud DNS always sends queries through the VPC network for this target.
    /// </summary>
    [EnumType]
    public readonly struct ManagedZoneForwardingConfigNameServerTargetForwardingPath : IEquatable<ManagedZoneForwardingConfigNameServerTargetForwardingPath>
    {
        private readonly string _value;

        private ManagedZoneForwardingConfigNameServerTargetForwardingPath(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Cloud DNS makes forwarding decisions based on address ranges; that is, RFC1918 addresses forward to the target through the VPC and non-RFC1918 addresses forward to the target through the internet
        /// </summary>
        public static ManagedZoneForwardingConfigNameServerTargetForwardingPath Default { get; } = new ManagedZoneForwardingConfigNameServerTargetForwardingPath("DEFAULT");
        /// <summary>
        /// Cloud DNS always forwards to this target through the VPC.
        /// </summary>
        public static ManagedZoneForwardingConfigNameServerTargetForwardingPath Private { get; } = new ManagedZoneForwardingConfigNameServerTargetForwardingPath("PRIVATE");

        public static bool operator ==(ManagedZoneForwardingConfigNameServerTargetForwardingPath left, ManagedZoneForwardingConfigNameServerTargetForwardingPath right) => left.Equals(right);
        public static bool operator !=(ManagedZoneForwardingConfigNameServerTargetForwardingPath left, ManagedZoneForwardingConfigNameServerTargetForwardingPath right) => !left.Equals(right);

        public static explicit operator string(ManagedZoneForwardingConfigNameServerTargetForwardingPath value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is ManagedZoneForwardingConfigNameServerTargetForwardingPath other && Equals(other);
        public bool Equals(ManagedZoneForwardingConfigNameServerTargetForwardingPath other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// The zone's visibility: public zones are exposed to the Internet, while private zones are visible only to Virtual Private Cloud resources.
    /// </summary>
    [EnumType]
    public readonly struct ManagedZoneVisibility : IEquatable<ManagedZoneVisibility>
    {
        private readonly string _value;

        private ManagedZoneVisibility(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static ManagedZoneVisibility Public { get; } = new ManagedZoneVisibility("PUBLIC");
        public static ManagedZoneVisibility Private { get; } = new ManagedZoneVisibility("PRIVATE");

        public static bool operator ==(ManagedZoneVisibility left, ManagedZoneVisibility right) => left.Equals(right);
        public static bool operator !=(ManagedZoneVisibility left, ManagedZoneVisibility right) => !left.Equals(right);

        public static explicit operator string(ManagedZoneVisibility value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is ManagedZoneVisibility other && Equals(other);
        public bool Equals(ManagedZoneVisibility other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Forwarding path for this TargetNameServer. If unset or set to DEFAULT, Cloud DNS makes forwarding decisions based on address ranges; that is, RFC1918 addresses go to the VPC network, non-RFC1918 addresses go to the internet. When set to PRIVATE, Cloud DNS always sends queries through the VPC network for this target.
    /// </summary>
    [EnumType]
    public readonly struct PolicyAlternativeNameServerConfigTargetNameServerForwardingPath : IEquatable<PolicyAlternativeNameServerConfigTargetNameServerForwardingPath>
    {
        private readonly string _value;

        private PolicyAlternativeNameServerConfigTargetNameServerForwardingPath(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Cloud DNS makes forwarding decision based on IP address ranges; that is, RFC1918 addresses forward to the target through the VPC and non-RFC1918 addresses forward to the target through the internet
        /// </summary>
        public static PolicyAlternativeNameServerConfigTargetNameServerForwardingPath Default { get; } = new PolicyAlternativeNameServerConfigTargetNameServerForwardingPath("DEFAULT");
        /// <summary>
        /// Cloud DNS always forwards to this target through the VPC.
        /// </summary>
        public static PolicyAlternativeNameServerConfigTargetNameServerForwardingPath Private { get; } = new PolicyAlternativeNameServerConfigTargetNameServerForwardingPath("PRIVATE");

        public static bool operator ==(PolicyAlternativeNameServerConfigTargetNameServerForwardingPath left, PolicyAlternativeNameServerConfigTargetNameServerForwardingPath right) => left.Equals(right);
        public static bool operator !=(PolicyAlternativeNameServerConfigTargetNameServerForwardingPath left, PolicyAlternativeNameServerConfigTargetNameServerForwardingPath right) => !left.Equals(right);

        public static explicit operator string(PolicyAlternativeNameServerConfigTargetNameServerForwardingPath value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is PolicyAlternativeNameServerConfigTargetNameServerForwardingPath other && Equals(other);
        public bool Equals(PolicyAlternativeNameServerConfigTargetNameServerForwardingPath other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Answer this query with a behavior rather than DNS data.
    /// </summary>
    [EnumType]
    public readonly struct ResponsePolicyRuleBehavior : IEquatable<ResponsePolicyRuleBehavior>
    {
        private readonly string _value;

        private ResponsePolicyRuleBehavior(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static ResponsePolicyRuleBehavior BehaviorUnspecified { get; } = new ResponsePolicyRuleBehavior("BEHAVIOR_UNSPECIFIED");
        /// <summary>
        /// Skip a less-specific ResponsePolicyRule and continue normal query logic. This can be used in conjunction with a wildcard to exempt a subset of the wildcard ResponsePolicyRule from the ResponsePolicy behavior and e.g., query the public internet instead. For instance, if these rules exist: *.example.com -&gt; 1.2.3.4 foo.example.com -&gt; PASSTHRU Then a query for 'foo.example.com' skips the wildcard.
        /// </summary>
        public static ResponsePolicyRuleBehavior BypassResponsePolicy { get; } = new ResponsePolicyRuleBehavior("BYPASS_RESPONSE_POLICY");

        public static bool operator ==(ResponsePolicyRuleBehavior left, ResponsePolicyRuleBehavior right) => left.Equals(right);
        public static bool operator !=(ResponsePolicyRuleBehavior left, ResponsePolicyRuleBehavior right) => !left.Equals(right);

        public static explicit operator string(ResponsePolicyRuleBehavior value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is ResponsePolicyRuleBehavior other && Equals(other);
        public bool Equals(ResponsePolicyRuleBehavior other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }
}
