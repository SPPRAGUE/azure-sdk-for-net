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
using Azure.ResourceManager.DataBox.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBox
{
    public partial class DataBoxJobData : IUtf8JsonSerializable, IJsonModel<DataBoxJobData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataBoxJobData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DataBoxJobData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxJobData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxJobData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("sku"u8);
            writer.WriteObjectValue(Sku, options);
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                ((IJsonModel<ManagedServiceIdentity>)Identity).Write(writer, options);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("transferType"u8);
            writer.WriteStringValue(TransferType.ToSerialString());
            if (options.Format != "W" && Optional.IsDefined(IsCancellable))
            {
                writer.WritePropertyName("isCancellable"u8);
                writer.WriteBooleanValue(IsCancellable.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(IsDeletable))
            {
                writer.WritePropertyName("isDeletable"u8);
                writer.WriteBooleanValue(IsDeletable.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(IsShippingAddressEditable))
            {
                writer.WritePropertyName("isShippingAddressEditable"u8);
                writer.WriteBooleanValue(IsShippingAddressEditable.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ReverseShippingDetailsUpdate))
            {
                writer.WritePropertyName("reverseShippingDetailsUpdate"u8);
                writer.WriteStringValue(ReverseShippingDetailsUpdate.Value.ToSerialString());
            }
            if (options.Format != "W" && Optional.IsDefined(ReverseTransportPreferenceUpdate))
            {
                writer.WritePropertyName("reverseTransportPreferenceUpdate"u8);
                writer.WriteStringValue(ReverseTransportPreferenceUpdate.Value.ToSerialString());
            }
            if (options.Format != "W" && Optional.IsDefined(IsPrepareToShipEnabled))
            {
                writer.WritePropertyName("isPrepareToShipEnabled"u8);
                writer.WriteBooleanValue(IsPrepareToShipEnabled.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(DelayedStage))
            {
                writer.WritePropertyName("delayedStage"u8);
                writer.WriteStringValue(DelayedStage.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(Error))
            {
                writer.WritePropertyName("error"u8);
                ((IJsonModel<ResponseError>)Error).Write(writer, options);
            }
            if (Optional.IsDefined(Details))
            {
                writer.WritePropertyName("details"u8);
                writer.WriteObjectValue(Details, options);
            }
            if (options.Format != "W" && Optional.IsDefined(CancellationReason))
            {
                writer.WritePropertyName("cancellationReason"u8);
                writer.WriteStringValue(CancellationReason);
            }
            if (Optional.IsDefined(DeliveryType))
            {
                writer.WritePropertyName("deliveryType"u8);
                writer.WriteStringValue(DeliveryType.Value.ToSerialString());
            }
            if (Optional.IsDefined(DeliveryInfo))
            {
                writer.WritePropertyName("deliveryInfo"u8);
                writer.WriteObjectValue(DeliveryInfo, options);
            }
            if (options.Format != "W" && Optional.IsDefined(IsCancellableWithoutFee))
            {
                writer.WritePropertyName("isCancellableWithoutFee"u8);
                writer.WriteBooleanValue(IsCancellableWithoutFee.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(AreAllDevicesLost))
            {
                writer.WritePropertyName("allDevicesLost"u8);
                writer.WriteBooleanValue(AreAllDevicesLost.Value);
            }
            writer.WriteEndObject();
        }

        DataBoxJobData IJsonModel<DataBoxJobData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxJobData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxJobData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataBoxJobData(document.RootElement, options);
        }

        internal static DataBoxJobData DeserializeDataBoxJobData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataBoxSku sku = default;
            ManagedServiceIdentity identity = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            DataBoxJobTransferType transferType = default;
            bool? isCancellable = default;
            bool? isDeletable = default;
            bool? isShippingAddressEditable = default;
            ReverseShippingDetailsEditStatus? reverseShippingDetailsUpdate = default;
            ReverseTransportPreferenceEditStatus? reverseTransportPreferenceUpdate = default;
            bool? isPrepareToShipEnabled = default;
            DataBoxStageName? status = default;
            DataBoxStageName? delayedStage = default;
            DateTimeOffset? startTime = default;
            ResponseError error = default;
            DataBoxBasicJobDetails details = default;
            string cancellationReason = default;
            JobDeliveryType? deliveryType = default;
            JobDeliveryInfo deliveryInfo = default;
            bool? isCancellableWithoutFee = default;
            bool? allDevicesLost = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    sku = DataBoxSku.DeserializeDataBoxSku(property.Value, options);
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = ModelReaderWriter.Read<ManagedServiceIdentity>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), options, AzureResourceManagerDataBoxContext.Default);
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
                    systemData = ModelReaderWriter.Read<SystemData>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), ModelSerializationExtensions.WireOptions, AzureResourceManagerDataBoxContext.Default);
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
                        if (property0.NameEquals("transferType"u8))
                        {
                            transferType = property0.Value.GetString().ToDataBoxJobTransferType();
                            continue;
                        }
                        if (property0.NameEquals("isCancellable"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isCancellable = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isDeletable"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isDeletable = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isShippingAddressEditable"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isShippingAddressEditable = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("reverseShippingDetailsUpdate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            reverseShippingDetailsUpdate = property0.Value.GetString().ToReverseShippingDetailsEditStatus();
                            continue;
                        }
                        if (property0.NameEquals("reverseTransportPreferenceUpdate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            reverseTransportPreferenceUpdate = property0.Value.GetString().ToReverseTransportPreferenceEditStatus();
                            continue;
                        }
                        if (property0.NameEquals("isPrepareToShipEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isPrepareToShipEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = new DataBoxStageName(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("delayedStage"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            delayedStage = new DataBoxStageName(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("startTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            startTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("error"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            error = ModelReaderWriter.Read<ResponseError>(new BinaryData(Encoding.UTF8.GetBytes(property0.Value.GetRawText())), options, AzureResourceManagerDataBoxContext.Default);
                            continue;
                        }
                        if (property0.NameEquals("details"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            details = DataBoxBasicJobDetails.DeserializeDataBoxBasicJobDetails(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("cancellationReason"u8))
                        {
                            cancellationReason = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("deliveryType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            deliveryType = property0.Value.GetString().ToJobDeliveryType();
                            continue;
                        }
                        if (property0.NameEquals("deliveryInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            deliveryInfo = JobDeliveryInfo.DeserializeJobDeliveryInfo(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("isCancellableWithoutFee"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isCancellableWithoutFee = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("allDevicesLost"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            allDevicesLost = property0.Value.GetBoolean();
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
            return new DataBoxJobData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                transferType,
                isCancellable,
                isDeletable,
                isShippingAddressEditable,
                reverseShippingDetailsUpdate,
                reverseTransportPreferenceUpdate,
                isPrepareToShipEnabled,
                status,
                delayedStage,
                startTime,
                error,
                details,
                cancellationReason,
                deliveryType,
                deliveryInfo,
                isCancellableWithoutFee,
                allDevicesLost,
                sku,
                identity,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataBoxJobData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxJobData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerDataBoxContext.Default);
                default:
                    throw new FormatException($"The model {nameof(DataBoxJobData)} does not support writing '{options.Format}' format.");
            }
        }

        DataBoxJobData IPersistableModel<DataBoxJobData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxJobData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDataBoxJobData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataBoxJobData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataBoxJobData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
