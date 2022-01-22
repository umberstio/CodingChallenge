using System;


namespace CodingChallenge.Data.FormaGeometrica
{
    public class Cuadrado : ICuadrilateroCalculable
    {
        public decimal Izquierda { get; }
        public decimal Derecha { get; }
        public decimal BaseSuperior { get; }
        public decimal BaseInferior { get; }

        public Cuadrado(decimal ancho)
        {
            Izquierda = ancho;
            Derecha = ancho;
            BaseSuperior = ancho;
            BaseInferior = ancho;
        }

        public decimal CalcularArea() => BaseSuperior * BaseSuperior;

        public decimal CalcularPerimetro() => BaseSuperior * 4;
    }
}
