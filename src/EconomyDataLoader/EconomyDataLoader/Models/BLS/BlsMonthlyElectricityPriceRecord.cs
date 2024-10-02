namespace EconomyDataLoader.Models.BLS;

public class BlsMonthlyElectricityPriceRecord : BlsRecord
{
    // Seasonally Adjusted Unemployment Rate
    // https://data.bls.gov/dataViewer/view/timeseries/APU000072610

    [JsonPropertyName("value")]
    [JsonConverter(typeof(StringToFloatConverter))]
    public float Value { get; set; }
}
