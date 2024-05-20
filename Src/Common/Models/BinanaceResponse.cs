// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Text;

namespace Binance.Spot
{
    public class BinanaceResponse<T>
    {
        public string id { get; set; }
        public int status { get; set; }
        public T result { get; set; }
        public List<RateLimit> rateLimits { get; set; }
    }

    public class RateLimit
    {
        public string rateLimitType { get; set; }
        public string interval { get; set; }
        public int intervalNum { get; set; }
        public int limit { get; set; }
        public int count { get; set; }
    }
}
