// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class InitialReplicationDetails : IUtf8JsonSerializable, IJsonModel<InitialReplicationDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InitialReplicationDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<InitialReplicationDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InitialReplicationDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InitialReplicationDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(InitialReplicationType))
            {
                writer.WritePropertyName("initialReplicationType"u8);
                writer.WriteStringValue(InitialReplicationType);
            }
            if (Optional.IsDefined(InitialReplicationProgressPercentage))
            {
                writer.WritePropertyName("initialReplicationProgressPercentage"u8);
                writer.WriteStringValue(InitialReplicationProgressPercentage);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        InitialReplicationDetails IJsonModel<InitialReplicationDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InitialReplicationDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InitialReplicationDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInitialReplicationDetails(document.RootElement, options);
        }

        internal static InitialReplicationDetails DeserializeInitialReplicationDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> initialReplicationType = default;
            Optional<string> initialReplicationProgressPercentage = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("initialReplicationType"u8))
                {
                    initialReplicationType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("initialReplicationProgressPercentage"u8))
                {
                    initialReplicationProgressPercentage = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new InitialReplicationDetails(initialReplicationType.Value, initialReplicationProgressPercentage.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<InitialReplicationDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InitialReplicationDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InitialReplicationDetails)} does not support '{options.Format}' format.");
            }
        }

        InitialReplicationDetails IPersistableModel<InitialReplicationDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InitialReplicationDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInitialReplicationDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InitialReplicationDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<InitialReplicationDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
