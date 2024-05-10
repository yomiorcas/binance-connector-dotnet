// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using Binance.Spot;
using Newtonsoft.Json.Linq;

namespace Binance.Spot
{
    public class KLineResponse
    {
        public List<List<object>> result { get; set; }
        public string id { get; set; }
        public byte status { get; set; }
    }
}
