// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

/**
 * Creates an app associated with a developer. This API associates the developer app with the specified API product and auto-generates an API key for the app to use in calls to API proxies inside that API product. The `name` is the unique ID of the app that you can use in API calls. The `DisplayName` (set as an attribute) appears in the UI. If you don't set the `DisplayName` attribute, the `name` appears in the UI.
 */
export class GoogleCloudApigeeV1DeveloperApp extends pulumi.CustomResource {
    /**
     * Get an existing GoogleCloudApigeeV1DeveloperApp resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): GoogleCloudApigeeV1DeveloperApp {
        return new GoogleCloudApigeeV1DeveloperApp(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'google-cloud:apigee/v1:GoogleCloudApigeeV1DeveloperApp';

    /**
     * Returns true if the given object is an instance of GoogleCloudApigeeV1DeveloperApp.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is GoogleCloudApigeeV1DeveloperApp {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === GoogleCloudApigeeV1DeveloperApp.__pulumiType;
    }


    /**
     * Create a GoogleCloudApigeeV1DeveloperApp resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: GoogleCloudApigeeV1DeveloperAppArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.parent === undefined) && !opts.urn) {
                throw new Error("Missing required property 'parent'");
            }
            inputs["apiProducts"] = args ? args.apiProducts : undefined;
            inputs["appFamily"] = args ? args.appFamily : undefined;
            inputs["appId"] = args ? args.appId : undefined;
            inputs["attributes"] = args ? args.attributes : undefined;
            inputs["callbackUrl"] = args ? args.callbackUrl : undefined;
            inputs["createdAt"] = args ? args.createdAt : undefined;
            inputs["credentials"] = args ? args.credentials : undefined;
            inputs["developerId"] = args ? args.developerId : undefined;
            inputs["keyExpiresIn"] = args ? args.keyExpiresIn : undefined;
            inputs["lastModifiedAt"] = args ? args.lastModifiedAt : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["parent"] = args ? args.parent : undefined;
            inputs["scopes"] = args ? args.scopes : undefined;
            inputs["status"] = args ? args.status : undefined;
        } else {
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(GoogleCloudApigeeV1DeveloperApp.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a GoogleCloudApigeeV1DeveloperApp resource.
 */
export interface GoogleCloudApigeeV1DeveloperAppArgs {
    /**
     * List of API products associated with the developer app.
     */
    readonly apiProducts?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Developer app family.
     */
    readonly appFamily?: pulumi.Input<string>;
    /**
     * ID of the developer app.
     */
    readonly appId?: pulumi.Input<string>;
    /**
     * List of attributes for the developer app.
     */
    readonly attributes?: pulumi.Input<pulumi.Input<inputs.apigee.v1.GoogleCloudApigeeV1Attribute>[]>;
    /**
     * Callback URL used by OAuth 2.0 authorization servers to communicate authorization codes back to developer apps.
     */
    readonly callbackUrl?: pulumi.Input<string>;
    /**
     * Output only. Time the developer app was created in milliseconds since epoch.
     */
    readonly createdAt?: pulumi.Input<string>;
    /**
     * Output only. Set of credentials for the developer app consisting of the consumer key/secret pairs associated with the API products.
     */
    readonly credentials?: pulumi.Input<pulumi.Input<inputs.apigee.v1.GoogleCloudApigeeV1Credential>[]>;
    /**
     * ID of the developer.
     */
    readonly developerId?: pulumi.Input<string>;
    /**
     * Expiration time, in milliseconds, for the consumer key that is generated for the developer app. If not set or left to the default value of `-1`, the API key never expires. The expiration time can't be updated after it is set.
     */
    readonly keyExpiresIn?: pulumi.Input<string>;
    /**
     * Output only. Time the developer app was modified in milliseconds since epoch.
     */
    readonly lastModifiedAt?: pulumi.Input<string>;
    /**
     * Name of the developer app.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * Required. Name of the developer. Use the following structure in your request: `organizations/{org}/developers/{developer_email}`
     */
    readonly parent: pulumi.Input<string>;
    /**
     * Scopes to apply to the developer app. The specified scopes must already exist for the API product that you associate with the developer app.
     */
    readonly scopes?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Status of the credential. Valid values include `approved` or `revoked`.
     */
    readonly status?: pulumi.Input<string>;
}