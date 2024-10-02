namespace EconomyDataLoader.Models.BEA;

public class BeaDataRecord
{
    [JsonPropertyName("Code")]
    public string Code { get; set; } = string.Empty;

    [JsonPropertyName("GeoFips")]
    public string GeoFips { get; set; } = string.Empty;

    [JsonPropertyName("GeoName")]
    public string GeoName { get; set; } = string.Empty;

    [JsonPropertyName("TimePeriod")]
    public string TimePeriod { get; set; } = string.Empty;

    [JsonPropertyName("CL_UNIT")]
    public string ClUnit { get; set; } = string.Empty;

    [JsonPropertyName("UNIT_MULT")]
    [JsonConverter(typeof(StringToFloatConverter))]
    public float UnitMult { get; set; }

    [JsonPropertyName("DataValue")]
    [JsonConverter(typeof(StringToIntConverter))]
    public int DataValue { get; set; }

    [JsonPropertyName("NoteRef")]
    public string NoteRef { get; set; } = string.Empty;

}