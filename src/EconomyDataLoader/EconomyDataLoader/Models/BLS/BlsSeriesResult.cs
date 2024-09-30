using System.Text.Json.Serialization;

namespace EconomyDataLoader.Models.BLS;

internal class BlsSeriesResult<T>
{
    [JsonPropertyName("seriesID")]
    public string SeriesId { get; set; } = string.Empty;

    [JsonPropertyName("data")]
    public List<T> Data { get; set; } = [];
}
