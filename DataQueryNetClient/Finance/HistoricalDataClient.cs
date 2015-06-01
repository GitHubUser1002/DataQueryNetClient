using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Entities.Finance;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DataQueryNetClient.Finance
{
    public class HistoricalDataClient : IHistoricalDataClient
    {
        private HistoricalDataClient() { }

        public static IHistoricalDataClient Instance = new HistoricalDataClient();

        public IEnumerable<HistoricalQuote> GetHistory(string symbol, DateTime start, DateTime end)
        {
            string json;
            using (var web = new WebClient())
            {
                json =
                    web.DownloadString(string.Format(QueryDirectory.HistoricalDataQuery, symbol,
                        start.ToString("yyyy-MM-dd"), end.ToString("yyyy-MM-dd")));
            }
            var jObject = JObject.Parse(json);

            var jQuotes = jObject["query"]["results"]["quote"].Children();

            return jQuotes.Select(jQuote => JsonConvert.DeserializeObject<HistoricalQuote>(jQuote.ToString()));
        }
    }
}
