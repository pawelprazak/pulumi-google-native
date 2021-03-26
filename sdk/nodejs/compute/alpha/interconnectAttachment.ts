// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

/**
 * Creates an InterconnectAttachment in the specified project using the data included in the request.
 */
export class InterconnectAttachment extends pulumi.CustomResource {
    /**
     * Get an existing InterconnectAttachment resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): InterconnectAttachment {
        return new InterconnectAttachment(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'google-cloud:compute/alpha:InterconnectAttachment';

    /**
     * Returns true if the given object is an instance of InterconnectAttachment.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is InterconnectAttachment {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === InterconnectAttachment.__pulumiType;
    }


    /**
     * Create a InterconnectAttachment resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: InterconnectAttachmentArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.project === undefined) && !opts.urn) {
                throw new Error("Missing required property 'project'");
            }
            if ((!args || args.region === undefined) && !opts.urn) {
                throw new Error("Missing required property 'region'");
            }
            inputs["adminEnabled"] = args ? args.adminEnabled : undefined;
            inputs["bandwidth"] = args ? args.bandwidth : undefined;
            inputs["candidateSubnets"] = args ? args.candidateSubnets : undefined;
            inputs["cloudRouterIpAddress"] = args ? args.cloudRouterIpAddress : undefined;
            inputs["creationTimestamp"] = args ? args.creationTimestamp : undefined;
            inputs["customerRouterIpAddress"] = args ? args.customerRouterIpAddress : undefined;
            inputs["dataplaneVersion"] = args ? args.dataplaneVersion : undefined;
            inputs["description"] = args ? args.description : undefined;
            inputs["edgeAvailabilityDomain"] = args ? args.edgeAvailabilityDomain : undefined;
            inputs["encryption"] = args ? args.encryption : undefined;
            inputs["googleReferenceId"] = args ? args.googleReferenceId : undefined;
            inputs["id"] = args ? args.id : undefined;
            inputs["interconnect"] = args ? args.interconnect : undefined;
            inputs["ipsecInternalAddresses"] = args ? args.ipsecInternalAddresses : undefined;
            inputs["kind"] = args ? args.kind : undefined;
            inputs["labelFingerprint"] = args ? args.labelFingerprint : undefined;
            inputs["labels"] = args ? args.labels : undefined;
            inputs["mtu"] = args ? args.mtu : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["operationalStatus"] = args ? args.operationalStatus : undefined;
            inputs["pairingKey"] = args ? args.pairingKey : undefined;
            inputs["partnerAsn"] = args ? args.partnerAsn : undefined;
            inputs["partnerMetadata"] = args ? args.partnerMetadata : undefined;
            inputs["privateInterconnectInfo"] = args ? args.privateInterconnectInfo : undefined;
            inputs["project"] = args ? args.project : undefined;
            inputs["region"] = args ? args.region : undefined;
            inputs["requestId"] = args ? args.requestId : undefined;
            inputs["router"] = args ? args.router : undefined;
            inputs["selfLink"] = args ? args.selfLink : undefined;
            inputs["selfLinkWithId"] = args ? args.selfLinkWithId : undefined;
            inputs["state"] = args ? args.state : undefined;
            inputs["type"] = args ? args.type : undefined;
            inputs["validateOnly"] = args ? args.validateOnly : undefined;
            inputs["vlanTag8021q"] = args ? args.vlanTag8021q : undefined;
        } else {
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(InterconnectAttachment.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a InterconnectAttachment resource.
 */
export interface InterconnectAttachmentArgs {
    /**
     * Determines whether this Attachment will carry packets. Not present for PARTNER_PROVIDER.
     */
    readonly adminEnabled?: pulumi.Input<boolean>;
    /**
     * Provisioned bandwidth capacity for the interconnect attachment. For attachments of type DEDICATED, the user can set the bandwidth. For attachments of type PARTNER, the Google Partner that is operating the interconnect must set the bandwidth. Output only for PARTNER type, mutable for PARTNER_PROVIDER and DEDICATED, and can take one of the following values: 
     * - BPS_50M: 50 Mbit/s 
     * - BPS_100M: 100 Mbit/s 
     * - BPS_200M: 200 Mbit/s 
     * - BPS_300M: 300 Mbit/s 
     * - BPS_400M: 400 Mbit/s 
     * - BPS_500M: 500 Mbit/s 
     * - BPS_1G: 1 Gbit/s 
     * - BPS_2G: 2 Gbit/s 
     * - BPS_5G: 5 Gbit/s 
     * - BPS_10G: 10 Gbit/s 
     * - BPS_20G: 20 Gbit/s 
     * - BPS_50G: 50 Gbit/s
     */
    readonly bandwidth?: pulumi.Input<string>;
    /**
     * Up to 16 candidate prefixes that can be used to restrict the allocation of cloudRouterIpAddress and customerRouterIpAddress for this attachment. All prefixes must be within link-local address space (169.254.0.0/16) and must be /29 or shorter (/28, /27, etc). Google will attempt to select an unused /29 from the supplied candidate prefix(es). The request will fail if all possible /29s are in use on Google's edge. If not supplied, Google will randomly select an unused /29 from all of link-local space.
     */
    readonly candidateSubnets?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * [Output Only] IPv4 address + prefix length to be configured on Cloud Router Interface for this interconnect attachment.
     */
    readonly cloudRouterIpAddress?: pulumi.Input<string>;
    /**
     * [Output Only] Creation timestamp in RFC3339 text format.
     */
    readonly creationTimestamp?: pulumi.Input<string>;
    /**
     * [Output Only] IPv4 address + prefix length to be configured on the customer router subinterface for this interconnect attachment.
     */
    readonly customerRouterIpAddress?: pulumi.Input<string>;
    /**
     * [Output Only] Dataplane version for this InterconnectAttachment.
     */
    readonly dataplaneVersion?: pulumi.Input<number>;
    /**
     * An optional description of this resource.
     */
    readonly description?: pulumi.Input<string>;
    /**
     * Desired availability domain for the attachment. Only available for type PARTNER, at creation time, and can take one of the following values: 
     * - AVAILABILITY_DOMAIN_ANY 
     * - AVAILABILITY_DOMAIN_1 
     * - AVAILABILITY_DOMAIN_2 For improved reliability, customers should configure a pair of attachments, one per availability domain. The selected availability domain will be provided to the Partner via the pairing key, so that the provisioned circuit will lie in the specified domain. If not specified, the value will default to AVAILABILITY_DOMAIN_ANY.
     */
    readonly edgeAvailabilityDomain?: pulumi.Input<string>;
    /**
     * Indicates the user-supplied encryption option of this interconnect attachment: 
     * - NONE is the default value, which means that the attachment carries unencrypted traffic. VMs can send traffic to, or receive traffic from, this type of attachment. 
     * - IPSEC indicates that the attachment carries only traffic encrypted by an IPsec device such as an HA VPN gateway. VMs cannot directly send traffic to, or receive traffic from, such an attachment. To use IPsec-encrypted Cloud Interconnect, create the attachment using this option.
     */
    readonly encryption?: pulumi.Input<string>;
    /**
     * [Output Only] Google reference ID, to be used when raising support tickets with Google or otherwise to debug backend connectivity issues. [Deprecated] This field is not used.
     */
    readonly googleReferenceId?: pulumi.Input<string>;
    /**
     * [Output Only] The unique identifier for the resource. This identifier is defined by the server.
     */
    readonly id?: pulumi.Input<string>;
    /**
     * URL of the underlying Interconnect object that this attachment's traffic will traverse through.
     */
    readonly interconnect?: pulumi.Input<string>;
    /**
     * URL of addresses that have been reserved for the interconnect attachment, Used only for interconnect attachment that has the encryption option as IPSEC. The addresses must be RFC 1918 IP address ranges. When creating HA VPN gateway over the interconnect attachment, if the attachment is configured to use an RFC 1918 IP address, then the VPN gateway?s IP address will be allocated from the IP address range specified here. For example, if the HA VPN gateway?s interface 0 is paired to this interconnect attachment, then an RFC 1918 IP address for the VPN gateway interface 0 will be allocated from the IP address specified for this interconnect attachment. If this field is not specified for interconnect attachment that has encryption option as IPSEC, later on when creating HA VPN gateway on this interconnect attachment, the HA VPN gateway's IP address will be allocated from regional external IP address pool.
     */
    readonly ipsecInternalAddresses?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * [Output Only] Type of the resource. Always compute#interconnectAttachment for interconnect attachments.
     */
    readonly kind?: pulumi.Input<string>;
    /**
     * A fingerprint for the labels being applied to this InterconnectAttachment, which is essentially a hash of the labels set used for optimistic locking. The fingerprint is initially generated by Compute Engine and changes after every request to modify or update labels. You must always provide an up-to-date fingerprint hash in order to update or change labels, otherwise the request will fail with error 412 conditionNotMet.
     *
     * To see the latest fingerprint, make a get() request to retrieve an InterconnectAttachment.
     */
    readonly labelFingerprint?: pulumi.Input<string>;
    /**
     * Labels for this resource. These can only be added or modified by the setLabels method. Each label key/value pair must comply with RFC1035. Label values may be empty.
     */
    readonly labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Maximum Transmission Unit (MTU), in bytes, of packets passing through this interconnect attachment. Only 1440 and 1500 are allowed. If not specified, the value will default to 1440.
     */
    readonly mtu?: pulumi.Input<number>;
    /**
     * Name of the resource. Provided by the client when the resource is created. The name must be 1-63 characters long, and comply with RFC1035. Specifically, the name must be 1-63 characters long and match the regular expression `[a-z]([-a-z0-9]*[a-z0-9])?` which means the first character must be a lowercase letter, and all following characters must be a dash, lowercase letter, or digit, except the last character, which cannot be a dash.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * [Output Only] The current status of whether or not this interconnect attachment is functional, which can take one of the following values: 
     * - OS_ACTIVE: The attachment has been turned up and is ready to use. 
     * - OS_UNPROVISIONED: The attachment is not ready to use yet, because turnup is not complete.
     */
    readonly operationalStatus?: pulumi.Input<string>;
    /**
     * [Output only for type PARTNER. Input only for PARTNER_PROVIDER. Not present for DEDICATED]. The opaque identifier of an PARTNER attachment used to initiate provisioning with a selected partner. Of the form "XXXXX/region/domain"
     */
    readonly pairingKey?: pulumi.Input<string>;
    /**
     * Optional BGP ASN for the router supplied by a Layer 3 Partner if they configured BGP on behalf of the customer. Output only for PARTNER type, input only for PARTNER_PROVIDER, not available for DEDICATED.
     */
    readonly partnerAsn?: pulumi.Input<string>;
    /**
     * Informational metadata about Partner attachments from Partners to display to customers. Output only for for PARTNER type, mutable for PARTNER_PROVIDER, not available for DEDICATED.
     */
    readonly partnerMetadata?: pulumi.Input<inputs.compute.alpha.InterconnectAttachmentPartnerMetadata>;
    /**
     * [Output Only] Information specific to an InterconnectAttachment. This property is populated if the interconnect that this is attached to is of type DEDICATED.
     */
    readonly privateInterconnectInfo?: pulumi.Input<inputs.compute.alpha.InterconnectAttachmentPrivateInfo>;
    /**
     * Project ID for this request.
     */
    readonly project: pulumi.Input<string>;
    /**
     * [Output Only] URL of the region where the regional interconnect attachment resides. You must specify this field as part of the HTTP request URL. It is not settable as a field in the request body.
     */
    readonly region: pulumi.Input<string>;
    /**
     * An optional request ID to identify requests. Specify a unique request ID so that if you must retry your request, the server will know to ignore the request if it has already been completed.
     *
     * For example, consider a situation where you make an initial request and the request times out. If you make the request again with the same request ID, the server can check if original operation with the same request ID was received, and if so, will ignore the second request. This prevents clients from accidentally creating duplicate commitments.
     *
     * The request ID must be a valid UUID with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
     */
    readonly requestId?: pulumi.Input<string>;
    /**
     * URL of the Cloud Router to be used for dynamic routing. This router must be in the same region as this InterconnectAttachment. The InterconnectAttachment will automatically connect the Interconnect to the network & region within which the Cloud Router is configured.
     */
    readonly router?: pulumi.Input<string>;
    /**
     * [Output Only] Server-defined URL for the resource.
     */
    readonly selfLink?: pulumi.Input<string>;
    /**
     * [Output Only] Server-defined URL for this resource with the resource id.
     */
    readonly selfLinkWithId?: pulumi.Input<string>;
    /**
     * [Output Only] The current state of this attachment's functionality. Enum values ACTIVE and UNPROVISIONED are shared by DEDICATED/PRIVATE, PARTNER, and PARTNER_PROVIDER interconnect attachments, while enum values PENDING_PARTNER, PARTNER_REQUEST_RECEIVED, and PENDING_CUSTOMER are used for only PARTNER and PARTNER_PROVIDER interconnect attachments. This state can take one of the following values: 
     * - ACTIVE: The attachment has been turned up and is ready to use. 
     * - UNPROVISIONED: The attachment is not ready to use yet, because turnup is not complete. 
     * - PENDING_PARTNER: A newly-created PARTNER attachment that has not yet been configured on the Partner side. 
     * - PARTNER_REQUEST_RECEIVED: A PARTNER attachment is in the process of provisioning after a PARTNER_PROVIDER attachment was created that references it. 
     * - PENDING_CUSTOMER: A PARTNER or PARTNER_PROVIDER attachment that is waiting for a customer to activate it. 
     * - DEFUNCT: The attachment was deleted externally and is no longer functional. This could be because the associated Interconnect was removed, or because the other side of a Partner attachment was deleted.
     */
    readonly state?: pulumi.Input<string>;
    /**
     * The type of interconnect attachment this is, which can take one of the following values: 
     * - DEDICATED: an attachment to a Dedicated Interconnect. 
     * - PARTNER: an attachment to a Partner Interconnect, created by the customer. 
     * - PARTNER_PROVIDER: an attachment to a Partner Interconnect, created by the partner.
     */
    readonly type?: pulumi.Input<string>;
    /**
     * If true, the request will not be committed.
     */
    readonly validateOnly?: pulumi.Input<boolean>;
    /**
     * The IEEE 802.1Q VLAN tag for this attachment, in the range 2-4094. Only specified at creation time.
     */
    readonly vlanTag8021q?: pulumi.Input<number>;
}