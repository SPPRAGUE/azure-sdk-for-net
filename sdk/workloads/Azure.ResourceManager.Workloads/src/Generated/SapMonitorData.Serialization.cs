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
using Azure.ResourceManager.Workloads.Models;

namespace Azure.ResourceManager.Workloads
{
    public partial class SapMonitorData : IUtf8JsonSerializable, IJsonModel<SapMonitorData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SapMonitorData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SapMonitorData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapMonitorData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SapMonitorData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                writer.WriteObjectValue(Identity, options);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(Errors))
            {
                writer.WritePropertyName("errors"u8);
                ((IJsonModel<ResponseError>)Errors).Write(writer, options);
            }
            if (Optional.IsDefined(AppLocation))
            {
                writer.WritePropertyName("appLocation"u8);
                writer.WriteStringValue(AppLocation.Value);
            }
            if (Optional.IsDefined(RoutingPreference))
            {
                writer.WritePropertyName("routingPreference"u8);
                writer.WriteStringValue(RoutingPreference.Value.ToString());
            }
            if (Optional.IsDefined(ZoneRedundancyPreference))
            {
                writer.WritePropertyName("zoneRedundancyPreference"u8);
                writer.WriteStringValue(ZoneRedundancyPreference);
            }
            if (Optional.IsDefined(ManagedResourceGroupConfiguration))
            {
                writer.WritePropertyName("managedResourceGroupConfiguration"u8);
                writer.WriteObjectValue(ManagedResourceGroupConfiguration, options);
            }
            if (Optional.IsDefined(LogAnalyticsWorkspaceArmId))
            {
                writer.WritePropertyName("logAnalyticsWorkspaceArmId"u8);
                writer.WriteStringValue(LogAnalyticsWorkspaceArmId);
            }
            if (Optional.IsDefined(MonitorSubnetId))
            {
                writer.WritePropertyName("monitorSubnet"u8);
                writer.WriteStringValue(MonitorSubnetId);
            }
            if (options.Format != "W" && Optional.IsDefined(MsiArmId))
            {
                writer.WritePropertyName("msiArmId"u8);
                writer.WriteStringValue(MsiArmId);
            }
            if (options.Format != "W" && Optional.IsDefined(StorageAccountArmId))
            {
                writer.WritePropertyName("storageAccountArmId"u8);
                writer.WriteStringValue(StorageAccountArmId);
            }
            writer.WriteEndObject();
        }

        SapMonitorData IJsonModel<SapMonitorData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapMonitorData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SapMonitorData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSapMonitorData(document.RootElement, options);
        }

        internal static SapMonitorData DeserializeSapMonitorData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            UserAssignedServiceIdentity identity = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            WorkloadMonitorProvisioningState? provisioningState = default;
            ResponseError errors = default;
            AzureLocation? appLocation = default;
            SapRoutingPreference? routingPreference = default;
            string zoneRedundancyPreference = default;
            ManagedRGConfiguration managedResourceGroupConfiguration = default;
            ResourceIdentifier logAnalyticsWorkspaceArmId = default;
            ResourceIdentifier monitorSubnet = default;
            ResourceIdentifier msiArmId = default;
            ResourceIdentifier storageAccountArmId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = UserAssignedServiceIdentity.DeserializeUserAssignedServiceIdentity(property.Value, options);
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
                    systemData = ModelReaderWriter.Read<SystemData>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), ModelSerializationExtensions.WireOptions, AzureResourceManagerWorkloadsContext.Default);
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
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new WorkloadMonitorProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("errors"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            errors = ModelReaderWriter.Read<ResponseError>(new BinaryData(Encoding.UTF8.GetBytes(property0.Value.GetRawText())), options, AzureResourceManagerWorkloadsContext.Default);
                            continue;
                        }
                        if (property0.NameEquals("appLocation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            appLocation = new AzureLocation(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("routingPreference"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            routingPreference = new SapRoutingPreference(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("zoneRedundancyPreference"u8))
                        {
                            zoneRedundancyPreference = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("managedResourceGroupConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            managedResourceGroupConfiguration = ManagedRGConfiguration.DeserializeManagedRGConfiguration(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("logAnalyticsWorkspaceArmId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            logAnalyticsWorkspaceArmId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("monitorSubnet"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            monitorSubnet = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("msiArmId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            msiArmId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("storageAccountArmId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            storageAccountArmId = new ResourceIdentifier(property0.Value.GetString());
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
            return new SapMonitorData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                identity,
                provisioningState,
                errors,
                appLocation,
                routingPreference,
                zoneRedundancyPreference,
                managedResourceGroupConfiguration,
                logAnalyticsWorkspaceArmId,
                monitorSubnet,
                msiArmId,
                storageAccountArmId,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SapMonitorData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapMonitorData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerWorkloadsContext.Default);
                default:
                    throw new FormatException($"The model {nameof(SapMonitorData)} does not support writing '{options.Format}' format.");
            }
        }

        SapMonitorData IPersistableModel<SapMonitorData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapMonitorData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeSapMonitorData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SapMonitorData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SapMonitorData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
