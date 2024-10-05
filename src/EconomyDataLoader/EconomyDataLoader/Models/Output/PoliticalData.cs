namespace EconomyDataLoader.Models.Output;

public class PoliticalData
{
    // Source: Wikipedia
    // https://en.wikipedia.org/wiki/Party_divisions_of_United_States_Congresses#:~:text=The%20following%20table%20lists%20the%20party%20divisions%20for%20each%20United

    [JsonPropertyName("terms")]
    public List<PoliticalTerm> Terms { get; init; } = [
            // 1981-1983 (97th Congress)
            new PoliticalTerm("Ronald Reagan", PartyEnum.Republican, PartyEnum.Democrat, PartyEnum.Republican, new(1981, 1, 20), new(1983, 1, 19)),
            // 1983-1985 (98th Congress)
            new PoliticalTerm("Ronald Reagan", PartyEnum.Republican, PartyEnum.Democrat, PartyEnum.Republican, new(1983, 1, 20), new(1985, 1, 19)),
            // 1985-1987 (99th Congress)
            new PoliticalTerm("Ronald Reagan", PartyEnum.Republican, PartyEnum.Democrat, PartyEnum.Republican, new(1985, 1, 20), new(1987, 1, 19)),
            // 1987-1989 (100th Congress)
            new PoliticalTerm("Ronald Reagan", PartyEnum.Republican, PartyEnum.Democrat, PartyEnum.Democrat, new(1987, 1, 20), new(1989, 1, 19)),
            // 1989-1991 (101st Congress)
            new PoliticalTerm("George H. W. Bush", PartyEnum.Republican, PartyEnum.Democrat, PartyEnum.Democrat, new(1989, 1, 20), new(1991, 1, 19)),
            // 1991-1993 (102nd Congress)
            new PoliticalTerm("George H. W. Bush", PartyEnum.Republican, PartyEnum.Democrat, PartyEnum.Democrat, new(1991, 1, 20), new(1993, 1, 19)),
            // 1993-1995 (103rd Congress)
            new PoliticalTerm("Bill Clinton", PartyEnum.Democrat, PartyEnum.Democrat, PartyEnum.Democrat, new(1993, 1, 20), new(1995, 1, 19)),
            // 1995-1997 (104th Congress)
            new PoliticalTerm("Bill Clinton", PartyEnum.Democrat, PartyEnum.Republican, PartyEnum.Republican, new(1995, 1, 20), new(1997, 1, 19)),
            // 1997-1999 (105th Congress)
            new PoliticalTerm("Bill Clinton", PartyEnum.Democrat, PartyEnum.Republican, PartyEnum.Republican, new(1997, 1, 20), new(1999, 1, 19)),
            // 1999-2001 (106th Congress)
            new PoliticalTerm("Bill Clinton", PartyEnum.Democrat, PartyEnum.Republican, PartyEnum.Republican, new(1999, 1, 20), new(2001, 1, 19)),
            // 2001-2003 (107th Congress)
            new PoliticalTerm("George W. Bush", PartyEnum.Republican, PartyEnum.Republican, PartyEnum.Democrat, new(2001, 1, 20), new(2003, 1, 19)),
            // 2003-2005 (108th Congress)
            new PoliticalTerm("George W. Bush", PartyEnum.Republican, PartyEnum.Republican, PartyEnum.Republican, new(2003, 1, 20), new(2005, 1, 19)),
            // 2005-2007 (109th Congress)
            new PoliticalTerm("George W. Bush", PartyEnum.Republican, PartyEnum.Republican, PartyEnum.Republican, new(2005, 1, 20), new(2007, 1, 19)),
            // 2007-2009 (110th Congress)
            new PoliticalTerm("George W. Bush", PartyEnum.Republican, PartyEnum.Democrat, PartyEnum.Democrat, new(2007, 1, 20), new(2009, 1, 19)),
            // 2009-2011 (111th Congress)
            new PoliticalTerm("Barack Obama", PartyEnum.Democrat, PartyEnum.Democrat, PartyEnum.Democrat, new(2009, 1, 20), new(2011, 1, 19)),
            // 2011-2013 (112th Congress)
            new PoliticalTerm("Barack Obama", PartyEnum.Democrat, PartyEnum.Republican, PartyEnum.Democrat, new(2011, 1, 20), new(2013, 1, 19)),
            // 2013-2015 (113th Congress)
            new PoliticalTerm("Barack Obama", PartyEnum.Democrat, PartyEnum.Republican, PartyEnum.Democrat, new(2013, 1, 20), new(2015, 1, 19)),
            // 2015-2017 (114th Congress)
            new PoliticalTerm("Barack Obama", PartyEnum.Democrat, PartyEnum.Republican, PartyEnum.Republican, new(2015, 1, 20), new(2017, 1, 19)),
            // 2017-2019 (115th Congress)
            new PoliticalTerm("Donald Trump", PartyEnum.Republican, PartyEnum.Republican, PartyEnum.Republican, new(2017, 1, 20), new(2019, 1, 19)),
            // 2019-2021 (116th Congress)
            new PoliticalTerm("Donald Trump", PartyEnum.Republican, PartyEnum.Democrat, PartyEnum.Republican, new(2019, 1, 20), new(2021, 1, 19)),
            // 2021-2023 (117th Congress)
            new PoliticalTerm("Joe Biden", PartyEnum.Democrat, PartyEnum.Democrat, PartyEnum.Democrat, new(2021, 1, 20), new(2023, 1, 19)),
            // 2023-2025 (118th Congress)
            new PoliticalTerm("Joe Biden", PartyEnum.Democrat, PartyEnum.Republican, PartyEnum.Democrat, new(2023, 1, 20), new(2025, 1, 19)),
        ];
}
