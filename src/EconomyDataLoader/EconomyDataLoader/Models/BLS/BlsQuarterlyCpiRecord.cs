using EconomyDataLoader.Utilities;
using System.Text.Json.Serialization;

namespace EconomyDataLoader.Models.BLS;

public class BlsQuarterlyCpiRecord
{
    // Seasonally Adjusted Unemployment Rate
    // LEU0252881600

    [JsonPropertyName("year")]
    public string Year { get; set; } = string.Empty;

    [JsonPropertyName("period")]
    public string Period { get; set; } = string.Empty;

    [JsonPropertyName("periodName")]
    public string PeriodName { get; set; } = string.Empty;

    [JsonPropertyName("value")]
    [JsonConverter(typeof(StringToIntConverter))]
    public int Value { get; set; }

}
