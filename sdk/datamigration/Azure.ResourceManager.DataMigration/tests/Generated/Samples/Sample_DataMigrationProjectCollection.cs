// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.DataMigration.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.DataMigration.Samples
{
    public partial class Sample_DataMigrationProjectCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_ProjectsCreateOrUpdate()
        {
            // Generated from example definition: specification/datamigration/resource-manager/Microsoft.DataMigration/preview/2025-03-15-preview/examples/Projects_CreateOrUpdate.json
            // this example is just showing the usage of "Projects_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataMigrationServiceResource created on azure
            // for more information of creating DataMigrationServiceResource, please refer to the document of DataMigrationServiceResource
            string subscriptionId = "fc04246f-04c5-437e-ac5e-206a19e7193f";
            string groupName = "DmsSdkRg";
            string serviceName = "DmsSdkService";
            ResourceIdentifier dataMigrationServiceResourceId = DataMigrationServiceResource.CreateResourceIdentifier(subscriptionId, groupName, serviceName);
            DataMigrationServiceResource dataMigrationService = client.GetDataMigrationServiceResource(dataMigrationServiceResourceId);

            // get the collection of this DataMigrationProjectResource
            DataMigrationProjectCollection collection = dataMigrationService.GetDataMigrationProjects();

            // invoke the operation
            string projectName = "DmsSdkProject";
            DataMigrationProjectData data = new DataMigrationProjectData(new AzureLocation("southcentralus"))
            {
                SourcePlatform = DataMigrationProjectSourcePlatform.Sql,
                TargetPlatform = DataMigrationProjectTargetPlatform.SqlDB,
            };
            ArmOperation<DataMigrationProjectResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, projectName, data);
            DataMigrationProjectResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataMigrationProjectData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ProjectsGet()
        {
            // Generated from example definition: specification/datamigration/resource-manager/Microsoft.DataMigration/preview/2025-03-15-preview/examples/Projects_Get.json
            // this example is just showing the usage of "Projects_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataMigrationServiceResource created on azure
            // for more information of creating DataMigrationServiceResource, please refer to the document of DataMigrationServiceResource
            string subscriptionId = "fc04246f-04c5-437e-ac5e-206a19e7193f";
            string groupName = "DmsSdkRg";
            string serviceName = "DmsSdkService";
            ResourceIdentifier dataMigrationServiceResourceId = DataMigrationServiceResource.CreateResourceIdentifier(subscriptionId, groupName, serviceName);
            DataMigrationServiceResource dataMigrationService = client.GetDataMigrationServiceResource(dataMigrationServiceResourceId);

            // get the collection of this DataMigrationProjectResource
            DataMigrationProjectCollection collection = dataMigrationService.GetDataMigrationProjects();

            // invoke the operation
            string projectName = "DmsSdkProject";
            DataMigrationProjectResource result = await collection.GetAsync(projectName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataMigrationProjectData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ProjectsList()
        {
            // Generated from example definition: specification/datamigration/resource-manager/Microsoft.DataMigration/preview/2025-03-15-preview/examples/Projects_List.json
            // this example is just showing the usage of "Projects_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataMigrationServiceResource created on azure
            // for more information of creating DataMigrationServiceResource, please refer to the document of DataMigrationServiceResource
            string subscriptionId = "fc04246f-04c5-437e-ac5e-206a19e7193f";
            string groupName = "DmsSdkRg";
            string serviceName = "DmsSdkService";
            ResourceIdentifier dataMigrationServiceResourceId = DataMigrationServiceResource.CreateResourceIdentifier(subscriptionId, groupName, serviceName);
            DataMigrationServiceResource dataMigrationService = client.GetDataMigrationServiceResource(dataMigrationServiceResourceId);

            // get the collection of this DataMigrationProjectResource
            DataMigrationProjectCollection collection = dataMigrationService.GetDataMigrationProjects();

            // invoke the operation and iterate over the result
            await foreach (DataMigrationProjectResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DataMigrationProjectData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_ProjectsGet()
        {
            // Generated from example definition: specification/datamigration/resource-manager/Microsoft.DataMigration/preview/2025-03-15-preview/examples/Projects_Get.json
            // this example is just showing the usage of "Projects_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataMigrationServiceResource created on azure
            // for more information of creating DataMigrationServiceResource, please refer to the document of DataMigrationServiceResource
            string subscriptionId = "fc04246f-04c5-437e-ac5e-206a19e7193f";
            string groupName = "DmsSdkRg";
            string serviceName = "DmsSdkService";
            ResourceIdentifier dataMigrationServiceResourceId = DataMigrationServiceResource.CreateResourceIdentifier(subscriptionId, groupName, serviceName);
            DataMigrationServiceResource dataMigrationService = client.GetDataMigrationServiceResource(dataMigrationServiceResourceId);

            // get the collection of this DataMigrationProjectResource
            DataMigrationProjectCollection collection = dataMigrationService.GetDataMigrationProjects();

            // invoke the operation
            string projectName = "DmsSdkProject";
            bool result = await collection.ExistsAsync(projectName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_ProjectsGet()
        {
            // Generated from example definition: specification/datamigration/resource-manager/Microsoft.DataMigration/preview/2025-03-15-preview/examples/Projects_Get.json
            // this example is just showing the usage of "Projects_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataMigrationServiceResource created on azure
            // for more information of creating DataMigrationServiceResource, please refer to the document of DataMigrationServiceResource
            string subscriptionId = "fc04246f-04c5-437e-ac5e-206a19e7193f";
            string groupName = "DmsSdkRg";
            string serviceName = "DmsSdkService";
            ResourceIdentifier dataMigrationServiceResourceId = DataMigrationServiceResource.CreateResourceIdentifier(subscriptionId, groupName, serviceName);
            DataMigrationServiceResource dataMigrationService = client.GetDataMigrationServiceResource(dataMigrationServiceResourceId);

            // get the collection of this DataMigrationProjectResource
            DataMigrationProjectCollection collection = dataMigrationService.GetDataMigrationProjects();

            // invoke the operation
            string projectName = "DmsSdkProject";
            NullableResponse<DataMigrationProjectResource> response = await collection.GetIfExistsAsync(projectName);
            DataMigrationProjectResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DataMigrationProjectData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
