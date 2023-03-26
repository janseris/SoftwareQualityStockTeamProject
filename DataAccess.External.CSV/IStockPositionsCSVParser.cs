using DataAccess.External.CSV.Models;

namespace DataAccess.External.CSV
{
    public interface IStockPositionsCSVParser
    {
        IList<StockPositionRecord> Parse(byte[] csv);
    }
}
