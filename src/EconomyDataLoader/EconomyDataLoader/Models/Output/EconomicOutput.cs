namespace EconomyDataLoader.Models.Output;

public class EconomicOutput
{
    [JsonPropertyName("summary")]
    public Summary Summary { get; set; } = new();

    [JsonPropertyName("politicalData")]
    public PoliticalData PoliticalData { get; set; } = new();

    [JsonPropertyName("economicDataValues")]
    public EconomicDataValues EconomicDataValues { get; set; } = new();
}
