using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Entities.Finance;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DataQueryNetClient.Finance
{
    public class OptionChainClient : IOptionChainClient
    {
        private OptionChainClient() { }

        public static IOptionChainClient Instance = new OptionChainClient();

        public IEnumerable<OptionChainLink> GetQuote(string symbol)
        {
            var years = Enumerable.Range(DateTime.Now.Year, 2);

            using (var web = new WebClient())
            {
                foreach (var year in years)
                {
                    var json = web.DownloadString(string.Format(QueryDirectory.OptionChainQuery, symbol, year));
                    var jObject = JObject.Parse(json);

                    var jPuts = jObject["puts"].Children();

                    foreach (var jPut in jPuts)
                    {
                        var put =
                            JsonConvert.DeserializeObject<OptionChainLink>(jPut.ToString().Replace("\"-\"", "\"\""));
                        put.Symbol = symbol;
                        put.Type = "Put";
                        yield return put;
                    }

                    var jCalls = jObject["calls"].Children();

                    foreach (var jCall in jCalls)
                    {
                        var call =
                            JsonConvert.DeserializeObject<OptionChainLink>(jCall.ToString().Replace("\"-\"", "\"\""));
                        call.Symbol = symbol;
                        call.Type = "Call";
                        yield return call;
                    }
                }

            }
        }
    }
}
