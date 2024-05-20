// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Binance.Spot
{
    public class OrderResponse
    {
        public long orderId { get; set; }
        public string clientOrderId { get; set; }
        public decimal price { get; set; }
        public decimal avgPrice { get; set; }
        public decimal stopPrice { get; set; }
        public string symbol { get; set; }
        public long updateTime { get; set; }
        public string origQty { get; set; }
        public string executedQty { get; set; }
        public string cumQuote { get; set; }
        public string timeInForce { get; set; }
        public string status { get; set; }
        public string type { get; set; }
    }
}
