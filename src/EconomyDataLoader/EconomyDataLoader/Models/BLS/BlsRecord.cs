namespace EconomyDataLoader.Models.BLS;

public class BlsRecord
{
    [JsonPropertyName("year")]
    [JsonConverter(typeof(StringToIntConverter))]
    public int Year { get; set; }

    [JsonPropertyName("period")]
    public string Period { get; set; } = string.Empty;

    [JsonPropertyName("periodName")]
    public string PeriodName { get; set; } = string.Empty;
}