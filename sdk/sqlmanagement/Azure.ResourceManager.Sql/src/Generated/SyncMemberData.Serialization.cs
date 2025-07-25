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
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    public partial class SyncMemberData : IUtf8JsonSerializable, IJsonModel<SyncMemberData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SyncMemberData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SyncMemberData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SyncMemberData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SyncMemberData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(DatabaseType))
            {
                writer.WritePropertyName("databaseType"u8);
                writer.WriteStringValue(DatabaseType.Value.ToString());
            }
            if (Optional.IsDefined(SyncAgentId))
            {
                writer.WritePropertyName("syncAgentId"u8);
                writer.WriteStringValue(SyncAgentId);
            }
            if (Optional.IsDefined(SqlServerDatabaseId))
            {
                writer.WritePropertyName("sqlServerDatabaseId"u8);
                writer.WriteStringValue(SqlServerDatabaseId.Value);
            }
            if (Optional.IsDefined(SyncMemberAzureDatabaseResourceId))
            {
                writer.WritePropertyName("syncMemberAzureDatabaseResourceId"u8);
                writer.WriteStringValue(SyncMemberAzureDatabaseResourceId);
            }
            if (Optional.IsDefined(UsePrivateLinkConnection))
            {
                writer.WritePropertyName("usePrivateLinkConnection"u8);
                writer.WriteBooleanValue(UsePrivateLinkConnection.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(PrivateEndpointName))
            {
                writer.WritePropertyName("privateEndpointName"u8);
                writer.WriteStringValue(PrivateEndpointName);
            }
            if (Optional.IsDefined(ServerName))
            {
                writer.WritePropertyName("serverName"u8);
                writer.WriteStringValue(ServerName);
            }
            if (Optional.IsDefined(DatabaseName))
            {
                writer.WritePropertyName("databaseName"u8);
                writer.WriteStringValue(DatabaseName);
            }
            if (Optional.IsDefined(UserName))
            {
                writer.WritePropertyName("userName"u8);
                writer.WriteStringValue(UserName);
            }
            if (Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password"u8);
                writer.WriteStringValue(Password);
            }
            if (Optional.IsDefined(SyncDirection))
            {
                writer.WritePropertyName("syncDirection"u8);
                writer.WriteStringValue(SyncDirection.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(SyncState))
            {
                writer.WritePropertyName("syncState"u8);
                writer.WriteStringValue(SyncState.Value.ToString());
            }
            writer.WriteEndObject();
        }

        SyncMemberData IJsonModel<SyncMemberData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SyncMemberData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SyncMemberData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSyncMemberData(document.RootElement, options);
        }

        internal static SyncMemberData DeserializeSyncMemberData(JsonElement element, ModelReaderWriterOptions options = null)
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
            SyncMemberDbType? databaseType = default;
            ResourceIdentifier syncAgentId = default;
            Guid? sqlServerDatabaseId = default;
            ResourceIdentifier syncMemberAzureDatabaseResourceId = default;
            bool? usePrivateLinkConnection = default;
            string privateEndpointName = default;
            string serverName = default;
            string databaseName = default;
            string userName = default;
            string password = default;
            SyncDirection? syncDirection = default;
            SyncMemberState? syncState = default;
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
                    systemData = ModelReaderWriter.Read<SystemData>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), ModelSerializationExtensions.WireOptions, AzureResourceManagerSqlContext.Default);
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
                        if (property0.NameEquals("databaseType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            databaseType = new SyncMemberDbType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("syncAgentId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            syncAgentId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("sqlServerDatabaseId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sqlServerDatabaseId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("syncMemberAzureDatabaseResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            syncMemberAzureDatabaseResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("usePrivateLinkConnection"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            usePrivateLinkConnection = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("privateEndpointName"u8))
                        {
                            privateEndpointName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serverName"u8))
                        {
                            serverName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("databaseName"u8))
                        {
                            databaseName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("userName"u8))
                        {
                            userName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("password"u8))
                        {
                            password = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("syncDirection"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            syncDirection = new SyncDirection(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("syncState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            syncState = new SyncMemberState(property0.Value.GetString());
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
            return new SyncMemberData(
                id,
                name,
                type,
                systemData,
                databaseType,
                syncAgentId,
                sqlServerDatabaseId,
                syncMemberAzureDatabaseResourceId,
                usePrivateLinkConnection,
                privateEndpointName,
                serverName,
                databaseName,
                userName,
                password,
                syncDirection,
                syncState,
                serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Name), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  name: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Name))
                {
                    builder.Append("  name: ");
                    if (Name.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Name}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Name}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Id), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  id: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Id))
                {
                    builder.Append("  id: ");
                    builder.AppendLine($"'{Id.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SystemData), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  systemData: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SystemData))
                {
                    builder.Append("  systemData: ");
                    builder.AppendLine($"'{SystemData.ToString()}'");
                }
            }

            builder.Append("  properties:");
            builder.AppendLine(" {");
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DatabaseType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    databaseType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DatabaseType))
                {
                    builder.Append("    databaseType: ");
                    builder.AppendLine($"'{DatabaseType.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SyncAgentId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    syncAgentId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SyncAgentId))
                {
                    builder.Append("    syncAgentId: ");
                    builder.AppendLine($"'{SyncAgentId.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SqlServerDatabaseId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    sqlServerDatabaseId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SqlServerDatabaseId))
                {
                    builder.Append("    sqlServerDatabaseId: ");
                    builder.AppendLine($"'{SqlServerDatabaseId.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SyncMemberAzureDatabaseResourceId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    syncMemberAzureDatabaseResourceId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SyncMemberAzureDatabaseResourceId))
                {
                    builder.Append("    syncMemberAzureDatabaseResourceId: ");
                    builder.AppendLine($"'{SyncMemberAzureDatabaseResourceId.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(UsePrivateLinkConnection), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    usePrivateLinkConnection: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(UsePrivateLinkConnection))
                {
                    builder.Append("    usePrivateLinkConnection: ");
                    var boolValue = UsePrivateLinkConnection.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PrivateEndpointName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    privateEndpointName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PrivateEndpointName))
                {
                    builder.Append("    privateEndpointName: ");
                    if (PrivateEndpointName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{PrivateEndpointName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{PrivateEndpointName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ServerName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    serverName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ServerName))
                {
                    builder.Append("    serverName: ");
                    if (ServerName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ServerName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ServerName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DatabaseName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    databaseName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DatabaseName))
                {
                    builder.Append("    databaseName: ");
                    if (DatabaseName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{DatabaseName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{DatabaseName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(UserName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    userName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(UserName))
                {
                    builder.Append("    userName: ");
                    if (UserName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{UserName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{UserName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Password), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    password: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Password))
                {
                    builder.Append("    password: ");
                    if (Password.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Password}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Password}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SyncDirection), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    syncDirection: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SyncDirection))
                {
                    builder.Append("    syncDirection: ");
                    builder.AppendLine($"'{SyncDirection.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SyncState), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    syncState: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SyncState))
                {
                    builder.Append("    syncState: ");
                    builder.AppendLine($"'{SyncState.Value.ToString()}'");
                }
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<SyncMemberData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SyncMemberData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerSqlContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SyncMemberData)} does not support writing '{options.Format}' format.");
            }
        }

        SyncMemberData IPersistableModel<SyncMemberData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SyncMemberData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeSyncMemberData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SyncMemberData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SyncMemberData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
