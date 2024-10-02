namespace EconomyDataLoader.Models.BLS;

public class BlsMonthlyGasolinePriceRecord : BlsRecord
{
    // Seasonally Adjusted Unemployment Rate
    // https://data.bls.gov/dataViewer/view/timeseries/APU000074714

    [JsonPropertyName("value")]
    [JsonConverter(typeof(StringToFloatConverter))]
    public float Value { get; set; }
}
