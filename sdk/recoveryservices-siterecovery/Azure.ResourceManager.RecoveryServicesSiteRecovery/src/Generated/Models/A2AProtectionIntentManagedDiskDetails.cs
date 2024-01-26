// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Azure VM managed disk input details. </summary>
    public partial class A2AProtectionIntentManagedDiskDetails
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="A2AProtectionIntentManagedDiskDetails"/>. </summary>
        /// <param name="diskId"> The disk Id. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="diskId"/> is null. </exception>
        public A2AProtectionIntentManagedDiskDetails(string diskId)
        {
            Argument.AssertNotNull(diskId, nameof(diskId));

            DiskId = diskId;
        }

        /// <summary> Initializes a new instance of <see cref="A2AProtectionIntentManagedDiskDetails"/>. </summary>
        /// <param name="diskId"> The disk Id. </param>
        /// <param name="primaryStagingStorageAccountCustomContent">
        /// The primary staging storage account input.
        /// Please note <see cref="StorageAccountCustomDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ExistingStorageAccount"/>.
        /// </param>
        /// <param name="recoveryResourceGroupCustomContent">
        /// The recovery resource group input.
        /// Please note <see cref="RecoveryResourceGroupCustomDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ExistingRecoveryResourceGroup"/>.
        /// </param>
        /// <param name="recoveryReplicaDiskAccountType"> The replica disk type. Its an optional value and will be same as source disk type if not user provided. </param>
        /// <param name="recoveryTargetDiskAccountType"> The target disk type after failover. Its an optional value and will be same as source disk type if not user provided. </param>
        /// <param name="recoveryDiskEncryptionSetId"> The recovery disk encryption set Id. </param>
        /// <param name="diskEncryptionInfo"> The recovery disk encryption information (for one / single pass flows). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal A2AProtectionIntentManagedDiskDetails(string diskId, StorageAccountCustomDetails primaryStagingStorageAccountCustomContent, RecoveryResourceGroupCustomDetails recoveryResourceGroupCustomContent, string recoveryReplicaDiskAccountType, string recoveryTargetDiskAccountType, ResourceIdentifier recoveryDiskEncryptionSetId, SiteRecoveryDiskEncryptionInfo diskEncryptionInfo, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DiskId = diskId;
            PrimaryStagingStorageAccountCustomContent = primaryStagingStorageAccountCustomContent;
            RecoveryResourceGroupCustomContent = recoveryResourceGroupCustomContent;
            RecoveryReplicaDiskAccountType = recoveryReplicaDiskAccountType;
            RecoveryTargetDiskAccountType = recoveryTargetDiskAccountType;
            RecoveryDiskEncryptionSetId = recoveryDiskEncryptionSetId;
            DiskEncryptionInfo = diskEncryptionInfo;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="A2AProtectionIntentManagedDiskDetails"/> for deserialization. </summary>
        internal A2AProtectionIntentManagedDiskDetails()
        {
        }

        /// <summary> The disk Id. </summary>
        public string DiskId { get; set; }
        /// <summary>
        /// The primary staging storage account input.
        /// Please note <see cref="StorageAccountCustomDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ExistingStorageAccount"/>.
        /// </summary>
        public StorageAccountCustomDetails PrimaryStagingStorageAccountCustomContent { get; set; }
        /// <summary>
        /// The recovery resource group input.
        /// Please note <see cref="RecoveryResourceGroupCustomDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ExistingRecoveryResourceGroup"/>.
        /// </summary>
        public RecoveryResourceGroupCustomDetails RecoveryResourceGroupCustomContent { get; set; }
        /// <summary> The replica disk type. Its an optional value and will be same as source disk type if not user provided. </summary>
        public string RecoveryReplicaDiskAccountType { get; set; }
        /// <summary> The target disk type after failover. Its an optional value and will be same as source disk type if not user provided. </summary>
        public string RecoveryTargetDiskAccountType { get; set; }
        /// <summary> The recovery disk encryption set Id. </summary>
        public ResourceIdentifier RecoveryDiskEncryptionSetId { get; set; }
        /// <summary> The recovery disk encryption information (for one / single pass flows). </summary>
        public SiteRecoveryDiskEncryptionInfo DiskEncryptionInfo { get; set; }
    }
}
