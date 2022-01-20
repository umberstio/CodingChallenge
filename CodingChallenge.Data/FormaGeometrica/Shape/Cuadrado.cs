using System;


namespace CodingChallenge.Data.FormaGeometrica
{
    public class Cuadrado : IFiguraAnchoCalculable
    {
        public decimal Ancho { get; }

        public Cuadrado(decimal ancho)
        {
            Ancho = ancho;
        }

        public  decimal CalcularArea() => Ancho * Ancho;

        public  decimal CalcularPerimetro() => Ancho * 4;
    }
}
