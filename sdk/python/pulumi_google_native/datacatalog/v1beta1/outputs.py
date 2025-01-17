# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from ... import _utilities
from . import outputs
from ._enums import *

__all__ = [
    'BindingResponse',
    'ExprResponse',
    'GoogleCloudDatacatalogV1beta1BigQueryDateShardedSpecResponse',
    'GoogleCloudDatacatalogV1beta1BigQueryTableSpecResponse',
    'GoogleCloudDatacatalogV1beta1ColumnSchemaResponse',
    'GoogleCloudDatacatalogV1beta1GcsFileSpecResponse',
    'GoogleCloudDatacatalogV1beta1GcsFilesetSpecResponse',
    'GoogleCloudDatacatalogV1beta1SchemaResponse',
    'GoogleCloudDatacatalogV1beta1SystemTimestampsResponse',
    'GoogleCloudDatacatalogV1beta1TableSpecResponse',
    'GoogleCloudDatacatalogV1beta1UsageSignalResponse',
    'GoogleCloudDatacatalogV1beta1ViewSpecResponse',
]

@pulumi.output_type
class BindingResponse(dict):
    """
    Associates `members`, or principals, with a `role`.
    """
    def __init__(__self__, *,
                 condition: 'outputs.ExprResponse',
                 members: Sequence[str],
                 role: str):
        """
        Associates `members`, or principals, with a `role`.
        :param 'ExprResponse' condition: The condition that is associated with this binding. If the condition evaluates to `true`, then this binding applies to the current request. If the condition evaluates to `false`, then this binding does not apply to the current request. However, a different role binding might grant the same role to one or more of the principals in this binding. To learn which resources support conditions in their IAM policies, see the [IAM documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
        :param Sequence[str] members: Specifies the principals requesting access for a Google Cloud resource. `members` can have the following values: * `allUsers`: A special identifier that represents anyone who is on the internet; with or without a Google account. * `allAuthenticatedUsers`: A special identifier that represents anyone who is authenticated with a Google account or a service account. * `user:{emailid}`: An email address that represents a specific Google account. For example, `alice@example.com` . * `serviceAccount:{emailid}`: An email address that represents a service account. For example, `my-other-app@appspot.gserviceaccount.com`. * `group:{emailid}`: An email address that represents a Google group. For example, `admins@example.com`. * `deleted:user:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing a user that has been recently deleted. For example, `alice@example.com?uid=123456789012345678901`. If the user is recovered, this value reverts to `user:{emailid}` and the recovered user retains the role in the binding. * `deleted:serviceAccount:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing a service account that has been recently deleted. For example, `my-other-app@appspot.gserviceaccount.com?uid=123456789012345678901`. If the service account is undeleted, this value reverts to `serviceAccount:{emailid}` and the undeleted service account retains the role in the binding. * `deleted:group:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing a Google group that has been recently deleted. For example, `admins@example.com?uid=123456789012345678901`. If the group is recovered, this value reverts to `group:{emailid}` and the recovered group retains the role in the binding. * `domain:{domain}`: The G Suite domain (primary) that represents all the users of that domain. For example, `google.com` or `example.com`. 
        :param str role: Role that is assigned to the list of `members`, or principals. For example, `roles/viewer`, `roles/editor`, or `roles/owner`.
        """
        pulumi.set(__self__, "condition", condition)
        pulumi.set(__self__, "members", members)
        pulumi.set(__self__, "role", role)

    @property
    @pulumi.getter
    def condition(self) -> 'outputs.ExprResponse':
        """
        The condition that is associated with this binding. If the condition evaluates to `true`, then this binding applies to the current request. If the condition evaluates to `false`, then this binding does not apply to the current request. However, a different role binding might grant the same role to one or more of the principals in this binding. To learn which resources support conditions in their IAM policies, see the [IAM documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
        """
        return pulumi.get(self, "condition")

    @property
    @pulumi.getter
    def members(self) -> Sequence[str]:
        """
        Specifies the principals requesting access for a Google Cloud resource. `members` can have the following values: * `allUsers`: A special identifier that represents anyone who is on the internet; with or without a Google account. * `allAuthenticatedUsers`: A special identifier that represents anyone who is authenticated with a Google account or a service account. * `user:{emailid}`: An email address that represents a specific Google account. For example, `alice@example.com` . * `serviceAccount:{emailid}`: An email address that represents a service account. For example, `my-other-app@appspot.gserviceaccount.com`. * `group:{emailid}`: An email address that represents a Google group. For example, `admins@example.com`. * `deleted:user:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing a user that has been recently deleted. For example, `alice@example.com?uid=123456789012345678901`. If the user is recovered, this value reverts to `user:{emailid}` and the recovered user retains the role in the binding. * `deleted:serviceAccount:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing a service account that has been recently deleted. For example, `my-other-app@appspot.gserviceaccount.com?uid=123456789012345678901`. If the service account is undeleted, this value reverts to `serviceAccount:{emailid}` and the undeleted service account retains the role in the binding. * `deleted:group:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing a Google group that has been recently deleted. For example, `admins@example.com?uid=123456789012345678901`. If the group is recovered, this value reverts to `group:{emailid}` and the recovered group retains the role in the binding. * `domain:{domain}`: The G Suite domain (primary) that represents all the users of that domain. For example, `google.com` or `example.com`. 
        """
        return pulumi.get(self, "members")

    @property
    @pulumi.getter
    def role(self) -> str:
        """
        Role that is assigned to the list of `members`, or principals. For example, `roles/viewer`, `roles/editor`, or `roles/owner`.
        """
        return pulumi.get(self, "role")


