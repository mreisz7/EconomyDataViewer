namespace EconomyDataLoader.Data;

internal static class FetchBlsData
{
    public static async Task<List<T>> FetchDataAsync<T>(string seriesId, string registrationKey) where T : BlsRecord
    {
        List<T> results = [];
        var client = new HttpClient();

        for (int i = 1980; i + 10 <= DateTime.Now.Year + 9; i += 10)
        {
            string URL = string.Format(
                "https://api.bls.gov/publicAPI/v2/timeseries/data/{0}?registrationkey={1}&startyear={2}&endyear={3}&catalog=true",
                seriesId,
                registrationKey,
                i,
                Math.Min(i + 9, DateTime.Now.Year));

            Console.WriteLine(URL);
            try
            {
                var response = await client.GetAsync(URL);
                var content = await response.Content.ReadAsStringAsync();
                var blsData = JsonSerializer.Deserialize<BeaRequestResult<T>>(content);
                results.AddRange(blsData!.Results.Series[0].Data);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
        return results.OrderBy(r => r.Year).ThenBy(r => r.Period).ToList();
    }
}
