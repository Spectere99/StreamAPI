﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace StreamApi
{
    public static class HttpRequestMessageExtensions
    {
        /// <summary>
        /// Returns an individual HTTP Header value
        /// </summary>
        /// <param name="request"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetHeader(this HttpRequestMessage request, string key)
        {
            IEnumerable<string> keys = null;
            if (!request.Headers.TryGetValues(key, out keys))
                return null;

            return keys.First();
        }
    }
}