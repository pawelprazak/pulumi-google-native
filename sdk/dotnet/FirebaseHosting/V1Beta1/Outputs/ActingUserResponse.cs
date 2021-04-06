// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleCloud.FirebaseHosting.V1Beta1.Outputs
{

    [OutputType]
    public sealed class ActingUserResponse
    {
        /// <summary>
        /// The email address of the user when the user performed the action.
        /// </summary>
        public readonly string Email;
        /// <summary>
        /// A profile image URL for the user. May not be present if the user has changed their email address or deleted their account.
        /// </summary>
        public readonly string ImageUrl;

        [OutputConstructor]
        private ActingUserResponse(
            string email,

            string imageUrl)
        {
            Email = email;
            ImageUrl = imageUrl;
        }
    }
}