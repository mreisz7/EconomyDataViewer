namespace EconomyDataLoader.Data;

internal static class FetchStockIndexData
{
    public static async Task<List<StockIndexMonthlyResultRecord>> FetchDataAsync(StockIndex stockIndex)
    {
        List<StockIndexMonthlyResultRecord> results = [];
        var client = new HttpClient();
        client.DefaultRequestHeaders.Add("domain-id", "www");
        client.DefaultRequestHeaders.Add("user-agent", "restclient");

        string URL = string.Format(
            "https://api.investing.com/api/financialdata/historical/{0}?start-date=1980-01-01&end-date={1}&time-frame=Monthly&add-missing-rows=false",
            GetSeriesId(stockIndex),
            DateTime.Now.ToString("yyyy-MM-dd"));

        Console.WriteLine(URL);

        try
        {
            var response = await client.GetAsync(URL);
            var content = await response.Content.ReadAsStringAsync();
            var stockIndexData = JsonSerializer.Deserialize<StockIndexRequestResult>(content);
            results = stockIndexData!.Data;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        
        return results.OrderBy(r => r.RowDateTimestamp).ToList();
    }

    public enum StockIndex
    {
        SP500,
        NASDAQ,
        DOWJONES
    }

    private static string GetSeriesId(StockIndex stockIndex)
    {
        return stockIndex switch
        {
            StockIndex.SP500 => "166",
            StockIndex.NASDAQ => "14958",
            StockIndex.DOWJONES => "169",
            _ => throw new ArgumentException("Invalid StockIndex")
        };
    }
}
