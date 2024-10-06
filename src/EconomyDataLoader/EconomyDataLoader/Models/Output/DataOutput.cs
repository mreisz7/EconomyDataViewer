namespace EconomyDataLoader.Models.Output;

public class DataOutput
{
    [JsonPropertyName("summary")]
    public DataSummary Summary { get; set; } = new();

    [JsonPropertyName("politicalData")]
    public PoliticalData PoliticalData { get; set; } = new();

    [JsonPropertyName("economicData")]
    public List<EconomicData> EconomicData { get; set; } = [];

    private Dictionary<PeriodInfo, EconomicData> _economicDataDict = new();

    public DataOutput() {}

    public DataOutput AddBeaPersonalIncomeData(List<BeaDataRecord> beaDataRecords)
    {
        foreach (var record in beaDataRecords)
        {
            PeriodInfo periodInfo = record.GetPeriodInfo();
            if (!_economicDataDict.ContainsKey(periodInfo))
            {
                _economicDataDict[periodInfo] = new(periodInfo.Year, periodInfo.PeriodType, periodInfo.Period, periodInfo.PeriodLabel);
            }

            if (_economicDataDict[periodInfo].Data.Bea == null)
            {
                _economicDataDict[periodInfo].Data.Bea = new();
            }
            _economicDataDict[periodInfo].Data!.Bea!.PersonalIncome = record.DataValue;
        }

        return this;
    }

    public DataOutput AddBlsUnemploymentData(List<BlsMonthlyUnemploymentRecord> blsUnemploymentRecords)
    {
        foreach (var record in blsUnemploymentRecords)
        {
            PeriodInfo periodInfo = record.GetPeriodInfo();
            if (!_economicDataDict.ContainsKey(periodInfo))
            {
                _economicDataDict[periodInfo] = new(periodInfo.Year, periodInfo.PeriodType, periodInfo.Period, periodInfo.PeriodLabel);
            }

            if (_economicDataDict[periodInfo].Data.Bls == null)
            {
                _economicDataDict[periodInfo].Data.Bls = new();
            }
            _economicDataDict[periodInfo].Data!.Bls!.UnemploymentData = record.Value;
        }

        return this;
    }


    public DataOutput AddBlsGasolinePriceData(List<BlsMonthlyGasolinePriceRecord> blsGasPriceRecords)
    {
        foreach (var record in blsGasPriceRecords)
        {
            PeriodInfo periodInfo = record.GetPeriodInfo();
            if (!_economicDataDict.ContainsKey(periodInfo))
            {
                _economicDataDict[periodInfo] = new(periodInfo.Year, periodInfo.PeriodType, periodInfo.Period, periodInfo.PeriodLabel);
            }

            if (_economicDataDict[periodInfo].Data.Bls == null)
            {
                _economicDataDict[periodInfo].Data.Bls = new();
            }
            _economicDataDict[periodInfo].Data!.Bls!.Gasoline = record.Value;
        }

        return this;
    }

    public DataOutput AddBlsElectricityPriceData(List<BlsMonthlyElectricityPriceRecord> blsElectricityPriceRecords)
    {
        foreach (var record in blsElectricityPriceRecords)
        {
            PeriodInfo periodInfo = record.GetPeriodInfo();
            if (!_economicDataDict.ContainsKey(periodInfo))
            {
                _economicDataDict[periodInfo] = new(periodInfo.Year, periodInfo.PeriodType, periodInfo.Period, periodInfo.PeriodLabel);
            }

            if (_economicDataDict[periodInfo].Data.Bls == null)
            {
                _economicDataDict[periodInfo].Data.Bls = new();
            }
            _economicDataDict[periodInfo].Data!.Bls!.Electricity = record.Value;
        }

        return this;
    }

    public DataOutput AddBlsCpiData(List<BlsQuarterlyCpiRecord> blsCpiRecords)
    {
        foreach (var record in blsCpiRecords)
        {
            PeriodInfo periodInfo = record.GetPeriodInfo();
            if (!_economicDataDict.ContainsKey(periodInfo))
            {
                _economicDataDict[periodInfo] = new(periodInfo.Year, periodInfo.PeriodType, periodInfo.Period, periodInfo.PeriodLabel);
            }

            if (_economicDataDict[periodInfo].Data.Bls == null)
            {
                _economicDataDict[periodInfo].Data.Bls = new();
            }
            _economicDataDict[periodInfo].Data!.Bls!.Cpi = record.Value;
        }

        return this;
    }

    public DataOutput AddSP500Data(List<StockIndexMonthlyResultRecord> sp500Records)
    {
        foreach (var record in sp500Records)
        {
            PeriodInfo periodInfo = record.GetPeriodInfo();
            if (!_economicDataDict.ContainsKey(periodInfo))
            {
                _economicDataDict[periodInfo] = new(periodInfo.Year, periodInfo.PeriodType, periodInfo.Period, periodInfo.PeriodLabel);
            }

            if (_economicDataDict[periodInfo].Data.StockIndexes == null)
            {
                _economicDataDict[periodInfo].Data.StockIndexes = new();
            }
            _economicDataDict[periodInfo].Data!.StockIndexes!.Sp500 = record.LastClose;
        }

        return this;
    }

    public DataOutput AddDowJonesData(List<StockIndexMonthlyResultRecord> dowJonesRecords)
    {
        foreach (var record in dowJonesRecords)
        {
            PeriodInfo periodInfo = record.GetPeriodInfo();
            if (!_economicDataDict.ContainsKey(periodInfo))
            {
                _economicDataDict[periodInfo] = new(periodInfo.Year, periodInfo.PeriodType, periodInfo.Period, periodInfo.PeriodLabel);
            }

            if (_economicDataDict[periodInfo].Data.StockIndexes == null)
            {
                _economicDataDict[periodInfo].Data.StockIndexes = new();
            }
            _economicDataDict[periodInfo].Data!.StockIndexes!.DowJones = record.LastClose;
        }

        return this;
    }

    public DataOutput AddNasdaqData(List<StockIndexMonthlyResultRecord> nasdaqRecords)
    {
        foreach (var record in nasdaqRecords)
        {
            PeriodInfo periodInfo = record.GetPeriodInfo();
            if (!_economicDataDict.ContainsKey(periodInfo))
            {
                _economicDataDict[periodInfo] = new(periodInfo.Year, periodInfo.PeriodType, periodInfo.Period, periodInfo.PeriodLabel);
            }

            if (_economicDataDict[periodInfo].Data.StockIndexes == null)
            {
                _economicDataDict[periodInfo].Data.StockIndexes = new();
            }
            _economicDataDict[periodInfo].Data!.StockIndexes!.Nasdaq = record.LastClose;
        }

        return this;
    }

    public DataOutput Finalize()
    {
        EconomicData = _economicDataDict.Values.OrderBy(x => x.Year).ThenBy(x => x.PeriodNum).ThenBy(x => x.PeriodType).ToList();
        return this;
    }

    public string ToJson()
    {
        return JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
    }
}
