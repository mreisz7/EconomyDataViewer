namespace EconomyDataLoader.Models.BLS;

public class BlsQuarterlyCpiRecord : BlsRecord, IPeriodicData
{
    // Seasonally Adjusted Unemployment Rate
    // LEU0252881600

    [JsonPropertyName("value")]
    [JsonConverter(typeof(StringToIntConverter))]
    public int Value { get; set; }

    public PeriodInfo GetPeriodInfo()
    {
        string quarter;
        switch (PeriodName)
        {
            case "1st Quarter":
                quarter = "Q1";
                break;
            case "2nd Quarter":
                quarter = "Q2";
                break;
            case "3rd Quarter":
                quarter = "Q3";
                break;
            case "4th Quarter":
                quarter = "Q4";
                break;
            default:
                throw new InvalidOperationException($"Unexpected period name: {PeriodName}");
        }

        return new PeriodInfo(Year, PeriodTypeEnum.Quarterly, quarter, $"{quarter} {Year}");
    }
}
