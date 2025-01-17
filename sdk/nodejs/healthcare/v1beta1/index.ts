// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

// Export members:
export * from "./annotation";
export * from "./annotationStore";
export * from "./attributeDefinition";
export * from "./consent";
export * from "./consentArtifact";
export * from "./consentStore";
export * from "./dataset";
export * from "./datasetAnnotationStoreIamPolicy";
export * from "./datasetConsentStoreIamPolicy";
export * from "./datasetDicomStoreIamPolicy";
export * from "./datasetFhirStoreIamPolicy";
export * from "./datasetHl7V2StoreIamPolicy";
export * from "./datasetIamPolicy";
export * from "./dicomStore";
export * from "./fhirStore";
export * from "./getAnnotation";
export * from "./getAnnotationStore";
export * from "./getAttributeDefinition";
export * from "./getConsent";
export * from "./getConsentArtifact";
export * from "./getConsentStore";
export * from "./getDataset";
export * from "./getDatasetAnnotationStoreIamPolicy";
export * from "./getDatasetConsentStoreIamPolicy";
export * from "./getDatasetDicomStoreIamPolicy";
export * from "./getDatasetFhirStoreIamPolicy";
export * from "./getDatasetHl7V2StoreIamPolicy";
export * from "./getDatasetIamPolicy";
export * from "./getDicomStore";
export * from "./getFhir";
export * from "./getFhirStore";
export * from "./getHl7V2Store";
export * from "./getMessage";
export * from "./getUserDataMapping";
export * from "./hl7V2Store";
export * from "./message";
export * from "./userDataMapping";

// Export enums:
export * from "../../types/enums/healthcare/v1beta1";

// Import resources to register:
import { Annotation } from "./annotation";
import { AnnotationStore } from "./annotationStore";
import { AttributeDefinition } from "./attributeDefinition";
import { Consent } from "./consent";
import { ConsentArtifact } from "./consentArtifact";
import { ConsentStore } from "./consentStore";
import { Dataset } from "./dataset";
import { DatasetAnnotationStoreIamPolicy } from "./datasetAnnotationStoreIamPolicy";
import { DatasetConsentStoreIamPolicy } from "./datasetConsentStoreIamPolicy";
import { DatasetDicomStoreIamPolicy } from "./datasetDicomStoreIamPolicy";
import { DatasetFhirStoreIamPolicy } from "./datasetFhirStoreIamPolicy";
import { DatasetHl7V2StoreIamPolicy } from "./datasetHl7V2StoreIamPolicy";
import { DatasetIamPolicy } from "./datasetIamPolicy";
import { DicomStore } from "./dicomStore";
import { FhirStore } from "./fhirStore";
import { Hl7V2Store } from "./hl7V2Store";
import { Message } from "./message";
import { UserDataMapping } from "./userDataMapping";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "google-native:healthcare/v1beta1:Annotation":
                return new Annotation(name, <any>undefined, { urn })
            case "google-native:healthcare/v1beta1:AnnotationStore":
                return new AnnotationStore(name, <any>undefined, { urn })
            case "google-native:healthcare/v1beta1:AttributeDefinition":
                return new AttributeDefinition(name, <any>undefined, { urn })
            case "google-native:healthcare/v1beta1:Consent":
                return new Consent(name, <any>undefined, { urn })
            case "google-native:healthcare/v1beta1:ConsentArtifact":
                return new ConsentArtifact(name, <any>undefined, { urn })
            case "google-native:healthcare/v1beta1:ConsentStore":
                return new ConsentStore(name, <any>undefined, { urn })
            case "google-native:healthcare/v1beta1:Dataset":
                return new Dataset(name, <any>undefined, { urn })
            case "google-native:healthcare/v1beta1:DatasetAnnotationStoreIamPolicy":
                return new DatasetAnnotationStoreIamPolicy(name, <any>undefined, { urn })
            case "google-native:healthcare/v1beta1:DatasetConsentStoreIamPolicy":
                return new DatasetConsentStoreIamPolicy(name, <any>undefined, { urn })
            case "google-native:healthcare/v1beta1:DatasetDicomStoreIamPolicy":
                return new DatasetDicomStoreIamPolicy(name, <any>undefined, { urn })
            case "google-native:healthcare/v1beta1:DatasetFhirStoreIamPolicy":
                return new DatasetFhirStoreIamPolicy(name, <any>undefined, { urn })
            case "google-native:healthcare/v1beta1:DatasetHl7V2StoreIamPolicy":
                return new DatasetHl7V2StoreIamPolicy(name, <any>undefined, { urn })
            case "google-native:healthcare/v1beta1:DatasetIamPolicy":
                return new DatasetIamPolicy(name, <any>undefined, { urn })
            case "google-native:healthcare/v1beta1:DicomStore":
                return new DicomStore(name, <any>undefined, { urn })
            case "google-native:healthcare/v1beta1:FhirStore":
                return new FhirStore(name, <any>undefined, { urn })
            case "google-native:healthcare/v1beta1:Hl7V2Store":
                return new Hl7V2Store(name, <any>undefined, { urn })
            case "google-native:healthcare/v1beta1:Message":
                return new Message(name, <any>undefined, { urn })
            case "google-native:healthcare/v1beta1:UserDataMapping":
                return new UserDataMapping(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("google-native", "healthcare/v1beta1", _module)
