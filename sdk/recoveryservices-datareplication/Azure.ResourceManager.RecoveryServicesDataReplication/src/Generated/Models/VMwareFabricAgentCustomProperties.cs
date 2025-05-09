// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    /// <summary> VMware fabric agent model custom properties. </summary>
    public partial class VMwareFabricAgentCustomProperties : DataReplicationFabricAgentCustomProperties
    {
        /// <summary> Initializes a new instance of <see cref="VMwareFabricAgentCustomProperties"/>. </summary>
        /// <param name="biosId"> Gets or sets the BIOS Id of the fabric agent machine. </param>
        /// <param name="marsAuthenticationIdentity"> Identity model. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="biosId"/> or <paramref name="marsAuthenticationIdentity"/> is null. </exception>
        public VMwareFabricAgentCustomProperties(string biosId, DataReplicationIdentity marsAuthenticationIdentity)
        {
            Argument.AssertNotNull(biosId, nameof(biosId));
            Argument.AssertNotNull(marsAuthenticationIdentity, nameof(marsAuthenticationIdentity));

            BiosId = biosId;
            MarsAuthenticationIdentity = marsAuthenticationIdentity;
            InstanceType = "VMware";
        }

        /// <summary> Initializes a new instance of <see cref="VMwareFabricAgentCustomProperties"/>. </summary>
        /// <param name="instanceType"> Discriminator property for DataReplicationFabricAgentCustomProperties. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="biosId"> Gets or sets the BIOS Id of the fabric agent machine. </param>
        /// <param name="marsAuthenticationIdentity"> Identity model. </param>
        internal VMwareFabricAgentCustomProperties(string instanceType, IDictionary<string, BinaryData> serializedAdditionalRawData, string biosId, DataReplicationIdentity marsAuthenticationIdentity) : base(instanceType, serializedAdditionalRawData)
        {
            BiosId = biosId;
            MarsAuthenticationIdentity = marsAuthenticationIdentity;
            InstanceType = instanceType ?? "VMware";
        }

        /// <summary> Initializes a new instance of <see cref="VMwareFabricAgentCustomProperties"/> for deserialization. </summary>
        internal VMwareFabricAgentCustomProperties()
        {
        }

        /// <summary> Gets or sets the BIOS Id of the fabric agent machine. </summary>
        public string BiosId { get; set; }
        /// <summary> Identity model. </summary>
        public DataReplicationIdentity MarsAuthenticationIdentity { get; set; }
    }
}
