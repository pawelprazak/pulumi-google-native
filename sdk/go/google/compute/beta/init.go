// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package beta

import (
	"fmt"

	"github.com/blang/semver"
	"github.com/pulumi/pulumi-google-cloud/sdk/go/google-cloud"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

type module struct {
	version semver.Version
}

func (m *module) Version() semver.Version {
	return m.version
}

func (m *module) Construct(ctx *pulumi.Context, name, typ, urn string) (r pulumi.Resource, err error) {
	switch typ {
	case "google-cloud:compute/beta:Address":
		r, err = NewAddress(ctx, name, nil, pulumi.URN_(urn))
	case "google-cloud:compute/beta:Autoscaler":
		r, err = NewAutoscaler(ctx, name, nil, pulumi.URN_(urn))
	case "google-cloud:compute/beta:BackendBucket":
		r, err = NewBackendBucket(ctx, name, nil, pulumi.URN_(urn))
	case "google-cloud:compute/beta:BackendService":
		r, err = NewBackendService(ctx, name, nil, pulumi.URN_(urn))
	case "google-cloud:compute/beta:Commitment":
		r, err = NewCommitment(ctx, name, nil, pulumi.URN_(urn))
	case "google-cloud:compute/beta:Disk":
		r, err = NewDisk(ctx, name, nil, pulumi.URN_(urn))
	case "google-cloud:compute/beta:ExternalVpnGateway":
		r, err = NewExternalVpnGateway(ctx, name, nil, pulumi.URN_(urn))
	case "google-cloud:compute/beta:Firewall":
		r, err = NewFirewall(ctx, name, nil, pulumi.URN_(urn))
	case "google-cloud:compute/beta:FirewallPolicy":
		r, err = NewFirewallPolicy(ctx, name, nil, pulumi.URN_(urn))
	case "google-cloud:compute/beta:ForwardingRule":
		r, err = NewForwardingRule(ctx, name, nil, pulumi.URN_(urn))
	case "google-cloud:compute/beta:HealthCheck":
		r, err = NewHealthCheck(ctx, name, nil, pulumi.URN_(urn))
	case "google-cloud:compute/beta:HealthCheckService":
		r, err = NewHealthCheckService(ctx, name, nil, pulumi.URN_(urn))
	case "google-cloud:compute/beta:HttpHealthCheck":
		r, err = NewHttpHealthCheck(ctx, name, nil, pulumi.URN_(urn))
	case "google-cloud:compute/beta:HttpsHealthCheck":
		r, err = NewHttpsHealthCheck(ctx, name, nil, pulumi.URN_(urn))
	case "google-cloud:compute/beta:Image":
		r, err = NewImage(ctx, name, nil, pulumi.URN_(urn))
	case "google-cloud:compute/beta:Instance":
		r, err = NewInstance(ctx, name, nil, pulumi.URN_(urn))
	case "google-cloud:compute/beta:InstanceGroup":
		r, err = NewInstanceGroup(ctx, name, nil, pulumi.URN_(urn))
	case "google-cloud:compute/beta:InstanceGroupManager":
		r, err = NewInstanceGroupManager(ctx, name, nil, pulumi.URN_(urn))
	case "google-cloud:compute/beta:InstanceTemplate":
		r, err = NewInstanceTemplate(ctx, name, nil, pulumi.URN_(urn))
	case "google-cloud:compute/beta:Interconnect":
		r, err = NewInterconnect(ctx, name, nil, pulumi.URN_(urn))
	case "google-cloud:compute/beta:InterconnectAttachment":
		r, err = NewInterconnectAttachment(ctx, name, nil, pulumi.URN_(urn))
	case "google-cloud:compute/beta:License":
		r, err = NewLicense(ctx, name, nil, pulumi.URN_(urn))
	case "google-cloud:compute/beta:MachineImage":
		r, err = NewMachineImage(ctx, name, nil, pulumi.URN_(urn))
	case "google-cloud:compute/beta:Network":
		r, err = NewNetwork(ctx, name, nil, pulumi.URN_(urn))
	case "google-cloud:compute/beta:NetworkEndpointGroup":
		r, err = NewNetworkEndpointGroup(ctx, name, nil, pulumi.URN_(urn))
	case "google-cloud:compute/beta:NodeGroup":
		r, err = NewNodeGroup(ctx, name, nil, pulumi.URN_(urn))
	case "google-cloud:compute/beta:NodeTemplate":
		r, err = NewNodeTemplate(ctx, name, nil, pulumi.URN_(urn))
	case "google-cloud:compute/beta:NotificationEndpoint":
		r, err = NewNotificationEndpoint(ctx, name, nil, pulumi.URN_(urn))
	case "google-cloud:compute/beta:PacketMirroring":
		r, err = NewPacketMirroring(ctx, name, nil, pulumi.URN_(urn))
	case "google-cloud:compute/beta:Policy":
		r, err = NewPolicy(ctx, name, nil, pulumi.URN_(urn))
	case "google-cloud:compute/beta:PublicAdvertisedPrefix":
		r, err = NewPublicAdvertisedPrefix(ctx, name, nil, pulumi.URN_(urn))
	case "google-cloud:compute/beta:PublicDelegatedPrefix":
		r, err = NewPublicDelegatedPrefix(ctx, name, nil, pulumi.URN_(urn))
	case "google-cloud:compute/beta:Reservation":
		r, err = NewReservation(ctx, name, nil, pulumi.URN_(urn))
	case "google-cloud:compute/beta:ResourcePolicy":
		r, err = NewResourcePolicy(ctx, name, nil, pulumi.URN_(urn))
	case "google-cloud:compute/beta:Route":
		r, err = NewRoute(ctx, name, nil, pulumi.URN_(urn))
	case "google-cloud:compute/beta:Router":
		r, err = NewRouter(ctx, name, nil, pulumi.URN_(urn))
	case "google-cloud:compute/beta:SecurityPolicy":
		r, err = NewSecurityPolicy(ctx, name, nil, pulumi.URN_(urn))
	case "google-cloud:compute/beta:ServiceAttachment":
		r, err = NewServiceAttachment(ctx, name, nil, pulumi.URN_(urn))
	case "google-cloud:compute/beta:Snapshot":
		r, err = NewSnapshot(ctx, name, nil, pulumi.URN_(urn))
	case "google-cloud:compute/beta:SslCertificate":
		r, err = NewSslCertificate(ctx, name, nil, pulumi.URN_(urn))
	case "google-cloud:compute/beta:SslPolicy":
		r, err = NewSslPolicy(ctx, name, nil, pulumi.URN_(urn))
	case "google-cloud:compute/beta:Subnetwork":
		r, err = NewSubnetwork(ctx, name, nil, pulumi.URN_(urn))
	case "google-cloud:compute/beta:TargetGrpcProxy":
		r, err = NewTargetGrpcProxy(ctx, name, nil, pulumi.URN_(urn))
	case "google-cloud:compute/beta:TargetHttpProxy":
		r, err = NewTargetHttpProxy(ctx, name, nil, pulumi.URN_(urn))
	case "google-cloud:compute/beta:TargetHttpsProxy":
		r, err = NewTargetHttpsProxy(ctx, name, nil, pulumi.URN_(urn))
	case "google-cloud:compute/beta:TargetInstance":
		r, err = NewTargetInstance(ctx, name, nil, pulumi.URN_(urn))
	case "google-cloud:compute/beta:TargetPool":
		r, err = NewTargetPool(ctx, name, nil, pulumi.URN_(urn))
	case "google-cloud:compute/beta:TargetSslProxy":
		r, err = NewTargetSslProxy(ctx, name, nil, pulumi.URN_(urn))
	case "google-cloud:compute/beta:TargetTcpProxy":
		r, err = NewTargetTcpProxy(ctx, name, nil, pulumi.URN_(urn))
	case "google-cloud:compute/beta:TargetVpnGateway":
		r, err = NewTargetVpnGateway(ctx, name, nil, pulumi.URN_(urn))
	case "google-cloud:compute/beta:UrlMap":
		r, err = NewUrlMap(ctx, name, nil, pulumi.URN_(urn))
	case "google-cloud:compute/beta:VpnGateway":
		r, err = NewVpnGateway(ctx, name, nil, pulumi.URN_(urn))
	case "google-cloud:compute/beta:VpnTunnel":
		r, err = NewVpnTunnel(ctx, name, nil, pulumi.URN_(urn))
	default:
		return nil, fmt.Errorf("unknown resource type: %s", typ)
	}

	return
}

func init() {
	version, err := google - cloud.PkgVersion()
	if err != nil {
		fmt.Println("failed to determine package version. defaulting to v1: %v", err)
	}
	pulumi.RegisterResourceModule(
		"google-cloud",
		"compute/beta",
		&module{version},
	)
}