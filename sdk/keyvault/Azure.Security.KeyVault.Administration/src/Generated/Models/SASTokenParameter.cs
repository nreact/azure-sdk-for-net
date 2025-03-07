// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Security.KeyVault.Administration.Models
{
    /// <summary> The SASTokenParameter. </summary>
    internal partial class SASTokenParameter
    {
        /// <summary> Initializes a new instance of SASTokenParameter. </summary>
        /// <param name="storageResourceUri"> Azure Blob storage container Uri. </param>
        /// <param name="token"> The SAS token pointing to an Azure Blob storage container. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="storageResourceUri"/> or <paramref name="token"/> is null. </exception>
        public SASTokenParameter(string storageResourceUri, string token)
        {
            Argument.AssertNotNull(storageResourceUri, nameof(storageResourceUri));
            Argument.AssertNotNull(token, nameof(token));

            StorageResourceUri = storageResourceUri;
            Token = token;
        }

        /// <summary> Azure Blob storage container Uri. </summary>
        public string StorageResourceUri { get; }
        /// <summary> The SAS token pointing to an Azure Blob storage container. </summary>
        public string Token { get; }
    }
}
