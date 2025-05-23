// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppService;

/// <summary>
/// Specification for a Kubernetes Environment to use for this resource.
/// </summary>
public partial class KubeEnvironmentProfile : ProvisionableConstruct
{
    /// <summary>
    /// Resource ID of the Kubernetes Environment.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id 
    {
        get { Initialize(); return _id!; }
        set { Initialize(); _id!.Assign(value); }
    }
    private BicepValue<ResourceIdentifier>? _id;

    /// <summary>
    /// Name of the Kubernetes Environment.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// Resource type of the Kubernetes Environment.
    /// </summary>
    public BicepValue<ResourceType> ResourceType 
    {
        get { Initialize(); return _resourceType!; }
    }
    private BicepValue<ResourceType>? _resourceType;

    /// <summary>
    /// Creates a new KubeEnvironmentProfile.
    /// </summary>
    public KubeEnvironmentProfile()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of KubeEnvironmentProfile.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"]);
        _name = DefineProperty<string>("Name", ["name"], isOutput: true);
        _resourceType = DefineProperty<ResourceType>("ResourceType", ["type"], isOutput: true);
    }
}
