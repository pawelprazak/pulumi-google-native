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
    /// Widget contains a single dashboard component and configuration of how to present the component in the dashboard.
    /// </summary>
    public sealed class WidgetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A chart of alert policy data.
        /// </summary>
        [Input("alertChart")]
        public Input<Inputs.AlertChartArgs>? AlertChart { get; set; }

        /// <summary>
        /// A blank space.
        /// </summary>
        [Input("blank")]
        public Input<Inputs.EmptyArgs>? Blank { get; set; }

        /// <summary>
        /// A widget that groups the other widgets. All widgets that are within the area spanned by the grouping widget are considered member widgets.
        /// </summary>
        [Input("collapsibleGroup")]
        public Input<Inputs.CollapsibleGroupArgs>? CollapsibleGroup { get; set; }

        /// <summary>
        /// A widget that shows a stream of logs.
        /// </summary>
        [Input("logsPanel")]
        public Input<Inputs.LogsPanelArgs>? LogsPanel { get; set; }

        /// <summary>
        /// A scorecard summarizing time series data.
        /// </summary>
        [Input("scorecard")]
        public Input<Inputs.ScorecardArgs>? Scorecard { get; set; }

        /// <summary>
        /// A raw string or markdown displaying textual content.
        /// </summary>
        [Input("text")]
        public Input<Inputs.TextArgs>? Text { get; set; }

        /// <summary>
        /// A widget that displays time series data in a tabular format.
        /// </summary>
        [Input("timeSeriesTable")]
        public Input<Inputs.TimeSeriesTableArgs>? TimeSeriesTable { get; set; }

        /// <summary>
        /// Optional. The title of the widget.
        /// </summary>
        [Input("title")]
        public Input<string>? Title { get; set; }

        /// <summary>
        /// A chart of time series data.
        /// </summary>
        [Input("xyChart")]
        public Input<Inputs.XyChartArgs>? XyChart { get; set; }

        public WidgetArgs()
        {
        }
    }
}
