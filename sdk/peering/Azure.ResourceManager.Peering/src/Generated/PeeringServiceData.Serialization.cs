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
using Azure.ResourceManager.Peering.Models;

namespace Azure.ResourceManager.Peering
{
    public partial class PeeringServiceData : IUtf8JsonSerializable, IJsonModel<PeeringServiceData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PeeringServiceData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<PeeringServiceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PeeringServiceData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PeeringServiceData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku, options);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(PeeringServiceLocation))
            {
                writer.WritePropertyName("peeringServiceLocation"u8);
                writer.WriteStringValue(PeeringServiceLocation);
            }
            if (Optional.IsDefined(PeeringServiceProvider))
            {
                writer.WritePropertyName("peeringServiceProvider"u8);
                writer.WriteStringValue(PeeringServiceProvider);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(ProviderPrimaryPeeringLocation))
            {
                writer.WritePropertyName("providerPrimaryPeeringLocation"u8);
                writer.WriteStringValue(ProviderPrimaryPeeringLocation);
            }
            if (Optional.IsDefined(ProviderBackupPeeringLocation))
            {
                writer.WritePropertyName("providerBackupPeeringLocation"u8);
                writer.WriteStringValue(ProviderBackupPeeringLocation);
            }
            if (Optional.IsDefined(LogAnalyticsWorkspaceProperties))
            {
                writer.WritePropertyName("logAnalyticsWorkspaceProperties"u8);
                writer.WriteObjectValue(LogAnalyticsWorkspaceProperties, options);
            }
            writer.WriteEndObject();
        }

        PeeringServiceData IJsonModel<PeeringServiceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PeeringServiceData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PeeringServiceData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePeeringServiceData(document.RootElement, options);
        }

        internal static PeeringServiceData DeserializePeeringServiceData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            PeeringServiceSku sku = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string peeringServiceLocation = default;
            string peeringServiceProvider = default;
            PeeringProvisioningState? provisioningState = default;
            string providerPrimaryPeeringLocation = default;
            string providerBackupPeeringLocation = default;
            PeeringLogAnalyticsWorkspaceProperties logAnalyticsWorkspaceProperties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = PeeringServiceSku.DeserializePeeringServiceSku(property.Value, options);
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
                    systemData = ModelReaderWriter.Read<SystemData>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), ModelSerializationExtensions.WireOptions, AzureResourceManagerPeeringContext.Default);
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
                        if (property0.NameEquals("peeringServiceLocation"u8))
                        {
                            peeringServiceLocation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("peeringServiceProvider"u8))
                        {
                            peeringServiceProvider = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new PeeringProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("providerPrimaryPeeringLocation"u8))
                        {
                            providerPrimaryPeeringLocation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("providerBackupPeeringLocation"u8))
                        {
                            providerBackupPeeringLocation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("logAnalyticsWorkspaceProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            logAnalyticsWorkspaceProperties = PeeringLogAnalyticsWorkspaceProperties.DeserializePeeringLogAnalyticsWorkspaceProperties(property0.Value, options);
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
            return new PeeringServiceData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                sku,
                peeringServiceLocation,
                peeringServiceProvider,
                provisioningState,
                providerPrimaryPeeringLocation,
                providerBackupPeeringLocation,
                logAnalyticsWorkspaceProperties,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PeeringServiceData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PeeringServiceData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerPeeringContext.Default);
                default:
                    throw new FormatException($"The model {nameof(PeeringServiceData)} does not support writing '{options.Format}' format.");
            }
        }

        PeeringServiceData IPersistableModel<PeeringServiceData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PeeringServiceData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializePeeringServiceData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PeeringServiceData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PeeringServiceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
