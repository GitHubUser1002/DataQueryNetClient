namespace Entities.Finance
{
    public class LiveQuote
    {
        public string Symbol { get; set; }
        public int AverageDailyVolume { get; set; }
        public double Change { get; set;  }
        public double DaysLow { get; set; }
        public double DaysHigh { get; set; }
        public double YearLow { get; set; }
        public double YearHigh { get; set; }
        public string MarketCapitalization { get; set; }
        public double LastTradePriceOnly { get; set; }
        public string Name { get; set; }
        public int Volume { get; set; }
        public string StockExchange { get; set; }
    }
}
