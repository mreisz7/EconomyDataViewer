namespace EconomyDataLoader.Models.Output;

public class PeriodInfo(int year, PeriodTypeEnum periodType, string period, string periodLabel) : IEquatable<PeriodInfo>
{
    [JsonPropertyName("year")]
    public int Year { get; set; } = year;

    [JsonPropertyName("periodType")]
    public PeriodTypeEnum PeriodType { get; set; } = periodType;

    [JsonPropertyName("period")]
    public string Period { get; set; } = period;

    [JsonPropertyName("periodLabel")]
    public string PeriodLabel { get; set; } = periodLabel;

    [JsonPropertyName("periodNum")]
    public int PeriodNum { get => GetPeriodNum(); }

    public int GetPeriodNum() => Period switch
    {
        "January" => 1,
        "February" => 2,
        "March" => 3,
        "April" => 4,
        "May" => 5,
        "June" => 6,
        "July" => 7,
        "August" => 8,
        "September" => 9,
        "October" => 10,
        "November" => 11,
        "December" => 12,
        "Q1" => 1,
        "Q2" => 4,
        "Q3" => 7,
        "Q4" => 10,
        _ => 0
    };

    public override bool Equals(object? obj)
    {
        return Equals(obj as PeriodInfo);
    }

    public bool Equals(PeriodInfo? other)
    {
        if (other == null)
            return false;

        return Year == other.Year &&
               PeriodType == other.PeriodType &&
               Period == other.Period &&
               PeriodLabel == other.PeriodLabel;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Year, PeriodType, Period, PeriodLabel);
    }
}
