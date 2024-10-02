using System.Text.Json.Serialization;

namespace EconomyDataLoader.Models.BEA;

public class BeaRequestResults
{
    [JsonPropertyName("Statistic")]
    public string Statistic { get; set; } = string.Empty;

    [JsonPropertyName("UnitOfMeasure")]
    public string UnitOfMeasure { get; set; } = string.Empty;

    [JsonPropertyName("PublicTable")]
    public string PublicTable { get; set; } = string.Empty;

    [JsonPropertyName("UTCProductionTime")]
    public string UtcProductionTime { get; set; } = string.Empty;

    [JsonPropertyName("NoteRef")]
    public string NoteRef { get; set; } = string.Empty;

    [JsonPropertyName("Data")]
    public List<BeaDataRecord> Data { get; set; } = new();

    [JsonPropertyName("Notes")]
    public List<BeaRequestNote> Notes { get; set; } = new();
}