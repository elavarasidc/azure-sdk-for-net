// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.Network
{
    /// <summary> Resets the VPN client shared key of the virtual network gateway in the specified resource group. </summary>
    public partial class VirtualNetworkGatewaysResetVpnClientSharedKeyOperation : Operation<Response>, IOperationSource<Response>
    {
        private readonly ArmOperationHelpers<Response> _operation;

        /// <summary> Initializes a new instance of VirtualNetworkGatewaysResetVpnClientSharedKeyOperation for mocking. </summary>
        protected VirtualNetworkGatewaysResetVpnClientSharedKeyOperation()
        {
        }

        internal VirtualNetworkGatewaysResetVpnClientSharedKeyOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new ArmOperationHelpers<Response>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "VirtualNetworkGatewaysResetVpnClientSharedKeyOperation");
        }
        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override Response Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<Response>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<Response>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        Response IOperationSource<Response>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            return response;
        }

        async ValueTask<Response> IOperationSource<Response>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            return await new ValueTask<Response>(response).ConfigureAwait(false);
        }
    }
}
