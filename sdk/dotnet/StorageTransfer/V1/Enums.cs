// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.ComponentModel;
using Pulumi;

namespace Pulumi.GoogleNative.StorageTransfer.V1
{
    [EnumType]
    public readonly struct LoggingConfigLogActionStatesItem : IEquatable<LoggingConfigLogActionStatesItem>
    {
        private readonly string _value;

        private LoggingConfigLogActionStatesItem(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Default value. This value is unused.
        /// </summary>
        public static LoggingConfigLogActionStatesItem LoggableActionStateUnspecified { get; } = new LoggingConfigLogActionStatesItem("LOGGABLE_ACTION_STATE_UNSPECIFIED");
        /// <summary>
        /// `LoggableAction` completed successfully. `SUCCEEDED` actions are logged as INFO.
        /// </summary>
        public static LoggingConfigLogActionStatesItem Succeeded { get; } = new LoggingConfigLogActionStatesItem("SUCCEEDED");
        /// <summary>
        /// `LoggableAction` terminated in an error state. `FAILED` actions are logged as ERROR.
        /// </summary>
        public static LoggingConfigLogActionStatesItem Failed { get; } = new LoggingConfigLogActionStatesItem("FAILED");

        public static bool operator ==(LoggingConfigLogActionStatesItem left, LoggingConfigLogActionStatesItem right) => left.Equals(right);
        public static bool operator !=(LoggingConfigLogActionStatesItem left, LoggingConfigLogActionStatesItem right) => !left.Equals(right);

        public static explicit operator string(LoggingConfigLogActionStatesItem value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is LoggingConfigLogActionStatesItem other && Equals(other);
        public bool Equals(LoggingConfigLogActionStatesItem other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    [EnumType]
    public readonly struct LoggingConfigLogActionsItem : IEquatable<LoggingConfigLogActionsItem>
    {
        private readonly string _value;

        private LoggingConfigLogActionsItem(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Default value. This value is unused.
        /// </summary>
        public static LoggingConfigLogActionsItem LoggableActionUnspecified { get; } = new LoggingConfigLogActionsItem("LOGGABLE_ACTION_UNSPECIFIED");
        /// <summary>
        /// Listing objects in a bucket.
        /// </summary>
        public static LoggingConfigLogActionsItem Find { get; } = new LoggingConfigLogActionsItem("FIND");
        /// <summary>
        /// Deleting objects at the source or the destination.
        /// </summary>
        public static LoggingConfigLogActionsItem Delete { get; } = new LoggingConfigLogActionsItem("DELETE");
        /// <summary>
        /// Copying objects to Google Cloud Storage.
        /// </summary>
        public static LoggingConfigLogActionsItem Copy { get; } = new LoggingConfigLogActionsItem("COPY");

        public static bool operator ==(LoggingConfigLogActionsItem left, LoggingConfigLogActionsItem right) => left.Equals(right);
        public static bool operator !=(LoggingConfigLogActionsItem left, LoggingConfigLogActionsItem right) => !left.Equals(right);

        public static explicit operator string(LoggingConfigLogActionsItem value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is LoggingConfigLogActionsItem other && Equals(other);
        public bool Equals(LoggingConfigLogActionsItem other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Specifies how each object's ACLs should be preserved for transfers between Google Cloud Storage buckets. If unspecified, the default behavior is the same as ACL_DESTINATION_BUCKET_DEFAULT.
    /// </summary>
    [EnumType]
    public readonly struct MetadataOptionsAcl : IEquatable<MetadataOptionsAcl>
    {
        private readonly string _value;

        private MetadataOptionsAcl(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// ACL behavior is unspecified.
        /// </summary>
        public static MetadataOptionsAcl AclUnspecified { get; } = new MetadataOptionsAcl("ACL_UNSPECIFIED");
        /// <summary>
        /// Use the destination bucket's default object ACLS, if applicable.
        /// </summary>
        public static MetadataOptionsAcl AclDestinationBucketDefault { get; } = new MetadataOptionsAcl("ACL_DESTINATION_BUCKET_DEFAULT");
        /// <summary>
        /// Preserve the object's original ACLs. This requires the service account to have `storage.objects.getIamPolicy` permission for the source object. [Uniform bucket-level access](https://cloud.google.com/storage/docs/uniform-bucket-level-access) must not be enabled on either the source or destination buckets.
        /// </summary>
        public static MetadataOptionsAcl AclPreserve { get; } = new MetadataOptionsAcl("ACL_PRESERVE");

        public static bool operator ==(MetadataOptionsAcl left, MetadataOptionsAcl right) => left.Equals(right);
        public static bool operator !=(MetadataOptionsAcl left, MetadataOptionsAcl right) => !left.Equals(right);

        public static explicit operator string(MetadataOptionsAcl value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is MetadataOptionsAcl other && Equals(other);
        public bool Equals(MetadataOptionsAcl other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Specifies how each file's POSIX group ID (GID) attribute should be handled by the transfer. By default, GID is not preserved. Only applicable to transfers involving POSIX file systems, and ignored for other transfers.
    /// </summary>
    [EnumType]
    public readonly struct MetadataOptionsGid : IEquatable<MetadataOptionsGid>
    {
        private readonly string _value;

        private MetadataOptionsGid(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// GID behavior is unspecified.
        /// </summary>
        public static MetadataOptionsGid GidUnspecified { get; } = new MetadataOptionsGid("GID_UNSPECIFIED");
        /// <summary>
        /// Do not preserve GID during a transfer job.
        /// </summary>
        public static MetadataOptionsGid GidSkip { get; } = new MetadataOptionsGid("GID_SKIP");
        /// <summary>
        /// Preserve GID during a transfer job.
        /// </summary>
        public static MetadataOptionsGid GidNumber { get; } = new MetadataOptionsGid("GID_NUMBER");

        public static bool operator ==(MetadataOptionsGid left, MetadataOptionsGid right) => left.Equals(right);
        public static bool operator !=(MetadataOptionsGid left, MetadataOptionsGid right) => !left.Equals(right);

        public static explicit operator string(MetadataOptionsGid value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is MetadataOptionsGid other && Equals(other);
        public bool Equals(MetadataOptionsGid other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Specifies how each object's Cloud KMS customer-managed encryption key (CMEK) is preserved for transfers between Google Cloud Storage buckets. If unspecified, the default behavior is the same as KMS_KEY_DESTINATION_BUCKET_DEFAULT.
    /// </summary>
    [EnumType]
    public readonly struct MetadataOptionsKmsKey : IEquatable<MetadataOptionsKmsKey>
    {
        private readonly string _value;

        private MetadataOptionsKmsKey(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// KmsKey behavior is unspecified.
        /// </summary>
        public static MetadataOptionsKmsKey KmsKeyUnspecified { get; } = new MetadataOptionsKmsKey("KMS_KEY_UNSPECIFIED");
        /// <summary>
        /// Use the destination bucket's default encryption settings.
        /// </summary>
        public static MetadataOptionsKmsKey KmsKeyDestinationBucketDefault { get; } = new MetadataOptionsKmsKey("KMS_KEY_DESTINATION_BUCKET_DEFAULT");
        /// <summary>
        /// Preserve the object's original Cloud KMS customer-managed encryption key (CMEK) if present. Objects that do not use a Cloud KMS encryption key will be encrypted using the destination bucket's encryption settings.
        /// </summary>
        public static MetadataOptionsKmsKey KmsKeyPreserve { get; } = new MetadataOptionsKmsKey("KMS_KEY_PRESERVE");

        public static bool operator ==(MetadataOptionsKmsKey left, MetadataOptionsKmsKey right) => left.Equals(right);
        public static bool operator !=(MetadataOptionsKmsKey left, MetadataOptionsKmsKey right) => !left.Equals(right);

        public static explicit operator string(MetadataOptionsKmsKey value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is MetadataOptionsKmsKey other && Equals(other);
        public bool Equals(MetadataOptionsKmsKey other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Specifies how each file's mode attribute should be handled by the transfer. By default, mode is not preserved. Only applicable to transfers involving POSIX file systems, and ignored for other transfers.
    /// </summary>
    [EnumType]
    public readonly struct MetadataOptionsMode : IEquatable<MetadataOptionsMode>
    {
        private readonly string _value;

        private MetadataOptionsMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Mode behavior is unspecified.
        /// </summary>
        public static MetadataOptionsMode ModeUnspecified { get; } = new MetadataOptionsMode("MODE_UNSPECIFIED");
        /// <summary>
        /// Do not preserve mode during a transfer job.
        /// </summary>
        public static MetadataOptionsMode ModeSkip { get; } = new MetadataOptionsMode("MODE_SKIP");
        /// <summary>
        /// Preserve mode during a transfer job.
        /// </summary>
        public static MetadataOptionsMode ModePreserve { get; } = new MetadataOptionsMode("MODE_PRESERVE");

        public static bool operator ==(MetadataOptionsMode left, MetadataOptionsMode right) => left.Equals(right);
        public static bool operator !=(MetadataOptionsMode left, MetadataOptionsMode right) => !left.Equals(right);

        public static explicit operator string(MetadataOptionsMode value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is MetadataOptionsMode other && Equals(other);
        public bool Equals(MetadataOptionsMode other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Specifies the storage class to set on objects being transferred to Google Cloud Storage buckets. If unspecified, the default behavior is the same as STORAGE_CLASS_DESTINATION_BUCKET_DEFAULT.
    /// </summary>
    [EnumType]
    public readonly struct MetadataOptionsStorageClass : IEquatable<MetadataOptionsStorageClass>
    {
        private readonly string _value;

        private MetadataOptionsStorageClass(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Storage class behavior is unspecified.
        /// </summary>
        public static MetadataOptionsStorageClass StorageClassUnspecified { get; } = new MetadataOptionsStorageClass("STORAGE_CLASS_UNSPECIFIED");
        /// <summary>
        /// Use the destination bucket's default storage class.
        /// </summary>
        public static MetadataOptionsStorageClass StorageClassDestinationBucketDefault { get; } = new MetadataOptionsStorageClass("STORAGE_CLASS_DESTINATION_BUCKET_DEFAULT");
        /// <summary>
        /// Preserve the object's original storage class. This is only supported for transfers from Google Cloud Storage buckets.
        /// </summary>
        public static MetadataOptionsStorageClass StorageClassPreserve { get; } = new MetadataOptionsStorageClass("STORAGE_CLASS_PRESERVE");
        /// <summary>
        /// Set the storage class to STANDARD.
        /// </summary>
        public static MetadataOptionsStorageClass StorageClassStandard { get; } = new MetadataOptionsStorageClass("STORAGE_CLASS_STANDARD");
        /// <summary>
        /// Set the storage class to NEARLINE.
        /// </summary>
        public static MetadataOptionsStorageClass StorageClassNearline { get; } = new MetadataOptionsStorageClass("STORAGE_CLASS_NEARLINE");
        /// <summary>
        /// Set the storage class to COLDLINE.
        /// </summary>
        public static MetadataOptionsStorageClass StorageClassColdline { get; } = new MetadataOptionsStorageClass("STORAGE_CLASS_COLDLINE");
        /// <summary>
        /// Set the storage class to ARCHIVE.
        /// </summary>
        public static MetadataOptionsStorageClass StorageClassArchive { get; } = new MetadataOptionsStorageClass("STORAGE_CLASS_ARCHIVE");

        public static bool operator ==(MetadataOptionsStorageClass left, MetadataOptionsStorageClass right) => left.Equals(right);
        public static bool operator !=(MetadataOptionsStorageClass left, MetadataOptionsStorageClass right) => !left.Equals(right);

        public static explicit operator string(MetadataOptionsStorageClass value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is MetadataOptionsStorageClass other && Equals(other);
        public bool Equals(MetadataOptionsStorageClass other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Specifies how symlinks should be handled by the transfer. By default, symlinks are not preserved. Only applicable to transfers involving POSIX file systems, and ignored for other transfers.
    /// </summary>
    [EnumType]
    public readonly struct MetadataOptionsSymlink : IEquatable<MetadataOptionsSymlink>
    {
        private readonly string _value;

        private MetadataOptionsSymlink(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Symlink behavior is unspecified.
        /// </summary>
        public static MetadataOptionsSymlink SymlinkUnspecified { get; } = new MetadataOptionsSymlink("SYMLINK_UNSPECIFIED");
        /// <summary>
        /// Do not preserve symlinks during a transfer job.
        /// </summary>
        public static MetadataOptionsSymlink SymlinkSkip { get; } = new MetadataOptionsSymlink("SYMLINK_SKIP");
        /// <summary>
        /// Preserve symlinks during a transfer job.
        /// </summary>
        public static MetadataOptionsSymlink SymlinkPreserve { get; } = new MetadataOptionsSymlink("SYMLINK_PRESERVE");

        public static bool operator ==(MetadataOptionsSymlink left, MetadataOptionsSymlink right) => left.Equals(right);
        public static bool operator !=(MetadataOptionsSymlink left, MetadataOptionsSymlink right) => !left.Equals(right);

        public static explicit operator string(MetadataOptionsSymlink value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is MetadataOptionsSymlink other && Equals(other);
        public bool Equals(MetadataOptionsSymlink other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Specifies how each object's temporary hold status should be preserved for transfers between Google Cloud Storage buckets. If unspecified, the default behavior is the same as TEMPORARY_HOLD_PRESERVE.
    /// </summary>
    [EnumType]
    public readonly struct MetadataOptionsTemporaryHold : IEquatable<MetadataOptionsTemporaryHold>
    {
        private readonly string _value;

        private MetadataOptionsTemporaryHold(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Temporary hold behavior is unspecified.
        /// </summary>
        public static MetadataOptionsTemporaryHold TemporaryHoldUnspecified { get; } = new MetadataOptionsTemporaryHold("TEMPORARY_HOLD_UNSPECIFIED");
        /// <summary>
        /// Do not set a temporary hold on the destination object.
        /// </summary>
        public static MetadataOptionsTemporaryHold TemporaryHoldSkip { get; } = new MetadataOptionsTemporaryHold("TEMPORARY_HOLD_SKIP");
        /// <summary>
        /// Preserve the object's original temporary hold status.
        /// </summary>
        public static MetadataOptionsTemporaryHold TemporaryHoldPreserve { get; } = new MetadataOptionsTemporaryHold("TEMPORARY_HOLD_PRESERVE");

        public static bool operator ==(MetadataOptionsTemporaryHold left, MetadataOptionsTemporaryHold right) => left.Equals(right);
        public static bool operator !=(MetadataOptionsTemporaryHold left, MetadataOptionsTemporaryHold right) => !left.Equals(right);

        public static explicit operator string(MetadataOptionsTemporaryHold value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is MetadataOptionsTemporaryHold other && Equals(other);
        public bool Equals(MetadataOptionsTemporaryHold other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Specifies how each object's `timeCreated` metadata is preserved for transfers between Google Cloud Storage buckets. If unspecified, the default behavior is the same as TIME_CREATED_SKIP.
    /// </summary>
    [EnumType]
    public readonly struct MetadataOptionsTimeCreated : IEquatable<MetadataOptionsTimeCreated>
    {
        private readonly string _value;

        private MetadataOptionsTimeCreated(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// TimeCreated behavior is unspecified.
        /// </summary>
        public static MetadataOptionsTimeCreated TimeCreatedUnspecified { get; } = new MetadataOptionsTimeCreated("TIME_CREATED_UNSPECIFIED");
        /// <summary>
        /// Do not preserve the `timeCreated` metadata from the source object.
        /// </summary>
        public static MetadataOptionsTimeCreated TimeCreatedSkip { get; } = new MetadataOptionsTimeCreated("TIME_CREATED_SKIP");
        /// <summary>
        /// Preserves the source object's `timeCreated` metadata in the `customTime` field in the destination object. Note that any value stored in the source object's `customTime` field will not be propagated to the destination object.
        /// </summary>
        public static MetadataOptionsTimeCreated TimeCreatedPreserveAsCustomTime { get; } = new MetadataOptionsTimeCreated("TIME_CREATED_PRESERVE_AS_CUSTOM_TIME");

        public static bool operator ==(MetadataOptionsTimeCreated left, MetadataOptionsTimeCreated right) => left.Equals(right);
        public static bool operator !=(MetadataOptionsTimeCreated left, MetadataOptionsTimeCreated right) => !left.Equals(right);

        public static explicit operator string(MetadataOptionsTimeCreated value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is MetadataOptionsTimeCreated other && Equals(other);
        public bool Equals(MetadataOptionsTimeCreated other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Specifies how each file's POSIX user ID (UID) attribute should be handled by the transfer. By default, UID is not preserved. Only applicable to transfers involving POSIX file systems, and ignored for other transfers.
    /// </summary>
    [EnumType]
    public readonly struct MetadataOptionsUid : IEquatable<MetadataOptionsUid>
    {
        private readonly string _value;

        private MetadataOptionsUid(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// UID behavior is unspecified.
        /// </summary>
        public static MetadataOptionsUid UidUnspecified { get; } = new MetadataOptionsUid("UID_UNSPECIFIED");
        /// <summary>
        /// Do not preserve UID during a transfer job.
        /// </summary>
        public static MetadataOptionsUid UidSkip { get; } = new MetadataOptionsUid("UID_SKIP");
        /// <summary>
        /// Preserve UID during a transfer job.
        /// </summary>
        public static MetadataOptionsUid UidNumber { get; } = new MetadataOptionsUid("UID_NUMBER");

        public static bool operator ==(MetadataOptionsUid left, MetadataOptionsUid right) => left.Equals(right);
        public static bool operator !=(MetadataOptionsUid left, MetadataOptionsUid right) => !left.Equals(right);

        public static explicit operator string(MetadataOptionsUid value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is MetadataOptionsUid other && Equals(other);
        public bool Equals(MetadataOptionsUid other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    [EnumType]
    public readonly struct NotificationConfigEventTypesItem : IEquatable<NotificationConfigEventTypesItem>
    {
        private readonly string _value;

        private NotificationConfigEventTypesItem(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Illegal value, to avoid allowing a default.
        /// </summary>
        public static NotificationConfigEventTypesItem EventTypeUnspecified { get; } = new NotificationConfigEventTypesItem("EVENT_TYPE_UNSPECIFIED");
        /// <summary>
        /// `TransferOperation` completed with status SUCCESS.
        /// </summary>
        public static NotificationConfigEventTypesItem TransferOperationSuccess { get; } = new NotificationConfigEventTypesItem("TRANSFER_OPERATION_SUCCESS");
        /// <summary>
        /// `TransferOperation` completed with status FAILED.
        /// </summary>
        public static NotificationConfigEventTypesItem TransferOperationFailed { get; } = new NotificationConfigEventTypesItem("TRANSFER_OPERATION_FAILED");
        /// <summary>
        /// `TransferOperation` completed with status ABORTED.
        /// </summary>
        public static NotificationConfigEventTypesItem TransferOperationAborted { get; } = new NotificationConfigEventTypesItem("TRANSFER_OPERATION_ABORTED");

        public static bool operator ==(NotificationConfigEventTypesItem left, NotificationConfigEventTypesItem right) => left.Equals(right);
        public static bool operator !=(NotificationConfigEventTypesItem left, NotificationConfigEventTypesItem right) => !left.Equals(right);

        public static explicit operator string(NotificationConfigEventTypesItem value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is NotificationConfigEventTypesItem other && Equals(other);
        public bool Equals(NotificationConfigEventTypesItem other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Required. The desired format of the notification message payloads.
    /// </summary>
    [EnumType]
    public readonly struct NotificationConfigPayloadFormat : IEquatable<NotificationConfigPayloadFormat>
    {
        private readonly string _value;

        private NotificationConfigPayloadFormat(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Illegal value, to avoid allowing a default.
        /// </summary>
        public static NotificationConfigPayloadFormat PayloadFormatUnspecified { get; } = new NotificationConfigPayloadFormat("PAYLOAD_FORMAT_UNSPECIFIED");
        /// <summary>
        /// No payload is included with the notification.
        /// </summary>
        public static NotificationConfigPayloadFormat None { get; } = new NotificationConfigPayloadFormat("NONE");
        /// <summary>
        /// `TransferOperation` is [formatted as a JSON response](https://developers.google.com/protocol-buffers/docs/proto3#json), in application/json.
        /// </summary>
        public static NotificationConfigPayloadFormat Json { get; } = new NotificationConfigPayloadFormat("JSON");

        public static bool operator ==(NotificationConfigPayloadFormat left, NotificationConfigPayloadFormat right) => left.Equals(right);
        public static bool operator !=(NotificationConfigPayloadFormat left, NotificationConfigPayloadFormat right) => !left.Equals(right);

        public static explicit operator string(NotificationConfigPayloadFormat value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is NotificationConfigPayloadFormat other && Equals(other);
        public bool Equals(NotificationConfigPayloadFormat other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Status of the job. This value MUST be specified for `CreateTransferJobRequests`. **Note:** The effect of the new job status takes place during a subsequent job run. For example, if you change the job status from ENABLED to DISABLED, and an operation spawned by the transfer is running, the status change would not affect the current operation.
    /// </summary>
    [EnumType]
    public readonly struct TransferJobStatus : IEquatable<TransferJobStatus>
    {
        private readonly string _value;

        private TransferJobStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Zero is an illegal value.
        /// </summary>
        public static TransferJobStatus StatusUnspecified { get; } = new TransferJobStatus("STATUS_UNSPECIFIED");
        /// <summary>
        /// New transfers are performed based on the schedule.
        /// </summary>
        public static TransferJobStatus Enabled { get; } = new TransferJobStatus("ENABLED");
        /// <summary>
        /// New transfers are not scheduled.
        /// </summary>
        public static TransferJobStatus Disabled { get; } = new TransferJobStatus("DISABLED");
        /// <summary>
        /// This is a soft delete state. After a transfer job is set to this state, the job and all the transfer executions are subject to garbage collection. Transfer jobs become eligible for garbage collection 30 days after their status is set to `DELETED`.
        /// </summary>
        public static TransferJobStatus Deleted { get; } = new TransferJobStatus("DELETED");

        public static bool operator ==(TransferJobStatus left, TransferJobStatus right) => left.Equals(right);
        public static bool operator !=(TransferJobStatus left, TransferJobStatus right) => !left.Equals(right);

        public static explicit operator string(TransferJobStatus value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is TransferJobStatus other && Equals(other);
        public bool Equals(TransferJobStatus other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// When to overwrite objects that already exist in the sink. If not set, overwrite behavior is determined by overwrite_objects_already_existing_in_sink.
    /// </summary>
    [EnumType]
    public readonly struct TransferOptionsOverwriteWhen : IEquatable<TransferOptionsOverwriteWhen>
    {
        private readonly string _value;

        private TransferOptionsOverwriteWhen(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Overwrite behavior is unspecified.
        /// </summary>
        public static TransferOptionsOverwriteWhen OverwriteWhenUnspecified { get; } = new TransferOptionsOverwriteWhen("OVERWRITE_WHEN_UNSPECIFIED");
        /// <summary>
        /// Overwrites destination objects with the source objects, only if the objects have the same name but different HTTP ETags or checksum values.
        /// </summary>
        public static TransferOptionsOverwriteWhen Different { get; } = new TransferOptionsOverwriteWhen("DIFFERENT");
        /// <summary>
        /// Never overwrites a destination object if a source object has the same name. In this case, the source object is not transferred.
        /// </summary>
        public static TransferOptionsOverwriteWhen Never { get; } = new TransferOptionsOverwriteWhen("NEVER");
        /// <summary>
        /// Always overwrite the destination object with the source object, even if the HTTP Etags or checksum values are the same.
        /// </summary>
        public static TransferOptionsOverwriteWhen Always { get; } = new TransferOptionsOverwriteWhen("ALWAYS");

        public static bool operator ==(TransferOptionsOverwriteWhen left, TransferOptionsOverwriteWhen right) => left.Equals(right);
        public static bool operator !=(TransferOptionsOverwriteWhen left, TransferOptionsOverwriteWhen right) => !left.Equals(right);

        public static explicit operator string(TransferOptionsOverwriteWhen value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is TransferOptionsOverwriteWhen other && Equals(other);
        public bool Equals(TransferOptionsOverwriteWhen other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }
}
