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

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class SecuritySolutionsReferenceData : IUtf8JsonSerializable, IJsonModel<SecuritySolutionsReferenceData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecuritySolutionsReferenceData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SecuritySolutionsReferenceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecuritySolutionsReferenceData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecuritySolutionsReferenceData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (options.Format != "W" && Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("securityFamily"u8);
            writer.WriteStringValue(SecurityFamily.ToString());
            writer.WritePropertyName("alertVendorName"u8);
            writer.WriteStringValue(AlertVendorName);
            writer.WritePropertyName("packageInfoUrl"u8);
            writer.WriteStringValue(PackageInfoUri.AbsoluteUri);
            writer.WritePropertyName("productName"u8);
            writer.WriteStringValue(ProductName);
            writer.WritePropertyName("publisher"u8);
            writer.WriteStringValue(Publisher);
            writer.WritePropertyName("publisherDisplayName"u8);
            writer.WriteStringValue(PublisherDisplayName);
            writer.WritePropertyName("template"u8);
            writer.WriteStringValue(Template);
            writer.WriteEndObject();
        }

        SecuritySolutionsReferenceData IJsonModel<SecuritySolutionsReferenceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecuritySolutionsReferenceData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecuritySolutionsReferenceData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecuritySolutionsReferenceData(document.RootElement, options);
        }

        internal static SecuritySolutionsReferenceData DeserializeSecuritySolutionsReferenceData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AzureLocation? location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            SecurityFamily securityFamily = default;
            string alertVendorName = default;
            Uri packageInfoUrl = default;
            string productName = default;
            string publisher = default;
            string publisherDisplayName = default;
            string template = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
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
                    systemData = ModelReaderWriter.Read<SystemData>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), ModelSerializationExtensions.WireOptions, AzureResourceManagerSecurityCenterContext.Default);
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
                        if (property0.NameEquals("securityFamily"u8))
                        {
                            securityFamily = new SecurityFamily(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("alertVendorName"u8))
                        {
                            alertVendorName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("packageInfoUrl"u8))
                        {
                            packageInfoUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("productName"u8))
                        {
                            productName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("publisher"u8))
                        {
                            publisher = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("publisherDisplayName"u8))
                        {
                            publisherDisplayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("template"u8))
                        {
                            template = property0.Value.GetString();
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
            return new SecuritySolutionsReferenceData(
                id,
                name,
                type,
                systemData,
                securityFamily,
                alertVendorName,
                packageInfoUrl,
                productName,
                publisher,
                publisherDisplayName,
                template,
                location,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SecuritySolutionsReferenceData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecuritySolutionsReferenceData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerSecurityCenterContext.Default);
                default:
                    throw new FormatException($"The model {nameof(SecuritySolutionsReferenceData)} does not support writing '{options.Format}' format.");
            }
        }

        SecuritySolutionsReferenceData IPersistableModel<SecuritySolutionsReferenceData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecuritySolutionsReferenceData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeSecuritySolutionsReferenceData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SecuritySolutionsReferenceData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecuritySolutionsReferenceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
