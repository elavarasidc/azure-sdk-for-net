// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Communication.Models
{
    /// <summary> The resource management error additional info. </summary>
    public partial class ErrorAdditionalInfo
    {
        /// <summary> Initializes a new instance of ErrorAdditionalInfo. </summary>
        internal ErrorAdditionalInfo()
        {
        }

        /// <summary> Initializes a new instance of ErrorAdditionalInfo. </summary>
        /// <param name="type"> The additional info type. </param>
        /// <param name="info"> The additional info. </param>
        internal ErrorAdditionalInfo(string type, object info)
        {
            Type = type;
            Info = info;
        }

        /// <summary> The additional info type. </summary>
        public string Type { get; }
        /// <summary> The additional info. </summary>
        public object Info { get; }
    }
}
