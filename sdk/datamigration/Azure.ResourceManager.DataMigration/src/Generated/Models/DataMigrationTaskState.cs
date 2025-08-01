// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> The state of the task. This is ignored if submitted. </summary>
    public readonly partial struct DataMigrationTaskState : IEquatable<DataMigrationTaskState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DataMigrationTaskState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DataMigrationTaskState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string QueuedValue = "Queued";
        private const string RunningValue = "Running";
        private const string CanceledValue = "Canceled";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string FailedInputValidationValue = "FailedInputValidation";
        private const string FaultedValue = "Faulted";

        /// <summary> Unknown. </summary>
        public static DataMigrationTaskState Unknown { get; } = new DataMigrationTaskState(UnknownValue);
        /// <summary> Queued. </summary>
        public static DataMigrationTaskState Queued { get; } = new DataMigrationTaskState(QueuedValue);
        /// <summary> Running. </summary>
        public static DataMigrationTaskState Running { get; } = new DataMigrationTaskState(RunningValue);
        /// <summary> Canceled. </summary>
        public static DataMigrationTaskState Canceled { get; } = new DataMigrationTaskState(CanceledValue);
        /// <summary> Succeeded. </summary>
        public static DataMigrationTaskState Succeeded { get; } = new DataMigrationTaskState(SucceededValue);
        /// <summary> Failed. </summary>
        public static DataMigrationTaskState Failed { get; } = new DataMigrationTaskState(FailedValue);
        /// <summary> FailedInputValidation. </summary>
        public static DataMigrationTaskState FailedInputValidation { get; } = new DataMigrationTaskState(FailedInputValidationValue);
        /// <summary> Faulted. </summary>
        public static DataMigrationTaskState Faulted { get; } = new DataMigrationTaskState(FaultedValue);
        /// <summary> Determines if two <see cref="DataMigrationTaskState"/> values are the same. </summary>
        public static bool operator ==(DataMigrationTaskState left, DataMigrationTaskState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DataMigrationTaskState"/> values are not the same. </summary>
        public static bool operator !=(DataMigrationTaskState left, DataMigrationTaskState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DataMigrationTaskState"/>. </summary>
        public static implicit operator DataMigrationTaskState(string value) => new DataMigrationTaskState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DataMigrationTaskState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DataMigrationTaskState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
