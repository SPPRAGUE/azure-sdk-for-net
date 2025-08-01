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
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.StandbyPool.Models
{
    public partial class StandbyContainerGroupProperties : IUtf8JsonSerializable, IJsonModel<StandbyContainerGroupProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StandbyContainerGroupProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<StandbyContainerGroupProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StandbyContainerGroupProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StandbyContainerGroupProperties)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("containerGroupProfile"u8);
            writer.WriteObjectValue(ContainerGroupProfile, options);
            if (Optional.IsCollectionDefined(SubnetIds))
            {
                writer.WritePropertyName("subnetIds"u8);
                writer.WriteStartArray();
                foreach (var item in SubnetIds)
                {
                    ((IJsonModel<WritableSubResource>)item).Write(writer, options);
                }
                writer.WriteEndArray();
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

        StandbyContainerGroupProperties IJsonModel<StandbyContainerGroupProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StandbyContainerGroupProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StandbyContainerGroupProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStandbyContainerGroupProperties(document.RootElement, options);
        }

        internal static StandbyContainerGroupProperties DeserializeStandbyContainerGroupProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            StandbyContainerGroupProfile containerGroupProfile = default;
            IList<WritableSubResource> subnetIds = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("containerGroupProfile"u8))
                {
                    containerGroupProfile = StandbyContainerGroupProfile.DeserializeStandbyContainerGroupProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("subnetIds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WritableSubResource> array = new List<WritableSubResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ModelReaderWriter.Read<WritableSubResource>(new BinaryData(Encoding.UTF8.GetBytes(item.GetRawText())), options, AzureResourceManagerStandbyPoolContext.Default));
                    }
                    subnetIds = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new StandbyContainerGroupProperties(containerGroupProfile, subnetIds ?? new ChangeTrackingList<WritableSubResource>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StandbyContainerGroupProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StandbyContainerGroupProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerStandbyPoolContext.Default);
                default:
                    throw new FormatException($"The model {nameof(StandbyContainerGroupProperties)} does not support writing '{options.Format}' format.");
            }
        }

        StandbyContainerGroupProperties IPersistableModel<StandbyContainerGroupProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StandbyContainerGroupProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeStandbyContainerGroupProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StandbyContainerGroupProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<StandbyContainerGroupProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
