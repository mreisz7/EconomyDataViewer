using EconomyDataLoader.Data;
using EconomyDataLoader.Models.BLS;
using EconomyDataLoader.Models.StockIndex;
using Microsoft.Extensions.Configuration;

// Create a new instance of ConfigurationBuilder
var configBuilder = new ConfigurationBuilder();
configBuilder.SetBasePath(Directory.GetCurrentDirectory())
             .AddJsonFile("appsettings.json")
             .AddUserSecrets<Program>();
var configuration = configBuilder.Build();

// Get the value from appsettings.json using the key "BlsApiKey"
var apiKey = configuration["BlsApiKey"];

// Fetch BLS data
var unemploymentData = await FetchBlsData.FetchDataAsync<BlsMonthlyUnemploymentRecord>("LNS14000000", apiKey!);
List<BlsMonthlyUnemploymentRecord> sortedUnemploymentData = unemploymentData.OrderBy(r => r.Year).ThenBy(r => r.Period).ToList();

var CpiData = await FetchBlsData.FetchDataAsync<BlsQuarterlyCpiRecord>("LEU0252881600", apiKey!);
List<BlsQuarterlyCpiRecord> sortedCpiData = CpiData.OrderBy(r => r.Year).ThenBy(r => r.Period).ToList();

var GasolineData = await FetchBlsData.FetchDataAsync<BlsMonthlyGasolinePriceRecord>("APU000074714", apiKey!);
List<BlsMonthlyGasolinePriceRecord> sortedGasolineData = GasolineData.OrderBy(r => r.Year).ThenBy(r => r.Period).ToList();

var ElectricityData = await FetchBlsData.FetchDataAsync<BlsMonthlyElectricityPriceRecord>("APU000072610", apiKey!);
List<BlsMonthlyElectricityPriceRecord> sortedElectricityData = ElectricityData.OrderBy(r => r.Year).ThenBy(r => r.Period).ToList();

// Fetch Stock Index data
var SP500Data = await FetchStockIndexData.FetchDataAsync(FetchStockIndexData.StockIndex.SP500);
List<StockIndexMonthlyResultRecord> sortedSP500Data = SP500Data.OrderBy(r => r.RowDateTimestamp).ToList();

var NASDAQData = await FetchStockIndexData.FetchDataAsync(FetchStockIndexData.StockIndex.NASDAQ);
List<StockIndexMonthlyResultRecord> sortedNASDAQData = NASDAQData.OrderBy(r => r.RowDateTimestamp).ToList();

var DOWJONESData = await FetchStockIndexData.FetchDataAsync(FetchStockIndexData.StockIndex.DOWJONES);
List<StockIndexMonthlyResultRecord> sortedDOWJONESData = DOWJONESData.OrderBy(r => r.RowDateTimestamp).ToList();

Console.WriteLine("Finished");