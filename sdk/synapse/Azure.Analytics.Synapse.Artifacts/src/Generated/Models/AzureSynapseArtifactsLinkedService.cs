// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Azure Synapse Analytics (Artifacts) linked service. </summary>
    public partial class AzureSynapseArtifactsLinkedService : LinkedService
    {
        /// <summary> Initializes a new instance of <see cref="AzureSynapseArtifactsLinkedService"/>. </summary>
        /// <param name="endpoint"> https://&lt;workspacename&gt;.dev.azuresynapse.net, Azure Synapse Analytics workspace URL. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> is null. </exception>
        public AzureSynapseArtifactsLinkedService(object endpoint)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));

            Endpoint = endpoint;
            Type = "AzureSynapseArtifacts";
        }

        /// <summary> Initializes a new instance of <see cref="AzureSynapseArtifactsLinkedService"/>. </summary>
        /// <param name="type"> Type of linked service. </param>
        /// <param name="version"> Version of the linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="endpoint"> https://&lt;workspacename&gt;.dev.azuresynapse.net, Azure Synapse Analytics workspace URL. Type: string (or Expression with resultType string). </param>
        /// <param name="authentication"> Required to specify MSI, if using system assigned managed identity as authentication method. Type: string (or Expression with resultType string). </param>
        /// <param name="workspaceResourceId"> The resource ID of the Synapse workspace. The format should be: /subscriptions/{subscriptionID}/resourceGroups/{resourceGroup}/providers/Microsoft.Synapse/workspaces/{workspaceName}. Type: string (or Expression with resultType string). </param>
        internal AzureSynapseArtifactsLinkedService(string type, string version, IntegrationRuntimeReference connectVia, string description, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, IDictionary<string, object> additionalProperties, object endpoint, object authentication, object workspaceResourceId) : base(type, version, connectVia, description, parameters, annotations, additionalProperties)
        {
            Endpoint = endpoint;
            Authentication = authentication;
            WorkspaceResourceId = workspaceResourceId;
            Type = type ?? "AzureSynapseArtifacts";
        }

        /// <summary> https://&lt;workspacename&gt;.dev.azuresynapse.net, Azure Synapse Analytics workspace URL. Type: string (or Expression with resultType string). </summary>
        public object Endpoint { get; set; }
        /// <summary> Required to specify MSI, if using system assigned managed identity as authentication method. Type: string (or Expression with resultType string). </summary>
        public object Authentication { get; set; }
        /// <summary> The resource ID of the Synapse workspace. The format should be: /subscriptions/{subscriptionID}/resourceGroups/{resourceGroup}/providers/Microsoft.Synapse/workspaces/{workspaceName}. Type: string (or Expression with resultType string). </summary>
        public object WorkspaceResourceId { get; set; }
    }
}
