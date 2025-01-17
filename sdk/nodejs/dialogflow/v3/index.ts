// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

// Export members:
export * from "./agent";
export * from "./entityType";
export * from "./environment";
export * from "./experiment";
export * from "./flow";
export * from "./getAgent";
export * from "./getEntityType";
export * from "./getEnvironment";
export * from "./getExperiment";
export * from "./getFlow";
export * from "./getIntent";
export * from "./getPage";
export * from "./getSecuritySetting";
export * from "./getSessionEntityType";
export * from "./getTestCase";
export * from "./getTransitionRouteGroup";
export * from "./getVersion";
export * from "./getWebhook";
export * from "./intent";
export * from "./page";
export * from "./securitySetting";
export * from "./sessionEntityType";
export * from "./testCase";
export * from "./transitionRouteGroup";
export * from "./version";
export * from "./webhook";

// Export enums:
export * from "../../types/enums/dialogflow/v3";

// Import resources to register:
import { Agent } from "./agent";
import { EntityType } from "./entityType";
import { Environment } from "./environment";
import { Experiment } from "./experiment";
import { Flow } from "./flow";
import { Intent } from "./intent";
import { Page } from "./page";
import { SecuritySetting } from "./securitySetting";
import { SessionEntityType } from "./sessionEntityType";
import { TestCase } from "./testCase";
import { TransitionRouteGroup } from "./transitionRouteGroup";
import { Version } from "./version";
import { Webhook } from "./webhook";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "google-native:dialogflow/v3:Agent":
                return new Agent(name, <any>undefined, { urn })
            case "google-native:dialogflow/v3:EntityType":
                return new EntityType(name, <any>undefined, { urn })
            case "google-native:dialogflow/v3:Environment":
                return new Environment(name, <any>undefined, { urn })
            case "google-native:dialogflow/v3:Experiment":
                return new Experiment(name, <any>undefined, { urn })
            case "google-native:dialogflow/v3:Flow":
                return new Flow(name, <any>undefined, { urn })
            case "google-native:dialogflow/v3:Intent":
                return new Intent(name, <any>undefined, { urn })
            case "google-native:dialogflow/v3:Page":
                return new Page(name, <any>undefined, { urn })
            case "google-native:dialogflow/v3:SecuritySetting":
                return new SecuritySetting(name, <any>undefined, { urn })
            case "google-native:dialogflow/v3:SessionEntityType":
                return new SessionEntityType(name, <any>undefined, { urn })
            case "google-native:dialogflow/v3:TestCase":
                return new TestCase(name, <any>undefined, { urn })
            case "google-native:dialogflow/v3:TransitionRouteGroup":
                return new TransitionRouteGroup(name, <any>undefined, { urn })
            case "google-native:dialogflow/v3:Version":
                return new Version(name, <any>undefined, { urn })
            case "google-native:dialogflow/v3:Webhook":
                return new Webhook(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("google-native", "dialogflow/v3", _module)
