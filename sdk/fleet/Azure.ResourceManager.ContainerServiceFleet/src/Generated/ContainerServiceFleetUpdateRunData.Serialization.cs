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
using Azure.ResourceManager.ContainerServiceFleet.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ContainerServiceFleet
{
    public partial class ContainerServiceFleetUpdateRunData : IUtf8JsonSerializable, IJsonModel<ContainerServiceFleetUpdateRunData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerServiceFleetUpdateRunData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ContainerServiceFleetUpdateRunData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceFleetUpdateRunData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerServiceFleetUpdateRunData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (options.Format != "W" && Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("eTag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(UpdateStrategyId))
            {
                writer.WritePropertyName("updateStrategyId"u8);
                writer.WriteStringValue(UpdateStrategyId);
            }
            if (Optional.IsDefined(Strategy))
            {
                writer.WritePropertyName("strategy"u8);
                writer.WriteObjectValue(Strategy, options);
            }
            if (Optional.IsDefined(ManagedClusterUpdate))
            {
                writer.WritePropertyName("managedClusterUpdate"u8);
                writer.WriteObjectValue(ManagedClusterUpdate, options);
            }
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteObjectValue(Status, options);
            }
            if (options.Format != "W" && Optional.IsDefined(AutoUpgradeProfileId))
            {
                writer.WritePropertyName("autoUpgradeProfileId"u8);
                writer.WriteStringValue(AutoUpgradeProfileId);
            }
            writer.WriteEndObject();
        }

        ContainerServiceFleetUpdateRunData IJsonModel<ContainerServiceFleetUpdateRunData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceFleetUpdateRunData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerServiceFleetUpdateRunData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerServiceFleetUpdateRunData(document.RootElement, options);
        }

        internal static ContainerServiceFleetUpdateRunData DeserializeContainerServiceFleetUpdateRunData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ETag? eTag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            ContainerServiceFleetUpdateRunProvisioningState? provisioningState = default;
            ResourceIdentifier updateStrategyId = default;
            ContainerServiceFleetUpdateRunStrategy strategy = default;
            ContainerServiceFleetManagedClusterUpdate managedClusterUpdate = default;
            ContainerServiceFleetUpdateRunStatus status = default;
            ResourceIdentifier autoUpgradeProfileId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("eTag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    eTag = new ETag(property.Value.GetString());
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
                    systemData = ModelReaderWriter.Read<SystemData>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), ModelSerializationExtensions.WireOptions, AzureResourceManagerContainerServiceFleetContext.Default);
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
                            provisioningState = new ContainerServiceFleetUpdateRunProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("updateStrategyId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            updateStrategyId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("strategy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            strategy = ContainerServiceFleetUpdateRunStrategy.DeserializeContainerServiceFleetUpdateRunStrategy(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("managedClusterUpdate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            managedClusterUpdate = ContainerServiceFleetManagedClusterUpdate.DeserializeContainerServiceFleetManagedClusterUpdate(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = ContainerServiceFleetUpdateRunStatus.DeserializeContainerServiceFleetUpdateRunStatus(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("autoUpgradeProfileId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            autoUpgradeProfileId = new ResourceIdentifier(property0.Value.GetString());
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
            return new ContainerServiceFleetUpdateRunData(
                id,
                name,
                type,
                systemData,
                eTag,
                provisioningState,
                updateStrategyId,
                strategy,
                managedClusterUpdate,
                status,
                autoUpgradeProfileId,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerServiceFleetUpdateRunData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceFleetUpdateRunData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerContainerServiceFleetContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ContainerServiceFleetUpdateRunData)} does not support writing '{options.Format}' format.");
            }
        }

        ContainerServiceFleetUpdateRunData IPersistableModel<ContainerServiceFleetUpdateRunData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceFleetUpdateRunData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeContainerServiceFleetUpdateRunData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerServiceFleetUpdateRunData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerServiceFleetUpdateRunData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
