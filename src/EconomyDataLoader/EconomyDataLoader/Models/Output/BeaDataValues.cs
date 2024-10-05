namespace EconomyDataLoader.Models.Output;

public class BeaDataValues
{
    [JsonPropertyName("personalIncome")]
    public int? PersonalIncome { get; set; } = null;
}
