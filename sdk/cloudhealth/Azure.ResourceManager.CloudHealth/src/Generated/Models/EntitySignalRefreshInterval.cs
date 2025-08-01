// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.CloudHealth.Models
{
    /// <summary> Refresh interval in ISO duration format. </summary>
    public readonly partial struct EntitySignalRefreshInterval : IEquatable<EntitySignalRefreshInterval>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EntitySignalRefreshInterval"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EntitySignalRefreshInterval(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PT1MValue = "PT1M";
        private const string PT5MValue = "PT5M";
        private const string PT10MValue = "PT10M";
        private const string PT30MValue = "PT30M";
        private const string PT1HValue = "PT1H";
        private const string PT2HValue = "PT2H";

        /// <summary> One Minute. </summary>
        public static EntitySignalRefreshInterval PT1M { get; } = new EntitySignalRefreshInterval(PT1MValue);
        /// <summary> Five Minutes. </summary>
        public static EntitySignalRefreshInterval PT5M { get; } = new EntitySignalRefreshInterval(PT5MValue);
        /// <summary> Ten Minutes. </summary>
        public static EntitySignalRefreshInterval PT10M { get; } = new EntitySignalRefreshInterval(PT10MValue);
        /// <summary> Thirty Minutes. </summary>
        public static EntitySignalRefreshInterval PT30M { get; } = new EntitySignalRefreshInterval(PT30MValue);
        /// <summary> One Hour. </summary>
        public static EntitySignalRefreshInterval PT1H { get; } = new EntitySignalRefreshInterval(PT1HValue);
        /// <summary> Two Hours. </summary>
        public static EntitySignalRefreshInterval PT2H { get; } = new EntitySignalRefreshInterval(PT2HValue);
        /// <summary> Determines if two <see cref="EntitySignalRefreshInterval"/> values are the same. </summary>
        public static bool operator ==(EntitySignalRefreshInterval left, EntitySignalRefreshInterval right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EntitySignalRefreshInterval"/> values are not the same. </summary>
        public static bool operator !=(EntitySignalRefreshInterval left, EntitySignalRefreshInterval right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="EntitySignalRefreshInterval"/>. </summary>
        public static implicit operator EntitySignalRefreshInterval(string value) => new EntitySignalRefreshInterval(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EntitySignalRefreshInterval other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EntitySignalRefreshInterval other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
