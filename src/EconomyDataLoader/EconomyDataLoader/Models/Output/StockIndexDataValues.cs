namespace EconomyDataLoader.Models.Output;

public class StockIndexDataValues
{
    [JsonPropertyName("sp500")]
    public float? Sp500 { get; set; } = null;

    [JsonPropertyName("dowJones")]
    public float? DowJones { get; set; } = null;

    [JsonPropertyName("nasdaq")]
    public float? Nasdaq { get; set; } = null;
}
