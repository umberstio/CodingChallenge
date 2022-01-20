using System;


namespace CodingChallenge.Data.FormaGeometrica
{
    public class Circulo : IFiguraAnchoCalculable
    {
        public decimal Ancho { get; }

        public Circulo(decimal ancho)
        {
            Ancho = ancho;
        }

        public  decimal CalcularArea() => (decimal)Math.PI * (Ancho / 2) * (Ancho / 2);

        public  decimal CalcularPerimetro() => (decimal)Math.PI * Ancho;

    }
}
