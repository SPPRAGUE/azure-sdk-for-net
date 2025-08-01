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
    public partial class DataMigrationOracleOciDriverInfo : IUtf8JsonSerializable, IJsonModel<DataMigrationOracleOciDriverInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataMigrationOracleOciDriverInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DataMigrationOracleOciDriverInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataMigrationOracleOciDriverInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataMigrationOracleOciDriverInfo)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(DriverName))
            {
                writer.WritePropertyName("driverName"u8);
                writer.WriteStringValue(DriverName);
            }
            if (options.Format != "W" && Optional.IsDefined(DriverSize))
            {
                writer.WritePropertyName("driverSize"u8);
                writer.WriteStringValue(DriverSize);
            }
            if (options.Format != "W" && Optional.IsDefined(ArchiveChecksum))
            {
                writer.WritePropertyName("archiveChecksum"u8);
                writer.WriteStringValue(ArchiveChecksum);
            }
            if (options.Format != "W" && Optional.IsDefined(OracleChecksum))
            {
                writer.WritePropertyName("oracleChecksum"u8);
                writer.WriteStringValue(OracleChecksum);
            }
            if (options.Format != "W" && Optional.IsDefined(AssemblyVersion))
            {
                writer.WritePropertyName("assemblyVersion"u8);
                writer.WriteStringValue(AssemblyVersion);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(SupportedOracleVersions))
            {
                writer.WritePropertyName("supportedOracleVersions"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedOracleVersions)
                {
                    writer.WriteStringValue(item);
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

        DataMigrationOracleOciDriverInfo IJsonModel<DataMigrationOracleOciDriverInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataMigrationOracleOciDriverInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataMigrationOracleOciDriverInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataMigrationOracleOciDriverInfo(document.RootElement, options);
        }

        internal static DataMigrationOracleOciDriverInfo DeserializeDataMigrationOracleOciDriverInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string driverName = default;
            string driverSize = default;
            string archiveChecksum = default;
            string oracleChecksum = default;
            string assemblyVersion = default;
            IReadOnlyList<string> supportedOracleVersions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("driverName"u8))
                {
                    driverName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("driverSize"u8))
                {
                    driverSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("archiveChecksum"u8))
                {
                    archiveChecksum = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("oracleChecksum"u8))
                {
                    oracleChecksum = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("assemblyVersion"u8))
                {
                    assemblyVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("supportedOracleVersions"u8))
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
                    supportedOracleVersions = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DataMigrationOracleOciDriverInfo(
                driverName,
                driverSize,
                archiveChecksum,
                oracleChecksum,
                assemblyVersion,
                supportedOracleVersions ?? new ChangeTrackingList<string>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataMigrationOracleOciDriverInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataMigrationOracleOciDriverInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerDataMigrationContext.Default);
                default:
                    throw new FormatException($"The model {nameof(DataMigrationOracleOciDriverInfo)} does not support writing '{options.Format}' format.");
            }
        }

        DataMigrationOracleOciDriverInfo IPersistableModel<DataMigrationOracleOciDriverInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataMigrationOracleOciDriverInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDataMigrationOracleOciDriverInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataMigrationOracleOciDriverInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataMigrationOracleOciDriverInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
