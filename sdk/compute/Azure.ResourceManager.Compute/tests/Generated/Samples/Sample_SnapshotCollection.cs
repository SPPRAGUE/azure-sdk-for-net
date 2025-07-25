// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.Compute.Samples
{
    public partial class Sample_SnapshotCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateASnapshotByImportingAnUnmanagedBlobFromADifferentSubscription()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/DiskRP/stable/2025-01-02/examples/snapshotExamples/Snapshot_Create_ByImportingAnUnmanagedBlobFromADifferentSubscription.json
            // this example is just showing the usage of "Snapshots_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this SnapshotResource
            SnapshotCollection collection = resourceGroupResource.GetSnapshots();

            // invoke the operation
            string snapshotName = "mySnapshot1";
            SnapshotData data = new SnapshotData(new AzureLocation("West US"))
            {
                CreationData = new DiskCreationData(DiskCreateOption.Import)
                {
                    StorageAccountId = new ResourceIdentifier("subscriptions/{subscription-id}/resourceGroups/myResourceGroup/providers/Microsoft.Storage/storageAccounts/myStorageAccount"),
                    SourceUri = new Uri("https://mystorageaccount.blob.core.windows.net/osimages/osimage.vhd"),
                },
            };
            ArmOperation<SnapshotResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, snapshotName, data);
            SnapshotResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SnapshotData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateASnapshotByImportingAnUnmanagedBlobFromTheSameSubscription()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/DiskRP/stable/2025-01-02/examples/snapshotExamples/Snapshot_Create_ByImportingAnUnmanagedBlobFromTheSameSubscription.json
            // this example is just showing the usage of "Snapshots_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this SnapshotResource
            SnapshotCollection collection = resourceGroupResource.GetSnapshots();

            // invoke the operation
            string snapshotName = "mySnapshot1";
            SnapshotData data = new SnapshotData(new AzureLocation("West US"))
            {
                CreationData = new DiskCreationData(DiskCreateOption.Import)
                {
                    SourceUri = new Uri("https://mystorageaccount.blob.core.windows.net/osimages/osimage.vhd"),
                },
            };
            ArmOperation<SnapshotResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, snapshotName, data);
            SnapshotResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SnapshotData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateASnapshotFromAnElasticSanVolumeSnapshot()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/DiskRP/stable/2025-01-02/examples/snapshotExamples/Snapshot_Create_FromAnElasticSanVolumeSnapshot.json
            // this example is just showing the usage of "Snapshots_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this SnapshotResource
            SnapshotCollection collection = resourceGroupResource.GetSnapshots();

            // invoke the operation
            string snapshotName = "mySnapshot";
            SnapshotData data = new SnapshotData(new AzureLocation("West US"))
            {
                CreationData = new DiskCreationData(DiskCreateOption.CopyFromSanSnapshot)
                {
                    ElasticSanResourceId = new ResourceIdentifier("subscriptions/{subscription-id}/resourceGroups/myResourceGroup/providers/Microsoft.ElasticSan/elasticSans/myElasticSan/volumegroups/myElasticSanVolumeGroup/snapshots/myElasticSanVolumeSnapshot"),
                },
            };
            ArmOperation<SnapshotResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, snapshotName, data);
            SnapshotResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SnapshotData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateASnapshotFromAnExistingSnapshotInTheSameOrADifferentSubscriptionInADifferentRegionWithQuickerCopySpeed()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/DiskRP/stable/2025-01-02/examples/snapshotExamples/Snapshot_Create_EnhancedProvisionedBandwidthCopySpeed.json
            // this example is just showing the usage of "Snapshots_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this SnapshotResource
            SnapshotCollection collection = resourceGroupResource.GetSnapshots();

            // invoke the operation
            string snapshotName = "mySnapshot2";
            SnapshotData data = new SnapshotData(new AzureLocation("West US"))
            {
                CreationData = new DiskCreationData(DiskCreateOption.CopyStart)
                {
                    SourceResourceId = new ResourceIdentifier("subscriptions/{subscription-id}/resourceGroups/myResourceGroup/providers/Microsoft.Compute/snapshots/mySnapshot1"),
                    ProvisionedBandwidthCopySpeed = ProvisionedBandwidthCopyOption.Enhanced,
                },
            };
            ArmOperation<SnapshotResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, snapshotName, data);
            SnapshotResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SnapshotData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateASnapshotFromAnExistingSnapshotInTheSameOrADifferentSubscriptionInADifferentRegion()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/DiskRP/stable/2025-01-02/examples/snapshotExamples/Snapshot_Create_FromAnExistingSnapshotInDifferentRegion.json
            // this example is just showing the usage of "Snapshots_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this SnapshotResource
            SnapshotCollection collection = resourceGroupResource.GetSnapshots();

            // invoke the operation
            string snapshotName = "mySnapshot2";
            SnapshotData data = new SnapshotData(new AzureLocation("West US"))
            {
                CreationData = new DiskCreationData(DiskCreateOption.CopyStart)
                {
                    SourceResourceId = new ResourceIdentifier("subscriptions/{subscription-id}/resourceGroups/myResourceGroup/providers/Microsoft.Compute/snapshots/mySnapshot1"),
                },
            };
            ArmOperation<SnapshotResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, snapshotName, data);
            SnapshotResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SnapshotData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateASnapshotFromAnExistingSnapshotInTheSameOrADifferentSubscription()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/DiskRP/stable/2025-01-02/examples/snapshotExamples/Snapshot_Create_FromAnExistingSnapshot.json
            // this example is just showing the usage of "Snapshots_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this SnapshotResource
            SnapshotCollection collection = resourceGroupResource.GetSnapshots();

            // invoke the operation
            string snapshotName = "mySnapshot2";
            SnapshotData data = new SnapshotData(new AzureLocation("West US"))
            {
                CreationData = new DiskCreationData(DiskCreateOption.Copy)
                {
                    SourceResourceId = new ResourceIdentifier("subscriptions/{subscription-id}/resourceGroups/myResourceGroup/providers/Microsoft.Compute/snapshots/mySnapshot1"),
                },
            };
            ArmOperation<SnapshotResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, snapshotName, data);
            SnapshotResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SnapshotData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateASnapshotWhichCanBeInstantlyAccessable()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/DiskRP/stable/2025-01-02/examples/snapshotExamples/Snapshot_Create_InstantAccessSnapshot.json
            // this example is just showing the usage of "Snapshots_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this SnapshotResource
            SnapshotCollection collection = resourceGroupResource.GetSnapshots();

            // invoke the operation
            string snapshotName = "mySnapshot2";
            SnapshotData data = new SnapshotData(new AzureLocation("West US"))
            {
                CreationData = new DiskCreationData(DiskCreateOption.Copy)
                {
                    SourceResourceId = new ResourceIdentifier("subscriptions/{subscription-id}/resourceGroups/myResourceGroup/providers/Microsoft.Compute/disks/myDisk1"),
                    InstantAccessDurationMinutes = 120L,
                },
            };
            ArmOperation<SnapshotResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, snapshotName, data);
            SnapshotResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SnapshotData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetInformationAboutASnapshot()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/DiskRP/stable/2025-01-02/examples/snapshotExamples/Snapshot_Get.json
            // this example is just showing the usage of "Snapshots_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this SnapshotResource
            SnapshotCollection collection = resourceGroupResource.GetSnapshots();

            // invoke the operation
            string snapshotName = "mySnapshot";
            SnapshotResource result = await collection.GetAsync(snapshotName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SnapshotData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetInformationAboutAnIncrementalSnapshot()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/DiskRP/stable/2025-01-02/examples/snapshotExamples/Snapshot_GetIncrementalSnapshot.json
            // this example is just showing the usage of "Snapshots_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this SnapshotResource
            SnapshotCollection collection = resourceGroupResource.GetSnapshots();

            // invoke the operation
            string snapshotName = "myIncrementalSnapshot";
            SnapshotResource result = await collection.GetAsync(snapshotName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SnapshotData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListAllSnapshotsInAResourceGroup()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/DiskRP/stable/2025-01-02/examples/snapshotExamples/Snapshot_ListByResourceGroup.json
            // this example is just showing the usage of "Snapshots_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this SnapshotResource
            SnapshotCollection collection = resourceGroupResource.GetSnapshots();

            // invoke the operation and iterate over the result
            await foreach (SnapshotResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SnapshotData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetInformationAboutASnapshot()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/DiskRP/stable/2025-01-02/examples/snapshotExamples/Snapshot_Get.json
            // this example is just showing the usage of "Snapshots_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this SnapshotResource
            SnapshotCollection collection = resourceGroupResource.GetSnapshots();

            // invoke the operation
            string snapshotName = "mySnapshot";
            bool result = await collection.ExistsAsync(snapshotName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetInformationAboutAnIncrementalSnapshot()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/DiskRP/stable/2025-01-02/examples/snapshotExamples/Snapshot_GetIncrementalSnapshot.json
            // this example is just showing the usage of "Snapshots_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this SnapshotResource
            SnapshotCollection collection = resourceGroupResource.GetSnapshots();

            // invoke the operation
            string snapshotName = "myIncrementalSnapshot";
            bool result = await collection.ExistsAsync(snapshotName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetInformationAboutASnapshot()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/DiskRP/stable/2025-01-02/examples/snapshotExamples/Snapshot_Get.json
            // this example is just showing the usage of "Snapshots_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this SnapshotResource
            SnapshotCollection collection = resourceGroupResource.GetSnapshots();

            // invoke the operation
            string snapshotName = "mySnapshot";
            NullableResponse<SnapshotResource> response = await collection.GetIfExistsAsync(snapshotName);
            SnapshotResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SnapshotData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetInformationAboutAnIncrementalSnapshot()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/DiskRP/stable/2025-01-02/examples/snapshotExamples/Snapshot_GetIncrementalSnapshot.json
            // this example is just showing the usage of "Snapshots_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this SnapshotResource
            SnapshotCollection collection = resourceGroupResource.GetSnapshots();

            // invoke the operation
            string snapshotName = "myIncrementalSnapshot";
            NullableResponse<SnapshotResource> response = await collection.GetIfExistsAsync(snapshotName);
            SnapshotResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SnapshotData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
