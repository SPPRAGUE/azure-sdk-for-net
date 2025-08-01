// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Diagnostics.CodeAnalysis;
using Azure.Core.Extensions;
using _Specs_.Azure.ClientGenerator.Core.Access;

namespace Microsoft.Extensions.Azure
{
    public static partial class _Specs_AzureClientGeneratorCoreAccessClientBuilderExtensions
    {
        public static IAzureClientBuilder<AccessClient, AccessClientOptions> AddAccessClient<TBuilder>(this TBuilder builder, Uri endpoint)
            where TBuilder : IAzureClientFactoryBuilder => throw null;

        [RequiresUnreferencedCode("Requires unreferenced code until we opt into EnableConfigurationBindingGenerator.")]
        [RequiresDynamicCode("Requires unreferenced code until we opt into EnableConfigurationBindingGenerator.")]
        public static IAzureClientBuilder<AccessClient, AccessClientOptions> AddAccessClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration)
            where TBuilder : IAzureClientFactoryBuilderWithConfiguration<TConfiguration> => throw null;
    }
}
