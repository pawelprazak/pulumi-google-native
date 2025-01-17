// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.Compute.V1
{
    public static class GetFirewall
    {
        /// <summary>
        /// Returns the specified firewall.
        /// </summary>
        public static Task<GetFirewallResult> InvokeAsync(GetFirewallArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetFirewallResult>("google-native:compute/v1:getFirewall", args ?? new GetFirewallArgs(), options.WithDefaults());

        /// <summary>
        /// Returns the specified firewall.
        /// </summary>
        public static Output<GetFirewallResult> Invoke(GetFirewallInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetFirewallResult>("google-native:compute/v1:getFirewall", args ?? new GetFirewallInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetFirewallArgs : Pulumi.InvokeArgs
    {
        [Input("firewall", required: true)]
        public string Firewall { get; set; } = null!;

        [Input("project")]
        public string? Project { get; set; }

        public GetFirewallArgs()
        {
        }
    }

    public sealed class GetFirewallInvokeArgs : Pulumi.InvokeArgs
    {
        [Input("firewall", required: true)]
        public Input<string> Firewall { get; set; } = null!;

        [Input("project")]
        public Input<string>? Project { get; set; }

        public GetFirewallInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetFirewallResult
    {
        /// <summary>
        /// The list of ALLOW rules specified by this firewall. Each rule specifies a protocol and port-range tuple that describes a permitted connection.
        /// </summary>
        public readonly ImmutableArray<Outputs.FirewallAllowedItemResponse> Allowed;
        /// <summary>
        /// Creation timestamp in RFC3339 text format.
        /// </summary>
        public readonly string CreationTimestamp;
        /// <summary>
        /// The list of DENY rules specified by this firewall. Each rule specifies a protocol and port-range tuple that describes a denied connection.
        /// </summary>
        public readonly ImmutableArray<Outputs.FirewallDeniedItemResponse> Denied;
        /// <summary>
        /// An optional description of this resource. Provide this field when you create the resource.
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// If destination ranges are specified, the firewall rule applies only to traffic that has destination IP address in these ranges. These ranges must be expressed in CIDR format. Both IPv4 and IPv6 are supported.
        /// </summary>
        public readonly ImmutableArray<string> DestinationRanges;
        /// <summary>
        /// Direction of traffic to which this firewall applies, either `INGRESS` or `EGRESS`. The default is `INGRESS`. For `INGRESS` traffic, you cannot specify the destinationRanges field, and for `EGRESS` traffic, you cannot specify the sourceRanges or sourceTags fields.
        /// </summary>
        public readonly string Direction;
        /// <summary>
        /// Denotes whether the firewall rule is disabled. When set to true, the firewall rule is not enforced and the network behaves as if it did not exist. If this is unspecified, the firewall rule will be enabled.
        /// </summary>
        public readonly bool Disabled;
        /// <summary>
        /// Type of the resource. Always compute#firewall for firewall rules.
        /// </summary>
        public readonly string Kind;
        /// <summary>
        /// This field denotes the logging options for a particular firewall rule. If logging is enabled, logs will be exported to Cloud Logging.
        /// </summary>
        public readonly Outputs.FirewallLogConfigResponse LogConfig;
        /// <summary>
        /// Name of the resource; provided by the client when the resource is created. The name must be 1-63 characters long, and comply with RFC1035. Specifically, the name must be 1-63 characters long and match the regular expression `[a-z]([-a-z0-9]*[a-z0-9])?`. The first character must be a lowercase letter, and all following characters (except for the last character) must be a dash, lowercase letter, or digit. The last character must be a lowercase letter or digit.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// URL of the network resource for this firewall rule. If not specified when creating a firewall rule, the default network is used: global/networks/default If you choose to specify this field, you can specify the network as a full or partial URL. For example, the following are all valid URLs: - https://www.googleapis.com/compute/v1/projects/myproject/global/networks/my-network - projects/myproject/global/networks/my-network - global/networks/default 
        /// </summary>
        public readonly string Network;
        /// <summary>
        /// Priority for this rule. This is an integer between `0` and `65535`, both inclusive. The default value is `1000`. Relative priorities determine which rule takes effect if multiple rules apply. Lower values indicate higher priority. For example, a rule with priority `0` has higher precedence than a rule with priority `1`. DENY rules take precedence over ALLOW rules if they have equal priority. Note that VPC networks have implied rules with a priority of `65535`. To avoid conflicts with the implied rules, use a priority number less than `65535`.
        /// </summary>
        public readonly int Priority;
        /// <summary>
        /// Server-defined URL for the resource.
        /// </summary>
        public readonly string SelfLink;
        /// <summary>
        /// If source ranges are specified, the firewall rule applies only to traffic that has a source IP address in these ranges. These ranges must be expressed in CIDR format. One or both of sourceRanges and sourceTags may be set. If both fields are set, the rule applies to traffic that has a source IP address within sourceRanges OR a source IP from a resource with a matching tag listed in the sourceTags field. The connection does not need to match both fields for the rule to apply. Both IPv4 and IPv6 are supported.
        /// </summary>
        public readonly ImmutableArray<string> SourceRanges;
        /// <summary>
        /// If source service accounts are specified, the firewall rules apply only to traffic originating from an instance with a service account in this list. Source service accounts cannot be used to control traffic to an instance's external IP address because service accounts are associated with an instance, not an IP address. sourceRanges can be set at the same time as sourceServiceAccounts. If both are set, the firewall applies to traffic that has a source IP address within the sourceRanges OR a source IP that belongs to an instance with service account listed in sourceServiceAccount. The connection does not need to match both fields for the firewall to apply. sourceServiceAccounts cannot be used at the same time as sourceTags or targetTags.
        /// </summary>
        public readonly ImmutableArray<string> SourceServiceAccounts;
        /// <summary>
        /// If source tags are specified, the firewall rule applies only to traffic with source IPs that match the primary network interfaces of VM instances that have the tag and are in the same VPC network. Source tags cannot be used to control traffic to an instance's external IP address, it only applies to traffic between instances in the same virtual network. Because tags are associated with instances, not IP addresses. One or both of sourceRanges and sourceTags may be set. If both fields are set, the firewall applies to traffic that has a source IP address within sourceRanges OR a source IP from a resource with a matching tag listed in the sourceTags field. The connection does not need to match both fields for the firewall to apply.
        /// </summary>
        public readonly ImmutableArray<string> SourceTags;
        /// <summary>
        /// A list of service accounts indicating sets of instances located in the network that may make network connections as specified in allowed[]. targetServiceAccounts cannot be used at the same time as targetTags or sourceTags. If neither targetServiceAccounts nor targetTags are specified, the firewall rule applies to all instances on the specified network.
        /// </summary>
        public readonly ImmutableArray<string> TargetServiceAccounts;
        /// <summary>
        /// A list of tags that controls which instances the firewall rule applies to. If targetTags are specified, then the firewall rule applies only to instances in the VPC network that have one of those tags. If no targetTags are specified, the firewall rule applies to all instances on the specified network.
        /// </summary>
        public readonly ImmutableArray<string> TargetTags;

        [OutputConstructor]
        private GetFirewallResult(
            ImmutableArray<Outputs.FirewallAllowedItemResponse> allowed,

            string creationTimestamp,

            ImmutableArray<Outputs.FirewallDeniedItemResponse> denied,

            string description,

            ImmutableArray<string> destinationRanges,

            string direction,

            bool disabled,

            string kind,

            Outputs.FirewallLogConfigResponse logConfig,

            string name,

            string network,

            int priority,

            string selfLink,

            ImmutableArray<string> sourceRanges,

            ImmutableArray<string> sourceServiceAccounts,

            ImmutableArray<string> sourceTags,

            ImmutableArray<string> targetServiceAccounts,

            ImmutableArray<string> targetTags)
        {
            Allowed = allowed;
            CreationTimestamp = creationTimestamp;
            Denied = denied;
            Description = description;
            DestinationRanges = destinationRanges;
            Direction = direction;
            Disabled = disabled;
            Kind = kind;
            LogConfig = logConfig;
            Name = name;
            Network = network;
            Priority = priority;
            SelfLink = selfLink;
            SourceRanges = sourceRanges;
            SourceServiceAccounts = sourceServiceAccounts;
            SourceTags = sourceTags;
            TargetServiceAccounts = targetServiceAccounts;
            TargetTags = targetTags;
        }
    }
}
