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
    public partial class SqlServerSqlMISyncTaskInput : IUtf8JsonSerializable, IJsonModel<SqlServerSqlMISyncTaskInput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SqlServerSqlMISyncTaskInput>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SqlServerSqlMISyncTaskInput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlServerSqlMISyncTaskInput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlServerSqlMISyncTaskInput)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("selectedDatabases"u8);
            writer.WriteStartArray();
            foreach (var item in SelectedDatabases)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(BackupFileShare))
            {
                writer.WritePropertyName("backupFileShare"u8);
                writer.WriteObjectValue(BackupFileShare, options);
            }
            writer.WritePropertyName("storageResourceId"u8);
            writer.WriteStringValue(StorageResourceId);
            writer.WritePropertyName("sourceConnectionInfo"u8);
            writer.WriteObjectValue(SourceConnectionInfo, options);
            writer.WritePropertyName("targetConnectionInfo"u8);
            writer.WriteObjectValue(TargetConnectionInfo, options);
            writer.WritePropertyName("azureApp"u8);
            writer.WriteObjectValue(AzureApp, options);
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

        SqlServerSqlMISyncTaskInput IJsonModel<SqlServerSqlMISyncTaskInput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlServerSqlMISyncTaskInput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlServerSqlMISyncTaskInput)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSqlServerSqlMISyncTaskInput(document.RootElement, options);
        }

        internal static SqlServerSqlMISyncTaskInput DeserializeSqlServerSqlMISyncTaskInput(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<MigrateSqlServerSqlMIDatabaseInput> selectedDatabases = default;
            DataMigrationFileShareInfo backupFileShare = default;
            string storageResourceId = default;
            DataMigrationSqlConnectionInfo sourceConnectionInfo = default;
            DataMigrationMISqlConnectionInfo targetConnectionInfo = default;
            DataMigrationAadApp azureApp = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("selectedDatabases"u8))
                {
                    List<MigrateSqlServerSqlMIDatabaseInput> array = new List<MigrateSqlServerSqlMIDatabaseInput>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MigrateSqlServerSqlMIDatabaseInput.DeserializeMigrateSqlServerSqlMIDatabaseInput(item, options));
                    }
                    selectedDatabases = array;
                    continue;
                }
                if (property.NameEquals("backupFileShare"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupFileShare = DataMigrationFileShareInfo.DeserializeDataMigrationFileShareInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("storageResourceId"u8))
                {
                    storageResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceConnectionInfo"u8))
                {
                    sourceConnectionInfo = DataMigrationSqlConnectionInfo.DeserializeDataMigrationSqlConnectionInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("targetConnectionInfo"u8))
                {
                    targetConnectionInfo = DataMigrationMISqlConnectionInfo.DeserializeDataMigrationMISqlConnectionInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("azureApp"u8))
                {
                    azureApp = DataMigrationAadApp.DeserializeDataMigrationAadApp(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SqlServerSqlMISyncTaskInput(
                selectedDatabases,
                backupFileShare,
                storageResourceId,
                sourceConnectionInfo,
                targetConnectionInfo,
                azureApp,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SqlServerSqlMISyncTaskInput>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlServerSqlMISyncTaskInput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerDataMigrationContext.Default);
                default:
                    throw new FormatException($"The model {nameof(SqlServerSqlMISyncTaskInput)} does not support writing '{options.Format}' format.");
            }
        }

        SqlServerSqlMISyncTaskInput IPersistableModel<SqlServerSqlMISyncTaskInput>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlServerSqlMISyncTaskInput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeSqlServerSqlMISyncTaskInput(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SqlServerSqlMISyncTaskInput)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SqlServerSqlMISyncTaskInput>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
