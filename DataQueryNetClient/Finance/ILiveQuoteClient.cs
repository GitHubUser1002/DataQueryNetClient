using Entities.Finance;

namespace DataQueryNetClient.Finance
{
    public interface ILiveQuoteClient
    {
        LiveQuote GetQuote(string symbol);
    }
}
