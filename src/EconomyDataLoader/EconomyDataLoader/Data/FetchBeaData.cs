namespace EconomyDataLoader.Data;

internal static class FetchBeaData
{
    public static async Task<List<BeaDataRecord>> FetchDataAsync(string registrationKey)
    {
        List<BeaDataRecord> results = [];
        var client = new HttpClient();

        string URL = string.Format(
            "https://apps.bea.gov/api/data/?UserID={0}&method=GetData&datasetname=Regional&TableName=CAINC1&LineCode=3&Year=ALL&GeoFips=00000&ResultFormat=json",
            registrationKey);

        Console.WriteLine(URL);

        try
        {
            var response = await client.GetAsync(URL);
            var content = await response.Content.ReadAsStringAsync();
            var beaData = JsonSerializer.Deserialize<BeaRequestResult>(content);
            results.AddRange(beaData!.BeaApi.Results.Data);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        
        return results.OrderBy(r => r.TimePeriod).ToList();
    }
}
