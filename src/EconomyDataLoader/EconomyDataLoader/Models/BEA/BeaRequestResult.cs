namespace EconomyDataLoader.Models.BEA;

internal class BeaRequestResult
{
    [JsonPropertyName("BEAAPI")]
    public BeaApiResult BeaApi { get; set; } = new BeaApiResult();
}
