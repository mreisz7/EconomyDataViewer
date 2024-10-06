namespace EconomyDataLoader.Models.Output;

public class DataSummary
{
    [JsonPropertyName("dateMin")]
    public DateOnly DateMin { get; set; }

    [JsonPropertyName("dateMax")]
    public DateOnly DateMax { get; set; }
}
