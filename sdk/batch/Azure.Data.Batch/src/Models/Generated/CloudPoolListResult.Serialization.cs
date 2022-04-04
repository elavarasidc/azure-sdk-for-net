// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Data.Batch.Models
{
    internal partial class CloudPoolListResult
    {
        internal static CloudPoolListResult DeserializeCloudPoolListResult(JsonElement element)
        {
            Optional<IReadOnlyList<CloudPool>> value = default;
            Optional<string> odataNextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<CloudPool> array = new List<CloudPool>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CloudPool.DeserializeCloudPool(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("odata.nextLink"))
                {
                    odataNextLink = property.Value.GetString();
                    continue;
                }
            }
            return new CloudPoolListResult(Optional.ToList(value), odataNextLink.Value);
        }
    }
}
