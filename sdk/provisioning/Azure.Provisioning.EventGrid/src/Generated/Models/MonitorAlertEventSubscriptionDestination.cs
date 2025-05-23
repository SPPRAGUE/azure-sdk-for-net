// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.EventGrid;

/// <summary>
/// Information about the Monitor Alert destination for an event subscription.
/// </summary>
public partial class MonitorAlertEventSubscriptionDestination : EventSubscriptionDestination
{
    /// <summary>
    /// The severity that will be attached to every Alert fired through this
    /// event subscription.             This field must be provided.
    /// </summary>
    public BicepValue<MonitorAlertSeverity> Severity 
    {
        get { Initialize(); return _severity!; }
        set { Initialize(); _severity!.Assign(value); }
    }
    private BicepValue<MonitorAlertSeverity>? _severity;

    /// <summary>
    /// The description that will be attached to every Alert fired through this
    /// event subscription.
    /// </summary>
    public BicepValue<string> Description 
    {
        get { Initialize(); return _description!; }
        set { Initialize(); _description!.Assign(value); }
    }
    private BicepValue<string>? _description;

    /// <summary>
    /// The list of ARM Ids of Action Groups that will be triggered on every
    /// Alert fired through this event subscription.             Each resource
    /// ARM Id should follow this pattern:
    /// /subscriptions/{AzureSubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.Insights/actionGroups/{ActionGroupName}.
    /// </summary>
    public BicepList<ResourceIdentifier> ActionGroups 
    {
        get { Initialize(); return _actionGroups!; }
        set { Initialize(); _actionGroups!.Assign(value); }
    }
    private BicepList<ResourceIdentifier>? _actionGroups;

    /// <summary>
    /// Creates a new MonitorAlertEventSubscriptionDestination.
    /// </summary>
    public MonitorAlertEventSubscriptionDestination() : base()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// MonitorAlertEventSubscriptionDestination.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        DefineProperty<string>("endpointType", ["endpointType"], defaultValue: "MonitorAlert");
        _severity = DefineProperty<MonitorAlertSeverity>("Severity", ["properties", "severity"]);
        _description = DefineProperty<string>("Description", ["properties", "description"]);
        _actionGroups = DefineListProperty<ResourceIdentifier>("ActionGroups", ["properties", "actionGroups"]);
    }
}
