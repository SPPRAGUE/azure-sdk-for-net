# Release History

## 1.2.0-beta.1 (Unreleased)

### Features Added

### Breaking Changes

### Bugs Fixed

### Other Changes

## 1.1.1 (2025-03-11)

### Features Added

- Exposed `JsonModelWriteCore` for model serialization procedure.

## 1.1.0 (2024-08-15)

### Features Added

- Upgraded api-version tag from 'package-2023-10' to 'package-2023-12'. Tag detail available at https://github.com/Azure/azure-rest-api-specs/blob/b8932418d4fd4940849e8722cc90e2b7bf1f8fda/specification/connectedvmware/resource-manager/readme.md.
- Enabled the new model serialization by using the System.ClientModel, refer this [document](https://aka.ms/azsdk/net/mrw) for more details.
- Added `ArmOperation.Rehydrate` and `ArmOperation.Rehydrate<T>` static methods to rehydrate a long-running operation.

### Other Changes

- Upgraded Azure.Core from 1.36.0 to 1.42.0
- Upgraded Azure.ResourceManager from 1.8.1 to 1.12.0

## 1.0.0 (2023-11-15)

This release is the first stable release of the Microsoft Azure Arc-enabled VMware vSphere Management library.

### Features Added

- Updated to API version `2023-10-01`.
- Enabled mocking for extension methods, refer this [document](https://aka.ms/azsdk/net/mocking) for more details.

### Other Changes

- Upgraded dependent `Azure.Core` to `1.35.0`.
- Upgraded dependent Azure.ResourceManager to 1.7.0.

## 1.0.0-beta.7 (2023-05-29)

### Features Added

- Enabled the model factory feature for model mocking, more information can be found [here](https://azure.github.io/azure-sdk/dotnet_introduction.html#dotnet-mocking-factory-builder).

### Other Changes

- Upgraded dependent Azure.Core to 1.32.0.
- Upgraded dependent Azure.ResourceManager to 1.6.0.

## 1.0.0-beta.6 (2023-02-16)

### Features Added

- Added operation support to `ArmConnectedVMwarevSphereModelFactory`.

### Other Changes

- Upgraded dependent `Azure.Core` to `1.28.0`.
- Upgraded dependent `Azure.ResourceManager` to `1.4.0`.

## 1.0.0-beta.5 (2022-07-12)

### Features Added

- Added Update methods in resource classes.

### Other Changes

- Upgraded dependent `Azure.ResourceManager` to 1.2.0
- Upgraded dependent `Azure.Core` to 1.25.0

## 1.0.0-beta.4 (2022-04-08)

### Breaking Changes

- Simplified `type` property names.
- Normalized the body parameter type names for PUT / POST / PATCH operations if it is only used as input.

### Other Changes

- Upgrade dependency to Azure.ResourceManager 1.0.0

## 1.0.0-beta.3 (2022-03-31)

### Breaking Changes

- Now all the resource classes would have a `Resource` suffix (if it previously does not have one).
- Renamed some models to more comprehensive names.
- `bool waitForCompletion` parameter in all long running operations were changed to `WaitUntil waitUntil`.
- Removed `GetIfExists` methods from all the resource classes.
- All properties of the type `object` were changed to `BinaryData`.

## 1.0.0-beta.2 (2022-01-29)

- waitForCompletion is now a required parameter and moved to the first parameter in LRO operations.
- Removed GetAllAsGenericResources in [Resource]Collections.
- Added Resource constructor to use ArmClient for ClientContext information and removed previous constructors with parameters.
- Couple of renamings.

## 1.0.0-beta.1 (2022-01-12)

### General New Features

This package follows the [new Azure SDK guidelines](https://azure.github.io/azure-sdk/general_introduction.html), and provides many core capabilities:

    - Support MSAL.NET, Azure.Identity is out of box for supporting MSAL.NET.
    - Support [OpenTelemetry](https://opentelemetry.io/) for distributed tracing.
    - HTTP pipeline with custom policies.
    - Better error-handling.
    - Support uniform telemetry across all languages.

This package is a Public Preview version, so expect incompatible changes in subsequent releases as we improve the product. To provide feedback, submit an issue in our [Azure SDK for .NET GitHub repo](https://github.com/Azure/azure-sdk-for-net/issues).

> NOTE: For more information about unified authentication, please refer to [Microsoft Azure Identity documentation for .NET](https://learn.microsoft.com/dotnet/api/overview/azure/identity-readme?view=azure-dotnet).
