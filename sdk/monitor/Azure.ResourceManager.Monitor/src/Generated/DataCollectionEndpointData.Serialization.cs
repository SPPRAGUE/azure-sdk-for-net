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
using Azure.ResourceManager.Monitor.Models;

namespace Azure.ResourceManager.Monitor
{
    public partial class DataCollectionEndpointData : IUtf8JsonSerializable, IJsonModel<DataCollectionEndpointData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataCollectionEndpointData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DataCollectionEndpointData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCollectionEndpointData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataCollectionEndpointData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind.Value.ToString());
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                ((IJsonModel<ManagedServiceIdentity>)Identity).Write(writer, ModelSerializationExtensions.WireV3Options);
            }
            if (options.Format != "W" && Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(ImmutableId))
            {
                writer.WritePropertyName("immutableId"u8);
                writer.WriteStringValue(ImmutableId);
            }
            if (Optional.IsDefined(ConfigurationAccess))
            {
                writer.WritePropertyName("configurationAccess"u8);
                writer.WriteObjectValue(ConfigurationAccess, options);
            }
            if (Optional.IsDefined(LogsIngestion))
            {
                writer.WritePropertyName("logsIngestion"u8);
                writer.WriteObjectValue(LogsIngestion, options);
            }
            if (Optional.IsDefined(MetricsIngestion))
            {
                writer.WritePropertyName("metricsIngestion"u8);
                writer.WriteObjectValue(MetricsIngestion, options);
            }
            if (Optional.IsDefined(NetworkAcls))
            {
                writer.WritePropertyName("networkAcls"u8);
                writer.WriteObjectValue(NetworkAcls, options);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(PrivateLinkScopedResources))
            {
                writer.WritePropertyName("privateLinkScopedResources"u8);
                writer.WriteStartArray();
                foreach (var item in PrivateLinkScopedResources)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(FailoverConfiguration))
            {
                writer.WritePropertyName("failoverConfiguration"u8);
                writer.WriteObjectValue(FailoverConfiguration, options);
            }
            if (options.Format != "W" && Optional.IsDefined(Metadata))
            {
                writer.WritePropertyName("metadata"u8);
                writer.WriteObjectValue(Metadata, options);
            }
            writer.WriteEndObject();
        }

        DataCollectionEndpointData IJsonModel<DataCollectionEndpointData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCollectionEndpointData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataCollectionEndpointData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataCollectionEndpointData(document.RootElement, options);
        }

        internal static DataCollectionEndpointData DeserializeDataCollectionEndpointData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataCollectionEndpointResourceKind? kind = default;
            ManagedServiceIdentity identity = default;
            ETag? etag = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string description = default;
            string immutableId = default;
            DataCollectionEndpointConfigurationAccess configurationAccess = default;
            DataCollectionEndpointLogsIngestion logsIngestion = default;
            DataCollectionEndpointMetricsIngestion metricsIngestion = default;
            DataCollectionEndpointNetworkAcls networkAcls = default;
            DataCollectionEndpointProvisioningState? provisioningState = default;
            IReadOnlyList<DataCollectionRulePrivateLinkScopedResourceInfo> privateLinkScopedResources = default;
            DataCollectionEndpointFailoverConfiguration failoverConfiguration = default;
            DataCollectionEndpointMetadata metadata = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kind = new DataCollectionEndpointResourceKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = ModelReaderWriter.Read<ManagedServiceIdentity>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), ModelSerializationExtensions.WireV3Options, AzureResourceManagerMonitorContext.Default);
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
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
                    systemData = ModelReaderWriter.Read<SystemData>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), ModelSerializationExtensions.WireOptions, AzureResourceManagerMonitorContext.Default);
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
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("immutableId"u8))
                        {
                            immutableId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("configurationAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            configurationAccess = DataCollectionEndpointConfigurationAccess.DeserializeDataCollectionEndpointConfigurationAccess(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("logsIngestion"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            logsIngestion = DataCollectionEndpointLogsIngestion.DeserializeDataCollectionEndpointLogsIngestion(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("metricsIngestion"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            metricsIngestion = DataCollectionEndpointMetricsIngestion.DeserializeDataCollectionEndpointMetricsIngestion(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("networkAcls"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            networkAcls = DataCollectionEndpointNetworkAcls.DeserializeDataCollectionEndpointNetworkAcls(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new DataCollectionEndpointProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("privateLinkScopedResources"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DataCollectionRulePrivateLinkScopedResourceInfo> array = new List<DataCollectionRulePrivateLinkScopedResourceInfo>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DataCollectionRulePrivateLinkScopedResourceInfo.DeserializeDataCollectionRulePrivateLinkScopedResourceInfo(item, options));
                            }
                            privateLinkScopedResources = array;
                            continue;
                        }
                        if (property0.NameEquals("failoverConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            failoverConfiguration = DataCollectionEndpointFailoverConfiguration.DeserializeDataCollectionEndpointFailoverConfiguration(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("metadata"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            metadata = DataCollectionEndpointMetadata.DeserializeDataCollectionEndpointMetadata(property0.Value, options);
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
            return new DataCollectionEndpointData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                kind,
                identity,
                etag,
                description,
                immutableId,
                configurationAccess,
                logsIngestion,
                metricsIngestion,
                networkAcls,
                provisioningState,
                privateLinkScopedResources ?? new ChangeTrackingList<DataCollectionRulePrivateLinkScopedResourceInfo>(),
                failoverConfiguration,
                metadata,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataCollectionEndpointData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCollectionEndpointData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerMonitorContext.Default);
                default:
                    throw new FormatException($"The model {nameof(DataCollectionEndpointData)} does not support writing '{options.Format}' format.");
            }
        }

        DataCollectionEndpointData IPersistableModel<DataCollectionEndpointData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCollectionEndpointData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDataCollectionEndpointData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataCollectionEndpointData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataCollectionEndpointData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