@pulumi.output_type
class ExprResponse(dict):
    """
    Represents a textual expression in the Common Expression Language (CEL) syntax. CEL is a C-like expression language. The syntax and semantics of CEL are documented at https://github.com/google/cel-spec. Example (Comparison): title: "Summary size limit" description: "Determines if a summary is less than 100 chars" expression: "document.summary.size() < 100" Example (Equality): title: "Requestor is owner" description: "Determines if requestor is the document owner" expression: "document.owner == request.auth.claims.email" Example (Logic): title: "Public documents" description: "Determine whether the document should be publicly visible" expression: "document.type != 'private' && document.type != 'internal'" Example (Data Manipulation): title: "Notification string" description: "Create a notification string with a timestamp." expression: "'New message received at ' + string(document.create_time)" The exact variables and functions that may be referenced within an expression are determined by the service that evaluates it. See the service documentation for additional information.
    """
    def __init__(__self__, *,
                 description: str,
                 expression: str,
                 location: str,
                 title: str):
        """
        Represents a textual expression in the Common Expression Language (CEL) syntax. CEL is a C-like expression language. The syntax and semantics of CEL are documented at https://github.com/google/cel-spec. Example (Comparison): title: "Summary size limit" description: "Determines if a summary is less than 100 chars" expression: "document.summary.size() < 100" Example (Equality): title: "Requestor is owner" description: "Determines if requestor is the document owner" expression: "document.owner == request.auth.claims.email" Example (Logic): title: "Public documents" description: "Determine whether the document should be publicly visible" expression: "document.type != 'private' && document.type != 'internal'" Example (Data Manipulation): title: "Notification string" description: "Create a notification string with a timestamp." expression: "'New message received at ' + string(document.create_time)" The exact variables and functions that may be referenced within an expression are determined by the service that evaluates it. See the service documentation for additional information.
        :param str description: Optional. Description of the expression. This is a longer text which describes the expression, e.g. when hovered over it in a UI.
        :param str expression: Textual representation of an expression in Common Expression Language syntax.
        :param str location: Optional. String indicating the location of the expression for error reporting, e.g. a file name and a position in the file.
        :param str title: Optional. Title for the expression, i.e. a short string describing its purpose. This can be used e.g. in UIs which allow to enter the expression.
        """
        pulumi.set(__self__, "description", description)
        pulumi.set(__self__, "expression", expression)
        pulumi.set(__self__, "location", location)
        pulumi.set(__self__, "title", title)

    @property
    @pulumi.getter
    def description(self) -> str:
        """
        Optional. Description of the expression. This is a longer text which describes the expression, e.g. when hovered over it in a UI.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def expression(self) -> str:
        """
        Textual representation of an expression in Common Expression Language syntax.
        """
        return pulumi.get(self, "expression")

    @property
    @pulumi.getter
    def location(self) -> str:
        """
        Optional. String indicating the location of the expression for error reporting, e.g. a file name and a position in the file.
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter
    def title(self) -> str:
        """
        Optional. Title for the expression, i.e. a short string describing its purpose. This can be used e.g. in UIs which allow to enter the expression.
        """
        return pulumi.get(self, "title")


