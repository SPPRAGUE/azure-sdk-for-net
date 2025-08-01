// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Input for the task that validates connection to SQL DB and target server requirements. </summary>
    public partial class ConnectToTargetSqlDBTaskInput
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ConnectToTargetSqlDBTaskInput"/>. </summary>
        /// <param name="targetConnectionInfo"> Connection information for target SQL DB. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetConnectionInfo"/> is null. </exception>
        public ConnectToTargetSqlDBTaskInput(DataMigrationSqlConnectionInfo targetConnectionInfo)
        {
            Argument.AssertNotNull(targetConnectionInfo, nameof(targetConnectionInfo));

            TargetConnectionInfo = targetConnectionInfo;
        }

        /// <summary> Initializes a new instance of <see cref="ConnectToTargetSqlDBTaskInput"/>. </summary>
        /// <param name="targetConnectionInfo"> Connection information for target SQL DB. </param>
        /// <param name="shouldQueryObjectCounts"> Boolean flag indicating whether to query object counts for each database on the target server. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConnectToTargetSqlDBTaskInput(DataMigrationSqlConnectionInfo targetConnectionInfo, bool? shouldQueryObjectCounts, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TargetConnectionInfo = targetConnectionInfo;
            ShouldQueryObjectCounts = shouldQueryObjectCounts;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ConnectToTargetSqlDBTaskInput"/> for deserialization. </summary>
        internal ConnectToTargetSqlDBTaskInput()
        {
        }

        /// <summary> Connection information for target SQL DB. </summary>
        public DataMigrationSqlConnectionInfo TargetConnectionInfo { get; set; }
        /// <summary> Boolean flag indicating whether to query object counts for each database on the target server. </summary>
        public bool? ShouldQueryObjectCounts { get; set; }
    }
}
