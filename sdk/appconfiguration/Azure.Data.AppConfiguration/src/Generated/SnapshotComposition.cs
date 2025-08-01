// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Data.AppConfiguration
{
    /// <summary> Composition types. </summary>
    public readonly partial struct SnapshotComposition : IEquatable<SnapshotComposition>
    {
        private readonly string _value;
        /// <summary> The 'key' composition type. </summary>
        private const string KeyValue = "key";
        /// <summary> The 'key_label' composition type. </summary>
        private const string KeyLabelValue = "key_label";

        /// <summary> Initializes a new instance of <see cref="SnapshotComposition"/>. </summary>
        /// <param name="value"> The value. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SnapshotComposition(string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            _value = value;
        }

        /// <summary> The 'key' composition type. </summary>
        public static SnapshotComposition Key { get; } = new SnapshotComposition(KeyValue);

        /// <summary> The 'key_label' composition type. </summary>
        public static SnapshotComposition KeyLabel { get; } = new SnapshotComposition(KeyLabelValue);

        /// <summary> Determines if two <see cref="SnapshotComposition"/> values are the same. </summary>
        /// <param name="left"> The left value to compare. </param>
        /// <param name="right"> The right value to compare. </param>
        public static bool operator ==(SnapshotComposition left, SnapshotComposition right) => left.Equals(right);

        /// <summary> Determines if two <see cref="SnapshotComposition"/> values are not the same. </summary>
        /// <param name="left"> The left value to compare. </param>
        /// <param name="right"> The right value to compare. </param>
        public static bool operator !=(SnapshotComposition left, SnapshotComposition right) => !left.Equals(right);

        /// <summary> Converts a string to a <see cref="SnapshotComposition"/>. </summary>
        /// <param name="value"> The value. </param>
        public static implicit operator SnapshotComposition(string value) => new SnapshotComposition(value);

        /// <summary> Converts a string to a <see cref="SnapshotComposition"/>. </summary>
        /// <param name="value"> The value. </param>
        public static implicit operator SnapshotComposition?(string value) => value == null ? null : new SnapshotComposition(value);

        /// <inheritdoc/>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SnapshotComposition other && Equals(other);

        /// <inheritdoc/>
        public bool Equals(SnapshotComposition other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc/>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;

        /// <inheritdoc/>
        public override string ToString() => _value;
    }
}
