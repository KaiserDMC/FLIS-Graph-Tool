namespace GraphTool.Data.Models;

public class Ils
{
    public string StationName { get; set; } = null!;

    public string IcaoEncode { get; set; } = null!;

    public string Runway { get; set; } = null!;

    public FacilityType FacilityType { get; set; }

    public string Ident { get; set; } = null!;

    public string Category { get; set; } = null!;

    public string LocClass { get; set; } = null!;

    public int OffsetAngle { get; set; }

    public double RunwayLength { get; set; }

    public double LocaliserBackset { get; set; }

    public double GpBackset { get; set; }

    public double DmeBackset { get; set; }

    public int Periodicity { get; set; }

    public string LocTxType { get; set; } = null!;

    public string? TypeLoc { get; set; }

    public string? TypeGp { get; set; }

    public string? TypeDme { get; set; }

    public int NumberTxLoc { get; set; }

    public int NumberTxGp { get; set; }

    public int NumberTxDme { get; set; }

    public string LocFrequency { get; set; } = null!;

    public string GpFrequency { get; set; } = null!;

    public double NominalLocWidth { get; set; }

    public double NominalGpAngle { get; set; }

    public int GpAzimuthOffset { get; set; }

    public double? VgsiNomAngle { get; set; }

    public double? VgsiBackset { get; set; }

    public double? VgsiHeight { get; set; }

    public string Country { get; set; } = null!;

    public string BpClearancePoint { get; set; } = null!;
}