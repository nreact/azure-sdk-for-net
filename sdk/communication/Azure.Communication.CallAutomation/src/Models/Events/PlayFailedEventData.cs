﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallAutomation
{
    /// <summary>
    /// The Play Failed event.
    /// </summary>
    [CodeGenModel("PlayFailed", Usage = new string[] { "output" }, Formats = new string[] { "json" })]
    public partial class PlayFailedEventData : CallAutomationEventData
    {
        /// <summary>
        /// Reason code.
        /// </summary>
        public ReasonCode ReasonCode { get; internal set; }

        /// <summary> Initializes a new instance of PlayFailed. </summary>
        /// <param name="callConnectionId"> Call connection ID. </param>
        /// <param name="serverCallId"> Server call ID. </param>
        /// <param name="correlationId"> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </param>
        /// <param name="operationContext"> Used by customers when calling mid-call actions to correlate the request to the response event. </param>
        /// <param name="resultInformation"> Contains the resulting SIP code/sub-code and message from NGC services. </param>
        internal PlayFailedEventData(string callConnectionId, string serverCallId, string correlationId, string operationContext, ResultInformation resultInformation)
        {
            CallConnectionId = callConnectionId;
            ServerCallId = serverCallId;
            CorrelationId = correlationId;
            OperationContext = operationContext;
            ResultInformation = resultInformation;
            ReasonCode = new ReasonCode(resultInformation.SubCode.ToString());
        }

        /// <summary>
        /// Deserialize <see cref="PlayFailedEventData"/> event.
        /// </summary>
        /// <param name="content">The json content.</param>
        /// <returns>The new <see cref="PlayFailedEventData"/> object.</returns>
        public static PlayFailedEventData Deserialize(string content)
        {
            using var document = JsonDocument.Parse(content);
            JsonElement element = document.RootElement;

            return DeserializePlayFailedEventData(element);
        }
    }
}
