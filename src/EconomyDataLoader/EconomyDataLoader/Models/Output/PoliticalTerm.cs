namespace EconomyDataLoader.Models.Output;

public class PoliticalTerm
{
    [JsonPropertyName("president")]
    public string President { get; set; } = string.Empty;

    [JsonPropertyName("presendentialPartyControl")]
    public PartyEnum PresendentialPartyControl { get; set; } = PartyEnum.Other;

    [JsonPropertyName("housePartyControl")]
    public PartyEnum HousePartyControl { get; set; } = PartyEnum.Other;

    [JsonPropertyName("senatePartyControl")]
    public PartyEnum SenatePartyControl { get; set; } = PartyEnum.Other;

    [JsonPropertyName("termStart")]
    public DateOnly TermStart { get; set; }

    [JsonPropertyName("termEnd")]
    public DateOnly TermEnd { get; set; }

    public PoliticalTerm() {}

    public PoliticalTerm(string president, 
                         PartyEnum presedentialParty,
                         PartyEnum houseParty,
                         PartyEnum senateParty,
                         DateOnly termStart,
                         DateOnly termEnd)
    {
        President = president;
        PresendentialPartyControl = presedentialParty;
        HousePartyControl = houseParty;
        SenatePartyControl = senateParty;
        TermStart = termStart;
        TermEnd = termEnd;
    }
}
