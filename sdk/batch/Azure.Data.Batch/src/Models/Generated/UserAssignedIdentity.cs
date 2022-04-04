// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Data.Batch.Models
{
    /// <summary> The user assigned Identity. </summary>
    public partial class UserAssignedIdentity
    {
        /// <summary> Initializes a new instance of UserAssignedIdentity. </summary>
        /// <param name="resourceId"> The ARM resource id of the user assigned identity. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceId"/> is null. </exception>
        internal UserAssignedIdentity(string resourceId)
        {
            if (resourceId == null)
            {
                throw new ArgumentNullException(nameof(resourceId));
            }

            ResourceId = resourceId;
        }

        /// <summary> Initializes a new instance of UserAssignedIdentity. </summary>
        /// <param name="resourceId"> The ARM resource id of the user assigned identity. </param>
        /// <param name="clientId"> The client id of the user assigned identity. </param>
        /// <param name="principalId"> The principal id of the user assigned identity. </param>
        internal UserAssignedIdentity(string resourceId, string clientId, string principalId)
        {
            ResourceId = resourceId;
            ClientId = clientId;
            PrincipalId = principalId;
        }

        /// <summary> The ARM resource id of the user assigned identity. </summary>
        public string ResourceId { get; }
        /// <summary> The client id of the user assigned identity. </summary>
        public string ClientId { get; }
        /// <summary> The principal id of the user assigned identity. </summary>
        public string PrincipalId { get; }
    }
}
