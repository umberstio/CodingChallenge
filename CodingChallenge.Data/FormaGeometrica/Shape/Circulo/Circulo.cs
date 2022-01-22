using System;


namespace CodingChallenge.Data.FormaGeometrica
{
    public class Circulo : ICirculoCalculable
    {
        public decimal Diametro { get; }

        public Circulo(decimal diametro)
        {
            Diametro = diametro;
        }

        public  decimal CalcularArea() => (decimal)Math.PI * (Diametro / 2) * (Diametro / 2);

        public  decimal CalcularPerimetro() => (decimal)Math.PI * Diametro;

    }
}
