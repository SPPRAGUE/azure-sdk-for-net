// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class DataMigrationOfflineConfiguration : IUtf8JsonSerializable, IJsonModel<DataMigrationOfflineConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataMigrationOfflineConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DataMigrationOfflineConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataMigrationOfflineConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataMigrationOfflineConfiguration)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(IsOfflineMigration))
            {
                writer.WritePropertyName("offline"u8);
                writer.WriteBooleanValue(IsOfflineMigration.Value);
            }
            if (Optional.IsDefined(LastBackupName))
            {
                writer.WritePropertyName("lastBackupName"u8);
                writer.WriteStringValue(LastBackupName);
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

        DataMigrationOfflineConfiguration IJsonModel<DataMigrationOfflineConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataMigrationOfflineConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataMigrationOfflineConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataMigrationOfflineConfiguration(document.RootElement, options);
        }

        internal static DataMigrationOfflineConfiguration DeserializeDataMigrationOfflineConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? offline = default;
            string lastBackupName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("offline"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    offline = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("lastBackupName"u8))
                {
                    lastBackupName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DataMigrationOfflineConfiguration(offline, lastBackupName, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataMigrationOfflineConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataMigrationOfflineConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerDataMigrationContext.Default);
                default:
                    throw new FormatException($"The model {nameof(DataMigrationOfflineConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        DataMigrationOfflineConfiguration IPersistableModel<DataMigrationOfflineConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataMigrationOfflineConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDataMigrationOfflineConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataMigrationOfflineConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataMigrationOfflineConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
