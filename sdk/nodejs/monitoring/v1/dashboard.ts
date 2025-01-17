// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Creates a new custom dashboard. For examples on how you can use this API to create dashboards, see Managing dashboards by API (https://cloud.google.com/monitoring/dashboards/api-dashboard). This method requires the monitoring.dashboards.create permission on the specified project. For more information about permissions, see Cloud Identity and Access Management (https://cloud.google.com/iam).
 */
export class Dashboard extends pulumi.CustomResource {
    /**
     * Get an existing Dashboard resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Dashboard {
        return new Dashboard(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'google-native:monitoring/v1:Dashboard';

    /**
     * Returns true if the given object is an instance of Dashboard.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Dashboard {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Dashboard.__pulumiType;
    }

    /**
     * The content is divided into equally spaced columns and the widgets are arranged vertically.
     */
    public readonly columnLayout!: pulumi.Output<outputs.monitoring.v1.ColumnLayoutResponse>;
    /**
     * Filters to reduce the amount of data charted based on the filter criteria.
     */
    public readonly dashboardFilters!: pulumi.Output<outputs.monitoring.v1.DashboardFilterResponse[]>;
    /**
     * The mutable, human-readable name.
     */
    public readonly displayName!: pulumi.Output<string>;
    /**
     * etag is used for optimistic concurrency control as a way to help prevent simultaneous updates of a policy from overwriting each other. An etag is returned in the response to GetDashboard, and users are expected to put that etag in the request to UpdateDashboard to ensure that their change will be applied to the same version of the Dashboard configuration. The field should not be passed during dashboard creation.
     */
    public readonly etag!: pulumi.Output<string>;
    /**
     * Content is arranged with a basic layout that re-flows a simple list of informational elements like widgets or tiles.
     */
    public readonly gridLayout!: pulumi.Output<outputs.monitoring.v1.GridLayoutResponse>;
    /**
     * Labels applied to the dashboard
     */
    public readonly labels!: pulumi.Output<{[key: string]: string}>;
    /**
     * The content is arranged as a grid of tiles, with each content widget occupying one or more grid blocks.
     */
    public readonly mosaicLayout!: pulumi.Output<outputs.monitoring.v1.MosaicLayoutResponse>;
    /**
     * Immutable. The resource name of the dashboard.
     */
    public readonly name!: pulumi.Output<string>;
    public readonly project!: pulumi.Output<string>;
    /**
     * The content is divided into equally spaced rows and the widgets are arranged horizontally.
     */
    public readonly rowLayout!: pulumi.Output<outputs.monitoring.v1.RowLayoutResponse>;
    /**
     * If set, validate the request and preview the review, but do not actually save it.
     */
    public readonly validateOnly!: pulumi.Output<string | undefined>;

    /**
     * Create a Dashboard resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: DashboardArgs, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.displayName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'displayName'");
            }
            resourceInputs["columnLayout"] = args ? args.columnLayout : undefined;
            resourceInputs["dashboardFilters"] = args ? args.dashboardFilters : undefined;
            resourceInputs["displayName"] = args ? args.displayName : undefined;
            resourceInputs["etag"] = args ? args.etag : undefined;
            resourceInputs["gridLayout"] = args ? args.gridLayout : undefined;
            resourceInputs["labels"] = args ? args.labels : undefined;
            resourceInputs["mosaicLayout"] = args ? args.mosaicLayout : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["project"] = args ? args.project : undefined;
            resourceInputs["rowLayout"] = args ? args.rowLayout : undefined;
            resourceInputs["validateOnly"] = args ? args.validateOnly : undefined;
        } else {
            resourceInputs["columnLayout"] = undefined /*out*/;
            resourceInputs["dashboardFilters"] = undefined /*out*/;
            resourceInputs["displayName"] = undefined /*out*/;
            resourceInputs["etag"] = undefined /*out*/;
            resourceInputs["gridLayout"] = undefined /*out*/;
            resourceInputs["labels"] = undefined /*out*/;
            resourceInputs["mosaicLayout"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["project"] = undefined /*out*/;
            resourceInputs["rowLayout"] = undefined /*out*/;
            resourceInputs["validateOnly"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(Dashboard.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * The set of arguments for constructing a Dashboard resource.
 */
export interface DashboardArgs {
    /**
     * The content is divided into equally spaced columns and the widgets are arranged vertically.
     */
    columnLayout?: pulumi.Input<inputs.monitoring.v1.ColumnLayoutArgs>;
    /**
     * Filters to reduce the amount of data charted based on the filter criteria.
     */
    dashboardFilters?: pulumi.Input<pulumi.Input<inputs.monitoring.v1.DashboardFilterArgs>[]>;
    /**
     * The mutable, human-readable name.
     */
    displayName: pulumi.Input<string>;
    /**
     * etag is used for optimistic concurrency control as a way to help prevent simultaneous updates of a policy from overwriting each other. An etag is returned in the response to GetDashboard, and users are expected to put that etag in the request to UpdateDashboard to ensure that their change will be applied to the same version of the Dashboard configuration. The field should not be passed during dashboard creation.
     */
    etag?: pulumi.Input<string>;
    /**
     * Content is arranged with a basic layout that re-flows a simple list of informational elements like widgets or tiles.
     */
    gridLayout?: pulumi.Input<inputs.monitoring.v1.GridLayoutArgs>;
    /**
     * Labels applied to the dashboard
     */
    labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * The content is arranged as a grid of tiles, with each content widget occupying one or more grid blocks.
     */
    mosaicLayout?: pulumi.Input<inputs.monitoring.v1.MosaicLayoutArgs>;
    /**
     * Immutable. The resource name of the dashboard.
     */
    name?: pulumi.Input<string>;
    project?: pulumi.Input<string>;
    /**
     * The content is divided into equally spaced rows and the widgets are arranged horizontally.
     */
    rowLayout?: pulumi.Input<inputs.monitoring.v1.RowLayoutArgs>;
    /**
     * If set, validate the request and preview the review, but do not actually save it.
     */
    validateOnly?: pulumi.Input<string>;
}
