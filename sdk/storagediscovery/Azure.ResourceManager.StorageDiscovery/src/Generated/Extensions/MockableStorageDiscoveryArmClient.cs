// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.StorageDiscovery.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableStorageDiscoveryArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableStorageDiscoveryArmClient"/> class for mocking. </summary>
        protected MockableStorageDiscoveryArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableStorageDiscoveryArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableStorageDiscoveryArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableStorageDiscoveryArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing a <see cref="StorageDiscoveryWorkspaceResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StorageDiscoveryWorkspaceResource.CreateResourceIdentifier" /> to create a <see cref="StorageDiscoveryWorkspaceResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StorageDiscoveryWorkspaceResource"/> object. </returns>
        public virtual StorageDiscoveryWorkspaceResource GetStorageDiscoveryWorkspaceResource(ResourceIdentifier id)
        {
            StorageDiscoveryWorkspaceResource.ValidateResourceId(id);
            return new StorageDiscoveryWorkspaceResource(Client, id);
        }
    }
}
