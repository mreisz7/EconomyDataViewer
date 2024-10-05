namespace EconomyDataLoader.Models.Output;

public class BlsDataValues
{
    [JsonPropertyName("unemploymentData")]
    public int? UnemploymentData { get; set; } = null;

    [JsonPropertyName("cpi")]
    public float? Cpi { get; set; } = null;

    [JsonPropertyName("gasoline")]
    public float? Gasoline { get; set; } = null;

    [JsonPropertyName("electricity")]
    public float? Electricity { get; set; } = null;
}
