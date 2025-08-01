// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Agents.Persistent
{
    /// <summary> Represents the function data in a streaming run step MCP call.*. </summary>
    public partial class RunStepDeltaMcpToolCall : RunStepDeltaToolCall
    {
        /// <summary> Initializes a new instance of <see cref="RunStepDeltaMcpToolCall"/>. </summary>
        /// <param name="index"> The index of the tool call detail in the run step's tool_calls array. </param>
        /// <param name="id"> The ID of the tool call, used when submitting outputs to the run. </param>
        /// <param name="arguments"> The arguments for MCP call. *. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="arguments"/> is null. </exception>
        internal RunStepDeltaMcpToolCall(int index, string id, string arguments) : base(index, id)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(arguments, nameof(arguments));

            Type = "mcp";
            Arguments = arguments;
        }

        /// <summary> Initializes a new instance of <see cref="RunStepDeltaMcpToolCall"/>. </summary>
        /// <param name="index"> The index of the tool call detail in the run step's tool_calls array. </param>
        /// <param name="id"> The ID of the tool call, used when submitting outputs to the run. </param>
        /// <param name="type"> The type of the tool call detail item in a streaming run step's details. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="arguments"> The arguments for MCP call. *. </param>
        internal RunStepDeltaMcpToolCall(int index, string id, string type, IDictionary<string, BinaryData> serializedAdditionalRawData, string arguments) : base(index, id, type, serializedAdditionalRawData)
        {
            Arguments = arguments;
        }

        /// <summary> Initializes a new instance of <see cref="RunStepDeltaMcpToolCall"/> for deserialization. </summary>
        internal RunStepDeltaMcpToolCall()
        {
        }

        /// <summary> The arguments for MCP call. *. </summary>
        public string Arguments { get; }
    }
}
