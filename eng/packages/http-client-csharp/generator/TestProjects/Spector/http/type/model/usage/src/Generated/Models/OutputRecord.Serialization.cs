// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace _Type.Model.Usage
{
    public partial class OutputRecord : IJsonModel<OutputRecord>
    {
        void IJsonModel<OutputRecord>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        OutputRecord IJsonModel<OutputRecord>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        protected virtual OutputRecord JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        BinaryData IPersistableModel<OutputRecord>.Write(ModelReaderWriterOptions options) => throw null;

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options) => throw null;

        OutputRecord IPersistableModel<OutputRecord>.Create(BinaryData data, ModelReaderWriterOptions options) => throw null;

        protected virtual OutputRecord PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options) => throw null;

        string IPersistableModel<OutputRecord>.GetFormatFromOptions(ModelReaderWriterOptions options) => throw null;

        /// <param name="outputRecord"> The <see cref="OutputRecord"/> to serialize into <see cref="RequestContent"/>. </param>
        public static implicit operator RequestContent(OutputRecord outputRecord) => throw null;

        public static explicit operator OutputRecord(Response result) => throw null;
    }
}
