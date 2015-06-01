using System.Collections.Generic;
using Entities.Finance;

namespace DataQueryNetClient.Finance
{
    public interface IOptionChainClient
    {
        IEnumerable<OptionChainLink> GetQuote(string symbol);
    }
}
