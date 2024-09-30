using EconomyDataLoader.Utilities;
using System.Text.Json.Serialization;

namespace EconomyDataLoader.Models.StockIndex;

public class StockIndexRequestSummary
{
    [JsonPropertyName("last_highest")]
    [JsonConverter(typeof(StringToFloatConverter))]
    public float LastHighest { get; set; }

    [JsonPropertyName("last_lowest")]
    [JsonConverter(typeof(StringToFloatConverter))]
    public float LastLowest { get; set; }

    [JsonPropertyName("last_difference")]
    [JsonConverter(typeof(StringToFloatConverter))]
    public float LastDifference { get; set; }

    [JsonPropertyName("last_avarage_total")]
    [JsonConverter(typeof(StringToFloatConverter))]
    public float LastAverageTotal { get; set; }

    [JsonPropertyName("last_change_percent")]
    [JsonConverter(typeof(StringToFloatConverter))]
    public float LastChangePercent { get; set; }
}