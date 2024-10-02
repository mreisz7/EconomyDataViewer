namespace EconomyDataLoader.Models.BLS;

public class BlsMonthlyUnemploymentRecord : BlsRecord
{
    // Seasonally Adjusted Unemployment Rate
    // https://data.bls.gov/dataViewer/view/timeseries/LNS14000000

    [JsonPropertyName("value")]
    [JsonConverter(typeof(StringToFloatConverter))]
    public float Value { get; set; }
}
