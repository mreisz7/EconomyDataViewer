namespace EconomyDataLoader.Models.BLS;

internal class BlsResults<T>
{
    [JsonPropertyName("series")]
    public List<BlsSeriesResult<T>> Series { get; set; } = [];
}
