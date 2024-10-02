namespace EconomyDataLoader.Models.BLS;

internal class BeaRequestResult<T>
{
    [JsonPropertyName("status")]
    public string Status { get; set; } = string.Empty;

    [JsonPropertyName("responseTime")]
    public int ResponseTime { get; set; }

    [JsonPropertyName("message")]
    public List<string> Message { get; set; } = [];

    [JsonPropertyName("Results")]
    public BlsResults<T> Results { get; set; } = new();
}
