//
// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
//

using System;
using System.Collections.Generic;
using Google.Protobuf.Collections;

namespace Microsoft.Azure.Functions.PowerShellWorker
{
    /// <summary>
    /// Custom type represent the context of the in-coming Http request.
    /// </summary>
    public class HttpRequestContext
    {
        /// <summary>
        /// Constructor for HttpRequestContext.
        /// </summary>
        public HttpRequestContext()
        {
            Headers = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            Params = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            Query = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        }

        /// <summary>
        /// Gets the Body of the Http request.
        /// </summary>
        public object Body { get; internal set; }

        /// <summary>
        /// Gets the Headers of the Http request.
        /// </summary>
        public Dictionary<string, string> Headers { get; private set; }

        /// <summary>
        /// Gets the Method of the Http request.
        /// </summary>
        public string Method { get; internal set; }

        /// <summary>
        /// Gets the Url of the Http request.
        /// </summary>
        public string Url { get; internal set; }

        /// <summary>
        /// Gets the Params of the Http request.
        /// </summary>
        public Dictionary<string, string> Params { get; private set; }

        /// <summary>
        /// Gets the Query of the Http request.
        /// </summary>
        public Dictionary<string, string> Query { get; private set; }

        /// <summary>
        /// Gets the RawBody of the Http request.
        /// </summary>
        public object RawBody { get; internal set; }
    }
}
