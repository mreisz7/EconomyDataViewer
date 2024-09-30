using EconomyDataLoader.Utilities;
using System.Text.Json.Serialization;

namespace EconomyDataLoader.Models.StockIndex;

public class StockIndexMonthlyResultRecord
{
    [JsonPropertyName("rowDate")]
    public string RowDate { get; set; } = string.Empty;

    [JsonPropertyName("rowDateTimestamp")]
    public DateTime RowDateTimestamp { get; set; }

    [JsonPropertyName("last_close")]
    [JsonConverter(typeof(StringToFloatConverter))]
    public float LastClose { get; set; }

    [JsonPropertyName("last_open")]
    [JsonConverter(typeof(StringToFloatConverter))]
    public float LastOpen { get; set; }

    [JsonPropertyName("last_max")]
    [JsonConverter(typeof(StringToFloatConverter))]
    public float LastMax { get; set; }

    [JsonPropertyName("last_min")]
    [JsonConverter(typeof(StringToFloatConverter))]
    public float LastMin { get; set; }

    [JsonPropertyName("volumeRaw")]
    public long Volume { get; set; }

    [JsonPropertyName("change_precent")]
    [JsonConverter(typeof(StringToFloatConverter))]
    public float ChangePercent { get; set; }
}