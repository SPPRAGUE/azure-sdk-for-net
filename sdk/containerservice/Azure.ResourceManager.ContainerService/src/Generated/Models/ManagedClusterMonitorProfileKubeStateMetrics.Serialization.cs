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

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ManagedClusterMonitorProfileKubeStateMetrics : IUtf8JsonSerializable, IJsonModel<ManagedClusterMonitorProfileKubeStateMetrics>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedClusterMonitorProfileKubeStateMetrics>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ManagedClusterMonitorProfileKubeStateMetrics>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterMonitorProfileKubeStateMetrics>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterMonitorProfileKubeStateMetrics)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(MetricLabelsAllowlist))
            {
                writer.WritePropertyName("metricLabelsAllowlist"u8);
                writer.WriteStringValue(MetricLabelsAllowlist);
            }
            if (Optional.IsDefined(MetricAnnotationsAllowList))
            {
                writer.WritePropertyName("metricAnnotationsAllowList"u8);
                writer.WriteStringValue(MetricAnnotationsAllowList);
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

        ManagedClusterMonitorProfileKubeStateMetrics IJsonModel<ManagedClusterMonitorProfileKubeStateMetrics>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterMonitorProfileKubeStateMetrics>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterMonitorProfileKubeStateMetrics)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedClusterMonitorProfileKubeStateMetrics(document.RootElement, options);
        }

        internal static ManagedClusterMonitorProfileKubeStateMetrics DeserializeManagedClusterMonitorProfileKubeStateMetrics(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string metricLabelsAllowlist = default;
            string metricAnnotationsAllowList = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("metricLabelsAllowlist"u8))
                {
                    metricLabelsAllowlist = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metricAnnotationsAllowList"u8))
                {
                    metricAnnotationsAllowList = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ManagedClusterMonitorProfileKubeStateMetrics(metricLabelsAllowlist, metricAnnotationsAllowList, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MetricLabelsAllowlist), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  metricLabelsAllowlist: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(MetricLabelsAllowlist))
                {
                    builder.Append("  metricLabelsAllowlist: ");
                    if (MetricLabelsAllowlist.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{MetricLabelsAllowlist}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{MetricLabelsAllowlist}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MetricAnnotationsAllowList), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  metricAnnotationsAllowList: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(MetricAnnotationsAllowList))
                {
                    builder.Append("  metricAnnotationsAllowList: ");
                    if (MetricAnnotationsAllowList.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{MetricAnnotationsAllowList}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{MetricAnnotationsAllowList}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ManagedClusterMonitorProfileKubeStateMetrics>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterMonitorProfileKubeStateMetrics>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterMonitorProfileKubeStateMetrics)} does not support writing '{options.Format}' format.");
            }
        }

        ManagedClusterMonitorProfileKubeStateMetrics IPersistableModel<ManagedClusterMonitorProfileKubeStateMetrics>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterMonitorProfileKubeStateMetrics>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeManagedClusterMonitorProfileKubeStateMetrics(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterMonitorProfileKubeStateMetrics)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedClusterMonitorProfileKubeStateMetrics>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
