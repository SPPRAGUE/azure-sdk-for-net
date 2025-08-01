// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Playwright.Models
{
    public partial class PlaywrightWorkspaceFreeTrialProperties : IUtf8JsonSerializable, IJsonModel<PlaywrightWorkspaceFreeTrialProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PlaywrightWorkspaceFreeTrialProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<PlaywrightWorkspaceFreeTrialProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PlaywrightWorkspaceFreeTrialProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PlaywrightWorkspaceFreeTrialProperties)} does not support writing '{format}' format.");
            }

            if (options.Format != "W")
            {
                writer.WritePropertyName("createdAt"u8);
                writer.WriteStringValue(CreatedOn, "O");
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("expiryAt"u8);
                writer.WriteStringValue(ExpiryOn, "O");
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("allocatedValue"u8);
                writer.WriteNumberValue(AllocatedValue);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("usedValue"u8);
                writer.WriteNumberValue(UsedValue);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("percentageUsed"u8);
                writer.WriteNumberValue(PercentageUsed);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        PlaywrightWorkspaceFreeTrialProperties IJsonModel<PlaywrightWorkspaceFreeTrialProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PlaywrightWorkspaceFreeTrialProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PlaywrightWorkspaceFreeTrialProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePlaywrightWorkspaceFreeTrialProperties(document.RootElement, options);
        }

        internal static PlaywrightWorkspaceFreeTrialProperties DeserializePlaywrightWorkspaceFreeTrialProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset createdAt = default;
            DateTimeOffset expiryAt = default;
            int allocatedValue = default;
            float usedValue = default;
            float percentageUsed = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("createdAt"u8))
                {
                    createdAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("expiryAt"u8))
                {
                    expiryAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("allocatedValue"u8))
                {
                    allocatedValue = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("usedValue"u8))
                {
                    usedValue = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("percentageUsed"u8))
                {
                    percentageUsed = property.Value.GetSingle();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new PlaywrightWorkspaceFreeTrialProperties(
                createdAt,
                expiryAt,
                allocatedValue,
                usedValue,
                percentageUsed,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PlaywrightWorkspaceFreeTrialProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PlaywrightWorkspaceFreeTrialProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerPlaywrightContext.Default);
                default:
                    throw new FormatException($"The model {nameof(PlaywrightWorkspaceFreeTrialProperties)} does not support writing '{options.Format}' format.");
            }
        }

        PlaywrightWorkspaceFreeTrialProperties IPersistableModel<PlaywrightWorkspaceFreeTrialProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PlaywrightWorkspaceFreeTrialProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializePlaywrightWorkspaceFreeTrialProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PlaywrightWorkspaceFreeTrialProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PlaywrightWorkspaceFreeTrialProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
