namespace CodingChallenge.Data.FormaGeometrica
{
    public interface IResultado
    {
        decimal Area { get; set; }
        int Cantidad { get; set; }
        string Tipo { get; set; }
        decimal Perimetro { get; set; }
    }
}