namespace EconomyDataLoader.Models.BEA;

public class BeaRequestNote
{
    [JsonPropertyName("NoteRef")]
    public string NoteRef { get; set; } = string.Empty;

    [JsonPropertyName("NoteText")]
    public string NoteText { get; set; } = string.Empty;
}