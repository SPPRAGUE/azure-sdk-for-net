# Creating a Project in Azure AI Language

This sample demonstrates how to create a new project synchronously using the `Azure.AI.Language.Text.Authoring` SDK.

## Create a TextAnalysisAuthoringClient

To create a `TextAnalysisAuthoringClient`, you will need the service endpoint and credentials of your Language resource. You can specify the service version by providing an `TextAnalysisAuthoringClientOptions` instance.

```C# Snippet:CreateTextAuthoringClientForSpecificApiVersion
Uri endpoint = new Uri("{endpoint}");
AzureKeyCredential credential = new AzureKeyCredential("{api-key}");
TextAnalysisAuthoringClientOptions options = new TextAnalysisAuthoringClientOptions(TextAnalysisAuthoringClientOptions.ServiceVersion.V2025_05_15_Preview);
TextAnalysisAuthoringClient client = new TextAnalysisAuthoringClient(endpoint, credential, options);
```

Or you can also create a `TextAnalysisAuthoringClient` using Azure Active Directory (AAD) authentication. Your user or service principal must be assigned the "Cognitive Services Language Reader" role.
For details on how to set up AAD authentication, refer to the [Create a client using AAD](https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/cognitivelanguage/Azure.AI.Language.Text.Authoring/README.md#create-a-client-using-azure-active-directory-authentication).

## Create a Project Synchronously

To create a new project, call CreateProject on the TextAnalysisAuthoring client.

```C# Snippet:Sample1_TextAuthoring_CreateProject
string projectName = "{projectName}";
TextAuthoringProject projectClient = client.GetProject(projectName);
var projectData = new TextAuthoringCreateProjectDetails(
    projectKind: "{projectKind}",
    storageInputContainerName: "{storageInputContainerName}",
    language: "{language}"
)
{
    Description = "Project description for a Custom Entity Recognition project",
    Multilingual = true
};
```

To create a project, the CreateProject method sends a request with the necessary project data (such as name, language, and project type). The method returns a Response object indicating the creation status.

## Create a Project Asynchronously

To create a new project, call CreateProjectAsync on the TextAnalysisAuthoring client.

```C# Snippet:Sample1_TextAuthoring_CreateProjectAsync
string projectName = "{projectName}";
TextAuthoringProject projectClient = client.GetProject(projectName);
var projectData = new TextAuthoringCreateProjectDetails(
    projectKind: "{projectKind}",
    storageInputContainerName: "{storageInputContainerName}",
    language: "{language}"
)
{
    Description = "Project description for a Custom Entity Recognition project",
    Multilingual = true
};

Response response = await projectClient.CreateProjectAsync(projectData);

Console.WriteLine($"Project created with status: {response.Status}");
```

To create a project, the CreateProject method sends a request with the necessary project data (such as name, language, and project type). The method returns a Response object indicating the creation status.
