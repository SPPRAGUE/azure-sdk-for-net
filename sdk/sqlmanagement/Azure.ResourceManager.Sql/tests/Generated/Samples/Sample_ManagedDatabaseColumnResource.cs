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
    public partial class Sample_ManagedDatabaseColumnResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetManagedDatabaseColumn()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2024-11-01-preview/examples/ManagedDatabaseColumnGet.json
            // this example is just showing the usage of "ManagedDatabaseColumns_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedDatabaseColumnResource created on azure
            // for more information of creating ManagedDatabaseColumnResource, please refer to the document of ManagedDatabaseColumnResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "myRG";
            string managedInstanceName = "myManagedInstanceName";
            string databaseName = "myDatabase";
            string schemaName = "dbo";
            string tableName = "table1";
            string columnName = "column1";
            ResourceIdentifier managedDatabaseColumnResourceId = ManagedDatabaseColumnResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, managedInstanceName, databaseName, schemaName, tableName, columnName);
            ManagedDatabaseColumnResource managedDatabaseColumn = client.GetManagedDatabaseColumnResource(managedDatabaseColumnResourceId);

            // invoke the operation
            ManagedDatabaseColumnResource result = await managedDatabaseColumn.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DatabaseColumnData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task DisableRecommendationManagedDatabaseSensitivityLabel_DisablesTheSensitivityRecommendationsOnAGivenColumn()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2024-11-01-preview/examples/ManagedDatabaseRecommendedColumnSensitivityLabelDisable.json
            // this example is just showing the usage of "ManagedDatabaseSensitivityLabels_DisableRecommendation" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedDatabaseColumnResource created on azure
            // for more information of creating ManagedDatabaseColumnResource, please refer to the document of ManagedDatabaseColumnResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "myRG";
            string managedInstanceName = "myManagedInstanceName";
            string databaseName = "myDatabase";
            string schemaName = "dbo";
            string tableName = "myTable";
            string columnName = "myColumn";
            ResourceIdentifier managedDatabaseColumnResourceId = ManagedDatabaseColumnResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, managedInstanceName, databaseName, schemaName, tableName, columnName);
            ManagedDatabaseColumnResource managedDatabaseColumn = client.GetManagedDatabaseColumnResource(managedDatabaseColumnResourceId);

            // invoke the operation
            await managedDatabaseColumn.DisableRecommendationManagedDatabaseSensitivityLabelAsync();

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task EnableRecommendationManagedDatabaseSensitivityLabel_EnablesTheSensitivityRecommendationsOnAGivenColumn()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2024-11-01-preview/examples/ManagedDatabaseRecommendedColumnSensitivityLabelEnable.json
            // this example is just showing the usage of "ManagedDatabaseSensitivityLabels_EnableRecommendation" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedDatabaseColumnResource created on azure
            // for more information of creating ManagedDatabaseColumnResource, please refer to the document of ManagedDatabaseColumnResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "myRG";
            string managedInstanceName = "myManagedInstanceName";
            string databaseName = "myDatabase";
            string schemaName = "dbo";
            string tableName = "myTable";
            string columnName = "myColumn";
            ResourceIdentifier managedDatabaseColumnResourceId = ManagedDatabaseColumnResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, managedInstanceName, databaseName, schemaName, tableName, columnName);
            ManagedDatabaseColumnResource managedDatabaseColumn = client.GetManagedDatabaseColumnResource(managedDatabaseColumnResourceId);

            // invoke the operation
            await managedDatabaseColumn.EnableRecommendationManagedDatabaseSensitivityLabelAsync();

            Console.WriteLine("Succeeded");
        }
    }
}
