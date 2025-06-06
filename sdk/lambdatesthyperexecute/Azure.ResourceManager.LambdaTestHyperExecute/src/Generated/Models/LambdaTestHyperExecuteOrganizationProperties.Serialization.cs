// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.LambdaTestHyperExecute.Models
{
    public partial class LambdaTestHyperExecuteOrganizationProperties : IUtf8JsonSerializable, IJsonModel<LambdaTestHyperExecuteOrganizationProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LambdaTestHyperExecuteOrganizationProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<LambdaTestHyperExecuteOrganizationProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LambdaTestHyperExecuteOrganizationProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LambdaTestHyperExecuteOrganizationProperties)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("marketplace"u8);
            writer.WriteObjectValue(Marketplace, options);
            writer.WritePropertyName("user"u8);
            writer.WriteObjectValue(User, options);
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WritePropertyName("partnerProperties"u8);
            writer.WriteObjectValue(PartnerProperties, options);
            if (Optional.IsDefined(SingleSignOnProperties))
            {
                writer.WritePropertyName("singleSignOnProperties"u8);
                writer.WriteObjectValue(SingleSignOnProperties, options);
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

        LambdaTestHyperExecuteOrganizationProperties IJsonModel<LambdaTestHyperExecuteOrganizationProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LambdaTestHyperExecuteOrganizationProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LambdaTestHyperExecuteOrganizationProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLambdaTestHyperExecuteOrganizationProperties(document.RootElement, options);
        }

        internal static LambdaTestHyperExecuteOrganizationProperties DeserializeLambdaTestHyperExecuteOrganizationProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            LambdaTestHyperExecuteMarketplaceDetails marketplace = default;
            LambdaTestHyperExecuteUserDetails user = default;
            LambdaTestHyperExecuteOfferProvisioningState? provisioningState = default;
            LambdaTestHyperExecuteOfferPartnerProperties partnerProperties = default;
            LambdaTestHyperExecuteSingleSignOnPropertiesV2 singleSignOnProperties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("marketplace"u8))
                {
                    marketplace = LambdaTestHyperExecuteMarketplaceDetails.DeserializeLambdaTestHyperExecuteMarketplaceDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("user"u8))
                {
                    user = LambdaTestHyperExecuteUserDetails.DeserializeLambdaTestHyperExecuteUserDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new LambdaTestHyperExecuteOfferProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("partnerProperties"u8))
                {
                    partnerProperties = LambdaTestHyperExecuteOfferPartnerProperties.DeserializeLambdaTestHyperExecuteOfferPartnerProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("singleSignOnProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    singleSignOnProperties = LambdaTestHyperExecuteSingleSignOnPropertiesV2.DeserializeLambdaTestHyperExecuteSingleSignOnPropertiesV2(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new LambdaTestHyperExecuteOrganizationProperties(
                marketplace,
                user,
                provisioningState,
                partnerProperties,
                singleSignOnProperties,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LambdaTestHyperExecuteOrganizationProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LambdaTestHyperExecuteOrganizationProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LambdaTestHyperExecuteOrganizationProperties)} does not support writing '{options.Format}' format.");
            }
        }

        LambdaTestHyperExecuteOrganizationProperties IPersistableModel<LambdaTestHyperExecuteOrganizationProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LambdaTestHyperExecuteOrganizationProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeLambdaTestHyperExecuteOrganizationProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LambdaTestHyperExecuteOrganizationProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<LambdaTestHyperExecuteOrganizationProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
