using System;


namespace CodingChallenge.Data.FormaGeometrica
{
    public class TrianguloEquilatero : ITrianguloCalculable
    {
        public decimal Base { get; }
        public decimal Izquierda { get; }
        public decimal Derecha { get; }

        public TrianguloEquilatero(decimal ancho)
        {
            Base = ancho;
            Izquierda = ancho;
            Derecha = ancho;
        }

        public decimal CalcularArea() => ((decimal)Math.Sqrt(3) / 4) * Base * Base;

        public decimal CalcularPerimetro() => Base * 3;
    }
}