@pulumi.output_type
class GoogleCloudDatacatalogV1beta1BigQueryDateShardedSpecResponse(dict):
    """
    Spec for a group of BigQuery tables with name pattern `[prefix]YYYYMMDD`. Context: https://cloud.google.com/bigquery/docs/partitioned-tables#partitioning_versus_sharding
    """
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "shardCount":
            suggest = "shard_count"
        elif key == "tablePrefix":
            suggest = "table_prefix"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in GoogleCloudDatacatalogV1beta1BigQueryDateShardedSpecResponse. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        GoogleCloudDatacatalogV1beta1BigQueryDateShardedSpecResponse.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        GoogleCloudDatacatalogV1beta1BigQueryDateShardedSpecResponse.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 dataset: str,
                 shard_count: str,
                 table_prefix: str):
        """
        Spec for a group of BigQuery tables with name pattern `[prefix]YYYYMMDD`. Context: https://cloud.google.com/bigquery/docs/partitioned-tables#partitioning_versus_sharding
        :param str dataset: The Data Catalog resource name of the dataset entry the current table belongs to, for example, `projects/{project_id}/locations/{location}/entrygroups/{entry_group_id}/entries/{entry_id}`.
        :param str shard_count: Total number of shards.
        :param str table_prefix: The table name prefix of the shards. The name of any given shard is `[table_prefix]YYYYMMDD`, for example, for shard `MyTable20180101`, the `table_prefix` is `MyTable`.
        """
        pulumi.set(__self__, "dataset", dataset)
        pulumi.set(__self__, "shard_count", shard_count)
        pulumi.set(__self__, "table_prefix", table_prefix)

    @property
    @pulumi.getter
    def dataset(self) -> str:
        """
        The Data Catalog resource name of the dataset entry the current table belongs to, for example, `projects/{project_id}/locations/{location}/entrygroups/{entry_group_id}/entries/{entry_id}`.
        """
        return pulumi.get(self, "dataset")

    @property
    @pulumi.getter(name="shardCount")
    def shard_count(self) -> str:
        """
        Total number of shards.
        """
        return pulumi.get(self, "shard_count")

    @property
    @pulumi.getter(name="tablePrefix")
    def table_prefix(self) -> str:
        """
        The table name prefix of the shards. The name of any given shard is `[table_prefix]YYYYMMDD`, for example, for shard `MyTable20180101`, the `table_prefix` is `MyTable`.
        """
        return pulumi.get(self, "table_prefix")


