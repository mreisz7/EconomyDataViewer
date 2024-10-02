namespace EconomyDataLoader.Models.BEA;

public class BeaApiResult
{
    [JsonPropertyName("Request")]
    public BeaRequestSummary Request { get; set; } = new();

    [JsonPropertyName("Results")]
    public BeaRequestResults Results { get; set; } = new();
}