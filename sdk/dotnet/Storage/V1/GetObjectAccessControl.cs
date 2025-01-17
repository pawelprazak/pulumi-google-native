// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.GoogleNative.Storage.V1
{
    public static class GetObjectAccessControl
    {
        /// <summary>
        /// Returns the ACL entry for the specified entity on the specified object.
        /// </summary>
        public static Task<GetObjectAccessControlResult> InvokeAsync(GetObjectAccessControlArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetObjectAccessControlResult>("google-native:storage/v1:getObjectAccessControl", args ?? new GetObjectAccessControlArgs(), options.WithDefaults());

        /// <summary>
        /// Returns the ACL entry for the specified entity on the specified object.
        /// </summary>
        public static Output<GetObjectAccessControlResult> Invoke(GetObjectAccessControlInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetObjectAccessControlResult>("google-native:storage/v1:getObjectAccessControl", args ?? new GetObjectAccessControlInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetObjectAccessControlArgs : Pulumi.InvokeArgs
    {
        [Input("bucket", required: true)]
        public string Bucket { get; set; } = null!;

        [Input("entity", required: true)]
        public string Entity { get; set; } = null!;

        [Input("generation")]
        public string? Generation { get; set; }

        [Input("object", required: true)]
        public string Object { get; set; } = null!;

        [Input("userProject")]
        public string? UserProject { get; set; }

        public GetObjectAccessControlArgs()
        {
        }
    }

    public sealed class GetObjectAccessControlInvokeArgs : Pulumi.InvokeArgs
    {
        [Input("bucket", required: true)]
        public Input<string> Bucket { get; set; } = null!;

        [Input("entity", required: true)]
        public Input<string> Entity { get; set; } = null!;

        [Input("generation")]
        public Input<string>? Generation { get; set; }

        [Input("object", required: true)]
        public Input<string> Object { get; set; } = null!;

        [Input("userProject")]
        public Input<string>? UserProject { get; set; }

        public GetObjectAccessControlInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetObjectAccessControlResult
    {
        /// <summary>
        /// The name of the bucket.
        /// </summary>
        public readonly string Bucket;
        /// <summary>
        /// The domain associated with the entity, if any.
        /// </summary>
        public readonly string Domain;
        /// <summary>
        /// The email address associated with the entity, if any.
        /// </summary>
        public readonly string Email;
        /// <summary>
        /// The entity holding the permission, in one of the following forms: 
        /// - user-userId 
        /// - user-email 
        /// - group-groupId 
        /// - group-email 
        /// - domain-domain 
        /// - project-team-projectId 
        /// - allUsers 
        /// - allAuthenticatedUsers Examples: 
        /// - The user liz@example.com would be user-liz@example.com. 
        /// - The group example@googlegroups.com would be group-example@googlegroups.com. 
        /// - To refer to all members of the Google Apps for Business domain example.com, the entity would be domain-example.com.
        /// </summary>
        public readonly string Entity;
        /// <summary>
        /// The ID for the entity, if any.
        /// </summary>
        public readonly string EntityId;
        /// <summary>
        /// HTTP 1.1 Entity tag for the access-control entry.
        /// </summary>
        public readonly string Etag;
        /// <summary>
        /// The content generation of the object, if applied to an object.
        /// </summary>
        public readonly string Generation;
        /// <summary>
        /// The kind of item this is. For object access control entries, this is always storage#objectAccessControl.
        /// </summary>
        public readonly string Kind;
        /// <summary>
        /// The name of the object, if applied to an object.
        /// </summary>
        public readonly string Object;
        /// <summary>
        /// The project team associated with the entity, if any.
        /// </summary>
        public readonly Outputs.ObjectAccessControlProjectTeamResponse ProjectTeam;
        /// <summary>
        /// The access permission for the entity.
        /// </summary>
        public readonly string Role;
        /// <summary>
        /// The link to this access-control entry.
        /// </summary>
        public readonly string SelfLink;

        [OutputConstructor]
        private GetObjectAccessControlResult(
            string bucket,

            string domain,

            string email,

            string entity,

            string entityId,

            string etag,

            string generation,

            string kind,

            string @object,

            Outputs.ObjectAccessControlProjectTeamResponse projectTeam,

            string role,

            string selfLink)
        {
            Bucket = bucket;
            Domain = domain;
            Email = email;
            Entity = entity;
            EntityId = entityId;
            Etag = etag;
            Generation = generation;
            Kind = kind;
            Object = @object;
            ProjectTeam = projectTeam;
            Role = role;
            SelfLink = selfLink;
        }
    }
}
