﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading.Tasks;
using System;
using Azure.Core;
using System.Threading;

namespace Azure.Communication.CallAutomation
{
    [CodeGenModel("TransferCallResponse")]
    public partial class TransferCallToParticipantResult
    {
        private CallAutomationEventProcessor _evHandler;
        private string _callConnectionId;
        private string _operationContext;

        internal void SetEventProcessor(CallAutomationEventProcessor evHandler, string callConnectionId, string operationContext)
        {
            _evHandler = evHandler;
            _callConnectionId = callConnectionId;
            _operationContext = operationContext;
        }

        /// <summary>
        /// This is blocking call. Wait for <see cref="TransferCallToParticipantEventResult"/> using <see cref="CallAutomationEventProcessor"/>.
        /// </summary>
        /// <param name="cancellationToken">Cancellation Token can be used to set timeout or cancel this WaitForEventProcessor.</param>
        /// <returns>Returns <see cref="TransferCallToParticipantEventResult"/> which contains either <see cref="CallTransferAcceptedEventData"/> event or <see cref="CallTransferFailedEventData"/> event.</returns>
        public TransferCallToParticipantEventResult WaitForEventProcessor(CancellationToken cancellationToken = default)
        {
            if (_evHandler is null)
            {
                throw new NullReferenceException(nameof(_evHandler));
            }

            var returnedEvent = _evHandler.WaitForEventProcessor(filter
                => filter.CallConnectionId == _callConnectionId
                && (filter.OperationContext == _operationContext || _operationContext is null)
                && (filter.GetType() == typeof(CallTransferAcceptedEventData)
                || filter.GetType() == typeof(CallTransferFailedEventData)),
                cancellationToken);

            return SetReturnedEvent(returnedEvent);
        }

        /// <summary>
        /// Wait for <see cref="TransferCallToParticipantEventResult"/> using <see cref="CallAutomationEventProcessor"/>.
        /// </summary>
        /// <param name="cancellationToken">Cancellation Token can be used to set timeout or cancel this WaitForEventProcessor.</param>
        /// <returns>Returns <see cref="TransferCallToParticipantEventResult"/> which contains either <see cref="CallTransferAcceptedEventData"/> event or <see cref="CallTransferFailedEventData"/> event.</returns>
        public async Task<TransferCallToParticipantEventResult> WaitForEventProcessorAsync(CancellationToken cancellationToken = default)
        {
            if (_evHandler is null)
            {
                throw new NullReferenceException(nameof(_evHandler));
            }

            var returnedEvent = await _evHandler.WaitForEventProcessorAsync(filter
                => filter.CallConnectionId == _callConnectionId
                && (filter.OperationContext == _operationContext || _operationContext is null)
                && (filter.GetType() == typeof(CallTransferAcceptedEventData)
                || filter.GetType() == typeof(CallTransferFailedEventData)),
                cancellationToken).ConfigureAwait(false);

            return SetReturnedEvent(returnedEvent);
        }

        private static TransferCallToParticipantEventResult SetReturnedEvent(CallAutomationEventData returnedEvent)
        {
            TransferCallToParticipantEventResult result = default;
            switch (returnedEvent)
            {
                case CallTransferAcceptedEventData:
                    result = new TransferCallToParticipantEventResult(true, (CallTransferAcceptedEventData)returnedEvent, null);
                    break;
                case CallTransferFailedEventData:
                    result = new TransferCallToParticipantEventResult(false, null, (CallTransferFailedEventData)returnedEvent);
                    break;
                default:
                    throw new NotSupportedException(returnedEvent.GetType().Name);
            }

            return result;
        }
    }
}
