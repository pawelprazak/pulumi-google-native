// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.Monitoring.V1.Inputs
{

    /// <summary>
    /// Defines the layout properties and content for a column.
    /// </summary>
    public sealed class ColumnArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The relative weight of this column. The column weight is used to adjust the width of columns on the screen (relative to peers). Greater the weight, greater the width of the column on the screen. If omitted, a value of 1 is used while rendering.
        /// </summary>
        [Input("weight")]
        public Input<string>? Weight { get; set; }

        [Input("widgets")]
        private InputList<Inputs.WidgetArgs>? _widgets;

        /// <summary>
        /// The display widgets arranged vertically in this column.
        /// </summary>
        public InputList<Inputs.WidgetArgs> Widgets
        {
            get => _widgets ?? (_widgets = new InputList<Inputs.WidgetArgs>());
            set => _widgets = value;
        }

        public ColumnArgs()
        {
        }
    }
}