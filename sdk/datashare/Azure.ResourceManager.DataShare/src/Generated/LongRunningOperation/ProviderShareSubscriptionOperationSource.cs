// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.DataShare
{
    internal class ProviderShareSubscriptionOperationSource : IOperationSource<ProviderShareSubscriptionResource>
    {
        private readonly ArmClient _client;

        internal ProviderShareSubscriptionOperationSource(ArmClient client)
        {
            _client = client;
        }

        ProviderShareSubscriptionResource IOperationSource<ProviderShareSubscriptionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<ProviderShareSubscriptionData>(response.Content);
            return new ProviderShareSubscriptionResource(_client, data);
        }

        async ValueTask<ProviderShareSubscriptionResource> IOperationSource<ProviderShareSubscriptionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<ProviderShareSubscriptionData>(response.Content);
            return await Task.FromResult(new ProviderShareSubscriptionResource(_client, data)).ConfigureAwait(false);
        }
    }
}
