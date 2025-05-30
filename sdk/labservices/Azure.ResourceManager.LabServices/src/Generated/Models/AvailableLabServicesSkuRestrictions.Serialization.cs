// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.LabServices.Models
{
    public partial class AvailableLabServicesSkuRestrictions : IUtf8JsonSerializable, IJsonModel<AvailableLabServicesSkuRestrictions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AvailableLabServicesSkuRestrictions>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AvailableLabServicesSkuRestrictions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvailableLabServicesSkuRestrictions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AvailableLabServicesSkuRestrictions)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(LabServicesSkuRestrictionType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(LabServicesSkuRestrictionType.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Values))
            {
                writer.WritePropertyName("values"u8);
                writer.WriteStartArray();
                foreach (var item in Values)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ReasonCode))
            {
                writer.WritePropertyName("reasonCode"u8);
                writer.WriteStringValue(ReasonCode.Value.ToString());
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

        AvailableLabServicesSkuRestrictions IJsonModel<AvailableLabServicesSkuRestrictions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvailableLabServicesSkuRestrictions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AvailableLabServicesSkuRestrictions)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAvailableLabServicesSkuRestrictions(document.RootElement, options);
        }

        internal static AvailableLabServicesSkuRestrictions DeserializeAvailableLabServicesSkuRestrictions(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            LabServicesSkuRestrictionType? type = default;
            IReadOnlyList<string> values = default;
            LabServicesSkuRestrictionReasonCode? reasonCode = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new LabServicesSkuRestrictionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("values"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    values = array;
                    continue;
                }
                if (property.NameEquals("reasonCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reasonCode = new LabServicesSkuRestrictionReasonCode(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AvailableLabServicesSkuRestrictions(type, values ?? new ChangeTrackingList<string>(), reasonCode, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AvailableLabServicesSkuRestrictions>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvailableLabServicesSkuRestrictions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AvailableLabServicesSkuRestrictions)} does not support writing '{options.Format}' format.");
            }
        }

        AvailableLabServicesSkuRestrictions IPersistableModel<AvailableLabServicesSkuRestrictions>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvailableLabServicesSkuRestrictions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAvailableLabServicesSkuRestrictions(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AvailableLabServicesSkuRestrictions)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AvailableLabServicesSkuRestrictions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
