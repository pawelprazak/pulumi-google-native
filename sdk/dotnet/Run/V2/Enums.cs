// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.ComponentModel;
using Pulumi;

namespace Pulumi.GoogleNative.Run.V2
{
    /// <summary>
    /// The sandbox environment to host this Revision.
    /// </summary>
    [EnumType]
    public readonly struct GoogleCloudRunV2RevisionTemplateExecutionEnvironment : IEquatable<GoogleCloudRunV2RevisionTemplateExecutionEnvironment>
    {
        private readonly string _value;

        private GoogleCloudRunV2RevisionTemplateExecutionEnvironment(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Unspecified
        /// </summary>
        public static GoogleCloudRunV2RevisionTemplateExecutionEnvironment ExecutionEnvironmentUnspecified { get; } = new GoogleCloudRunV2RevisionTemplateExecutionEnvironment("EXECUTION_ENVIRONMENT_UNSPECIFIED");
        /// <summary>
        /// Uses the First Generation environment.
        /// </summary>
        public static GoogleCloudRunV2RevisionTemplateExecutionEnvironment ExecutionEnvironmentGen1 { get; } = new GoogleCloudRunV2RevisionTemplateExecutionEnvironment("EXECUTION_ENVIRONMENT_GEN1");
        /// <summary>
        /// Uses Second Generation environment.
        /// </summary>
        public static GoogleCloudRunV2RevisionTemplateExecutionEnvironment ExecutionEnvironmentGen2 { get; } = new GoogleCloudRunV2RevisionTemplateExecutionEnvironment("EXECUTION_ENVIRONMENT_GEN2");

        public static bool operator ==(GoogleCloudRunV2RevisionTemplateExecutionEnvironment left, GoogleCloudRunV2RevisionTemplateExecutionEnvironment right) => left.Equals(right);
        public static bool operator !=(GoogleCloudRunV2RevisionTemplateExecutionEnvironment left, GoogleCloudRunV2RevisionTemplateExecutionEnvironment right) => !left.Equals(right);

        public static explicit operator string(GoogleCloudRunV2RevisionTemplateExecutionEnvironment value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is GoogleCloudRunV2RevisionTemplateExecutionEnvironment other && Equals(other);
        public bool Equals(GoogleCloudRunV2RevisionTemplateExecutionEnvironment other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// The execution environment being used to host this Task.
    /// </summary>
    [EnumType]
    public readonly struct GoogleCloudRunV2TaskTemplateExecutionEnvironment : IEquatable<GoogleCloudRunV2TaskTemplateExecutionEnvironment>
    {
        private readonly string _value;

        private GoogleCloudRunV2TaskTemplateExecutionEnvironment(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Unspecified
        /// </summary>
        public static GoogleCloudRunV2TaskTemplateExecutionEnvironment ExecutionEnvironmentUnspecified { get; } = new GoogleCloudRunV2TaskTemplateExecutionEnvironment("EXECUTION_ENVIRONMENT_UNSPECIFIED");
        /// <summary>
        /// Uses the First Generation environment.
        /// </summary>
        public static GoogleCloudRunV2TaskTemplateExecutionEnvironment ExecutionEnvironmentGen1 { get; } = new GoogleCloudRunV2TaskTemplateExecutionEnvironment("EXECUTION_ENVIRONMENT_GEN1");
        /// <summary>
        /// Uses Second Generation environment.
        /// </summary>
        public static GoogleCloudRunV2TaskTemplateExecutionEnvironment ExecutionEnvironmentGen2 { get; } = new GoogleCloudRunV2TaskTemplateExecutionEnvironment("EXECUTION_ENVIRONMENT_GEN2");

        public static bool operator ==(GoogleCloudRunV2TaskTemplateExecutionEnvironment left, GoogleCloudRunV2TaskTemplateExecutionEnvironment right) => left.Equals(right);
        public static bool operator !=(GoogleCloudRunV2TaskTemplateExecutionEnvironment left, GoogleCloudRunV2TaskTemplateExecutionEnvironment right) => !left.Equals(right);

        public static explicit operator string(GoogleCloudRunV2TaskTemplateExecutionEnvironment value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is GoogleCloudRunV2TaskTemplateExecutionEnvironment other && Equals(other);
        public bool Equals(GoogleCloudRunV2TaskTemplateExecutionEnvironment other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// The allocation type for this traffic target.
    /// </summary>
    [EnumType]
    public readonly struct GoogleCloudRunV2TrafficTargetType : IEquatable<GoogleCloudRunV2TrafficTargetType>
    {
        private readonly string _value;

        private GoogleCloudRunV2TrafficTargetType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Unspecified instance allocation type.
        /// </summary>
        public static GoogleCloudRunV2TrafficTargetType TrafficTargetAllocationTypeUnspecified { get; } = new GoogleCloudRunV2TrafficTargetType("TRAFFIC_TARGET_ALLOCATION_TYPE_UNSPECIFIED");
        /// <summary>
        /// Allocates instances to the Service's latest ready Revision.
        /// </summary>
        public static GoogleCloudRunV2TrafficTargetType TrafficTargetAllocationTypeLatest { get; } = new GoogleCloudRunV2TrafficTargetType("TRAFFIC_TARGET_ALLOCATION_TYPE_LATEST");
        /// <summary>
        /// Allocates instances to a Revision by name.
        /// </summary>
        public static GoogleCloudRunV2TrafficTargetType TrafficTargetAllocationTypeRevision { get; } = new GoogleCloudRunV2TrafficTargetType("TRAFFIC_TARGET_ALLOCATION_TYPE_REVISION");

        public static bool operator ==(GoogleCloudRunV2TrafficTargetType left, GoogleCloudRunV2TrafficTargetType right) => left.Equals(right);
        public static bool operator !=(GoogleCloudRunV2TrafficTargetType left, GoogleCloudRunV2TrafficTargetType right) => !left.Equals(right);

        public static explicit operator string(GoogleCloudRunV2TrafficTargetType value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is GoogleCloudRunV2TrafficTargetType other && Equals(other);
        public bool Equals(GoogleCloudRunV2TrafficTargetType other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Traffic VPC egress settings.
    /// </summary>
    [EnumType]
    public readonly struct GoogleCloudRunV2VpcAccessEgress : IEquatable<GoogleCloudRunV2VpcAccessEgress>
    {
        private readonly string _value;

        private GoogleCloudRunV2VpcAccessEgress(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Unspecified
        /// </summary>
        public static GoogleCloudRunV2VpcAccessEgress VpcEgressUnspecified { get; } = new GoogleCloudRunV2VpcAccessEgress("VPC_EGRESS_UNSPECIFIED");
        /// <summary>
        /// All outbound traffic is routed through the VPC connector.
        /// </summary>
        public static GoogleCloudRunV2VpcAccessEgress AllTraffic { get; } = new GoogleCloudRunV2VpcAccessEgress("ALL_TRAFFIC");
        /// <summary>
        /// Only private IP ranges are routed through the VPC connector.
        /// </summary>
        public static GoogleCloudRunV2VpcAccessEgress PrivateRangesOnly { get; } = new GoogleCloudRunV2VpcAccessEgress("PRIVATE_RANGES_ONLY");

        public static bool operator ==(GoogleCloudRunV2VpcAccessEgress left, GoogleCloudRunV2VpcAccessEgress right) => left.Equals(right);
        public static bool operator !=(GoogleCloudRunV2VpcAccessEgress left, GoogleCloudRunV2VpcAccessEgress right) => !left.Equals(right);

        public static explicit operator string(GoogleCloudRunV2VpcAccessEgress value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is GoogleCloudRunV2VpcAccessEgress other && Equals(other);
        public bool Equals(GoogleCloudRunV2VpcAccessEgress other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// The log type that this config enables.
    /// </summary>
    [EnumType]
    public readonly struct GoogleIamV1AuditLogConfigLogType : IEquatable<GoogleIamV1AuditLogConfigLogType>
    {
        private readonly string _value;

        private GoogleIamV1AuditLogConfigLogType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Default case. Should never be this.
        /// </summary>
        public static GoogleIamV1AuditLogConfigLogType LogTypeUnspecified { get; } = new GoogleIamV1AuditLogConfigLogType("LOG_TYPE_UNSPECIFIED");
        /// <summary>
        /// Admin reads. Example: CloudIAM getIamPolicy
        /// </summary>
        public static GoogleIamV1AuditLogConfigLogType AdminRead { get; } = new GoogleIamV1AuditLogConfigLogType("ADMIN_READ");
        /// <summary>
        /// Data writes. Example: CloudSQL Users create
        /// </summary>
        public static GoogleIamV1AuditLogConfigLogType DataWrite { get; } = new GoogleIamV1AuditLogConfigLogType("DATA_WRITE");
        /// <summary>
        /// Data reads. Example: CloudSQL Users list
        /// </summary>
        public static GoogleIamV1AuditLogConfigLogType DataRead { get; } = new GoogleIamV1AuditLogConfigLogType("DATA_READ");

        public static bool operator ==(GoogleIamV1AuditLogConfigLogType left, GoogleIamV1AuditLogConfigLogType right) => left.Equals(right);
        public static bool operator !=(GoogleIamV1AuditLogConfigLogType left, GoogleIamV1AuditLogConfigLogType right) => !left.Equals(right);

        public static explicit operator string(GoogleIamV1AuditLogConfigLogType value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is GoogleIamV1AuditLogConfigLogType other && Equals(other);
        public bool Equals(GoogleIamV1AuditLogConfigLogType other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// The launch stage as defined by [Google Cloud Platform Launch Stages](https://cloud.google.com/terms/launch-stages). Cloud Run supports `ALPHA`, `BETA`, and `GA`. If no value is specified, GA is assumed.
    /// </summary>
    [EnumType]
    public readonly struct JobLaunchStage : IEquatable<JobLaunchStage>
    {
        private readonly string _value;

        private JobLaunchStage(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Do not use this default value.
        /// </summary>
        public static JobLaunchStage LaunchStageUnspecified { get; } = new JobLaunchStage("LAUNCH_STAGE_UNSPECIFIED");
        /// <summary>
        /// The feature is not yet implemented. Users can not use it.
        /// </summary>
        public static JobLaunchStage Unimplemented { get; } = new JobLaunchStage("UNIMPLEMENTED");
        /// <summary>
        /// Prelaunch features are hidden from users and are only visible internally.
        /// </summary>
        public static JobLaunchStage Prelaunch { get; } = new JobLaunchStage("PRELAUNCH");
        /// <summary>
        /// Early Access features are limited to a closed group of testers. To use these features, you must sign up in advance and sign a Trusted Tester agreement (which includes confidentiality provisions). These features may be unstable, changed in backward-incompatible ways, and are not guaranteed to be released.
        /// </summary>
        public static JobLaunchStage EarlyAccess { get; } = new JobLaunchStage("EARLY_ACCESS");
        /// <summary>
        /// Alpha is a limited availability test for releases before they are cleared for widespread use. By Alpha, all significant design issues are resolved and we are in the process of verifying functionality. Alpha customers need to apply for access, agree to applicable terms, and have their projects allowlisted. Alpha releases don't have to be feature complete, no SLAs are provided, and there are no technical support obligations, but they will be far enough along that customers can actually use them in test environments or for limited-use tests -- just like they would in normal production cases.
        /// </summary>
        public static JobLaunchStage Alpha { get; } = new JobLaunchStage("ALPHA");
        /// <summary>
        /// Beta is the point at which we are ready to open a release for any customer to use. There are no SLA or technical support obligations in a Beta release. Products will be complete from a feature perspective, but may have some open outstanding issues. Beta releases are suitable for limited production use cases.
        /// </summary>
        public static JobLaunchStage Beta { get; } = new JobLaunchStage("BETA");
        /// <summary>
        /// GA features are open to all developers and are considered stable and fully qualified for production use.
        /// </summary>
        public static JobLaunchStage Ga { get; } = new JobLaunchStage("GA");
        /// <summary>
        /// Deprecated features are scheduled to be shut down and removed. For more information, see the "Deprecation Policy" section of our [Terms of Service](https://cloud.google.com/terms/) and the [Google Cloud Platform Subject to the Deprecation Policy](https://cloud.google.com/terms/deprecation) documentation.
        /// </summary>
        public static JobLaunchStage Deprecated { get; } = new JobLaunchStage("DEPRECATED");

        public static bool operator ==(JobLaunchStage left, JobLaunchStage right) => left.Equals(right);
        public static bool operator !=(JobLaunchStage left, JobLaunchStage right) => !left.Equals(right);

        public static explicit operator string(JobLaunchStage value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is JobLaunchStage other && Equals(other);
        public bool Equals(JobLaunchStage other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Provides the ingress settings for this Service. On output, returns the currently observed ingress settings, or INGRESS_TRAFFIC_UNSPECIFIED if no revision is active.
    /// </summary>
    [EnumType]
    public readonly struct ServiceIngress : IEquatable<ServiceIngress>
    {
        private readonly string _value;

        private ServiceIngress(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Unspecified
        /// </summary>
        public static ServiceIngress IngressTrafficUnspecified { get; } = new ServiceIngress("INGRESS_TRAFFIC_UNSPECIFIED");
        /// <summary>
        /// All inbound traffic is allowed.
        /// </summary>
        public static ServiceIngress IngressTrafficAll { get; } = new ServiceIngress("INGRESS_TRAFFIC_ALL");
        /// <summary>
        /// Only internal traffic is allowed.
        /// </summary>
        public static ServiceIngress IngressTrafficInternalOnly { get; } = new ServiceIngress("INGRESS_TRAFFIC_INTERNAL_ONLY");
        /// <summary>
        /// Both internal and Google Cloud Load Balancer traffic is allowed.
        /// </summary>
        public static ServiceIngress IngressTrafficInternalLoadBalancer { get; } = new ServiceIngress("INGRESS_TRAFFIC_INTERNAL_LOAD_BALANCER");

        public static bool operator ==(ServiceIngress left, ServiceIngress right) => left.Equals(right);
        public static bool operator !=(ServiceIngress left, ServiceIngress right) => !left.Equals(right);

        public static explicit operator string(ServiceIngress value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is ServiceIngress other && Equals(other);
        public bool Equals(ServiceIngress other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// The launch stage as defined by [Google Cloud Platform Launch Stages](https://cloud.google.com/terms/launch-stages). Cloud Run supports `ALPHA`, `BETA`, and `GA`. If no value is specified, GA is assumed.
    /// </summary>
    [EnumType]
    public readonly struct ServiceLaunchStage : IEquatable<ServiceLaunchStage>
    {
        private readonly string _value;

        private ServiceLaunchStage(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Do not use this default value.
        /// </summary>
        public static ServiceLaunchStage LaunchStageUnspecified { get; } = new ServiceLaunchStage("LAUNCH_STAGE_UNSPECIFIED");
        /// <summary>
        /// The feature is not yet implemented. Users can not use it.
        /// </summary>
        public static ServiceLaunchStage Unimplemented { get; } = new ServiceLaunchStage("UNIMPLEMENTED");
        /// <summary>
        /// Prelaunch features are hidden from users and are only visible internally.
        /// </summary>
        public static ServiceLaunchStage Prelaunch { get; } = new ServiceLaunchStage("PRELAUNCH");
        /// <summary>
        /// Early Access features are limited to a closed group of testers. To use these features, you must sign up in advance and sign a Trusted Tester agreement (which includes confidentiality provisions). These features may be unstable, changed in backward-incompatible ways, and are not guaranteed to be released.
        /// </summary>
        public static ServiceLaunchStage EarlyAccess { get; } = new ServiceLaunchStage("EARLY_ACCESS");
        /// <summary>
        /// Alpha is a limited availability test for releases before they are cleared for widespread use. By Alpha, all significant design issues are resolved and we are in the process of verifying functionality. Alpha customers need to apply for access, agree to applicable terms, and have their projects allowlisted. Alpha releases don't have to be feature complete, no SLAs are provided, and there are no technical support obligations, but they will be far enough along that customers can actually use them in test environments or for limited-use tests -- just like they would in normal production cases.
        /// </summary>
        public static ServiceLaunchStage Alpha { get; } = new ServiceLaunchStage("ALPHA");
        /// <summary>
        /// Beta is the point at which we are ready to open a release for any customer to use. There are no SLA or technical support obligations in a Beta release. Products will be complete from a feature perspective, but may have some open outstanding issues. Beta releases are suitable for limited production use cases.
        /// </summary>
        public static ServiceLaunchStage Beta { get; } = new ServiceLaunchStage("BETA");
        /// <summary>
        /// GA features are open to all developers and are considered stable and fully qualified for production use.
        /// </summary>
        public static ServiceLaunchStage Ga { get; } = new ServiceLaunchStage("GA");
        /// <summary>
        /// Deprecated features are scheduled to be shut down and removed. For more information, see the "Deprecation Policy" section of our [Terms of Service](https://cloud.google.com/terms/) and the [Google Cloud Platform Subject to the Deprecation Policy](https://cloud.google.com/terms/deprecation) documentation.
        /// </summary>
        public static ServiceLaunchStage Deprecated { get; } = new ServiceLaunchStage("DEPRECATED");

        public static bool operator ==(ServiceLaunchStage left, ServiceLaunchStage right) => left.Equals(right);
        public static bool operator !=(ServiceLaunchStage left, ServiceLaunchStage right) => !left.Equals(right);

        public static explicit operator string(ServiceLaunchStage value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is ServiceLaunchStage other && Equals(other);
        public bool Equals(ServiceLaunchStage other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }
}