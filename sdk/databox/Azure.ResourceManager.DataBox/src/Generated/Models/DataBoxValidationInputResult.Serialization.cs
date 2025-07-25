// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    [PersistableModelProxy(typeof(UnknownValidationInputResponse))]
    public partial class DataBoxValidationInputResult : IUtf8JsonSerializable, IJsonModel<DataBoxValidationInputResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataBoxValidationInputResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DataBoxValidationInputResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxValidationInputResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxValidationInputResult)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("validationType"u8);
            writer.WriteStringValue(ValidationType.ToSerialString());
            if (options.Format != "W" && Optional.IsDefined(Error))
            {
                writer.WritePropertyName("error"u8);
                ((IJsonModel<ResponseError>)Error).Write(writer, options);
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

        DataBoxValidationInputResult IJsonModel<DataBoxValidationInputResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxValidationInputResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxValidationInputResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataBoxValidationInputResult(document.RootElement, options);
        }

        internal static DataBoxValidationInputResult DeserializeDataBoxValidationInputResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("validationType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "ValidateAddress": return AddressValidationResult.DeserializeAddressValidationResult(element, options);
                    case "ValidateCreateOrderLimit": return CreateOrderLimitForSubscriptionValidationResult.DeserializeCreateOrderLimitForSubscriptionValidationResult(element, options);
                    case "ValidateDataTransferDetails": return DataTransferDetailsValidationResult.DeserializeDataTransferDetailsValidationResult(element, options);
                    case "ValidatePreferences": return PreferencesValidationResult.DeserializePreferencesValidationResult(element, options);
                    case "ValidateSkuAvailability": return SkuAvailabilityValidationResult.DeserializeSkuAvailabilityValidationResult(element, options);
                    case "ValidateSubscriptionIsAllowedToCreateJob": return SubscriptionIsAllowedToCreateJobValidationResult.DeserializeSubscriptionIsAllowedToCreateJobValidationResult(element, options);
                }
            }
            return UnknownValidationInputResponse.DeserializeUnknownValidationInputResponse(element, options);
        }

        BinaryData IPersistableModel<DataBoxValidationInputResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxValidationInputResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerDataBoxContext.Default);
                default:
                    throw new FormatException($"The model {nameof(DataBoxValidationInputResult)} does not support writing '{options.Format}' format.");
            }
        }

        DataBoxValidationInputResult IPersistableModel<DataBoxValidationInputResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxValidationInputResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDataBoxValidationInputResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataBoxValidationInputResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataBoxValidationInputResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
