// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary>
    /// A class representing the CosmosDBTableRoleAssignment data model.
    /// Parameters to create and update an Azure Cosmos DB Table Role Assignment.
    /// </summary>
    public partial class CosmosDBTableRoleAssignmentData : ResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CosmosDBTableRoleAssignmentData"/>. </summary>
        public CosmosDBTableRoleAssignmentData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CosmosDBTableRoleAssignmentData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="roleDefinitionId"> The unique identifier for the associated Role Definition. </param>
        /// <param name="scope"> The data plane resource path for which access is being granted through this Table Role Assignment. </param>
        /// <param name="principalId"> The unique identifier for the associated AAD principal in the AAD graph to which access is being granted through this Table Role Assignment. Tenant ID for the principal is inferred using the tenant associated with the subscription. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CosmosDBTableRoleAssignmentData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ResourceIdentifier roleDefinitionId, ResourceIdentifier scope, Guid? principalId, string provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            RoleDefinitionId = roleDefinitionId;
            Scope = scope;
            PrincipalId = principalId;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The unique identifier for the associated Role Definition. </summary>
        [WirePath("properties.roleDefinitionId")]
        public ResourceIdentifier RoleDefinitionId { get; set; }
        /// <summary> The data plane resource path for which access is being granted through this Table Role Assignment. </summary>
        [WirePath("properties.scope")]
        public ResourceIdentifier Scope { get; set; }
        /// <summary> The unique identifier for the associated AAD principal in the AAD graph to which access is being granted through this Table Role Assignment. Tenant ID for the principal is inferred using the tenant associated with the subscription. </summary>
        [WirePath("properties.principalId")]
        public Guid? PrincipalId { get; set; }
        /// <summary> Provisioning state of the resource. </summary>
        [WirePath("properties.provisioningState")]
        public string ProvisioningState { get; }
    }
}
