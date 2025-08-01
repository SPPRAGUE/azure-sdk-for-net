// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.OracleDatabase.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.OracleDatabase.Samples
{
    public partial class Sample_ExascaleDBStorageVaultResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ExascaleDbStorageVaultsGetMaximumSet()
        {
            // Generated from example definition: 2025-03-01/ExascaleDbStorageVaults_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "ExascaleDbStorageVault_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ExascaleDBStorageVaultResource created on azure
            // for more information of creating ExascaleDBStorageVaultResource, please refer to the document of ExascaleDBStorageVaultResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rgopenapi";
            string exascaleDbStorageVaultName = "vmClusterName";
            ResourceIdentifier exascaleDBStorageVaultResourceId = ExascaleDBStorageVaultResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, exascaleDbStorageVaultName);
            ExascaleDBStorageVaultResource exascaleDBStorageVault = client.GetExascaleDBStorageVaultResource(exascaleDBStorageVaultResourceId);

            // invoke the operation
            ExascaleDBStorageVaultResource result = await exascaleDBStorageVault.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ExascaleDBStorageVaultData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_ExascaleDbStorageVaultsDeleteMaximumSet()
        {
            // Generated from example definition: 2025-03-01/ExascaleDbStorageVaults_Delete_MaximumSet_Gen.json
            // this example is just showing the usage of "ExascaleDbStorageVault_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ExascaleDBStorageVaultResource created on azure
            // for more information of creating ExascaleDBStorageVaultResource, please refer to the document of ExascaleDBStorageVaultResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rgopenapi";
            string exascaleDbStorageVaultName = "vmClusterName";
            ResourceIdentifier exascaleDBStorageVaultResourceId = ExascaleDBStorageVaultResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, exascaleDbStorageVaultName);
            ExascaleDBStorageVaultResource exascaleDBStorageVault = client.GetExascaleDBStorageVaultResource(exascaleDBStorageVaultResourceId);

            // invoke the operation
            await exascaleDBStorageVault.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_ExascaleDbStorageVaultsUpdateMaximumSet()
        {
            // Generated from example definition: 2025-03-01/ExascaleDbStorageVaults_Update_MaximumSet_Gen.json
            // this example is just showing the usage of "ExascaleDbStorageVault_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ExascaleDBStorageVaultResource created on azure
            // for more information of creating ExascaleDBStorageVaultResource, please refer to the document of ExascaleDBStorageVaultResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rgopenapi";
            string exascaleDbStorageVaultName = "vmClusterName";
            ResourceIdentifier exascaleDBStorageVaultResourceId = ExascaleDBStorageVaultResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, exascaleDbStorageVaultName);
            ExascaleDBStorageVaultResource exascaleDBStorageVault = client.GetExascaleDBStorageVaultResource(exascaleDBStorageVaultResourceId);

            // invoke the operation
            ExascaleDBStorageVaultPatch patch = new ExascaleDBStorageVaultPatch
            {
                Tags =
{
["key6179"] = "ouj"
},
            };
            ArmOperation<ExascaleDBStorageVaultResource> lro = await exascaleDBStorageVault.UpdateAsync(WaitUntil.Completed, patch);
            ExascaleDBStorageVaultResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ExascaleDBStorageVaultData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
