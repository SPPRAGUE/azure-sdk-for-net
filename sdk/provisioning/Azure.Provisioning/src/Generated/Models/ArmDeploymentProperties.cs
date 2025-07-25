// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Resources;

/// <summary>
/// Deployment properties.
/// </summary>
public partial class ArmDeploymentProperties : ProvisionableConstruct
{
    /// <summary>
    /// The template content. You use this element when you want to pass the
    /// template syntax directly in the request rather than link to an
    /// existing template. It can be a JObject or well-formed JSON string. Use
    /// either the templateLink property or the template property, but not
    /// both.                          To assign an object to this property
    /// use System.BinaryData.FromObjectAsJson``1(``0,System.Text.Json.JsonSerializerOptions).
    /// To assign an already formatted json string to
    /// this property use System.BinaryData.FromString(System.String).
    /// Examples:
    /// BinaryData.FromObjectAsJson(&quot;foo&quot;)Creates a
    /// payload of
    /// &quot;foo&quot;.BinaryData.FromString(&quot;\&quot;foo\&quot;&quot;)Creates
    /// a payload of &quot;foo&quot;.BinaryData.FromObjectAsJson(new { key =
    /// &quot;value&quot; })Creates a payload of { &quot;key&quot;:
    /// &quot;value&quot; }.BinaryData.FromString(&quot;{\&quot;key\&quot;:
    /// \&quot;value\&quot;}&quot;)Creates a payload of { &quot;key&quot;:
    /// &quot;value&quot; }.
    /// </summary>
    public BicepValue<BinaryData> Template 
    {
        get { Initialize(); return _template!; }
        set { Initialize(); _template!.Assign(value); }
    }
    private BicepValue<BinaryData>? _template;

    /// <summary>
    /// The URI of the template. Use either the templateLink property or the
    /// template property, but not both.
    /// </summary>
    public ArmDeploymentTemplateLink TemplateLink 
    {
        get { Initialize(); return _templateLink!; }
        set { Initialize(); AssignOrReplace(ref _templateLink, value); }
    }
    private ArmDeploymentTemplateLink? _templateLink;

    /// <summary>
    /// Name and value pairs that define the deployment parameters for the
    /// template. You use this element when you want to provide the parameter
    /// values directly in the request rather than link to an existing
    /// parameter file. Use either the parametersLink property or the
    /// parameters property, but not both. It can be a JObject or a well
    /// formed JSON string.                          To assign an object to
    /// this property use
    /// System.BinaryData.FromObjectAsJson``1(``0,System.Text.Json.JsonSerializerOptions).
    /// To assign an already formatted json string to
    /// this property use System.BinaryData.FromString(System.String).
    /// Examples:
    /// BinaryData.FromObjectAsJson(&quot;foo&quot;)Creates a
    /// payload of
    /// &quot;foo&quot;.BinaryData.FromString(&quot;\&quot;foo\&quot;&quot;)Creates
    /// a payload of &quot;foo&quot;.BinaryData.FromObjectAsJson(new { key =
    /// &quot;value&quot; })Creates a payload of { &quot;key&quot;:
    /// &quot;value&quot; }.BinaryData.FromString(&quot;{\&quot;key\&quot;:
    /// \&quot;value\&quot;}&quot;)Creates a payload of { &quot;key&quot;:
    /// &quot;value&quot; }.
    /// </summary>
    public BicepValue<BinaryData> Parameters 
    {
        get { Initialize(); return _parameters!; }
        set { Initialize(); _parameters!.Assign(value); }
    }
    private BicepValue<BinaryData>? _parameters;

    /// <summary>
    /// External input values, used by external tooling for parameter
    /// evaluation.
    /// </summary>
    public BicepDictionary<ArmDeploymentExternalInput> ExternalInputs 
    {
        get { Initialize(); return _externalInputs!; }
        set { Initialize(); _externalInputs!.Assign(value); }
    }
    private BicepDictionary<ArmDeploymentExternalInput>? _externalInputs;

    /// <summary>
    /// External input definitions, used by external tooling to define expected
    /// external input values.
    /// </summary>
    public BicepDictionary<ArmDeploymentExternalInputDefinition> ExternalInputDefinitions 
    {
        get { Initialize(); return _externalInputDefinitions!; }
        set { Initialize(); _externalInputDefinitions!.Assign(value); }
    }
    private BicepDictionary<ArmDeploymentExternalInputDefinition>? _externalInputDefinitions;

    /// <summary>
    /// The URI of parameters file. You use this element to link to an existing
    /// parameters file. Use either the parametersLink property or the
    /// parameters property, but not both.
    /// </summary>
    public ArmDeploymentParametersLink ParametersLink 
    {
        get { Initialize(); return _parametersLink!; }
        set { Initialize(); AssignOrReplace(ref _parametersLink, value); }
    }
    private ArmDeploymentParametersLink? _parametersLink;

