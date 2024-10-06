namespace EconomyDataLoader.Models.BLS;

public class BlsMonthlyUnemploymentRecord : BlsRecord, IPeriodicData
{
    // Seasonally Adjusted Unemployment Rate
    // https://data.bls.gov/dataViewer/view/timeseries/LNS14000000

    [JsonPropertyName("value")]
    [JsonConverter(typeof(StringToFloatConverter))]
    public float Value { get; set; }

    public PeriodInfo GetPeriodInfo()
    {
        return new PeriodInfo(Year, PeriodTypeEnum.Monthly, PeriodName, $"{PeriodName} {Year}");
    }
}
