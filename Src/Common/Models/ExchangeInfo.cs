// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;

namespace Binance.Spot
{
    public class ExchangeInfo
    {
        public string symbols { get; set; }
    }
    public class AssetSymbol
    {
        public string symbol { get; set; }
        public int pricePrecision { get; set; }
        public int quantityPrecision { get; set; }
        public decimal liquidationFee { get; set; }
        public decimal tickSize { get; set; }
        public decimal maxPrice { get; set; }
        public decimal minPrice { get; set; }
        public decimal stepSize { get; set; }
        public decimal minQty { get; set; }
        public decimal maxQty { get; set; }
    }
}
