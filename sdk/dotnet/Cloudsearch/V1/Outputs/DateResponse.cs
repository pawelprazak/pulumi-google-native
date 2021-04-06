// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.Cloudsearch.V1.Outputs
{

    [OutputType]
    public sealed class DateResponse
    {
        /// <summary>
        /// Day of month. Must be from 1 to 31 and valid for the year and month.
        /// </summary>
        public readonly int Day;
        /// <summary>
        /// Month of date. Must be from 1 to 12.
        /// </summary>
        public readonly int Month;
        /// <summary>
        /// Year of date. Must be from 1 to 9999.
        /// </summary>
        public readonly int Year;

        [OutputConstructor]
        private DateResponse(
            int day,

            int month,

            int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }
    }
}