@pulumi.output_type
class GoogleCloudDatacatalogV1beta1BigQueryTableSpecResponse(dict):
    """
    Describes a BigQuery table.
    """
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "tableSourceType":
            suggest = "table_source_type"
        elif key == "tableSpec":
            suggest = "table_spec"
        elif key == "viewSpec":
            suggest = "view_spec"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in GoogleCloudDatacatalogV1beta1BigQueryTableSpecResponse. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        GoogleCloudDatacatalogV1beta1BigQueryTableSpecResponse.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        GoogleCloudDatacatalogV1beta1BigQueryTableSpecResponse.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 table_source_type: str,
                 table_spec: 'outputs.GoogleCloudDatacatalogV1beta1TableSpecResponse',
                 view_spec: 'outputs.GoogleCloudDatacatalogV1beta1ViewSpecResponse'):
        """
        Describes a BigQuery table.
        :param str table_source_type: The table source type.
        :param 'GoogleCloudDatacatalogV1beta1TableSpecResponse' table_spec: Spec of a BigQuery table. This field should only be populated if `table_source_type` is `BIGQUERY_TABLE`.
        :param 'GoogleCloudDatacatalogV1beta1ViewSpecResponse' view_spec: Table view specification. This field should only be populated if `table_source_type` is `BIGQUERY_VIEW`.
        """
        pulumi.set(__self__, "table_source_type", table_source_type)
        pulumi.set(__self__, "table_spec", table_spec)
        pulumi.set(__self__, "view_spec", view_spec)

    @property
    @pulumi.getter(name="tableSourceType")
    def table_source_type(self) -> str:
        """
        The table source type.
        """
        return pulumi.get(self, "table_source_type")

    @property
    @pulumi.getter(name="tableSpec")
    def table_spec(self) -> 'outputs.GoogleCloudDatacatalogV1beta1TableSpecResponse':
        """
        Spec of a BigQuery table. This field should only be populated if `table_source_type` is `BIGQUERY_TABLE`.
        """
        return pulumi.get(self, "table_spec")

    @property
    @pulumi.getter(name="viewSpec")
    def view_spec(self) -> 'outputs.GoogleCloudDatacatalogV1beta1ViewSpecResponse':
        """
        Table view specification. This field should only be populated if `table_source_type` is `BIGQUERY_VIEW`.
        """
        return pulumi.get(self, "view_spec")


@pulumi.output_type
class GoogleCloudDatacatalogV1beta1ColumnSchemaResponse(dict):
    """
    Representation of a column within a schema. Columns could be nested inside other columns.
    """
    def __init__(__self__, *,
                 column: str,
                 description: str,
                 mode: str,
                 subcolumns: Sequence['outputs.GoogleCloudDatacatalogV1beta1ColumnSchemaResponse'],
                 type: str):
        """
        Representation of a column within a schema. Columns could be nested inside other columns.
        :param str column: Name of the column.
        :param str description: Optional. Description of the column. Default value is an empty string.
        :param str mode: Optional. A column's mode indicates whether the values in this column are required, nullable, etc. Only `NULLABLE`, `REQUIRED` and `REPEATED` are supported. Default mode is `NULLABLE`.
        :param Sequence['GoogleCloudDatacatalogV1beta1ColumnSchemaResponse'] subcolumns: Optional. Schema of sub-columns. A column can have zero or more sub-columns.
        :param str type: Type of the column.
        """
        pulumi.set(__self__, "column", column)
        pulumi.set(__self__, "description", description)
        pulumi.set(__self__, "mode", mode)
        pulumi.set(__self__, "subcolumns", subcolumns)
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter
    def column(self) -> str:
        """
        Name of the column.
        """
        return pulumi.get(self, "column")

    @property
    @pulumi.getter
    def description(self) -> str:
        """
        Optional. Description of the column. Default value is an empty string.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def mode(self) -> str:
        """
        Optional. A column's mode indicates whether the values in this column are required, nullable, etc. Only `NULLABLE`, `REQUIRED` and `REPEATED` are supported. Default mode is `NULLABLE`.
        """
        return pulumi.get(self, "mode")

    @property
    @pulumi.getter
    def subcolumns(self) -> Sequence['outputs.GoogleCloudDatacatalogV1beta1ColumnSchemaResponse']:
        """
        Optional. Schema of sub-columns. A column can have zero or more sub-columns.
        """
        return pulumi.get(self, "subcolumns")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        Type of the column.
        """
        return pulumi.get(self, "type")


