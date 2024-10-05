namespace EconomyDataLoader.Models.Output;

public class Summary
{
    [JsonPropertyName("dateMin")]
    public DateOnly DateMin { get; set; }

    [JsonPropertyName("dateMax")]
    public DateOnly DateMax { get; set; }
}
