// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> InMageRcm discovered protected VM details. </summary>
    public partial class InMageRcmDiscoveredProtectedVmDetails
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

        /// <summary> Initializes a new instance of <see cref="InMageRcmDiscoveredProtectedVmDetails"/>. </summary>
        internal InMageRcmDiscoveredProtectedVmDetails()
        {
            Datastores = new ChangeTrackingList<string>();
            IPAddresses = new ChangeTrackingList<IPAddress>();
        }

        /// <summary> Initializes a new instance of <see cref="InMageRcmDiscoveredProtectedVmDetails"/>. </summary>
        /// <param name="vCenterId"> The VCenter Id. </param>
        /// <param name="vCenterFqdn"> The VCenter fqdn. </param>
        /// <param name="datastores"> The list of datastores. </param>
        /// <param name="ipAddresses"> The list of IP addresses. </param>
        /// <param name="vmwareToolsStatus"> The VMware tools status. </param>
        /// <param name="powerStatus"> The VM power status. </param>
        /// <param name="vmFqdn"> The VM fqdn. </param>
        /// <param name="osName"> The VM's OS name. </param>
        /// <param name="createdOn"> The SDS created timestamp. </param>
        /// <param name="updatedOn"> The SDS updated timestamp. </param>
        /// <param name="isDeleted"> A value indicating whether the VM is deleted. </param>
        /// <param name="lastDiscoveryTimeInUtc"> The last time when SDS information discovered in SRS. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal InMageRcmDiscoveredProtectedVmDetails(string vCenterId, string vCenterFqdn, IReadOnlyList<string> datastores, IReadOnlyList<IPAddress> ipAddresses, string vmwareToolsStatus, string powerStatus, string vmFqdn, string osName, DateTimeOffset? createdOn, DateTimeOffset? updatedOn, bool? isDeleted, DateTimeOffset? lastDiscoveryTimeInUtc, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            VCenterId = vCenterId;
            VCenterFqdn = vCenterFqdn;
            Datastores = datastores;
            IPAddresses = ipAddresses;
            VMwareToolsStatus = vmwareToolsStatus;
            PowerStatus = powerStatus;
            VmFqdn = vmFqdn;
            OSName = osName;
            CreatedOn = createdOn;
            UpdatedOn = updatedOn;
            IsDeleted = isDeleted;
            LastDiscoveryTimeInUtc = lastDiscoveryTimeInUtc;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The VCenter Id. </summary>
        public string VCenterId { get; }
        /// <summary> The VCenter fqdn. </summary>
        public string VCenterFqdn { get; }
        /// <summary> The list of datastores. </summary>
        public IReadOnlyList<string> Datastores { get; }
        /// <summary> The list of IP addresses. </summary>
        public IReadOnlyList<IPAddress> IPAddresses { get; }
        /// <summary> The VMware tools status. </summary>
        public string VMwareToolsStatus { get; }
        /// <summary> The VM power status. </summary>
        public string PowerStatus { get; }
        /// <summary> The VM fqdn. </summary>
        public string VmFqdn { get; }
        /// <summary> The VM's OS name. </summary>
        public string OSName { get; }
        /// <summary> The SDS created timestamp. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The SDS updated timestamp. </summary>
        public DateTimeOffset? UpdatedOn { get; }
        /// <summary> A value indicating whether the VM is deleted. </summary>
        public bool? IsDeleted { get; }
        /// <summary> The last time when SDS information discovered in SRS. </summary>
        public DateTimeOffset? LastDiscoveryTimeInUtc { get; }
    }
}