@pulumi.output_type
class GoogleCloudDatacatalogV1beta1GcsFileSpecResponse(dict):
    """
    Specifications of a single file in Cloud Storage.
    """
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "filePath":
            suggest = "file_path"
        elif key == "gcsTimestamps":
            suggest = "gcs_timestamps"
        elif key == "sizeBytes":
            suggest = "size_bytes"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in GoogleCloudDatacatalogV1beta1GcsFileSpecResponse. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        GoogleCloudDatacatalogV1beta1GcsFileSpecResponse.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        GoogleCloudDatacatalogV1beta1GcsFileSpecResponse.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 file_path: str,
                 gcs_timestamps: 'outputs.GoogleCloudDatacatalogV1beta1SystemTimestampsResponse',
                 size_bytes: str):
        """
        Specifications of a single file in Cloud Storage.
        :param str file_path: The full file path. Example: `gs://bucket_name/a/b.txt`.
        :param 'GoogleCloudDatacatalogV1beta1SystemTimestampsResponse' gcs_timestamps: Timestamps about the Cloud Storage file.
        :param str size_bytes: The size of the file, in bytes.
        """
        pulumi.set(__self__, "file_path", file_path)
        pulumi.set(__self__, "gcs_timestamps", gcs_timestamps)
        pulumi.set(__self__, "size_bytes", size_bytes)

    @property
    @pulumi.getter(name="filePath")
    def file_path(self) -> str:
        """
        The full file path. Example: `gs://bucket_name/a/b.txt`.
        """
        return pulumi.get(self, "file_path")

    @property
    @pulumi.getter(name="gcsTimestamps")
    def gcs_timestamps(self) -> 'outputs.GoogleCloudDatacatalogV1beta1SystemTimestampsResponse':
        """
        Timestamps about the Cloud Storage file.
        """
        return pulumi.get(self, "gcs_timestamps")

    @property
    @pulumi.getter(name="sizeBytes")
    def size_bytes(self) -> str:
        """
        The size of the file, in bytes.
        """
        return pulumi.get(self, "size_bytes")


@pulumi.output_type
class GoogleCloudDatacatalogV1beta1GcsFilesetSpecResponse(dict):
    """
    Describes a Cloud Storage fileset entry.
    """
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "filePatterns":
            suggest = "file_patterns"
        elif key == "sampleGcsFileSpecs":
            suggest = "sample_gcs_file_specs"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in GoogleCloudDatacatalogV1beta1GcsFilesetSpecResponse. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        GoogleCloudDatacatalogV1beta1GcsFilesetSpecResponse.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        GoogleCloudDatacatalogV1beta1GcsFilesetSpecResponse.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 file_patterns: Sequence[str],
                 sample_gcs_file_specs: Sequence['outputs.GoogleCloudDatacatalogV1beta1GcsFileSpecResponse']):
        """
        Describes a Cloud Storage fileset entry.
        :param Sequence[str] file_patterns: Patterns to identify a set of files in Google Cloud Storage. See [Cloud Storage documentation](https://cloud.google.com/storage/docs/gsutil/addlhelp/WildcardNames) for more information. Note that bucket wildcards are currently not supported. Examples of valid file_patterns: * `gs://bucket_name/dir/*`: matches all files within `bucket_name/dir` directory. * `gs://bucket_name/dir/**`: matches all files in `bucket_name/dir` spanning all subdirectories. * `gs://bucket_name/file*`: matches files prefixed by `file` in `bucket_name` * `gs://bucket_name/??.txt`: matches files with two characters followed by `.txt` in `bucket_name` * `gs://bucket_name/[aeiou].txt`: matches files that contain a single vowel character followed by `.txt` in `bucket_name` * `gs://bucket_name/[a-m].txt`: matches files that contain `a`, `b`, ... or `m` followed by `.txt` in `bucket_name` * `gs://bucket_name/a/*/b`: matches all files in `bucket_name` that match `a/*/b` pattern, such as `a/c/b`, `a/d/b` * `gs://another_bucket/a.txt`: matches `gs://another_bucket/a.txt` You can combine wildcards to provide more powerful matches, for example: * `gs://bucket_name/[a-m]??.j*g`
        :param Sequence['GoogleCloudDatacatalogV1beta1GcsFileSpecResponse'] sample_gcs_file_specs: Sample files contained in this fileset, not all files contained in this fileset are represented here.
        """
        pulumi.set(__self__, "file_patterns", file_patterns)
        pulumi.set(__self__, "sample_gcs_file_specs", sample_gcs_file_specs)

    @property
    @pulumi.getter(name="filePatterns")
    def file_patterns(self) -> Sequence[str]:
        """
        Patterns to identify a set of files in Google Cloud Storage. See [Cloud Storage documentation](https://cloud.google.com/storage/docs/gsutil/addlhelp/WildcardNames) for more information. Note that bucket wildcards are currently not supported. Examples of valid file_patterns: * `gs://bucket_name/dir/*`: matches all files within `bucket_name/dir` directory. * `gs://bucket_name/dir/**`: matches all files in `bucket_name/dir` spanning all subdirectories. * `gs://bucket_name/file*`: matches files prefixed by `file` in `bucket_name` * `gs://bucket_name/??.txt`: matches files with two characters followed by `.txt` in `bucket_name` * `gs://bucket_name/[aeiou].txt`: matches files that contain a single vowel character followed by `.txt` in `bucket_name` * `gs://bucket_name/[a-m].txt`: matches files that contain `a`, `b`, ... or `m` followed by `.txt` in `bucket_name` * `gs://bucket_name/a/*/b`: matches all files in `bucket_name` that match `a/*/b` pattern, such as `a/c/b`, `a/d/b` * `gs://another_bucket/a.txt`: matches `gs://another_bucket/a.txt` You can combine wildcards to provide more powerful matches, for example: * `gs://bucket_name/[a-m]??.j*g`
        """
        return pulumi.get(self, "file_patterns")

    @property
    @pulumi.getter(name="sampleGcsFileSpecs")
    def sample_gcs_file_specs(self) -> Sequence['outputs.GoogleCloudDatacatalogV1beta1GcsFileSpecResponse']:
        """
        Sample files contained in this fileset, not all files contained in this fileset are represented here.
        """
        return pulumi.get(self, "sample_gcs_file_specs")


