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

namespace Azure.ResourceManager.Compute
{
    /// <summary>
    /// A class representing a collection of <see cref="VirtualMachineRunCommandResource"/> and their operations.
    /// Each <see cref="VirtualMachineRunCommandResource"/> in the collection will belong to the same instance of <see cref="VirtualMachineResource"/>.
    /// To get a <see cref="VirtualMachineRunCommandCollection"/> instance call the GetVirtualMachineRunCommands method from an instance of <see cref="VirtualMachineResource"/>.
    /// </summary>
    public partial class VirtualMachineRunCommandCollection : ArmCollection, IEnumerable<VirtualMachineRunCommandResource>, IAsyncEnumerable<VirtualMachineRunCommandResource>
    {
        private readonly ClientDiagnostics _virtualMachineRunCommandClientDiagnostics;
        private readonly VirtualMachineRunCommandsRestOperations _virtualMachineRunCommandRestClient;

        /// <summary> Initializes a new instance of the <see cref="VirtualMachineRunCommandCollection"/> class for mocking. </summary>
        protected VirtualMachineRunCommandCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VirtualMachineRunCommandCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal VirtualMachineRunCommandCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _virtualMachineRunCommandClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Compute", VirtualMachineRunCommandResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(VirtualMachineRunCommandResource.ResourceType, out string virtualMachineRunCommandApiVersion);
            _virtualMachineRunCommandRestClient = new VirtualMachineRunCommandsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, virtualMachineRunCommandApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != VirtualMachineResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, VirtualMachineResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// The operation to create or update the run command.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}/runCommands/{runCommandName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineRunCommands_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualMachineRunCommandResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="runCommandName"> The name of the VirtualMachineRunCommand. </param>
        /// <param name="data"> Parameters supplied to the Create Virtual Machine RunCommand operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runCommandName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runCommandName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<VirtualMachineRunCommandResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string runCommandName, VirtualMachineRunCommandData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(runCommandName, nameof(runCommandName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _virtualMachineRunCommandClientDiagnostics.CreateScope("VirtualMachineRunCommandCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _virtualMachineRunCommandRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, runCommandName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ComputeArmOperation<VirtualMachineRunCommandResource>(new VirtualMachineRunCommandOperationSource(Client), _virtualMachineRunCommandClientDiagnostics, Pipeline, _virtualMachineRunCommandRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, runCommandName, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to create or update the run command.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}/runCommands/{runCommandName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineRunCommands_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualMachineRunCommandResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="runCommandName"> The name of the VirtualMachineRunCommand. </param>
        /// <param name="data"> Parameters supplied to the Create Virtual Machine RunCommand operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runCommandName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runCommandName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<VirtualMachineRunCommandResource> CreateOrUpdate(WaitUntil waitUntil, string runCommandName, VirtualMachineRunCommandData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(runCommandName, nameof(runCommandName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _virtualMachineRunCommandClientDiagnostics.CreateScope("VirtualMachineRunCommandCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _virtualMachineRunCommandRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, runCommandName, data, cancellationToken);
                var operation = new ComputeArmOperation<VirtualMachineRunCommandResource>(new VirtualMachineRunCommandOperationSource(Client), _virtualMachineRunCommandClientDiagnostics, Pipeline, _virtualMachineRunCommandRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, runCommandName, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to get the run command.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}/runCommands/{runCommandName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineRunCommands_GetByVirtualMachine</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualMachineRunCommandResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="runCommandName"> The name of the VirtualMachineRunCommand. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runCommandName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runCommandName"/> is null. </exception>
        public virtual async Task<Response<VirtualMachineRunCommandResource>> GetAsync(string runCommandName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(runCommandName, nameof(runCommandName));

            using var scope = _virtualMachineRunCommandClientDiagnostics.CreateScope("VirtualMachineRunCommandCollection.Get");
            scope.Start();
            try
            {
                var response = await _virtualMachineRunCommandRestClient.GetByVirtualMachineAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, runCommandName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualMachineRunCommandResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to get the run command.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}/runCommands/{runCommandName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineRunCommands_GetByVirtualMachine</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualMachineRunCommandResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="runCommandName"> The name of the VirtualMachineRunCommand. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runCommandName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runCommandName"/> is null. </exception>
        public virtual Response<VirtualMachineRunCommandResource> Get(string runCommandName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(runCommandName, nameof(runCommandName));

            using var scope = _virtualMachineRunCommandClientDiagnostics.CreateScope("VirtualMachineRunCommandCollection.Get");
            scope.Start();
            try
            {
                var response = _virtualMachineRunCommandRestClient.GetByVirtualMachine(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, runCommandName, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualMachineRunCommandResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to get all run commands of a Virtual Machine.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}/runCommands</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineRunCommands_ListByVirtualMachine</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualMachineRunCommandResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualMachineRunCommandResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualMachineRunCommandResource> GetAllAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _virtualMachineRunCommandRestClient.CreateListByVirtualMachineRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _virtualMachineRunCommandRestClient.CreateListByVirtualMachineNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new VirtualMachineRunCommandResource(Client, VirtualMachineRunCommandData.DeserializeVirtualMachineRunCommandData(e)), _virtualMachineRunCommandClientDiagnostics, Pipeline, "VirtualMachineRunCommandCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// The operation to get all run commands of a Virtual Machine.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}/runCommands</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineRunCommands_ListByVirtualMachine</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualMachineRunCommandResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualMachineRunCommandResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualMachineRunCommandResource> GetAll(string expand = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _virtualMachineRunCommandRestClient.CreateListByVirtualMachineRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _virtualMachineRunCommandRestClient.CreateListByVirtualMachineNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new VirtualMachineRunCommandResource(Client, VirtualMachineRunCommandData.DeserializeVirtualMachineRunCommandData(e)), _virtualMachineRunCommandClientDiagnostics, Pipeline, "VirtualMachineRunCommandCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}/runCommands/{runCommandName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineRunCommands_GetByVirtualMachine</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualMachineRunCommandResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="runCommandName"> The name of the VirtualMachineRunCommand. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runCommandName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runCommandName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string runCommandName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(runCommandName, nameof(runCommandName));

            using var scope = _virtualMachineRunCommandClientDiagnostics.CreateScope("VirtualMachineRunCommandCollection.Exists");
            scope.Start();
            try
            {
                var response = await _virtualMachineRunCommandRestClient.GetByVirtualMachineAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, runCommandName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}/runCommands/{runCommandName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineRunCommands_GetByVirtualMachine</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualMachineRunCommandResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="runCommandName"> The name of the VirtualMachineRunCommand. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runCommandName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runCommandName"/> is null. </exception>
        public virtual Response<bool> Exists(string runCommandName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(runCommandName, nameof(runCommandName));

            using var scope = _virtualMachineRunCommandClientDiagnostics.CreateScope("VirtualMachineRunCommandCollection.Exists");
            scope.Start();
            try
            {
                var response = _virtualMachineRunCommandRestClient.GetByVirtualMachine(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, runCommandName, expand, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}/runCommands/{runCommandName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineRunCommands_GetByVirtualMachine</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualMachineRunCommandResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="runCommandName"> The name of the VirtualMachineRunCommand. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runCommandName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runCommandName"/> is null. </exception>
        public virtual async Task<NullableResponse<VirtualMachineRunCommandResource>> GetIfExistsAsync(string runCommandName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(runCommandName, nameof(runCommandName));

            using var scope = _virtualMachineRunCommandClientDiagnostics.CreateScope("VirtualMachineRunCommandCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _virtualMachineRunCommandRestClient.GetByVirtualMachineAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, runCommandName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<VirtualMachineRunCommandResource>(response.GetRawResponse());
                return Response.FromValue(new VirtualMachineRunCommandResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}/runCommands/{runCommandName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineRunCommands_GetByVirtualMachine</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualMachineRunCommandResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="runCommandName"> The name of the VirtualMachineRunCommand. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runCommandName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runCommandName"/> is null. </exception>
        public virtual NullableResponse<VirtualMachineRunCommandResource> GetIfExists(string runCommandName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(runCommandName, nameof(runCommandName));

            using var scope = _virtualMachineRunCommandClientDiagnostics.CreateScope("VirtualMachineRunCommandCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _virtualMachineRunCommandRestClient.GetByVirtualMachine(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, runCommandName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<VirtualMachineRunCommandResource>(response.GetRawResponse());
                return Response.FromValue(new VirtualMachineRunCommandResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VirtualMachineRunCommandResource> IEnumerable<VirtualMachineRunCommandResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VirtualMachineRunCommandResource> IAsyncEnumerable<VirtualMachineRunCommandResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
