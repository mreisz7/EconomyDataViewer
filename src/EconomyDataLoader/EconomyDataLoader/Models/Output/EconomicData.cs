namespace EconomyDataLoader.Models.Output;

public class EconomicData(int year, PeriodTypeEnum periodType, string period, string periodLabel) : PeriodInfo(year, periodType, period, periodLabel)
{
    [JsonPropertyName("data")]
    public EconomicDataValues Data { get; set; } = new();
}