@pulumi.output_type
class GoogleCloudDatacatalogV1beta1SchemaResponse(dict):
    """
    Represents a schema (e.g. BigQuery, GoogleSQL, Avro schema).
    """
    def __init__(__self__, *,
                 columns: Sequence['outputs.GoogleCloudDatacatalogV1beta1ColumnSchemaResponse']):
        """
        Represents a schema (e.g. BigQuery, GoogleSQL, Avro schema).
        :param Sequence['GoogleCloudDatacatalogV1beta1ColumnSchemaResponse'] columns: Schema of columns. A maximum of 10,000 columns and sub-columns can be specified.
        """
        pulumi.set(__self__, "columns", columns)

    @property
    @pulumi.getter
    def columns(self) -> Sequence['outputs.GoogleCloudDatacatalogV1beta1ColumnSchemaResponse']:
        """
        Schema of columns. A maximum of 10,000 columns and sub-columns can be specified.
        """
        return pulumi.get(self, "columns")


@pulumi.output_type
class GoogleCloudDatacatalogV1beta1SystemTimestampsResponse(dict):
    """
    Timestamps about this resource according to a particular system.
    """
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "createTime":
            suggest = "create_time"
        elif key == "expireTime":
            suggest = "expire_time"
        elif key == "updateTime":
            suggest = "update_time"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in GoogleCloudDatacatalogV1beta1SystemTimestampsResponse. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        GoogleCloudDatacatalogV1beta1SystemTimestampsResponse.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        GoogleCloudDatacatalogV1beta1SystemTimestampsResponse.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 create_time: str,
                 expire_time: str,
                 update_time: str):
        """
        Timestamps about this resource according to a particular system.
        :param str create_time: The creation time of the resource within the given system.
        :param str expire_time: The expiration time of the resource within the given system. Currently only apllicable to BigQuery resources.
        :param str update_time: The last-modified time of the resource within the given system.
        """
        pulumi.set(__self__, "create_time", create_time)
        pulumi.set(__self__, "expire_time", expire_time)
        pulumi.set(__self__, "update_time", update_time)

    @property
    @pulumi.getter(name="createTime")
    def create_time(self) -> str:
        """
        The creation time of the resource within the given system.
        """
        return pulumi.get(self, "create_time")

    @property
    @pulumi.getter(name="expireTime")
    def expire_time(self) -> str:
        """
        The expiration time of the resource within the given system. Currently only apllicable to BigQuery resources.
        """
        return pulumi.get(self, "expire_time")

    @property
    @pulumi.getter(name="updateTime")
    def update_time(self) -> str:
        """
        The last-modified time of the resource within the given system.
        """
        return pulumi.get(self, "update_time")


