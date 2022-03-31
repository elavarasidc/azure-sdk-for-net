// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Cdn
{
    internal class AfdSecurityPolicyOperationSource : IOperationSource<AfdSecurityPolicyResource>
    {
        private readonly ArmClient _client;

        internal AfdSecurityPolicyOperationSource(ArmClient client)
        {
            _client = client;
        }

        AfdSecurityPolicyResource IOperationSource<AfdSecurityPolicyResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = AfdSecurityPolicyData.DeserializeAfdSecurityPolicyData(document.RootElement);
            return new AfdSecurityPolicyResource(_client, data);
        }

        async ValueTask<AfdSecurityPolicyResource> IOperationSource<AfdSecurityPolicyResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = AfdSecurityPolicyData.DeserializeAfdSecurityPolicyData(document.RootElement);
            return new AfdSecurityPolicyResource(_client, data);
        }
    }
}