    /// <summary>
    /// The configurations to use for deployment extensions. The keys of this
    /// object are deployment extension aliases as defined in the deployment
    /// template.
    /// </summary>
    public BicepDictionary<BicepDictionary<ArmDeploymentExtensionConfigItem>> ExtensionConfigs 
    {
        get { Initialize(); return _extensionConfigs!; }
        set { Initialize(); _extensionConfigs!.Assign(value); }
    }
    private BicepDictionary<BicepDictionary<ArmDeploymentExtensionConfigItem>>? _extensionConfigs;

    /// <summary>
    /// The mode that is used to deploy resources. This value can be either
    /// Incremental or Complete. In Incremental mode, resources are deployed
    /// without deleting existing resources that are not included in the
    /// template. In Complete mode, resources are deployed and existing
    /// resources in the resource group that are not included in the template
    /// are deleted. Be careful when using Complete mode as you may
    /// unintentionally delete resources.
    /// </summary>
    public BicepValue<ArmDeploymentMode> Mode 
    {
        get { Initialize(); return _mode!; }
    }
    private BicepValue<ArmDeploymentMode>? _mode;

    /// <summary>
    /// Specifies the type of information to log for debugging. The permitted
    /// values are none, requestContent, responseContent, or both
    /// requestContent and responseContent separated by a comma. The default
    /// is none. When setting this value, carefully consider the type of
    /// information you are passing in during deployment. By logging
    /// information about the request or response, you could potentially
    /// expose sensitive data that is retrieved through the deployment
    /// operations.
    /// </summary>
    public BicepValue<string> DebugSettingDetailLevel 
    {
        get { Initialize(); return _debugSettingDetailLevel!; }
        set { Initialize(); _debugSettingDetailLevel!.Assign(value); }
    }
    private BicepValue<string>? _debugSettingDetailLevel;

    /// <summary>
    /// The deployment on error behavior.
    /// </summary>
    public ErrorDeployment ErrorDeployment 
    {
        get { Initialize(); return _errorDeployment!; }
        set { Initialize(); AssignOrReplace(ref _errorDeployment, value); }
    }
    private ErrorDeployment? _errorDeployment;

    /// <summary>
    /// The scope to be used for evaluation of parameters, variables and
    /// functions in a nested template.
    /// </summary>
    public BicepValue<ExpressionEvaluationScope> ExpressionEvaluationScope 
    {
        get { Initialize(); return _expressionEvaluationScope!; }
        set { Initialize(); _expressionEvaluationScope!.Assign(value); }
    }
    private BicepValue<ExpressionEvaluationScope>? _expressionEvaluationScope;

    /// <summary>
    /// The validation level of the deployment.
    /// </summary>
    public BicepValue<ValidationLevel> ValidationLevel 
    {
        get { Initialize(); return _validationLevel!; }
        set { Initialize(); _validationLevel!.Assign(value); }
    }
    private BicepValue<ValidationLevel>? _validationLevel;

    /// <summary>
    /// Creates a new ArmDeploymentProperties.
    /// </summary>
    public ArmDeploymentProperties()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of ArmDeploymentProperties.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _template = DefineProperty<BinaryData>("Template", ["template"]);
        _templateLink = DefineModelProperty<ArmDeploymentTemplateLink>("TemplateLink", ["templateLink"]);
        _parameters = DefineProperty<BinaryData>("Parameters", ["parameters"]);
        _externalInputs = DefineDictionaryProperty<ArmDeploymentExternalInput>("ExternalInputs", ["externalInputs"]);
        _externalInputDefinitions = DefineDictionaryProperty<ArmDeploymentExternalInputDefinition>("ExternalInputDefinitions", ["externalInputDefinitions"]);
        _parametersLink = DefineModelProperty<ArmDeploymentParametersLink>("ParametersLink", ["parametersLink"]);
        _extensionConfigs = DefineDictionaryProperty<BicepDictionary<ArmDeploymentExtensionConfigItem>>("ExtensionConfigs", ["extensionConfigs"]);
        _mode = DefineProperty<ArmDeploymentMode>("Mode", ["mode"], isOutput: true);
        _debugSettingDetailLevel = DefineProperty<string>("DebugSettingDetailLevel", ["debugSetting", "detailLevel"]);
        _errorDeployment = DefineModelProperty<ErrorDeployment>("ErrorDeployment", ["onErrorDeployment"]);
        _expressionEvaluationScope = DefineProperty<ExpressionEvaluationScope>("ExpressionEvaluationScope", ["expressionEvaluationOptions", "scope"]);
        _validationLevel = DefineProperty<ValidationLevel>("ValidationLevel", ["validationLevel"]);
    }
}