@pulumi.output_type
class GoogleCloudDatacatalogV1beta1TableSpecResponse(dict):
    """
    Normal BigQuery table spec.
    """
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "groupedEntry":
            suggest = "grouped_entry"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in GoogleCloudDatacatalogV1beta1TableSpecResponse. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        GoogleCloudDatacatalogV1beta1TableSpecResponse.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        GoogleCloudDatacatalogV1beta1TableSpecResponse.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 grouped_entry: str):
        """
        Normal BigQuery table spec.
        :param str grouped_entry: If the table is a dated shard, i.e., with name pattern `[prefix]YYYYMMDD`, `grouped_entry` is the Data Catalog resource name of the date sharded grouped entry, for example, `projects/{project_id}/locations/{location}/entrygroups/{entry_group_id}/entries/{entry_id}`. Otherwise, `grouped_entry` is empty.
        """
        pulumi.set(__self__, "grouped_entry", grouped_entry)

    @property
    @pulumi.getter(name="groupedEntry")
    def grouped_entry(self) -> str:
        """
        If the table is a dated shard, i.e., with name pattern `[prefix]YYYYMMDD`, `grouped_entry` is the Data Catalog resource name of the date sharded grouped entry, for example, `projects/{project_id}/locations/{location}/entrygroups/{entry_group_id}/entries/{entry_id}`. Otherwise, `grouped_entry` is empty.
        """
        return pulumi.get(self, "grouped_entry")


@pulumi.output_type
class GoogleCloudDatacatalogV1beta1UsageSignalResponse(dict):
    """
    The set of all usage signals that we store in Data Catalog.
    """
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "updateTime":
            suggest = "update_time"
        elif key == "usageWithinTimeRange":
            suggest = "usage_within_time_range"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in GoogleCloudDatacatalogV1beta1UsageSignalResponse. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        GoogleCloudDatacatalogV1beta1UsageSignalResponse.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        GoogleCloudDatacatalogV1beta1UsageSignalResponse.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 update_time: str,
                 usage_within_time_range: Mapping[str, str]):
        """
        The set of all usage signals that we store in Data Catalog.
        :param str update_time: The timestamp of the end of the usage statistics duration.
        :param Mapping[str, str] usage_within_time_range: Usage statistics over each of the pre-defined time ranges, supported strings for time ranges are {"24H", "7D", "30D"}.
        """
        pulumi.set(__self__, "update_time", update_time)
        pulumi.set(__self__, "usage_within_time_range", usage_within_time_range)

    @property
    @pulumi.getter(name="updateTime")
    def update_time(self) -> str:
        """
        The timestamp of the end of the usage statistics duration.
        """
        return pulumi.get(self, "update_time")

    @property
    @pulumi.getter(name="usageWithinTimeRange")
    def usage_within_time_range(self) -> Mapping[str, str]:
        """
        Usage statistics over each of the pre-defined time ranges, supported strings for time ranges are {"24H", "7D", "30D"}.
        """
        return pulumi.get(self, "usage_within_time_range")


@pulumi.output_type
class GoogleCloudDatacatalogV1beta1ViewSpecResponse(dict):
    """
    Table view specification.
    """
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "viewQuery":
            suggest = "view_query"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in GoogleCloudDatacatalogV1beta1ViewSpecResponse. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        GoogleCloudDatacatalogV1beta1ViewSpecResponse.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        GoogleCloudDatacatalogV1beta1ViewSpecResponse.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 view_query: str):
        """
        Table view specification.
        :param str view_query: The query that defines the table view.
        """
        pulumi.set(__self__, "view_query", view_query)

    @property
    @pulumi.getter(name="viewQuery")
    def view_query(self) -> str:
        """
        The query that defines the table view.
        """
        return pulumi.get(self, "view_query")


