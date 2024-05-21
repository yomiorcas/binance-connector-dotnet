// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Binance.Spot
{
    public class TradePosition
    {
        public string symbol { get; set; }
        public decimal entryPrice { get; set; }
        public int leverage { get; set; }
        public long updateTime { get; set; }
        public decimal liquidationPrice { get; set; }
        public decimal unRealizedProfit { get; set; }
        public decimal breakEvenPrice { get; set; }
        public decimal markPrice { get; set; }
        public string marginType { get; set; }
        public decimal isolatedWallet { get; set; }
        public decimal positionAmt { get; set; }
        public decimal notional { get; set; }
        public string positionSide { get; set; }
    }
}
