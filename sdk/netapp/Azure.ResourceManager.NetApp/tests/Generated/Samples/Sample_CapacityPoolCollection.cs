// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.NetApp.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.NetApp.Samples
{
    public partial class Sample_CapacityPoolCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_PoolsCreateOrUpdate()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2025-03-01/examples/Pools_CreateOrUpdate.json
            // this example is just showing the usage of "Pools_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetAppAccountResource created on azure
            // for more information of creating NetAppAccountResource, please refer to the document of NetAppAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myRG";
            string accountName = "account1";
            ResourceIdentifier netAppAccountResourceId = NetAppAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            NetAppAccountResource netAppAccount = client.GetNetAppAccountResource(netAppAccountResourceId);

            // get the collection of this CapacityPoolResource
            CapacityPoolCollection collection = netAppAccount.GetCapacityPools();

            // invoke the operation
            string poolName = "pool1";
            CapacityPoolData data = new CapacityPoolData(new AzureLocation("eastus"), 4398046511104L, NetAppFileServiceLevel.Premium)
            {
                QosType = CapacityPoolQosType.Auto,
            };
            ArmOperation<CapacityPoolResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, poolName, data);
            CapacityPoolResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CapacityPoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_PoolsGet()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2025-03-01/examples/Pools_Get.json
            // this example is just showing the usage of "Pools_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetAppAccountResource created on azure
            // for more information of creating NetAppAccountResource, please refer to the document of NetAppAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myRG";
            string accountName = "account1";
            ResourceIdentifier netAppAccountResourceId = NetAppAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            NetAppAccountResource netAppAccount = client.GetNetAppAccountResource(netAppAccountResourceId);

            // get the collection of this CapacityPoolResource
            CapacityPoolCollection collection = netAppAccount.GetCapacityPools();

            // invoke the operation
            string poolName = "pool1";
            CapacityPoolResource result = await collection.GetAsync(poolName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CapacityPoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_PoolsList()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2025-03-01/examples/Pools_List.json
            // this example is just showing the usage of "Pools_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetAppAccountResource created on azure
            // for more information of creating NetAppAccountResource, please refer to the document of NetAppAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myRG";
            string accountName = "account1";
            ResourceIdentifier netAppAccountResourceId = NetAppAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            NetAppAccountResource netAppAccount = client.GetNetAppAccountResource(netAppAccountResourceId);

            // get the collection of this CapacityPoolResource
            CapacityPoolCollection collection = netAppAccount.GetCapacityPools();

            // invoke the operation and iterate over the result
            await foreach (CapacityPoolResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                CapacityPoolData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_PoolsGet()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2025-03-01/examples/Pools_Get.json
            // this example is just showing the usage of "Pools_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetAppAccountResource created on azure
            // for more information of creating NetAppAccountResource, please refer to the document of NetAppAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myRG";
            string accountName = "account1";
            ResourceIdentifier netAppAccountResourceId = NetAppAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            NetAppAccountResource netAppAccount = client.GetNetAppAccountResource(netAppAccountResourceId);

            // get the collection of this CapacityPoolResource
            CapacityPoolCollection collection = netAppAccount.GetCapacityPools();

            // invoke the operation
            string poolName = "pool1";
            bool result = await collection.ExistsAsync(poolName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_PoolsGet()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2025-03-01/examples/Pools_Get.json
            // this example is just showing the usage of "Pools_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetAppAccountResource created on azure
            // for more information of creating NetAppAccountResource, please refer to the document of NetAppAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myRG";
            string accountName = "account1";
            ResourceIdentifier netAppAccountResourceId = NetAppAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            NetAppAccountResource netAppAccount = client.GetNetAppAccountResource(netAppAccountResourceId);

            // get the collection of this CapacityPoolResource
            CapacityPoolCollection collection = netAppAccount.GetCapacityPools();

            // invoke the operation
            string poolName = "pool1";
            NullableResponse<CapacityPoolResource> response = await collection.GetIfExistsAsync(poolName);
            CapacityPoolResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                CapacityPoolData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
