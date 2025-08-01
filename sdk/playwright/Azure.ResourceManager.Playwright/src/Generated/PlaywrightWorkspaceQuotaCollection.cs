// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Playwright.Models;

namespace Azure.ResourceManager.Playwright
{
    /// <summary>
    /// A class representing a collection of <see cref="PlaywrightWorkspaceQuotaResource"/> and their operations.
    /// Each <see cref="PlaywrightWorkspaceQuotaResource"/> in the collection will belong to the same instance of <see cref="PlaywrightWorkspaceResource"/>.
    /// To get a <see cref="PlaywrightWorkspaceQuotaCollection"/> instance call the GetPlaywrightWorkspaceQuotas method from an instance of <see cref="PlaywrightWorkspaceResource"/>.
    /// </summary>
    public partial class PlaywrightWorkspaceQuotaCollection : ArmCollection, IEnumerable<PlaywrightWorkspaceQuotaResource>, IAsyncEnumerable<PlaywrightWorkspaceQuotaResource>
    {
        private readonly ClientDiagnostics _playwrightWorkspaceQuotaClientDiagnostics;
        private readonly PlaywrightWorkspaceQuotasRestOperations _playwrightWorkspaceQuotaRestClient;

        /// <summary> Initializes a new instance of the <see cref="PlaywrightWorkspaceQuotaCollection"/> class for mocking. </summary>
        protected PlaywrightWorkspaceQuotaCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PlaywrightWorkspaceQuotaCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PlaywrightWorkspaceQuotaCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _playwrightWorkspaceQuotaClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Playwright", PlaywrightWorkspaceQuotaResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(PlaywrightWorkspaceQuotaResource.ResourceType, out string playwrightWorkspaceQuotaApiVersion);
            _playwrightWorkspaceQuotaRestClient = new PlaywrightWorkspaceQuotasRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, playwrightWorkspaceQuotaApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != PlaywrightWorkspaceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, PlaywrightWorkspaceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get Playwright workspace quota resource by name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LoadTestService/playwrightWorkspaces/{playwrightWorkspaceName}/quotas/{quotaName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PlaywrightWorkspaceQuota_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PlaywrightWorkspaceQuotaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="quotaName"> The name of the PlaywrightWorkspaceQuota. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PlaywrightWorkspaceQuotaResource>> GetAsync(PlaywrightQuotaName quotaName, CancellationToken cancellationToken = default)
        {
            using var scope = _playwrightWorkspaceQuotaClientDiagnostics.CreateScope("PlaywrightWorkspaceQuotaCollection.Get");
            scope.Start();
            try
            {
                var response = await _playwrightWorkspaceQuotaRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, quotaName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PlaywrightWorkspaceQuotaResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get Playwright workspace quota resource by name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LoadTestService/playwrightWorkspaces/{playwrightWorkspaceName}/quotas/{quotaName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PlaywrightWorkspaceQuota_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PlaywrightWorkspaceQuotaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="quotaName"> The name of the PlaywrightWorkspaceQuota. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PlaywrightWorkspaceQuotaResource> Get(PlaywrightQuotaName quotaName, CancellationToken cancellationToken = default)
        {
            using var scope = _playwrightWorkspaceQuotaClientDiagnostics.CreateScope("PlaywrightWorkspaceQuotaCollection.Get");
            scope.Start();
            try
            {
                var response = _playwrightWorkspaceQuotaRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, quotaName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PlaywrightWorkspaceQuotaResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List quota resources for a given Playwright workspace resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LoadTestService/playwrightWorkspaces/{playwrightWorkspaceName}/quotas</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PlaywrightWorkspaceQuota_ListByPlaywrightWorkspace</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PlaywrightWorkspaceQuotaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PlaywrightWorkspaceQuotaResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PlaywrightWorkspaceQuotaResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _playwrightWorkspaceQuotaRestClient.CreateListByPlaywrightWorkspaceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _playwrightWorkspaceQuotaRestClient.CreateListByPlaywrightWorkspaceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new PlaywrightWorkspaceQuotaResource(Client, PlaywrightWorkspaceQuotaData.DeserializePlaywrightWorkspaceQuotaData(e)), _playwrightWorkspaceQuotaClientDiagnostics, Pipeline, "PlaywrightWorkspaceQuotaCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List quota resources for a given Playwright workspace resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LoadTestService/playwrightWorkspaces/{playwrightWorkspaceName}/quotas</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PlaywrightWorkspaceQuota_ListByPlaywrightWorkspace</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PlaywrightWorkspaceQuotaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PlaywrightWorkspaceQuotaResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PlaywrightWorkspaceQuotaResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _playwrightWorkspaceQuotaRestClient.CreateListByPlaywrightWorkspaceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _playwrightWorkspaceQuotaRestClient.CreateListByPlaywrightWorkspaceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new PlaywrightWorkspaceQuotaResource(Client, PlaywrightWorkspaceQuotaData.DeserializePlaywrightWorkspaceQuotaData(e)), _playwrightWorkspaceQuotaClientDiagnostics, Pipeline, "PlaywrightWorkspaceQuotaCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LoadTestService/playwrightWorkspaces/{playwrightWorkspaceName}/quotas/{quotaName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PlaywrightWorkspaceQuota_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PlaywrightWorkspaceQuotaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="quotaName"> The name of the PlaywrightWorkspaceQuota. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(PlaywrightQuotaName quotaName, CancellationToken cancellationToken = default)
        {
            using var scope = _playwrightWorkspaceQuotaClientDiagnostics.CreateScope("PlaywrightWorkspaceQuotaCollection.Exists");
            scope.Start();
            try
            {
                var response = await _playwrightWorkspaceQuotaRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, quotaName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LoadTestService/playwrightWorkspaces/{playwrightWorkspaceName}/quotas/{quotaName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PlaywrightWorkspaceQuota_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PlaywrightWorkspaceQuotaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="quotaName"> The name of the PlaywrightWorkspaceQuota. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(PlaywrightQuotaName quotaName, CancellationToken cancellationToken = default)
        {
            using var scope = _playwrightWorkspaceQuotaClientDiagnostics.CreateScope("PlaywrightWorkspaceQuotaCollection.Exists");
            scope.Start();
            try
            {
                var response = _playwrightWorkspaceQuotaRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, quotaName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LoadTestService/playwrightWorkspaces/{playwrightWorkspaceName}/quotas/{quotaName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PlaywrightWorkspaceQuota_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PlaywrightWorkspaceQuotaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="quotaName"> The name of the PlaywrightWorkspaceQuota. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<NullableResponse<PlaywrightWorkspaceQuotaResource>> GetIfExistsAsync(PlaywrightQuotaName quotaName, CancellationToken cancellationToken = default)
        {
            using var scope = _playwrightWorkspaceQuotaClientDiagnostics.CreateScope("PlaywrightWorkspaceQuotaCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _playwrightWorkspaceQuotaRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, quotaName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<PlaywrightWorkspaceQuotaResource>(response.GetRawResponse());
                return Response.FromValue(new PlaywrightWorkspaceQuotaResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LoadTestService/playwrightWorkspaces/{playwrightWorkspaceName}/quotas/{quotaName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PlaywrightWorkspaceQuota_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PlaywrightWorkspaceQuotaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="quotaName"> The name of the PlaywrightWorkspaceQuota. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual NullableResponse<PlaywrightWorkspaceQuotaResource> GetIfExists(PlaywrightQuotaName quotaName, CancellationToken cancellationToken = default)
        {
            using var scope = _playwrightWorkspaceQuotaClientDiagnostics.CreateScope("PlaywrightWorkspaceQuotaCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _playwrightWorkspaceQuotaRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, quotaName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<PlaywrightWorkspaceQuotaResource>(response.GetRawResponse());
                return Response.FromValue(new PlaywrightWorkspaceQuotaResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PlaywrightWorkspaceQuotaResource> IEnumerable<PlaywrightWorkspaceQuotaResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PlaywrightWorkspaceQuotaResource> IAsyncEnumerable<PlaywrightWorkspaceQuotaResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
