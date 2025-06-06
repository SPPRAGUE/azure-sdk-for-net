// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.CognitiveServices;

/// <summary>
/// SkuCapability indicates the capability of a certain feature.
/// </summary>
public partial class CognitiveServicesSkuCapability : ProvisionableConstruct
{
    /// <summary>
    /// The name of the SkuCapability.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// The value of the SkuCapability.
    /// </summary>
    public BicepValue<string> Value 
    {
        get { Initialize(); return _value!; }
    }
    private BicepValue<string>? _value;

    /// <summary>
    /// Creates a new CognitiveServicesSkuCapability.
    /// </summary>
    public CognitiveServicesSkuCapability()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// CognitiveServicesSkuCapability.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _name = DefineProperty<string>("Name", ["name"], isOutput: true);
        _value = DefineProperty<string>("Value", ["value"], isOutput: true);
    }
}
