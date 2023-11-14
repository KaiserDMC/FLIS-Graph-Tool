namespace GraphTool.Data.Models;

public class Dme
{
    public string StationName { get; set; } = null!;

    public FacilityType FacilityType { get; set; }

    public string Ident { get; set; } = null!;

    public int Periodicity { get; set; }

    public string? TypeDme { get; set; }

    public int NumberTxDme { get; set; }

    public string Frequency { get; set; } = null!;

    public string Country { get; set; } = null!;
}