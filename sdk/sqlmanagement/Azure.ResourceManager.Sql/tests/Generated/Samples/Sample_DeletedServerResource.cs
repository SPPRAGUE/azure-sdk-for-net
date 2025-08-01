// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.Sql.Samples
{
    public partial class Sample_DeletedServerResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetDeletedServer()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2024-11-01-preview/examples/DeletedServerGet.json
            // this example is just showing the usage of "DeletedServers_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DeletedServerResource created on azure
            // for more information of creating DeletedServerResource, please refer to the document of DeletedServerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            AzureLocation locationName = new AzureLocation("japaneast");
            string deletedServerName = "sqlcrudtest-d-1414";
            ResourceIdentifier deletedServerResourceId = DeletedServerResource.CreateResourceIdentifier(subscriptionId, locationName, deletedServerName);
            DeletedServerResource deletedServer = client.GetDeletedServerResource(deletedServerResourceId);

            // invoke the operation
            DeletedServerResource result = await deletedServer.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DeletedServerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Recover_RecoverDeletedServer()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2024-11-01-preview/examples/DeletedServerRecover.json
            // this example is just showing the usage of "DeletedServers_Recover" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DeletedServerResource created on azure
            // for more information of creating DeletedServerResource, please refer to the document of DeletedServerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            AzureLocation locationName = new AzureLocation("japaneast");
            string deletedServerName = "sqlcrudtest-d-1414";
            ResourceIdentifier deletedServerResourceId = DeletedServerResource.CreateResourceIdentifier(subscriptionId, locationName, deletedServerName);
            DeletedServerResource deletedServer = client.GetDeletedServerResource(deletedServerResourceId);

            // invoke the operation
            ArmOperation<DeletedServerResource> lro = await deletedServer.RecoverAsync(WaitUntil.Completed);
            DeletedServerResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DeletedServerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
