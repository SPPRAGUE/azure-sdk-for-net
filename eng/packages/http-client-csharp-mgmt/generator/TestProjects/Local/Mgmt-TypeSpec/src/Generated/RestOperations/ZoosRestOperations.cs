// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace MgmtTypeSpec
{
    internal partial class Zoos
    {
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of Zoos for mocking. </summary>
        protected Zoos()
        {
        }

        /// <summary> Initializes a new instance of Zoos. </summary>
        /// <param name="clientDiagnostics"> The ClientDiagnostics is used to provide tracing support for the client library. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> Service endpoint. </param>
        /// <param name="apiVersion"></param>
        internal Zoos(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint, string apiVersion)
        {
            ClientDiagnostics = clientDiagnostics;
            _endpoint = endpoint;
            Pipeline = pipeline;
            _apiVersion = apiVersion;
        }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline { get; }

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        internal HttpMessage CreateCreateOrUpdateRequest(Guid subscriptionId, string resourceGroupName, string zooName, RequestContent content, RequestContext context)
        {
            HttpMessage message = Pipeline.CreateMessage();
            Request request = message.Request;
            request.Method = RequestMethod.Put;
            RawRequestUriBuilder uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId.ToString(), true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/MgmtTypeSpec/zoos/", false);
            uri.AppendPath(zooName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.SetValue("Content-Type", "application/json");
            request.Headers.SetValue("Accept", "application/json");
            request.Content = content;
            return message;
        }

        internal HttpMessage CreateGetRequest(Guid subscriptionId, string resourceGroupName, string zooName, RequestContext context)
        {
            HttpMessage message = Pipeline.CreateMessage();
            Request request = message.Request;
            request.Method = RequestMethod.Get;
            RawRequestUriBuilder uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId.ToString(), true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/MgmtTypeSpec/zoos/", false);
            uri.AppendPath(zooName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.SetValue("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateDeleteRequest(Guid subscriptionId, string resourceGroupName, string zooName, RequestContext context)
        {
            HttpMessage message = Pipeline.CreateMessage();
            Request request = message.Request;
            request.Method = RequestMethod.Delete;
            RawRequestUriBuilder uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId.ToString(), true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/MgmtTypeSpec/zoos/", false);
            uri.AppendPath(zooName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.SetValue("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateUpdateRequest(Guid subscriptionId, string resourceGroupName, string zooName, RequestContent content, RequestContext context)
        {
            HttpMessage message = Pipeline.CreateMessage();
            Request request = message.Request;
            request.Method = RequestMethod.Patch;
            RawRequestUriBuilder uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId.ToString(), true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/MgmtTypeSpec/zoos/", false);
            uri.AppendPath(zooName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.SetValue("Content-Type", "application/json");
            request.Headers.SetValue("Accept", "application/json");
            request.Content = content;
            return message;
        }

        internal HttpMessage CreateGetRequest(Guid subscriptionId, string resourceGroupName, RequestContext context)
        {
            HttpMessage message = Pipeline.CreateMessage();
            Request request = message.Request;
            request.Method = RequestMethod.Get;
            RawRequestUriBuilder uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId.ToString(), true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/MgmtTypeSpec/zoos", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.SetValue("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateNextGetRequest(Uri nextPage, Guid subscriptionId, string resourceGroupName, RequestContext context)
        {
            HttpMessage message = Pipeline.CreateMessage();
            Request request = message.Request;
            request.Method = RequestMethod.Get;
            RawRequestUriBuilder uri = new RawRequestUriBuilder();
            uri.Reset(nextPage);
            request.Uri = uri;
            request.Headers.SetValue("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateZooAddressListRequest(Guid subscriptionId, string resourceGroupName, string zooName, int? maxpagesize, RequestContext context)
        {
            HttpMessage message = Pipeline.CreateMessage();
            Request request = message.Request;
            request.Method = RequestMethod.Get;
            RawRequestUriBuilder uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId.ToString(), true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/MgmtTypeSpec/zoos/", false);
            uri.AppendPath(zooName, true);
            uri.AppendPath("/zooAddressList", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (maxpagesize != null)
            {
                uri.AppendQuery("$maxpagesize", TypeFormatters.ConvertToString(maxpagesize, null), true);
            }
            request.Uri = uri;
            request.Headers.SetValue("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateNextZooAddressListRequest(Uri nextPage, Guid subscriptionId, string resourceGroupName, string zooName, int? maxpagesize, RequestContext context)
        {
            HttpMessage message = Pipeline.CreateMessage();
            Request request = message.Request;
            request.Method = RequestMethod.Get;
            RawRequestUriBuilder uri = new RawRequestUriBuilder();
            uri.Reset(nextPage);
            request.Uri = uri;
            request.Headers.SetValue("Accept", "application/json");
            return message;
        }
    }
}
