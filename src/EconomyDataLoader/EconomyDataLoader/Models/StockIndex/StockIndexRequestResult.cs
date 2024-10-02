namespace EconomyDataLoader.Models.StockIndex;

internal class StockIndexRequestResult
{
    [JsonPropertyName("data")]
    public List<StockIndexMonthlyResultRecord> Data { get; set; } = [];

    [JsonPropertyName("summary")]
    public StockIndexRequestSummary Summary { get; set; } = new();
}
