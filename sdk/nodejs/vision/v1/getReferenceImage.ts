// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Gets information associated with a ReferenceImage. Possible errors: * Returns NOT_FOUND if the specified image does not exist.
 */
export function getReferenceImage(args: GetReferenceImageArgs, opts?: pulumi.InvokeOptions): Promise<GetReferenceImageResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("google-native:vision/v1:getReferenceImage", {
        "location": args.location,
        "productId": args.productId,
        "project": args.project,
        "referenceImageId": args.referenceImageId,
    }, opts);
}

export interface GetReferenceImageArgs {
    location: string;
    productId: string;
    project?: string;
    referenceImageId: string;
}

export interface GetReferenceImageResult {
    /**
     * Optional. Bounding polygons around the areas of interest in the reference image. If this field is empty, the system will try to detect regions of interest. At most 10 bounding polygons will be used. The provided shape is converted into a non-rotated rectangle. Once converted, the small edge of the rectangle must be greater than or equal to 300 pixels. The aspect ratio must be 1:4 or less (i.e. 1:3 is ok; 1:5 is not).
     */
    readonly boundingPolys: outputs.vision.v1.BoundingPolyResponse[];
    /**
     * The resource name of the reference image. Format is: `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID/referenceImages/IMAGE_ID`. This field is ignored when creating a reference image.
     */
    readonly name: string;
    /**
     * The Google Cloud Storage URI of the reference image. The URI must start with `gs://`.
     */
    readonly uri: string;
}

export function getReferenceImageOutput(args: GetReferenceImageOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetReferenceImageResult> {
    return pulumi.output(args).apply(a => getReferenceImage(a, opts))
}

export interface GetReferenceImageOutputArgs {
    location: pulumi.Input<string>;
    productId: pulumi.Input<string>;
    project?: pulumi.Input<string>;
    referenceImageId: pulumi.Input<string>;
}
