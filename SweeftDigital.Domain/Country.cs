namespace SweeftDigital.Domain;

public sealed class Country
{
    public string? Region { get; set; }
    public string? Subregion { get; set; }
    public double[]? Latlng { get; set; }
    public double Area { get; set; }
    public int Population { get; set; }
}