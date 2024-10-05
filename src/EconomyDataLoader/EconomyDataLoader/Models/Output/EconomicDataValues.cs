namespace EconomyDataLoader.Models.Output;

public class EconomicDataValues
{
    [JsonPropertyName("bea")]
    public BeaDataValues? Bea { get; set; } = null;

    [JsonPropertyName("bls")]
    public BlsDataValues? Bls { get; set; } = null;

    [JsonPropertyName("stockIndexes")]
    public StockIndexDataValues? StockIndexes { get; set; } = null;
}
