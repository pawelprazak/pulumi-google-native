// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

/**
 * Creates a new Connectivity Test. After you create a test, the reachability analysis is performed as part of the long running operation, which completes when the analysis completes. If the endpoint specifications in `ConnectivityTest` are invalid (for example, containing non-existent resources in the network, or you don't have read permissions to the network configurations of listed projects), then the reachability result returns a value of `UNKNOWN`. If the endpoint specifications in `ConnectivityTest` are incomplete, the reachability result returns a value of AMBIGUOUS. For more information, see the Connectivity Test documentation.
 */
export class ConnectivityTest extends pulumi.CustomResource {
    /**
     * Get an existing ConnectivityTest resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): ConnectivityTest {
        return new ConnectivityTest(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'google-cloud:networkmanagement/v1:ConnectivityTest';

    /**
     * Returns true if the given object is an instance of ConnectivityTest.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ConnectivityTest {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ConnectivityTest.__pulumiType;
    }


    /**
     * Create a ConnectivityTest resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ConnectivityTestArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.parent === undefined) && !opts.urn) {
                throw new Error("Missing required property 'parent'");
            }
            inputs["createTime"] = args ? args.createTime : undefined;
            inputs["description"] = args ? args.description : undefined;
            inputs["destination"] = args ? args.destination : undefined;
            inputs["displayName"] = args ? args.displayName : undefined;
            inputs["labels"] = args ? args.labels : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["parent"] = args ? args.parent : undefined;
            inputs["protocol"] = args ? args.protocol : undefined;
            inputs["reachabilityDetails"] = args ? args.reachabilityDetails : undefined;
            inputs["relatedProjects"] = args ? args.relatedProjects : undefined;
            inputs["source"] = args ? args.source : undefined;
            inputs["testId"] = args ? args.testId : undefined;
            inputs["updateTime"] = args ? args.updateTime : undefined;
        } else {
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(ConnectivityTest.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a ConnectivityTest resource.
 */
export interface ConnectivityTestArgs {
    /**
     * Output only. The time the test was created.
     */
    readonly createTime?: pulumi.Input<string>;
    /**
     * The user-supplied description of the Connectivity Test. Maximum of 512 characters.
     */
    readonly description?: pulumi.Input<string>;
    /**
     * Required. Destination specification of the Connectivity Test. You can use a combination of destination IP address, Compute Engine VM instance, or VPC network to uniquely identify the destination location. Even if the destination IP address is not unique, the source IP location is unique. Usually, the analysis can infer the destination endpoint from route information. If the destination you specify is a VM instance and the instance has multiple network interfaces, then you must also specify either a destination IP address or VPC network to identify the destination interface. A reachability analysis proceeds even if the destination location is ambiguous. However, the result can include endpoints that you don't intend to test.
     */
    readonly destination?: pulumi.Input<inputs.networkmanagement.v1.Endpoint>;
    /**
     * Output only. The display name of a Connectivity Test.
     */
    readonly displayName?: pulumi.Input<string>;
    /**
     * Resource labels to represent user-provided metadata.
     */
    readonly labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Required. Unique name of the resource using the form: `projects/{project_id}/locations/global/connectivityTests/{test_id}`
     */
    readonly name?: pulumi.Input<string>;
    /**
     * Required. The parent resource of the Connectivity Test to create: `projects/{project_id}/locations/global`
     */
    readonly parent: pulumi.Input<string>;
    /**
     * IP Protocol of the test. When not provided, "TCP" is assumed.
     */
    readonly protocol?: pulumi.Input<string>;
    /**
     * Output only. The reachability details of this test from the latest run. The details are updated when creating a new test, updating an existing test, or triggering a one-time rerun of an existing test.
     */
    readonly reachabilityDetails?: pulumi.Input<inputs.networkmanagement.v1.ReachabilityDetails>;
    /**
     * Other projects that may be relevant for reachability analysis. This is applicable to scenarios where a test can cross project boundaries.
     */
    readonly relatedProjects?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Required. Source specification of the Connectivity Test. You can use a combination of source IP address, virtual machine (VM) instance, or Compute Engine network to uniquely identify the source location. Examples: If the source IP address is an internal IP address within a Google Cloud Virtual Private Cloud (VPC) network, then you must also specify the VPC network. Otherwise, specify the VM instance, which already contains its internal IP address and VPC network information. If the source of the test is within an on-premises network, then you must provide the destination VPC network. If the source endpoint is a Compute Engine VM instance with multiple network interfaces, the instance itself is not sufficient to identify the endpoint. So, you must also specify the source IP address or VPC network. A reachability analysis proceeds even if the source location is ambiguous. However, the test result may include endpoints that you don't intend to test.
     */
    readonly source?: pulumi.Input<inputs.networkmanagement.v1.Endpoint>;
    /**
     * Required. The logical name of the Connectivity Test in your project with the following restrictions: * Must contain only lowercase letters, numbers, and hyphens. * Must start with a letter. * Must be between 1-40 characters. * Must end with a number or a letter. * Must be unique within the customer project
     */
    readonly testId?: pulumi.Input<string>;
    /**
     * Output only. The time the test's configuration was updated.
     */
    readonly updateTime?: pulumi.Input<string>;
}