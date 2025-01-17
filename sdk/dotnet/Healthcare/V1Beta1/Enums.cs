// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.ComponentModel;
using Pulumi;

namespace Pulumi.GoogleNative.Healthcare.V1Beta1
{
    /// <summary>
    /// Required. The category of the attribute. The value of this field cannot be changed after creation.
    /// </summary>
    [EnumType]
    public readonly struct AttributeDefinitionCategory : IEquatable<AttributeDefinitionCategory>
    {
        private readonly string _value;

        private AttributeDefinitionCategory(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// No category specified. This option is invalid.
        /// </summary>
        public static AttributeDefinitionCategory CategoryUnspecified { get; } = new AttributeDefinitionCategory("CATEGORY_UNSPECIFIED");
        /// <summary>
        /// Specify this category when this attribute describes the properties of resources. For example, data anonymity or data type.
        /// </summary>
        public static AttributeDefinitionCategory Resource { get; } = new AttributeDefinitionCategory("RESOURCE");
        /// <summary>
        /// Specify this category when this attribute describes the properties of requests. For example, requester's role or requester's organization.
        /// </summary>
        public static AttributeDefinitionCategory Request { get; } = new AttributeDefinitionCategory("REQUEST");

        public static bool operator ==(AttributeDefinitionCategory left, AttributeDefinitionCategory right) => left.Equals(right);
        public static bool operator !=(AttributeDefinitionCategory left, AttributeDefinitionCategory right) => !left.Equals(right);

        public static explicit operator string(AttributeDefinitionCategory value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is AttributeDefinitionCategory other && Equals(other);
        public bool Equals(AttributeDefinitionCategory other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

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
    /// Required. Indicates the current state of this Consent.
    /// </summary>
    [EnumType]
    public readonly struct ConsentState : IEquatable<ConsentState>
    {
        private readonly string _value;

        private ConsentState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// No state specified. Treated as ACTIVE only at the time of resource creation.
        /// </summary>
        public static ConsentState StateUnspecified { get; } = new ConsentState("STATE_UNSPECIFIED");
        /// <summary>
        /// The Consent is active and is considered when evaluating a user's consent on resources.
        /// </summary>
        public static ConsentState Active { get; } = new ConsentState("ACTIVE");
        /// <summary>
        /// The archived state is currently not being used.
        /// </summary>
        public static ConsentState Archived { get; } = new ConsentState("ARCHIVED");
        /// <summary>
        /// A revoked Consent is not considered when evaluating a user's consent on resources.
        /// </summary>
        public static ConsentState Revoked { get; } = new ConsentState("REVOKED");
        /// <summary>
        /// A draft Consent is not considered when evaluating a user's consent on resources unless explicitly specified.
        /// </summary>
        public static ConsentState Draft { get; } = new ConsentState("DRAFT");
        /// <summary>
        /// When a draft Consent is rejected by a user, it is set to a rejected state. A rejected Consent is not considered when evaluating a user's consent on resources.
        /// </summary>
        public static ConsentState Rejected { get; } = new ConsentState("REJECTED");

        public static bool operator ==(ConsentState left, ConsentState right) => left.Equals(right);
        public static bool operator !=(ConsentState left, ConsentState right) => !left.Equals(right);

        public static explicit operator string(ConsentState value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is ConsentState other && Equals(other);
        public bool Equals(ConsentState other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Enable parsing of references within complex FHIR data types such as Extensions. If this value is set to ENABLED, then features like referential integrity and Bundle reference rewriting apply to all references. If this flag has not been specified the behavior of the FHIR store will not change, references in complex data types will not be parsed. New stores will have this value set to ENABLED after a notification period. Warning: turning on this flag causes processing existing resources to fail if they contain references to non-existent resources.
    /// </summary>
    [EnumType]
    public readonly struct FhirStoreComplexDataTypeReferenceParsing : IEquatable<FhirStoreComplexDataTypeReferenceParsing>
    {
        private readonly string _value;

        private FhirStoreComplexDataTypeReferenceParsing(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// No parsing behavior specified. This is the same as DISABLED for backwards compatibility.
        /// </summary>
        public static FhirStoreComplexDataTypeReferenceParsing ComplexDataTypeReferenceParsingUnspecified { get; } = new FhirStoreComplexDataTypeReferenceParsing("COMPLEX_DATA_TYPE_REFERENCE_PARSING_UNSPECIFIED");
        /// <summary>
        /// References in complex data types are ignored.
        /// </summary>
        public static FhirStoreComplexDataTypeReferenceParsing Disabled { get; } = new FhirStoreComplexDataTypeReferenceParsing("DISABLED");
        /// <summary>
        /// References in complex data types are parsed.
        /// </summary>
        public static FhirStoreComplexDataTypeReferenceParsing Enabled { get; } = new FhirStoreComplexDataTypeReferenceParsing("ENABLED");

        public static bool operator ==(FhirStoreComplexDataTypeReferenceParsing left, FhirStoreComplexDataTypeReferenceParsing right) => left.Equals(right);
        public static bool operator !=(FhirStoreComplexDataTypeReferenceParsing left, FhirStoreComplexDataTypeReferenceParsing right) => !left.Equals(right);

        public static explicit operator string(FhirStoreComplexDataTypeReferenceParsing value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is FhirStoreComplexDataTypeReferenceParsing other && Equals(other);
        public bool Equals(FhirStoreComplexDataTypeReferenceParsing other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Immutable. The FHIR specification version that this FHIR store supports natively. This field is immutable after store creation. Requests are rejected if they contain FHIR resources of a different version. Version is required for every FHIR store.
    /// </summary>
    [EnumType]
    public readonly struct FhirStoreVersion : IEquatable<FhirStoreVersion>
    {
        private readonly string _value;

        private FhirStoreVersion(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// VERSION_UNSPECIFIED is treated as STU3 to accommodate the existing FHIR stores.
        /// </summary>
        public static FhirStoreVersion VersionUnspecified { get; } = new FhirStoreVersion("VERSION_UNSPECIFIED");
        /// <summary>
        /// Draft Standard for Trial Use, [Release 2](https://www.hl7.org/fhir/DSTU2)
        /// </summary>
        public static FhirStoreVersion Dstu2 { get; } = new FhirStoreVersion("DSTU2");
        /// <summary>
        /// Standard for Trial Use, [Release 3](https://www.hl7.org/fhir/STU3)
        /// </summary>
        public static FhirStoreVersion Stu3 { get; } = new FhirStoreVersion("STU3");
        /// <summary>
        /// [Release 4](https://www.hl7.org/fhir/R4)
        /// </summary>
        public static FhirStoreVersion R4 { get; } = new FhirStoreVersion("R4");

        public static bool operator ==(FhirStoreVersion left, FhirStoreVersion right) => left.Equals(right);
        public static bool operator !=(FhirStoreVersion left, FhirStoreVersion right) => !left.Equals(right);

        public static explicit operator string(FhirStoreVersion value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is FhirStoreVersion other && Equals(other);
        public bool Equals(FhirStoreVersion other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Determines whether the existing table in the destination is to be overwritten or appended to. If a write_disposition is specified, the `force` parameter is ignored.
    /// </summary>
    [EnumType]
    public readonly struct GoogleCloudHealthcareV1beta1DicomBigQueryDestinationWriteDisposition : IEquatable<GoogleCloudHealthcareV1beta1DicomBigQueryDestinationWriteDisposition>
    {
        private readonly string _value;

        private GoogleCloudHealthcareV1beta1DicomBigQueryDestinationWriteDisposition(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Default behavior is the same as WRITE_EMPTY.
        /// </summary>
        public static GoogleCloudHealthcareV1beta1DicomBigQueryDestinationWriteDisposition WriteDispositionUnspecified { get; } = new GoogleCloudHealthcareV1beta1DicomBigQueryDestinationWriteDisposition("WRITE_DISPOSITION_UNSPECIFIED");
        /// <summary>
        /// Only export data if the destination table is empty.
        /// </summary>
        public static GoogleCloudHealthcareV1beta1DicomBigQueryDestinationWriteDisposition WriteEmpty { get; } = new GoogleCloudHealthcareV1beta1DicomBigQueryDestinationWriteDisposition("WRITE_EMPTY");
        /// <summary>
        /// Erase all existing data in a table before writing the instances.
        /// </summary>
        public static GoogleCloudHealthcareV1beta1DicomBigQueryDestinationWriteDisposition WriteTruncate { get; } = new GoogleCloudHealthcareV1beta1DicomBigQueryDestinationWriteDisposition("WRITE_TRUNCATE");
        /// <summary>
        /// Append data to the existing table.
        /// </summary>
        public static GoogleCloudHealthcareV1beta1DicomBigQueryDestinationWriteDisposition WriteAppend { get; } = new GoogleCloudHealthcareV1beta1DicomBigQueryDestinationWriteDisposition("WRITE_APPEND");

        public static bool operator ==(GoogleCloudHealthcareV1beta1DicomBigQueryDestinationWriteDisposition left, GoogleCloudHealthcareV1beta1DicomBigQueryDestinationWriteDisposition right) => left.Equals(right);
        public static bool operator !=(GoogleCloudHealthcareV1beta1DicomBigQueryDestinationWriteDisposition left, GoogleCloudHealthcareV1beta1DicomBigQueryDestinationWriteDisposition right) => !left.Equals(right);

        public static explicit operator string(GoogleCloudHealthcareV1beta1DicomBigQueryDestinationWriteDisposition value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is GoogleCloudHealthcareV1beta1DicomBigQueryDestinationWriteDisposition other && Equals(other);
        public bool Equals(GoogleCloudHealthcareV1beta1DicomBigQueryDestinationWriteDisposition other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Determines if existing data in the destination dataset is overwritten, appended to, or not written if the tables contain data. If a write_disposition is specified, the `force` parameter is ignored.
    /// </summary>
    [EnumType]
    public readonly struct GoogleCloudHealthcareV1beta1FhirBigQueryDestinationWriteDisposition : IEquatable<GoogleCloudHealthcareV1beta1FhirBigQueryDestinationWriteDisposition>
    {
        private readonly string _value;

        private GoogleCloudHealthcareV1beta1FhirBigQueryDestinationWriteDisposition(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Default behavior is the same as WRITE_EMPTY.
        /// </summary>
        public static GoogleCloudHealthcareV1beta1FhirBigQueryDestinationWriteDisposition WriteDispositionUnspecified { get; } = new GoogleCloudHealthcareV1beta1FhirBigQueryDestinationWriteDisposition("WRITE_DISPOSITION_UNSPECIFIED");
        /// <summary>
        /// Only export data if the destination tables are empty.
        /// </summary>
        public static GoogleCloudHealthcareV1beta1FhirBigQueryDestinationWriteDisposition WriteEmpty { get; } = new GoogleCloudHealthcareV1beta1FhirBigQueryDestinationWriteDisposition("WRITE_EMPTY");
        /// <summary>
        /// Erase all existing data in the tables before writing the instances.
        /// </summary>
        public static GoogleCloudHealthcareV1beta1FhirBigQueryDestinationWriteDisposition WriteTruncate { get; } = new GoogleCloudHealthcareV1beta1FhirBigQueryDestinationWriteDisposition("WRITE_TRUNCATE");
        /// <summary>
        /// Append data to the existing tables.
        /// </summary>
        public static GoogleCloudHealthcareV1beta1FhirBigQueryDestinationWriteDisposition WriteAppend { get; } = new GoogleCloudHealthcareV1beta1FhirBigQueryDestinationWriteDisposition("WRITE_APPEND");

        public static bool operator ==(GoogleCloudHealthcareV1beta1FhirBigQueryDestinationWriteDisposition left, GoogleCloudHealthcareV1beta1FhirBigQueryDestinationWriteDisposition right) => left.Equals(right);
        public static bool operator !=(GoogleCloudHealthcareV1beta1FhirBigQueryDestinationWriteDisposition left, GoogleCloudHealthcareV1beta1FhirBigQueryDestinationWriteDisposition right) => !left.Equals(right);

        public static explicit operator string(GoogleCloudHealthcareV1beta1FhirBigQueryDestinationWriteDisposition value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is GoogleCloudHealthcareV1beta1FhirBigQueryDestinationWriteDisposition other && Equals(other);
        public bool Equals(GoogleCloudHealthcareV1beta1FhirBigQueryDestinationWriteDisposition other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Immutable. Determines the version of both the default parser to be used when `schema` is not given, as well as the schematized parser used when `schema` is specified. This field is immutable after HL7v2 store creation.
    /// </summary>
    [EnumType]
    public readonly struct ParserConfigVersion : IEquatable<ParserConfigVersion>
    {
        private readonly string _value;

        private ParserConfigVersion(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Unspecified parser version, equivalent to V1.
        /// </summary>
        public static ParserConfigVersion ParserVersionUnspecified { get; } = new ParserConfigVersion("PARSER_VERSION_UNSPECIFIED");
        /// <summary>
        /// The `parsed_data` includes every given non-empty message field except the Field Separator (MSH-1) field. As a result, the parsed MSH segment starts with the MSH-2 field and the field numbers are off-by-one with respect to the HL7 standard.
        /// </summary>
        public static ParserConfigVersion V1 { get; } = new ParserConfigVersion("V1");
        /// <summary>
        /// The `parsed_data` includes every given non-empty message field.
        /// </summary>
        public static ParserConfigVersion V2 { get; } = new ParserConfigVersion("V2");
        /// <summary>
        /// This version is the same as V2, with the following change. The `parsed_data` contains unescaped escaped field separators, component separators, sub-component separators, repetition separators, escape characters, and truncation characters. If `schema` is specified, the schematized parser uses improved parsing heuristics compared to previous versions.
        /// </summary>
        public static ParserConfigVersion V3 { get; } = new ParserConfigVersion("V3");

        public static bool operator ==(ParserConfigVersion left, ParserConfigVersion right) => left.Equals(right);
        public static bool operator !=(ParserConfigVersion left, ParserConfigVersion right) => !left.Equals(right);

        public static explicit operator string(ParserConfigVersion value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is ParserConfigVersion other && Equals(other);
        public bool Equals(ParserConfigVersion other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Specifies the output schema type. Schema type is required.
    /// </summary>
    [EnumType]
    public readonly struct SchemaConfigSchemaType : IEquatable<SchemaConfigSchemaType>
    {
        private readonly string _value;

        private SchemaConfigSchemaType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// No schema type specified. This type is unsupported.
        /// </summary>
        public static SchemaConfigSchemaType SchemaTypeUnspecified { get; } = new SchemaConfigSchemaType("SCHEMA_TYPE_UNSPECIFIED");
        /// <summary>
        /// A data-driven schema generated from the fields present in the FHIR data being exported, with no additional simplification.
        /// </summary>
        public static SchemaConfigSchemaType Lossless { get; } = new SchemaConfigSchemaType("LOSSLESS");
        /// <summary>
        /// Analytics schema defined by the FHIR community. See https://github.com/FHIR/sql-on-fhir/blob/master/sql-on-fhir.md. BigQuery only allows a maximum of 10,000 columns per table. Due to this limitation, the server will not generate schemas for fields of type `Resource`, which can hold any resource type. The affected fields are `Parameters.parameter.resource`, `Bundle.entry.resource`, and `Bundle.entry.response.outcome`.
        /// </summary>
        public static SchemaConfigSchemaType Analytics { get; } = new SchemaConfigSchemaType("ANALYTICS");
        /// <summary>
        /// Analytics V2, similar to schema defined by the FHIR community, with added support for extensions with one or more occurrences and contained resources in stringified JSON.
        /// </summary>
        public static SchemaConfigSchemaType AnalyticsV2 { get; } = new SchemaConfigSchemaType("ANALYTICS_V2");

        public static bool operator ==(SchemaConfigSchemaType left, SchemaConfigSchemaType right) => left.Equals(right);
        public static bool operator !=(SchemaConfigSchemaType left, SchemaConfigSchemaType right) => !left.Equals(right);

        public static explicit operator string(SchemaConfigSchemaType value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is SchemaConfigSchemaType other && Equals(other);
        public bool Equals(SchemaConfigSchemaType other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Determines how messages that fail to parse are handled.
    /// </summary>
    [EnumType]
    public readonly struct SchemaPackageSchematizedParsingType : IEquatable<SchemaPackageSchematizedParsingType>
    {
        private readonly string _value;

        private SchemaPackageSchematizedParsingType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Unspecified schematized parsing type, equivalent to `SOFT_FAIL`.
        /// </summary>
        public static SchemaPackageSchematizedParsingType SchematizedParsingTypeUnspecified { get; } = new SchemaPackageSchematizedParsingType("SCHEMATIZED_PARSING_TYPE_UNSPECIFIED");
        /// <summary>
        /// Messages that fail to parse are still stored and ACKed but a parser error is stored in place of the schematized data.
        /// </summary>
        public static SchemaPackageSchematizedParsingType SoftFail { get; } = new SchemaPackageSchematizedParsingType("SOFT_FAIL");
        /// <summary>
        /// Messages that fail to parse are rejected from ingestion/insertion and return an error code.
        /// </summary>
        public static SchemaPackageSchematizedParsingType HardFail { get; } = new SchemaPackageSchematizedParsingType("HARD_FAIL");

        public static bool operator ==(SchemaPackageSchematizedParsingType left, SchemaPackageSchematizedParsingType right) => left.Equals(right);
        public static bool operator !=(SchemaPackageSchematizedParsingType left, SchemaPackageSchematizedParsingType right) => !left.Equals(right);

        public static explicit operator string(SchemaPackageSchematizedParsingType value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is SchemaPackageSchematizedParsingType other && Equals(other);
        public bool Equals(SchemaPackageSchematizedParsingType other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Determines how unexpected segments (segments not matched to the schema) are handled.
    /// </summary>
    [EnumType]
    public readonly struct SchemaPackageUnexpectedSegmentHandling : IEquatable<SchemaPackageUnexpectedSegmentHandling>
    {
        private readonly string _value;

        private SchemaPackageUnexpectedSegmentHandling(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Unspecified handling mode, equivalent to FAIL.
        /// </summary>
        public static SchemaPackageUnexpectedSegmentHandling UnexpectedSegmentHandlingModeUnspecified { get; } = new SchemaPackageUnexpectedSegmentHandling("UNEXPECTED_SEGMENT_HANDLING_MODE_UNSPECIFIED");
        /// <summary>
        /// Unexpected segments fail to parse and return an error.
        /// </summary>
        public static SchemaPackageUnexpectedSegmentHandling Fail { get; } = new SchemaPackageUnexpectedSegmentHandling("FAIL");
        /// <summary>
        /// Unexpected segments do not fail, but are omitted from the output.
        /// </summary>
        public static SchemaPackageUnexpectedSegmentHandling Skip { get; } = new SchemaPackageUnexpectedSegmentHandling("SKIP");
        /// <summary>
        /// Unexpected segments do not fail, but are parsed in place and added to the current group. If a segment has a type definition, it is used, otherwise it is parsed as VARIES.
        /// </summary>
        public static SchemaPackageUnexpectedSegmentHandling Parse { get; } = new SchemaPackageUnexpectedSegmentHandling("PARSE");

        public static bool operator ==(SchemaPackageUnexpectedSegmentHandling left, SchemaPackageUnexpectedSegmentHandling right) => left.Equals(right);
        public static bool operator !=(SchemaPackageUnexpectedSegmentHandling left, SchemaPackageUnexpectedSegmentHandling right) => !left.Equals(right);

        public static explicit operator string(SchemaPackageUnexpectedSegmentHandling value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is SchemaPackageUnexpectedSegmentHandling other && Equals(other);
        public bool Equals(SchemaPackageUnexpectedSegmentHandling other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// If this is a primitive type then this field is the type of the primitive For example, STRING. Leave unspecified for composite types.
    /// </summary>
    [EnumType]
    public readonly struct TypePrimitive : IEquatable<TypePrimitive>
    {
        private readonly string _value;

        private TypePrimitive(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Not a primitive.
        /// </summary>
        public static TypePrimitive PrimitiveUnspecified { get; } = new TypePrimitive("PRIMITIVE_UNSPECIFIED");
        /// <summary>
        /// String primitive.
        /// </summary>
        public static TypePrimitive String { get; } = new TypePrimitive("STRING");
        /// <summary>
        /// Element that can have unschematized children.
        /// </summary>
        public static TypePrimitive Varies { get; } = new TypePrimitive("VARIES");
        /// <summary>
        /// Like STRING, but all delimiters below this element are ignored.
        /// </summary>
        public static TypePrimitive UnescapedString { get; } = new TypePrimitive("UNESCAPED_STRING");

        public static bool operator ==(TypePrimitive left, TypePrimitive right) => left.Equals(right);
        public static bool operator !=(TypePrimitive left, TypePrimitive right) => !left.Equals(right);

        public static explicit operator string(TypePrimitive value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is TypePrimitive other && Equals(other);
        public bool Equals(TypePrimitive other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }
}
