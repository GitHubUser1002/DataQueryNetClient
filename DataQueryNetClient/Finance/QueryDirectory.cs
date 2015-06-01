namespace DataQueryNetClient.Finance
{
    internal static class QueryDirectory
    {
        public static string HistoricalDataQuery =
            "https://query.yahooapis.com/v1/public/yql?q=select%20*%20from%20yahoo.finance.historicaldata%20where%20symbol%20%3D%20%22{0}%22%20and%20startDate%20%3D%20%22{1}%22%20and%20endDate%20%3D%20%22{2}%22&format=json&diagnostics=true&env=store%3A%2F%2Fdatatables.org%2Falltableswithkeys&callback=";
    
        public static string LiveQuoteQuery =
            "https://query.yahooapis.com/v1/public/yql?q=select%20*%20from%20yahoo.finance.quote%20where%20symbol%20%3D%20%22{0}%22&format=json&diagnostics=true&env=store%3A%2F%2Fdatatables.org%2Falltableswithkeys&callback=";

        public static string OptionChainExpirationQuery = "http://www.google.com/finance/option_chain?q={0}&output=json";

        public static string OptionChainQuery = "http://www.google.com/finance/option_chain?q={0}&output=json&expy={1}";
    }
}
