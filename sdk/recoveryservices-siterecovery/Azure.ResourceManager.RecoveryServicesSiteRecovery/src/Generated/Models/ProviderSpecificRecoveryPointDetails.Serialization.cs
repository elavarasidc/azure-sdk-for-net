// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    [PersistableModelProxy(typeof(UnknownProviderSpecificRecoveryPointDetails))]
    public partial class ProviderSpecificRecoveryPointDetails : IUtf8JsonSerializable, IJsonModel<ProviderSpecificRecoveryPointDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ProviderSpecificRecoveryPointDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ProviderSpecificRecoveryPointDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProviderSpecificRecoveryPointDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProviderSpecificRecoveryPointDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        ProviderSpecificRecoveryPointDetails IJsonModel<ProviderSpecificRecoveryPointDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProviderSpecificRecoveryPointDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProviderSpecificRecoveryPointDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeProviderSpecificRecoveryPointDetails(document.RootElement, options);
        }

        internal static ProviderSpecificRecoveryPointDetails DeserializeProviderSpecificRecoveryPointDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("instanceType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "A2A": return A2ARecoveryPointDetails.DeserializeA2ARecoveryPointDetails(element);
                    case "InMageAzureV2": return InMageAzureV2RecoveryPointDetails.DeserializeInMageAzureV2RecoveryPointDetails(element);
                    case "InMageRcm": return InMageRcmRecoveryPointDetails.DeserializeInMageRcmRecoveryPointDetails(element);
                }
            }
            return UnknownProviderSpecificRecoveryPointDetails.DeserializeUnknownProviderSpecificRecoveryPointDetails(element);
        }

        BinaryData IPersistableModel<ProviderSpecificRecoveryPointDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProviderSpecificRecoveryPointDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ProviderSpecificRecoveryPointDetails)} does not support '{options.Format}' format.");
            }
        }

        ProviderSpecificRecoveryPointDetails IPersistableModel<ProviderSpecificRecoveryPointDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProviderSpecificRecoveryPointDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeProviderSpecificRecoveryPointDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ProviderSpecificRecoveryPointDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ProviderSpecificRecoveryPointDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
