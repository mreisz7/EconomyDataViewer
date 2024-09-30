﻿using EconomyDataLoader.Utilities;
using System.Text.Json.Serialization;

namespace EconomyDataLoader.Models.BLS;

public class BlsMonthlyElectricityPriceRecord
{
    // Seasonally Adjusted Unemployment Rate
    // https://data.bls.gov/dataViewer/view/timeseries/APU000072610

    [JsonPropertyName("year")]
    public string Year { get; set; } = string.Empty;

    [JsonPropertyName("period")]
    public string Period { get; set; } = string.Empty;

    [JsonPropertyName("periodName")]
    public string PeriodName { get; set; } = string.Empty;

    [JsonPropertyName("value")]
    [JsonConverter(typeof(StringToFloatConverter))]
    public float Value { get; set; }

}
