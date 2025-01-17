// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

// Export members:
export * from "./asset";
export * from "./content";
export * from "./contentitem";
export * from "./entity";
export * from "./environment";
export * from "./getAsset";
export * from "./getContent";
export * from "./getContentitem";
export * from "./getEntity";
export * from "./getEnvironment";
export * from "./getLake";
export * from "./getLakeAssetIamPolicy";
export * from "./getLakeContentIamPolicy";
export * from "./getLakeContentitemIamPolicy";
export * from "./getLakeEnvironmentIamPolicy";
export * from "./getLakeIamPolicy";
export * from "./getLakeTaskIamPolicy";
export * from "./getLakeZoneIamPolicy";
export * from "./getPartition";
export * from "./getTask";
export * from "./getZone";
export * from "./lake";
export * from "./lakeAssetIamPolicy";
export * from "./lakeContentIamPolicy";
export * from "./lakeContentitemIamPolicy";
export * from "./lakeEnvironmentIamPolicy";
export * from "./lakeIamPolicy";
export * from "./lakeTaskIamPolicy";
export * from "./lakeZoneIamPolicy";
export * from "./partition";
export * from "./task";
export * from "./zone";

// Export enums:
export * from "../../types/enums/dataplex/v1";

// Import resources to register:
import { Asset } from "./asset";
import { Content } from "./content";
import { Contentitem } from "./contentitem";
import { Entity } from "./entity";
import { Environment } from "./environment";
import { Lake } from "./lake";
import { LakeAssetIamPolicy } from "./lakeAssetIamPolicy";
import { LakeContentIamPolicy } from "./lakeContentIamPolicy";
import { LakeContentitemIamPolicy } from "./lakeContentitemIamPolicy";
import { LakeEnvironmentIamPolicy } from "./lakeEnvironmentIamPolicy";
import { LakeIamPolicy } from "./lakeIamPolicy";
import { LakeTaskIamPolicy } from "./lakeTaskIamPolicy";
import { LakeZoneIamPolicy } from "./lakeZoneIamPolicy";
import { Partition } from "./partition";
import { Task } from "./task";
import { Zone } from "./zone";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "google-native:dataplex/v1:Asset":
                return new Asset(name, <any>undefined, { urn })
            case "google-native:dataplex/v1:Content":
                return new Content(name, <any>undefined, { urn })
            case "google-native:dataplex/v1:Contentitem":
                return new Contentitem(name, <any>undefined, { urn })
            case "google-native:dataplex/v1:Entity":
                return new Entity(name, <any>undefined, { urn })
            case "google-native:dataplex/v1:Environment":
                return new Environment(name, <any>undefined, { urn })
            case "google-native:dataplex/v1:Lake":
                return new Lake(name, <any>undefined, { urn })
            case "google-native:dataplex/v1:LakeAssetIamPolicy":
                return new LakeAssetIamPolicy(name, <any>undefined, { urn })
            case "google-native:dataplex/v1:LakeContentIamPolicy":
                return new LakeContentIamPolicy(name, <any>undefined, { urn })
            case "google-native:dataplex/v1:LakeContentitemIamPolicy":
                return new LakeContentitemIamPolicy(name, <any>undefined, { urn })
            case "google-native:dataplex/v1:LakeEnvironmentIamPolicy":
                return new LakeEnvironmentIamPolicy(name, <any>undefined, { urn })
            case "google-native:dataplex/v1:LakeIamPolicy":
                return new LakeIamPolicy(name, <any>undefined, { urn })
            case "google-native:dataplex/v1:LakeTaskIamPolicy":
                return new LakeTaskIamPolicy(name, <any>undefined, { urn })
            case "google-native:dataplex/v1:LakeZoneIamPolicy":
                return new LakeZoneIamPolicy(name, <any>undefined, { urn })
            case "google-native:dataplex/v1:Partition":
                return new Partition(name, <any>undefined, { urn })
            case "google-native:dataplex/v1:Task":
                return new Task(name, <any>undefined, { urn })
            case "google-native:dataplex/v1:Zone":
                return new Zone(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("google-native", "dataplex/v1", _module)
