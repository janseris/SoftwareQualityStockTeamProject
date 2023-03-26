namespace DataAccess.External.CSV
{
    public interface IStockPositionsCSVDAO
    {
        /// <summary>
        /// Loads records data in CSV format
        /// </summary>
        Task<byte[]> GetTodayRecordsCSV();
    }
}
