namespace Binance.Spot
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Binance.Common;
    using Binance.Spot.Models;

    public class FutureMarket : SpotService
    {
        public FutureMarket(string baseUrl = DEFAULT_SPOT_BASE_URL, string apiKey = null, string apiSecret = null)
        : this(new HttpClient(), baseUrl: baseUrl, apiKey: apiKey, apiSecret: apiSecret)
        {
        }

        public FutureMarket(HttpClient httpClient, string baseUrl = DEFAULT_SPOT_BASE_URL, string apiKey = null, string apiSecret = null)
        : base(httpClient, baseUrl: baseUrl, apiKey: apiKey, apiSecret: apiSecret)
        {
        }

        public FutureMarket(HttpClient httpClient, IBinanceSignatureService signatureService, string baseUrl = DEFAULT_SPOT_BASE_URL, string apiKey = null)
        : base(httpClient, baseUrl: baseUrl, apiKey: apiKey, signatureService: signatureService)
        {
        }

        private const string KLINE_CANDLESTICK_DATA = "/fapi/v1/klines";

        /// <summary>
        /// Kline/candlestick bars for a symbol.<para />
        /// Klines are uniquely identified by their open time.<para />
        /// - If `startTime` and `endTime` are not sent, the most recent klines are returned.<para />
        /// Weight(IP): 1.
        /// </summary>
        /// <param name="symbol">Trading symbol, e.g. BNBUSDT.</param>
        /// <param name="interval">kline intervals.</param>
        /// <param name="startTime">UTC timestamp in ms.</param>
        /// <param name="endTime">UTC timestamp in ms.</param>
        /// <param name="limit">Default 500; max 1000.</param>
        /// <returns>Kline data.</returns>
        public async Task<string> KlineCandlestickData(string symbol, Interval interval, long? startTime = null, long? endTime = null, int? limit = null)
        {
            var result = await this.SendPublicAsync<string>(
                KLINE_CANDLESTICK_DATA,
                HttpMethod.Get,
                query: new Dictionary<string, object>
                {
                    { "symbol", symbol },
                    { "interval", interval },
                    { "startTime", startTime },
                    { "endTime", endTime },
                    { "limit", limit },
                });

            return result;
        }

        private const string EXCHANGE_INFORMATION = "/fapi/v1/exchangeInfo";

        /// <summary>
        /// Current exchange trading rules and symbol information.<para />
        /// - If any symbol provided in either symbol or symbols do not exist, the endpoint will throw an error.<para />
        /// Weight(IP): 10.
        /// </summary>
        /// <param name="symbol">Trading symbol, e.g. BNBUSDT.</param>
        /// <param name="symbols"></param>
        /// <returns>Current exchange trading rules and symbol information.</returns>
        public async Task<string> ExchangeInformation(string symbol = null, string symbols = null)
        {
            var result = await this.SendSignedAsync<string>(
                EXCHANGE_INFORMATION,
                HttpMethod.Get,
                query: new Dictionary<string, object>
                {
                    { "symbol", symbol },
                    { "symbols", symbols }
                });

            return result;
        }

        private const string RECENT_TRADES_LIST = "/fapi/v1/trades";

        /// <summary>
        /// Get recent trades.<para />
        /// Weight(IP): 1.
        /// </summary>
        /// <param name="symbol">Trading symbol, e.g. BNBUSDT.</param>
        /// <param name="limit">Default 500; max 1000.</param>
        /// <returns>Trade list.</returns>
        public async Task<string> RecentTradesList(string symbol, int? limit = null)
        {
            var result = await this.SendSignedAsync<string>(
                RECENT_TRADES_LIST,
                HttpMethod.Get,
                query: new Dictionary<string, object>
                {
                    { "symbol", symbol },
                    { "limit", limit },
                });

            return result;
        }

        private const string POSITION_RISKS = "/fapi/v2/positionRisk";

        /// <summary>
        /// Get POSITION RISKS.<para />
        /// Weight(IP): 1.
        /// </summary>
        /// <param name="symbol">Trading symbol, e.g. BNBUSDT.</param>
        /// <returns>list.</returns>
        public async Task<string> GetPositionRisk(string symbol)
        {
            var result = await this.SendSignedAsync<string>(
                POSITION_RISKS,
                HttpMethod.Get,
                query: new Dictionary<string, object>
                {
                    { "symbol", symbol },
                });

            return result;
        }

        private const string USER_TRADES = "/fapi/v1/userTrades";

        public async Task<string> GetUserTrades(string symbol,long? startTime = null, long? endTime = null, int? limit = null)
        {
            var result = await this.SendSignedAsync<string>(
                USER_TRADES,
                HttpMethod.Get,
                query: new Dictionary<string, object>
                {
                    { "symbol", symbol },
                    { "limit", limit },
                    { "endTime", endTime },
                    { "startTime", startTime },
                });

            return result;
        }
    }
}