// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.Billing.Samples
{
    public partial class Sample_BillingProfileRoleDefinitionCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_BillingRoleDefinitionGetByBillingProfile()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/billingRoleDefinitionGetByBillingProfile.json
            // this example is just showing the usage of "BillingRoleDefinition_GetByBillingProfile" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingProfileResource created on azure
            // for more information of creating BillingProfileResource, please refer to the document of BillingProfileResource
            string billingAccountName = "10000000-0000-0000-0000-000000000000:00000000-0000-0000-0000-000000000000_2019-05-31";
            string billingProfileName = "xxxx-xxxx-xxx-xxx";
            ResourceIdentifier billingProfileResourceId = BillingProfileResource.CreateResourceIdentifier(billingAccountName, billingProfileName);
            BillingProfileResource billingProfile = client.GetBillingProfileResource(billingProfileResourceId);

            // get the collection of this BillingProfileRoleDefinitionResource
            BillingProfileRoleDefinitionCollection collection = billingProfile.GetBillingProfileRoleDefinitions();

            // invoke the operation
            string roleDefinitionName = "40000000-aaaa-bbbb-cccc-100000000000";
            BillingProfileRoleDefinitionResource result = await collection.GetAsync(roleDefinitionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BillingRoleDefinitionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_BillingRoleDefinitionListByBillingProfile()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/billingRoleDefinitionListByBillingProfile.json
            // this example is just showing the usage of "BillingRoleDefinition_ListByBillingProfile" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingProfileResource created on azure
            // for more information of creating BillingProfileResource, please refer to the document of BillingProfileResource
            string billingAccountName = "10000000-0000-0000-0000-000000000000:00000000-0000-0000-0000-000000000000_2019-05-31";
            string billingProfileName = "xxxx-xxxx-xxx-xxx";
            ResourceIdentifier billingProfileResourceId = BillingProfileResource.CreateResourceIdentifier(billingAccountName, billingProfileName);
            BillingProfileResource billingProfile = client.GetBillingProfileResource(billingProfileResourceId);

            // get the collection of this BillingProfileRoleDefinitionResource
            BillingProfileRoleDefinitionCollection collection = billingProfile.GetBillingProfileRoleDefinitions();

            // invoke the operation and iterate over the result
            await foreach (BillingProfileRoleDefinitionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                BillingRoleDefinitionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_BillingRoleDefinitionGetByBillingProfile()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/billingRoleDefinitionGetByBillingProfile.json
            // this example is just showing the usage of "BillingRoleDefinition_GetByBillingProfile" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingProfileResource created on azure
            // for more information of creating BillingProfileResource, please refer to the document of BillingProfileResource
            string billingAccountName = "10000000-0000-0000-0000-000000000000:00000000-0000-0000-0000-000000000000_2019-05-31";
            string billingProfileName = "xxxx-xxxx-xxx-xxx";
            ResourceIdentifier billingProfileResourceId = BillingProfileResource.CreateResourceIdentifier(billingAccountName, billingProfileName);
            BillingProfileResource billingProfile = client.GetBillingProfileResource(billingProfileResourceId);

            // get the collection of this BillingProfileRoleDefinitionResource
            BillingProfileRoleDefinitionCollection collection = billingProfile.GetBillingProfileRoleDefinitions();

            // invoke the operation
            string roleDefinitionName = "40000000-aaaa-bbbb-cccc-100000000000";
            bool result = await collection.ExistsAsync(roleDefinitionName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_BillingRoleDefinitionGetByBillingProfile()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/billingRoleDefinitionGetByBillingProfile.json
            // this example is just showing the usage of "BillingRoleDefinition_GetByBillingProfile" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingProfileResource created on azure
            // for more information of creating BillingProfileResource, please refer to the document of BillingProfileResource
            string billingAccountName = "10000000-0000-0000-0000-000000000000:00000000-0000-0000-0000-000000000000_2019-05-31";
            string billingProfileName = "xxxx-xxxx-xxx-xxx";
            ResourceIdentifier billingProfileResourceId = BillingProfileResource.CreateResourceIdentifier(billingAccountName, billingProfileName);
            BillingProfileResource billingProfile = client.GetBillingProfileResource(billingProfileResourceId);

            // get the collection of this BillingProfileRoleDefinitionResource
            BillingProfileRoleDefinitionCollection collection = billingProfile.GetBillingProfileRoleDefinitions();

            // invoke the operation
            string roleDefinitionName = "40000000-aaaa-bbbb-cccc-100000000000";
            NullableResponse<BillingProfileRoleDefinitionResource> response = await collection.GetIfExistsAsync(roleDefinitionName);
            BillingProfileRoleDefinitionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                BillingRoleDefinitionData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
