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
using Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw
{
    public partial class PaloAltoNetworksFirewallData : IUtf8JsonSerializable, IJsonModel<PaloAltoNetworksFirewallData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PaloAltoNetworksFirewallData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<PaloAltoNetworksFirewallData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PaloAltoNetworksFirewallData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PaloAltoNetworksFirewallData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                ((IJsonModel<ManagedServiceIdentity>)Identity).Write(writer, ModelSerializationExtensions.WireV3Options);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(PanETag))
            {
                writer.WritePropertyName("panEtag"u8);
                writer.WriteStringValue(PanETag.Value.ToString());
            }
            writer.WritePropertyName("networkProfile"u8);
            writer.WriteObjectValue(NetworkProfile, options);
            if (Optional.IsDefined(IsPanoramaManaged))
            {
                writer.WritePropertyName("isPanoramaManaged"u8);
                writer.WriteStringValue(IsPanoramaManaged.Value.ToString());
            }
            if (Optional.IsDefined(PanoramaConfig))
            {
                writer.WritePropertyName("panoramaConfig"u8);
                writer.WriteObjectValue(PanoramaConfig, options);
            }
            if (Optional.IsDefined(AssociatedRulestack))
            {
                writer.WritePropertyName("associatedRulestack"u8);
                writer.WriteObjectValue(AssociatedRulestack, options);
            }
            writer.WritePropertyName("dnsSettings"u8);
            writer.WriteObjectValue(DnsSettings, options);
            if (Optional.IsCollectionDefined(FrontEndSettings))
            {
                writer.WritePropertyName("frontEndSettings"u8);
                writer.WriteStartArray();
                foreach (var item in FrontEndSettings)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WritePropertyName("planData"u8);
            writer.WriteObjectValue(PlanData, options);
            writer.WritePropertyName("marketplaceDetails"u8);
            writer.WriteObjectValue(MarketplaceDetails, options);
            writer.WriteEndObject();
        }

        PaloAltoNetworksFirewallData IJsonModel<PaloAltoNetworksFirewallData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PaloAltoNetworksFirewallData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PaloAltoNetworksFirewallData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePaloAltoNetworksFirewallData(document.RootElement, options);
        }

        internal static PaloAltoNetworksFirewallData DeserializePaloAltoNetworksFirewallData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ManagedServiceIdentity identity = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            ETag? panETag = default;
            FirewallNetworkProfile networkProfile = default;
            FirewallBooleanType? isPanoramaManaged = default;
            FirewallPanoramaConfiguration panoramaConfig = default;
            RulestackDetails associatedRulestack = default;
            FirewallDnsSettings dnsSettings = default;
            IList<FirewallFrontendSetting> frontEndSettings = default;
            FirewallProvisioningState? provisioningState = default;
            FirewallBillingPlanInfo planData = default;
            PanFirewallMarketplaceDetails marketplaceDetails = default;
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
                    identity = ModelReaderWriter.Read<ManagedServiceIdentity>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), ModelSerializationExtensions.WireV3Options, AzureResourceManagerPaloAltoNetworksNgfwContext.Default);
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
                    systemData = ModelReaderWriter.Read<SystemData>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), ModelSerializationExtensions.WireOptions, AzureResourceManagerPaloAltoNetworksNgfwContext.Default);
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
                        if (property0.NameEquals("panEtag"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            panETag = new ETag(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("networkProfile"u8))
                        {
                            networkProfile = FirewallNetworkProfile.DeserializeFirewallNetworkProfile(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("isPanoramaManaged"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isPanoramaManaged = new FirewallBooleanType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("panoramaConfig"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            panoramaConfig = FirewallPanoramaConfiguration.DeserializeFirewallPanoramaConfiguration(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("associatedRulestack"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            associatedRulestack = RulestackDetails.DeserializeRulestackDetails(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("dnsSettings"u8))
                        {
                            dnsSettings = FirewallDnsSettings.DeserializeFirewallDnsSettings(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("frontEndSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<FirewallFrontendSetting> array = new List<FirewallFrontendSetting>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(FirewallFrontendSetting.DeserializeFirewallFrontendSetting(item, options));
                            }
                            frontEndSettings = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new FirewallProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("planData"u8))
                        {
                            planData = FirewallBillingPlanInfo.DeserializeFirewallBillingPlanInfo(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("marketplaceDetails"u8))
                        {
                            marketplaceDetails = PanFirewallMarketplaceDetails.DeserializePanFirewallMarketplaceDetails(property0.Value, options);
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
            return new PaloAltoNetworksFirewallData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                identity,
                panETag,
                networkProfile,
                isPanoramaManaged,
                panoramaConfig,
                associatedRulestack,
                dnsSettings,
                frontEndSettings ?? new ChangeTrackingList<FirewallFrontendSetting>(),
                provisioningState,
                planData,
                marketplaceDetails,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PaloAltoNetworksFirewallData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PaloAltoNetworksFirewallData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerPaloAltoNetworksNgfwContext.Default);
                default:
                    throw new FormatException($"The model {nameof(PaloAltoNetworksFirewallData)} does not support writing '{options.Format}' format.");
            }
        }

        PaloAltoNetworksFirewallData IPersistableModel<PaloAltoNetworksFirewallData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PaloAltoNetworksFirewallData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializePaloAltoNetworksFirewallData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PaloAltoNetworksFirewallData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PaloAltoNetworksFirewallData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
