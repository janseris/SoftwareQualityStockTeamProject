namespace DataAccess.External.CSV
{
    /// <summary>
    /// Retrieves CSV with stock positions from an online source
    /// </summary>
    public class StockPositionsCSVDAO : IStockPositionsCSVDAO
    {
        private readonly HttpClient _httpClient;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="httpClient">with base address (URL) pointing to the requested resource</param>
        public StockPositionsCSVDAO(HttpClient httpClient)
        {
            if (httpClient.BaseAddress is null)
            {
                throw new ArgumentException($"{nameof(httpClient.BaseAddress)} must be set");
            }
            _httpClient = httpClient;
        }

        public async Task<byte[]> GetTodayRecordsCSV()
        {
            return await GetCSV(_httpClient.BaseAddress! /* "!" = assert not null */);
        }

        private async Task<byte[]> GetCSV(Uri url)
        {
            return await _httpClient.GetByteArrayAsync(url);
        }
    }
}
