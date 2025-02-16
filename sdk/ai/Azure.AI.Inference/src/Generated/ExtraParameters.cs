// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Inference
{
    /// <summary> Controls what happens if extra parameters, undefined by the REST API, are passed in the JSON request payload. </summary>
    internal readonly partial struct ExtraParameters : IEquatable<ExtraParameters>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ExtraParameters"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ExtraParameters(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ErrorValue = "error";
        private const string DropValue = "drop";
        private const string PassThroughValue = "pass-through";

        /// <summary> The service will error if it detected extra parameters in the request payload. This is the service default. </summary>
        public static ExtraParameters Error { get; } = new ExtraParameters(ErrorValue);
        /// <summary> The service will ignore (drop) extra parameters in the request payload. It will only pass the known parameters to the back-end AI model. </summary>
        public static ExtraParameters Drop { get; } = new ExtraParameters(DropValue);
        /// <summary> The service will pass extra parameters to the back-end AI model. </summary>
        public static ExtraParameters PassThrough { get; } = new ExtraParameters(PassThroughValue);
        /// <summary> Determines if two <see cref="ExtraParameters"/> values are the same. </summary>
        public static bool operator ==(ExtraParameters left, ExtraParameters right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ExtraParameters"/> values are not the same. </summary>
        public static bool operator !=(ExtraParameters left, ExtraParameters right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ExtraParameters"/>. </summary>
        public static implicit operator ExtraParameters(string value) => new ExtraParameters(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ExtraParameters other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ExtraParameters other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
