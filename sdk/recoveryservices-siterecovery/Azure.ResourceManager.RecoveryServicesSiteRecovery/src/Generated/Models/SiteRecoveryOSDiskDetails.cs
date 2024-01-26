// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Details of the OS Disk. </summary>
    public partial class SiteRecoveryOSDiskDetails
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

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryOSDiskDetails"/>. </summary>
        internal SiteRecoveryOSDiskDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryOSDiskDetails"/>. </summary>
        /// <param name="osVhdId"> The id of the disk containing the OS. </param>
        /// <param name="osType"> The type of the OS on the VM. </param>
        /// <param name="vhdName"> The OS disk VHD name. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SiteRecoveryOSDiskDetails(string osVhdId, string osType, string vhdName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            OSVhdId = osVhdId;
            OSType = osType;
            VhdName = vhdName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The id of the disk containing the OS. </summary>
        public string OSVhdId { get; }
        /// <summary> The type of the OS on the VM. </summary>
        public string OSType { get; }
        /// <summary> The OS disk VHD name. </summary>
        public string VhdName { get; }
    }
}
