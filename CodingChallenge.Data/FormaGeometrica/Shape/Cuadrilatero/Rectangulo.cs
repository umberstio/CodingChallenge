
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.FormaGeometrica
{
    public class Rectangulo : ICuadrilateroCalculable
    {
        public decimal Izquierda { get; }

        public decimal Derecha { get; }

        public decimal BaseSuperior { get; }

        public decimal BaseInferior { get; }

        public Rectangulo(decimal alto, decimal ancho)
        {
            Izquierda = alto;
            Derecha = alto;
            BaseSuperior = ancho;
            BaseInferior = ancho;
        }
        public decimal CalcularArea() => Izquierda * BaseInferior;

        public decimal CalcularPerimetro() => (2 * Izquierda) + (2 * BaseInferior);

    }
}
