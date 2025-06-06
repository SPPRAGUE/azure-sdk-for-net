// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace _Type.Property.AdditionalProperties
{
    public partial class SpreadModelArrayRecord : IJsonModel<SpreadModelArrayRecord>
    {
        void IJsonModel<SpreadModelArrayRecord>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        SpreadModelArrayRecord IJsonModel<SpreadModelArrayRecord>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        protected virtual SpreadModelArrayRecord JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        BinaryData IPersistableModel<SpreadModelArrayRecord>.Write(ModelReaderWriterOptions options) => throw null;

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options) => throw null;

        SpreadModelArrayRecord IPersistableModel<SpreadModelArrayRecord>.Create(BinaryData data, ModelReaderWriterOptions options) => throw null;

        protected virtual SpreadModelArrayRecord PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options) => throw null;

        string IPersistableModel<SpreadModelArrayRecord>.GetFormatFromOptions(ModelReaderWriterOptions options) => throw null;

        /// <param name="spreadModelArrayRecord"> The <see cref="SpreadModelArrayRecord"/> to serialize into <see cref="RequestContent"/>. </param>
        public static implicit operator RequestContent(SpreadModelArrayRecord spreadModelArrayRecord) => throw null;

        public static explicit operator SpreadModelArrayRecord(Response result) => throw null;
    }
}
