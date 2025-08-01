// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class SecureScoreControlDefinitionItem : IUtf8JsonSerializable, IJsonModel<SecureScoreControlDefinitionItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecureScoreControlDefinitionItem>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SecureScoreControlDefinitionItem>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecureScoreControlDefinitionItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecureScoreControlDefinitionItem)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (options.Format != "W" && Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (options.Format != "W" && Optional.IsDefined(MaxScore))
            {
                writer.WritePropertyName("maxScore"u8);
                writer.WriteNumberValue(MaxScore.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Source))
            {
                writer.WritePropertyName("source"u8);
                writer.WriteObjectValue(Source, options);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(AssessmentDefinitions))
            {
                writer.WritePropertyName("assessmentDefinitions"u8);
                writer.WriteStartArray();
                foreach (var item in AssessmentDefinitions)
                {
                    ((IJsonModel<SubResource>)item).Write(writer, options);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        SecureScoreControlDefinitionItem IJsonModel<SecureScoreControlDefinitionItem>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecureScoreControlDefinitionItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecureScoreControlDefinitionItem)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecureScoreControlDefinitionItem(document.RootElement, options);
        }

        internal static SecureScoreControlDefinitionItem DeserializeSecureScoreControlDefinitionItem(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string displayName = default;
            string description = default;
            int? maxScore = default;
            SecureScoreControlDefinitionSource source = default;
            IReadOnlyList<SubResource> assessmentDefinitions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = ModelReaderWriter.Read<SystemData>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), ModelSerializationExtensions.WireOptions, AzureResourceManagerSecurityCenterContext.Default);
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("maxScore"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maxScore = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("source"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            source = SecureScoreControlDefinitionSource.DeserializeSecureScoreControlDefinitionSource(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("assessmentDefinitions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SubResource> array = new List<SubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ModelReaderWriter.Read<SubResource>(new BinaryData(Encoding.UTF8.GetBytes(item.GetRawText())), options, AzureResourceManagerSecurityCenterContext.Default));
                            }
                            assessmentDefinitions = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SecureScoreControlDefinitionItem(
                id,
                name,
                type,
                systemData,
                displayName,
                description,
                maxScore,
                source,
                assessmentDefinitions ?? new ChangeTrackingList<SubResource>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SecureScoreControlDefinitionItem>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecureScoreControlDefinitionItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerSecurityCenterContext.Default);
                default:
                    throw new FormatException($"The model {nameof(SecureScoreControlDefinitionItem)} does not support writing '{options.Format}' format.");
            }
        }

        SecureScoreControlDefinitionItem IPersistableModel<SecureScoreControlDefinitionItem>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecureScoreControlDefinitionItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeSecureScoreControlDefinitionItem(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SecureScoreControlDefinitionItem)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecureScoreControlDefinitionItem>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
