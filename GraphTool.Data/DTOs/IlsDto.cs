namespace GraphTool.Data.DTOs;

using Newtonsoft.Json;

public class IlsDto
{
    [JsonProperty("Station")]
    public string StationName { get; set; } = null!;

    [JsonProperty("ICAOEncode")]
    public string IcaoEncode { get; set; } = null!;

    [JsonProperty("Runway")]
    public string Runway { get; set; } = null!;

    [JsonProperty("Facility")]
    public string FacilityType { get; set; } = null!;

    [JsonProperty("Ident")]
    public string Ident { get; set; } = null!;

    [JsonProperty("Category")]
    public string Category { get; set; } = null!;

    [JsonProperty("LOCClass")]
    public string LocClass { get; set; } = null!;

    [JsonProperty("OffsetAngle")]
    public int OffsetAngle { get; set; }

    [JsonProperty("RunwayLength")]
    public double RunwayLength { get; set; }

    [JsonProperty("LocaliserBackset")]
    public double LocaliserBackset { get; set; }

    [JsonProperty("GPBackset")]
    public double GpBackset { get; set; }

    [JsonProperty("DMEBackset")]
    public double DmeBackset { get; set; }

    [JsonProperty("Periodicity")]
    public int Periodicity { get; set; }

    [JsonProperty("LocTxType")]
    public string LocTxType { get; set; } = null!;

    [JsonProperty("TypeLoc")]
    public string? TypeLoc { get; set; }

    [JsonProperty("TypeGP")]
    public string? TypeGp { get; set; }

    [JsonProperty("TypeDME")]
    public string? TypeDme { get; set; }

    [JsonProperty("NoofTxLoc")]
    public int NumberTxLoc { get; set; }

    [JsonProperty("NoofTxGP")]
    public int NumberTxGp { get; set; }

    [JsonProperty("NoofTxDME")]
    public int NumberTxDme { get; set; }

    [JsonProperty("LocFrequency")]
    public string LocFrequency { get; set; } = null!;

    [JsonProperty("GPFrequency")]
    public string GpFrequency { get; set; } = null!;

    [JsonProperty("NominalLocWidth")]
    public double NominalLocWidth { get; set; }

    [JsonProperty("NominalGPAngle")]
    public double NominalGpAngle { get; set; }

    [JsonProperty("GPAzimuthOffset")]
    public int GpAzimuthOffset { get; set; }

    [JsonProperty("ILSProcedure")]
    public string Procedure { get; set; } = null!;

    [JsonProperty("NationalRegulation")]
    public string NationalRegulation { get; set; } = null!;

    [JsonProperty("InternationalStandard")]
    public string InternationalStandard { get; set; } = null!;

    [JsonProperty("VGSINomAngle")]
    public double? VgsiNomAngle { get; set; }

    [JsonProperty("VGSIBackset")]
    public double? VgsiBackset { get; set; }

    [JsonProperty("VGSIHeight(m)")]
    public double? VgsiHeight { get; set; }

    [JsonProperty("PAPIProcedure")]
    public string PapiProcedure { get; set; } = null!;

    [JsonProperty("NationalRegulation1")]
    public string NationalRegulationPapi { get; set; } = null!;

    [JsonProperty("InternationalStandard1")]
    public string InternationalStandardPapi { get; set; } = null!;

    [JsonProperty("Country")]
    public string Country { get; set; } = null!;

    [JsonProperty("BPClearancePoint")]
    public string BpClearancePoint { get; set; } = null!;
}