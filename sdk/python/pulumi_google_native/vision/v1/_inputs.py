# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from ... import _utilities

__all__ = [
    'BoundingPolyArgs',
    'KeyValueArgs',
    'NormalizedVertexArgs',
    'VertexArgs',
]

@pulumi.input_type
class BoundingPolyArgs:
    def __init__(__self__, *,
                 normalized_vertices: Optional[pulumi.Input[Sequence[pulumi.Input['NormalizedVertexArgs']]]] = None,
                 vertices: Optional[pulumi.Input[Sequence[pulumi.Input['VertexArgs']]]] = None):
        """
        A bounding polygon for the detected image annotation.
        :param pulumi.Input[Sequence[pulumi.Input['NormalizedVertexArgs']]] normalized_vertices: The bounding polygon normalized vertices.
        :param pulumi.Input[Sequence[pulumi.Input['VertexArgs']]] vertices: The bounding polygon vertices.
        """
        if normalized_vertices is not None:
            pulumi.set(__self__, "normalized_vertices", normalized_vertices)
        if vertices is not None:
            pulumi.set(__self__, "vertices", vertices)

    @property
    @pulumi.getter(name="normalizedVertices")
    def normalized_vertices(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['NormalizedVertexArgs']]]]:
        """
        The bounding polygon normalized vertices.
        """
        return pulumi.get(self, "normalized_vertices")

    @normalized_vertices.setter
    def normalized_vertices(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['NormalizedVertexArgs']]]]):
        pulumi.set(self, "normalized_vertices", value)

    @property
    @pulumi.getter
    def vertices(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['VertexArgs']]]]:
        """
        The bounding polygon vertices.
        """
        return pulumi.get(self, "vertices")

    @vertices.setter
    def vertices(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['VertexArgs']]]]):
        pulumi.set(self, "vertices", value)


@pulumi.input_type
class KeyValueArgs:
    def __init__(__self__, *,
                 key: Optional[pulumi.Input[str]] = None,
                 value: Optional[pulumi.Input[str]] = None):
        """
        A product label represented as a key-value pair.
        :param pulumi.Input[str] key: The key of the label attached to the product. Cannot be empty and cannot exceed 128 bytes.
        :param pulumi.Input[str] value: The value of the label attached to the product. Cannot be empty and cannot exceed 128 bytes.
        """
        if key is not None:
            pulumi.set(__self__, "key", key)
        if value is not None:
            pulumi.set(__self__, "value", value)

    @property
    @pulumi.getter
    def key(self) -> Optional[pulumi.Input[str]]:
        """
        The key of the label attached to the product. Cannot be empty and cannot exceed 128 bytes.
        """
        return pulumi.get(self, "key")

    @key.setter
    def key(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "key", value)

    @property
    @pulumi.getter
    def value(self) -> Optional[pulumi.Input[str]]:
        """
        The value of the label attached to the product. Cannot be empty and cannot exceed 128 bytes.
        """
        return pulumi.get(self, "value")

    @value.setter
    def value(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "value", value)


@pulumi.input_type
class NormalizedVertexArgs:
    def __init__(__self__, *,
                 x: Optional[pulumi.Input[float]] = None,
                 y: Optional[pulumi.Input[float]] = None):
        """
        A vertex represents a 2D point in the image. NOTE: the normalized vertex coordinates are relative to the original image and range from 0 to 1.
        :param pulumi.Input[float] x: X coordinate.
        :param pulumi.Input[float] y: Y coordinate.
        """
        if x is not None:
            pulumi.set(__self__, "x", x)
        if y is not None:
            pulumi.set(__self__, "y", y)

    @property
    @pulumi.getter
    def x(self) -> Optional[pulumi.Input[float]]:
        """
        X coordinate.
        """
        return pulumi.get(self, "x")

    @x.setter
    def x(self, value: Optional[pulumi.Input[float]]):
        pulumi.set(self, "x", value)

    @property
    @pulumi.getter
    def y(self) -> Optional[pulumi.Input[float]]:
        """
        Y coordinate.
        """
        return pulumi.get(self, "y")

    @y.setter
    def y(self, value: Optional[pulumi.Input[float]]):
        pulumi.set(self, "y", value)


@pulumi.input_type
class VertexArgs:
    def __init__(__self__, *,
                 x: Optional[pulumi.Input[int]] = None,
                 y: Optional[pulumi.Input[int]] = None):
        """
        A vertex represents a 2D point in the image. NOTE: the vertex coordinates are in the same scale as the original image.
        :param pulumi.Input[int] x: X coordinate.
        :param pulumi.Input[int] y: Y coordinate.
        """
        if x is not None:
            pulumi.set(__self__, "x", x)
        if y is not None:
            pulumi.set(__self__, "y", y)

    @property
    @pulumi.getter
    def x(self) -> Optional[pulumi.Input[int]]:
        """
        X coordinate.
        """
        return pulumi.get(self, "x")

    @x.setter
    def x(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "x", value)

    @property
    @pulumi.getter
    def y(self) -> Optional[pulumi.Input[int]]:
        """
        Y coordinate.
        """
        return pulumi.get(self, "y")

    @y.setter
    def y(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "y", value)


