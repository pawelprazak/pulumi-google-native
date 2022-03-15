// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.ComponentModel;
using Pulumi;

namespace Pulumi.GoogleNative.Notebooks.V1
{
    /// <summary>
    /// Type of this accelerator.
    /// </summary>
    [EnumType]
    public readonly struct AcceleratorConfigType : IEquatable<AcceleratorConfigType>
    {
        private readonly string _value;

        private AcceleratorConfigType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Accelerator type is not specified.
        /// </summary>
        public static AcceleratorConfigType AcceleratorTypeUnspecified { get; } = new AcceleratorConfigType("ACCELERATOR_TYPE_UNSPECIFIED");
        /// <summary>
        /// Accelerator type is Nvidia Tesla K80.
        /// </summary>
        public static AcceleratorConfigType NvidiaTeslaK80 { get; } = new AcceleratorConfigType("NVIDIA_TESLA_K80");
        /// <summary>
        /// Accelerator type is Nvidia Tesla P100.
        /// </summary>
        public static AcceleratorConfigType NvidiaTeslaP100 { get; } = new AcceleratorConfigType("NVIDIA_TESLA_P100");
        /// <summary>
        /// Accelerator type is Nvidia Tesla V100.
        /// </summary>
        public static AcceleratorConfigType NvidiaTeslaV100 { get; } = new AcceleratorConfigType("NVIDIA_TESLA_V100");
        /// <summary>
        /// Accelerator type is Nvidia Tesla P4.
        /// </summary>
        public static AcceleratorConfigType NvidiaTeslaP4 { get; } = new AcceleratorConfigType("NVIDIA_TESLA_P4");
        /// <summary>
        /// Accelerator type is Nvidia Tesla T4.
        /// </summary>
        public static AcceleratorConfigType NvidiaTeslaT4 { get; } = new AcceleratorConfigType("NVIDIA_TESLA_T4");
        /// <summary>
        /// Accelerator type is Nvidia Tesla A100.
        /// </summary>
        public static AcceleratorConfigType NvidiaTeslaA100 { get; } = new AcceleratorConfigType("NVIDIA_TESLA_A100");
        /// <summary>
        /// Accelerator type is NVIDIA Tesla T4 Virtual Workstations.
        /// </summary>
        public static AcceleratorConfigType NvidiaTeslaT4Vws { get; } = new AcceleratorConfigType("NVIDIA_TESLA_T4_VWS");
        /// <summary>
        /// Accelerator type is NVIDIA Tesla P100 Virtual Workstations.
        /// </summary>
        public static AcceleratorConfigType NvidiaTeslaP100Vws { get; } = new AcceleratorConfigType("NVIDIA_TESLA_P100_VWS");
        /// <summary>
        /// Accelerator type is NVIDIA Tesla P4 Virtual Workstations.
        /// </summary>
        public static AcceleratorConfigType NvidiaTeslaP4Vws { get; } = new AcceleratorConfigType("NVIDIA_TESLA_P4_VWS");
        /// <summary>
        /// (Coming soon) Accelerator type is TPU V2.
        /// </summary>
        public static AcceleratorConfigType TpuV2 { get; } = new AcceleratorConfigType("TPU_V2");
        /// <summary>
        /// (Coming soon) Accelerator type is TPU V3.
        /// </summary>
        public static AcceleratorConfigType TpuV3 { get; } = new AcceleratorConfigType("TPU_V3");

        public static bool operator ==(AcceleratorConfigType left, AcceleratorConfigType right) => left.Equals(right);
        public static bool operator !=(AcceleratorConfigType left, AcceleratorConfigType right) => !left.Equals(right);

        public static explicit operator string(AcceleratorConfigType value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is AcceleratorConfigType other && Equals(other);
        public bool Equals(AcceleratorConfigType other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// The type of Job to be used on this execution.
    /// </summary>
    [EnumType]
    public readonly struct ExecutionTemplateJobType : IEquatable<ExecutionTemplateJobType>
    {
        private readonly string _value;

        private ExecutionTemplateJobType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// No type specified.
        /// </summary>
        public static ExecutionTemplateJobType JobTypeUnspecified { get; } = new ExecutionTemplateJobType("JOB_TYPE_UNSPECIFIED");
        /// <summary>
        /// Custom Job in `aiplatform.googleapis.com`. Default value for an execution.
        /// </summary>
        public static ExecutionTemplateJobType VertexAi { get; } = new ExecutionTemplateJobType("VERTEX_AI");
        /// <summary>
        /// Run execution on a cluster with Dataproc as a job. https://cloud.google.com/dataproc/docs/reference/rest/v1/projects.regions.jobs
        /// </summary>
        public static ExecutionTemplateJobType Dataproc { get; } = new ExecutionTemplateJobType("DATAPROC");

        public static bool operator ==(ExecutionTemplateJobType left, ExecutionTemplateJobType right) => left.Equals(right);
        public static bool operator !=(ExecutionTemplateJobType left, ExecutionTemplateJobType right) => !left.Equals(right);

        public static explicit operator string(ExecutionTemplateJobType value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is ExecutionTemplateJobType other && Equals(other);
        public bool Equals(ExecutionTemplateJobType other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Required. Scale tier of the hardware used for notebook execution. DEPRECATED Will be discontinued. As right now only CUSTOM is supported.
    /// </summary>
    [EnumType]
    public readonly struct ExecutionTemplateScaleTier : IEquatable<ExecutionTemplateScaleTier>
    {
        private readonly string _value;

        private ExecutionTemplateScaleTier(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Unspecified Scale Tier.
        /// </summary>
        public static ExecutionTemplateScaleTier ScaleTierUnspecified { get; } = new ExecutionTemplateScaleTier("SCALE_TIER_UNSPECIFIED");
        /// <summary>
        /// A single worker instance. This tier is suitable for learning how to use Cloud ML, and for experimenting with new models using small datasets.
        /// </summary>
        public static ExecutionTemplateScaleTier Basic { get; } = new ExecutionTemplateScaleTier("BASIC");
        /// <summary>
        /// Many workers and a few parameter servers.
        /// </summary>
        public static ExecutionTemplateScaleTier Standard1 { get; } = new ExecutionTemplateScaleTier("STANDARD_1");
        /// <summary>
        /// A large number of workers with many parameter servers.
        /// </summary>
        public static ExecutionTemplateScaleTier Premium1 { get; } = new ExecutionTemplateScaleTier("PREMIUM_1");
        /// <summary>
        /// A single worker instance with a K80 GPU.
        /// </summary>
        public static ExecutionTemplateScaleTier BasicGpu { get; } = new ExecutionTemplateScaleTier("BASIC_GPU");
        /// <summary>
        /// A single worker instance with a Cloud TPU.
        /// </summary>
        public static ExecutionTemplateScaleTier BasicTpu { get; } = new ExecutionTemplateScaleTier("BASIC_TPU");
        /// <summary>
        /// The CUSTOM tier is not a set tier, but rather enables you to use your own cluster specification. When you use this tier, set values to configure your processing cluster according to these guidelines: * You _must_ set `ExecutionTemplate.masterType` to specify the type of machine to use for your master node. This is the only required setting.
        /// </summary>
        public static ExecutionTemplateScaleTier Custom { get; } = new ExecutionTemplateScaleTier("CUSTOM");

        public static bool operator ==(ExecutionTemplateScaleTier left, ExecutionTemplateScaleTier right) => left.Equals(right);
        public static bool operator !=(ExecutionTemplateScaleTier left, ExecutionTemplateScaleTier right) => !left.Equals(right);

        public static explicit operator string(ExecutionTemplateScaleTier value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is ExecutionTemplateScaleTier other && Equals(other);
        public bool Equals(ExecutionTemplateScaleTier other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Input only. The type of the boot disk attached to this instance, defaults to standard persistent disk (`PD_STANDARD`).
    /// </summary>
    [EnumType]
    public readonly struct InstanceBootDiskType : IEquatable<InstanceBootDiskType>
    {
        private readonly string _value;

        private InstanceBootDiskType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Disk type not set.
        /// </summary>
        public static InstanceBootDiskType DiskTypeUnspecified { get; } = new InstanceBootDiskType("DISK_TYPE_UNSPECIFIED");
        /// <summary>
        /// Standard persistent disk type.
        /// </summary>
        public static InstanceBootDiskType PdStandard { get; } = new InstanceBootDiskType("PD_STANDARD");
        /// <summary>
        /// SSD persistent disk type.
        /// </summary>
        public static InstanceBootDiskType PdSsd { get; } = new InstanceBootDiskType("PD_SSD");
        /// <summary>
        /// Balanced persistent disk type.
        /// </summary>
        public static InstanceBootDiskType PdBalanced { get; } = new InstanceBootDiskType("PD_BALANCED");

        public static bool operator ==(InstanceBootDiskType left, InstanceBootDiskType right) => left.Equals(right);
        public static bool operator !=(InstanceBootDiskType left, InstanceBootDiskType right) => !left.Equals(right);

        public static explicit operator string(InstanceBootDiskType value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is InstanceBootDiskType other && Equals(other);
        public bool Equals(InstanceBootDiskType other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Input only. The type of the data disk attached to this instance, defaults to standard persistent disk (`PD_STANDARD`).
    /// </summary>
    [EnumType]
    public readonly struct InstanceDataDiskType : IEquatable<InstanceDataDiskType>
    {
        private readonly string _value;

        private InstanceDataDiskType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Disk type not set.
        /// </summary>
        public static InstanceDataDiskType DiskTypeUnspecified { get; } = new InstanceDataDiskType("DISK_TYPE_UNSPECIFIED");
        /// <summary>
        /// Standard persistent disk type.
        /// </summary>
        public static InstanceDataDiskType PdStandard { get; } = new InstanceDataDiskType("PD_STANDARD");
        /// <summary>
        /// SSD persistent disk type.
        /// </summary>
        public static InstanceDataDiskType PdSsd { get; } = new InstanceDataDiskType("PD_SSD");
        /// <summary>
        /// Balanced persistent disk type.
        /// </summary>
        public static InstanceDataDiskType PdBalanced { get; } = new InstanceDataDiskType("PD_BALANCED");

        public static bool operator ==(InstanceDataDiskType left, InstanceDataDiskType right) => left.Equals(right);
        public static bool operator !=(InstanceDataDiskType left, InstanceDataDiskType right) => !left.Equals(right);

        public static explicit operator string(InstanceDataDiskType value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is InstanceDataDiskType other && Equals(other);
        public bool Equals(InstanceDataDiskType other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Input only. Disk encryption method used on the boot and data disks, defaults to GMEK.
    /// </summary>
    [EnumType]
    public readonly struct InstanceDiskEncryption : IEquatable<InstanceDiskEncryption>
    {
        private readonly string _value;

        private InstanceDiskEncryption(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Disk encryption is not specified.
        /// </summary>
        public static InstanceDiskEncryption DiskEncryptionUnspecified { get; } = new InstanceDiskEncryption("DISK_ENCRYPTION_UNSPECIFIED");
        /// <summary>
        /// Use Google managed encryption keys to encrypt the boot disk.
        /// </summary>
        public static InstanceDiskEncryption Gmek { get; } = new InstanceDiskEncryption("GMEK");
        /// <summary>
        /// Use customer managed encryption keys to encrypt the boot disk.
        /// </summary>
        public static InstanceDiskEncryption Cmek { get; } = new InstanceDiskEncryption("CMEK");

        public static bool operator ==(InstanceDiskEncryption left, InstanceDiskEncryption right) => left.Equals(right);
        public static bool operator !=(InstanceDiskEncryption left, InstanceDiskEncryption right) => !left.Equals(right);

        public static explicit operator string(InstanceDiskEncryption value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is InstanceDiskEncryption other && Equals(other);
        public bool Equals(InstanceDiskEncryption other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Optional. The type of vNIC to be used on this interface. This may be gVNIC or VirtioNet.
    /// </summary>
    [EnumType]
    public readonly struct InstanceNicType : IEquatable<InstanceNicType>
    {
        private readonly string _value;

        private InstanceNicType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// No type specified.
        /// </summary>
        public static InstanceNicType UnspecifiedNicType { get; } = new InstanceNicType("UNSPECIFIED_NIC_TYPE");
        /// <summary>
        /// VIRTIO
        /// </summary>
        public static InstanceNicType VirtioNet { get; } = new InstanceNicType("VIRTIO_NET");
        /// <summary>
        /// GVNIC
        /// </summary>
        public static InstanceNicType Gvnic { get; } = new InstanceNicType("GVNIC");

        public static bool operator ==(InstanceNicType left, InstanceNicType right) => left.Equals(right);
        public static bool operator !=(InstanceNicType left, InstanceNicType right) => !left.Equals(right);

        public static explicit operator string(InstanceNicType value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is InstanceNicType other && Equals(other);
        public bool Equals(InstanceNicType other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Input only. The type of the boot disk attached to this instance, defaults to standard persistent disk (`PD_STANDARD`).
    /// </summary>
    [EnumType]
    public readonly struct LocalDiskInitializeParamsDiskType : IEquatable<LocalDiskInitializeParamsDiskType>
    {
        private readonly string _value;

        private LocalDiskInitializeParamsDiskType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Disk type not set.
        /// </summary>
        public static LocalDiskInitializeParamsDiskType DiskTypeUnspecified { get; } = new LocalDiskInitializeParamsDiskType("DISK_TYPE_UNSPECIFIED");
        /// <summary>
        /// Standard persistent disk type.
        /// </summary>
        public static LocalDiskInitializeParamsDiskType PdStandard { get; } = new LocalDiskInitializeParamsDiskType("PD_STANDARD");
        /// <summary>
        /// SSD persistent disk type.
        /// </summary>
        public static LocalDiskInitializeParamsDiskType PdSsd { get; } = new LocalDiskInitializeParamsDiskType("PD_SSD");
        /// <summary>
        /// Balanced persistent disk type.
        /// </summary>
        public static LocalDiskInitializeParamsDiskType PdBalanced { get; } = new LocalDiskInitializeParamsDiskType("PD_BALANCED");

        public static bool operator ==(LocalDiskInitializeParamsDiskType left, LocalDiskInitializeParamsDiskType right) => left.Equals(right);
        public static bool operator !=(LocalDiskInitializeParamsDiskType left, LocalDiskInitializeParamsDiskType right) => !left.Equals(right);

        public static explicit operator string(LocalDiskInitializeParamsDiskType value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is LocalDiskInitializeParamsDiskType other && Equals(other);
        public bool Equals(LocalDiskInitializeParamsDiskType other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Optional. Type of reservation to consume
    /// </summary>
    [EnumType]
    public readonly struct ReservationAffinityConsumeReservationType : IEquatable<ReservationAffinityConsumeReservationType>
    {
        private readonly string _value;

        private ReservationAffinityConsumeReservationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Default type.
        /// </summary>
        public static ReservationAffinityConsumeReservationType TypeUnspecified { get; } = new ReservationAffinityConsumeReservationType("TYPE_UNSPECIFIED");
        /// <summary>
        /// Do not consume from any allocated capacity.
        /// </summary>
        public static ReservationAffinityConsumeReservationType NoReservation { get; } = new ReservationAffinityConsumeReservationType("NO_RESERVATION");
        /// <summary>
        /// Consume any reservation available.
        /// </summary>
        public static ReservationAffinityConsumeReservationType AnyReservation { get; } = new ReservationAffinityConsumeReservationType("ANY_RESERVATION");
        /// <summary>
        /// Must consume from a specific reservation. Must specify key value fields for specifying the reservations.
        /// </summary>
        public static ReservationAffinityConsumeReservationType SpecificReservation { get; } = new ReservationAffinityConsumeReservationType("SPECIFIC_RESERVATION");

        public static bool operator ==(ReservationAffinityConsumeReservationType left, ReservationAffinityConsumeReservationType right) => left.Equals(right);
        public static bool operator !=(ReservationAffinityConsumeReservationType left, ReservationAffinityConsumeReservationType right) => !left.Equals(right);

        public static explicit operator string(ReservationAffinityConsumeReservationType value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is ReservationAffinityConsumeReservationType other && Equals(other);
        public bool Equals(ReservationAffinityConsumeReservationType other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Accelerator model.
    /// </summary>
    [EnumType]
    public readonly struct RuntimeAcceleratorConfigType : IEquatable<RuntimeAcceleratorConfigType>
    {
        private readonly string _value;

        private RuntimeAcceleratorConfigType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Accelerator type is not specified.
        /// </summary>
        public static RuntimeAcceleratorConfigType AcceleratorTypeUnspecified { get; } = new RuntimeAcceleratorConfigType("ACCELERATOR_TYPE_UNSPECIFIED");
        /// <summary>
        /// Accelerator type is Nvidia Tesla K80.
        /// </summary>
        public static RuntimeAcceleratorConfigType NvidiaTeslaK80 { get; } = new RuntimeAcceleratorConfigType("NVIDIA_TESLA_K80");
        /// <summary>
        /// Accelerator type is Nvidia Tesla P100.
        /// </summary>
        public static RuntimeAcceleratorConfigType NvidiaTeslaP100 { get; } = new RuntimeAcceleratorConfigType("NVIDIA_TESLA_P100");
        /// <summary>
        /// Accelerator type is Nvidia Tesla V100.
        /// </summary>
        public static RuntimeAcceleratorConfigType NvidiaTeslaV100 { get; } = new RuntimeAcceleratorConfigType("NVIDIA_TESLA_V100");
        /// <summary>
        /// Accelerator type is Nvidia Tesla P4.
        /// </summary>
        public static RuntimeAcceleratorConfigType NvidiaTeslaP4 { get; } = new RuntimeAcceleratorConfigType("NVIDIA_TESLA_P4");
        /// <summary>
        /// Accelerator type is Nvidia Tesla T4.
        /// </summary>
        public static RuntimeAcceleratorConfigType NvidiaTeslaT4 { get; } = new RuntimeAcceleratorConfigType("NVIDIA_TESLA_T4");
        /// <summary>
        /// Accelerator type is Nvidia Tesla A100.
        /// </summary>
        public static RuntimeAcceleratorConfigType NvidiaTeslaA100 { get; } = new RuntimeAcceleratorConfigType("NVIDIA_TESLA_A100");
        /// <summary>
        /// (Coming soon) Accelerator type is TPU V2.
        /// </summary>
        public static RuntimeAcceleratorConfigType TpuV2 { get; } = new RuntimeAcceleratorConfigType("TPU_V2");
        /// <summary>
        /// (Coming soon) Accelerator type is TPU V3.
        /// </summary>
        public static RuntimeAcceleratorConfigType TpuV3 { get; } = new RuntimeAcceleratorConfigType("TPU_V3");
        /// <summary>
        /// Accelerator type is NVIDIA Tesla T4 Virtual Workstations.
        /// </summary>
        public static RuntimeAcceleratorConfigType NvidiaTeslaT4Vws { get; } = new RuntimeAcceleratorConfigType("NVIDIA_TESLA_T4_VWS");
        /// <summary>
        /// Accelerator type is NVIDIA Tesla P100 Virtual Workstations.
        /// </summary>
        public static RuntimeAcceleratorConfigType NvidiaTeslaP100Vws { get; } = new RuntimeAcceleratorConfigType("NVIDIA_TESLA_P100_VWS");
        /// <summary>
        /// Accelerator type is NVIDIA Tesla P4 Virtual Workstations.
        /// </summary>
        public static RuntimeAcceleratorConfigType NvidiaTeslaP4Vws { get; } = new RuntimeAcceleratorConfigType("NVIDIA_TESLA_P4_VWS");

        public static bool operator ==(RuntimeAcceleratorConfigType left, RuntimeAcceleratorConfigType right) => left.Equals(right);
        public static bool operator !=(RuntimeAcceleratorConfigType left, RuntimeAcceleratorConfigType right) => !left.Equals(right);

        public static explicit operator string(RuntimeAcceleratorConfigType value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is RuntimeAcceleratorConfigType other && Equals(other);
        public bool Equals(RuntimeAcceleratorConfigType other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// The type of access mode this instance.
    /// </summary>
    [EnumType]
    public readonly struct RuntimeAccessConfigAccessType : IEquatable<RuntimeAccessConfigAccessType>
    {
        private readonly string _value;

        private RuntimeAccessConfigAccessType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Unspecified access.
        /// </summary>
        public static RuntimeAccessConfigAccessType RuntimeAccessTypeUnspecified { get; } = new RuntimeAccessConfigAccessType("RUNTIME_ACCESS_TYPE_UNSPECIFIED");
        /// <summary>
        /// Single user login.
        /// </summary>
        public static RuntimeAccessConfigAccessType SingleUser { get; } = new RuntimeAccessConfigAccessType("SINGLE_USER");
        /// <summary>
        /// Service Account mode. In Service Account mode, Runtime creator will specify a SA that exists in the consumer project. Using Runtime Service Account field. Users accessing the Runtime need ActAs (Service Account User) permission.
        /// </summary>
        public static RuntimeAccessConfigAccessType ServiceAccount { get; } = new RuntimeAccessConfigAccessType("SERVICE_ACCOUNT");

        public static bool operator ==(RuntimeAccessConfigAccessType left, RuntimeAccessConfigAccessType right) => left.Equals(right);
        public static bool operator !=(RuntimeAccessConfigAccessType left, RuntimeAccessConfigAccessType right) => !left.Equals(right);

        public static explicit operator string(RuntimeAccessConfigAccessType value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is RuntimeAccessConfigAccessType other && Equals(other);
        public bool Equals(RuntimeAccessConfigAccessType other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    [EnumType]
    public readonly struct ScheduleState : IEquatable<ScheduleState>
    {
        private readonly string _value;

        private ScheduleState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Unspecified state.
        /// </summary>
        public static ScheduleState StateUnspecified { get; } = new ScheduleState("STATE_UNSPECIFIED");
        /// <summary>
        /// The job is executing normally.
        /// </summary>
        public static ScheduleState Enabled { get; } = new ScheduleState("ENABLED");
        /// <summary>
        /// The job is paused by the user. It will not execute. A user can intentionally pause the job using PauseJobRequest.
        /// </summary>
        public static ScheduleState Paused { get; } = new ScheduleState("PAUSED");
        /// <summary>
        /// The job is disabled by the system due to error. The user cannot directly set a job to be disabled.
        /// </summary>
        public static ScheduleState Disabled { get; } = new ScheduleState("DISABLED");
        /// <summary>
        /// The job state resulting from a failed CloudScheduler.UpdateJob operation. To recover a job from this state, retry CloudScheduler.UpdateJob until a successful response is received.
        /// </summary>
        public static ScheduleState UpdateFailed { get; } = new ScheduleState("UPDATE_FAILED");
        /// <summary>
        /// The schedule resource is being created.
        /// </summary>
        public static ScheduleState Initializing { get; } = new ScheduleState("INITIALIZING");
        /// <summary>
        /// The schedule resource is being deleted.
        /// </summary>
        public static ScheduleState Deleting { get; } = new ScheduleState("DELETING");

        public static bool operator ==(ScheduleState left, ScheduleState right) => left.Equals(right);
        public static bool operator !=(ScheduleState left, ScheduleState right) => !left.Equals(right);

        public static explicit operator string(ScheduleState value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is ScheduleState other && Equals(other);
        public bool Equals(ScheduleState other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Type of this accelerator.
    /// </summary>
    [EnumType]
    public readonly struct SchedulerAcceleratorConfigType : IEquatable<SchedulerAcceleratorConfigType>
    {
        private readonly string _value;

        private SchedulerAcceleratorConfigType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Unspecified accelerator type. Default to no GPU.
        /// </summary>
        public static SchedulerAcceleratorConfigType SchedulerAcceleratorTypeUnspecified { get; } = new SchedulerAcceleratorConfigType("SCHEDULER_ACCELERATOR_TYPE_UNSPECIFIED");
        /// <summary>
        /// Nvidia Tesla K80 GPU.
        /// </summary>
        public static SchedulerAcceleratorConfigType NvidiaTeslaK80 { get; } = new SchedulerAcceleratorConfigType("NVIDIA_TESLA_K80");
        /// <summary>
        /// Nvidia Tesla P100 GPU.
        /// </summary>
        public static SchedulerAcceleratorConfigType NvidiaTeslaP100 { get; } = new SchedulerAcceleratorConfigType("NVIDIA_TESLA_P100");
        /// <summary>
        /// Nvidia Tesla V100 GPU.
        /// </summary>
        public static SchedulerAcceleratorConfigType NvidiaTeslaV100 { get; } = new SchedulerAcceleratorConfigType("NVIDIA_TESLA_V100");
        /// <summary>
        /// Nvidia Tesla P4 GPU.
        /// </summary>
        public static SchedulerAcceleratorConfigType NvidiaTeslaP4 { get; } = new SchedulerAcceleratorConfigType("NVIDIA_TESLA_P4");
        /// <summary>
        /// Nvidia Tesla T4 GPU.
        /// </summary>
        public static SchedulerAcceleratorConfigType NvidiaTeslaT4 { get; } = new SchedulerAcceleratorConfigType("NVIDIA_TESLA_T4");
        /// <summary>
        /// Nvidia Tesla A100 GPU.
        /// </summary>
        public static SchedulerAcceleratorConfigType NvidiaTeslaA100 { get; } = new SchedulerAcceleratorConfigType("NVIDIA_TESLA_A100");
        /// <summary>
        /// TPU v2.
        /// </summary>
        public static SchedulerAcceleratorConfigType TpuV2 { get; } = new SchedulerAcceleratorConfigType("TPU_V2");
        /// <summary>
        /// TPU v3.
        /// </summary>
        public static SchedulerAcceleratorConfigType TpuV3 { get; } = new SchedulerAcceleratorConfigType("TPU_V3");

        public static bool operator ==(SchedulerAcceleratorConfigType left, SchedulerAcceleratorConfigType right) => left.Equals(right);
        public static bool operator !=(SchedulerAcceleratorConfigType left, SchedulerAcceleratorConfigType right) => !left.Equals(right);

        public static explicit operator string(SchedulerAcceleratorConfigType value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is SchedulerAcceleratorConfigType other && Equals(other);
        public bool Equals(SchedulerAcceleratorConfigType other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Action. Rolloback or Upgrade.
    /// </summary>
    [EnumType]
    public readonly struct UpgradeHistoryEntryAction : IEquatable<UpgradeHistoryEntryAction>
    {
        private readonly string _value;

        private UpgradeHistoryEntryAction(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Operation is not specified.
        /// </summary>
        public static UpgradeHistoryEntryAction ActionUnspecified { get; } = new UpgradeHistoryEntryAction("ACTION_UNSPECIFIED");
        /// <summary>
        /// Upgrade.
        /// </summary>
        public static UpgradeHistoryEntryAction Upgrade { get; } = new UpgradeHistoryEntryAction("UPGRADE");
        /// <summary>
        /// Rollback.
        /// </summary>
        public static UpgradeHistoryEntryAction Rollback { get; } = new UpgradeHistoryEntryAction("ROLLBACK");

        public static bool operator ==(UpgradeHistoryEntryAction left, UpgradeHistoryEntryAction right) => left.Equals(right);
        public static bool operator !=(UpgradeHistoryEntryAction left, UpgradeHistoryEntryAction right) => !left.Equals(right);

        public static explicit operator string(UpgradeHistoryEntryAction value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is UpgradeHistoryEntryAction other && Equals(other);
        public bool Equals(UpgradeHistoryEntryAction other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// The state of this instance upgrade history entry.
    /// </summary>
    [EnumType]
    public readonly struct UpgradeHistoryEntryState : IEquatable<UpgradeHistoryEntryState>
    {
        private readonly string _value;

        private UpgradeHistoryEntryState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// State is not specified.
        /// </summary>
        public static UpgradeHistoryEntryState StateUnspecified { get; } = new UpgradeHistoryEntryState("STATE_UNSPECIFIED");
        /// <summary>
        /// The instance upgrade is started.
        /// </summary>
        public static UpgradeHistoryEntryState Started { get; } = new UpgradeHistoryEntryState("STARTED");
        /// <summary>
        /// The instance upgrade is succeeded.
        /// </summary>
        public static UpgradeHistoryEntryState Succeeded { get; } = new UpgradeHistoryEntryState("SUCCEEDED");
        /// <summary>
        /// The instance upgrade is failed.
        /// </summary>
        public static UpgradeHistoryEntryState Failed { get; } = new UpgradeHistoryEntryState("FAILED");

        public static bool operator ==(UpgradeHistoryEntryState left, UpgradeHistoryEntryState right) => left.Equals(right);
        public static bool operator !=(UpgradeHistoryEntryState left, UpgradeHistoryEntryState right) => !left.Equals(right);

        public static explicit operator string(UpgradeHistoryEntryState value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is UpgradeHistoryEntryState other && Equals(other);
        public bool Equals(UpgradeHistoryEntryState other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Optional. The type of vNIC to be used on this interface. This may be gVNIC or VirtioNet.
    /// </summary>
    [EnumType]
    public readonly struct VirtualMachineConfigNicType : IEquatable<VirtualMachineConfigNicType>
    {
        private readonly string _value;

        private VirtualMachineConfigNicType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// No type specified.
        /// </summary>
        public static VirtualMachineConfigNicType UnspecifiedNicType { get; } = new VirtualMachineConfigNicType("UNSPECIFIED_NIC_TYPE");
        /// <summary>
        /// VIRTIO
        /// </summary>
        public static VirtualMachineConfigNicType VirtioNet { get; } = new VirtualMachineConfigNicType("VIRTIO_NET");
        /// <summary>
        /// GVNIC
        /// </summary>
        public static VirtualMachineConfigNicType Gvnic { get; } = new VirtualMachineConfigNicType("GVNIC");

        public static bool operator ==(VirtualMachineConfigNicType left, VirtualMachineConfigNicType right) => left.Equals(right);
        public static bool operator !=(VirtualMachineConfigNicType left, VirtualMachineConfigNicType right) => !left.Equals(right);

        public static explicit operator string(VirtualMachineConfigNicType value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is VirtualMachineConfigNicType other && Equals(other);
        public bool Equals(VirtualMachineConfigNicType other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }
}