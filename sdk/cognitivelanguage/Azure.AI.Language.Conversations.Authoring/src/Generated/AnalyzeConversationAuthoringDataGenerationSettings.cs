// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Conversations.Authoring
{
    /// <summary> Settings to enable data generation for training augmentation. </summary>
    public partial class AnalyzeConversationAuthoringDataGenerationSettings
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

        /// <summary> Initializes a new instance of <see cref="AnalyzeConversationAuthoringDataGenerationSettings"/>. </summary>
        /// <param name="enableDataGeneration"> Must be explicitly set to True to enable data generation to augment training data. </param>
        /// <param name="dataGenerationConnectionInfo"> Must be filled out to enable data generation to augment training data. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataGenerationConnectionInfo"/> is null. </exception>
        public AnalyzeConversationAuthoringDataGenerationSettings(bool enableDataGeneration, AnalyzeConversationAuthoringDataGenerationConnectionInfo dataGenerationConnectionInfo)
        {
            Argument.AssertNotNull(dataGenerationConnectionInfo, nameof(dataGenerationConnectionInfo));

            EnableDataGeneration = enableDataGeneration;
            DataGenerationConnectionInfo = dataGenerationConnectionInfo;
        }

        /// <summary> Initializes a new instance of <see cref="AnalyzeConversationAuthoringDataGenerationSettings"/>. </summary>
        /// <param name="enableDataGeneration"> Must be explicitly set to True to enable data generation to augment training data. </param>
        /// <param name="dataGenerationConnectionInfo"> Must be filled out to enable data generation to augment training data. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AnalyzeConversationAuthoringDataGenerationSettings(bool enableDataGeneration, AnalyzeConversationAuthoringDataGenerationConnectionInfo dataGenerationConnectionInfo, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            EnableDataGeneration = enableDataGeneration;
            DataGenerationConnectionInfo = dataGenerationConnectionInfo;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AnalyzeConversationAuthoringDataGenerationSettings"/> for deserialization. </summary>
        internal AnalyzeConversationAuthoringDataGenerationSettings()
        {
        }

        /// <summary> Must be explicitly set to True to enable data generation to augment training data. </summary>
        public bool EnableDataGeneration { get; }
        /// <summary> Must be filled out to enable data generation to augment training data. </summary>
        public AnalyzeConversationAuthoringDataGenerationConnectionInfo DataGenerationConnectionInfo { get; }
    }
}
