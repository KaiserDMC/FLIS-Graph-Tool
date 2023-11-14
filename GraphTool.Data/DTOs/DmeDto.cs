namespace GraphTool.Data.DTOs;

using Newtonsoft.Json;

public class DmeDto
{
    [JsonProperty("Station")]
    public string StationName { get; set; } = null!;

    [JsonProperty("Facility")]
    public string FacilityType { get; set; } = null!;

    [JsonProperty("Ident")]
    public string Ident { get; set; } = null!;

    [JsonProperty("Periodicity")]
    public int Periodicity { get; set; }

    [JsonProperty("TypeDME")]
    public string? TypeDme { get; set; }

    [JsonProperty("NoofTxDME")]
    public int NumberTxDme { get; set; }

    [JsonProperty("DMEFrequency")]
    public string VorDmeFrequency { get; set; } = null!;

    [JsonProperty("DMEProcedure")]
    public string Procedure { get; set; } = null!;

    [JsonProperty("NationalRegulation")]
    public string NationalRegulation { get; set; } = null!;

    [JsonProperty("InternationalStandard")]
    public string InternationalStandard { get; set; } = null!;

    [JsonProperty("Country")]
    public string Country { get; set; } = null!;
}