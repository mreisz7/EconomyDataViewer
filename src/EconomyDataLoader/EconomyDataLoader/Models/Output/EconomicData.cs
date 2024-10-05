namespace EconomyDataLoader.Models.Output;

public class EconomicData
{
    [JsonPropertyName("year")]
    public int Year { get; set; }

    [JsonPropertyName("periodType")]
    public string PeriodType { get; set; } = string.Empty;

    [JsonPropertyName("period")]
    public string Period { get; set; } = string.Empty;

    [JsonPropertyName("periodLabel")]
    public string PeriodLabel { get; set; } = string.Empty;

    [JsonPropertyName("data")]
    public EconomicDataValues Data { get; set; } = new();
}
