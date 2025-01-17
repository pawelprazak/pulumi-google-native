// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Request that a new Project be created. The result is an Operation which can be used to track the creation process. This process usually takes a few seconds, but can sometimes take much longer. The tracking Operation is automatically deleted after a few hours, so there is no need to call DeleteOperation. Authorization requires the Google IAM permission `resourcemanager.projects.create` on the specified parent for the new project. The parent is identified by a specified ResourceId, which must include both an ID and a type, such as organization. This method does not associate the new project with a billing account. You can set or update the billing account associated with a project using the [`projects.updateBillingInfo`] (/billing/reference/rest/v1/projects/updateBillingInfo) method.
 */
export class Project extends pulumi.CustomResource {
    /**
     * Get an existing Project resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Project {
        return new Project(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'google-native:cloudresourcemanager/v1:Project';

    /**
     * Returns true if the given object is an instance of Project.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Project {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Project.__pulumiType;
    }

    /**
     * Creation time. Read-only.
     */
    public readonly createTime!: pulumi.Output<string>;
    /**
     * The labels associated with this Project. Label keys must be between 1 and 63 characters long and must conform to the following regular expression: a-z{0,62}. Label values must be between 0 and 63 characters long and must conform to the regular expression [a-z0-9_-]{0,63}. A label value can be empty. No more than 256 labels can be associated with a given resource. Clients should store labels in a representation such as JSON that does not depend on specific characters being disallowed. Example: "environment" : "dev" Read-write.
     */
    public readonly labels!: pulumi.Output<{[key: string]: string}>;
    /**
     * The Project lifecycle state. Read-only.
     */
    public readonly lifecycleState!: pulumi.Output<string>;
    /**
     * The optional user-assigned display name of the Project. When present it must be between 4 to 30 characters. Allowed characters are: lowercase and uppercase letters, numbers, hyphen, single-quote, double-quote, space, and exclamation point. Example: `My Project` Read-write.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * An optional reference to a parent Resource. Supported parent types include "organization" and "folder". Once set, the parent cannot be cleared. The `parent` can be set on creation or using the `UpdateProject` method; the end user must have the `resourcemanager.projects.create` permission on the parent.
     */
    public readonly parent!: pulumi.Output<outputs.cloudresourcemanager.v1.ResourceIdResponse>;
    /**
     * The unique, user-assigned ID of the Project. It must be 6 to 30 lowercase letters, digits, or hyphens. It must start with a letter. Trailing hyphens are prohibited. Example: `tokyo-rain-123` Read-only after creation.
     */
    public readonly projectId!: pulumi.Output<string>;
    /**
     * The number uniquely identifying the project. Example: `415104041262` Read-only.
     */
    public readonly projectNumber!: pulumi.Output<string>;

    /**
     * Create a Project resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: ProjectArgs, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            resourceInputs["createTime"] = args ? args.createTime : undefined;
            resourceInputs["labels"] = args ? args.labels : undefined;
            resourceInputs["lifecycleState"] = args ? args.lifecycleState : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["parent"] = args ? args.parent : undefined;
            resourceInputs["projectId"] = args ? args.projectId : undefined;
            resourceInputs["projectNumber"] = args ? args.projectNumber : undefined;
        } else {
            resourceInputs["createTime"] = undefined /*out*/;
            resourceInputs["labels"] = undefined /*out*/;
            resourceInputs["lifecycleState"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["parent"] = undefined /*out*/;
            resourceInputs["projectId"] = undefined /*out*/;
            resourceInputs["projectNumber"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(Project.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * The set of arguments for constructing a Project resource.
 */
export interface ProjectArgs {
    /**
     * Creation time. Read-only.
     */
    createTime?: pulumi.Input<string>;
    /**
     * The labels associated with this Project. Label keys must be between 1 and 63 characters long and must conform to the following regular expression: a-z{0,62}. Label values must be between 0 and 63 characters long and must conform to the regular expression [a-z0-9_-]{0,63}. A label value can be empty. No more than 256 labels can be associated with a given resource. Clients should store labels in a representation such as JSON that does not depend on specific characters being disallowed. Example: "environment" : "dev" Read-write.
     */
    labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * The Project lifecycle state. Read-only.
     */
    lifecycleState?: pulumi.Input<enums.cloudresourcemanager.v1.ProjectLifecycleState>;
    /**
     * The optional user-assigned display name of the Project. When present it must be between 4 to 30 characters. Allowed characters are: lowercase and uppercase letters, numbers, hyphen, single-quote, double-quote, space, and exclamation point. Example: `My Project` Read-write.
     */
    name?: pulumi.Input<string>;
    /**
     * An optional reference to a parent Resource. Supported parent types include "organization" and "folder". Once set, the parent cannot be cleared. The `parent` can be set on creation or using the `UpdateProject` method; the end user must have the `resourcemanager.projects.create` permission on the parent.
     */
    parent?: pulumi.Input<inputs.cloudresourcemanager.v1.ResourceIdArgs>;
    /**
     * The unique, user-assigned ID of the Project. It must be 6 to 30 lowercase letters, digits, or hyphens. It must start with a letter. Trailing hyphens are prohibited. Example: `tokyo-rain-123` Read-only after creation.
     */
    projectId?: pulumi.Input<string>;
    /**
     * The number uniquely identifying the project. Example: `415104041262` Read-only.
     */
    projectNumber?: pulumi.Input<string>;
}
