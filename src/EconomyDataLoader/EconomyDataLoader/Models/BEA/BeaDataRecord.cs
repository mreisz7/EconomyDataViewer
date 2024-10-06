namespace EconomyDataLoader.Models.BEA;

public class BeaDataRecord : IPeriodicData
{
    [JsonPropertyName("Code")]
    public string Code { get; set; } = string.Empty;

    [JsonPropertyName("GeoFips")]
    public string GeoFips { get; set; } = string.Empty;

    [JsonPropertyName("GeoName")]
    public string GeoName { get; set; } = string.Empty;

    [JsonPropertyName("TimePeriod")]
    [JsonConverter(typeof(StringToIntConverter))]
    public int TimePeriod { get; set; }

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

    public PeriodInfo GetPeriodInfo()
    {
        return new PeriodInfo(TimePeriod, PeriodTypeEnum.Annual, TimePeriod.ToString(), TimePeriod.ToString());   
    }
}