// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.OperationalInsights.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableOperationalInsightsArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableOperationalInsightsArmClient"/> class for mocking. </summary>
        protected MockableOperationalInsightsArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableOperationalInsightsArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableOperationalInsightsArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableOperationalInsightsArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing an <see cref="OperationalInsightsClusterResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="OperationalInsightsClusterResource.CreateResourceIdentifier" /> to create an <see cref="OperationalInsightsClusterResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="OperationalInsightsClusterResource"/> object. </returns>
        public virtual OperationalInsightsClusterResource GetOperationalInsightsClusterResource(ResourceIdentifier id)
        {
            OperationalInsightsClusterResource.ValidateResourceId(id);
            return new OperationalInsightsClusterResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="OperationalInsightsDataExportResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="OperationalInsightsDataExportResource.CreateResourceIdentifier" /> to create an <see cref="OperationalInsightsDataExportResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="OperationalInsightsDataExportResource"/> object. </returns>
        public virtual OperationalInsightsDataExportResource GetOperationalInsightsDataExportResource(ResourceIdentifier id)
        {
            OperationalInsightsDataExportResource.ValidateResourceId(id);
            return new OperationalInsightsDataExportResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="OperationalInsightsDataSourceResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="OperationalInsightsDataSourceResource.CreateResourceIdentifier" /> to create an <see cref="OperationalInsightsDataSourceResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="OperationalInsightsDataSourceResource"/> object. </returns>
        public virtual OperationalInsightsDataSourceResource GetOperationalInsightsDataSourceResource(ResourceIdentifier id)
        {
            OperationalInsightsDataSourceResource.ValidateResourceId(id);
            return new OperationalInsightsDataSourceResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="OperationalInsightsLinkedServiceResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="OperationalInsightsLinkedServiceResource.CreateResourceIdentifier" /> to create an <see cref="OperationalInsightsLinkedServiceResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="OperationalInsightsLinkedServiceResource"/> object. </returns>
        public virtual OperationalInsightsLinkedServiceResource GetOperationalInsightsLinkedServiceResource(ResourceIdentifier id)
        {
            OperationalInsightsLinkedServiceResource.ValidateResourceId(id);
            return new OperationalInsightsLinkedServiceResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="OperationalInsightsLinkedStorageAccountsResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="OperationalInsightsLinkedStorageAccountsResource.CreateResourceIdentifier" /> to create an <see cref="OperationalInsightsLinkedStorageAccountsResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="OperationalInsightsLinkedStorageAccountsResource"/> object. </returns>
        public virtual OperationalInsightsLinkedStorageAccountsResource GetOperationalInsightsLinkedStorageAccountsResource(ResourceIdentifier id)
        {
            OperationalInsightsLinkedStorageAccountsResource.ValidateResourceId(id);
            return new OperationalInsightsLinkedStorageAccountsResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="LogAnalyticsQueryResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="LogAnalyticsQueryResource.CreateResourceIdentifier" /> to create a <see cref="LogAnalyticsQueryResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="LogAnalyticsQueryResource"/> object. </returns>
        public virtual LogAnalyticsQueryResource GetLogAnalyticsQueryResource(ResourceIdentifier id)
        {
            LogAnalyticsQueryResource.ValidateResourceId(id);
            return new LogAnalyticsQueryResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="LogAnalyticsQueryPackResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="LogAnalyticsQueryPackResource.CreateResourceIdentifier" /> to create a <see cref="LogAnalyticsQueryPackResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="LogAnalyticsQueryPackResource"/> object. </returns>
        public virtual LogAnalyticsQueryPackResource GetLogAnalyticsQueryPackResource(ResourceIdentifier id)
        {
            LogAnalyticsQueryPackResource.ValidateResourceId(id);
            return new LogAnalyticsQueryPackResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="OperationalInsightsSavedSearchResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="OperationalInsightsSavedSearchResource.CreateResourceIdentifier" /> to create an <see cref="OperationalInsightsSavedSearchResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="OperationalInsightsSavedSearchResource"/> object. </returns>
        public virtual OperationalInsightsSavedSearchResource GetOperationalInsightsSavedSearchResource(ResourceIdentifier id)
        {
            OperationalInsightsSavedSearchResource.ValidateResourceId(id);
            return new OperationalInsightsSavedSearchResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="StorageInsightResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StorageInsightResource.CreateResourceIdentifier" /> to create a <see cref="StorageInsightResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StorageInsightResource"/> object. </returns>
        public virtual StorageInsightResource GetStorageInsightResource(ResourceIdentifier id)
        {
            StorageInsightResource.ValidateResourceId(id);
            return new StorageInsightResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="OperationalInsightsTableResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="OperationalInsightsTableResource.CreateResourceIdentifier" /> to create an <see cref="OperationalInsightsTableResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="OperationalInsightsTableResource"/> object. </returns>
        public virtual OperationalInsightsTableResource GetOperationalInsightsTableResource(ResourceIdentifier id)
        {
            OperationalInsightsTableResource.ValidateResourceId(id);
            return new OperationalInsightsTableResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="OperationalInsightsWorkspaceResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="OperationalInsightsWorkspaceResource.CreateResourceIdentifier" /> to create an <see cref="OperationalInsightsWorkspaceResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="OperationalInsightsWorkspaceResource"/> object. </returns>
        public virtual OperationalInsightsWorkspaceResource GetOperationalInsightsWorkspaceResource(ResourceIdentifier id)
        {
            OperationalInsightsWorkspaceResource.ValidateResourceId(id);
            return new OperationalInsightsWorkspaceResource(Client, id);
        }
    }
}
