// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.AI.Projects
{
    // Data plane generated sub-client.
    /// <summary> The Telemetry sub-client. </summary>
    public partial class TelemetryClient
    {
        private static readonly string[] AuthorizationScopes = new string[] { "https://management.azure.com/.default" };
        private readonly TokenCredential _tokenCredential;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _subscriptionId;
        private readonly string _resourceGroupName;
        private readonly string _projectName;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of TelemetryClient for mocking. </summary>
        protected TelemetryClient()
        {
        }

        /// <summary> Initializes a new instance of TelemetryClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="tokenCredential"> The token credential to copy. </param>
        /// <param name="endpoint"> The Azure AI Foundry project endpoint, in the form `https://&lt;azure-region&gt;.api.azureml.ms` or `https://&lt;private-link-guid&gt;.&lt;azure-region&gt;.api.azureml.ms`, where &lt;azure-region&gt; is the Azure region where the project is deployed (e.g. westus) and &lt;private-link-guid&gt; is the GUID of the Enterprise private link. </param>
        /// <param name="subscriptionId"> The Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the Azure Resource Group. </param>
        /// <param name="projectName"> The Azure AI Foundry project name. </param>
        /// <param name="apiVersion"> The API version to use for this operation. </param>
        internal TelemetryClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, TokenCredential tokenCredential, Uri endpoint, string subscriptionId, string resourceGroupName, string projectName, string apiVersion)
        {
            ClientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _tokenCredential = tokenCredential;
            _endpoint = endpoint;
            _subscriptionId = subscriptionId;
            _resourceGroupName = resourceGroupName;
            _projectName = projectName;
            _apiVersion = apiVersion;
        }

        /// <summary> Gets the properties of the specified Application Insights resource. </summary>
        /// <param name="appInsightsResourceUrl"> The AppInsights Azure resource Url. It should have the format: '/subscriptions/{subscription_id}/resourceGroups/{resource_group_name}/providers/microsoft.insights/components/{resourcename}'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="appInsightsResourceUrl"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="appInsightsResourceUrl"/> is an empty string, and was expected to be non-empty. </exception>
        internal virtual async Task<Response<GetAppInsightsResponse>> GetAppInsightsAsync(string appInsightsResourceUrl, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(appInsightsResourceUrl, nameof(appInsightsResourceUrl));

            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = await GetAppInsightsAsync(appInsightsResourceUrl, context).ConfigureAwait(false);
            return Response.FromValue(GetAppInsightsResponse.FromResponse(response), response);
        }

        /// <summary> Gets the properties of the specified Application Insights resource. </summary>
        /// <param name="appInsightsResourceUrl"> The AppInsights Azure resource Url. It should have the format: '/subscriptions/{subscription_id}/resourceGroups/{resource_group_name}/providers/microsoft.insights/components/{resourcename}'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="appInsightsResourceUrl"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="appInsightsResourceUrl"/> is an empty string, and was expected to be non-empty. </exception>
        internal virtual Response<GetAppInsightsResponse> GetAppInsights(string appInsightsResourceUrl, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(appInsightsResourceUrl, nameof(appInsightsResourceUrl));

            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = GetAppInsights(appInsightsResourceUrl, context);
            return Response.FromValue(GetAppInsightsResponse.FromResponse(response), response);
        }

        /// <summary>
        /// [Protocol Method] Gets the properties of the specified Application Insights resource
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="GetAppInsightsAsync(string,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="appInsightsResourceUrl"> The AppInsights Azure resource Url. It should have the format: '/subscriptions/{subscription_id}/resourceGroups/{resource_group_name}/providers/microsoft.insights/components/{resourcename}'. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="appInsightsResourceUrl"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="appInsightsResourceUrl"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        internal virtual async Task<Response> GetAppInsightsAsync(string appInsightsResourceUrl, RequestContext context)
        {
            Argument.AssertNotNullOrEmpty(appInsightsResourceUrl, nameof(appInsightsResourceUrl));

            using var scope = ClientDiagnostics.CreateScope("TelemetryClient.GetAppInsights");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetAppInsightsRequest(appInsightsResourceUrl, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Gets the properties of the specified Application Insights resource
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="GetAppInsights(string,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="appInsightsResourceUrl"> The AppInsights Azure resource Url. It should have the format: '/subscriptions/{subscription_id}/resourceGroups/{resource_group_name}/providers/microsoft.insights/components/{resourcename}'. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="appInsightsResourceUrl"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="appInsightsResourceUrl"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        internal virtual Response GetAppInsights(string appInsightsResourceUrl, RequestContext context)
        {
            Argument.AssertNotNullOrEmpty(appInsightsResourceUrl, nameof(appInsightsResourceUrl));

            using var scope = ClientDiagnostics.CreateScope("TelemetryClient.GetAppInsights");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetAppInsightsRequest(appInsightsResourceUrl, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateGetAppInsightsRequest(string appInsightsResourceUrl, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRaw("/agents/v1.0/subscriptions/", false);
            uri.AppendRaw(_subscriptionId, true);
            uri.AppendRaw("/resourceGroups/", false);
            uri.AppendRaw(_resourceGroupName, true);
            uri.AppendRaw("/providers/Microsoft.MachineLearningServices/workspaces/", false);
            uri.AppendRaw(_projectName, true);
            uri.AppendPath("/", false);
            uri.AppendPath(appInsightsResourceUrl, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        private static RequestContext DefaultRequestContext = new RequestContext();
        internal static RequestContext FromCancellationToken(CancellationToken cancellationToken = default)
        {
            if (!cancellationToken.CanBeCanceled)
            {
                return DefaultRequestContext;
            }

            return new RequestContext() { CancellationToken = cancellationToken };
        }

        private static ResponseClassifier _responseClassifier200;
        private static ResponseClassifier ResponseClassifier200 => _responseClassifier200 ??= new StatusCodeClassifier(stackalloc ushort[] { 200 });
    }
}
