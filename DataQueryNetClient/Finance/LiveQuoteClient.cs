using System.Linq;
using System.Net;
using Entities.Finance;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DataQueryNetClient.Finance
{
    public class LiveQuoteClient : ILiveQuoteClient
    {
        private LiveQuoteClient() { }

        public static ILiveQuoteClient Instance = new LiveQuoteClient();

        public LiveQuote GetQuote(string symbol)
        {
            string json;
            using (var web = new WebClient())
            {
                json =
                    web.DownloadString(string.Format(QueryDirectory.LiveQuoteQuery, symbol));
            }
            var jObject = JObject.Parse(json);

            var jQuote = jObject["query"]["results"]["quote"];

            return jQuote != null ? JsonConvert.DeserializeObject<LiveQuote>(jQuote.ToString()) : null;
        }
    }
}
