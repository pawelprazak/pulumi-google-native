// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***


export const ArgumentArgumentKind = {
    ArgumentKindUnspecified: "ARGUMENT_KIND_UNSPECIFIED",
    /**
     * The argument is a variable with fully specified type, which can be a struct or an array, but not a table.
     */
    FixedType: "FIXED_TYPE",
    /**
     * The argument is any type, including struct or array, but not a table. To be added: FIXED_TABLE, ANY_TABLE
     */
    AnyType: "ANY_TYPE",
} as const;

/**
 * Optional. Defaults to FIXED_TYPE.
 */
export type ArgumentArgumentKind = (typeof ArgumentArgumentKind)[keyof typeof ArgumentArgumentKind];

export const ArgumentMode = {
    ModeUnspecified: "MODE_UNSPECIFIED",
    /**
     * The argument is input-only.
     */
    In: "IN",
    /**
     * The argument is output-only.
     */
    Out: "OUT",
    /**
     * The argument is both an input and an output.
     */
    Inout: "INOUT",
} as const;

/**
 * Optional. Specifies whether the argument is input or output. Can be set for procedures only.
 */
export type ArgumentMode = (typeof ArgumentMode)[keyof typeof ArgumentMode];

export const AuditLogConfigLogType = {
    /**
     * Default case. Should never be this.
     */
    LogTypeUnspecified: "LOG_TYPE_UNSPECIFIED",
    /**
     * Admin reads. Example: CloudIAM getIamPolicy
     */
    AdminRead: "ADMIN_READ",
    /**
     * Data writes. Example: CloudSQL Users create
     */
    DataWrite: "DATA_WRITE",
    /**
     * Data reads. Example: CloudSQL Users list
     */
    DataRead: "DATA_READ",
} as const;

/**
 * The log type that this config enables.
 */
export type AuditLogConfigLogType = (typeof AuditLogConfigLogType)[keyof typeof AuditLogConfigLogType];

export const DatasetAccessEntryTargetTypesItem = {
    /**
     * Do not use. You must set a target type explicitly.
     */
    TargetTypeUnspecified: "TARGET_TYPE_UNSPECIFIED",
    /**
     * This entry applies to views in the dataset.
     */
    Views: "VIEWS",
} as const;

export type DatasetAccessEntryTargetTypesItem = (typeof DatasetAccessEntryTargetTypesItem)[keyof typeof DatasetAccessEntryTargetTypesItem];

export const RoutineDeterminismLevel = {
    /**
     * The determinism of the UDF is unspecified.
     */
    DeterminismLevelUnspecified: "DETERMINISM_LEVEL_UNSPECIFIED",
    /**
     * The UDF is deterministic, meaning that 2 function calls with the same inputs always produce the same result, even across 2 query runs.
     */
    Deterministic: "DETERMINISTIC",
    /**
     * The UDF is not deterministic.
     */
    NotDeterministic: "NOT_DETERMINISTIC",
} as const;

/**
 * Optional. The determinism level of the JavaScript UDF, if defined.
 */
export type RoutineDeterminismLevel = (typeof RoutineDeterminismLevel)[keyof typeof RoutineDeterminismLevel];

export const RoutineLanguage = {
    LanguageUnspecified: "LANGUAGE_UNSPECIFIED",
    /**
     * SQL language.
     */
    Sql: "SQL",
    /**
     * JavaScript language.
     */
    Javascript: "JAVASCRIPT",
} as const;

/**
 * Optional. Defaults to "SQL".
 */
export type RoutineLanguage = (typeof RoutineLanguage)[keyof typeof RoutineLanguage];

export const RoutineRoutineType = {
    RoutineTypeUnspecified: "ROUTINE_TYPE_UNSPECIFIED",
    /**
     * Non-builtin permanent scalar function.
     */
    ScalarFunction: "SCALAR_FUNCTION",
    /**
     * Stored procedure.
     */
    Procedure: "PROCEDURE",
    /**
     * Non-builtin permanent TVF.
     */
    TableValuedFunction: "TABLE_VALUED_FUNCTION",
} as const;

/**
 * Required. The type of routine.
 */
export type RoutineRoutineType = (typeof RoutineRoutineType)[keyof typeof RoutineRoutineType];

export const StandardSqlDataTypeTypeKind = {
    /**
     * Invalid type.
     */
    TypeKindUnspecified: "TYPE_KIND_UNSPECIFIED",
    /**
     * Encoded as a string in decimal format.
     */
    Int64: "INT64",
    /**
     * Encoded as a boolean "false" or "true".
     */
    Bool: "BOOL",
    /**
     * Encoded as a number, or string "NaN", "Infinity" or "-Infinity".
     */
    Float64: "FLOAT64",
    /**
     * Encoded as a string value.
     */
    String: "STRING",
    /**
     * Encoded as a base64 string per RFC 4648, section 4.
     */
    Bytes: "BYTES",
    /**
     * Encoded as an RFC 3339 timestamp with mandatory "Z" time zone string: 1985-04-12T23:20:50.52Z
     */
    Timestamp: "TIMESTAMP",
    /**
     * Encoded as RFC 3339 full-date format string: 1985-04-12
     */
    Date: "DATE",
    /**
     * Encoded as RFC 3339 partial-time format string: 23:20:50.52
     */
    Time: "TIME",
    /**
     * Encoded as RFC 3339 full-date "T" partial-time: 1985-04-12T23:20:50.52
     */
    Datetime: "DATETIME",
    /**
     * Encoded as fully qualified 3 part: 0-5 15 2:30:45.6
     */
    Interval: "INTERVAL",
    /**
     * Encoded as WKT
     */
    Geography: "GEOGRAPHY",
    /**
     * Encoded as a decimal string.
     */
    Numeric: "NUMERIC",
    /**
     * Encoded as a decimal string.
     */
    Bignumeric: "BIGNUMERIC",
    /**
     * Encoded as a string.
     */
    Json: "JSON",
    /**
     * Encoded as a list with types matching Type.array_type.
     */
    Array: "ARRAY",
    /**
     * Encoded as a list with fields of type Type.struct_type[i]. List is used because a JSON object cannot have duplicate field names.
     */
    Struct: "STRUCT",
} as const;

/**
 * Required. The top level type of this field. Can be any standard SQL data type (e.g., "INT64", "DATE", "ARRAY").
 */
export type StandardSqlDataTypeTypeKind = (typeof StandardSqlDataTypeTypeKind)[keyof typeof StandardSqlDataTypeTypeKind];
