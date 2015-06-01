using System;
using System.Collections.Generic;
using Entities.Finance;

namespace DataQueryNetClient.Finance
{
    public interface IHistoricalDataClient
    {
        IEnumerable<HistoricalQuote> GetHistory(string symbol, DateTime start, DateTime end);
    }
}
