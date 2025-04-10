// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.HybridConnectivity.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.HybridConnectivity.Samples
{
    public partial class Sample_PublicCloudConnectorSolutionConfigurationResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_SolutionConfigurationsGet()
        {
            // Generated from example definition: 2024-12-01/SolutionConfigurations_Get.json
            // this example is just showing the usage of "SolutionConfiguration_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PublicCloudConnectorSolutionConfigurationResource created on azure
            // for more information of creating PublicCloudConnectorSolutionConfigurationResource, please refer to the document of PublicCloudConnectorSolutionConfigurationResource
            string resourceUri = "ymuj";
            string solutionConfiguration = "tks";
            ResourceIdentifier publicCloudConnectorSolutionConfigurationResourceId = PublicCloudConnectorSolutionConfigurationResource.CreateResourceIdentifier(resourceUri, solutionConfiguration);
            PublicCloudConnectorSolutionConfigurationResource publicCloudConnectorSolutionConfiguration = client.GetPublicCloudConnectorSolutionConfigurationResource(publicCloudConnectorSolutionConfigurationResourceId);

            // invoke the operation
            PublicCloudConnectorSolutionConfigurationResource result = await publicCloudConnectorSolutionConfiguration.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PublicCloudConnectorSolutionConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_SolutionConfigurationsDelete()
        {
            // Generated from example definition: 2024-12-01/SolutionConfigurations_Delete.json
            // this example is just showing the usage of "SolutionConfiguration_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PublicCloudConnectorSolutionConfigurationResource created on azure
            // for more information of creating PublicCloudConnectorSolutionConfigurationResource, please refer to the document of PublicCloudConnectorSolutionConfigurationResource
            string resourceUri = "ymuj";
            string solutionConfiguration = "stu";
            ResourceIdentifier publicCloudConnectorSolutionConfigurationResourceId = PublicCloudConnectorSolutionConfigurationResource.CreateResourceIdentifier(resourceUri, solutionConfiguration);
            PublicCloudConnectorSolutionConfigurationResource publicCloudConnectorSolutionConfiguration = client.GetPublicCloudConnectorSolutionConfigurationResource(publicCloudConnectorSolutionConfigurationResourceId);

            // invoke the operation
            await publicCloudConnectorSolutionConfiguration.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_SolutionConfigurationsUpdate()
        {
            // Generated from example definition: 2024-12-01/SolutionConfigurations_Update.json
            // this example is just showing the usage of "SolutionConfiguration_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PublicCloudConnectorSolutionConfigurationResource created on azure
            // for more information of creating PublicCloudConnectorSolutionConfigurationResource, please refer to the document of PublicCloudConnectorSolutionConfigurationResource
            string resourceUri = "ymuj";
            string solutionConfiguration = "dxt";
            ResourceIdentifier publicCloudConnectorSolutionConfigurationResourceId = PublicCloudConnectorSolutionConfigurationResource.CreateResourceIdentifier(resourceUri, solutionConfiguration);
            PublicCloudConnectorSolutionConfigurationResource publicCloudConnectorSolutionConfiguration = client.GetPublicCloudConnectorSolutionConfigurationResource(publicCloudConnectorSolutionConfigurationResourceId);

            // invoke the operation
            PublicCloudConnectorSolutionConfigurationPatch patch = new PublicCloudConnectorSolutionConfigurationPatch
            {
                Properties = new SolutionConfigurationPropertiesUpdate
                {
                    SolutionType = "myzljlstvmgkp",
                    SolutionSettings = new PublicCloudConnectorSolutionSettings(),
                },
            };
            PublicCloudConnectorSolutionConfigurationResource result = await publicCloudConnectorSolutionConfiguration.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PublicCloudConnectorSolutionConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task SyncNow_SolutionConfigurationsSyncNow()
        {
            // Generated from example definition: 2024-12-01/SolutionConfigurations_SyncNow.json
            // this example is just showing the usage of "SolutionConfigurations_SyncNow" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PublicCloudConnectorSolutionConfigurationResource created on azure
            // for more information of creating PublicCloudConnectorSolutionConfigurationResource, please refer to the document of PublicCloudConnectorSolutionConfigurationResource
            string resourceUri = "ymuj";
            string solutionConfiguration = "tks";
            ResourceIdentifier publicCloudConnectorSolutionConfigurationResourceId = PublicCloudConnectorSolutionConfigurationResource.CreateResourceIdentifier(resourceUri, solutionConfiguration);
            PublicCloudConnectorSolutionConfigurationResource publicCloudConnectorSolutionConfiguration = client.GetPublicCloudConnectorSolutionConfigurationResource(publicCloudConnectorSolutionConfigurationResourceId);

            // invoke the operation
            ArmOperation<HybridConnectivityOperationStatus> lro = await publicCloudConnectorSolutionConfiguration.SyncNowAsync(WaitUntil.Completed);
            HybridConnectivityOperationStatus result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
