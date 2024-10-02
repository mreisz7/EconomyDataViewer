namespace EconomyDataLoader.Models.BLS;

public class BlsQuarterlyCpiRecord : BlsRecord
{
    // Seasonally Adjusted Unemployment Rate
    // LEU0252881600

    [JsonPropertyName("value")]
    [JsonConverter(typeof(StringToIntConverter))]
    public int Value { get; set; }
}
