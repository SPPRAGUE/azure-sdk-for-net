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
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Cdn
{
    public partial class FrontDoorRouteData : IUtf8JsonSerializable, IJsonModel<FrontDoorRouteData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FrontDoorRouteData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<FrontDoorRouteData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FrontDoorRouteData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FrontDoorRouteData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(EndpointName))
            {
                writer.WritePropertyName("endpointName"u8);
                writer.WriteStringValue(EndpointName);
            }
            if (Optional.IsCollectionDefined(CustomDomains))
            {
                writer.WritePropertyName("customDomains"u8);
                writer.WriteStartArray();
                foreach (var item in CustomDomains)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(OriginGroup))
            {
                writer.WritePropertyName("originGroup"u8);
                ((IJsonModel<WritableSubResource>)OriginGroup).Write(writer, options);
            }
            if (Optional.IsDefined(OriginPath))
            {
                writer.WritePropertyName("originPath"u8);
                writer.WriteStringValue(OriginPath);
            }
            if (Optional.IsCollectionDefined(RuleSets))
            {
                writer.WritePropertyName("ruleSets"u8);
                writer.WriteStartArray();
                foreach (var item in RuleSets)
                {
                    ((IJsonModel<WritableSubResource>)item).Write(writer, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(SupportedProtocols))
            {
                writer.WritePropertyName("supportedProtocols"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedProtocols)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(PatternsToMatch))
            {
                writer.WritePropertyName("patternsToMatch"u8);
                writer.WriteStartArray();
                foreach (var item in PatternsToMatch)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(CacheConfiguration))
            {
                if (CacheConfiguration != null)
                {
                    writer.WritePropertyName("cacheConfiguration"u8);
                    writer.WriteObjectValue(CacheConfiguration, options);
                }
                else
                {
                    writer.WriteNull("cacheConfiguration");
                }
            }
            if (Optional.IsDefined(ForwardingProtocol))
            {
                writer.WritePropertyName("forwardingProtocol"u8);
                writer.WriteStringValue(ForwardingProtocol.Value.ToString());
            }
            if (Optional.IsDefined(LinkToDefaultDomain))
            {
                writer.WritePropertyName("linkToDefaultDomain"u8);
                writer.WriteStringValue(LinkToDefaultDomain.Value.ToString());
            }
            if (Optional.IsDefined(HttpsRedirect))
            {
                writer.WritePropertyName("httpsRedirect"u8);
                writer.WriteStringValue(HttpsRedirect.Value.ToString());
            }
            if (Optional.IsDefined(EnabledState))
            {
                writer.WritePropertyName("enabledState"u8);
                writer.WriteStringValue(EnabledState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(DeploymentStatus))
            {
                writer.WritePropertyName("deploymentStatus"u8);
                writer.WriteStringValue(DeploymentStatus.Value.ToString());
            }
            writer.WriteEndObject();
        }

        FrontDoorRouteData IJsonModel<FrontDoorRouteData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FrontDoorRouteData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FrontDoorRouteData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFrontDoorRouteData(document.RootElement, options);
        }

        internal static FrontDoorRouteData DeserializeFrontDoorRouteData(JsonElement element, ModelReaderWriterOptions options = null)
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
            string endpointName = default;
            IList<FrontDoorActivatedResourceInfo> customDomains = default;
            WritableSubResource originGroup = default;
            string originPath = default;
            IList<WritableSubResource> ruleSets = default;
            IList<FrontDoorEndpointProtocol> supportedProtocols = default;
            IList<string> patternsToMatch = default;
            FrontDoorRouteCacheConfiguration cacheConfiguration = default;
            ForwardingProtocol? forwardingProtocol = default;
            LinkToDefaultDomain? linkToDefaultDomain = default;
            HttpsRedirect? httpsRedirect = default;
            EnabledState? enabledState = default;
            FrontDoorProvisioningState? provisioningState = default;
            FrontDoorDeploymentStatus? deploymentStatus = default;
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
                    systemData = ModelReaderWriter.Read<SystemData>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), ModelSerializationExtensions.WireOptions, AzureResourceManagerCdnContext.Default);
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
                        if (property0.NameEquals("endpointName"u8))
                        {
                            endpointName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("customDomains"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<FrontDoorActivatedResourceInfo> array = new List<FrontDoorActivatedResourceInfo>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(FrontDoorActivatedResourceInfo.DeserializeFrontDoorActivatedResourceInfo(item, options));
                            }
                            customDomains = array;
                            continue;
                        }
                        if (property0.NameEquals("originGroup"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            originGroup = ModelReaderWriter.Read<WritableSubResource>(new BinaryData(Encoding.UTF8.GetBytes(property0.Value.GetRawText())), options, AzureResourceManagerCdnContext.Default);
                            continue;
                        }
                        if (property0.NameEquals("originPath"u8))
                        {
                            originPath = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ruleSets"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ModelReaderWriter.Read<WritableSubResource>(new BinaryData(Encoding.UTF8.GetBytes(item.GetRawText())), options, AzureResourceManagerCdnContext.Default));
                            }
                            ruleSets = array;
                            continue;
                        }
                        if (property0.NameEquals("supportedProtocols"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<FrontDoorEndpointProtocol> array = new List<FrontDoorEndpointProtocol>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new FrontDoorEndpointProtocol(item.GetString()));
                            }
                            supportedProtocols = array;
                            continue;
                        }
                        if (property0.NameEquals("patternsToMatch"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            patternsToMatch = array;
                            continue;
                        }
                        if (property0.NameEquals("cacheConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                cacheConfiguration = null;
                                continue;
                            }
                            cacheConfiguration = FrontDoorRouteCacheConfiguration.DeserializeFrontDoorRouteCacheConfiguration(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("forwardingProtocol"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            forwardingProtocol = new ForwardingProtocol(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("linkToDefaultDomain"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            linkToDefaultDomain = new LinkToDefaultDomain(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("httpsRedirect"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            httpsRedirect = new HttpsRedirect(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("enabledState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enabledState = new EnabledState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new FrontDoorProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("deploymentStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            deploymentStatus = new FrontDoorDeploymentStatus(property0.Value.GetString());
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
            return new FrontDoorRouteData(
                id,
                name,
                type,
                systemData,
                endpointName,
                customDomains ?? new ChangeTrackingList<FrontDoorActivatedResourceInfo>(),
                originGroup,
                originPath,
                ruleSets ?? new ChangeTrackingList<WritableSubResource>(),
                supportedProtocols ?? new ChangeTrackingList<FrontDoorEndpointProtocol>(),
                patternsToMatch ?? new ChangeTrackingList<string>(),
                cacheConfiguration,
                forwardingProtocol,
                linkToDefaultDomain,
                httpsRedirect,
                enabledState,
                provisioningState,
                deploymentStatus,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FrontDoorRouteData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FrontDoorRouteData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerCdnContext.Default);
                default:
                    throw new FormatException($"The model {nameof(FrontDoorRouteData)} does not support writing '{options.Format}' format.");
            }
        }

        FrontDoorRouteData IPersistableModel<FrontDoorRouteData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FrontDoorRouteData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeFrontDoorRouteData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FrontDoorRouteData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FrontDoorRouteData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
