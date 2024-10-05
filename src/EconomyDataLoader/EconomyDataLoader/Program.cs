// Create a new instance of ConfigurationBuilder
var configBuilder = new ConfigurationBuilder();
configBuilder.SetBasePath(Directory.GetCurrentDirectory())
             .AddJsonFile("appsettings.json")
             .AddUserSecrets<Program>();
var configuration = configBuilder.Build();

// Fetch BLS data
string blsApiKey = configuration["BlsApiKey"] ?? throw new NullReferenceException("BLS API Key not provided.");

// Unemployment Rate - https://data.bls.gov/dataViewer/view/timeseries/LNS14000000
List<BlsMonthlyUnemploymentRecord> unemploymentData = await FetchBlsData.FetchDataAsync<BlsMonthlyUnemploymentRecord>("LNS14000000", blsApiKey!);

// CPI - https://data.bls.gov/dataViewer/view/timeseries/LEU0252881600
List<BlsQuarterlyCpiRecord> cpiData = await FetchBlsData.FetchDataAsync<BlsQuarterlyCpiRecord>("LEU0252881600", blsApiKey!);

// Gasoline - https://data.bls.gov/dataViewer/view/timeseries/APU000074714
List<BlsMonthlyGasolinePriceRecord> gasolineData = await FetchBlsData.FetchDataAsync<BlsMonthlyGasolinePriceRecord>("APU000074714", blsApiKey!);

// Electricity - https://data.bls.gov/dataViewer/view/timeseries/APU000072610
List<BlsMonthlyElectricityPriceRecord> electricityData = await FetchBlsData.FetchDataAsync<BlsMonthlyElectricityPriceRecord>("APU000072610", blsApiKey!);

// Fetch Stock Index data

// Investing.com (S&P 500) - https://www.investing.com/indices/us-spx-500-historical-data
List<StockIndexMonthlyResultRecord> sp500Data = await FetchStockIndexData.FetchDataAsync(FetchStockIndexData.StockIndex.SP500);

// Investing.com (Nasdaq) - https://www.investing.com/indices/nq-100-historical-data
List<StockIndexMonthlyResultRecord> nasdaqData = await FetchStockIndexData.FetchDataAsync(FetchStockIndexData.StockIndex.NASDAQ);

// Investing.com (Dow Jones) - https://www.investing.com/indices/us-30-historical-data
List<StockIndexMonthlyResultRecord> dowJonesData = await FetchStockIndexData.FetchDataAsync(FetchStockIndexData.StockIndex.DOWJONES);

// Fetch BEA data
string beaApiKey = configuration["BeaApiKey"] ?? throw new NullReferenceException("BEA API Key not provided.");

// Per-Capita Personal Income  - https://apps.bea.gov/api/data/
List<BeaDataRecord> beaData = await FetchBeaData.FetchDataAsync(beaApiKey!);

Console.WriteLine("Finished");
