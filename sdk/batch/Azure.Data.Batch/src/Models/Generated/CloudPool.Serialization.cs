// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Data.Batch.Models
{
    public partial class CloudPool
    {
        internal static CloudPool DeserializeCloudPool(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> displayName = default;
            Optional<string> url = default;
            Optional<string> eTag = default;
            Optional<DateTimeOffset> lastModified = default;
            Optional<DateTimeOffset> creationTime = default;
            Optional<PoolState> state = default;
            Optional<DateTimeOffset> stateTransitionTime = default;
            Optional<AllocationState> allocationState = default;
            Optional<DateTimeOffset> allocationStateTransitionTime = default;
            Optional<string> vmSize = default;
            Optional<CloudServiceConfiguration> cloudServiceConfiguration = default;
            Optional<VirtualMachineConfiguration> virtualMachineConfiguration = default;
            Optional<TimeSpan> resizeTimeout = default;
            Optional<IReadOnlyList<ResizeError>> resizeErrors = default;
            Optional<int> currentDedicatedNodes = default;
            Optional<int> currentLowPriorityNodes = default;
            Optional<int> targetDedicatedNodes = default;
            Optional<int> targetLowPriorityNodes = default;
            Optional<bool> enableAutoScale = default;
            Optional<string> autoScaleFormula = default;
            Optional<TimeSpan> autoScaleEvaluationInterval = default;
            Optional<AutoScaleRun> autoScaleRun = default;
            Optional<bool> enableInterNodeCommunication = default;
            Optional<NetworkConfiguration> networkConfiguration = default;
            Optional<StartTask> startTask = default;
            Optional<IReadOnlyList<CertificateReference>> certificateReferences = default;
            Optional<IReadOnlyList<ApplicationPackageReference>> applicationPackageReferences = default;
            Optional<IReadOnlyList<string>> applicationLicenses = default;
            Optional<int> taskSlotsPerNode = default;
            Optional<TaskSchedulingPolicy> taskSchedulingPolicy = default;
            Optional<IReadOnlyList<UserAccount>> userAccounts = default;
            Optional<IReadOnlyList<MetadataItem>> metadata = default;
            Optional<PoolStatistics> stats = default;
            Optional<IReadOnlyList<MountConfiguration>> mountConfiguration = default;
            Optional<BatchPoolIdentity> identity = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("url"))
                {
                    url = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("eTag"))
                {
                    eTag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastModified"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    lastModified = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("creationTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    creationTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("state"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    state = property.Value.GetString().ToPoolState();
                    continue;
                }
                if (property.NameEquals("stateTransitionTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    stateTransitionTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("allocationState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    allocationState = property.Value.GetString().ToAllocationState();
                    continue;
                }
                if (property.NameEquals("allocationStateTransitionTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    allocationStateTransitionTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("vmSize"))
                {
                    vmSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cloudServiceConfiguration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    cloudServiceConfiguration = CloudServiceConfiguration.DeserializeCloudServiceConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("virtualMachineConfiguration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    virtualMachineConfiguration = VirtualMachineConfiguration.DeserializeVirtualMachineConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("resizeTimeout"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    resizeTimeout = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("resizeErrors"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ResizeError> array = new List<ResizeError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResizeError.DeserializeResizeError(item));
                    }
                    resizeErrors = array;
                    continue;
                }
                if (property.NameEquals("currentDedicatedNodes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    currentDedicatedNodes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("currentLowPriorityNodes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    currentLowPriorityNodes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("targetDedicatedNodes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    targetDedicatedNodes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("targetLowPriorityNodes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    targetLowPriorityNodes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("enableAutoScale"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enableAutoScale = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("autoScaleFormula"))
                {
                    autoScaleFormula = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("autoScaleEvaluationInterval"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    autoScaleEvaluationInterval = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("autoScaleRun"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    autoScaleRun = AutoScaleRun.DeserializeAutoScaleRun(property.Value);
                    continue;
                }
                if (property.NameEquals("enableInterNodeCommunication"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enableInterNodeCommunication = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("networkConfiguration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    networkConfiguration = NetworkConfiguration.DeserializeNetworkConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("startTask"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    startTask = StartTask.DeserializeStartTask(property.Value);
                    continue;
                }
                if (property.NameEquals("certificateReferences"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<CertificateReference> array = new List<CertificateReference>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CertificateReference.DeserializeCertificateReference(item));
                    }
                    certificateReferences = array;
                    continue;
                }
                if (property.NameEquals("applicationPackageReferences"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ApplicationPackageReference> array = new List<ApplicationPackageReference>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ApplicationPackageReference.DeserializeApplicationPackageReference(item));
                    }
                    applicationPackageReferences = array;
                    continue;
                }
                if (property.NameEquals("applicationLicenses"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    applicationLicenses = array;
                    continue;
                }
                if (property.NameEquals("taskSlotsPerNode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    taskSlotsPerNode = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("taskSchedulingPolicy"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    taskSchedulingPolicy = TaskSchedulingPolicy.DeserializeTaskSchedulingPolicy(property.Value);
                    continue;
                }
                if (property.NameEquals("userAccounts"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<UserAccount> array = new List<UserAccount>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(UserAccount.DeserializeUserAccount(item));
                    }
                    userAccounts = array;
                    continue;
                }
                if (property.NameEquals("metadata"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<MetadataItem> array = new List<MetadataItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MetadataItem.DeserializeMetadataItem(item));
                    }
                    metadata = array;
                    continue;
                }
                if (property.NameEquals("stats"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    stats = PoolStatistics.DeserializePoolStatistics(property.Value);
                    continue;
                }
                if (property.NameEquals("mountConfiguration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<MountConfiguration> array = new List<MountConfiguration>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.MountConfiguration.DeserializeMountConfiguration(item));
                    }
                    mountConfiguration = array;
                    continue;
                }
                if (property.NameEquals("identity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    identity = BatchPoolIdentity.DeserializeBatchPoolIdentity(property.Value);
                    continue;
                }
            }
            return new CloudPool(id.Value, displayName.Value, url.Value, eTag.Value, Optional.ToNullable(lastModified), Optional.ToNullable(creationTime), Optional.ToNullable(state), Optional.ToNullable(stateTransitionTime), Optional.ToNullable(allocationState), Optional.ToNullable(allocationStateTransitionTime), vmSize.Value, cloudServiceConfiguration.Value, virtualMachineConfiguration.Value, Optional.ToNullable(resizeTimeout), Optional.ToList(resizeErrors), Optional.ToNullable(currentDedicatedNodes), Optional.ToNullable(currentLowPriorityNodes), Optional.ToNullable(targetDedicatedNodes), Optional.ToNullable(targetLowPriorityNodes), Optional.ToNullable(enableAutoScale), autoScaleFormula.Value, Optional.ToNullable(autoScaleEvaluationInterval), autoScaleRun.Value, Optional.ToNullable(enableInterNodeCommunication), networkConfiguration.Value, startTask.Value, Optional.ToList(certificateReferences), Optional.ToList(applicationPackageReferences), Optional.ToList(applicationLicenses), Optional.ToNullable(taskSlotsPerNode), taskSchedulingPolicy.Value, Optional.ToList(userAccounts), Optional.ToList(metadata), stats.Value, Optional.ToList(mountConfiguration), identity.Value);
        }
    }
}
