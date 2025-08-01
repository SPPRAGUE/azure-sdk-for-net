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
    public partial class PlaywrightQuotaProperties : IUtf8JsonSerializable, IJsonModel<PlaywrightQuotaProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PlaywrightQuotaProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<PlaywrightQuotaProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PlaywrightQuotaProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PlaywrightQuotaProperties)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(FreeTrial))
            {
                writer.WritePropertyName("freeTrial"u8);
                writer.WriteObjectValue(FreeTrial, options);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
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

        PlaywrightQuotaProperties IJsonModel<PlaywrightQuotaProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PlaywrightQuotaProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PlaywrightQuotaProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePlaywrightQuotaProperties(document.RootElement, options);
        }

        internal static PlaywrightQuotaProperties DeserializePlaywrightQuotaProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            PlaywrightFreeTrialProperties freeTrial = default;
            PlaywrightProvisioningState? provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("freeTrial"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    freeTrial = PlaywrightFreeTrialProperties.DeserializePlaywrightFreeTrialProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new PlaywrightProvisioningState(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new PlaywrightQuotaProperties(freeTrial, provisioningState, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PlaywrightQuotaProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PlaywrightQuotaProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerPlaywrightContext.Default);
                default:
                    throw new FormatException($"The model {nameof(PlaywrightQuotaProperties)} does not support writing '{options.Format}' format.");
            }
        }

        PlaywrightQuotaProperties IPersistableModel<PlaywrightQuotaProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PlaywrightQuotaProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializePlaywrightQuotaProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PlaywrightQuotaProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PlaywrightQuotaProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
