using System;


namespace CodingChallenge.Data.FormaGeometrica
{
    public class TrianguloEquilatero : IFiguraAnchoCalculable
    {
        public decimal Ancho { get; }

        public TrianguloEquilatero(decimal ancho)
        {
            Ancho = ancho;
        }

        public decimal CalcularArea() => ((decimal)Math.Sqrt(3) / 4) * Ancho * Ancho;

        public decimal CalcularPerimetro() => Ancho * 3;
    }
}