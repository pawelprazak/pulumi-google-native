// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.Datastream.V1.Outputs
{

    /// <summary>
    /// Oracle Column.
    /// </summary>
    [OutputType]
    public sealed class OracleColumnResponse
    {
        /// <summary>
        /// Column name.
        /// </summary>
        public readonly string Column;
        /// <summary>
        /// The Oracle data type.
        /// </summary>
        public readonly string DataType;
        /// <summary>
        /// Column encoding.
        /// </summary>
        public readonly string Encoding;
        /// <summary>
        /// Column length.
        /// </summary>
        public readonly int Length;
        /// <summary>
        /// Whether or not the column can accept a null value.
        /// </summary>
        public readonly bool Nullable;
        /// <summary>
        /// The ordinal position of the column in the table.
        /// </summary>
        public readonly int OrdinalPosition;
        /// <summary>
        /// Column precision.
        /// </summary>
        public readonly int Precision;
        /// <summary>
        /// Whether or not the column represents a primary key.
        /// </summary>
        public readonly bool PrimaryKey;
        /// <summary>
        /// Column scale.
        /// </summary>
        public readonly int Scale;

        [OutputConstructor]
        private OracleColumnResponse(
            string column,

            string dataType,

            string encoding,

            int length,

            bool nullable,

            int ordinalPosition,

            int precision,

            bool primaryKey,

            int scale)
        {
            Column = column;
            DataType = dataType;
            Encoding = encoding;
            Length = length;
            Nullable = nullable;
            OrdinalPosition = ordinalPosition;
            Precision = precision;
            PrimaryKey = primaryKey;
            Scale = scale;
        }
    }
}