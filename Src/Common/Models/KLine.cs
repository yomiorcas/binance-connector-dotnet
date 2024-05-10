namespace Binance.Spot
{
    using System;

    public class KLine
    {
        public long OpenTime { get; set; }
        public DateTime OpenDateTime => new DateTime(OpenTime);
        public decimal Open { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public decimal Close { get; set; }
        public decimal Volume { get; set; }
        public decimal QuoteAssetVolume { get; set; }
        public long NumberOfTrades { get; set; }
    }
}
