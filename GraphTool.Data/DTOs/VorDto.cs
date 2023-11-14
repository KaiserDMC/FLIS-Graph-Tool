namespace GraphTool.Data.DTOs;

using Newtonsoft.Json;

public class VorDto
{
    [JsonProperty("Station")]
    public string StationName { get; set; } = null!;

    [JsonProperty("Facility")]
    public string FacilityType { get; set; } = null!;

    [JsonProperty("Ident")]
    public string Ident { get; set; } = null!;

    [JsonProperty("Periodicity")]
    public int Periodicity { get; set; }

    [JsonProperty("TypeVOR")]
    public string? TypeVor { get; set; }

    [JsonProperty("TypeDME")]
    public string? TypeDme { get; set; }

    [JsonProperty("NoofTxVOR")]
    public int NumberTxVor { get; set; }

    [JsonProperty("NoofTxDME")]
    public int NumberTxDme { get; set; }

    [JsonProperty("VOR/DMEFrequency")]
    public string VorDmeFrequency { get; set; } = null!;

    [JsonProperty("MagVar")]
    public string MagVar { get; set; } = null!;

    [JsonProperty("VOR/DMEProcedure")]
    public string Procedure { get; set; } = null!;

    [JsonProperty("NationalRegulation")]
    public string NationalRegulation { get; set; } = null!;

    [JsonProperty("InternationalStandard")]
    public string InternationalStandard { get; set; } = null!;

    [JsonProperty("Country")]
    public string Country { get; set; } = null!;
}